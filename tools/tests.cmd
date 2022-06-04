@echo off

set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild" "..\src\DotMarkdown.sln" ^
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
