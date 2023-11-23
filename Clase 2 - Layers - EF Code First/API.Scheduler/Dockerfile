#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API.Scheduler/API.Scheduler.csproj", "API.Scheduler/"]
RUN dotnet restore "API.Scheduler/API.Scheduler.csproj"
COPY . .
WORKDIR "/src/API.Scheduler"
RUN dotnet build "API.Scheduler.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.Scheduler.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.Scheduler.dll"]