# User Management API

A simple ASP.NET Core Web API project for managing users with CRUD operations, input validation, Swagger/OpenAPI integration, and custom middleware.

---

## Features

- Create, read, update, and delete users
- ASP.NET Core Web API architecture
- Swagger/OpenAPI integration for API testing
- Input validation using Data Annotations
- Custom request logging middleware
- In-memory user storage
- RESTful API endpoints
- Microsoft Copilot assisted development and debugging

---

## Technologies Used

- C#
- ASP.NET Core Web API
- .NET 8
- Swagger / OpenAPI
- Visual Studio Code
- Git & GitHub
- Microsoft Copilot

---

## Project Structure

```text
UserManagementApi/
│
├── Controllers/
│   └── UsersController.cs
│
├── Middleware/
│   └── RequestLoggingMiddleware.cs
│
├── Models/
│   ├── User.cs
│   └── UserStore.cs
│
├── Program.cs
├── UserManagementApi.csproj
└── README.md
```

---

## API Endpoints

| Method | Endpoint          | Description             |
| ------ | ----------------- | ----------------------- |
| GET    | `/api/users`      | Get all users           |
| GET    | `/api/users/{id}` | Get user by ID          |
| POST   | `/api/users`      | Create a new user       |
| PUT    | `/api/users/{id}` | Update an existing user |
| DELETE | `/api/users/{id}` | Delete a user           |

---

## Validation

The API uses Data Annotations to validate incoming user data.
Validation rules include:

- Name is required
- Name must contain at least 3 characters
- Email must be a valid email address
- Age must be between 1 and 120

Example:

```csharp
[Required]
[MinLength(3)]
public string Name { get; set; }

[Required]
[EmailAddress]
public string Email { get; set; }

[Range(1, 120)]
public int Age { get; set; }
```

---

## Middleware

The project includes custom logging middleware that logs:

- HTTP request method
- Request path
- Response status code

Example console output:

```yaml
Request: GET /api/users
Response status: 200
```

---

## Swagger / OpenAPI

Swagger UI is integrated for easy API testing and documentation.
After running the project, open:

```http
https://localhost:xxxx/swagger
```

---

## Copilot Usage

Microsoft Copilot was used during development to:

- Generate the initial API structure
- Help create CRUD endpoints
- Debug routing and validation issues
- Improve middleware implementation
- Suggest code refactoring and cleanup

---

## How to Run the Project

Clone repository:
```bash
git clone https://github.com/narcisiwe/user-management-api.git
```
Navigate to the project folder:
```bash
cd user-management-api
```
Run the application:
```bash
dotnet run
```

---

## Example JSON Request

```JSON
{
  "name": "Alice Smith",
  "email": "alice@example.com",
  "age": 25
}
```

---

## Learning Objectives

This project demonstrates:

- ASP.NET Core Web API development
- REST API design
- CRUD operations
- Middleware pipeline implementation
- Validation and error handling
- Swagger/OpenAPI integration
- GitHub project management
- Microsoft Copilot assisted development
