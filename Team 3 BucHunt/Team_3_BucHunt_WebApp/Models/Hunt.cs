/**
* --------------------------------------------------------------------------- 
* File name: Hunt.cs
* Project name: 404 Industries BucHunt
* --------------------------------------------------------------------------- 
* Author’s name and email: Dante Hays, haysdc@etsu.edu
* Creation Date: Nov 09, 2022
* Last modified: Dante Hays haysdc@etsu.edu Nov 10, 2022
* --------------------------------------------------------------------------- 
*/

using System;
using System.Collections.Generic;

namespace Team_3_BucHunt_WebApp.Models;

/**
* Class Name: Hunt <br>
* Class Purpose: The data model for the Hunt object<br>
* <hr>
* Date created: Nov 09, 2022 <br>
* Date last modified: Nov 10, 2022 
* @author Dante Hays
*/
public partial class Hunt
{
    public int HuntId { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public bool? TeamGame { get; set; }

    public virtual ICollection<HuntCode> HuntCodes { get; } = new List<HuntCode>();

    public virtual ICollection<User> UsersNavigation { get; } = new List<User>();

    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    public virtual ICollection<User> Users { get; } = new List<User>();
} //End public partial class Hunt
