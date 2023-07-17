$roslynatorExe="../../roslynator/src/CommandLine/bin/Debug/net7.0/Roslynator"

dotnet restore "../../Roslynator/src/CommandLine.sln" /p:Configuration=Debug -v m
dotnet build "../../Roslynator/src/CommandLine.sln" --no-restore /p:Configuration=Debug /v:m /m

& $roslynatorExe generate-doc "../src/DotMarkdown.sln" `
 --properties "Configuration=Release" `
 --projects "DotMarkdown(netstandard1.3)" `
 --heading "DotMarkdown Reference" `
 -o "../docs/api" `
 --host docusaurus `
 --group-by-common-namespace `
 --ignored-common-parts content `
 --max-derived-types 10

# & $roslynatorExe list-symbols "../src/DotMarkdown.sln" `
#  --properties "Configuration=Release" `
#  --projects "DotMarkdown(netstandard1.3)" `
#  --visibility public `
#  --depth member `
#  --ignored-parts containing-namespace assembly-attributes `
#  --ignored-attributes System.Runtime.CompilerServices.InternalsVisibleToAttribute `
#  --output "../docs/api.txt"

Write-Host "DONE"
