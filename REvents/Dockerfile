FROM mcr.microsoft.com/dotnet/sdk AS build


RUN curl -sL https://deb.nodesource.com/setup_20.x | bash - \
    && apt-get install -y nodejs 


WORKDIR /src
COPY ["REvents.csproj", "REvents.csproj"]

RUN dotnet restore "REvents.csproj"
COPY . .

RUN dotnet build "REvents.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "REvents.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet AS final
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
EXPOSE 443
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "REvents.dll"]
