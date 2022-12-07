![ETSU logo](/ReadMeSupport/East_Tennessee_State_University_Logo.jpg)

# BucHunt
>Information about this project

* The purpose of this project is to create a scavanger hunt game for students at East Tenneessee State University.

* This project is set to spand multiple semesters in production and will be used as a learning tool for students in the Software Engineering I course at ETSU.

* This project will be handed down to a new class each semester where more features will be added until the ideal product is created for Mr. Kinser to present to ETSU's board of directors.

* The final goal is to not only have a working product by the end of this project's lifecycle but to also give students the experience and knowledge of what it is like working as part of a scrum team.  The hope is that each student in the course will gain an understanding of what software engineering is and some of the key conepts that go into it.

## Before Reading Notes
>Infomration about the documentation for the first semester's class iteration of the project

This first BucHunt project iteration is designed/implemented by Team 3 (404 Industries) in the Fall 2022, Software Engineering I course.

>This document will contain the following information to help guide future classes on what Team 3 accomplished as well as what was not accomplished
* Dos and Dont's that were discovered in the design, implementation, and testing phases for this iteration of the project.
* Database Set Up
* Code Review
* Server Set Up 
* Notes made by students for student during the implementation phase for this project
* Outside resources that have been gathered to help future classes 

>Team 3's deffinition of done for this project
1. Meet minimum requirments of each task
2. Reviewed by other team members
3. Follows code & UI/UX standards
4. Tested
5. Committed
6. Code review - optional 

# Git Hub Information
>Source Control
>We have a dev and a prd branch on Github. The prd branch has basic limitations to prevent anyone from pushing to that branch without a pull request, which will need to be reviewed by at least one person.
### When working on a new feature
* Branch off dev
* Follow basic naming conventions ( Feature/<descriptive name of what you are working on> ) 
### When feature is ready to merge
* First, pull dev into feature branch - That way we can handle merge conflicts in feature branch.
* Then, create pull request 
* Please get someone other than yourself to look at the code - Make sure all functionality is still present after you pull from dev.
* Get Pull Request approved, continue with merge
* Delete branch, if necessary 
### When dev branch is ready for merge
* Pull prd into dev, handle any merge conflicts 
* Create Pull Request - Will be required to be reviewed.
* Get approval 
  
# Getting Started
>Initial setup and path that Team 3 took to complete this iteration of the Buc Hunt project

### Developer Enviroments
* Trello - To keep track of user stories as well as what tasks people on team are doing, what tasks are in progress, and what tasks have been completed.
* GitHub - Online software development platform where the code for this project was kept and maintained.
* VS studio - A standalone source code editor that runs on Windows, macOS, and Linux machines.
### Framework
* Model-View Controller - A software design that is commonly used to implement user interfaces, data, and contorlling logic.
### Tech Stack
* .Net 6.0, entity framework
### Coding Languages
* C#
* HTML
* SQL

# UI/Code Standards
## UI Standards
>Below are the standards for the userinterface for this project
* Mobile-first approach - Designs started out for mobile devices first
* 3-click rule - Have the user find what they are looking for in no less than 3 clicks
* User accessability - User must be able to have easy access of the cite
* User-friendly - Project needs to have a user first design in mind.  This means that the user must be able to have an easily understandable interface
## Coding Standards
>The standards for this project follow ETSU's Computing Department's coding standards.
>Standards that are refereneced come from the CSCI 1250 Itroduction to Computer Science Coding Standards pdf file [Download](/ReadMeSupport/CodingStandards.pdf)
### FILE
>Each FILE (class and interface definition) should begin with a preface of comments

![File Image](/ReadMeSupport/FILE_Coding_Standard.png)

### CLASS
>Each CLASS should begin with a preface of comments

![Class Image](/ReadMeSupport/Class_Coding_Standard.png)

### METHOD
>Each METHOD definition should have a preface of comments describing the method's purpose, it's parameters, and what it returns

![Method Image](/ReadMeSupport/Method_Coding_Standard.png)

## General Commenting Coding Standards
>The following is this list of standards used for commenting in general for this project
### Identifier naming conventions
* Constants are declared as public static members of the class, are UPPERCASE, and if the constant has
multiple terms, an underscore is used to separate them.
* Variables are declared before use, are lowercase, and if a variable contains multiple terms, each new term
begin with a capitalized letter. 
* Class names always begin with UPPERCASE letter and must match the filename. If the name contains
multiple terms then each term begins with an UPPERCASE letter.
### Punctuation and White Space
* Do not use a preceding or a trailing underscore in identifier names.
* Put each curly brace ({ and }) on separate lines.
* Each pair of corresponding curly braces should be aligned.
* When a statement is continued from one line to another, indent the continued line(s).
* Indent each CONSTANT declaration and each variable declaration, placing them on separate lines

