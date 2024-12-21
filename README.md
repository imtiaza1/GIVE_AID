# 🤝 Give Aid - Donation System (Code First Approach)

## 📝 Description
**Give Aid** is a donation management system developed using the **Code First** approach in **.NET MVC**. This project, created as part of my studies at **Aptech**, enables users to contribute to various causes securely and efficiently. The system leverages **C#** and **Entity Framework** to dynamically create the database based on the code structure.

Key Features:  
- **User Login**: Secure user authentication.  
- **Make Donations**: Seamless contribution process for donors.  
- **Specific Donations**: Allocate donations to specific causes and track them effectively.

---

## 🚀 Features
✨ **Code First Approach**: Automatically generates the database from the application's models.  
🔒 **Secure Login**: Robust authentication for users.  
🎁 **Donation Tracking**: View and manage donations for specific purposes.

---

## 🛠️ Technologies Used
| Technology    | Description                           |
|---------------|---------------------------------------|
| ![C# Icon](https://img.shields.io/badge/C%23-green?logo=csharp&logoColor=white) | Server-side programming. |
| ![SQL Icon](https://img.shields.io/badge/SQL-lightblue?logo=mysql&logoColor=white) | Database for storing user and donation data. |
| ![.NET Icon](https://img.shields.io/badge/.NET-5.0-purple?logo=dotnet&logoColor=white) | Framework for building the application. |
| ![Entity Framework](https://img.shields.io/badge/Entity%20Framework-darkgreen?logo=ef&logoColor=white) | ORM for database management. |

---

## 📦 Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/username/repository-name.git
    ```
2. Open the project in Visual Studio.
3. Configure the database connection string in `appsettings.json`:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=GiveAidDB;Trusted_Connection=True;"
    }
    ```
4. Run the following commands in the **Package Manager Console** to create and update the database:
    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```
5. Build and run the project.

---

## 🖥️ Usage
1. Launch the application in your local environment or deploy it on a web server.
2. Access the system through the browser:
    ```bash
    http://localhost/give-aid
    ```
3. Use the login credentials or register as a new user to start donating.

---

## 🙌 Acknowledgements
Special thanks to **Aptech** for providing the platform and guidance to complete this project successfully.

---

## 📜 License
This project is licensed under the **MIT License**. Contributions and modifications are welcome!

---

## 🖋️ Author
Developed by **[Imtiaz Ali](https://github.com/imtiaza1)**.
