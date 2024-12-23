# 🤝 Give Aid - Donation System 

## 📝 Description
**Give Aid** is a donation management system developed using the **Code First** approach in **.NET MVC**. This project enables users to contribute to various causes securely and efficiently. The system leverages **C#** and **Entity Framework** to dynamically create the database based on the code structure.

## Key Features
- **User Authentication**: Secure login and registration process for donors and administrators.  
- **Make Donations**: Easy and seamless process for making one-time or recurring donations.  
- **Specific Donations**: Allocate funds to specific causes or campaigns, with real-time tracking of donation progress.  
- **Donor Management**: Allow users to manage their personal information, track donation history, and view receipts.  
- **Campaign Management**: Administrators can create and manage various donation campaigns for different causes.  
- **Donation Goals**: Set donation goals for campaigns, and visually track progress toward reaching these goals.  
- **Multiple Payment Options**: Accept donations through multiple payment methods such as credit/debit cards, PayPal, or bank transfers.  
- **Donor Dashboard**: Personalized dashboard for users to view their donation history, upcoming payments, and upcoming campaigns.  
- **Cause Information**: Detailed information about each cause or campaign to help donors make informed decisions.  
- **Admin Dashboard**: Admin panel to manage users, donations, campaigns, and track real-time statistics.

---

## 🚀 Features
✨ **Code First Approach**: Automatically generates the database schema based on the application’s models, making it easier to scale and maintain.  
🔒 **Secure Login**: Robust authentication and role-based access control for users and administrators.  
🎁 **Donation Tracking**: Track specific donations and view detailed reports on donations made toward each campaign.  
📊 **Campaign Analytics**: View detailed analytics and progress reports for ongoing campaigns to assess effectiveness and user engagement.  
📅 **Recurring Donations**: Set up recurring donations, allowing donors to contribute on a regular basis (e.g., monthly, quarterly).  
💬 **Donor Feedback**: Donors can leave feedback and interact with the campaigns or causes they are supporting.  
📈 **Donation Reports**: Generate detailed reports for donors and administrators, including transaction history, donation summaries, and tax-related information.  
📱 **Responsive Design**: Optimized for all devices, ensuring a seamless donation experience on desktops, tablets, and mobile devices.  



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
A special thanks to all contributors, testers, and users who helped make this project a success. Your support is greatly appreciated!

---

## 📜 License
This project is licensed under the **MIT License**. Contributions and modifications are welcome!

---
