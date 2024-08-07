# CourseNest (Hub for Online Courses)

## Overview

CourseNest is a web application developed using .NET Core MVC (.NET 8), MS SQL Server, Entity Framework Core, and Identity Core for authentication. It allows users to browse, register, and purchase online courses. Administrators can manage courses, users, and other administrative tasks.

## Tech Stack 🧑‍💻

- **.NET Core MVC (.NET 8)**
- **MS SQL Server (Database)**
- **Entity Framework Core (ORM)**
- **Identity Core (Authentication)**
- **Bootstrap 5 (Frontend)**

## How to Run the Project? 🌐

Assuming you have already installed Visual Studio 2022 and MS SQL Server Management Studio (SQL Server 2022), follow these steps:

1. **Clone the Project**
    ```bash
    git clone https://github.com/somesh-dawalbaje/CourseNest
    ```

2. **Open the Project in Visual Studio**
    - Locate the file `CourseNest.sln` and double-click to open it in Visual Studio.

3. **Update Connection String**
    - Open `appsettings.json` and update the connection string:
      ```json
      "ConnectionStrings": {
        "conn":  "Server=Your_Server_Name;Database=CourseNestDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
      }
      ```

4. **Delete Migrations Folder**
    - Delete the `Migrations` folder in the project.

5. **Open Package Manager Console**
    - In Visual Studio, navigate to `Tools > NuGet Package Manager > Package Manager Console`.

6. **Run Migration Commands**
    ```bash
    add-migration init
    update-database
    ```

7. **Run the Project**
    - Press `F5` in Visual Studio or use the following command in the terminal:
      ```bash
      dotnet run
      ```

## How to Register as Admin and Login? 🧑‍💻🧑‍💻

1. **Seed Default Data**
    - Open `Program.cs` and uncomment these lines:
      ```csharp
      //using(var scope = app.Services.CreateScope())
      //{
      //    await DbSeeder.SeedDefaultData(scope.ServiceProvider);
      //}
      ```
    - Run the project to seed the data, then stop the project and comment the lines again.

2. **Admin Login**
    - Use the following credentials to login as admin:
      - **Username**: admin@gmail.com
      - **Password**: Admin@123

## Data Entry 📈📉

To test the application, some initial data must be entered into the database.

### Category
- You can add categories from the admin panel.

### Course
- You can add courses from the admin panel.

### EnrollmentStatus (⚠️Important)
- EnrollmentStatus contains constants and cannot be entered through the admin panel. It must be added via SQL Server.





### Screenshots


![Screenshot 2024-07-11 221729](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/70824b56-c815-4bda-998e-e6c31c901f1b)
![Screenshot 2024-07-11 221751](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/522958b6-7d17-4817-89c7-e4c5e0cf37e6)
![Screenshot 2024-07-11 221811](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/09cfd4b3-69ea-4a0f-adf7-fd246e7a03c3)
![Screenshot 2024-07-11 221852](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/5fe891e6-fb85-40b3-b6a0-a7709f407a0e)
![Screenshot 2024-07-11 222408](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/4c2d320f-6e7c-4e0a-8343-c169638391a9)
![Screenshot 2024-07-11 221918](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/f7480020-c0bf-41de-bd36-2fa07029ae9f)
![Screenshot 2024-07-11 221938](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/beddada5-7f3f-4811-869b-8a8e69e67527)
![Screenshot 2024-07-11 221949](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/4ef3b659-f50e-42b5-b791-8529a9fbbbf4)
![Screenshot 2024-07-11 222001](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/9e42810a-56c7-4dcf-b336-358256bb81f2)
![Screenshot 2024-07-11 222015](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/125d9ada-a265-44ac-b851-a9f2e2368bf8)
![Screenshot 2024-07-11 222059](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/4a2aefca-221d-4c08-b8e9-bbb4a739f109)
![Screenshot 2024-07-11 222136](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/75213385-6554-4c7b-9f62-e59ae00f6426)
![Screenshot 2024-07-11 222145](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/e421afe1-dec7-45d2-ab6c-f8ecd99b06e5)
![Screenshot 2024-07-11 222213](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/febfa0ff-e89c-49ad-bab2-28393022fed2)
![Screenshot 2024-07-11 222233](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/309ed02e-71e6-4d2c-a47a-4b0d45f61104)
![Screenshot 2024-07-11 222245](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/fd74ded5-b225-4bd8-a7c3-c92ebdcb826b)
![Screenshot 2024-07-11 222259](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/8b666865-e9e0-4b31-9f21-73be16157319)
![Screenshot 2024-07-11 222314](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/eb26df5a-d104-48aa-b675-fd7027321414)
![Screenshot 2024-07-11 222326](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/13c110d1-fea1-4615-b551-48f852122c57)
![Screenshot 2024-07-11 222343](https://github.com/somesh-dawalbaje/Dotnet_project_CourseNest/assets/161592874/85e59725-74d1-4fc5-98b5-ee5d794757d9)
