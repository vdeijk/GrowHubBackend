# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the csproj files and restore any dependencies (via NuGet)
COPY ["Farm Backend/Farm Backend.csproj", "Farm Backend/"]
RUN dotnet restore "Farm Backend/Farm Backend.csproj"

# Copy the rest of the files and build the application
COPY . .
WORKDIR "/src/Farm Backend"
RUN dotnet publish "Farm Backend.csproj" -c Release -o /app/publish

# Define the entrypoint for the container
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Farm Backend.dll"]
