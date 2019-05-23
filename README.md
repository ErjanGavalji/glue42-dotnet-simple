# Reusable WPF Glue42 browser window opener

## Purpose
Demonstrates an approach for launching a browser window from within a WPF
application and changing the URLs of the applications loading in this window.

## Approach
A JavaScript middle-man web application registers the
`T42.Demo.OpenReusableWindow` method to the Glue42 environment

The WPF application calls it and passes the respective URLs in the event
handlers of the two buttons

## Run
1. Load the DotNetDemo solution into Visual Studio and rebuild
2. Navigate to the `deploy subfolder` and run the deploy.bat file
3. Load Glue42
4. Start the `Window Opener Web Middle Man` application if not already started
5. Start the `Reusable Window Opener` application
6 Use the two buttons to have a browser window loaded and URLs reloaded


