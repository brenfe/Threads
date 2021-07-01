FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /src



COPY . .
RUN dotnet restore
WORKDIR "/src/."
RUN dotnet build "Thread.csproj" -c Release -o /app/build
RUN dotnet publish "Thread.csproj" -c Release -o /app/publish
WORKDIR /app/publish
ENTRYPOINT ["dotnet", "Threads.dll"]

