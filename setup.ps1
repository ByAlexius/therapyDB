# Get the current working directory (where the script is executed)
$scriptPath = $PSScriptRoot
$currentDirectory = Get-Location

# Set the name of the project
$projectName = "therapyDB"

# Construct the full project path
$projectPath = Join-Path $currentDirectory $projectName

# Set the name of the database
$databaseName = "Database"

# Set the connection string
$connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=$databaseName;Integrated Security=True;"

# Navigate to the project directory
cd $projectPath

# Install EntityFramework NuGet package
nuget install EntityFramework -Version 6.4.4 -OutputDirectory packages

# Import the EntityFramework module
Import-Module "$projectPath\packages\EntityFramework.6.4.4\tools\EntityFramework6.psm1"

# Enable Migrations
Enable-Migrations -StartUpProjectName $projectPath

# Add an initial migration
Add-Migration InitialCreate -StartUpProjectName $projectPath

# Apply Migrations to create or update the database
Update-Database -StartUpProjectName $projectPath -ConnectionString $connectionString

# Ensure the DbContext is created to trigger database creation
$contextTypeName = "therapyDB.TherapyDBContext"
$context = [System.Activator]::CreateInstance([System.Type]::GetType($contextTypeName))

Write-Host "Database created or updated using Entity Framework migrations."
