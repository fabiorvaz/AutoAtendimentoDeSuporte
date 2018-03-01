@echo off

set TARGET=..\SuporteSolution.sln
set CONFIGURATION=Release

set MSBUILD="C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe"
if not exist %MSBUILD% echo ERRO: arquivo nao encontrado: %MSBUILD%
if not exist %MSBUILD% goto erro

if "%TARGET%" == "" echo ERRO: nenhum arquivo informado.
if "%TARGET%" == "" goto erro

if not exist "%TARGET%" echo ERRO: arquivo nao encontrado: %1
if not exist "%TARGET%" goto erro

echo --------------------------------------------------------------
echo --- Target........: %TARGET%
echo --- Configuration.: %CONFIGURATION%
echo --------------------------------------------------------------
echo ----- MSBUILD -----
%MSBUILD% "%TARGET%" /t:Build /p:Configuration=%CONFIGURATION%
if errorlevel 1 goto erro
goto fim

:erro
pause

:fim