# Database 
>Microsoft SQL was used for handling the database 
  
## [Download](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) SQL Server Management Studio (SSMS)

### Login for the server
* If you have an Active Directory domain configured, and the user is on a computer joined to the domain, you can add their domain credentials to the SQL server and they will be able to use the Windows login to connect to the server.

* However, in Fall 2022, we do not have a domain configured. That would require students to join their computers to the domain any way. To get around that, you can create SQL Login Credentials for the users that need to access the database. You can set the permissions for each user and control their access to databases and other controls.
  
### Database Tutorial
1. Right-click the Server name in the Object explorer > Select properties
  
![Image](/ReadMeSupport/ServerLogin.png)

2. Under Security, enable "SQL Server and Windows Authentication." Set the Auditing to the level of your choosing.
![Server Security](/ReadMeSupport/ServerSecurity.png)
  
3. Restart the server. You should now be able to login to the SQL server from SSMS on a different device.

### Change Firewall Rules to SQL Connections
1. Determine what Firewall Profile is currently running, unless the server is connected to a domain, it is probably a public profile.
2. Control Panel > All Control Panel Items > Windows Defender Firewall. Note how the Public network is the connected one.
  
![Fire Walls](/ReadMeSupport/Firewalls.png)

3. Select Advanced settings on the left side of window. This will open "Windows Defender Firewall with Advanced Security." Select inbound rules.
  
4. Enable the following rules. Note that there are two rules with the same name. One for UDP ports and one for TCP ports. Also note the network profile of the rule.
  
![ServerTCP](/ReadMeSupport/ServerTCP.png)
  
5. If these rules do not exist, you can add a new inbound rule to allow connections on port 1433 (default SQL port).
  
# Creating/Modifying Server Accounts
>The link below will take you to the corect documentation.  Just download raw.
 
## [Download](/ReadMeSupport/Documentation-RDPUserAccounts.docx) documentation for creating/modifying server accounts.

# Code Deployment
## Installations
1. Edge 

2. Visual Studio (.NET 6)

3. Git -  Set up Powershell to automatically have all git commands.
 

## Setting up website
1. From the server, use VS to build release solution.

2. Assign the physical path of the website to the release folder.

![Physical Path](/ReadMeSupport/PhysicalPath.png)

3. Be sure to add IIS_IUSRS to the main folder the code is stored in.

