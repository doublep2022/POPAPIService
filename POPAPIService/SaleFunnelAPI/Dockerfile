FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SaleFunnelAPI/SaleFunnelAPI.csproj", "SaleFunnelAPI/"]
RUN dotnet restore "SaleFunnelAPI/SaleFunnelAPI.csproj"
COPY . .
WORKDIR "/src/SaleFunnelAPI"
RUN dotnet build "SaleFunnelAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SaleFunnelAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SaleFunnelAPI.dll"]
