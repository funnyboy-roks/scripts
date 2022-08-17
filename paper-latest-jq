#!/bin/bash
# ./paper-latest-jq [output-file] [MC-Version]
# Download the latest version of paper
# Requires `jq` and `wget`

# Text Colors >:D
GREEN='\033[0;32m'
YELLOW='\033[0;33m'
BLUE='\033[0;34m'

OUTPUT=$1
if [ -z "$1" ]
then
    OUTPUT='paper.jar'
fi

VERSION=$2
if [ -z "$2" ]
then
    VERSION=$(wget -O- https://papermc.io/api/v2/projects/paper | jq -r '.versions[-1]')
fi

BUILD=$(wget -O- https://papermc.io/api/v2/projects/paper/versions/${VERSION} | jq -r '.builds[-1]')
FILE="paper-${VERSION}-${BUILD}.jar"
URL="https://papermc.io/api/v2/projects/paper/versions/${VERSION}/builds/${BUILD}/downloads/${FILE}"

wget -O $OUTPUT $URL
echo "${GREEN}Downloaded latest Paper version:\n\
${BLUE}Version: ${YELLOW}${VERSION}${BLUE}\n\
Build: ${YELLOW}${BUILD}${BLUE}\n\
Output File: ${YELLOW}${OUTPUT}"
