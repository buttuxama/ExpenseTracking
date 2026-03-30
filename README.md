# ExpenseTracking

A simple and intuitive web application for tracking and managing personal expenses. Built with ASP.NET Core MVC and modern web technologies.

## Features

- **Track Expenses**: Add, edit, and delete expense entries
- **View Summary**: See total expenses at a glance
- **Responsive Design**: Works seamlessly on desktop and mobile devices
- **Real-time Updates**: Instant feedback on all operations
- **Simple UI**: Clean and user-friendly interface

## Technology Stack

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: Entity Framework Core with In-Memory Database
- **Frontend**: HTML5, CSS3, JavaScript
- **UI Framework**: Bootstrap 5

## Project Structure

```
ExpenseTracking/
├── Controllers/          # MVC controllers
│   └── HomeController.cs
├── Models/              # Data models
│   ├── Expense.cs
│   └── ExpenseTrackingDbContext.cs
├── Views/               # Razor views
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Expenses.cshtml
│   │   └── CreateEditExpense.cshtml
│   └── Shared/
├── wwwroot/             # Static files (CSS, JS, libraries)
├── Properties/          # Application settings
└── Program.cs           # Application startup configuration
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- A text editor or IDE (Visual Studio, Visual Studio Code, etc.)

## Usage

1. Open your browser and navigate to the application URL
2. Click on "Expenses" to view all tracked expenses
3. Click "Add Expense" to create a new expense entry
4. Fill in the description and amount
5. Click "Save" to add or update the expense
6. Use the delete option to remove expenses

## Model

### Expense

```csharp
public class Expense
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public string Description { get; set; }
}
```

## API Endpoints

- `GET /` - Home page
- `GET /Home/Expenses` - View all expenses with total sum
- `GET /Home/CreateEditExpense/{id?}` - Form to create or edit an expense
- `POST /Home/CreateEditExpense` - Save expense
- `GET /Home/DeleteExpense/{id}` - Delete an expense

## Configuration

### Database

The application uses an in-memory database by default. To switch to a different database:

1. Update the DbContext configuration in `Program.cs`
2. Add the appropriate EF Core provider package
3. Create and run migrations

### Application Settings

Edit `appsettings.json` and `appsettings.Development.json` to configure:

- Logging levels
- Database connection strings
- Application-specific settings

## Development

### Requirements

- .NET 8.0 SDK
- Visual Studio 2022 or Visual Studio Code with C# extension

### Building

```bash
dotnet build
```

## Future Enhancements

- [ ] User authentication and authorization
- [ ] Export functionality (CSV, PDF)
- [ ] Search and filter capabilities
- [ ] Persistent database (SQL Server, PostgreSQL)
- [ ] Unit tests
