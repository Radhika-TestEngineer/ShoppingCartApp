# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src.sln .
COPY src/ ./src/
COPY tests/ ./tests/
RUN dotnet restore src.sln
RUN dotnet publish src/ShoppingCart.API/ShoppingCart.API.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ShoppingCart.API.dll"]
