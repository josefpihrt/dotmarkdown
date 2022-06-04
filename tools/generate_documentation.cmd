@echo off

set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

set _roslynatorExe="..\..\roslynator\src\CommandLine\bin\Debug\net48\roslynator"
set _msbuildPath="%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin"
set _msbuildProperties="Configuration=Release"
set _rootDirectoryUrl="../../docs/api/"

%_msbuildPath%\msbuild "..\..\Roslynator\src\CommandLine.sln" /t:Clean,Build /p:Configuration=Debug /v:m /m

%_roslynatorExe% generate-doc "..\src\DotMarkdown.sln" ^
 --msbuild-path %_msbuildPath% ^
 --properties %_msbuildProperties% ^
 --projects DotMarkdown ^
 -o "..\docs\api" ^
 -h "DotMarkdown API Reference"

%_roslynatorExe% list-symbols "..\src\DotMarkdown.sln" ^
 --msbuild-path %_msbuildPath% ^
 --properties %_msbuildProperties% ^
 --projects DotMarkdown(netstandard1.3) ^
 --visibility public ^
 --depth member ^
 --ignored-parts containing-namespace assembly-attributes ^
 --ignored-attributes System.Runtime.CompilerServices.InternalsVisibleToAttribute ^
 --output "..\docs\api.txt"

echo OK
pause
