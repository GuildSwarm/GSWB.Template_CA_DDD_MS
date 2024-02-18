#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Template_CA_DDD_MS/Template_CA_DDD_MS.API.csproj", "src/Template_CA_DDD_MS/"]
COPY ["src/Template_CA_DDD_MS.Infrastructure/Template_CA_DDD_MS.Infrastructure.csproj", "src/Template_CA_DDD_MS.Infrastructure/"]
COPY ["src/Template_CA_DDD_MS.Application/Template_CA_DDD_MS.Application.csproj", "src/Template_CA_DDD_MS.Application/"]
COPY ["src/Template_CA_DDD_MS.Domain/Template_CA_DDD_MS.Domain.csproj", "src/Template_CA_DDD_MS.Domain/"]
RUN dotnet restore "./src/Template_CA_DDD_MS/./Template_CA_DDD_MS.API.csproj"
COPY . .
WORKDIR "/src/src/Template_CA_DDD_MS"
RUN dotnet build "./Template_CA_DDD_MS.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Template_CA_DDD_MS.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Template_CA_DDD_MS.API.dll"]