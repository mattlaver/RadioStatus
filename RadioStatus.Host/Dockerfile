FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["RadioStatus.Host/RadioStatus.Host.csproj", "RadioStatus.Host/"]
RUN dotnet restore "RadioStatus.Host/RadioStatus.Host.csproj"
COPY . .
WORKDIR "/src/RadioStatus.Host"
RUN dotnet build "RadioStatus.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RadioStatus.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RadioStatus.Host.dll"]