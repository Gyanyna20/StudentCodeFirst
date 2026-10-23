# Student Code-First Console Application

## Purpose
This console application demonstrates Entity Framework 6 Code First. The model is defined in C# classes, and Entity Framework creates a SQL Server LocalDB database and its `Students` table when the application first accesses the database. The application then adds one student and displays the students saved in the database.

## Requirements
- Windows
- Visual Studio (full IDE) with .NET Framework 4.7.2 targeting pack
- SQL Server LocalDB
- NuGet package restore enabled


## How to run
1. Open `StudentCodeFirst.sln` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Ensure SQL Server LocalDB is installed.
4. Build and run the project.


## Main concepts
- `Student.cs`: the entity/model class.
- `StudentContext.cs`: the EF6 database context and `DbSet<Student>`.
- `Program.cs`: adds one student and reads the saved records.
- `App.config`: configures the LocalDB connection string.
