# Ordering Service
Currently I am working on V1. The folder structure is not as it should be.

## Technology Stack
Clean Architecture - DDD & Solid Principle  
CQRS    
ASP .NET Core Web API  
REST API - CRUD Operation  
Entity Framework Core with SQL Server  - Code First Approach  
MediatR    
FluentValidation  
AutoMapper  

Docker*

### DDD - Domain Driver Design
Not technology specific  
  
Application Layer  
    Depends upon domain model  
    Use repository interface  
    Depends on Infrastructre through DI  
Domain Model Layer  
    NOT depend upon any  
    Domain Entities, Aggregate root and Value Objects  
    Repository Contracts/Interface  
Infrastructure Layer  
    Depend upon domain model  
    Direct dependency on framework like EF.

#### Ubiquitous Language
Developer and Domain Expert  

#### Bounded Context
Sub-Domain that can use DDD   
E-Commerce - Order Management, Customer Management, Stock Management, Delivery Management,
 Payment System Management, Product Management, User Management etc.  

### CQRS
Separation of command and query  
Read and Write in different module in different DB tool  

### Eventual Consistency
All models in consistent system are stored consistently without interruption.  
In eventual consistent, the models may be inconsistent for a while.  
CQRS update reading model with asynchronous process  

### Event Sourcing
Main idea is accumulating events  
Latest status of asset is not recorded  
Instead events effecting the status are recorded.

### CQRS and Event Sourcing
Event as writing model and Final state as read model  

### Mediator Design Pattern
MediatR nuget package

## Functionality
### Use Cases
  

## Implementation
### ASP .NET Web API
Ordering.Domain - dotnet new classlib
Ordering.Application - dotnet new classlib  
Ordering.Infrastructure - dotnet new classlib
Ordering.API - dotnet new webapi  

### Nuget Packages
#### Ordering.Domain
NA  

#### Ordering.Application
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection  
dotnet add package FluentValidation  
dotnet add package FluentValidation.DependencyInjectionExtensions  
dotnet add package AutoMapper  
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection  
dotnet add package Microsoft.Extensions.Logging.Abstractions  

dotnet add reference ../Ordering.Domain/Ordering.Domain.csproj

#### Ordering.API
dotnet add package Swashbuckle.AspNetCore  

dotnet add reference ../Ordering.Application/Ordering.Application.csproj  
dotnet add reference ../Ordering.Infrastructure/Ordering.Infrastructure.csproj - Not done yet  

#### Ordering.Infrastructure

### Folder Structure
-- Ordering.Domain  
-- Ordering.Application  - CQRS
    -- Contracts - Interfaces that are implemented in Ordering.Infrastructure  
-- Ordering.API  
-- Ordering.Infrastructure

### Swagger URL
http://localhost:8003/swagger/index.html
