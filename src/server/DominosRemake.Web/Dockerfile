FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/server/DominosRemake.Web/DominosRemake.Web.csproj", "DominosRemake.Web/"]
COPY ["src/server/DominosRemake.Identity/DominosRemake.Identity.csproj", "DominosRemake.Identity/"]
COPY ["src/server/DominosRemake.Infrastructure/DominosRemake.Infrastructure.csproj", "DominosRemake.Infrastructure/"]
RUN dotnet restore "DominosRemake.Web/DominosRemake.Web.csproj"
COPY src/server/DominosRemake.Web/ .
WORKDIR "/src/DominosRemake.Web"
RUN dotnet build "DominosRemake.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DominosRemake.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DominosRemake.Web.dll"]
