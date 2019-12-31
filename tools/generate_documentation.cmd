@echo off

set _roslynatorExe="..\..\roslynator\src\CommandLine\bin\Debug\net472\roslynator"
set _msbuildPath="C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin"
set _msbuildProperties="Configuration=Release"
set _rootDirectoryUrl="../../docs/api/"

%_msbuildPath%\msbuild "..\..\Roslynator\src\CommandLine.sln" /t:Clean,Build /p:Configuration=Debug /v:m /m

%_roslynatorExe% generate-doc "..\DotMarkdown.sln" ^
 --msbuild-path %_msbuildPath% ^
 --properties %_msbuildProperties% ^
 --projects DotMarkdown ^
 -o "..\docs\api" ^
 -h "DotMarkdown API Reference"

%_roslynatorExe% list-symbols "..\DotMarkdown.sln" ^
 --msbuild-path %_msbuildPath% ^
 --properties %_msbuildProperties% ^
 --projects DotMarkdown ^
 --visibility public ^
 --depth member ^
 --ignored-parts containing-namespace assembly-attributes ^
 --ignored-attributes System.Runtime.CompilerServices.InternalsVisibleToAttribute ^
 --output "..\docs\api.txt"

echo OK
pause
