@echo off
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0launch-instance-B.ps1" %*
if errorlevel 1 pause
