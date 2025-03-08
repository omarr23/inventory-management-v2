# Running a .NET 8 Project

## Step 1: Add `appsettings.json` Manually
Before running the project, ensure you have the `appsettings.json` file in the root of your project. If missing, create one and configure the necessary settings such as database connection strings, logging levels, and other environment-specific configurations.

Example:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

## Step 2: Restore Dependencies
Run the following command to restore all required NuGet packages:
```sh
dotnet restore
```
> **Does `dotnet restore` restore Entity Framework (EF) packages for SQL Server?**

## Step 3: Build the Project
Compile the project by running:
```sh
dotnet build
```
This will check for any compilation errors and prepare the project for execution.

## Step 4: Run Migrations
To apply Entity Framework Core migrations and update the database schema, use:
```sh
dotnet ef database update
```
Ensure that the `dotnet-ef` tool is installed globally or locally in your project:
```sh
dotnet tool install --global dotnet-ef
```

If migrations are missing, create one using:
```sh
dotnet ef migrations add InitialCreate
```
Then apply it with:
```sh
dotnet ef database update
```

## Step 5: Run the Application
Now, you can run the application with:
```sh
dotnet run
```


