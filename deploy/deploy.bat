@echo off

rd /S /Q %localappdata%\Tick42\Demos\ReuseBrowserWindows
mkdir %localappdata%\Tick42\Demos\ReuseBrowserWindows

xcopy ..\ManipulateBrowserWindows\bin\Debug\*.* %localappdata%\Tick42\Demos\ReuseBrowserWindows /E /I /Y /R

xcopy .\*.json %localappdata%\Tick42\GlueDesktop\config\apps /E /I /Y /R

rd /S /Q %localappdata%\Tick42\Demos\WebMiddleMan
mkdir %localappdata%\Tick42\Demos\WebMiddleMan
xcopy ..\WebMiddleMan\* %localappdata%\Tick42\Demos\WebMiddleMan /E /I /Y /R

