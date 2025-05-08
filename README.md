# AutoMapper Example with ASP.NET Core

This repository demonstrates a simple and professional way to use **AutoMapper** in an **ASP.NET Core Web API** project.  
The project also uses **EF Core** with a **SQLite** database following the Code-First approach.

## 🚀 Features

- AutoMapper integration
- EF Core with SQLite (Code First)
- Simple `Product` entity and CRUD operations
- Clean and minimal API design

## 📦 Technologies

- .NET 9
- AutoMapper
- Entity Framework Core
- SQLite

## 📝 Related Blog Post

You can read the related Medium article here:
👉 [AutoMapper Nedir? .NET ile AutoMapper Kullanımı](https://medium.com/@sinanganiz/automapper-nedir-net-ile-automapper-kullan%C4%B1m%C4%B1-214a47cc9b29)

## 🛠️ Getting Started

1. Clone the repo:

```bash
git clone https://github.com/sinanganiz/automapper-example.git
cd automapper-example
```

2. Restore dependencies:

```bash
dotnet restore
```

3. Apply migrations and run:

```bash
dotnet ef database update
dotnet run
```
