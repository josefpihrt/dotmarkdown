@echo off

set /p _apiKey=Enter API Key:
set _source=https://api.nuget.org/v3/index.json

set _version=0.1.0

set _filePath=..\src\DotMarkdown\bin\Release\DotMarkdown.%_version%.nupkg
dotnet nuget push "%_filePath%" -k %_apiKey% -s %_source%

echo OK
pause
