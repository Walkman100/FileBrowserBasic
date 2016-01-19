; FileBrowser Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

;Icon "Resources\FileBrowser.ico"
Caption "FileBrowser Installer"
Name "FileBrowser"
XPStyle on
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing FileBrowser. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\WalkmanOSS

OutFile "bin\Release\FileBrowser-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "FileBrowser Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\FileBrowser.exe"
  WriteUninstaller "FileBrowser-Uninst.exe"
SectionEnd

Section "FileBrowser Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\WalkmanOSS"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\FileBrowser.lnk" "$INSTDIR\FileBrowser.exe" "" "$INSTDIR\FileBrowser.exe" "" "" "" "FileBrowser"
  CreateShortCut "$SMPROGRAMS\WalkmanOSS\Uninstall FileBrowser.lnk" "$INSTDIR\FileBrowser-Uninst.exe" "" "" "" "" "" "Uninstall FileBrowser"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "FileBrowser Desktop Shortcut"
  CreateShortCut "$DESKTOP\FileBrowser.lnk" "$INSTDIR\FileBrowser.exe" "" "$INSTDIR\FileBrowser.exe" "" "" "" "FileBrowser"
SectionEnd

Section "FileBrowser Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\FileBrowser.lnk" "$INSTDIR\FileBrowser.exe" "" "$INSTDIR\FileBrowser.exe" "" "" "" "FileBrowser"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install FileBrowser. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/FileBrowser/blob/master/README.md#filebrowser-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\FileBrowser-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\FileBrowser.exe"
  RMDir "$INSTDIR"
  
  Delete "$SMPROGRAMS\WalkmanOSS\FileBrowser.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\WalkmanOSS\Uninstall FileBrowser.lnk"
  RMDir "$SMPROGRAMS\WalkmanOSS"
  
  Delete "$DESKTOP\FileBrowser.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\FileBrowser.lnk"   ; Remove Quick Launch shortcut
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall FileBrowser. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
