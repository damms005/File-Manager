#TODO:
;license text
;handle failed pre-requisite installations (wic, winIns3.1, dotNet)
;-change of grading system should not cause result recompilation
;-launch compiled executable
;-LINQ is cool! Do LINQ for every LINQ'able foreach when compiling results to make result copilations faster (especially for iterations in each student, or each subjectfile foreach, including sub-method calls in-there)


!include WinVer.nsh
!include LogicLib.nsh
!include "MUI2.nsh"
!include WordFunc.nsh
!insertmacro VersionCompare
!include "DotNetVer.nsh"

!define VERSION "1.0.0.0"
!define SHORTVERSION "1.0"
!define INPUTFOLDER "C:\SharpDevelop Projects\MyTools\File Manager"

VIAddVersionKey "ProductName" "File Manager"
VIAddVersionKey "Comments" "File Management Application"
VIAddVersionKey "CompanyName" "IQ+"
VIAddVersionKey "LegalTrademarks" "File Manager is maintained by IQ+"
VIAddVersionKey "FileVersion" "${VERSION}"
VIProductVersion "${VERSION}"

Name "File Manager 1.0"
OutFile "File Manager Installer - ${SHORTVERSION}.exe"
InstallDir "$PROGRAMFILES32\File Manager"
ShowInstDetails show
!define ICON_URL "$DESKTOP\File Manager 1.0 .lnk"

;SetCompressor lzma
SetCompress off

UninstallIcon "${INPUTFOLDER}\Resources\logo.ico"

!define MUI_ICON  "${INPUTFOLDER}\Resources\logo.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "${INPUTFOLDER}\Resources\logo.bmp"
!define MUI_HEADERIMAGE_RIGHT

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_WELCOME
  ;!insertmacro MUI_PAGE_LICENSE "${INPUTFOLDER}\bin\Debug\License\license.rtf"
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------

;Languages

  !insertmacro MUI_LANGUAGE "English"

#Sections
Section "File Manager Installation"
	
	SetOutPath "$INSTDIR"
		
	${If} ${AtLeastWinXP}
		 Goto OSISSupported
	${EndIf}
	
	;end if not at least win xp
	MessageBox MB_OK|MB_ICONEXCLAMATION "File Manager can only be installed on Windows OS not less than Windows XP$\r$\nFile Manager installation will now abort"
	Quit
	
	OSISSupported:	
	${If} ${HasDotNet4.0}
		;MessageBox MB_OK|MB_ICONEXCLAMATION "You already have dotNet 4.0 installed. You can now enjoy using File Manager!"
		;installation finished
		Goto FinalizaInstallation
	${EndIf}
	
	;code reaches here means no dotNet 4 installed
	
	;We support at least windows XP
	
	;if windows xp, install prerequisite for .net 4
	${If} ${IsWinXP}
		DetailPrint "Installing pre-requisites for Win XP..."
		Call PrepareXPForDotNetInstallation
	${EndIf}
	
	Call InstallDotNet
	
	FinalizaInstallation:		
	
	File "${INPUTFOLDER}\bin\Debug\File Manager.exe"
	File "${INPUTFOLDER}\bin\Debug\SharpZipLib.dll"
	File "${INPUTFOLDER}\bin\Debug\EPocalipse.IFilter.dll"
	File "${INPUTFOLDER}\bin\Debug\itextsharp.dll"
	
	;enable in Add/Remove programs
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "DisplayName" "File Manager"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "UninstallString" "$INSTDIR\Uninstall.exe"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "DisplayIcon" "$INSTDIR\File Manager.exe,0"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "DisplayVersion" "${SHORTVERSION}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "Publisher" "IQ+"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "RegCompany" "IQPLUSKNOWLEDGE"
	WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "NoModify " 1
	WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager" "NoRepair " 1
	
	;Store installation folder
	WriteRegStr HKCU "Software\File Manager" "" $INSTDIR
	
	;cretae shortcuts
	CreateDirectory "$INSTDIR"
	CreateShortCut "${ICON_URL}" "$INSTDIR\File Manager.exe" \
		"" "" "" SW_SHOWMAXIMIZED ALT|CONTROL|SHIFT|F5 "File Manager"
	
	;Create uninstaller
	WriteUninstaller "$INSTDIR\Uninstall.exe"

	${If} ${IsWinXP}
		Call checkServicePack
	${EndIf}
			
