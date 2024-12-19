# BookManagementSystem

This is a Book Management System implemented with ASP.NET Core, Entity Framework Core, and Razor Pages. The system allows CRUD operations for managing books and includes both a backend API and a frontend interface.

Project Structure
The project is organized as follows:

Backend:

Program.cs: Configures services and middleware.
AppDbContext.cs: Entity Framework Core database context.
Book.cs: Represents the Book entity.
Book.cs: Data Transfer Object for the Book entity.
MappingProfile.cs: AutoMapper configuration.
IBookRepository.cs and BookRepository.cs: Data access layer.
IBookService.cs and BookService.cs: Business logic layer.
BooksController.cs: API controller for managing books.

Frontend:
Razor Pages for the user interface, including pages for listing, adding, editing, and deleting books (Index.cshtml, Add.cshtml, etc.).
_Layout.cshtml: Provides a shared layout with Bootstrap for styling.
Prerequisites
.NET 6.0 SDK
SQLite (or any other configured database)
Steps to Run the Application
Restore Dependencies: Run the following command in the project root:
dotnet restore

Migrate the Database: Create the SQLite database and apply migrations:
dotnet ef database update

Run the Application: Start the application:
dotnet run

Access the Application:
Open a browser and navigate to the API documentation (Swagger UI): https://localhost:5001/swagger
Access the frontend at https://localhost:5001.
Consuming the API from Another Application
To consume the API hosted in this project:
Ensure the API is running on https://localhost:5001 (or another configured URL).
Use the following endpoints:
GET /api/Books: Retrieve all books.
GET /api/Books/{id}: Retrieve a book by ID.
POST /api/Books: Add a new book.
PUT /api/Books/{id}: Update an existing book.
DELETE /api/Books/{id}: Delete a book.
Include an HTTP client (e.g., HttpClient in .NET) in the external application to interact with these endpoints.

Example in .NET for retrieving books:


using var client = new HttpClient { BaseAddress = new Uri("https://localhost:5001/api/Books") };
var response = await client.GetAsync("");
var books = await response.Content.ReadAsAsync<List<BookDto>>();

Features

Backend:
RESTful API with Swagger UI for documentation.
Clean separation of concerns using Repository and Service layers.
AutoMapper for object mapping.

Frontend:
Razor Pages with Bootstrap for a responsive UI.
CRUD operations for books.
Technologies Used
Backend: ASP.NET Core, Entity Framework Core, AutoMapper.
Frontend: Razor Pages, Bootstrap.
Database: SQLite (default, configurable).
