# Discount Service
It is v1. It may not be in proper structure.

## Technology Stack
ASP .NET Web API  
REST API - CRUD Operation  
N-Layer with Repository Pattern  
PostgreSQL  
Dapper micro-orm - Fast data access  
Swagger  
Docker*

### PostgreSQL
Open Source  

### pgAdmin
Manage Portal for PostgreSQL DB  
Open Source  

### Dapper
It is a Micro-ORM tool developed by Stack Overflow team  
LightWeight  


## Functionality
### Use Cases
Get coupon with productname  
Update coupon   
Delete coupon  
Checkout coupon  

## Implementation
### PostreSQL on docker
docker pull postgres  
docker run --name postgres -d -p 5432:5432 -e POSTGRES_PASSWORD=secret postgres

### pgAdmin4 - Management tool for PostgreSQL
docker run -dp 5050:80 --name pgadmin -e PGADMIN_DEFAULT_EMAIL=user@domain.com -e PGADMIN_DEFAULT_PASSWORD=SuperSecret dpage/pgadmin4  
http://localhost:5050/browser/#  

Steps :-
1. Create server
    Name :- DiscountServer ** - Any  
    Host Name :- Your machine ip  
    user/password :- postgres and secret  
2. Create DB - DiscountDb
3. Create Table through Query Editor
    CREATE TABLE Coupon(  
        ID SERIAL PRIMARY KEY NOT NULL,  
        ProductName VARCHAR(24) NOT NULL,  
        Description TEXT,  
        Amount INT  
    );  

### ASP .NET Web API
dotnet new webapi

### Nuget Packages
dotnet add package Npgsql  
dotnet add package Dapper  
dotnet add package Swashbuckle.AspNetCore

### Folder Structure
-- Controller (Here API endpoints are declared. This are directly working with repository)  
-- Entities (Here we have kept POCO file for Mongo document.)  
-- Data - Here we have created a connection with MongoDB. It also adding seed data.  
-- Repositories - Communicating with DB based on connection/context created in Data folder  
-- appsetting.json - Have added configuration related to db.

### Swagger URL
http://localhost:8002/swagger/index.html