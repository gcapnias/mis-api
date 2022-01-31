#!/bin/bash
mkdir -p public-api
wget --no-check-certificate https://mis.ssreng.com/api/api-docs -O api-docs.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/alarms -O public-api/alarms.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/alerts -O public-api/alerts.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/cameras -O public-api/cameras.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/centroids -O public-api/centroids.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/graphics -O public-api/graphics.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/gtctracks -O public-api/gtctracks.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/radarimages -O public-api/radarimages.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/radars -O public-api/radars.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/ships -O public-api/ships.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/stations -O public-api/stations.json
wget --no-check-certificate https://mis.ssreng.com/api/api-docs/public-api/tracks -O public-api/tracks.json