* [Troubleshoot](https://learn.microsoft.com/en-us/troubleshoot/developer/webapps/iis/health-diagnostic-performance/http-error-500-19-webpage)

![DEV Properties](/ReadMeSupport/DEVProperties.png)  

* When changing site over, make sure you change the physical path to the correct folder – within the release folder.

![Edit Site](/ReadMeSupport/EditSite.png) 

![FileTree](/ReadMeSupport/FileTree.png) 

4. With those steps, you should be able to run website 
* [Host Website](https://www.guru99.com/deploying-website-iis.html) 

* Advanced settings of one of the DEV website below.

<img src="/ReadMeSupport/AdvancedSettings.png" width=75% height=75%>  

* For this iteration to connect to website use 151.141.91.45 click [here](http://151.141.91.45/) to go to website
  
# Web Page Design
>The diagram below illustrates the BucHunt web page basic layout and flow.
<img src="/ReadMeSupport/GetImage.png" width=50% height=50%>  
  

# Code Review
>Below will be coding topics that were found to be essential for the project to function.
## Collecting user input
* You can use a message box in the html file for the front end to allow the user to put in input.
* In order for us to use this information we have to reference the model that we want the user input to be associated with, at the top of the file do @(Model Name).
>Below is the code for collecting this input all we have to do is reference the field we wish the input to be for

<img src="/ReadMeSupport/UserInput.PNG" width=50% height=50%> 

## Validating input
* Validating the user input is important for this project because if a user inputs a invalid code they should not be given access to the game.
* For validating the access codes inputted by the users setting the field to be required as well as setting the maximum length of the property can be done as shown   below 

<img src="/ReadMeSupport/Validation1.png" width=65% height=65%> 
>Side Note:  It is possible to add a regular expression which will only allow for integers to be accepted into the text box. 

*Inside the JoinHunt.cshtml file validation can be done with a simple if looking to see if the TempData value is null.
  
<img src="/ReadMeSupport/Validation2.png" width=65% height=65%>
  
* Example below is if the TempData is null
  
<img src="/ReadMeSupport/Validation3.png" width=65% height=65%>

* Example below is if the TempData is not null

<img src="/ReadMeSupport/Validation3.png" width=65% height=65%>

* The Code that handles the validation and will store the message in the TemData is located in the model for the Hunt.
* Works by taking the access code input and running a foreach loop comparing the input with the access codes stored in a list pulled from the database. 
  
<img src="/ReadMeSupport/Validation.PNG" width=65% height=65%> 

## Notification Service
>This section will cover how the access codes can be sent to users' mobile devices through text or email
>The article that covers this is [here](https://avtech.com/articles/138/list-of-email-to-sms-addresses/)

* A gmail account was created for the team where all emails and texts will be routed from
** Calling the NotificationService constructor will set up the Smtp client with the following
* Host = "smtp.gmail.com"
* Port = 587 
* EnableSsl = true 
* DeliveryMethod = SmtpDeliveryMethod.Network 
* UseDefaultCredentials = false
* Credentials = new NetworkCredential("404IndustriesETSU@gmail.com", "npsovbvygcqovxxg")dw 
** SendEmail Method

<img src="/ReadMeSupport/Services1.png" width=75% height=75%>
 
** SendText

<img src="/ReadMeSupport/Services2.png" width=75% height=75%> 



# Remote Desktop Server Access
1. Remote Desktop Protocol (RDP) is a Windows tool that allows you to remotely access servers and computers. By default, Windows only allows 2 RDP connections at a time. On Windows Servers, you can install the Remote Desktop Licensing service to allow more than 2 RDP connections. RDP Licensing is free for 120 days, after that it will expire. Remote Desktop Licensing will expire on February 28th, 2023. ETSU does not have a licensing server at this time.
  
2. To connect to the server, open Remote Desktop on a Windows computer. Note you must be on the ETSU network (Wi-Fi or hardwired). Click "Show Options." Note that you can save the RDP connection as an RDP file.  
  
3. Enter the hostname: FALL22-4250-1-3.etsu.edu. IPv4 address at the time of this writing: 151.141.91.45. Enter your credentials for the server.

![Remote Server](/ReadMeSupport/RemoteServer.png) 
  
4. Please note that only one person can use one set of credentials at a time. If someone else logs in with the same credentials, it will kick off the original user.  

# Notes for future team
* For access codes either use E number or Phone number - This was found to be more reliable than a random number generator
* Document as you code for it makes it easier to follow what a team member did
* Keep note of the scrum process as you conduct your team meetings - Meaning make sure you follow the correct steps
* Have a presentable product at every Sprint review, do NOT have just pieces of the project working on multiple machines
* Remeber the project is also about learning so take notes of the steps you take 
* Having an hour meeting before class is a good way to go over the expected hours of work
* Build a local database so you can run code on your local machine at home
* Set up gitignore early - First thing you should do 

# Resources/References
[MVC Tutorial](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-6.0)

[Latitude Longitude Finder](https://www.latlong.net/)

[Hosting Website on ISS](https://www.guru99.com/deploying-website-iis.html)

[Connect and querry SQL Server](https://learn.microsoft.com/en-us/sql/ssms/quickstarts/ssms-connect-query-sql-server?view=sql-server-ver16)

[SQL Tutorial Video](https://www.youtube.com/c/AlexTheAnalyst/videos)

[Intro to working with Database](https://learn.microsoft.com/en-us/aspnet/web-pages/overview/data/5-working-with-data)

[Connection String and Working with SQL Server](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/creating-a-connection-string)

[Nine Options for Managing Persistent User State](https://learn.microsoft.com/en-us/archive/msdn-magazine/2003/april/nine-options-for-managing-persistent-user-state-in-asp-net)

[Session Variables](https://stackoverflow.com/questions/14138872/how-to-use-sessions-in-an-asp-net-mvc-4-application)

[Gitignore](https://stackoverflow.com/questions/19663093/apply-gitignore-on-an-existing-repository-already-tracking-large-number-of-file)

[Entity Framework Core](https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx)

[QR Code Optional Read (Some PG-13 language)](https://www.reddit.com/r/programming/comments/yyrsjr/the_basics_of_how_qr_codes_work/?utm_source=share&utm_medium=ios_app&utm_name=iossmf)

[HTTP Error 500.19 Services](https://learn.microsoft.com/en-us/troubleshoot/developer/webapps/iis/health-diagnostic-performance/http-error-500-19-webpage)

[Troubleshotting](https://learn.microsoft.com/en-us/answers/questions/531547/nuget-packages-has-offline-only.html)


# Outside Help
>Robert Nielson
