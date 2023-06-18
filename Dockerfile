FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5102

ENV ASPNETCORE_URLS=http://+:5102

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Forum.csproj", "./"]
RUN dotnet restore "Forum.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Forum.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forum.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forum.dll"]
