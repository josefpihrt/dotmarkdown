@echo off

"C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild" "..\DotMarkdown.sln" ^
 /t:Clean ^
 /p:Configuration=Debug ^
 /v:minimal ^
 /m

"C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild" "..\DotMarkdown.sln" ^
 /t:Clean,Build ^
 /p:Configuration=Release,TreatWarningsAsErrors=true,WarningsNotAsErrors=1591 ^
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

dotnet pack -c Release --no-build -v normal "..\src\DotMarkdown\DotMarkdown.csproj"

echo OK
pause
