# Catalog Service
Currently I am working on V1. The folder structure is not as it should be.

## Technology Stack
ASP .NET Web API  
REST API - CRUD Operation  
N-Layer with Repository Pattern  
MongoDB  
Swagger  
Docker*

### Mongo DB
Document Oriented DB  
BSON document(like JSON)  
Queries can be written in any field or by range  
Collection = Table and Document = Row

## Functionality
### Use Cases
Listing Product and Category  
Get Product with product Id  
Get Product with category  
Create new Product  
Update/Delete Product  

## Implementation
### Mongo DB on docker
docker pull mongo  
docker run -d -p 27017:27017 --name mongo mongo

### ASP .NET Web API
dotnet new webapi

### Nuget Packages
dotnet add package MongoDB.Driver  
dotnet add package Swashbuckle.AspNetCore

### Folder Structure
-- Controller (Here API endpoints are declared. This are directly working with repository)  
-- Entities (Here we have kept POCO file for Mongo document.)  
-- Data - Here we have created a connection with MongoDB. It also adding seed data.  
-- Repositories - Communicating with Mongo DB based on connection/context created in Data folder  
-- appsetting.json - Have added configuration related to mongo db.

### Swagger URL
http://localhost:5000/swagger/index.html

### Commands to check the impact of mongo db
docker exec -it mongo bash  
mongo  
show databases  
use CatalogDB  
show collections  
db.<<collections_name>>.find().pretty()


