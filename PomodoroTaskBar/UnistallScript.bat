@echo OFF
title Uninstall DeskBand
@echo ON
@setlocal enableextensions
@cd /d "%~dp0"

rem Check permissions
net session >nul 2>&1
if %errorLevel% == 0 (
    echo Rodando como administrador.
) else (
    echo Esse script necessita permissões de administrador.
	pause
    goto EXIT
)

if defined %PROGRAMFILES(x86)% (
    rem use /unregister to uninstall
    %SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /unregister /nologo /codebase "PomodoroTaskBar.dll"
) else (
    %SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /unregister /nologo /codebase "PomodoroTaskBar.dll"
)

taskkill /im explorer.exe /f
start explorer.exe

pause