[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.20
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
  Cmn1=Enables a Crestron control system to set its clock based on the||1
  Cmn2=value it\\retrieves from an NTP (Network Time Protocol) server.||1
  Cmn3=||1Currently it supports\\communication with up to four NTP servers.
  Cmn4=||2This module implements the SNTP v4\\specification which is described||1
  Cmn5=in RFC2030.\\\\A list of public NTP servers can be found here: http:
  Cmn6=//ntp.isc.org/bin/view/Servers/WebHome\\                 \\Revision||1
  Cmn7=History:\\v1.0 - Initial
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=6
  Inclusions_CDS=5
  Name=NTP Time Sync v1.0 (cm)
  SmplCName=NTP Time Sync v1.0.csp
  Code=1
  SysRev5=4.000
  SMWRev=2.02.05
  InputCue1=Debug
  InputSigType1=Digital
  InputCue2=Logging
  InputSigType2=Digital
  InputCue3=[~UNUSED~]
  InputSigType3=Digital
  InputCue4=SyncTime[#]
  InputSigType4=Digital
  OutputCue1=Busy
  OutputSigType1=Digital
  OutputCue2=[~UNUSED~]
  OutputSigType2=Digital
  OutputCue3=[~UNUSED~]
  OutputSigType3=Digital
  OutputCue4=SyncSuccessful[1]
  OutputSigType4=Digital
  OutputCue5=SyncSuccessful[2]
  OutputSigType5=Digital
  OutputCue6=SyncSuccessful[3]
  OutputSigType6=Digital
  OutputCue7=SyncSuccessful[4]
  OutputSigType7=Digital
  OutputCue8=[~UNUSED~]
  OutputSigType8=Digital
  OutputCue9=SyncFailed[#]
  OutputSigType9=Digital
  InputList2Cue1=[~UNUSED~]
  InputList2SigType1=Analog
  InputList2Cue2=[~UNUSED~]
  InputList2SigType2=Analog
  InputList2Cue3=[~UNUSED~]
  InputList2SigType3=Analog
  InputList2Cue4=[~UNUSED~]
  InputList2SigType4=Analog
  InputList2Cue5=[~UNUSED~]
  InputList2SigType5=Analog
  InputList2Cue6=[~UNUSED~]
  InputList2SigType6=Analog
  InputList2Cue7=GMT_Offset_Minutes
  InputList2SigType7=Analog
  InputList2Cue8=[~UNUSED~]
  InputList2SigType8=Serial
  InputList2Cue9=Server_IP$[#]
  InputList2SigType9=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=4
  MaxVariableInputs=7
  MinVariableInputsList2=9
  MaxVariableInputsList2=12
  MinVariableOutputs=9
  MaxVariableOutputs=12
  MinVariableOutputsList2=0
  MaxVariableOutputsList2=0
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=0
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_NTP_Time_Sync_v1_0
  SymJam=NonExclusive
  FileName=NTP Time Sync v1.0.csh
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]