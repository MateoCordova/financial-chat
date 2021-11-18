# financial-chat .Net Challenge
## Goal
The goal of this exercise is to create a simple browser-basedchat application using .NET.This application should allow several users to talkin a chatroom and also to get stock quotesfrom an API using a specific command
## Build with
- .NET 6
- SignalR
- EntityFramework
## Bonus:
- Uses Identity
- Supports Multiple Chat Rooms 
## How to use:
1. Open a command prompt on the solution folder 
2. Run: `dotnet ef database update --context ApplicationDbContext`
* If step failed, `run dotnet tool install --global dotnet-ef`
3. Run: `dotnet ef database update --context ChatContext`
4. Run: `dotnet run`
5. Open browser on designated port, and go to http://localhost:XXX/chat/seed eg http://localhost:8080/chat/seed
