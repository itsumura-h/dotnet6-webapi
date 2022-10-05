FROM mcr.microsoft.com/dotnet/sdk:6.0.400-1-jammy-amd64

RUN apt update --fix-missing && \
    apt upgrade -y
RUN apt install -y --fix-missing \
        vim \
        curl \
        wget \
        git \
        sqlite3 \
        libpq-dev

ENV PATH $PATH:/root/.dotnet/tools

WORKDIR /application
