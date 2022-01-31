#!/bin/bash

# Install Java 8+
#sudo apt install openjdk-8-jre-headless

# Download current stable 2.x.x branch (Swagger and OpenAPI version 2)
#wget https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.4.25/swagger-codegen-cli-2.4.25.jar -O swagger-codegen-cli.jar

#java -jar swagger-codegen-cli.jar help

# Download current stable 3.x.x branch (OpenAPI version 3)
wget https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.31/swagger-codegen-cli-3.0.31.jar -O swagger-codegen-cli.jar

java -jar swagger-codegen-cli.jar --help
