FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src


COPY ["TaskMate.Api/TaskMate.Api.csproj", "TaskMate.Api/"]
COPY ["TaskMate.Application/TaskMate.Application.csproj", "TaskMate.Application/"]
COPY ["TaskMate.Domain/TaskMate.Domain.csproj", "TaskMate.Domain/"]
COPY ["TaskMate.Infrastructure/TaskMate.Infrastructure.csproj", "TaskMate.Infrastructure/"]

RUN dotnet restore "TaskMate.Api/TaskMate.Api.csproj"

COPY . .
WORKDIR "/src/TaskMate.Api"
RUN dotnet publish "TaskMate.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV DOTNET_RUNNING_IN_CONTAINER=true
ENV ASPNETCORE_URLS=http://+:80

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "TaskMate.Api.dll"]