#!/bin/bash

AQUA='\033[36m'
WHITE='\033[37m'
RESET='\033[0m'

cd ./Tests

echo -e "${AQUA}Duelist >${WHITE} Running tests with coverage..."
dotnet test /p:CollectCoverage=true /p:CoverletOutput=../TestResults/ /p:CoverletOutputFormat=lcov

if [ $? -eq 0 ]; then
    echo -e "${AQUA}Duelist >${WHITE} Tests ran successfully, generating HTML report..."

    reportgenerator -reports:../TestResults/coverage.info -targetdir:../TestResults/CoverageReport -reporttypes:Html

    if [ $? -eq 0 ]; then
        echo -e "${AQUA}Duelist >${WHITE} HTML report generated at ./TestResults/CoverageReport/index.html"
    else
        echo -e "${AQUA}Duelist >${WHITE} Failed to generate HTML report"
        exit 1
    fi
else
    echo -e "${AQUA}Duelist >${WHITE} Test run failed. Aborting."
    exit 1
fi
