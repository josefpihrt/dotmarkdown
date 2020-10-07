@echo off

"C:\Program Files\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild" "..\DotMarkdown.sln" ^
 /t:Build ^
 /p:Configuration=Debug ^
 /v:normal ^
 /fl ^
 /m

pause
