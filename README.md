# _To Do List_

#### By _**Jessi Baker**_

#### _Hair Salon - Epicodus - C# and .NET - Database Basics - Code Review_

## Technologies Used

* GIT
* C#
* ASP.NET MVC
* MySQL
* Entity Framework
* LINQ

## Description

This is a MVC web application to help a salon manage their stylists and their clients. User will be able to add a list of stylists working at the salon & for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see a single stylist. Specifically, the user will be able to add new stylists to the system when they are hired; add new clients to a specific stylist; clients must have a stylist in order to be added; see a list of all stylists; select a stylist, see their details, and see a list of all clients that belong to that stylist.

## Setup/Installation Requirements

* This web app uses MySQL as a database.  Directions for install & account setup see _https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql_
* Go to _https://github.com/jessb-epicodus/HairSalon.git_
* Cone this repository to your desktop (or other desired location)
* Navigate to the top level of the project directory called _HairSalon_
* Enter the following in your terminal to add required packages:
  * _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_
  * _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_
  * _dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0_
* To access the database, a _MYSQL_ login & password is required.
* Still in the project directory, add a file, _appsettings.json_.  Add the following code to that file & fill in your password as designated
  _{_
    _"ConnectionStrings": {_
        _"DefaultConnection": "Server=localhost;Port=3306;database=jessi_baker;uid=root;pwd=YOUR-PASSWORD-HERE;"_
    _}_
  _}_
* Protect your password by adding _*/appsettings.json_ to your .gitignore
* From the project directory install dependeciey by entering _dotnet restore_ in your terminal
* To try out this web app enter _dotnet run_ in the command line to use this app
* _This is not yet published._

## Known Bugs

* Clients listed on stylist detail page are dislpayed as actionlinks with no endpoint
* Lacks clear error handling / validation in requiring a stylist before adding a client

## License

Copyright (c) _Mar 2022_ _Jessi Baker_

## Contact

_If you run into any issues or have questions, ideas or concerns or wish to make a contribution to the code see contact information below._
* Jessi Baker <jessb.epicodus@gmail.com>