# Notes
* Introduction
  * What is C#?
    * Type system: strongly typed
    * Paradigm: object oriented + funtional techniques
  * What is dotnet
    * Framework for CLI (common language infrastructure) developed by MS
    * Not only for C# (F#, VB, ...)
    * Open source reimplementation since 2016
* Programming with C#
  * What are solution and project and namespace and nuget?
  * Primary datatypes + var keyword
  * Flow control: if, while, for, foreach
  * Structures: method, struct, interface, enum, class, record
  * Class field vs property
  * Generic type
  * Object and list initializer
  * Property init vs private set
  * Naming conventions
  * Lambda expression
  * LINQ
    * Extension methods: definition + usage
    * Query syntax
    * Why LINQ?
      * Easier to comprehend
      * Less bug-prune
      * Fewer side-effects
  * Usefull NuGet packages
    * dotnet-repl
    * dotnet-script
* C# in Depth
  * Syntax sugar [sharplab.io](https://sharplab.io/)
    * num+=1
    * property
    * known variable in compile time
    * record
  * Compilation
    * All dotnet languages including C# complile to IL (intermediate language)
      * `dotnet build`: creates IL files (.dll, .exe, ...)
      * CLR (common language runtime) executes IL files
      * Using JIT (just in time) technique
* Further Study
  * Delegate + Action and Func
  * Pattern matching
  * Attribute
  * Nullable
  * Async
  * Unsafe context and pointers

# Project Structure

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
