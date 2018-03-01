@echo off

set origem=..\SuporteSolution\bin\Release\SuporteSolution.exe
set destino2=\\sntolvebra\discos\AUTOUPD\Dinfo\SuporteSolution[BETA].exe

dir \\sntolvebra\discos > nul
if errorlevel 1 net use \\sntolvebra\discos

rem if not exist %destino1% mkdir %destino1%
rem if not exist %destino2% mkdir %destino2%

rem copy /y Output\*.* %destino1%
rem if errorlevel 1 goto fim

rem copy /y Output\*.* %destino2%
echo  * COPY  %origem%  %destino2%
copy /y %origem% %destino2%

if errorlevel 1 goto fim

:fim
if errorlevel 1 pause
