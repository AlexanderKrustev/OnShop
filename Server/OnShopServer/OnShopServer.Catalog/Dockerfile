#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OnShopServer.Catalog/OnShopServer.Catalog.csproj", "OnShopServer.Catalog/"]
RUN dotnet restore "OnShopServer.Catalog/OnShopServer.Catalog.csproj"
COPY . .
WORKDIR "/src/OnShopServer.Catalog"
RUN dotnet build "OnShopServer.Catalog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnShopServer.Catalog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnShopServer.Catalog.dll"]