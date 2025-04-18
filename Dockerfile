# Use the official .NET 8 SDK image to build the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET 8 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the .csproj file from the EntryPoint folder (which is in the root)
COPY ["EntryPoint/EntryPoint.csproj", "EntryPoint/"]

# Restore dependencies
RUN dotnet restore "EntryPoint/EntryPoint.csproj"

# Copy the rest of the application code
COPY . .

# Build the application
WORKDIR "/src/EntryPoint"
RUN dotnet build "EntryPoint.csproj" -c Release -o /app/build

# Publish the app to the /app/publish directory
FROM build AS publish
RUN dotnet publish "EntryPoint.csproj" -c Release -o /app/publish

# Copy the published app from the previous stage and set it up to run
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EntryPoint.dll"]
