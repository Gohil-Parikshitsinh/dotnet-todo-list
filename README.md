# 📝 Todo List Desktop Application (.NET Windows Forms)

A simple **Todo List Desktop Application** built using **C# Windows Forms and SQL Server LocalDB**.
The application allows users to **create, manage, and track tasks** with an easy-to-use graphical interface.

This project demonstrates the implementation of **CRUD operations (Create, Read, Update, Delete)** with a **database-connected desktop application**.

---

# 📌 Project Overview

The Todo List application helps users manage daily tasks efficiently by allowing them to:

* Add new tasks
* Update existing tasks
* Delete tasks
* Mark tasks as completed
* View all tasks in a table
* Track completed and pending tasks

Completed tasks are automatically **highlighted in green** to improve visibility.

---

# 🚀 Features

* ➕ Add new tasks
* ✏️ Update existing tasks
* ❌ Delete tasks
* ✅ Mark tasks as **Done**
* 📋 Display tasks in a table view
* 🎨 Completed tasks highlighted in **green**
* 📊 Task statistics:

  * Total tasks
  * Completed tasks
  * Pending tasks

---

# 🛠️ Technologies Used

* **C#**
* **.NET Windows Forms**
* **SQL Server LocalDB**
* **ADO.NET**
* **Git & GitHub**

---

# 📂 Project Structure

```
TodoListApp
│
├── TodoListApp.sln
├── TodoListApp
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   ├── App.config
│   └── TodoListApp.csproj
│
├── database.sql
└── README.md
```

---

# 🧠 Software Development Process

This project was developed following a simplified **Software Development Lifecycle (SDLC)**.

## 1️⃣ Planning & Feasibility Study

The goal of the project was to create a **simple desktop task manager** that demonstrates how a Windows Forms application can interact with a database.

Key objectives:

* Practice CRUD operations
* Learn database connectivity
* Build a basic productivity application

---

## 2️⃣ Requirements Gathering & Analysis

The application requirements were defined as:

* Users should be able to **add tasks**
* Users should be able to **update tasks**
* Users should be able to **delete tasks**
* Users should be able to **mark tasks as completed**
* The system should show **pending and completed tasks**
* Completed tasks should be **visually highlighted**

---

## 3️⃣ Design & Logical Architecture

The system was designed with a **simple client-database architecture**.

### Application Layers

```
User Interface (Windows Forms)
        ↓
Application Logic (C#)
        ↓
Database Layer (SQL Server LocalDB)
```

### Database Design

The application uses a single table:

**Tasks Table**

| Column      | Type              | Description            |
| ----------- | ----------------- | ---------------------- |
| TaskID      | INT (Primary Key) | Unique task identifier |
| Title       | VARCHAR(100)      | Task name              |
| Description | VARCHAR(255)      | Task details           |
| Status      | VARCHAR(20)       | Pending / Done         |

---

# 💾 Database Setup

Run the following SQL script in **SQL Server Management Studio** or **Visual Studio SQL Server Object Explorer**.

```
CREATE TABLE Tasks (
    TaskID INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(100),
    Description VARCHAR(255),
    Status VARCHAR(20)
);
```

---

# ⚙️ How to Run the Project

Follow these steps to run the project locally.

### 1️⃣ Clone the repository

```
git clone https://github.com/YOUR_USERNAME/dotnet-todo-list.git
```

---

### 2️⃣ Open the project

Open the solution file in **Visual Studio**

```
TodoListApp.sln
```

---

### 3️⃣ Setup the Database

Create the **Tasks table** using the SQL script provided above.

---

### 4️⃣ Run the Application

Press:

```
F5
```

or click **Start Debugging** in Visual Studio.

---

# 📊 Application Workflow

1. User enters **Task Name** and **Description**
2. Click **Add** to save the task
3. Tasks appear in the table
4. User can:

   * Update the task
   * Delete the task
   * Mark the task as Done
5. Completed tasks are **highlighted in green**
6. Task statistics update automatically

---

# 🔮 Future Improvements

Possible improvements for this application include:

* Task search functionality
* Due date for tasks
* Overdue task highlighting
* User authentication
* Better UI design

---


# 📸 Application Screenshots

Below are some screenshots of the Todo List Application interface.

## Main Interface

Displays all tasks with their status. Completed tasks are highlighted in **green**.

```
screenshots/main-interface.png
```

## Adding a Task

Users can enter a **task title and description** and click the **Add button**.

```
screenshots/add-task.png
```

## Task Completed

When a task is marked as **Done**, it is visually highlighted.

```
screenshots/task-completed.png
```

screenshots/final.png

Example structure:

```
TodoListApp
│
├── screenshots
│   ├── main-interface.png
│   ├── add-task.png
│   └── task-completed.png
│
└── README.md
```

---

# 🏗️ Application Architecture

The application follows a **simple 3-layer architecture**.

```
+-------------------------+
|     Windows Forms UI    |
|   (User Interface)      |
+-----------+-------------+
            |
            |
+-----------v-------------+
|   Application Logic     |
|        (C# Code)        |
+-----------+-------------+
            |
            |
+-----------v-------------+
|   Database Layer        |
|   SQL Server LocalDB    |
+-------------------------+
```

### Description

**User Interface**

* Built using **Windows Forms**
* Allows users to interact with the application
* Provides buttons and input fields for task management

**Application Logic**

* Written in **C#**
* Handles user actions
* Executes database queries

**Database Layer**

* Stores task data
* Managed using **SQL Server LocalDB**

---

# 🗄️ Database ER Diagram

The application uses a **single table structure**.

```
+----------------------+
|        Tasks         |
+----------------------+
| TaskID (PK)          |
| Title                |
| Description          |
| Status               |
+----------------------+
```

### Column Description

| Column      | Type         | Description                  |
| ----------- | ------------ | ---------------------------- |
| TaskID      | INT          | Primary key (Auto Increment) |
| Title       | VARCHAR(100) | Task name                    |
| Description | VARCHAR(255) | Task details                 |
| Status      | VARCHAR(20)  | Pending or Done              |

---

# 📌 Example Task Data

| TaskID | Title               | Description          | Status  |
| ------ | ------------------- | -------------------- | ------- |
| 1      | Complete Assignment | Finish .NET project  | Pending |
| 2      | Study Database      | Practice SQL queries | Done    |



# 👨‍💻 Author

Developed as a **college practical project** for learning **.NET Windows Forms and database integration**.

---

# 📄 License

This project is for **educational purposes**.
