﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Test-App/Test-App.csproj", "Test-App/"]
RUN dotnet restore "Test-App/Test-App.csproj"
COPY . .
WORKDIR "/src/Test-App"
RUN dotnet build "Test-App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Test-App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Test-App.dll"]
