#dotnet tool install -g orang.dotnet.cli

orang delete "../src" -a d -n "bin|obj" e --content-only -t n -u -p s --align-columns
Write-Host

dotnet clean "../src/DotMarkdown.sln" -c Debug -v m /m
dotnet clean "../src/DotMarkdown.sln" -c Release -v m /m
dotnet build "../src/DotMarkdown.sln" -c Release -v n /p:TreatWarningsAsErrors=true,WarningsNotAsErrors=1591 /fl /m

if(!$?) { Read-Host; Exit }

dotnet test -c Release --no-build "../src/Tests/DotMarkdown.Tests.csproj"

if(!$?) { Read-Host; Exit }

dotnet pack -c Release --no-build -v normal "../src/DotMarkdown/DotMarkdown.csproj"

Write-Host "DONE"
Read-Host
