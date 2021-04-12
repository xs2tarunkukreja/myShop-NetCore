# Backet Service
It is v1. It may not be in proper structure.

## Technology Stack
ASP .NET Web API  
REST API - CRUD Operation  
N-Layer with Repository Pattern  
Redis  
Swagger  
Docker*

### Redis
Remote Dictionary Server  
Sharding, Cluster, Sentinel, Replication  
A long set of data type supported  

## Functionality
### Use Cases
Get Basket and Items with username  
Update Basket and Items
Delete Basket  
Checkout Basket

## Implementation
### Redis on docker
docker pull redis  
docker run -d -p 6379:6379 --name redis redis

### ASP .NET Web API
dotnet new webapi

### Nuget Packages
dotnet add package Microsoft.Extensions.Caching.StackExchangeRedis  
dotnet add package Newtonsoft.Json  
dotnet add package Swashbuckle.AspNetCore

### Folder Structure
-- Controller (Here API endpoints are declared. This are directly working with repository)  
-- Entities (Here we have kept POCO file for Mongo document.)  
-- Data - Here we have created a connection with MongoDB. It also adding seed data.  
-- Repositories - Communicating with DB based on connection/context created in Data folder  
-- appsetting.json - Have added configuration related to db.

### Swagger URL
http://localhost:8001/swagger/index.html

### Commands to check the impact of redis
docker exec -it redis sh  
redis-cli  
ping  
get key  
set key value  

KEYS *  
HGETALL "<<Name>>"
