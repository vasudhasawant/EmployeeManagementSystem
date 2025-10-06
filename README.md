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
create database TaskManagement

use TaskManagement
create table Employee
(
id int identity primary key,
employeename varchar(100) not null,
username varchar(20) not null unique,
password varchar(20) not null,
department varchar(20),
designation varchar(20)
)
insert into employee values('vasudha','vasu','admin@12345','IT','Software Developer')
select * from Employee
