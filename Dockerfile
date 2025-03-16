# https://mcr.microsoft.com/en-us/artifact/mar/dotnet/sdk/tags
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build-env

WORKDIR /Jazper.Website

COPY ["Jazper.Website/", "Jazper.Website/"]

RUN dotnet publish "Jazper.Website/Jazper.Website.csproj" -p:PublishSingleFile=false -r linux-musl-x64 --self-contained -c Release -o /publish


# https://hub.docker.com/_/alpine
FROM alpine:3

RUN apk update --no-cache && apk add --no-cache icu-libs curl

EXPOSE 8080

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS="http://0.0.0.0:8080"

WORKDIR /src

COPY --from=build-env /publish /src

CMD ["./Jazper.Website"]

HEALTHCHECK CMD curl --fail http://0.0.0.0:8080/health || exit