# _Salon Client Tracker_

#### _7/31/2020_

#### By _**Hannah Beinstein**_

## Description

_Salon Client Tracker is an program created to practice MVC web app design and many-to-one relationships. The program contains two classes, one for Employees and one for Stylists. The program can display a list of stylists and their clients (each client is unique to their stylist), and also includes functionality to add and remove both stylist and clients._

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| ** 1. Program will display an error message if no stylists have been added to database | -- | "No stylists have been added yet!" |
| ** 2. Program will add new stylists to database | "add stylist" | "Martha" |
| ** 3. Program will display a list of all stylists | -- | "Jim, Hannah, Michael, Martha" |
| ** 4. Program will display an error message if no clients have been added to database | -- | "This stylist doesn't have any clients yet!" |
| ** 5. Program will add new clients to database | "add client" | "Lisa" |
| ** 6. Program will display a list of all clients belonging to a stylist | Stylist: "Michael" | Clients: "Lisa, Jan, Marcus" |

## Project Setup/Installation Instructions

_Download Project:_
* _Clone or download this repository located at https://github.com/HBeinstein/HairSalon.Solution.
* _Run $ dotnet restore to download all dev dependencies._
* _Run $ dotnet build to create project._
* _The project database can be replicated either by importing the database or by using a SQL Schema Query (see either set of instructions below)._

_Import Database:_
* _Launch MySQLWorkbench or alternate SQL GUI._
* _Navigate to the Administration window and select: "Data Import/Restore"_
* _Under "Import Options", select: "Import from self-contained file"._
* _In the cloned project repository, navigate to the database .sql file and select it._
* _Under "Default schema to be imported to", select the new button, name your database hannah_beinstein, and click OK._
* _Click: "Start Import"._
* _Your new database should now appear within your schemas!_

_Replicating Database using SQL Schema Query:_
* _Launch MySQLWorkbench._
* _Select: "new schema" from the upper menu bar._
* _Name your new schema hannah_beinstein and select "apply"._
* _Copy the schema query below and paste into the SQL script area. Select Apply._
* _Your new database should now appear within your schemas!_
```
DROP DATABASE IF EXISTS `hannah_heinstein`;
CREATE DATABASE `hannah_beinstein`;

USE `hannah_beinstein`;

CREATE TABLE `Clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistId` int(11) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Notes` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `Stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

 
## Known Bugs

_No known bugs_

## Support and contact details

_{Please contact me at hannah.beinstein@gmail.com with any known bugs or support issues!}_

## Technologies Used

* _GitHub_
* _C#_
* _SQL_
* _EFC_

### License

*Copyright (c) 2020 **_Hannah Beinstein MIT License_**