#!/bin/bash

REPO_NAME=$(echo $GITHUB_REPOSITORY | awk -F'/' '{print $2}')
ADD_APP_COMPONENT='builder.RootComponents.Add<App>("#app");'

cd Client
# Uncomment App component in Program.cs
sed -i -e "s/\/\/\s*$ADD_APP_COMPONENT/$ADD_APP_COMPONENT/" Program.cs
# Move index.html back into place
mv wwwroot/index.moved.html wwwroot/index.html
# Rewrite base URL of client app
sed -i -e "s/<base href=\".*\"/<base href=\"\/$REPO_NAME\/\"/" wwwroot/index.html
# Install Node packages
npm install