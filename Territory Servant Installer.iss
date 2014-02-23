; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Territory Servant"
#define MyAppVersion "1.11"
#define MyAppPublisher "LVOE"
#define MyAppURL "http://territoryservant.lvoe.us"
#define MyAppExeName "Territory Servant.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{6B7D8ED2-34B8-4325-B418-DD55B811EDBB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=C:\share\Documents\LVOE\Projects\territory-servant\license.txt
OutputDir=C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release
OutputBaseFilename=Install Territory Servant
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\Territory Servant.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\BSE.Windows.Forms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\GMap.NET.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\GMap.NET.WindowsForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\icon.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\MultiLineListBox.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\PdfSharp.Charting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\PdfSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\Templates\default.xml"; DestDir: "{app}\Templates"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\share\Documents\LVOE\Projects\territory-servant\Territory Servant\bin\Release\Templates\default_a4.xml"; DestDir: "{app}\Templates"; Flags: ignoreversion recursesubdirs createallsubdirs

; settings.dat permissions fix
Source: "{app}\settings.dat"; DestDir: "{app}"; Flags: external skipifsourcedoesntexist; Permissions: everyone-full

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
/////////////////////////////////////////////////////////////////////
function oldFilesExist(): Boolean;
begin
  if(FileExists(ExpandConstant('{app}\uninstall.exe'))) then
  begin
    Result := True;
  end
  else
  begin
    Result := False;
  end;
end;

/////////////////////////////////////////////////////////////////////
function UnInstallOldVersion(): Boolean;
var
  iResultCode: Integer;
begin
    if Exec(ExpandConstant('{app}\uninstall.exe'), '','', SW_SHOW, ewWaitUntilTerminated, iResultCode) then
      Result := True
    else
      Result := False;
end;

/////////////////////////////////////////////////////////////////////
function NextButtonClick(CurPageID: Integer) : Boolean;                             
var
  ResultCode: integer;
begin                   
  //MsgBox(IntToStr(CurPageId), mbInformation, MB_OK);
  if (CurPageID=6) then
  begin
    if (oldFilesExist()) then
    begin
      MsgBox('Please uninstall the older version of Territory Servant before continuing', mbInformation, MB_OK);
      UnInstallOldVersion();
      //ShellExec('', 'exporer', '{app}', '{app}', SW_SHOW, ewNoWait, resultCode);
      Result := False;
      Exit;
    end;
  end;
  Result := True;
end;