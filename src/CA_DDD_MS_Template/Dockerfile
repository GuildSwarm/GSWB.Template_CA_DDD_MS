#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/CA_DDD_MS_Template/CA_DDD_MS_Template.API.csproj", "src/CA_DDD_MS_Template/"]
COPY ["src/CA_DDD_MS_Template.Infrastructure/CA_DDD_MS_Template.Infrastructure.csproj", "src/CA_DDD_MS_Template.Infrastructure/"]
COPY ["src/CA_DDD_MS_Template.Application/CA_DDD_MS_Template.Application.csproj", "src/CA_DDD_MS_Template.Application/"]
COPY ["src/CA_DDD_MS_Template.Domain/CA_DDD_MS_Template.Domain.csproj", "src/CA_DDD_MS_Template.Domain/"]
RUN dotnet restore "./src/CA_DDD_MS_Template/./CA_DDD_MS_Template.API.csproj"
COPY . .
WORKDIR "/src/src/CA_DDD_MS_Template"
RUN dotnet build "./CA_DDD_MS_Template.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CA_DDD_MS_Template.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CA_DDD_MS_Template.API.dll"]