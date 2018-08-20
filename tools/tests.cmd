@echo off

"C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild" "..\DotMarkdown.sln" ^
 /t:Clean,Build ^
 /p:Configuration=Release,RunCodeAnalysis=false ^
 /v:normal ^
 /m

if errorlevel 1 (
 pause
 exit
)

dotnet test -c Release --no-build "..\src\Tests\DotMarkdown.Tests.csproj"

if errorlevel 1 (
 pause
 exit
)

echo OK
pause
