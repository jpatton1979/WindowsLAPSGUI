# Windows LAPS GUI

A basic GUI for Microsoft LAPS and Windows LAPS inspired by [htcfreek's implementation](https://github.com/htcfreek/SimpleLapsGui).

![image](https://github.com/user-attachments/assets/52176426-4aca-44f5-816f-e139b30de9d5)


### System requirements
- PowerShell 5.1
- Windows LAPS PowerShell module
- Domain-joined PC

### Limitations
- Since the Windows LAPS PowerShell cmdlets are only available in 64-bit mode the application build platform target must be set to "x64" to work.  As such the Setup TargetPlatform (VS Installer Project) is set to "x64".
