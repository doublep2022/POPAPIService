FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjectDeliveryAPI/ProjectDeliveryAPI.csproj", "ProjectDeliveryAPI/"]
RUN dotnet restore "ProjectDeliveryAPI/ProjectDeliveryAPI.csproj"
COPY . .
WORKDIR "/src/ProjectDeliveryAPI"
RUN dotnet build "ProjectDeliveryAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectDeliveryAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectDeliveryAPI.dll"]