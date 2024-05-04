# FinlayWagg.lyHost

Project description:
This project is an implementation of a Azure web app with and accompanying SQL database also manged via Azure, created on Visual Studio 2022. The application is a web app for dog walkers and owners to register to find opportunities to walk dogs or help with walking your own dog.

Dependencies:
- Visual Studio 2022
  - Microsoft.EntityFrameworkCore, version: 7.0.5
  - Microsoft.EntityFrameworkCore.SqlServer, version 7.0.5
  - Microsoft.EntityFrameworkCore.Tools, version 7.0.5
- SQL Server Management Studio 19 (SSMS)
- Microsoft Azure
- A pre created Azure app service plan

Setup:
Clone the repository by selecting the '<> code' button and copying the repo link.
Enter git clone <Wagg.ly repo link> into the terminal.
Go to file in Visual Studio to find the file space that the repository was cloned to.
Once opened select build and wait for the project to finish it's setup.

The frontend can now be run in Visual studio 2022 via the https button, please note you have not yet set up the database.

SQL local SSMS setup:
Setup a database with the same name as the one within the project 'Wagg.lyDatabase'. Therefore the connection string found in the 'appsettings.json' file should still be valid.
Once created you can manage this database within SSMS (you must create the database prior as you cannot create them in SSMS).
As the database perameter migration has already been defined within the 'DatabaseSetup.cs' the database will link to the SSMS after you enter the 'update_database' command in the SSMS packet manager console.
    - If the last step was unsuccessful run 'add-migration "ADD MIGRATIONS FILE NAME HERE"' the re-run 'update_database'.

This can then be run within Visual studio 2022 via the https button, if you wish to push the database and app to Azure follow on.

Create an Azure database and add the client IPV4 address (it will already have your IP highlighted). 
Next go back to SSMS and reconnect, you will find the azure database under the databases tab.
Go to the local database and expand it then copy the table created to the clipboard, go back to the azure database in SSMS open the tables folder, open a query window and paste then execute it within the Azure database table.
After it has built the table made and tested locally will build in the Azure SQL database.
When publishing the application in visual studio select the azure database created under service dependencies, once connected PUBLISH!:)

You have now got the fully published webapp and database connected on an external web address.
