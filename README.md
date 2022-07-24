```bash
dotnet new sln
```
```bash
dotnet new console -o 1-Basics
dotnet sln csharp-workshop.sln add 1-Basics/1-Basics.csproj
dotnet add 1-Basics/1-Basics.csproj package Newtonsoft.Json
dotnet run --project 1-Basics/1-Basics.csproj
```
```bash
dotnet new console -o 2-OOP
dotnet sln csharp-workshop.sln add 2-OOP/2-OOP.csproj
dotnet new classlib -o 2-OOPLib
dotnet sln csharp-workshop.sln add 2-OOPLib/2-OOPLib.csproj
dotnet add 2-OOP/2-OOP.csproj reference 2-OOPLib/2-OOPLib.csproj
dotnet run --project 2-OOP/2-OOP.csproj
```
```bash
dotnet new console -o 3-Functional
dotnet sln csharp-workshop.sln add 3-Functional/3-Functional.csproj
dotnet run --project 3-Functional/3-Functional.csproj
```