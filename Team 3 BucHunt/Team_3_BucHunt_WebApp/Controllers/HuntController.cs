﻿/**
* --------------------------------------------------------------------------- 
* File name: HuntController.cs
* Project name: 404 Industries BucHunt
* --------------------------------------------------------------------------- 
* Author’s name and email: Dante Hays, haysdc@etsu.edu
* Creation Date: Nov 01, 2022
* Last modified: Dante Hays haysdc@etsu.edu Nov 02, 2022
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
* Date last modified: Nov 02, 2022 
* @author Dante Hays
*/

public class HuntController : Controller
{
    public Models.User user = new Models.User();
    private readonly List<Models.User> allUsers;
    //public Models.Task task = new Models.Task();
    //private BucHuntContext db = new BucHuntContext();
    //List<User> teams = new List<User>();
    //List<List<User>> teamList = new List<List<User>>();


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
        allUsers = _context.Users.ToList(); //initializing this here allows for the same functionality as calling it in the Index method below
                                            //db call every time -- possibly tied to the page reloading after the button is hit
                                            
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
        return View();
    }

    /// <summary>
    /// Returns Hunt page if code is correct will redirect if incorrect and will display invalid code.
    /// </summary>
    /// 
    /// NOTES: These should probably 
    /// 
    /// <param name="user"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Index(User user)
    {
        //List<Models.User> allUsers = _context.Users.ToList();
        //user.OpenDB(); //Generates the list of Users from the database
        //task.OpenDB(); //Generates the list of Tasks from the database
        bool correct = false;
        

        foreach (User u in allUsers)
        {
            if (user.AccessCode == u.AccessCode)
            {
               
                correct = true; 
                break;
            }
        }
        if (correct)
        {
            List<Models.Task> taskList = _context.Tasks.ToList();
            ViewBag.taskList = taskList;
            return View();
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
        return View();
    }   //End public IActionResult LeaderBoard()

} //End public class HuntController : Controller


