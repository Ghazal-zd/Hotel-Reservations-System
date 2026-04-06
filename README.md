Hotel Management System
A desktop-based hotel management system developed using C# and SQL Server.
The system is designed to streamline hotel operations including reservations, room management, employee roles, and automated notifications.
Features:
Reservation Management:
Create, update, and cancel reservations
Track check-in and check-out dates
Calculate stay duration automatically
Room Management:
Manage room availability and status
Track occupied vs available rooms
Support for different room types
Employee & Role-Based Access:
Role-based permissions for system users
Secure access control for different operations
Notification System:
Event-driven notifications (e.g., upcoming check-ins)
Database & T-SQL Logic:
Stored Procedures for core operations
Triggers for automated database actions
Functions for reusable logic
Security:
Password hashing for secure authentication
Basic protection of sensitive data
Technologies Used:
C# (Windows Forms)
SQL Server
T-SQL (Stored Procedures, Triggers, Functions)
Event-driven programming
ADO.NET
How to Run the System:
1. Clone the repository
2. Open the solution
3. Build the project
4. Set up the database
- Run all SQL scripts in the "Database Script" folder using SQL Server
5. Configure connection string
- Open "App.config"
- Update the connection string to match your SQL Server
6. Run the application

🔐 Default System Users
The system includes predefined roles with different permissions:
🧑‍💼 Admin
Username: admin
Password: admin
Permissions: Full access (manage rooms, reservations, employees, reports)
👤 Manager
Username: manager
Password: 1234
Permissions: Manage rooms, reservations
👨‍💻 Receptionist
Username: reception
Password: 4321
Permissions: Manage reservations
Notes:
Each role has different access levels enforced through role-based authorization
Passwords are stored securely using hashing techniques
Permissions are managed within the system based on user roles
