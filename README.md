# Employee Management System

This is a web-based **Employee Management System** built using **ASP.NET** and **SQL Server**.  
It allows administrators to manage employees, departments, and designations efficiently.

---

## 🚀 Features
- Employee registration and login
- Add, edit, delete employee details
- Department and designation management
- Secure authentication with password validation
- SQL Server database integration

---

## 🛠️ Technologies Used
- ASP.NET (C#)
- SQL Server
- HTML, CSS, Bootstrap
- Visual Studio 2022

---

## ⚙️ Database Setup
```sql
CREATE DATABASE EmployeeDB;

USE EmployeeDB;

CREATE TABLE Employees (
    ID INT IDENTITY PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Department VARCHAR(50),
    Designation VARCHAR(50)
);
