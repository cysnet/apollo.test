FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["apollo.test/apollo.test.csproj", "apollo.test/"]
RUN dotnet restore "apollo.test/apollo.test.csproj"
COPY . .
WORKDIR "/src/apollo.test"
RUN dotnet build "apollo.test.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "apollo.test.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "apollo.test.dll"]