#!/bin/bash
mkdir -p open-api
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/alarms.json > open-api/alarms.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/alerts.json > open-api/alerts.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/cameras.json > open-api/cameras.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/centroids.json > open-api/centroids.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/graphics.json > open-api/graphics.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/gtctracks.json > open-api/gtctracks.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/radarimages.json > open-api/radarimages.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/radars.json > open-api/radars.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/ships.json > open-api/ships.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/stations.json > open-api/stations.json
node_modules/api-spec-converter/bin/api-spec-converter --from=swagger_1 --to=swagger_2 --syntax=json --order=alpha public-api/tracks.json > open-api/tracks.json
