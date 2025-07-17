# TestGrqaphQl

A sample GraphQL API built with ASP.NET Core and Entity Framework Core, demonstrating how to manage and expose relational data (Authors and Books) via a modern, type-safe API. This project is ideal for developers looking to learn or prototype GraphQL services with a .NET backend, using SQL Server as a database and leveraging best practices like filtering, sorting, and projections.

---

## 🧾 Project Description

**TestGrqaphQl** is a backend service that exposes a GraphQL endpoint for managing authors and books. Built with ASP.NET Core and Entity Framework Core, it provides a robust starting point for anyone interested in:

- Learning how to build GraphQL APIs in .NET.
- Implementing CRUD operations with database-backed models.
- Experimenting with filtering, sorting, and projections in GraphQL.
- Generating and exploring API documentation with Swagger.

---

## ⚙️ Tech Stack

- **Languages**: C#
- **Frameworks**: ASP.NET Core 8, Entity Framework Core
- **Database**: SQL Server (LocalDB or full)
- **GraphQL Server**: HotChocolate
- **Documentation**: Swagger/OpenAPI

---

## 🎯 Target Audience

- .NET Developers
- Students and educators exploring GraphQL and EF Core
- Backend engineers prototyping APIs
- Anyone interested in modern API design with .NET

---

## ✨ Features

- GraphQL endpoint with query and mutation support at `/graphql`
- CRUD operations for Authors and Books
- Advanced GraphQL features: filtering, sorting, and projections
- Swagger UI for RESTful endpoints and schema exploration
- Entity Framework Core code-first migrations

---

## 🚀 Installation Instructions

```bash
# 1. Clone the repository
git clone https://github.com/sadeg-2/TestGrqaphQl.git
cd TestGrqaphQl

# 2. Restore dependencies
dotnet restore

# 3. Set up your database connection (see below)
```

### Example `appsettings.json` (connection string)

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TestGrqaphQlDb;Trusted_Connection=True;"
  }
}
```

> **Note:** You can use SQL Server Express, Azure SQL, or any full SQL Server instance if preferred.

---

## 🛠️ How to Run the Project

### Run the backend locally:

```bash
# Apply any pending EF Core migrations to set up the schema
dotnet ef database update

# Start the application
dotnet run --project TestGrqaphQl
```

- The GraphQL endpoint will be available at: `https://localhost:5001/graphql`
- The Swagger UI will be available at: `https://localhost:5001/swagger`

---

## 📦 Example Usage

### Example GraphQL Query

```graphql
query {
  books {
    nodes{
        id
        title
        author {
          name
        }
    }
  }
}
```

### Example GraphQL Mutation

```graphql
mutation {
  addAuthor(name: "Jane Doe") {
    id
    name
  }
}
```

### Example: Add Book (Mutation)

```graphql
mutation {
  addBook(title: "My First Book", authorId: 1) {
    id
    title
    author {
      name
    }
  }
}
```

### Example REST API Call (if any REST endpoints exist)

```bash
curl https://localhost:5001/weatherforecast
```

---

## 🧪 Testing Instructions

If you have unit or integration tests, run them with:

```bash
dotnet test
```
> _Note: Add tests to the solution to improve reliability and confidence in your changes!_

---

## 📚 Documentation

- **Swagger UI:** Available at `/swagger` after running the project.
- **GraphQL Playground:** Tools like [Banana Cake Pop](https://chillicream.com/docs/bananacakepop) can be used to explore `/graphql`.

---

## 🧑‍💻 Contributing Guide

We welcome contributions! To get started:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -am 'Add new feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request

Please follow standard .NET coding conventions and document your code where appropriate.

---

## 🪪 License

This project is **unlicensed** by default. Please add a license file (e.g., MIT, Apache 2.0) if you plan to open source the project.

---

## 📞 Contact & Maintainers

- **Maintainer:** [sadeg-2](https://github.com/sadeg-2)
- For issues, open a [GitHub issue](https://github.com/sadeg-2/TestGrqaphQl/issues).
- For questions, contact via GitHub profile.

---

_Ready to dive into .NET GraphQL APIs? Fork, clone, and start building!_
