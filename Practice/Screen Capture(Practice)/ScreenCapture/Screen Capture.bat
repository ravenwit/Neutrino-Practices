cls
@echo off
color 0a
if EXIST "C:\Screen Shots" goto CAPTURE
if NOT EXIST "C:\Screen Shots" goto MDFD
:CAPTURE
cd "C:\Programme Files\Screen Capture"
nircmd.exe savescreenshot "C:\Screen Shots\scr~$currdate.MM_dd_yyyy$-~$currtime.HH_mm_ss$.png"
goto END
:MDFD
md "C:\Screen Shots"
goto CAPTURE
:END
