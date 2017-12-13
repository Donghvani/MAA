# MAA

## Resources required
1. SQL Server 2017 Express edition
https://www.microsoft.com/en-us/sql-server/sql-server-editions-express

2. SQL Server Management Studio (SSMS)
https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms

## Useful articles
1. ASP.NET Core Application to Existing Database (Database First
https://ef.readthedocs.io/en/staging/platforms/aspnetcore/existing-db.html#prerequisites

2. SQL server naming conventions:
https://launchbylunch.com/posts/2014/Feb/16/sql-naming-conventions/

## Useful scripts
1. Database first approach -> generate entities from Database
Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=maa;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

## Database
See database creation scripts in "DB_Scripts" directory