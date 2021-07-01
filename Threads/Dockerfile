FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster
WORKDIR /src
COPY ["Threads.csproj"," "]
RUN dotnet restore "./Threads.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Thread.csproj" -c Release -o /app/build
RUN dotnet publish "Thread.csproj" -c Release -o /app/publish
WORKDIR /app
ENTRYPOINT ["dotnet", "Threads.dll"]

