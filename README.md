📌 SSMS API – Onion Architecture (.NET 8)
This project is a .NET 8 Web API implementing Onion Architecture to manage Users, Roles, and UserRoles.
It follows a clean separation of concerns with four layers:

🏗 Onion Architecture Overview
Onion Architecture is a domain-centric architecture that places the application’s core logic at the center and builds outward in layers.
The rule is: outer layers depend on inner layers, but inner layers never depend on outer layers.

📂 Project Structure (4 Layers)
1. Domain Layer (SSMS.Domain)
Purpose: Contains the core entities and business rules.

What’s inside:

Entity classes: User, Role, UserRole

Business rules & validation (if any)

Key principle: No dependencies on any other project.

2. Application Layer (SSMS.Application)
Purpose: Defines the contracts (interfaces) and data transfer objects (DTOs) used between layers.

What’s inside:

DTOs – For transferring data between API and database without exposing entities directly.

Example: UserDto, RoleDto, UserRoleDto

Interfaces – For services (IUserService, IRoleService, IUserRoleService)

Key principle: Knows about the Domain layer, but no infrastructure or API logic.

3. Infrastructure Layer (SSMS.Infrastructure)
Purpose: Implements the service logic and database access.

What’s inside:

Entity Framework DbContext – AppDbContext with DbSet<User>, DbSet<Role>, DbSet<UserRole>

Service Implementations – e.g., UserService, RoleService, UserRoleService

Repositories (if needed)

Key principle: Depends on Application & Domain layers to implement interfaces.

4. API Layer (SSMS.API)
Purpose: The entry point of the application, exposing endpoints to clients.

What’s inside:

Controllers: UserController, RoleController, UserRoleController

Swagger/OpenAPI setup for testing endpoints

Dependency Injection configuration

Key principle: Talks to Application Layer interfaces; never directly accesses the database.

🔄 Flow of Control
Client sends HTTP request → API Controller

Controller calls a Service Interface from Application Layer

Service Implementation in Infrastructure Layer runs the logic and uses DbContext to access the database

Entity/DTO data flows back to Controller

Controller returns JSON response to the client

⚙️ Technologies Used
.NET 8 Web API

Entity Framework Core

SQL Server

Swagger / OpenAPI

Onion Architecture for clean separation

🚀 How to Run
Clone the repo

Update appsettings.json with your SQL Server connection string

Run migrations (if applicable)

Start the API → Open Swagger at /swagger
