FROM mcr.microsoft.com/dotnet/core/sdk:5.0-alpine AS build
WORKDIR /app
COPY *.sln .
COPY /*.csproj .
RUN dotnet restore
# copy full solution over
COPY . .
RUN dotnet build
# publish the API
FROM build AS publish
WORKDIR /app/webapi
RUN dotnet publish -c Release -o out
# run the api
FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-alpine AS runtime
WORKDIR /app
COPY --from=publish /app/webapi/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "webapi.dll"]