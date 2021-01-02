@echo off

set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild" "..\DotMarkdown.sln" ^
 /t:Build ^
 /p:Configuration=Debug ^
 /v:normal ^
 /fl ^
 /m

pause
