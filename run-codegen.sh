#!/bin/bash
mkdir -p samples
# alarms
mkdir -p samples/alarms
rm -rf samples/alarms
java -jar swagger-codegen-cli.jar generate -i open-api/alarms.json -l csharp -o samples/alarms
# alerts
mkdir -p samples/alerts
rm -rf samples/alerts
java -jar swagger-codegen-cli.jar generate -i open-api/alerts.json -l csharp -o samples/alerts
# cameras
mkdir -p samples/cameras
rm -rf samples/cameras
java -jar swagger-codegen-cli.jar generate -i open-api/cameras.json -l csharp -o samples/cameras
# centroids
mkdir -p samples/centroids
rm -rf samples/centroids
java -jar swagger-codegen-cli.jar generate -i open-api/centroids.json -l csharp -o samples/centroids
# graphics
mkdir -p samples/graphics
rm -rf samples/graphics
java -jar swagger-codegen-cli.jar generate -i open-api/graphics.json -l csharp -o samples/graphics
# gtctracks
mkdir -p samples/gtctracks
rm -rf samples/gtctracks
java -jar swagger-codegen-cli.jar generate -i open-api/gtctracks.json -l csharp -o samples/gtctracks
# radarimages
mkdir -p samples/radarimages
rm -rf samples/radarimages
java -jar swagger-codegen-cli.jar generate -i open-api/radarimages.json -l csharp -o samples/radarimages
# radars
mkdir -p samples/radars
rm -rf samples/radars
java -jar swagger-codegen-cli.jar generate -i open-api/radars.json -l csharp -o samples/radars
# ships
mkdir -p samples/ships
rm -rf samples/ships
java -jar swagger-codegen-cli.jar generate -i open-api/ships.json -l csharp -o samples/ships
# stations
mkdir -p samples/stations
rm -rf samples/stations
java -jar swagger-codegen-cli.jar generate -i open-api/stations.json -l csharp -o samples/stations
# tracks
mkdir -p samples/tracks
rm -rf samples/tracks
java -jar swagger-codegen-cli.jar generate -i open-api/tracks.json -l csharp -o samples/tracks
