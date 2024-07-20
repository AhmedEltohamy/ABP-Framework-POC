# Product Categorization

## About this solution

This is a layered startup solution based on [Domain Driven Design (DDD)](https://docs.abp.io/en/abp/latest/Domain-Driven-Design) practises. All the fundamental ABP modules are already installed. 

### Pre-requirements

* [.NET 8.0+ SDK](https://dotnet.microsoft.com/download/dotnet)
* [Node v18 or 20](https://nodejs.org/en)

### Before running the application

Run `ProductCategorization.DbMigrator` to create the database, applay the migrations and seed the initail data to it. <br>
This should be done in the first run. It is also needed if a new database migration is added to the solution later.

### Running the application

Run `ProductCategorization.HttpApi.Host` and use Swagger UI to Test the **Products** collection
