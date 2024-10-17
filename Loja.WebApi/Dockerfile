FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5122

#ENV ASPNETCORE_URLS=http://+:5122
ENV ASPNETCORE_HTTP_PORTS=5122


FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Loja.WebApi/Loja.WebApi.csproj", "Loja.WebApi/"]
RUN dotnet restore "Loja.WebApi/Loja.WebApi.csproj"
COPY . .
WORKDIR "/src/Loja.WebApi"
RUN dotnet build "Loja.WebApi.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Loja.WebApi.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Loja.WebApi.dll"]
