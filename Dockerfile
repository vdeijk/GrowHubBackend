# Use the official .NET SDK image as a build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY ["FarmBackend/EntryPoint.csproj", "FarmBackend/"]
RUN dotnet restore "FarmBackend/EntryPoint.csproj"

# Copy the rest of the application code
COPY FarmBackend/. ./FarmBackend/

# Build the application
WORKDIR "/app/FarmBackend"
RUN dotnet publish "EntryPoint.csproj" -c Release -o /app/publish

# Use the official .NET runtime image as a runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Expose the port
EXPOSE 5000

# Set the entry point for the application
ENTRYPOINT ["dotnet", "FarmBackend.dll"]


