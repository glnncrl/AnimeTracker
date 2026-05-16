# 🎌 AnimeTracker

A full stack **ASP.NET Core MVC** web application for tracking your anime collection.

## Features
- ✅ Full CRUD — Add, View, Edit, Delete anime entries
- 🔍 Search by title or genre
- 📌 Filter by watch status
- ↕️ Sort by rating or title
- 📊 Stats dashboard — Total, Watching, Completed, Dropped, Avg Rating
- 🎨 Custom anime-themed dark UI

## Tech Stack
- **Backend:** ASP.NET Core MVC (.NET 10)
- **Database:** SQL Server Management Studio 22 + Entity Framework Core
- **Frontend:** Razor Views, Bootstrap 5, Custom CSS
- **IDE:** Visual Studio 2022

## Setup Instructions

1. Clone the repository
```bash
   git clone https://github.com/glnncrl/AnimeTracker.git
```
2. Open `AnimeTracker.sln` in Visual Studio 2022
3. Update the connection string in `appsettings.json`:
```json
   "DefaultConnection": "Server=YOUR_SERVER;Database=AnimeTrackerDB;Trusted_Connection=True;TrustServerCertificate=True;"
```
4. Open Package Manager Console and run:
```bash
   Update-Database
```
5. Press **F5** to run

## Developer
**Glenn Carlo Pabayo** — Full Stack Developer

- 🐙 [github.com/glnncrl](https://github.com/glnncrl)
- 📸 [instagram.com/glnncrl_pby](https://www.instagram.com/glnncrl_pby/)
- ✉️ glenn.pabayo@gmail.com
