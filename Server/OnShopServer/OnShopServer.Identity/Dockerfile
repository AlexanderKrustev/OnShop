#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OnShopServer.Identity/OnShopServer.Identity.csproj", "OnShopServer.Identity/"]
RUN dotnet restore "OnShopServer.Identity/OnShopServer.Identity.csproj"
COPY . .
WORKDIR "/src/OnShopServer.Identity"
RUN dotnet build "OnShopServer.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnShopServer.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnShopServer.Identity.dll"]