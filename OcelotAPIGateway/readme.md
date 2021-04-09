# Ocelot API Gateway
It is v1. It may not be in proper structure.

## Technology Stack
Ocelot - Routing, Upstream, Downstream, Configuration  
ASP .NET Web App  
Gateway Aggregation Pattern - Shopping.Aggregator  
Docker*

### Gateway Routing Pattern
Route request to multiple services using a single endpoint  
Simplify Client  
Application Layer 7  
Similar to facade patter in OOD  
Act as a reverse proxy  

#### Features
Request Aggregation  
Service Discovery Integration  
Provide other cross-cutting feature such as authentication, SSL Termination and cache  
Retry policies, Circuit Breaker, QoS  
Rate Limiting and Throttling  
Load Balancing  
Logging, tracing, correlation
IP Whitelisting etc.

### BFF - Backend for Frontend Pattern
Split API Gateway into multiple API Gateway  
If your application have multiple client app  

### Ocelot API Gateway
Like set of middlewares  
Lightweight - Open Source  
Routing and Authentication  
configuration.json file.

## Functionality
### Use Cases
Route Catalog APIs with /Catalog path  
Route Basket APIs with /Basket path  
Route Discount APIs with /Discount path  
Route Ordering APIs with /Ordering path  

## Implementation

### ASP .NET Web API / Web App
dotnet new web  

### Nuget Packages
dotnet add package Ocelot 

### Folder Structure
-- ocelot.json - Have added configuration related to ocelot routing  
-- Program.cs - Update for reading ocelot.json file.  
-- Startup.cs - Add dependency of Ocelot and call the middleware.  