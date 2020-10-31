# Steps

1. Create a new dotnet project.

    `$ dotnet new console`

2. Add EF Core package to target Sqlite.

    `$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

3. Define context class and entity classes that make up the model.

4. Then allow the project to be able to run migrations:

    ``` bash
    $ dotnet tool install --global dotnet-ef
    $ dotnet add package Microsoft.EntityFrameworkCore.Design
    $ dotnet ef migrations add InitialCreate
    $ dotnet ef database update
    ```

El penúltimo paso no anda en Mac ni en Windows.
