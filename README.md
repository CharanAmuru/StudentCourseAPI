# StudentCourseAPI

An ASP.NET Core Web API for managing students and their enrolled courses. Built with Entity Framework Core and SQL Server.

## 🌟 Features

- CRUD operations for Students and Courses
- Entity relationships with navigation properties
- SQL Server DB integration via EF Core
- Swagger UI for API testing
- CORS support enabled

## 📁 Project Structure

StudentCourseAPI/
│
├── Controllers/ → CoursesController.cs, StudentsController.cs
├── Models/ → Course.cs, Student.cs
├── Data/ → AppDbContext.cs
├── Program.cs
├── appsettings.json
└── StudentCourseAPI.sln

---

## 🚀 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (LocalDB)
- Swagger UI for testing API
- Visual Studio 2022

---

## 🔗 API Endpoints

You can test all endpoints in Swagger UI:  
**http://localhost:5024/swagger**

Examples:

- `GET /api/Students` → Get all students
- `POST /api/Students` → Add a new student
- `GET /api/Courses` → Get all courses

---

## 📦 Sample JSON for Student

```json
{
  "name": "Charan Sai",
  "email": "charan@email.com",
  "courses": [
    {
      "courseName": "Data Structures",
      "credit": 3
    }
  ]
}
