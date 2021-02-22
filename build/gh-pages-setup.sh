#!/bin/bash

cd Client
# Move index.html back into place
mv wwwroot/index.moved.html wwwroot/index.html
# Rewrite base URL of client app
REPO_NAME=$(echo $GITHUB_REPOSITORY | awk -F'/' '{print $2}')
sed -i -e "s/<base href=\".*\"/<base href=\"\/$REPO_NAME\/\"/" wwwroot/index.html
# Install Node packages
npm install