/**
* --------------------------------------------------------------------------- 
* File name: HuntController.cs
* Project name: 404 Industries BucHunt
* --------------------------------------------------------------------------- 
* Author’s name and email: Dante Hays, haysdc@etsu.edu
* Creation Date: Nov 01, 2022
* Last modified: Janine Day dayjn1@etsu.edu Dec 5, 2022
* --------------------------------------------------------------------------- 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_3_BucHunt_WebApp.Models;


namespace Team_3_BucHunt_WebApp.Controllers;

/**
* Class Name: HuntController <br>
* Class Purpose: Holds the logic for the Hunt page<br>
* <hr>
* Date created: Oct 27, 2022 <br>
* Date last modified: Dec 01, 2022 
* @author Dante Hays
*/

public class HuntController : Controller
{
    public Models.User user = new Models.User();
    //Hannah's code
    private readonly List<Models.User> allUsers;
    private readonly List<Models.Task> taskList;
    private readonly List<Models.Location> locations;
   


    /* This is used to create a "local" connection to the 
       database that can be reused for different purposes.
        it takes advantage of the database connection string in
        the appsettings.json file and the builder.Services settings
        in the Program.cs file > these settings allow for one connection
        established to the database on load of the project that can be
        called at any point from the controllers using the local var below
        - Hannah*/
    private readonly BucHuntContext _context;

    //nothing is calling this yet, but _context is still getting a connection to the database? - Hannah (I need to remind myself the details of how this works)
    public HuntController(BucHuntContext context)
    {
        _context = context;

        allUsers = _context.Users.ToList(); //initializing this here allows for the same functionality as calling it in the Index method below, but is cleaner since this is the "constructor" for the controller and where global variables are usually initialized - best practice
        taskList = _context.Tasks.ToList(); //db call every time page is loaded, but for now doesn't slow things down too much
        locations = _context.Locations.ToList();                                    
        
    }

    /**
    * Method Name: Index <br>
    * Method Purpose: Returns the view of the Hunt page <br>
    * <hr>
    * Date created: Oct 27, 2022 <br>
    * Date last modified: Nov 03, 2022 <br>
    * <hr>
    * Notes on specifications, special algorithms, and assumptions: N/A
    * <hr> 
    * @returns View()
    */

    [HttpGet]
    public ActionResult Index()
    {
        ViewBag.locations = locations;
    
        ViewBag.taskList = taskList;
            return View(model: HttpContext.Session.GetString("currentUser"));
    }

    /// <summary>
    /// Returns Hunt page if code is correct will redirect if incorrect and will display invalid code.
    /// </summary>
    /// 
    /// NOTES: 
    /// 
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Index(User user)
    {
        
        bool correct = false; //init this to false so we go through validation every time
        ViewBag.taskList = taskList; //tasklist was initialized in the "constructor" and is being passed into a viewbag to render the partial view tasklist page
        ViewBag.locations = locations;
        

        foreach (User u in allUsers)
        {
            if (user.AccessCode == u.AccessCode)
            {
                HttpContext.Session.SetString("currentUser", u.Email);
                correct = true;
                break;
            }
        }
        if (correct)
        {
            
            ViewBag.taskList = taskList;
            return View(model: HttpContext.Session.GetString("currentUser"));

        }
        else
        {

            TempData["Message"] = "Invalid Code";
            return RedirectToAction("JoinHunt", "Home");
        }
    } //End public IActionResult Index()

    /**
    * Method Name: LeaderBoard <br>
    * Method Purpose: Returns the view of the Hunt page <br>
    * <hr>
    * Date created: Nov 15, 2022 <br>
    * Date last modified: Nov 15, 2022 <br>
    * <hr>
    * Notes on specifications, special algorithms, and assumptions: N/A
    * <hr> 
    * @returns View()
    */
    public IActionResult LeaderBoard()
    {
        ViewBag.allUsers = allUsers;
        return View();
    }   //End public IActionResult LeaderBoard()


    /**
    * Method Name: AnswerForm <br>
    * Method Purpose: Returns the view answer form for a question <br>
    * <hr>
    * Date created: Nov 26,2022 <br>
    * Date last modified: Nov 29,2022 <br>
    * <hr>
    * Notes on specifications, special algorithms, and assumptions: N/A
    * <hr> 
    * @returns View()
    */
    public IActionResult AnswerForm(int taskId, bool incorrect)
    {

         string Question = taskList[taskId].Question;
        
        //add functionality to call answerform partial view and
        //check answers (call method below) as entered for each task and keep track of them
        // ie add them to some sort of local data structure or to a table in database

        //(The incorrect bool tracks if they got the question wrong so
         //a message can be displayed accordingly)
         
        return RedirectToAction("_TaskAnswerForm", "Shared");
    }


    /**
    * Method Name: CheckAnswer <br>
    * Method Purpose: Checks a passed answer to see if it is correct <br>
    * <hr>
    * Date created: Nov 26,2022 <br>
    * Date last modified: Dec 5,2022 <br>
    * <hr>
    * Notes on specifications, special algorithms, and assumptions: N/A
    * <hr> 
    * @returns View()
*/
    public IActionResult CheckAnswer(Team_3_BucHunt_WebApp.Models.Task task)
    {       
        string correctAnswer = "";

        foreach(var t in taskList)
        {
            if (t.TaskId == task.TaskId)
                correctAnswer = t.Answer;
        }

        if (task.Answer == correctAnswer)
        {
            TempData["Message"] = "Correct!";
            return RedirectToAction("Index", "Hunt");
        }
        else
        {
            TempData["Message"] = "Incorrect Answer";
            return RedirectToAction("Index", "Hunt");
        }
        
    }

} //End public class HuntController : Controller


