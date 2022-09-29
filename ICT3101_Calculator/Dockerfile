FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ICT3101_Calculator/ICT3101_Calculator.csproj", "ICT3101_Calculator/"]
RUN dotnet restore "ICT3101_Calculator/ICT3101_Calculator.csproj"
COPY . .
WORKDIR "/src/ICT3101_Calculator"
RUN dotnet build "ICT3101_Calculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ICT3101_Calculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ICT3101_Calculator.dll"]
