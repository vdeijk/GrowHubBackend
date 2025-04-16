# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the csproj files and restore any dependencies (via NuGet)
COPY ["FarmBackend/EntryPoint.csproj", "FarmBackend/"]
RUN dotnet restore "FarmBackend/EntryPoint.csproj"

# Copy the rest of the files and build the application
COPY . .
WORKDIR "/src/FarmBackend"
RUN dotnet publish "FarmBackend.csproj" -c Release -o /app/publish

# Define the entrypoint for the container
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FarmBackend.dll"]
