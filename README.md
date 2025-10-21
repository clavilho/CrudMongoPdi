# 🧩 Basic CRUD with .NET and MongoDB

This project is a simple **CRUD (Create, Read, Update, Delete)** application built using **.NET 8** and **MongoDB**.  
It demonstrates how to connect a .NET Web API to a MongoDB database and perform basic operations on a collection.

---

## 🚀 Features

- Create a new record  
- Retrieve all records or a specific record by ID  
- Update an existing record  
- Delete a record  
- Built with dependency injection and clean architecture principles

---

## 🛠️ Technologies Used

- **.NET 8 (ASP.NET Core Web API)**
- **MongoDB**
- **MongoDB.Driver**
- **Swagger / OpenAPI**
- **C#**

---

## ⚙️ Configuration

1. Clone this repository:

   ```bash
   git clone https://github.com/your-username/CrudMongo.git
   cd CrudMongo
Configure your MongoDB connection in appsettings.json:

json
Copiar código
{
  "MongoDB": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "UserDb",
    "CollectionName": "Users"
  }
}
Run the application:

bash
Copiar código
dotnet run
Open Swagger UI in your browser:

bash
Copiar código
https://localhost:7025/swagger
📁 Project Structure
pgsql
Copiar código
CrudMongo/
├── Controllers/
│   └── UserController.cs
├── Models/
│   └── User.cs
├── Services/
│   └── MongoDbService.cs
├── appsettings.json
└── Program.cs
📘 Example Endpoints
Method	Endpoint	Description
GET	/api/user	Get all users
GET	/api/user/{id}	Get a user by ID
POST	/api/user	Create a new user
PUT	/api/user/{id}	Update a user
DELETE	/api/user/{id}	Delete a user

🧠 Example User Model
csharp
Copiar código
public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
🧰 Requirements
.NET SDK 8.0+

MongoDB running locally or in Docker

To run MongoDB using Docker:

bash
Copiar código
docker run -d -p 27017:27017 --name mongodb mongo
🧑‍💻 Author
João Vitor Clavilho dos Santos
📧 Contact: [jv.clavilho@hotmail.com]
💼 GitHub: github.com/clavilho
