
dotnet clean "..\DotMarkdown.sln" -c Release
dotnet build "..\DotMarkdown.sln" -c Release  /p:RunCodeAnalysis=false -v n /m

if(!$?) { Read-Host; Exit }

dotnet test -c Release --no-build "..\src\Tests\DotMarkdown.Tests.csproj"

if(!$?) { Read-Host; Exit }

Write-Host "DONE"
Read-Host
