#dotnet tool install -g roslynator.dotnet.cli

roslynator generate-doc "../DotMarkdown.sln" `
 --properties "Configuration=Release" `
 --projects DotMarkdown `
 --heading "DotMarkdown API Reference" `
 -o "../docs/api"

roslynator list-symbols "../DotMarkdown.sln" `
 --properties "Configuration=Release" `
 --projects "DotMarkdown(netstandard1.3)" `
 --visibility public `
 --depth member `
 --ignored-parts containing-namespace assembly-attributes `
 --ignored-attributes System.Runtime.CompilerServices.InternalsVisibleToAttribute `
 --output "../docs/api.txt"

 Write-Host "DONE"
 Read-Host
