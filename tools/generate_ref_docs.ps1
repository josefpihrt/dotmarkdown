roslynator generate-doc "../src/DotMarkdown.sln" `
 --properties "Configuration=Release" `
 --projects "DotMarkdown(netstandard1.3)" "DotMarkdown.Docusaurus(netstandard1.3)" `
 --heading ".NET API Reference" `
 -o "build/ref" `
 --host docusaurus `
 --group-by-common-namespace `
 --ignored-common-parts content `
 --ignored-root-parts all `
 --max-derived-types 10

 roslynator generate-doc-root "../src/DotMarkdown.sln" `
  --properties "Configuration=Release" `
  --projects "DotMarkdown(netstandard1.3)" "DotMarkdown.Docusaurus(netstandard1.3)" `
  -o "build/ref.md" `
  --host docusaurus `
  --heading ".NET API Reference" `
  --ignored-parts content `
  --root-directory-url "ref"

Write-Host "DONE"
