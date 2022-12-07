/**
* --------------------------------------------------------------------------- 
* File name: Task.cs
* Project name: 404 Industries BucHunt
* --------------------------------------------------------------------------- 
* Author’s name and email: Dante Hays, haysdc@etsu.edu
* Creation Date: Nov 09, 2022
* Last modified: Dante Hays haysdc@etsu.edu Nov 10, 2022
* --------------------------------------------------------------------------- 
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Team_3_BucHunt_WebApp.Models;

/**
* Class Name: Task <br>
* Class Purpose: The data model for the Task object should only reflect the corresponding table in the database<br>
* <hr>
* Date created: Nov 09, 2022 <br>
* Date last modified: Nov 10, 2022 
* @author Dante Hays
*/
public partial class Task
{
    public int TaskId { get; set; }

    public int LocationId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    /// <summary>
    /// Base constructor for Task class
    /// </summary>
    public Task()
    {

    }


    /// <summary>
    ///  Constructor for the Task class
    /// </summary>
    /// <param name="taskId"></param>
    /// <param name="locationId"></param>
    /// <param name="question"></param>
    /// <param name="answer"></param>
    public Task(int taskId, int locationId, string? question, string? answer)
    {
        TaskId = taskId;
        LocationId = locationId;
        Question = question;
        Answer = answer;
    }
}  //End public partial class Task
