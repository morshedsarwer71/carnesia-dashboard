FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy project files
COPY ["Carnesia.Domain/Carnesia.Domain.csproj", "Carnesia.Domain/"]
COPY ["Carnesia.Application/Carnesia.Application.csproj", "Carnesia.Application/"]
COPY ["Carnesia/Carnesia.csproj", "Carnesia/"]

# Restore packages
RUN dotnet restore "Carnesia/Carnesia.csproj"

# Copy everything else
COPY . .

# Build and publish
RUN dotnet publish "Carnesia/Carnesia.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:5001

EXPOSE 5001
ENTRYPOINT ["dotnet", "Carnesia.dll"]