@echo OFF
title Install DeskBand
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
    %SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /nologo /codebase "PomodoroTaskBar.dll"
) else (
    %SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /nologo /codebase "PomodoroTaskBar.dll"
)
pause