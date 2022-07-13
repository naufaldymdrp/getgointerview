FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source
COPY . .
# restore dotnet tool
RUN dotnet tool restore
# run dotnet cake to build, test, and publish
# to publish/ directory
RUN dotnet cake

# LAYER 2 : Build Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build /source/publish .

ENV ASPNETCORE_HTTP_PORT=https://+:5001
ENV ASPNETCORE_URLS=http://+:5000

EXPOSE 5000
EXPOSE 5001

ENTRYPOINT [ "dotnet", "GetGoInterview.Api.dll"]
