%windir%\system32\rundll32.exe advapi32.dll,ProcessIdleTasks
set st=%time:~0,2%:%time:~3,2%
echo _log_%st% >> log.log