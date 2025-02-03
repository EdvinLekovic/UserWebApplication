# Simple User web application

Application demo available here: https://youtu.be/6bhIXlapO08


## Application Setup

The technologies that here are used is `C# .NET`, `HTML`, `CSS`, `Javascript` and for keeping the data I used `Microsoft SQL Server`.

To setup the environment to work this application properly, I reccomend installing `Visual Studio 2022`, then clone this repo and open it through the IDE. 

First you need to install `Microsft SQL Server Management Studio`.

Then setting up the local database first through the `Windows Command Prompt`.For creating the server you enter this command `sqllocaldb create <here the name of the server>`.

After this you need to setup the server name inside the `appsettings.json` file.

After you done that inside the terminal in VS 2022 you are entering this `Add-Migration <migration name here>` and
`Update-Database`. After this your local database is created and you can store data inside of it.

