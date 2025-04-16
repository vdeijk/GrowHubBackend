# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Set the working directory and expose port
WORKDIR /app
EXPOSE 5000

# Copy the csproj files and restore any dependencies (via NuGet)
COPY ["FarmBackend/EntryPoint.csproj", "FarmBackend/"]
RUN dotnet restore "FarmBackend/EntryPoint.csproj"

# Copy the rest of the files and build the application
COPY . .

# Build the application
RUN dotnet publish "FarmBackend/EntryPoint.csproj" -c Release -o /app/publish

# Use the official .NET runtime image as a runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "FarmBackend.dll"]
