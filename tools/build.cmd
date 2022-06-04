@echo off

set _version=0.1.1
set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

orang replace "..\src" -e csproj -c "(?<=<PackageVersion>)\d+\.\d+\.\d+(?=</PackageVersion>)" -r "%_version%" -t m r
echo.

orang delete "..\src" -a d -n "bin|obj" e --content-only -t n -y su s
echo.

dotnet restore "..\src\DotMarkdown.sln" --force /p:Configuration=Release

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild" "..\src\DotMarkdown.sln" ^
 /t:Clean ^
 /p:Configuration=Debug ^
 /v:minimal ^
 /m

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild" "..\src\DotMarkdown.sln" ^
 /t:Clean,Build ^
 /p:Configuration=Release,TreatWarningsAsErrors=true,WarningsNotAsErrors=1591 ^
 /v:normal ^
 /fl ^
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
