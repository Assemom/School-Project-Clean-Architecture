# 🚀 School Management System API

A scalable and maintainable School Management System API built with **ASP.NET Core Web API** following **Clean Architecture** principles.  
This project demonstrates real-world backend development practices including authentication, authorization, database optimization, and modular architecture.

---

## 📌 Overview

The School Management System API is designed to manage the core operations of a school environment such as:

- Student management
- Instructor management
- Department management
- Subject management
- Student enrollment
- Authentication & authorization

The project focuses on **separation of concerns**, **maintainability**, and **scalability** using Clean Architecture.

---

## 🏗 Architecture

The solution is structured into 6 layers:

```text
SchoolManagementSystem
│── API             # Presentation Layer (Controllers, Endpoints)
│── Core            # Domain Entities & Business Rules
│── Service         # Application Logic & Use Cases
│── Infrastructure  # EF Core, External Services
│── Data            # Database Configurations & Persistence
│── Shared          # Common Models, Constants, Responses
```

### Architecture Principles

- Clean Architecture
- Separation of Concerns
- Dependency Inversion
- Repository Pattern
- CQRS with MediatR

---

## ✨ Features

### 🔐 Authentication & Authorization

- JWT Authentication
- Role-Based Authorization
- Protected Endpoints
- Role-Based Filtering

### 👨‍🎓 Student Management

- Create Student
- Update Student
- Delete Student
- Get Student Details
- Student Enrollment

### 👨‍🏫 Instructor Management

- CRUD Operations
- Instructor Assignment

### 🏢 Department Management

- CRUD Operations

### 📚 Subject Management

- CRUD Operations

### 🔗 Student–Subject Enrollment

- Enroll students in subjects
- Manage relationships

### 📧 Email Service

- Email notifications support

### 🌍 Localization

- Multi-language API support

### 📄 Swagger Documentation

- API documentation with Swagger UI

---

## 🗄 Database Features

### Stored Procedures

Used for:

- Performance optimization
- Complex business operations

### Database Views

Used for:

- Reporting
- Simplified data retrieval

---

## 🛠 Technologies Used

### Backend

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server

### Libraries & Tools

- MediatR
- AutoMapper
- JWT Authentication
- Swagger
- Dependency Injection

### Design Patterns

- Clean Architecture
- Repository Pattern
- CQRS Pattern

---

## 📂 API Endpoints

### Authentication

| Method | Endpoint              | Description |
|--------|-----------------------|-------------|
| POST   | /api/auth/login       | Login |
| POST   | /api/auth/register    | Register |

### Students

| Method | Endpoint              | Description |
|--------|-----------------------|-------------|
| GET    | /api/students         | Get all students |
| GET    | /api/students/{id}    | Get student by id |
| POST   | /api/students         | Create student |
| PUT    | /api/students/{id}    | Update student |
| DELETE | /api/students/{id}    | Delete student |

### Subjects

| Method | Endpoint              | Description |
|--------|-----------------------|-------------|
| GET    | /api/subjects         | Get all subjects |
| POST   | /api/subjects         | Create subject |

### Departments

| Method | Endpoint              | Description |
|--------|-----------------------|-------------|
| GET    | /api/departments      | Get all departments |
| POST   | /api/departments      | Create department |

### Instructors

| Method | Endpoint              | Description |
|--------|-----------------------|-------------|
| GET    | /api/instructors      | Get all instructors |
| POST   | /api/instructors      | Create instructor |

---

## ⚙ Installation & Setup

### 1. Clone Repository

```bash
git clone <your-repo-url>
cd SchoolManagementSystem
```

### 2. Configure Connection String

Update `appsettings.json`

```json
"ConnectionStrings": {
  "DefaultConnection": "YourConnectionString"
}
```

### 3. Apply Database Migration

```bash
dotnet ef database update
```

### 4. Run Project

```bash
dotnet run
```

---

## 📄 Swagger Documentation

After running the project:

```text
https://localhost:{port}/swagger
```

---

## 🔐 Authentication Flow

1. Register user
2. Login
3. Receive JWT token
4. Use token in Authorization header

```text
Authorization: Bearer your_token_here
```

---

## 📈 Future Improvements

- Add caching
- Improve validation
- Add global exception handling
- Add unit testing
- Add integration testing
- Add logging system
- Add refresh tokens

---

## 📚 What I Learned

- Applying Clean Architecture in real projects
- Implementing JWT Authentication
- Role-Based Authorization
- Using MediatR with CQRS
- Working with Stored Procedures and Views
- Building scalable APIs

---

## 🤝 Contributing

Contributions are welcome.

1. Fork repository
2. Create feature branch
3. Commit changes
4. Push branch
5. Open pull request

---

## 📬 Contact

**Assem Omar**  
Software Engineer | Backend Developer  

📧 Email: assemomar202@gmail.com  
📍 Cairo, Egypt

---

## ⭐ Support

If you like this project, give it a star ⭐
