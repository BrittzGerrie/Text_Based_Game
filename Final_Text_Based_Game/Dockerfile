FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Final_Text_Based_Game/Final_Text_Based_Game.csproj", "Final_Text_Based_Game/"]
RUN dotnet restore "Final_Text_Based_Game/Final_Text_Based_Game.csproj"
COPY . .
WORKDIR "/src/Final_Text_Based_Game"
RUN dotnet build "Final_Text_Based_Game.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Final_Text_Based_Game.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Final_Text_Based_Game.dll"]
