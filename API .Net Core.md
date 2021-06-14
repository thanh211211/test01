#entity framework core: Migrations Overview 
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs
#	Create your first migration
	dotnet ef migrations add InitialCreate
	Add-Migration InitialCreate

#	Create your database and schema
	dotnet ef database update
	Update-Database
	
#Run lệnh sau để Cập nhật Models
Scaffold-DbContext "Server=isacc01.isolutions.com.vn;Database=Libs_GiengDa_Data;user id=libs;password=libsA01*"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
	
# config API has ssl
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:32847",
      "sslPort": 44348
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "Libs.API.Web": {
      "commandName": "Project",
      "dotnetRunMessages": "true",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}


