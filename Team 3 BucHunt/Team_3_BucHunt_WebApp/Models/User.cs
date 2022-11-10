﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Team_3_BucHunt_WebApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string PhoneNum { get; set; } = null!; //char

    public string? AccessCode { get; set; }

    public int? HuntId { get; set; }

    public virtual Hunt? Hunt { get; set; }

    public virtual ICollection<Hunt> Hunts { get; } = new List<Hunt>();

  
    SqlCommand command;
    SqlDataReader dataReader;
    String sql = "";
    string connectionString = " ";
    public List<User> usersList = new List<User>(); //Individual person list

    public List<User> teamList = new List<User>(); //Team list


    /// <summary>
    /// Method to open and establish connection to the database
    /// Will generate a list of Users stored on the database
    /// </summary>
    public void OpenDB()
    {
        connectionString = @"Server=FALL22-4250-1-3; Database=BucHunt; User Id=dbaccess; Password=Password1!";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            sql = "SELECT * FROM [BucHunt].[dbo].[Users]";
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                User user = new User(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4));
                usersList.Add(user);
            }
        }
    }


    /// <summary>
    ///  Base constructor for the User class
    /// </summary>
    public User()
    {

    }


    /// <summary>
    ///  Constructor for the User class
    /// </summary>
    /// <param name="id"></param>
    /// <param name="email"></param>
    /// <param name="phone"></param>
    /// <param name="code"></param>
    /// <param name="huntId"></param>
    public User(int id, string email, string phone, string code, int huntId)
    {
        HuntId = id;

        Email = email;

        PhoneNum = phone;

        AccessCode = code;

        HuntId = huntId;
    }



}