SectionEnd

Section Uninstall
	;ADD YOUR OWN FILES HERE...
	Delete "$INSTDIR\Uninstall.exe"
	Delete "$INSTDIR\File Manager.exe"
	
	Delete "${ICON_URL}"
	
	RMDir "$INSTDIR"
	DeleteRegKey /ifempty HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\File Manager"
SectionEnd


Function .onInit
  ${IfNot} ${AtLeastWinXP}
    MessageBox MB_OK "XP and above required"
    Quit
  ${EndIf}
FunctionEnd


Function InstallDotNet

	DetailPrint "Installing dotNet 4.0 (This will take a few minutes)..."
	File "${INPUTFOLDER}\prerequisites\dotNet4_xp\dotNetFx40_Full_x86_x64.exe"
	ExecWait "$OUTDIR\dotNetFx40_Full_x86_x64.exe"
	Delete "$OUTDIR\dotNetFx40_Full_x86_x64.exe"
FunctionEnd


Function PrepareXPForDotNetInstallation
	;check for WIC	
	IfFileExists "$WINDIR\System32\WindowsCodecs.dll" WindowsInstallerThree
		

	;end if no wic
	MessageBox MB_OK|MB_ICONEXCLAMATION "You do not have Windows Installer Component. Please install File Manager with the full installer (not with File Manager Lite)"
	Quit

	
	;else, these lines before WindowsInstallerThree are executed to install WIC
	DetailPrint "Windows XP requires the Windows Imaging Components to be installed..."
	MessageBox MB_OK|MB_ICONEXCLAMATION "Windows Imaging Components will now be installed"
	;File "${INPUTFOLDER}\prerequisites\dotNet4_xp\wic_x86_enu.exe"
	ExecWait "$OUTDIR\wic_x86_enu.exe"
	Delete "$OUTDIR\wic_x86_enu.exe"
	
	WindowsInstallerThree:
	Call GetMicrosoftInstallerVersion
	
	IntCmp $R2 3 equalVersions youHaveLowerVersion DoneFinishing
	
	equalVersions:
		IntCmp $R3 1 DoneFinishing youHaveLowerVersion DoneFinishing
		
	youHaveLowerVersion:
	
		;end if no .net4
		MessageBox MB_OK|MB_ICONEXCLAMATION "You do not have Microsoft Installer version 3.1 or higher. Please install File Manager with the full installer (not with File Manager Lite)"
		Quit

		DetailPrint "dotNet 4 for Windows XP requires Windows Installer >= 3.1..."		
		MessageBox MB_OK|MB_ICONEXCLAMATION "Installing Windows Installer 3.1 will now be installed"
		;File "${INPUTFOLDER}\prerequisites\dotNet4_xp\WindowsInstaller-KB893803_3.1-v2-x86.exe"
		ExecWait "$OUTDIR\WindowsInstaller-KB893803_3.1-v2-x86.exe"
		Delete "$OUTDIR\WindowsInstaller-KB893803_3.1-v2-x86.exe"
	
	DoneFinishing:
		Return
FunctionEnd

Function GetMicrosoftInstallerVersion
	GetDllVersion "$SYSDIR\msi.dll" $R0 $R1
	IntOp $R2 $R0 >> 16
	IntOp $R2 $R2 & 0x0000FFFF ; $R2 now contains major version
	IntOp $R3 $R0 & 0x0000FFFF ; $R3 now contains minor version
	IntOp $R4 $R1 >> 16
	IntOp $R4 $R4 & 0x0000FFFF ; $R4 now contains release
	IntOp $R5 $R1 & 0x0000FFFF ; $R5 now contains build
	StrCpy $0 "$R2.$R3.$R4.$R5" ; $0 now contains string like "1.2.0.192"
FunctionEnd

Function checkServicePack
	${If} ${AtLeastServicePack} 3
		DetailPrint "Windows XP Service Pack 3 already installed..."
	${Else}
		MessageBox MB_OK|MB_ICONEXCLAMATION "In order to smoothly run File Manager on Windows XP, Please install Windows XP Service Pack 3"
	${EndIf}
FunctionEnd