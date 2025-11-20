# TodoList API (ASP.NET Core)

A simple TodoList API project built with **ASP.NET Core** and documented using **Swagger**.  
Currently, the project runs with Swagger UI only.

---

## Features
- Interactive API documentation via Swagger UI  
- Endpoints for basic Todo operations (create, read, update, delete)  
- Ready for future database integration  

---

## Tech Stack
- **Framework:** ASP.NET Core 8 (or your version)  
- **API Docs:** Swagger / Swashbuckle  
- **Database:** None (in-memory only for now)  

---

## Installation

Clone the repository:
```bash
git clone https://github.com/your-username/todolist-api.git
cd todolist-api

Usage
Once the server is running, open Swagger UI at:

Code
https://localhost:7274/swagger/index.html
Here you can explore and test all available endpoints.

---
## API Endpoints (Swagger)
Method	Endpoint	Description
GET	/api/Todo	Retrieve all todos
GET	/api/Todo/{id}	Retrieve a single todo by ID
POST	/api/Todo	Create a new todo
PUT	/api/Todo/{id}	Update an existing todo
DELETE	/api/Todo/{id}	Delete a todo by ID
Note: Since there is no database yet, todos are stored in memory and reset when the server restarts.

Sample Request/Response
Create a Todo (POST /api/Todo)
Request Body:

json
{
    "id": 1,
    "taskName": "string",
    "isCompleted": "string"
}
Response:

json
{
    "id": 1,
    "taskName": "Grocery",
    "isCompleted": "N"
}
