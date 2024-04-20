# Restore Project
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

COPY . /app/

WORKDIR /app/src/

RUN dotnet restore

RUN dotnet publish -c release --runtime linux-musl-x64 -o /app --no-restore --self-contained true -p:PublishTrimmed=false


# https://hub.docker.com/_/microsoft-dotnet-runtime-deps/
FROM mcr.microsoft.com/dotnet/runtime-deps:8.0-alpine

# Only the binary "JazperDK" and "wwwroot" is needed to run the website.
COPY --from=build /app/JazperDK /app/JazperDK
COPY --from=build /app/wwwroot /app/wwwroot

WORKDIR /app

EXPOSE 8080

ENTRYPOINT ["./JazperDK"]