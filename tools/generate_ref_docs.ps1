$roslynatorExe="../../roslynator/src/CommandLine/bin/Debug/net7.0/Roslynator"

dotnet restore "../../Roslynator/src/CommandLine.sln" /p:Configuration=Debug -v m
dotnet build "../../Roslynator/src/CommandLine.sln" --no-restore /p:Configuration=Debug /v:m /m

& $roslynatorExe generate-doc "../src/DotMarkdown.sln" `
 --properties "Configuration=Release" `
 --projects "DotMarkdown(netstandard1.3)" "DotMarkdown.Docusaurus(netstandard1.3)" `
 --heading ".NET API Reference" `
 -o "build/ref" `
 --host docusaurus `
 --group-by-common-namespace `
 --ignored-common-parts content `
 --ignored-root-parts all `
 --max-derived-types 10

 & $roslynatorExe generate-doc-root "../src/DotMarkdown.sln" `
  --properties "Configuration=Release" `
  --projects "DotMarkdown(netstandard1.3)" "DotMarkdown.Docusaurus(netstandard1.3)" `
  -o "build/ref.md" `
  --host docusaurus `
  --heading ".NET API Reference" `
  --ignored-parts content `
  --root-directory-url "ref"

Write-Host "DONE"
