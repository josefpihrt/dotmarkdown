$version=0.1.1
$apiKey = Read-Host -Prompt "Enter API Key:" -MaskInput

dotnet nuget push "../src/DotMarkdown/bin/Release/DotMarkdown.$version.nupkg" -k $apiKey -s "https://api.nuget.org/v3/index.json"

Write-Host "DONE"
Read-Host
