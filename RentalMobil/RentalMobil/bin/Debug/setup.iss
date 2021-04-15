[Setup]
AppName=Aplikasi Rental Mobil
AppVerName=Rental Mobil Versi 1.0
AppPublisher=Kelompok 5
AllowCancelDuringInstall = yes
DefaultDirName={pf}\SI Rental
DefaultGroupName=Rental
Compression = lzma
SolidCompression = yes
OutputBaseFilename=SetupRentalMbil
AllowNoIcons = yes
AlwaysRestart = no
AlwaysShowComponentsList = no
DisableProgramGroupPage = yes
AppendDefaultDirName = yes
CreateUninstallRegKey = yes
DisableStartupPrompt = yes
LanguageDetectionMethod=none
ShowLanguageDialog=no
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\RentalMobil.exe,0
UninstallDisplayName=Rental Mobil
WindowVisible = no
AppCopyright=Copyright © 2021. Kelompok 5
FlatComponentsList = yes
PrivilegesRequired = admin
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico
;WizardImageFile=SetupModern21.bmp
;WizardSmallImageFile=SetupModernSmall21.bmp

;[Languages]
;Name: ina; MessagesFile: compiler:Indonesia.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
Source: C:\Users\User\Downloads\RentalMobilFP FIXXX\RentalMobilFP FIXXX\RentalMobil\RentalMobil\RentalMobil\bin\Debug\RentalMobil.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Users\User\Downloads\RentalMobilFP FIXXX\RentalMobilFP FIXXX\RentalMobil\RentalMobil\RentalMobil\bin\Debug\RentalMobil.exe.config; DestDir: {app}; Flags: ignoreversion
Source: C:\Users\User\Downloads\RentalMobilFP FIXXX\RentalMobilFP FIXXX\RentalMobil\RentalMobil\RentalMobil\bin\Debug\RestSharp.dll; DestDir: {app}; Flags: ignoreversion

Source: C:\Users\User\Downloads\RentalMobilFP FIXXX\RentalMobilFP FIXXX\RentalMobil\RentalMobil\RentalMobil\bin\Debug\Database\RMobil.mdb; DestDir: {app}\Database; Flags: ignoreversion



[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Rental Mobil"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue