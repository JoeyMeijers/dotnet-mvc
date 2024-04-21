# Create sqlite backend

## define your models

## install nuget packages

- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Design

## Add DbContext class

- Example: ApiContext.cs
- Make sure to override the onConfiguring method

## Migrate and update the db

- dotnet ef migrations add InitialCreate
- dotnet ef database update
