# _Animal Shelter_

#### _MySQL & Entity Framework Core Practice for Epicodus_, _Mar. 17 2020_

#### By _**Brandan Sayarath, Zakkrey Short, Geoff Goetz**_

## Description

_This application will allow tracking of current animals in an animal shelter. It will allow creation of a database of animals by species, breed, gender, date of admittance and name._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates instance of an Animal object | Animal newAnimal = new Animal(type, name, breed, gender, date of admittance) | new Animal object created |
| Application saves all new animals in database table named animals | new animal object instantiated | new animal object saved as row in database table |
| If user visits '/' root route, applications displays splash page with link to '/animals' | user visits '/' route | displays homepage |
| If user visits '/animals' route, applications displays all animals in database, each with a link to view more details about the animal and ordered alphabetically by type | user visits '/animals' route | displays list of animals |
| If user clicks "add new animal" button, application redirects to new animal form | user clicks "add new animal" button | application redirects to new animal form |
| If user visits '/animals/new', application shows new animal form | user visits '/animals/new' | application displays form for adding new animal |
| If user visits submits new animal form, application adds new animal to database and redirects to '/animals' | user submits form | application adds new animal to database and redirects to page showing all animals in database |
| If user visits '/animals/{id}', application displays details for that animal | user clicks on specific animal in animals list | application redirects to display details about that animal |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd AnimalShelter.Solution``

_Confirm that you have navigated to the ToDoList.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd AnimalShelter``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Brandan Sayarath, Zakkrey Short, Geoff Goetz_**