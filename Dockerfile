FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
RUN git clone https://github.com/mathpss/ConsumindoApiBrasilApi.git
WORKDIR /src/ConsumindoApiBrasilApi
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "/app/ConsumindoApiDe3°.dll"]
