FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App
ARG ENV

# Copy everything
COPY src/SDOH.Hackathon.PortalAPI/Portal.API ./
COPY appsettings.json ./
COPY appsettings.${ENV}.json ./
# Restore as distinct layers
RUN dotnet restore Api/Portal.API.csproj
RUN dotnet restore Data/Data.csproj
# Build and publish a release
RUN dotnet publish Data/Data.csproj -c Release -o out
RUN dotnet publish Api/Portal.API.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "DotNet.Docker.dll"]