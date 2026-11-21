# ASP.NET Orchard Core Web Application

A modular web application built using **ASP.NET Core** and **Orchard Core CMS**, focusing on extensibility, clean architecture, and CMS-driven development.

---

## 🎯 Project Objective
Design and develop a scalable Orchard Core–based application with custom modules, content types, and role-based access control.

---

## ⚙️ Current Features (In Progress)
- Orchard Core CMS setup and configuration
- Custom module development (`ProjectModule`)
- Content types and content parts
- Admin dashboard configuration
- Role-based user and permission management
- Modular and feature-based architecture

---

## 🛠️ Technology Stack
- ASP.NET Core
- Orchard Core CMS
- C#
- Razor / MVC
- Database: SQLite (development)

---

## 📁 Project Structure

```
Program.cs              application entry point, Orchard Core startup
MyOrchardApp.csproj     host project
appsettings.json        host configuration
src/Modules/
  ProjectModule/        custom Orchard Core module
    Controllers/        module controllers
    Views/              Razor views
    Migrations/         content type and index migrations
Localization/           translation resources shipped with Orchard Core
wwwroot/                static assets
NLog.config             logging configuration
```

`App_Data/` is created at first run and holds the site database, the tenant
settings and the Data Protection keys. It is intentionally **not** tracked:
it is per-installation state and contains secrets.

---

## ▶️ How to Run
1. Open the solution in **Visual Studio**
2. Restore NuGet packages
3. Run the application
4. Complete Orchard Core setup in the browser (first run)
5. Access the admin dashboard and manage content

---

## 🚀 Roadmap
- Add additional custom modules
- Build frontend pages driven by content types
- Improve UI structure and navigation
- Add deployment notes (IIS / Docker / Azure)
- Add screenshots and documentation

---
## 📸 Screenshots

### Orchard Admin Dashboard
![Admin Dashboard](admin-dashboard.jpg)

### Custom Orchard Module Enabled
![Custom Module Enabled](custom-module-enabled.jpg)

### Custom Orchard Module (Code)
![Custom Module Code](custom-module-code.jpg)

---
## 📌 Notes
This project is under active development and will be extended progressively.

