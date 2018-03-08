using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_CISCO_C90___C60_CALL_CONTROL_V2_1
{
    public class UserModuleClass_CISCO_C90___C60_CALL_CONTROL_V2_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.BufferInput DEVICE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DEVICE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput ENTRYOFFSET;
        Crestron.Logos.SplusObjects.AnalogInput ENTRIESPERPAGE;
        Crestron.Logos.SplusObjects.AnalogInput DTMFSENDCALLSLOT;
        Crestron.Logos.SplusObjects.StringInput DTMFSEND;
        Crestron.Logos.SplusObjects.DigitalInput GETLOCALPHONEBOOK;
        Crestron.Logos.SplusObjects.AnalogInput SELECTEDENTRYNUMBER;
        Crestron.Logos.SplusObjects.AnalogInput PAGESSELECTEDENTRYNUMBER;
        Crestron.Logos.SplusObjects.DigitalInput CLEARSELECTEDENTRYNUMBER;
        Crestron.Logos.SplusObjects.DigitalInput DIALSELECTEDPHONEBOOKENTRYNUMBER;
        Crestron.Logos.SplusObjects.AnalogInput PHONEBOOKSOURCEID;
        Crestron.Logos.SplusObjects.DigitalInput TOPLEVEL;
        Crestron.Logos.SplusObjects.DigitalInput UPONELEVEL;
        Crestron.Logos.SplusObjects.DigitalInput SEARCHPHONEBOOK;
        Crestron.Logos.SplusObjects.StringInput PHONEBOOKSEARCHSTRING;
        Crestron.Logos.SplusObjects.DigitalInput CALLCONTROLACCEPTINCOMINGCALL;
        Crestron.Logos.SplusObjects.DigitalInput CALLCONTROLREJECTINCOMINGCALL;
        Crestron.Logos.SplusObjects.AnalogInput DISCONNECTCALLWITHID;
        Crestron.Logos.SplusObjects.DigitalInput DISCONNECTALLCALLS;
        Crestron.Logos.SplusObjects.StringInput DIALNUMBER;
        Crestron.Logos.SplusObjects.StringInput DIALCALLRATE;
        Crestron.Logos.SplusObjects.StringInput DIALCALLPROTOCOL;
        Crestron.Logos.SplusObjects.DigitalInput DIALCALL;
        Crestron.Logos.SplusObjects.AnalogInput FARENDCONTROLCALLSLOT;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAPANLEFT;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAPANRIGHT;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERATILTUP;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERATILTDOWN;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAZOOMIN;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAZOOMOUT;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAFOCUSIN;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERAFOCUSOUT;
        Crestron.Logos.SplusObjects.DigitalInput FARENDCONTROLCAMERASTOP;
        Crestron.Logos.SplusObjects.AnalogInput FARENDCONTROLPRESENTATIONSOURCEID;
        Crestron.Logos.SplusObjects.AnalogInput FARENDCONTROLPRESETACTIVATEID;
        Crestron.Logos.SplusObjects.AnalogInput SETVOLUMELEVEL;
        Crestron.Logos.SplusObjects.DigitalInput RESYNCRONIZECALLSTATUSLIST;
        Crestron.Logos.SplusObjects.StringOutput TSTRING_RECEIVE_TEXT;
        Crestron.Logos.SplusObjects.StringInput TSTRING_SEND_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SSTRING_RECEIVE_TEXT;
        Crestron.Logos.SplusObjects.StringInput SSTRING_SEND_TEXT;
        Crestron.Logos.SplusObjects.DigitalInput DATATOTRACE;
        Crestron.Logos.SplusObjects.AnalogInput SEARCHDELAYSTART;
        Crestron.Logos.SplusObjects.AnalogInput SEARCHDELAYMOD;
        Crestron.Logos.SplusObjects.AnalogInput SEARCHDELAY;
        Crestron.Logos.SplusObjects.DigitalInput DEFAULTCALLTYPESIP;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDPHONEBOOK_NAME;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDPHONEBOOK_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput SELECTEDPHONEBOOK_CALLRATE;
        Crestron.Logos.SplusObjects.StringOutput PHONEBOOK_SEARCH_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput GETVOLUMELEVEL;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEMNAME;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEMNETWORKADDRESS;
        Crestron.Logos.SplusObjects.StringOutput GETGATEKEEPERSTATUS;
        Crestron.Logos.SplusObjects.StringOutput GETGATEKEEPERREGISTRATIONMODE;
        Crestron.Logos.SplusObjects.StringOutput GETGATEKEEPERNETWORKADDRESS;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEMH323ID;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEME164ALIAS;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEMSIPURI;
        Crestron.Logos.SplusObjects.StringOutput GETSYSTEMSOFTWAREVERSION;
        Crestron.Logos.SplusObjects.StringOutput FROM_DEVICE_CONFIGURATIONCHANGES;
        Crestron.Logos.SplusObjects.StringOutput FROM_DEVICE_STATUSCHANGES;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_ALERT_TEXT;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_ALERT_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_ISACTIVE;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_TITLE;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_OPTION1_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_OPTION2_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_OPTION3_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_OPTION4_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_PROMPT_OPTION5_TEXT;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION1_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION2_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION3_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION4_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION5_ISACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION1_WASSELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION2_WASSELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION3_WASSELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION4_WASSELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput MESSAGE_PROMPT_OPTION5_WASSELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTFIRSTPHONEBOOKITEMNUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTLASTPHONEBOOKITEMNUMBER;
        Crestron.Logos.SplusObjects.StringOutput PHONEBOOK_SELECTED_FOLDER_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput DIRECTORYDOWNLOADBUSY;
        Crestron.Logos.SplusObjects.AnalogOutput TOTALROWSFORSEARCH;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTEDISFOLDER;
        Crestron.Logos.SplusObjects.DigitalOutput SELECTEDISCONTACT;
        Crestron.Logos.SplusObjects.StringOutput CALLHISTORYNAME;
        Crestron.Logos.SplusObjects.StringOutput CALLHISTORYNUMBER;
        Crestron.Logos.SplusObjects.DigitalOutput GETREBOOTCODEC_IS_IN_PROGRESS;
        Crestron.Logos.SplusObjects.DigitalOutput SIGNALINCOMINGCALL;
        Crestron.Logos.SplusObjects.DigitalOutput DEVICE_ONLINE;
        Crestron.Logos.SplusObjects.StringOutput INCOMINGCALLNUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput NUMBEROFACTIVECALLS;
        Crestron.Logos.SplusObjects.AnalogOutput PHONEBOOKPAGESCURRENTPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput PHONEBOOKPAGESTOTALPAGES;
        Crestron.Logos.SplusObjects.DigitalOutput DIRECTORYONTOPLEVEL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> CALLSTATUS_ISCONNECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> CALLSTATUS_SUPPORTSPRESENTATION;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> CALLSTATUS_ISACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> INPUT_SOURCE_NAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PHONEBOOK_NAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PHONEBOOK_PAGES_NAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_STATUS;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_CALLTYPE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_REMOTESITE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_DURATION;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_TRANSMITCALLRATE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_RECEIVECALLRATE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CALLSTATUS_DIRECTION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> CALLSTATUS_CALLID;
        ushort SEMAPHORE = 0;
        ushort DIALSEMAPHORE = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        ushort CALLID = 0;
        CrestronString CALLRESPONSETYPE;
        CrestronString CALLSTATUS;
        ushort TMP = 0;
        CrestronString REMOTENUMBER;
        ushort CALLSLOT = 0;
        CrestronString GTEMPDISPLAYNAME;
        CrestronString GTEMPVALUE;
        CrestronString GTEMPSEGMENT;
        ushort INPUTSOURCEITEM = 0;
        ushort CONTACTITEM = 0;
        ushort ENTITYID = 0;
        CrestronString PHONEBOOKENTRYTYPE;
        CrestronString PHONEBOOKTYPE;
        ushort PREVIOUSFOUNDCONTACTITEM = 0;
        ushort NEXTAVAILABLEDIRENTRY = 0;
        ushort NEXTAVAILABLECONTACTMETHOD = 0;
        ushort INTERNALENTRYOFFSET = 0;
        CrestronString MESSAGE_PROMPT_FEEDBACKID;
        CrestronString SSEARCHTEXT;
        ushort NEXTFOLDERENTRY = 0;
        ushort PHONEBOOKPARSEFAILURE = 0;
        ushort RECEIVINGPHONEBOOK = 0;
        ushort PHONEBOOKLEVELTOTALROWS = 0;
        ushort PREVIOUSFOUNDCONTACTMETHOD = 0;
        ushort CONTACTMETHOD = 0;
        ushort SELECTEDFOLDER = 0;
        ushort [] SEARCHRESULT;
        ushort SEARCHACTIVE = 0;
        ushort SELECTEDENTRY = 0;
        ushort SELECTEDENTRYMETHOD = 0;
        ushort SEARCHINDEX = 0;
        ushort GLOBALSEARCHCOUNT = 0;
        ushort IPHONEBOOKPAGESCURRENTPAGE = 0;
        ushort IPHONEBOOKPAGESTOTALPAGES = 0;
        ushort IPHONBOOKPAGESENTRYOFFSET = 0;
        PHONEBOOK [] PHONEBOOKENTRY;
        CONTACTLIST [] CONTACT;
        private void PRINTSAVEDDATA (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 263;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 265;
                /* Trace( "{0} \t {1:d}", CONTACT [ I] . CONTACTNUMBER , (short)CONTACT[ I ].CALLTYPE) */ ; 
                __context__.SourceCodeLine = 263;
                } 
            
            __context__.SourceCodeLine = 267;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 10 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)20; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 269;
                /* Trace( "{0} \t {1:d} \t {2:d}", PHONEBOOKENTRY [ I] . ENTRYNAME , (short)PHONEBOOKENTRY[ I ].FIRSTCHILD, (short)PHONEBOOKENTRY[ I ].CHILDCOUNT) */ ; 
                __context__.SourceCodeLine = 267;
                } 
            
            
            }
            
        private void CONTACTSEARCH (  SplusExecutionContext __context__, ushort INDEXCONTACT , ushort SEARCHCOUNT ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 276;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( PHONEBOOKENTRY[ INDEXCONTACT ].FIRSTCHILD ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)((PHONEBOOKENTRY[ INDEXCONTACT ].FIRSTCHILD + PHONEBOOKENTRY[ INDEXCONTACT ].CHILDCOUNT) - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 278;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEARCHCOUNT != GLOBALSEARCHCOUNT) ) || Functions.TestForTrue ( Functions.BoolToInt ( SEARCHINDEX >= 50 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 280;
                    return ; 
                    } 
                
                __context__.SourceCodeLine = 282;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ I ].FOLDERID ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 284;
                    CONTACTSEARCH (  __context__ , (ushort)( I ), (ushort)( SEARCHCOUNT )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 288;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( Functions.Upper( PHONEBOOKSEARCHSTRING ) , Functions.Upper( PHONEBOOKENTRY[ I ].ENTRYNAME ) ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 290;
                        SEARCHINDEX = (ushort) ( (SEARCHINDEX + 1) ) ; 
                        __context__.SourceCodeLine = 291;
                        SEARCHRESULT [ SEARCHINDEX] = (ushort) ( I ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 276;
                } 
            
            
            }
            
        private void FOLDERSEARCH (  SplusExecutionContext __context__, ushort INDEXFOLDER , ushort SEARCHCOUNT ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 300;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( PHONEBOOKENTRY[ INDEXFOLDER ].FIRSTCHILD ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)((PHONEBOOKENTRY[ INDEXFOLDER ].FIRSTCHILD + PHONEBOOKENTRY[ INDEXFOLDER ].CHILDCOUNT) - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 302;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEARCHCOUNT != GLOBALSEARCHCOUNT) ) || Functions.TestForTrue ( Functions.BoolToInt ( SEARCHINDEX >= 50 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 304;
                    return ; 
                    } 
                
                __context__.SourceCodeLine = 306;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ I ].FOLDERID ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 308;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( Functions.Upper( PHONEBOOKSEARCHSTRING ) , Functions.Upper( PHONEBOOKENTRY[ I ].ENTRYNAME ) ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 310;
                        SEARCHINDEX = (ushort) ( (SEARCHINDEX + 1) ) ; 
                        __context__.SourceCodeLine = 311;
                        SEARCHRESULT [ SEARCHINDEX] = (ushort) ( I ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 313;
                    FOLDERSEARCH (  __context__ , (ushort)( I ), (ushort)( SEARCHCOUNT )) ; 
                    } 
                
                __context__.SourceCodeLine = 300;
                } 
            
            __context__.SourceCodeLine = 316;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INDEXFOLDER == SELECTEDFOLDER) ) && Functions.TestForTrue ( Functions.BoolToInt ( SEARCHINDEX < 50 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 318;
                CONTACTSEARCH (  __context__ , (ushort)( INDEXFOLDER ), (ushort)( SEARCHCOUNT )) ; 
                } 
            
            
            }
            
        private void PHONEBOOKSEARCH (  SplusExecutionContext __context__, ushort SEARCHCOUNT ) 
            { 
            ushort INDEXRESET = 0;
            
            ushort INDEXLIST = 0;
            
            
            __context__.SourceCodeLine = 327;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)50; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( INDEXRESET  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INDEXRESET  >= __FN_FORSTART_VAL__1) && (INDEXRESET  <= __FN_FOREND_VAL__1) ) : ( (INDEXRESET  <= __FN_FORSTART_VAL__1) && (INDEXRESET  >= __FN_FOREND_VAL__1) ) ; INDEXRESET  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 329;
                SEARCHRESULT [ INDEXRESET] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 330;
                SEARCHRESULT [ INDEXRESET] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 327;
                } 
            
            __context__.SourceCodeLine = 332;
            SEARCHINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 334;
            FOLDERSEARCH (  __context__ , (ushort)( SELECTEDFOLDER ), (ushort)( SEARCHCOUNT )) ; 
            __context__.SourceCodeLine = 336;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHCOUNT == GLOBALSEARCHCOUNT))  ) ) 
                { 
                __context__.SourceCodeLine = 338;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHINDEX == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 340;
                    TOTALROWSFORSEARCH  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 341;
                    PHONEBOOK_NAME [ 1]  .UpdateValue ( "No Results"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 345;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHINDEX == 50))  ) ) 
                        { 
                        __context__.SourceCodeLine = 347;
                        TOTALROWSFORSEARCH  .Value = (ushort) ( (50 + 1) ) ; 
                        __context__.SourceCodeLine = 348;
                        PHONEBOOK_NAME [ (50 + 1)]  .UpdateValue ( "More Entries Available. Refine Search."  ) ; 
                        __context__.SourceCodeLine = 349;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHINDEX == ENTRIESPERPAGE  .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 351;
                            PHONEBOOK_PAGES_NAME [ ENTRIESPERPAGE  .UshortValue]  .UpdateValue ( "More Entries Available. Refine Search."  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 356;
                        TOTALROWSFORSEARCH  .Value = (ushort) ( SEARCHINDEX ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 358;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)SEARCHINDEX; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( INDEXLIST  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (INDEXLIST  >= __FN_FORSTART_VAL__2) && (INDEXLIST  <= __FN_FOREND_VAL__2) ) : ( (INDEXLIST  <= __FN_FORSTART_VAL__2) && (INDEXLIST  >= __FN_FOREND_VAL__2) ) ; INDEXLIST  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 360;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHCOUNT != GLOBALSEARCHCOUNT))  ) ) 
                            { 
                            __context__.SourceCodeLine = 362;
                            break ; 
                            } 
                        
                        __context__.SourceCodeLine = 365;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SEARCHRESULT[ INDEXLIST ] ].FOLDERID ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 367;
                            PHONEBOOK_NAME [ INDEXLIST]  .UpdateValue ( "[+]  " + PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                            __context__.SourceCodeLine = 368;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHINDEX == (50 + 1)))  ) ) 
                                { 
                                __context__.SourceCodeLine = 370;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEXLIST < ENTRIESPERPAGE  .UshortValue ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 372;
                                    PHONEBOOK_PAGES_NAME [ ENTRIESPERPAGE  .UshortValue]  .UpdateValue ( "[+]  " + PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 377;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEXLIST < ENTRIESPERPAGE  .UshortValue ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 379;
                                    PHONEBOOK_PAGES_NAME [ ENTRIESPERPAGE  .UshortValue]  .UpdateValue ( "[+]  " + PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 385;
                            PHONEBOOK_NAME [ INDEXLIST]  .UpdateValue ( PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                            __context__.SourceCodeLine = 386;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHINDEX == (50 + 1)))  ) ) 
                                { 
                                __context__.SourceCodeLine = 388;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEXLIST < ENTRIESPERPAGE  .UshortValue ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 390;
                                    PHONEBOOK_PAGES_NAME [ ENTRIESPERPAGE  .UshortValue]  .UpdateValue ( PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 395;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEXLIST < ENTRIESPERPAGE  .UshortValue ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 397;
                                    PHONEBOOK_PAGES_NAME [ ENTRIESPERPAGE  .UshortValue]  .UpdateValue ( PHONEBOOKENTRY [ SEARCHRESULT[ INDEXLIST ]] . ENTRYNAME  ) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 358;
                        } 
                    
                    } 
                
                } 
            
            
            }
            
        private CrestronString SEARCHREPLACE (  SplusExecutionContext __context__, CrestronString DATA , CrestronString SEARCH , CrestronString REPLACE ) 
            { 
            ushort POS = 0;
            
            
            __context__.SourceCodeLine = 409;
            POS = (ushort) ( Functions.Find( SEARCH , DATA ) ) ; 
            __context__.SourceCodeLine = 410;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( POS > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 412;
                SetString ( REPLACE , (int)POS, DATA ) ; 
                __context__.SourceCodeLine = 413;
                DATA  .UpdateValue ( Functions.Mid ( DATA ,  (int) ( 1 ) ,  (int) ( POS ) ) + Functions.Mid ( DATA ,  (int) ( (POS + 2) ) ,  (int) ( Functions.Length( DATA ) ) )  ) ; 
                __context__.SourceCodeLine = 414;
                POS = (ushort) ( Functions.Find( SEARCH , DATA ) ) ; 
                __context__.SourceCodeLine = 410;
                } 
            
            __context__.SourceCodeLine = 416;
            if ( Functions.TestForTrue  ( ( 0)  ) ) 
                {
                __context__.SourceCodeLine = 416;
                Print( "searchReplace\r\n") ; 
                }
            
            __context__.SourceCodeLine = 417;
            return ( DATA ) ; 
            
            }
            
        private CrestronString UTF8TOISO8859 (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            
            __context__.SourceCodeLine = 422;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u00A6", "æ")  ) ; 
            __context__.SourceCodeLine = 423;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u00B8", "ø")  ) ; 
            __context__.SourceCodeLine = 424;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u00A5", "å")  ) ; 
            __context__.SourceCodeLine = 425;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u0086", "Æ")  ) ; 
            __context__.SourceCodeLine = 426;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u0098", "Ø")  ) ; 
            __context__.SourceCodeLine = 427;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u0085", "Å")  ) ; 
            __context__.SourceCodeLine = 428;
            DATA  .UpdateValue ( SEARCHREPLACE (  __context__ , DATA, "\u00C3\u00A9", "é")  ) ; 
            __context__.SourceCodeLine = 429;
            return ( DATA ) ; 
            
            }
            
        private void SETSELECTEDMESSAGEPROMPTRESPONSE (  SplusExecutionContext __context__, ushort OPTIONID ) 
            { 
            
            __context__.SourceCodeLine = 434;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONID == 1))  ) ) 
                {
                __context__.SourceCodeLine = 434;
                MESSAGE_PROMPT_OPTION1_WASSELECTED  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 434;
                MESSAGE_PROMPT_OPTION1_WASSELECTED  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 435;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONID == 2))  ) ) 
                {
                __context__.SourceCodeLine = 435;
                MESSAGE_PROMPT_OPTION2_WASSELECTED  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 435;
                MESSAGE_PROMPT_OPTION2_WASSELECTED  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 436;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONID == 3))  ) ) 
                {
                __context__.SourceCodeLine = 436;
                MESSAGE_PROMPT_OPTION3_WASSELECTED  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 436;
                MESSAGE_PROMPT_OPTION3_WASSELECTED  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 437;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONID == 4))  ) ) 
                {
                __context__.SourceCodeLine = 437;
                MESSAGE_PROMPT_OPTION4_WASSELECTED  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 437;
                MESSAGE_PROMPT_OPTION4_WASSELECTED  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 438;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OPTIONID == 5))  ) ) 
                {
                __context__.SourceCodeLine = 438;
                MESSAGE_PROMPT_OPTION5_WASSELECTED  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 438;
                MESSAGE_PROMPT_OPTION5_WASSELECTED  .Value = (ushort) ( 0 ) ; 
                }
            
            
            }
            
        private void RESETMESSAGEPROMPT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 443;
            MESSAGE_PROMPT_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 444;
            MESSAGE_PROMPT_FEEDBACKID  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 445;
            MESSAGE_PROMPT_TITLE  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 446;
            MESSAGE_PROMPT_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 447;
            MESSAGE_PROMPT_OPTION1_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 448;
            MESSAGE_PROMPT_OPTION2_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 449;
            MESSAGE_PROMPT_OPTION3_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 450;
            MESSAGE_PROMPT_OPTION4_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 451;
            MESSAGE_PROMPT_OPTION5_TEXT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 452;
            MESSAGE_PROMPT_OPTION1_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 453;
            MESSAGE_PROMPT_OPTION2_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 454;
            MESSAGE_PROMPT_OPTION3_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 455;
            MESSAGE_PROMPT_OPTION4_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 456;
            MESSAGE_PROMPT_OPTION5_ISACTIVE  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private CrestronString GETSTRINGAFTERTOKEN (  SplusExecutionContext __context__, CrestronString TEXT , CrestronString TOKEN ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString RETVAL;
            RETVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 463;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , TEXT ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 465;
                TEXT  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( 1 ) ,  (int) ( (Functions.Find( "\u000D\u000A" , TEXT ) - 1) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 467;
            MARKER1 = (ushort) ( (Functions.Find( TOKEN , TEXT ) + Functions.Length( TOKEN )) ) ; 
            __context__.SourceCodeLine = 468;
            MARKER2 = (ushort) ( (Functions.Length( TEXT ) - (MARKER1 - 1)) ) ; 
            __context__.SourceCodeLine = 469;
            RETVAL  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( MARKER1 ) ,  (int) ( MARKER2 ) )  ) ; 
            __context__.SourceCodeLine = 470;
            return ( RETVAL ) ; 
            
            }
            
        private CrestronString GETTAGVALUEREMOVEAMPERSANDS (  SplusExecutionContext __context__, ref CrestronString DATA ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString VALUE;
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 479;
            MARKER1 = (ushort) ( (Functions.Find( ": \u0022" , DATA ) + 3) ) ; 
            __context__.SourceCodeLine = 480;
            MARKER2 = (ushort) ( Functions.Find( "\u0022" , DATA , MARKER1 ) ) ; 
            __context__.SourceCodeLine = 481;
            VALUE  .UpdateValue ( Functions.Mid ( DATA ,  (int) ( MARKER1 ) ,  (int) ( (MARKER2 - MARKER1) ) )  ) ; 
            __context__.SourceCodeLine = 482;
            return ( VALUE ) ; 
            
            }
            
        private CrestronString GETTAGVALUE (  SplusExecutionContext __context__, ref CrestronString DATA ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString VALUE;
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 491;
            if ( Functions.TestForTrue  ( ( Functions.Find( "(ghost=True): /" , DATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 493;
                return ( "" ) ; 
                } 
            
            __context__.SourceCodeLine = 495;
            MARKER1 = (ushort) ( (Functions.Find( ": " , DATA ) + 2) ) ; 
            __context__.SourceCodeLine = 496;
            MARKER2 = (ushort) ( Functions.Find( "\u000D\u000A" , DATA ) ) ; 
            __context__.SourceCodeLine = 497;
            VALUE  .UpdateValue ( Functions.Mid ( DATA ,  (int) ( MARKER1 ) ,  (int) ( (MARKER2 - MARKER1) ) )  ) ; 
            __context__.SourceCodeLine = 498;
            return ( VALUE ) ; 
            
            }
            
        private CrestronString REMOVEAMPERSANDS (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString VALUE;
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 506;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( STR , (int)( 2 ) ) == "\u0022\u0022"))  ) ) 
                { 
                __context__.SourceCodeLine = 508;
                return ( "" ) ; 
                } 
            
            __context__.SourceCodeLine = 510;
            MARKER1 = (ushort) ( (Functions.Find( "\u0022" , STR ) + 1) ) ; 
            __context__.SourceCodeLine = 511;
            MARKER2 = (ushort) ( (Functions.Find( "\u0022" , STR , MARKER1 ) - MARKER1) ) ; 
            __context__.SourceCodeLine = 512;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MARKER2 > MARKER1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 514;
                return ( Functions.Mid ( STR ,  (int) ( MARKER1 ) ,  (int) ( MARKER2 ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 518;
                return ( STR ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private CrestronString GETSTRINGTOKENVALUE (  SplusExecutionContext __context__, CrestronString TEXT , CrestronString TOKEN ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString VALUE;
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            ushort ENDOFTOKEN = 0;
            ushort STARTOFTEXT = 0;
            ushort ENDOFTEXT = 0;
            
            CrestronString RETVAL;
            RETVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 529;
            ENDOFTOKEN = (ushort) ( (Functions.Find( TOKEN , TEXT ) + Functions.Length( TOKEN )) ) ; 
            __context__.SourceCodeLine = 530;
            STARTOFTEXT = (ushort) ( (Functions.Find( "\u0022" , TEXT , (ENDOFTOKEN + 1) ) + 1) ) ; 
            __context__.SourceCodeLine = 531;
            ENDOFTEXT = (ushort) ( Functions.Find( "\u0022" , TEXT , STARTOFTEXT ) ) ; 
            __context__.SourceCodeLine = 532;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ENDOFTEXT > STARTOFTEXT ))  ) ) 
                { 
                __context__.SourceCodeLine = 534;
                RETVAL  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( STARTOFTEXT ) ,  (int) ( (ENDOFTEXT - STARTOFTEXT) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 536;
            return ( RETVAL ) ; 
            
            }
            
        private CrestronString GETCALLRATEFROMTEXT (  SplusExecutionContext __context__, CrestronString TEXT ) 
            { 
            CrestronString RETVAL;
            RETVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 542;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXT == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 544;
                return ( TEXT ) ; 
                } 
            
            __context__.SourceCodeLine = 546;
            MakeString ( RETVAL , "{0} Kbps", TEXT ) ; 
            __context__.SourceCodeLine = 547;
            return ( RETVAL ) ; 
            
            }
            
        private CrestronString GETDURATIONFROMTEXT (  SplusExecutionContext __context__, CrestronString TEXT ) 
            { 
            CrestronString RETVAL;
            RETVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 553;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEXT == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 555;
                return ( TEXT ) ; 
                } 
            
            __context__.SourceCodeLine = 557;
            MakeString ( RETVAL , "{0} s", TEXT ) ; 
            __context__.SourceCodeLine = 558;
            return ( RETVAL ) ; 
            
            }
            
        private ushort GETCALLSLOTFROMCALLID (  SplusExecutionContext __context__, ushort CALLID ) 
            { 
            ushort CALLNUMBER = 0;
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 566;
            CALLNUMBER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 567;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)3; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 569;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLSTATUS_CALLID[ I ] .Value == CALLID))  ) ) 
                    { 
                    __context__.SourceCodeLine = 571;
                    CALLNUMBER = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 572;
                    break ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 576;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CALLSTATUS_CALLID[ I ] .Value == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (CALLNUMBER == 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 578;
                        CALLNUMBER = (ushort) ( I ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 567;
                } 
            
            __context__.SourceCodeLine = 582;
            return (ushort)( CALLNUMBER) ; 
            
            }
            
        private void CLEARCALL (  SplusExecutionContext __context__, ushort CALLSLOT ) 
            { 
            
            __context__.SourceCodeLine = 587;
            CALLSTATUS_CALLID [ CALLSLOT]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 588;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_STATUS[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 590;
                CALLSTATUS_STATUS [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 592;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_DIRECTION[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 594;
                CALLSTATUS_DIRECTION [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 596;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_CALLTYPE[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 598;
                CALLSTATUS_CALLTYPE [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 600;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_TRANSMITCALLRATE[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 602;
                CALLSTATUS_TRANSMITCALLRATE [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 604;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_RECEIVECALLRATE[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 606;
                CALLSTATUS_RECEIVECALLRATE [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 608;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_REMOTESITE[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 610;
                CALLSTATUS_REMOTESITE [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 612;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_DURATION[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 614;
                CALLSTATUS_DURATION [ CALLSLOT]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 616;
            CALLSTATUS_ISACTIVE [ CALLSLOT]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 617;
            CALLSTATUS_ISCONNECTED [ CALLSLOT]  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void RESETCALLLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 625;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)3; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 627;
                CLEARCALL (  __context__ , (ushort)( I )) ; 
                __context__.SourceCodeLine = 625;
                } 
            
            __context__.SourceCodeLine = 629;
            MakeString ( DEVICE_TX__DOLLAR__ , "xStatus Call\r\n") ; 
            
            }
            
        object RESYNCRONIZECALLSTATUSLIST_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 636;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)3; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 638;
                    CLEARCALL (  __context__ , (ushort)( I )) ; 
                    __context__.SourceCodeLine = 636;
                    } 
                
                __context__.SourceCodeLine = 640;
                MakeString ( DEVICE_TX__DOLLAR__ , "xStatus Call\r\n") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    private void RESETPHONEBOOKLIST (  SplusExecutionContext __context__ ) 
        { 
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 648;
        TOTALROWSFORSEARCH  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 650;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)255; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 652;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( PHONEBOOK_NAME[ I ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 654;
                PHONEBOOK_NAME [ I]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 650;
            } 
        
        
        }
        
    private void RESETSELECTEDPHONEBOOKITEM (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 662;
        SELECTEDPHONEBOOK_NAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 663;
        SELECTEDPHONEBOOK_NUMBER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 664;
        SELECTEDPHONEBOOK_CALLRATE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 665;
        SELECTEDISFOLDER  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 666;
        SELECTEDISCONTACT  .Value = (ushort) ( 0 ) ; 
        
        }
        
    private void DISCONNECTCALL (  SplusExecutionContext __context__, ushort CALLSLOT ) 
        { 
        
        __context__.SourceCodeLine = 671;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand Call Disconnect CallId: {0:d}\r\n", (short)CALLSTATUS_CALLID[ CALLSLOT ] .Value) ; 
        
        }
        
    private void VALIDRESPONSEFOUND (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 676;
        if ( Functions.TestForTrue  ( ( Functions.Not( DEVICE_ONLINE  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 678;
            DEVICE_ONLINE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 680;
            CreateWait ( "COMMTIMEOUT" , 2500 , COMMTIMEOUT_Callback ) ;
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 687;
            RetimeWait ( (int)2500, "COMMTIMEOUT" ) ; 
            } 
        
        
        }
        
    public void COMMTIMEOUT_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 682;
            DEVICE_ONLINE  .Value = (ushort) ( 0 ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void PARSECALLFEEDBACK (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 693;
    CALLID = (ushort) ( Functions.Atoi( Functions.Remove( " " , TEMPSTRING__DOLLAR__ ) ) ) ; 
    __context__.SourceCodeLine = 694;
    CALLSLOT = (ushort) ( GETCALLSLOTFROMCALLID( __context__ , (ushort)( CALLID ) ) ) ; 
    __context__.SourceCodeLine = 695;
    CALLSTATUS_CALLID [ CALLSLOT]  .Value = (ushort) ( CALLID ) ; 
    __context__.SourceCodeLine = 696;
    CALLRESPONSETYPE  .UpdateValue ( Functions.Remove ( ":" , TEMPSTRING__DOLLAR__ )  ) ; 
    __context__.SourceCodeLine = 697;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "(ghost=True):"))  ) ) 
        { 
        __context__.SourceCodeLine = 699;
        CLEARCALL (  __context__ , (ushort)( CALLSLOT )) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 701;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "Status:"))  ) ) 
            { 
            __context__.SourceCodeLine = 703;
            CALLSTATUS_ISACTIVE [ CALLSLOT]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 704;
            CALLSTATUS  .UpdateValue ( GETTAGVALUE (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 705;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_STATUS[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 707;
                CALLSTATUS_STATUS [ CALLSLOT]  .UpdateValue ( CALLSTATUS  ) ; 
                } 
            
            __context__.SourceCodeLine = 709;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_ISCONNECTED[ CALLSLOT ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 711;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLSTATUS == "Connected"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 713;
                    CALLSTATUS_ISCONNECTED [ CALLSLOT]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 717;
                    CALLSTATUS_ISCONNECTED [ CALLSLOT]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 721;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "RemoteNumber:"))  ) ) 
                { 
                __context__.SourceCodeLine = 723;
                if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_REMOTESITE[ CALLSLOT ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 725;
                    CALLSTATUS_REMOTESITE [ CALLSLOT]  .UpdateValue ( REMOVEAMPERSANDS (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                    __context__.SourceCodeLine = 725;
                    ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 729;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "Duration:"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 731;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_DURATION[ CALLSLOT ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 733;
                        CALLSTATUS_DURATION [ CALLSLOT]  .UpdateValue ( GETDURATIONFROMTEXT (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 737;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "CallType:"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 739;
                        if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_CALLTYPE[ CALLSLOT ] ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 741;
                            CALLSTATUS_CALLTYPE [ CALLSLOT]  .UpdateValue ( GETTAGVALUE (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 745;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "Direction:"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 747;
                            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_DIRECTION[ CALLSLOT ] ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 749;
                                CALLSTATUS_DIRECTION [ CALLSLOT]  .UpdateValue ( GETTAGVALUE (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 752;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "DisplayName:"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 754;
                                if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_REMOTESITE[ CALLSLOT ] ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 756;
                                    GTEMPDISPLAYNAME  .UpdateValue ( REMOVEAMPERSANDS (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                                    __context__.SourceCodeLine = 757;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPDISPLAYNAME == ""))  ) ) 
                                        { 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 763;
                                        CALLSTATUS_REMOTESITE [ CALLSLOT]  .UpdateValue ( GTEMPDISPLAYNAME  ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 767;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "CallbackNumber:"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 769;
                                    if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_REMOTESITE[ CALLSLOT ] ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 771;
                                        CALLSTATUS_REMOTESITE [ CALLSLOT]  .UpdateValue ( REMOVEAMPERSANDS (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 774;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "TransmitCallRate:"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 776;
                                        if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_TRANSMITCALLRATE[ CALLSLOT ] ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 778;
                                            CALLSTATUS_TRANSMITCALLRATE [ CALLSLOT]  .UpdateValue ( GETCALLRATEFROMTEXT (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 781;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALLRESPONSETYPE == "ReceiveCallRate:"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 783;
                                            if ( Functions.TestForTrue  ( ( IsSignalDefined( CALLSTATUS_RECEIVECALLRATE[ CALLSLOT ] ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 785;
                                                CALLSTATUS_RECEIVECALLRATE [ CALLSLOT]  .UpdateValue ( GETCALLRATEFROMTEXT (  __context__ , GETTAGVALUE( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                                                } 
                                            
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        }
    
    
    }
    
private void DISPLAYPHONEBOOKPAGES (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    ushort J = 0;
    
    ushort FOLDERTEMP = 0;
    
    
    __context__.SourceCodeLine = 795;
    FOLDERTEMP = (ushort) ( SELECTEDFOLDER ) ; 
    __context__.SourceCodeLine = 795;
    /* Trace( "DisplayPhonebookPages: folderTemp = {0:d}: phonebookEntry[folderTemp].childCount = {1:d}", (short)FOLDERTEMP, (short)PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT) */ ; 
    __context__.SourceCodeLine = 797;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD == (2000 + 1)) ) || Functions.TestForTrue ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == 0) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 799;
        IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 800;
        PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
        __context__.SourceCodeLine = 801;
        IPHONEBOOKPAGESTOTALPAGES = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 802;
        PHONEBOOKPAGESTOTALPAGES  .Value = (ushort) ( IPHONEBOOKPAGESTOTALPAGES ) ; 
        __context__.SourceCodeLine = 803;
        PHONEBOOK_PAGES_NAME [ 1]  .UpdateValue ( "No Contacts"  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 807;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( Functions.Min( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT , 255 ) , ENTRIESPERPAGE  .UshortValue ) != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 809;
            IPHONEBOOKPAGESTOTALPAGES = (ushort) ( ((Functions.Min( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT , 255 ) / ENTRIESPERPAGE  .UshortValue) + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 813;
            IPHONEBOOKPAGESTOTALPAGES = (ushort) ( (Functions.Min( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT , 255 ) / ENTRIESPERPAGE  .UshortValue) ) ; 
            } 
        
        __context__.SourceCodeLine = 815;
        PHONEBOOKPAGESTOTALPAGES  .Value = (ushort) ( IPHONEBOOKPAGESTOTALPAGES ) ; 
        __context__.SourceCodeLine = 816;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)ENTRIESPERPAGE  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 818;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT > SEARCHDELAYSTART  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( I , SEARCHDELAYMOD  .UshortValue ) == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 820;
                Functions.Delay (  (int) ( SEARCHDELAY  .UshortValue ) ) ; 
                } 
            
            __context__.SourceCodeLine = 822;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOLDERTEMP != SELECTEDFOLDER))  ) ) 
                { 
                __context__.SourceCodeLine = 824;
                return ; 
                } 
            
            __context__.SourceCodeLine = 826;
            J = (ushort) ( (((IPHONEBOOKPAGESCURRENTPAGE - 1) * ENTRIESPERPAGE  .UshortValue) + I) ) ; 
            __context__.SourceCodeLine = 827;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ ((J + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1) ].FOLDERID ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 829;
                PHONEBOOK_PAGES_NAME [ I]  .UpdateValue ( "[+]  " + PHONEBOOKENTRY [ ((J + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1)] . ENTRYNAME  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 833;
                PHONEBOOK_PAGES_NAME [ I]  .UpdateValue ( PHONEBOOKENTRY [ ((J + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1)] . ENTRYNAME  ) ; 
                } 
            
            __context__.SourceCodeLine = 816;
            } 
        
        } 
    
    
    }
    
private void DISPLAYPHONEBOOK (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    ushort FOLDERTEMP = 0;
    
    
    __context__.SourceCodeLine = 844;
    FOLDERTEMP = (ushort) ( SELECTEDFOLDER ) ; 
    __context__.SourceCodeLine = 846;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD == (2000 + 1)) ) || Functions.TestForTrue ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == 0) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 848;
        TOTALROWSFORSEARCH  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 849;
        PHONEBOOK_NAME [ 1]  .UpdateValue ( "No Contacts"  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 853;
        TOTALROWSFORSEARCH  .Value = (ushort) ( Functions.Min( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT , 255 ) ) ; 
        __context__.SourceCodeLine = 854;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)TOTALROWSFORSEARCH  .Value; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 856;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( PHONEBOOKENTRY[ FOLDERTEMP ].CHILDCOUNT > SEARCHDELAYSTART  .UshortValue ) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( I , SEARCHDELAYMOD  .UshortValue ) == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 858;
                Functions.Delay (  (int) ( SEARCHDELAY  .UshortValue ) ) ; 
                } 
            
            __context__.SourceCodeLine = 860;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FOLDERTEMP != SELECTEDFOLDER))  ) ) 
                { 
                __context__.SourceCodeLine = 862;
                return ; 
                } 
            
            __context__.SourceCodeLine = 865;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ ((I + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1) ].FOLDERID ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 867;
                PHONEBOOK_NAME [ I]  .UpdateValue ( "[+]  " + PHONEBOOKENTRY [ ((I + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1)] . ENTRYNAME  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 871;
                PHONEBOOK_NAME [ I]  .UpdateValue ( PHONEBOOKENTRY [ ((I + PHONEBOOKENTRY[ FOLDERTEMP ].FIRSTCHILD) - 1)] . ENTRYNAME  ) ; 
                } 
            
            __context__.SourceCodeLine = 854;
            } 
        
        } 
    
    
    }
    
private void RUNSEARCHPHONEBOOK (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    ushort NEXTENTRYTODISPLAY = 0;
    
    CrestronString PATH;
    PATH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 125, this );
    
    CrestronString SEARCHSTRING;
    SEARCHSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 81, this );
    
    ushort FIRSTENTRYTODISPLAY = 0;
    
    
    __context__.SourceCodeLine = 886;
    FIRSTENTRYTODISPLAY = (ushort) ( (20 * INTERNALENTRYOFFSET) ) ; 
    __context__.SourceCodeLine = 887;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (NEXTFOLDERENTRY != 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEXTFOLDERENTRY < 2000 ) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 889;
        PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 890;
        MakeString ( PATH , " FolderId: \u0022{0}\u0022 ", PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FOLDERID ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 894;
        PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 895;
        PATH  .UpdateValue ( ""  ) ; 
        } 
    
    __context__.SourceCodeLine = 899;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RECEIVINGPHONEBOOK == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 901;
        RECEIVINGPHONEBOOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 902;
        PREVIOUSFOUNDCONTACTITEM = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 903;
        MakeString ( SEARCHSTRING , " SearchString: \"{0}\" ", SSEARCHTEXT ) ; 
        __context__.SourceCodeLine = 904;
        MakeString ( DEVICE_TX__DOLLAR__ , "xcommand Phonebook Search PhonebookType:{0} Limit:{1:d} Offset: {2:d} {3}{4} Recursive:False\r\n", PHONEBOOKTYPE , (short)20, (short)FIRSTENTRYTODISPLAY, PATH , SEARCHSTRING ) ; 
        __context__.SourceCodeLine = 906;
        CreateWait ( "RECEIVEPHONEBOOK" , 1000 , RECEIVEPHONEBOOK_Callback ) ;
        } 
    
    
    }
    
public void RECEIVEPHONEBOOK_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 908;
            RECEIVINGPHONEBOOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 909;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PHONEBOOKPARSEFAILURE < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 911;
                GenerateUserWarning ( "Directory Download Timed Out. (Attempt: {0:d}) (Folder Name: {1}) (FolderID {2})", (short)(PHONEBOOKPARSEFAILURE + 1), PHONEBOOKENTRY [ NEXTFOLDERENTRY] . ENTRYNAME , PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FOLDERID ) ; 
                __context__.SourceCodeLine = 912;
                PHONEBOOKPARSEFAILURE = (ushort) ( (PHONEBOOKPARSEFAILURE + 1) ) ; 
                __context__.SourceCodeLine = 913;
                NEXTAVAILABLEDIRENTRY = (ushort) ( ((PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FIRSTCHILD + (20 * INTERNALENTRYOFFSET)) - 1) ) ; 
                __context__.SourceCodeLine = 914;
                PHONEBOOKENTRY [ NEXTFOLDERENTRY] . CHILDCOUNT = (ushort) ( (20 * INTERNALENTRYOFFSET) ) ; 
                __context__.SourceCodeLine = 915;
                RUNSEARCHPHONEBOOK (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 919;
                GenerateUserError ( "Directory Download Timed Out. (Folder Name: {0}) (FolderID: {1}) (Entries Expected: {2:d}) (Entries Receive: {3:d})", PHONEBOOKENTRY [ NEXTFOLDERENTRY] . ENTRYNAME , PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FOLDERID , (short)PHONEBOOKLEVELTOTALROWS, (short)PHONEBOOKENTRY[ NEXTFOLDERENTRY ].CHILDCOUNT) ; 
                __context__.SourceCodeLine = 920;
                PHONEBOOKPARSEFAILURE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 921;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKENTRY[ NEXTFOLDERENTRY ].CHILDCOUNT == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 923;
                    PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FIRSTCHILD = (ushort) ( (2000 + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 925;
                INTERNALENTRYOFFSET = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 926;
                do 
                    { 
                    __context__.SourceCodeLine = 928;
                    NEXTFOLDERENTRY = (ushort) ( (NEXTFOLDERENTRY + 1) ) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NEXTFOLDERENTRY >= 2000 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FOLDERID ) > 0 ) )) )) )); 
                __context__.SourceCodeLine = 931;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTFOLDERENTRY < 2000 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 933;
                    PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FIRSTCHILD = (ushort) ( (NEXTAVAILABLEDIRENTRY + 1) ) ; 
                    __context__.SourceCodeLine = 934;
                    RUNSEARCHPHONEBOOK (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 938;
                    SELECTEDFOLDER = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 939;
                    DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 940;
                    GenerateUserNotice ( "Directory Download Finished. (Entries: {0:d}) Last Folder Failed. (Folder Name: {1}) (FolderID: {2})", (short)NEXTAVAILABLEDIRENTRY, PHONEBOOKENTRY [ NEXTFOLDERENTRY] . ENTRYNAME , PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FOLDERID ) ; 
                    __context__.SourceCodeLine = 941;
                    DISPLAYPHONEBOOK (  __context__  ) ; 
                    __context__.SourceCodeLine = 942;
                    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 943;
                    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                    __context__.SourceCodeLine = 944;
                    DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                    __context__.SourceCodeLine = 945;
                    DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void PROCESSFEEDBACK (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 954;
    while ( Functions.TestForTrue  ( ( SEMAPHORE)  ) ) 
        { 
        __context__.SourceCodeLine = 956;
        TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Gather ( "\u000D\u000A" , DEVICE_RX__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 959;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "OK\u000D\u000A") ) || Functions.TestForTrue ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "\u000D\u000A") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 961;
            VALIDRESPONSEFOUND (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 963;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "** end\u000D\u000A"))  ) ) 
                { 
                __context__.SourceCodeLine = 965;
                VALIDRESPONSEFOUND (  __context__  ) ; 
                __context__.SourceCodeLine = 966;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RECEIVINGPHONEBOOK == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 968;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == (((PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FIRSTCHILD + (20 * INTERNALENTRYOFFSET)) + 20) - 1)) ) || Functions.TestForTrue ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == ((PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FIRSTCHILD + PHONEBOOKLEVELTOTALROWS) - 1)) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 970;
                        CancelWait ( "RECEIVEPHONEBOOK" ) ; 
                        __context__.SourceCodeLine = 971;
                        PHONEBOOKPARSEFAILURE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 972;
                        RECEIVINGPHONEBOOK = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 974;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLEDIRENTRY >= 2000 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 976;
                            SELECTEDFOLDER = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 977;
                            DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 978;
                            GenerateUserNotice ( "Directory Download Finished. Found Max Entries. (Entries: {0:d})", (short)NEXTAVAILABLEDIRENTRY) ; 
                            __context__.SourceCodeLine = 979;
                            DISPLAYPHONEBOOK (  __context__  ) ; 
                            __context__.SourceCodeLine = 980;
                            IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 981;
                            PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                            __context__.SourceCodeLine = 982;
                            DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                            __context__.SourceCodeLine = 983;
                            DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 985;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLEDIRENTRY < ((PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FIRSTCHILD + PHONEBOOKLEVELTOTALROWS) - 1) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 987;
                                INTERNALENTRYOFFSET = (ushort) ( (INTERNALENTRYOFFSET + 1) ) ; 
                                __context__.SourceCodeLine = 988;
                                RUNSEARCHPHONEBOOK (  __context__  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 990;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLEDIRENTRY >= ((PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FIRSTCHILD + PHONEBOOKLEVELTOTALROWS) - 1) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 992;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (PHONEBOOKLEVELTOTALROWS == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (INTERNALENTRYOFFSET == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 994;
                                        PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FIRSTCHILD = (ushort) ( (2000 + 1) ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 996;
                                    INTERNALENTRYOFFSET = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 997;
                                    do 
                                        { 
                                        __context__.SourceCodeLine = 999;
                                        NEXTFOLDERENTRY = (ushort) ( (NEXTFOLDERENTRY + 1) ) ; 
                                        } 
                                    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (NEXTFOLDERENTRY == 2000) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ NEXTFOLDERENTRY ].FOLDERID ) > 0 ) )) )) )); 
                                    __context__.SourceCodeLine = 1003;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTFOLDERENTRY < 2000 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1005;
                                        PHONEBOOKENTRY [ NEXTFOLDERENTRY] . FIRSTCHILD = (ushort) ( (NEXTAVAILABLEDIRENTRY + 1) ) ; 
                                        __context__.SourceCodeLine = 1006;
                                        RUNSEARCHPHONEBOOK (  __context__  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1008;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTFOLDERENTRY >= 2000 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1010;
                                            SELECTEDFOLDER = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 1011;
                                            DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
                                            __context__.SourceCodeLine = 1012;
                                            GenerateUserNotice ( "Directory Download Finished. (Entries: {0:d})", (short)NEXTAVAILABLEDIRENTRY) ; 
                                            __context__.SourceCodeLine = 1013;
                                            DISPLAYPHONEBOOK (  __context__  ) ; 
                                            __context__.SourceCodeLine = 1014;
                                            IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                                            __context__.SourceCodeLine = 1015;
                                            PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                                            __context__.SourceCodeLine = 1016;
                                            DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                                            __context__.SourceCodeLine = 1017;
                                            DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        }
                                    
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1025;
                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 1027;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "*s "))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1029;
                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 1031;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Audio ") ) || Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Video ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Preset ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Standby ") )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1033;
                        FROM_DEVICE_STATUSCHANGES  .UpdateValue ( GTEMPSEGMENT + TEMPSTRING__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1035;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Call "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1037;
                            PARSECALLFEEDBACK (  __context__  ) ; 
                            __context__.SourceCodeLine = 1038;
                            VALIDRESPONSEFOUND (  __context__  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1040;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Conference "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1042;
                                VALIDRESPONSEFOUND (  __context__  ) ; 
                                __context__.SourceCodeLine = 1043;
                                FROM_DEVICE_STATUSCHANGES  .UpdateValue ( GTEMPSEGMENT + TEMPSTRING__DOLLAR__  ) ; 
                                __context__.SourceCodeLine = 1044;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "Site"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1046;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Capabilities Presentation:" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1048;
                                        CALLID = (ushort) ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) ) ; 
                                        __context__.SourceCodeLine = 1049;
                                        CALLSLOT = (ushort) ( GETCALLSLOTFROMCALLID( __context__ , (ushort)( CALLID ) ) ) ; 
                                        __context__.SourceCodeLine = 1050;
                                        GTEMPVALUE  .UpdateValue ( GETSTRINGTOKENVALUE (  __context__ , TEMPSTRING__DOLLAR__, "Presentation:")  ) ; 
                                        __context__.SourceCodeLine = 1051;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPVALUE == "True"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1053;
                                            CALLSTATUS_SUPPORTSPRESENTATION [ CALLSLOT]  .Value = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 1057;
                                            CALLSTATUS_SUPPORTSPRESENTATION [ CALLSLOT]  .Value = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1062;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "SystemUnit "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1064;
                                    VALIDRESPONSEFOUND (  __context__  ) ; 
                                    __context__.SourceCodeLine = 1065;
                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                    __context__.SourceCodeLine = 1066;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "State "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1068;
                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                        __context__.SourceCodeLine = 1070;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "NumberOfInProgressCalls: "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1072;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "0\u000D\u000A"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1074;
                                                SIGNALINCOMINGCALL  .Value = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 1075;
                                                INCOMINGCALLNUMBER  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1078;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "NumberOfActiveCalls: "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1080;
                                                NUMBEROFACTIVECALLS  .Value = (ushort) ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) ) ; 
                                                } 
                                            
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1083;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Software "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1085;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1087;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Version: "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1089;
                                                GETSYSTEMSOFTWAREVERSION  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                } 
                                            
                                            } 
                                        
                                        }
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1093;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "H323 "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1095;
                                        VALIDRESPONSEFOUND (  __context__  ) ; 
                                        __context__.SourceCodeLine = 1096;
                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                        __context__.SourceCodeLine = 1098;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "GateKeeper "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1100;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1102;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Status: "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1104;
                                                GETGATEKEEPERSTATUS  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1106;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Address: "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1108;
                                                    GETGATEKEEPERNETWORKADDRESS  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                    } 
                                                
                                                }
                                            
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1112;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Network "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1114;
                                            VALIDRESPONSEFOUND (  __context__  ) ; 
                                            __context__.SourceCodeLine = 1115;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1117;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "1 "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1119;
                                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                __context__.SourceCodeLine = 1121;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "IPv4 "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1123;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1125;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Address: "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1127;
                                                        GETSYSTEMNETWORKADDRESS  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                } 
                                            
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1133;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "*e "))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1135;
                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 1137;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "IncomingCallIndication "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1139;
                            VALIDRESPONSEFOUND (  __context__  ) ; 
                            __context__.SourceCodeLine = 1140;
                            INCOMINGCALLNUMBER  .UpdateValue ( GETSTRINGTOKENVALUE (  __context__ , TEMPSTRING__DOLLAR__, "DisplayNameValue:")  ) ; 
                            __context__.SourceCodeLine = 1141;
                            SIGNALINCOMINGCALL  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1143;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "SString "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1145;
                                VALIDRESPONSEFOUND (  __context__  ) ; 
                                __context__.SourceCodeLine = 1146;
                                SSTRING_RECEIVE_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1148;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "TString: "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1150;
                                    VALIDRESPONSEFOUND (  __context__  ) ; 
                                    __context__.SourceCodeLine = 1151;
                                    TSTRING_RECEIVE_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1153;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Message "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1155;
                                        VALIDRESPONSEFOUND (  __context__  ) ; 
                                        __context__.SourceCodeLine = 1156;
                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                        __context__.SourceCodeLine = 1158;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Prompt "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1160;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1162;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( GTEMPSEGMENT ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "Clear" , TEMPSTRING__DOLLAR__ ) > 0 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1164;
                                                RESETMESSAGEPROMPT (  __context__  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1166;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Display "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1168;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1169;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Title: "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1171;
                                                        MESSAGE_PROMPT_TITLE  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1173;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Text: "))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1175;
                                                            MESSAGE_PROMPT_TITLE  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                            __context__.SourceCodeLine = 1176;
                                                            MESSAGE_PROMPT_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1178;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "FeedbackID: "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1180;
                                                                MESSAGE_PROMPT_FEEDBACKID  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1182;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Option.1: "))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1184;
                                                                    MESSAGE_PROMPT_OPTION1_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                    __context__.SourceCodeLine = 1185;
                                                                    MESSAGE_PROMPT_OPTION1_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 1187;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Option.2: "))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 1189;
                                                                        MESSAGE_PROMPT_OPTION2_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                        __context__.SourceCodeLine = 1190;
                                                                        MESSAGE_PROMPT_OPTION2_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 1192;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Option.3: "))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 1194;
                                                                            MESSAGE_PROMPT_OPTION3_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                            __context__.SourceCodeLine = 1195;
                                                                            MESSAGE_PROMPT_OPTION3_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 1197;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Option.4: "))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 1199;
                                                                                MESSAGE_PROMPT_OPTION4_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                                __context__.SourceCodeLine = 1200;
                                                                                MESSAGE_PROMPT_OPTION4_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 1202;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Option.5: "))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 1204;
                                                                                    MESSAGE_PROMPT_OPTION5_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                                    __context__.SourceCodeLine = 1205;
                                                                                    MESSAGE_PROMPT_OPTION5_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                                                    } 
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1208;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Response "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1210;
                                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                        __context__.SourceCodeLine = 1211;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "OptionId: "))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1213;
                                                            SETSELECTEDMESSAGEPROMPTRESPONSE (  __context__ , (ushort)( Functions.Atoi( TEMPSTRING__DOLLAR__ ) )) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1216;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Cleared ") ) || Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Clear ") )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1218;
                                                            RESETMESSAGEPROMPT (  __context__  ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1221;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Alert "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1223;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Display Text:" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1225;
                                                    MESSAGE_ALERT_TEXT  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1226;
                                                    MESSAGE_ALERT_ISACTIVE  .Value = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1228;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Cleared" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1230;
                                                        MESSAGE_ALERT_TEXT  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 1231;
                                                        MESSAGE_ALERT_ISACTIVE  .Value = (ushort) ( 0 ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                } 
                                            
                                            }
                                        
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1236;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "*c "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1238;
                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 1240;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "xConfiguration "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1242;
                                VALIDRESPONSEFOUND (  __context__  ) ; 
                                __context__.SourceCodeLine = 1243;
                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                __context__.SourceCodeLine = 1245;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Conference ") ) || Functions.TestForTrue ( Functions.BoolToInt (GTEMPSEGMENT == "Standby ") )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1247;
                                    FROM_DEVICE_CONFIGURATIONCHANGES  .UpdateValue ( GTEMPSEGMENT + TEMPSTRING__DOLLAR__  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1249;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Audio "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1251;
                                        GETVOLUMELEVEL  .Value = (ushort) ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1253;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "SystemUnit "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1255;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1257;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Name: "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1259;
                                                GETSYSTEMNAME  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1262;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "H323 "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1264;
                                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                __context__.SourceCodeLine = 1266;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Profile "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1268;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1270;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "1 "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1272;
                                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                        __context__.SourceCodeLine = 1274;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "H323Alias"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1276;
                                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                            __context__.SourceCodeLine = 1278;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "ID: "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1280;
                                                                GETSYSTEMH323ID  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1282;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "E164: "))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1284;
                                                                    GETSYSTEME164ALIAS  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1287;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Gatekeeper "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1289;
                                                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                                __context__.SourceCodeLine = 1291;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Discovery "))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1293;
                                                                    GETGATEKEEPERREGISTRATIONMODE  .UpdateValue ( GETTAGVALUE (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            }
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1299;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "SIP "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1301;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1303;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Profile "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1305;
                                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                        __context__.SourceCodeLine = 1307;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "1 "))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1309;
                                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                            __context__.SourceCodeLine = 1311;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "URI: "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1313;
                                                                GETSYSTEMSIPURI  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - 2) ) )  ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1318;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Video "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1320;
                                                        FROM_DEVICE_CONFIGURATIONCHANGES  .UpdateValue ( GTEMPSEGMENT + TEMPSTRING__DOLLAR__  ) ; 
                                                        __context__.SourceCodeLine = 1321;
                                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                        __context__.SourceCodeLine = 1323;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Input "))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1325;
                                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                            __context__.SourceCodeLine = 1327;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Source "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1329;
                                                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                                __context__.SourceCodeLine = 1331;
                                                                INPUTSOURCEITEM = (ushort) ( Functions.Atoi( GTEMPSEGMENT ) ) ; 
                                                                __context__.SourceCodeLine = 1332;
                                                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                                __context__.SourceCodeLine = 1334;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Name: "))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1336;
                                                                    INPUT_SOURCE_NAME [ INPUTSOURCEITEM]  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            } 
                                                        
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1343;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "*r "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1345;
                                VALIDRESPONSEFOUND (  __context__  ) ; 
                                __context__.SourceCodeLine = 1346;
                                RetimeWait ( (int)1000, "RECEIVEPHONEBOOK" ) ; 
                                __context__.SourceCodeLine = 1347;
                                GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                __context__.SourceCodeLine = 1348;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "BootResult "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1350;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTRING__DOLLAR__ == "(status=OK):\u000D\u000A"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1352;
                                        Functions.Pulse ( 10, GETREBOOTCODEC_IS_IN_PROGRESS ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1355;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "ResultSet "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1357;
                                        GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                        __context__.SourceCodeLine = 1358;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Contact "))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1360;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1362;
                                                CURRENTFIRSTPHONEBOOKITEMNUMBER  .Value = (ushort) ( ((INTERNALENTRYOFFSET * 20) + 1) ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 1364;
                                            CONTACTITEM = (ushort) ( Functions.Atoi( Functions.Remove( " " , TEMPSTRING__DOLLAR__ ) ) ) ; 
                                            __context__.SourceCodeLine = 1367;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREVIOUSFOUNDCONTACTITEM != CONTACTITEM))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1369;
                                                NEXTAVAILABLEDIRENTRY = (ushort) ( (NEXTAVAILABLEDIRENTRY + 1) ) ; 
                                                __context__.SourceCodeLine = 1370;
                                                NEXTAVAILABLECONTACTMETHOD = (ushort) ( (NEXTAVAILABLECONTACTMETHOD + 1) ) ; 
                                                __context__.SourceCodeLine = 1371;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLEDIRENTRY > 2000 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1373;
                                                    GenerateUserNotice ( "Directory Exceeds Module's Max Entries. (Max Entries: {0:d})", (short)2000) ; 
                                                    __context__.SourceCodeLine = 1374;
                                                    NEXTAVAILABLEDIRENTRY = (ushort) ( 2000 ) ; 
                                                    __context__.SourceCodeLine = 1375;
                                                    Functions.ClearBuffer ( DEVICE_RX__DOLLAR__ ) ; 
                                                    __context__.SourceCodeLine = 1376;
                                                    CancelWait ( "RECEIVEPHONEBOOK" ) ; 
                                                    __context__.SourceCodeLine = 1377;
                                                    DISPLAYPHONEBOOK (  __context__  ) ; 
                                                    __context__.SourceCodeLine = 1378;
                                                    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 1379;
                                                    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                                                    __context__.SourceCodeLine = 1380;
                                                    DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                                                    __context__.SourceCodeLine = 1381;
                                                    DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 1382;
                                                    RECEIVINGPHONEBOOK = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 1383;
                                                    break ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 1385;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLECONTACTMETHOD > 4000 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1387;
                                                    GenerateUserNotice ( "Directory Exceeds Module's Max Contact Methods. (Max Entries: {0:d})", (short)4000) ; 
                                                    __context__.SourceCodeLine = 1388;
                                                    NEXTAVAILABLECONTACTMETHOD = (ushort) ( 4000 ) ; 
                                                    __context__.SourceCodeLine = 1389;
                                                    Functions.ClearBuffer ( DEVICE_RX__DOLLAR__ ) ; 
                                                    __context__.SourceCodeLine = 1390;
                                                    CancelWait ( "RECEIVEPHONEBOOK" ) ; 
                                                    __context__.SourceCodeLine = 1391;
                                                    DISPLAYPHONEBOOK (  __context__  ) ; 
                                                    __context__.SourceCodeLine = 1392;
                                                    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 1393;
                                                    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                                                    __context__.SourceCodeLine = 1394;
                                                    DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                                                    __context__.SourceCodeLine = 1395;
                                                    DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 1396;
                                                    RECEIVINGPHONEBOOK = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 1397;
                                                    break ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 1399;
                                                CURRENTLASTPHONEBOOKITEMNUMBER  .Value = (ushort) ( (CURRENTLASTPHONEBOOKITEMNUMBER  .Value + 1) ) ; 
                                                __context__.SourceCodeLine = 1400;
                                                PREVIOUSFOUNDCONTACTMETHOD = (ushort) ( 1 ) ; 
                                                __context__.SourceCodeLine = 1401;
                                                PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . FIRSTCHILD = (ushort) ( NEXTAVAILABLECONTACTMETHOD ) ; 
                                                __context__.SourceCodeLine = 1402;
                                                PHONEBOOKENTRY [ NEXTFOLDERENTRY] . CHILDCOUNT = (ushort) ( (PHONEBOOKENTRY[ NEXTFOLDERENTRY ].CHILDCOUNT + 1) ) ; 
                                                __context__.SourceCodeLine = 1403;
                                                PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . PARENTFOLDER = (ushort) ( NEXTFOLDERENTRY ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 1406;
                                            GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 1407;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Name: "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1409;
                                                PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . ENTRYNAME  .UpdateValue ( UTF8TOISO8859 (  __context__ , REMOVEAMPERSANDS( __context__ , TEMPSTRING__DOLLAR__ ))  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1411;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "ContactMethod "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1413;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1414;
                                                    CONTACTMETHOD = (ushort) ( Functions.Atoi( GTEMPSEGMENT ) ) ; 
                                                    __context__.SourceCodeLine = 1415;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREVIOUSFOUNDCONTACTMETHOD != CONTACTMETHOD))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1417;
                                                        PREVIOUSFOUNDCONTACTMETHOD = (ushort) ( CONTACTMETHOD ) ; 
                                                        __context__.SourceCodeLine = 1418;
                                                        NEXTAVAILABLECONTACTMETHOD = (ushort) ( (NEXTAVAILABLECONTACTMETHOD + 1) ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 1420;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1422;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Number: "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1424;
                                                        PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . CHILDCOUNT = (ushort) ( (PHONEBOOKENTRY[ NEXTAVAILABLEDIRENTRY ].CHILDCOUNT + 1) ) ; 
                                                        __context__.SourceCodeLine = 1425;
                                                        CONTACT [ NEXTAVAILABLECONTACTMETHOD] . CONTACTNUMBER  .UpdateValue ( REMOVEAMPERSANDS (  __context__ , TEMPSTRING__DOLLAR__)  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1427;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Protocol: "))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1429;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) == "SIP"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1431;
                                                                CONTACT [ NEXTAVAILABLECONTACTMETHOD] . CALLTYPE = (ushort) ( (CONTACT[ NEXTAVAILABLECONTACTMETHOD ].CALLTYPE | 2) ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1434;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "CallRate: "))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1436;
                                                                CONTACT [ NEXTAVAILABLECONTACTMETHOD] . CALLRATE  .UpdateValue ( REMOVEAMPERSANDS (  __context__ , TEMPSTRING__DOLLAR__)  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    } 
                                                
                                                }
                                            
                                            __context__.SourceCodeLine = 1439;
                                            PREVIOUSFOUNDCONTACTITEM = (ushort) ( CONTACTITEM ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1441;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "Folder "))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1443;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEXTAVAILABLEDIRENTRY == 0))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1445;
                                                    CURRENTFIRSTPHONEBOOKITEMNUMBER  .Value = (ushort) ( ((INTERNALENTRYOFFSET * 20) + 1) ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 1447;
                                                CONTACTITEM = (ushort) ( Functions.Atoi( Functions.Remove( " " , TEMPSTRING__DOLLAR__ ) ) ) ; 
                                                __context__.SourceCodeLine = 1448;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREVIOUSFOUNDCONTACTITEM != (CONTACTITEM + 2000)))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1450;
                                                    NEXTAVAILABLEDIRENTRY = (ushort) ( (NEXTAVAILABLEDIRENTRY + 1) ) ; 
                                                    __context__.SourceCodeLine = 1451;
                                                    PHONEBOOKENTRY [ NEXTFOLDERENTRY] . CHILDCOUNT = (ushort) ( (PHONEBOOKENTRY[ NEXTFOLDERENTRY ].CHILDCOUNT + 1) ) ; 
                                                    __context__.SourceCodeLine = 1452;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEXTAVAILABLEDIRENTRY > 2000 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1454;
                                                        GenerateUserNotice ( "Directory Exceeds Module's Max Entries. (Max Entries: {0:d})", (short)2000) ; 
                                                        __context__.SourceCodeLine = 1455;
                                                        NEXTAVAILABLEDIRENTRY = (ushort) ( 2000 ) ; 
                                                        __context__.SourceCodeLine = 1456;
                                                        Functions.ClearBuffer ( DEVICE_RX__DOLLAR__ ) ; 
                                                        __context__.SourceCodeLine = 1457;
                                                        CancelWait ( "RECEIVEPHONEBOOK" ) ; 
                                                        __context__.SourceCodeLine = 1458;
                                                        DISPLAYPHONEBOOK (  __context__  ) ; 
                                                        __context__.SourceCodeLine = 1459;
                                                        IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                                                        __context__.SourceCodeLine = 1460;
                                                        PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                                                        __context__.SourceCodeLine = 1461;
                                                        DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                                                        __context__.SourceCodeLine = 1462;
                                                        DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 1463;
                                                        RECEIVINGPHONEBOOK = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 1464;
                                                        break ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 1466;
                                                    CURRENTLASTPHONEBOOKITEMNUMBER  .Value = (ushort) ( (CURRENTLASTPHONEBOOKITEMNUMBER  .Value + 1) ) ; 
                                                    __context__.SourceCodeLine = 1467;
                                                    PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . PARENTFOLDER = (ushort) ( NEXTFOLDERENTRY ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 1469;
                                                PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . FIRSTCHILD = (ushort) ( (2000 + 1) ) ; 
                                                __context__.SourceCodeLine = 1470;
                                                PHONEBOOKENTRYTYPE  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( (Functions.Find( ": " , TEMPSTRING__DOLLAR__ ) - 1) ) )  ) ; 
                                                __context__.SourceCodeLine = 1471;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKENTRYTYPE == "Name"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1473;
                                                    PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . ENTRYNAME  .UpdateValue ( UTF8TOISO8859 (  __context__ , GETTAGVALUEREMOVEAMPERSANDS( __context__ , ref TEMPSTRING__DOLLAR__ ))  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1475;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKENTRYTYPE == "FolderId"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1477;
                                                        PHONEBOOKENTRY [ NEXTAVAILABLEDIRENTRY] . FOLDERID  .UpdateValue ( GETTAGVALUEREMOVEAMPERSANDS (  __context__ ,   ref  TEMPSTRING__DOLLAR__ )  ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                __context__.SourceCodeLine = 1479;
                                                PREVIOUSFOUNDCONTACTITEM = (ushort) ( (CONTACTITEM + 2000) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1481;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "ResultInfo "))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1483;
                                                    GTEMPSEGMENT  .UpdateValue ( Functions.Remove ( "\u0020" , TEMPSTRING__DOLLAR__ )  ) ; 
                                                    __context__.SourceCodeLine = 1485;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GTEMPSEGMENT == "TotalRows: "))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1487;
                                                        PHONEBOOKLEVELTOTALROWS = (ushort) ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        } 
                                    
                                    }
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            }
        
        __context__.SourceCodeLine = 954;
        } 
    
    __context__.SourceCodeLine = 1494;
    SEMAPHORE = (ushort) ( 0 ) ; 
    
    }
    
private void RESETEVERYTHING (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    
    
    __context__.SourceCodeLine = 1501;
    TOTALROWSFORSEARCH  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1502;
    PHONEBOOKLEVELTOTALROWS = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1503;
    INTERNALENTRYOFFSET = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1504;
    SELECTEDFOLDER = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1505;
    DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 1506;
    PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1507;
    NEXTAVAILABLEDIRENTRY = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1508;
    NEXTAVAILABLECONTACTMETHOD = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1509;
    NEXTFOLDERENTRY = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1510;
    PREVIOUSFOUNDCONTACTITEM = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1511;
    CURRENTFIRSTPHONEBOOKITEMNUMBER  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1512;
    CURRENTLASTPHONEBOOKITEMNUMBER  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1513;
    PHONEBOOK_SELECTED_FOLDER_NAME  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 1514;
    RESETMESSAGEPROMPT (  __context__  ) ; 
    __context__.SourceCodeLine = 1515;
    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1516;
    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
    __context__.SourceCodeLine = 1517;
    IPHONEBOOKPAGESTOTALPAGES = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1518;
    PHONEBOOKPAGESTOTALPAGES  .Value = (ushort) ( IPHONEBOOKPAGESTOTALPAGES ) ; 
    __context__.SourceCodeLine = 1520;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)ENTRIESPERPAGE  .UshortValue; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 1522;
        PHONEBOOK_PAGES_NAME [ I]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1520;
        } 
    
    __context__.SourceCodeLine = 1525;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)2000; 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 1527;
        PHONEBOOKENTRY [ I] . PARENTFOLDER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1528;
        PHONEBOOKENTRY [ I] . FIRSTCHILD = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1529;
        Functions.ClearBuffer ( PHONEBOOKENTRY [ I] . ENTRYNAME ) ; 
        __context__.SourceCodeLine = 1530;
        Functions.ClearBuffer ( PHONEBOOKENTRY [ I] . FOLDERID ) ; 
        __context__.SourceCodeLine = 1531;
        PHONEBOOKENTRY [ I] . CHILDCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1525;
        } 
    
    __context__.SourceCodeLine = 1534;
    ushort __FN_FORSTART_VAL__3 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__3 = (ushort)4000; 
    int __FN_FORSTEP_VAL__3 = (int)1; 
    for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
        { 
        __context__.SourceCodeLine = 1536;
        CONTACT [ I] . CALLTYPE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1537;
        Functions.ClearBuffer ( CONTACT [ I] . CONTACTNUMBER ) ; 
        __context__.SourceCodeLine = 1538;
        Functions.ClearBuffer ( CONTACT [ I] . CALLRATE ) ; 
        __context__.SourceCodeLine = 1534;
        } 
    
    __context__.SourceCodeLine = 1540;
    PHONEBOOKENTRY [ 0] . FIRSTCHILD = (ushort) ( 1 ) ; 
    
    }
    
private void SETPHONEBOOKOFFSET (  SplusExecutionContext __context__, ushort NEWOFFSET ) 
    { 
    
    __context__.SourceCodeLine = 1547;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INTERNALENTRYOFFSET != NEWOFFSET))  ) ) 
        { 
        __context__.SourceCodeLine = 1549;
        INTERNALENTRYOFFSET = (ushort) ( NEWOFFSET ) ; 
        } 
    
    __context__.SourceCodeLine = 1551;
    CURRENTFIRSTPHONEBOOKITEMNUMBER  .Value = (ushort) ( (NEWOFFSET * ENTRIESPERPAGE  .UshortValue) ) ; 
    __context__.SourceCodeLine = 1552;
    CURRENTLASTPHONEBOOKITEMNUMBER  .Value = (ushort) ( CURRENTFIRSTPHONEBOOKITEMNUMBER  .Value ) ; 
    __context__.SourceCodeLine = 1552;
    /* Trace( "SetPhonebookOffset: searchActive = {0:d}", (short)SEARCHACTIVE) */ ; 
    __context__.SourceCodeLine = 1553;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEARCHACTIVE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( (NEWOFFSET + 1) <= PHONEBOOKPAGESTOTALPAGES  .Value ) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 1554;
        /* Trace( "SetPhonebookOffset: newOffset = {0:d}", (short)NEWOFFSET) */ ; 
        __context__.SourceCodeLine = 1555;
        IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( (NEWOFFSET + 1) ) ; 
        __context__.SourceCodeLine = 1555;
        /* Trace( "SetPhonebookOffset: searchActive = {0:d}: iPhonebookPagesCurrentPage = {1:d}", (short)SEARCHACTIVE, (short)IPHONEBOOKPAGESCURRENTPAGE) */ ; 
        __context__.SourceCodeLine = 1556;
        PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
        __context__.SourceCodeLine = 1557;
        DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
        } 
    
    
    }
    
object SETVOLUMELEVEL_OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1566;
        MakeString ( DEVICE_TX__DOLLAR__ , "xConfiguration Audio Volume: {0}\r\n", Functions.ItoA (  (int) ( SETVOLUMELEVEL  .UshortValue ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEVICE_RX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1571;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1573;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1574;
            PROCESSFEEDBACK (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGESSELECTEDENTRYNUMBER_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort URIENTRIESFOUND = 0;
        
        ushort FOUNDH323 = 0;
        
        ushort FOUNDSIP = 0;
        
        ushort IENTRYNUMBER = 0;
        
        
        __context__.SourceCodeLine = 1586;
        URIENTRIESFOUND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1587;
        FOUNDH323 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1588;
        FOUNDSIP = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1589;
        IENTRYNUMBER = (ushort) ( (PAGESSELECTEDENTRYNUMBER  .UshortValue + (ENTRIESPERPAGE  .UshortValue * (IPHONEBOOKPAGESCURRENTPAGE - 1))) ) ; 
        __context__.SourceCodeLine = 1591;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIRECTORYDOWNLOADBUSY  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1593;
            RESETSELECTEDPHONEBOOKITEM (  __context__  ) ; 
            __context__.SourceCodeLine = 1595;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHACTIVE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1597;
                SELECTEDENTRY = (ushort) ( SEARCHRESULT[ IENTRYNUMBER ] ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1601;
                SELECTEDENTRY = (ushort) ( ((IENTRYNUMBER + PHONEBOOKENTRY[ SELECTEDFOLDER ].FIRSTCHILD) - 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 1603;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IENTRYNUMBER > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PHONEBOOKENTRY[ SELECTEDFOLDER ].FIRSTCHILD <= 2000 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SELECTEDENTRY ].ENTRYNAME ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1605;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SELECTEDENTRY ].FOLDERID ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1609;
                    SELECTEDFOLDER = (ushort) ( SELECTEDENTRY ) ; 
                    __context__.SourceCodeLine = 1610;
                    DIRECTORYONTOPLEVEL  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1611;
                    PHONEBOOK_SELECTED_FOLDER_NAME  .UpdateValue ( PHONEBOOKENTRY [ SELECTEDFOLDER] . ENTRYNAME  ) ; 
                    __context__.SourceCodeLine = 1612;
                    SELECTEDISFOLDER  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1613;
                    PHONEBOOK_SEARCH_TEXT  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1614;
                    DISPLAYPHONEBOOK (  __context__  ) ; 
                    __context__.SourceCodeLine = 1615;
                    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1616;
                    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                    __context__.SourceCodeLine = 1617;
                    DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1622;
                    SELECTEDPHONEBOOK_NAME  .UpdateValue ( PHONEBOOKENTRY [ SELECTEDENTRY] . ENTRYNAME  ) ; 
                    __context__.SourceCodeLine = 1624;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1626;
                        SELECTEDENTRYMETHOD = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1631;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)((PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD + PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT) - 1); 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 1633;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "@" , CONTACT[ I ].CONTACTNUMBER ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1635;
                                SELECTEDENTRYMETHOD = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 1636;
                                URIENTRIESFOUND = (ushort) ( (URIENTRIESFOUND + 1) ) ; 
                                __context__.SourceCodeLine = 1637;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 2) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDSIP == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1639;
                                    FOUNDSIP = (ushort) ( I ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1641;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 0) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1643;
                                        FOUNDH323 = (ushort) ( I ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 1631;
                            } 
                        
                        __context__.SourceCodeLine = 1647;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (URIENTRIESFOUND == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1649;
                            ushort __FN_FORSTART_VAL__2 = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ;
                            ushort __FN_FOREND_VAL__2 = (ushort)((PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD + PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT) - 1); 
                            int __FN_FORSTEP_VAL__2 = (int)1; 
                            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                                { 
                                __context__.SourceCodeLine = 1651;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 2) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDSIP == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1653;
                                    FOUNDSIP = (ushort) ( I ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1655;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 0) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1657;
                                        FOUNDH323 = (ushort) ( I ) ; 
                                        } 
                                    
                                    }
                                
                                __context__.SourceCodeLine = 1649;
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 1661;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (URIENTRIESFOUND != 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1663;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (DEFAULTCALLTYPESIP  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1665;
                                SELECTEDENTRYMETHOD = (ushort) ( FOUNDSIP ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1669;
                                SELECTEDENTRYMETHOD = (ushort) ( FOUNDH323 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1673;
                    SELECTEDPHONEBOOK_NUMBER  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CONTACTNUMBER  ) ; 
                    __context__.SourceCodeLine = 1674;
                    SELECTEDPHONEBOOK_CALLRATE  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CALLRATE  ) ; 
                    __context__.SourceCodeLine = 1676;
                    SELECTEDISCONTACT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTEDENTRYNUMBER_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        ushort URIENTRIESFOUND = 0;
        
        ushort FOUNDH323 = 0;
        
        ushort FOUNDSIP = 0;
        
        
        __context__.SourceCodeLine = 1689;
        URIENTRIESFOUND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1690;
        FOUNDH323 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1691;
        FOUNDSIP = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1693;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIRECTORYDOWNLOADBUSY  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1695;
            RESETSELECTEDPHONEBOOKITEM (  __context__  ) ; 
            __context__.SourceCodeLine = 1697;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEARCHACTIVE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1699;
                SELECTEDENTRY = (ushort) ( SEARCHRESULT[ SELECTEDENTRYNUMBER  .UshortValue ] ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1703;
                SELECTEDENTRY = (ushort) ( ((SELECTEDENTRYNUMBER  .UshortValue + PHONEBOOKENTRY[ SELECTEDFOLDER ].FIRSTCHILD) - 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 1705;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( SELECTEDENTRYNUMBER  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( PHONEBOOKENTRY[ SELECTEDFOLDER ].FIRSTCHILD <= 2000 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SELECTEDENTRY ].ENTRYNAME ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1707;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SELECTEDENTRY ].FOLDERID ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1711;
                    SELECTEDFOLDER = (ushort) ( SELECTEDENTRY ) ; 
                    __context__.SourceCodeLine = 1712;
                    DIRECTORYONTOPLEVEL  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1713;
                    PHONEBOOK_SELECTED_FOLDER_NAME  .UpdateValue ( PHONEBOOKENTRY [ SELECTEDFOLDER] . ENTRYNAME  ) ; 
                    __context__.SourceCodeLine = 1714;
                    SELECTEDISFOLDER  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1715;
                    PHONEBOOK_SEARCH_TEXT  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 1716;
                    DISPLAYPHONEBOOK (  __context__  ) ; 
                    __context__.SourceCodeLine = 1717;
                    IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1718;
                    PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
                    __context__.SourceCodeLine = 1719;
                    DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1724;
                    SELECTEDPHONEBOOK_NAME  .UpdateValue ( PHONEBOOKENTRY [ SELECTEDENTRY] . ENTRYNAME  ) ; 
                    __context__.SourceCodeLine = 1726;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1728;
                        SELECTEDENTRYMETHOD = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1733;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)((PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD + PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT) - 1); 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 1735;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "@" , CONTACT[ I ].CONTACTNUMBER ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1737;
                                SELECTEDENTRYMETHOD = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 1738;
                                URIENTRIESFOUND = (ushort) ( (URIENTRIESFOUND + 1) ) ; 
                                __context__.SourceCodeLine = 1739;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 2) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDSIP == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1741;
                                    FOUNDSIP = (ushort) ( I ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1743;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 0) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1745;
                                        FOUNDH323 = (ushort) ( I ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 1733;
                            } 
                        
                        __context__.SourceCodeLine = 1749;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (URIENTRIESFOUND == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1751;
                            ushort __FN_FORSTART_VAL__2 = (ushort) ( PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD ) ;
                            ushort __FN_FOREND_VAL__2 = (ushort)((PHONEBOOKENTRY[ SELECTEDENTRY ].FIRSTCHILD + PHONEBOOKENTRY[ SELECTEDENTRY ].CHILDCOUNT) - 1); 
                            int __FN_FORSTEP_VAL__2 = (int)1; 
                            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                                { 
                                __context__.SourceCodeLine = 1753;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 2) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDSIP == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1755;
                                    FOUNDSIP = (ushort) ( I ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1757;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( (CONTACT[ I ].CALLTYPE & 0) ) && Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1759;
                                        FOUNDH323 = (ushort) ( I ) ; 
                                        } 
                                    
                                    }
                                
                                __context__.SourceCodeLine = 1751;
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 1763;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (URIENTRIESFOUND != 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1765;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (DEFAULTCALLTYPESIP  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (FOUNDH323 == 0) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1767;
                                SELECTEDENTRYMETHOD = (ushort) ( FOUNDSIP ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1771;
                                SELECTEDENTRYMETHOD = (ushort) ( FOUNDH323 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 1775;
                    SELECTEDPHONEBOOK_NUMBER  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CONTACTNUMBER  ) ; 
                    __context__.SourceCodeLine = 1776;
                    SELECTEDPHONEBOOK_CALLRATE  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CALLRATE  ) ; 
                    __context__.SourceCodeLine = 1778;
                    SELECTEDISCONTACT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEARSELECTEDENTRYNUMBER_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1786;
        RESETSELECTEDPHONEBOOKITEM (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GETLOCALPHONEBOOK_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1791;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIRECTORYDOWNLOADBUSY  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1793;
            DIRECTORYDOWNLOADBUSY  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1794;
            RESETEVERYTHING (  __context__  ) ; 
            __context__.SourceCodeLine = 1795;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PHONEBOOKSOURCEID  .UshortValue == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1797;
                PHONEBOOKTYPE  .UpdateValue ( "Corporate"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1801;
                PHONEBOOKTYPE  .UpdateValue ( "Local"  ) ; 
                } 
            
            __context__.SourceCodeLine = 1803;
            RUNSEARCHPHONEBOOK (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIALSELECTEDPHONEBOOKENTRYNUMBER_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString DIALSTRING;
        DIALSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 220, this );
        
        
        __context__.SourceCodeLine = 1815;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CONTACT[ SELECTEDENTRYMETHOD ].CONTACTNUMBER ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1817;
            MakeString ( DIALSTRING , "xCommand Dial Number: \"{0}\"", CONTACT [ SELECTEDENTRYMETHOD] . CONTACTNUMBER ) ; 
            __context__.SourceCodeLine = 1818;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CONTACT[ SELECTEDENTRYMETHOD ].CALLRATE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1820;
                DIALSTRING  .UpdateValue ( DIALSTRING + " CallRate: " + CONTACT [ SELECTEDENTRYMETHOD] . CALLRATE  ) ; 
                } 
            
            __context__.SourceCodeLine = 1823;
            if ( Functions.TestForTrue  ( ( (CONTACT[ SELECTEDENTRYMETHOD ].CALLTYPE & 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1825;
                DIALSTRING  .UpdateValue ( DIALSTRING + " Protocol: SIP"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1829;
                DIALSTRING  .UpdateValue ( DIALSTRING + " Protocol: H323"  ) ; 
                } 
            
            __context__.SourceCodeLine = 1832;
            if ( Functions.TestForTrue  ( ( (CONTACT[ SELECTEDENTRYMETHOD ].CALLTYPE & 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1834;
                DIALSTRING  .UpdateValue ( DIALSTRING + " CallType: Audio"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1838;
                DIALSTRING  .UpdateValue ( DIALSTRING + " CallType: Video"  ) ; 
                } 
            
            __context__.SourceCodeLine = 1840;
            MakeString ( DEVICE_TX__DOLLAR__ , "{0}\r\n", DIALSTRING ) ; 
            __context__.SourceCodeLine = 1842;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKENTRY[ SELECTEDENTRY ].ENTRYNAME ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1844;
                CALLHISTORYNAME  .UpdateValue ( PHONEBOOKENTRY [ SELECTEDENTRY] . ENTRYNAME  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1848;
                CALLHISTORYNAME  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CONTACTNUMBER  ) ; 
                } 
            
            __context__.SourceCodeLine = 1850;
            CALLHISTORYNUMBER  .UpdateValue ( CONTACT [ SELECTEDENTRYMETHOD] . CONTACTNUMBER  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEARCHPHONEBOOK_OnRelease_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1856;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PHONEBOOKSEARCHSTRING ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1858;
            SEARCHACTIVE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1859;
            GLOBALSEARCHCOUNT = (ushort) ( (GLOBALSEARCHCOUNT + 1) ) ; 
            __context__.SourceCodeLine = 1860;
            PHONEBOOKSEARCH (  __context__ , (ushort)( GLOBALSEARCHCOUNT )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1864;
            SEARCHACTIVE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1865;
            DISPLAYPHONEBOOK (  __context__  ) ; 
            __context__.SourceCodeLine = 1866;
            IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1867;
            PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
            __context__.SourceCodeLine = 1868;
            DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTRYOFFSET_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1874;
        SETPHONEBOOKOFFSET (  __context__ , (ushort)( ENTRYOFFSET  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PHONEBOOKSEARCHSTRING_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1879;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSEARCHTEXT != PHONEBOOKSEARCHSTRING))  ) ) 
            { 
            __context__.SourceCodeLine = 1881;
            SSEARCHTEXT  .UpdateValue ( PHONEBOOKSEARCHSTRING  ) ; 
            __context__.SourceCodeLine = 1882;
            PHONEBOOK_SEARCH_TEXT  .UpdateValue ( SSEARCHTEXT  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOPLEVEL_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1888;
        SELECTEDFOLDER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1889;
        DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1890;
        PHONEBOOK_SEARCH_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1891;
        DISPLAYPHONEBOOK (  __context__  ) ; 
        __context__.SourceCodeLine = 1892;
        IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1893;
        PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
        __context__.SourceCodeLine = 1894;
        DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPONELEVEL_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1899;
        SELECTEDFOLDER = (ushort) ( PHONEBOOKENTRY[ SELECTEDFOLDER ].PARENTFOLDER ) ; 
        __context__.SourceCodeLine = 1900;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SELECTEDFOLDER == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1902;
            DIRECTORYONTOPLEVEL  .Value = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 1904;
        PHONEBOOK_SEARCH_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1905;
        DISPLAYPHONEBOOK (  __context__  ) ; 
        __context__.SourceCodeLine = 1906;
        IPHONEBOOKPAGESCURRENTPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1907;
        PHONEBOOKPAGESCURRENTPAGE  .Value = (ushort) ( IPHONEBOOKPAGESCURRENTPAGE ) ; 
        __context__.SourceCodeLine = 1908;
        DISPLAYPHONEBOOKPAGES (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIALCALL_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString DIALSTRING;
        DIALSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 220, this );
        
        
        __context__.SourceCodeLine = 1915;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( DIALNUMBER ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1917;
            MakeString ( DIALSTRING , "xCommand Dial Number: {0}", DIALNUMBER ) ; 
            __context__.SourceCodeLine = 1918;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( DIALCALLRATE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1920;
                DIALSTRING  .UpdateValue ( DIALSTRING + " CallRate: " + DIALCALLRATE  ) ; 
                } 
            
            __context__.SourceCodeLine = 1922;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( DIALCALLPROTOCOL ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1924;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "VOIP" , DIALCALLPROTOCOL ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1926;
                    MakeString ( DIALSTRING , "{0} onlyaudio: true", DIALSTRING ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1930;
                    MakeString ( DIALSTRING , "{0} Protocol: {1}", DIALSTRING , DIALCALLPROTOCOL ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1933;
            MakeString ( DEVICE_TX__DOLLAR__ , "{0}\r\n", DIALSTRING ) ; 
            __context__.SourceCodeLine = 1934;
            CALLHISTORYNUMBER  .UpdateValue ( DIALNUMBER  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCONNECTCALLWITHID_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1940;
        DISCONNECTCALL (  __context__ , (ushort)( DISCONNECTCALLWITHID  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CALLCONTROLACCEPTINCOMINGCALL_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1945;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand Call Accept\r\n") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CALLCONTROLREJECTINCOMINGCALL_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1950;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand Call Reject\r\n") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCONNECTALLCALLS_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1955;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand Call DisconnectAll\r\n") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DTMFSEND_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1961;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DTMFSENDCALLSLOT  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1963;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand DTMFSend DTMFString: \"{0}\" CallId: \"{1:d}\"\r\n", DTMFSEND , (short)CALLSTATUS_CALLID[ 1 ] .Value) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1967;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand DTMFSend DTMFString: \"{0}\" CallId: \"{1:d}\"\r\n", DTMFSEND , (short)CALLSTATUS_CALLID[ DTMFSENDCALLSLOT  .UshortValue ] .Value) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void FARENDCONTROLCAMERAMOVE (  SplusExecutionContext __context__, CrestronString DIRECTION ) 
    { 
    
    __context__.SourceCodeLine = 1973;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FARENDCONTROLCALLSLOT  .UshortValue == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 1975;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Camera Move Value: {0}\r\n", DIRECTION ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 1979;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Camera Move Value: {0} CallId: \"{1:d}\"\r\n", DIRECTION , (short)CALLSTATUS_CALLID[ FARENDCONTROLCALLSLOT  .UshortValue ] .Value) ; 
        } 
    
    
    }
    
object FARENDCONTROLPRESENTATIONSOURCEID_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1985;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FARENDCONTROLCALLSLOT  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1987;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Source Select SourceId: {0:d}\r\n", (short)FARENDCONTROLPRESENTATIONSOURCEID  .UshortValue) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1991;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Source Select SourceId: {0:d}  CallId: \"{1:d}\"\r\n", (short)FARENDCONTROLPRESENTATIONSOURCEID  .UshortValue, (short)CALLSTATUS_CALLID[ FARENDCONTROLCALLSLOT  .UshortValue ] .Value) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLPRESETACTIVATEID_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1997;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FARENDCONTROLCALLSLOT  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1999;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Preset Activate PresetId: {0:d}\r\n", (short)FARENDCONTROLPRESETACTIVATEID  .UshortValue) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2003;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Preset Activate PresetId: {0:d}  CallId: \"{1:d}\"\r\n", (short)FARENDCONTROLPRESETACTIVATEID  .UshortValue, (short)CALLSTATUS_CALLID[ FARENDCONTROLCALLSLOT  .UshortValue ] .Value) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERASTOP_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2009;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FARENDCONTROLCALLSLOT  .UshortValue == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2011;
            MakeString ( DEVICE_TX__DOLLAR__ , "xCommand FarEndControl Camera Stop\r\n") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2015;
            MakeString ( DEVICE_TX__DOLLAR__ , "xcommand FarEndControl Camera Stop CallId: \"{0:d}\"\r\n", (short)CALLSTATUS_CALLID[ FARENDCONTROLCALLSLOT  .UshortValue ] .Value) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void SSTRINGSENDMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE ) 
    { 
    
    __context__.SourceCodeLine = 2021;
    MakeString ( DEVICE_TX__DOLLAR__ , "xCommand SStringSend Message: \"{0}\"\r\n", MESSAGE ) ; 
    
    }
    
private void TSTRINGSENDMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE ) 
    { 
    
    __context__.SourceCodeLine = 2026;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DTMFSENDCALLSLOT  .UshortValue == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2028;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand TStringSend Message: \"{0}\"\r\n", MESSAGE ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2032;
        MakeString ( DEVICE_TX__DOLLAR__ , "xCommand TStringSend Message: \"{0}\" CallId: \"{1:d}\"\r\n", MESSAGE , (short)CALLSTATUS_CALLID[ DTMFSENDCALLSLOT  .UshortValue ] .Value) ; 
        } 
    
    
    }
    
object TSTRING_SEND_TEXT_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2038;
        TSTRINGSENDMESSAGE (  __context__ , TSTRING_SEND_TEXT) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SSTRING_SEND_TEXT_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2044;
        SSTRINGSENDMESSAGE (  __context__ , SSTRING_SEND_TEXT) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAPANLEFT_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2050;
        FARENDCONTROLCAMERAMOVE (  __context__ , "Left") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAPANRIGHT_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2055;
        FARENDCONTROLCAMERAMOVE (  __context__ , "Right") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERATILTUP_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2060;
        FARENDCONTROLCAMERAMOVE (  __context__ , "Up") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERATILTDOWN_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2065;
        FARENDCONTROLCAMERAMOVE (  __context__ , "Down") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAZOOMIN_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2070;
        FARENDCONTROLCAMERAMOVE (  __context__ , "ZoomIn") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAZOOMOUT_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2075;
        FARENDCONTROLCAMERAMOVE (  __context__ , "ZoomOut") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAFOCUSIN_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2080;
        FARENDCONTROLCAMERAMOVE (  __context__ , "FocusIn") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FARENDCONTROLCAMERAFOCUSOUT_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2085;
        FARENDCONTROLCAMERAMOVE (  __context__ , "FocusOut") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DATATOTRACE_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2090;
        PRINTSAVEDDATA (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 2099;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2100;
        DIALSEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2101;
        SIGNALINCOMINGCALL  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2102;
        NUMBEROFACTIVECALLS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2103;
        GLOBALSEARCHCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2104;
        RESETPHONEBOOKLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 2105;
        RESETSELECTEDPHONEBOOKITEM (  __context__  ) ; 
        __context__.SourceCodeLine = 2106;
        RESETEVERYTHING (  __context__  ) ; 
        __context__.SourceCodeLine = 2107;
        PHONEBOOKENTRY [ 0] . FIRSTCHILD = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SEARCHRESULT  = new ushort[ 51 ];
    TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    CALLRESPONSETYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    CALLSTATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    REMOTENUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    GTEMPDISPLAYNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    GTEMPVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    GTEMPSEGMENT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    PHONEBOOKENTRYTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    PHONEBOOKTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
    MESSAGE_PROMPT_FEEDBACKID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    SSEARCHTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 82, this );
    PHONEBOOKENTRY  = new PHONEBOOK[ 2001 ];
    for( uint i = 0; i < 2001; i++ )
    {
        PHONEBOOKENTRY [i] = new PHONEBOOK( this, true );
        PHONEBOOKENTRY [i].PopulateCustomAttributeList( false );
        
    }
    CONTACT  = new CONTACTLIST[ 4001 ];
    for( uint i = 0; i < 4001; i++ )
    {
        CONTACT [i] = new CONTACTLIST( this, true );
        CONTACT [i].PopulateCustomAttributeList( false );
        
    }
    
    GETLOCALPHONEBOOK = new Crestron.Logos.SplusObjects.DigitalInput( GETLOCALPHONEBOOK__DigitalInput__, this );
    m_DigitalInputList.Add( GETLOCALPHONEBOOK__DigitalInput__, GETLOCALPHONEBOOK );
    
    CLEARSELECTEDENTRYNUMBER = new Crestron.Logos.SplusObjects.DigitalInput( CLEARSELECTEDENTRYNUMBER__DigitalInput__, this );
    m_DigitalInputList.Add( CLEARSELECTEDENTRYNUMBER__DigitalInput__, CLEARSELECTEDENTRYNUMBER );
    
    DIALSELECTEDPHONEBOOKENTRYNUMBER = new Crestron.Logos.SplusObjects.DigitalInput( DIALSELECTEDPHONEBOOKENTRYNUMBER__DigitalInput__, this );
    m_DigitalInputList.Add( DIALSELECTEDPHONEBOOKENTRYNUMBER__DigitalInput__, DIALSELECTEDPHONEBOOKENTRYNUMBER );
    
    TOPLEVEL = new Crestron.Logos.SplusObjects.DigitalInput( TOPLEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( TOPLEVEL__DigitalInput__, TOPLEVEL );
    
    UPONELEVEL = new Crestron.Logos.SplusObjects.DigitalInput( UPONELEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( UPONELEVEL__DigitalInput__, UPONELEVEL );
    
    SEARCHPHONEBOOK = new Crestron.Logos.SplusObjects.DigitalInput( SEARCHPHONEBOOK__DigitalInput__, this );
    m_DigitalInputList.Add( SEARCHPHONEBOOK__DigitalInput__, SEARCHPHONEBOOK );
    
    CALLCONTROLACCEPTINCOMINGCALL = new Crestron.Logos.SplusObjects.DigitalInput( CALLCONTROLACCEPTINCOMINGCALL__DigitalInput__, this );
    m_DigitalInputList.Add( CALLCONTROLACCEPTINCOMINGCALL__DigitalInput__, CALLCONTROLACCEPTINCOMINGCALL );
    
    CALLCONTROLREJECTINCOMINGCALL = new Crestron.Logos.SplusObjects.DigitalInput( CALLCONTROLREJECTINCOMINGCALL__DigitalInput__, this );
    m_DigitalInputList.Add( CALLCONTROLREJECTINCOMINGCALL__DigitalInput__, CALLCONTROLREJECTINCOMINGCALL );
    
    DISCONNECTALLCALLS = new Crestron.Logos.SplusObjects.DigitalInput( DISCONNECTALLCALLS__DigitalInput__, this );
    m_DigitalInputList.Add( DISCONNECTALLCALLS__DigitalInput__, DISCONNECTALLCALLS );
    
    DIALCALL = new Crestron.Logos.SplusObjects.DigitalInput( DIALCALL__DigitalInput__, this );
    m_DigitalInputList.Add( DIALCALL__DigitalInput__, DIALCALL );
    
    FARENDCONTROLCAMERAPANLEFT = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAPANLEFT__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAPANLEFT__DigitalInput__, FARENDCONTROLCAMERAPANLEFT );
    
    FARENDCONTROLCAMERAPANRIGHT = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAPANRIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAPANRIGHT__DigitalInput__, FARENDCONTROLCAMERAPANRIGHT );
    
    FARENDCONTROLCAMERATILTUP = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERATILTUP__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERATILTUP__DigitalInput__, FARENDCONTROLCAMERATILTUP );
    
    FARENDCONTROLCAMERATILTDOWN = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERATILTDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERATILTDOWN__DigitalInput__, FARENDCONTROLCAMERATILTDOWN );
    
    FARENDCONTROLCAMERAZOOMIN = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAZOOMIN__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAZOOMIN__DigitalInput__, FARENDCONTROLCAMERAZOOMIN );
    
    FARENDCONTROLCAMERAZOOMOUT = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAZOOMOUT__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAZOOMOUT__DigitalInput__, FARENDCONTROLCAMERAZOOMOUT );
    
    FARENDCONTROLCAMERAFOCUSIN = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAFOCUSIN__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAFOCUSIN__DigitalInput__, FARENDCONTROLCAMERAFOCUSIN );
    
    FARENDCONTROLCAMERAFOCUSOUT = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERAFOCUSOUT__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERAFOCUSOUT__DigitalInput__, FARENDCONTROLCAMERAFOCUSOUT );
    
    FARENDCONTROLCAMERASTOP = new Crestron.Logos.SplusObjects.DigitalInput( FARENDCONTROLCAMERASTOP__DigitalInput__, this );
    m_DigitalInputList.Add( FARENDCONTROLCAMERASTOP__DigitalInput__, FARENDCONTROLCAMERASTOP );
    
    RESYNCRONIZECALLSTATUSLIST = new Crestron.Logos.SplusObjects.DigitalInput( RESYNCRONIZECALLSTATUSLIST__DigitalInput__, this );
    m_DigitalInputList.Add( RESYNCRONIZECALLSTATUSLIST__DigitalInput__, RESYNCRONIZECALLSTATUSLIST );
    
    DATATOTRACE = new Crestron.Logos.SplusObjects.DigitalInput( DATATOTRACE__DigitalInput__, this );
    m_DigitalInputList.Add( DATATOTRACE__DigitalInput__, DATATOTRACE );
    
    DEFAULTCALLTYPESIP = new Crestron.Logos.SplusObjects.DigitalInput( DEFAULTCALLTYPESIP__DigitalInput__, this );
    m_DigitalInputList.Add( DEFAULTCALLTYPESIP__DigitalInput__, DEFAULTCALLTYPESIP );
    
    MESSAGE_ALERT_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_ALERT_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_ALERT_ISACTIVE__DigitalOutput__, MESSAGE_ALERT_ISACTIVE );
    
    MESSAGE_PROMPT_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION1_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION1_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION1_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_OPTION1_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION2_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION2_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION2_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_OPTION2_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION3_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION3_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION3_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_OPTION3_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION4_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION4_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION4_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_OPTION4_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION5_ISACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION5_ISACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION5_ISACTIVE__DigitalOutput__, MESSAGE_PROMPT_OPTION5_ISACTIVE );
    
    MESSAGE_PROMPT_OPTION1_WASSELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION1_WASSELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION1_WASSELECTED__DigitalOutput__, MESSAGE_PROMPT_OPTION1_WASSELECTED );
    
    MESSAGE_PROMPT_OPTION2_WASSELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION2_WASSELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION2_WASSELECTED__DigitalOutput__, MESSAGE_PROMPT_OPTION2_WASSELECTED );
    
    MESSAGE_PROMPT_OPTION3_WASSELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION3_WASSELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION3_WASSELECTED__DigitalOutput__, MESSAGE_PROMPT_OPTION3_WASSELECTED );
    
    MESSAGE_PROMPT_OPTION4_WASSELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION4_WASSELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION4_WASSELECTED__DigitalOutput__, MESSAGE_PROMPT_OPTION4_WASSELECTED );
    
    MESSAGE_PROMPT_OPTION5_WASSELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( MESSAGE_PROMPT_OPTION5_WASSELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( MESSAGE_PROMPT_OPTION5_WASSELECTED__DigitalOutput__, MESSAGE_PROMPT_OPTION5_WASSELECTED );
    
    PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER = new Crestron.Logos.SplusObjects.DigitalOutput( PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER__DigitalOutput__, this );
    m_DigitalOutputList.Add( PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER__DigitalOutput__, PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER );
    
    DIRECTORYDOWNLOADBUSY = new Crestron.Logos.SplusObjects.DigitalOutput( DIRECTORYDOWNLOADBUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIRECTORYDOWNLOADBUSY__DigitalOutput__, DIRECTORYDOWNLOADBUSY );
    
    SELECTEDISFOLDER = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTEDISFOLDER__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTEDISFOLDER__DigitalOutput__, SELECTEDISFOLDER );
    
    SELECTEDISCONTACT = new Crestron.Logos.SplusObjects.DigitalOutput( SELECTEDISCONTACT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SELECTEDISCONTACT__DigitalOutput__, SELECTEDISCONTACT );
    
    GETREBOOTCODEC_IS_IN_PROGRESS = new Crestron.Logos.SplusObjects.DigitalOutput( GETREBOOTCODEC_IS_IN_PROGRESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( GETREBOOTCODEC_IS_IN_PROGRESS__DigitalOutput__, GETREBOOTCODEC_IS_IN_PROGRESS );
    
    SIGNALINCOMINGCALL = new Crestron.Logos.SplusObjects.DigitalOutput( SIGNALINCOMINGCALL__DigitalOutput__, this );
    m_DigitalOutputList.Add( SIGNALINCOMINGCALL__DigitalOutput__, SIGNALINCOMINGCALL );
    
    DEVICE_ONLINE = new Crestron.Logos.SplusObjects.DigitalOutput( DEVICE_ONLINE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DEVICE_ONLINE__DigitalOutput__, DEVICE_ONLINE );
    
    DIRECTORYONTOPLEVEL = new Crestron.Logos.SplusObjects.DigitalOutput( DIRECTORYONTOPLEVEL__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIRECTORYONTOPLEVEL__DigitalOutput__, DIRECTORYONTOPLEVEL );
    
    CALLSTATUS_ISCONNECTED = new InOutArray<DigitalOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_ISCONNECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( CALLSTATUS_ISCONNECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( CALLSTATUS_ISCONNECTED__DigitalOutput__ + i, CALLSTATUS_ISCONNECTED[i+1] );
    }
    
    CALLSTATUS_SUPPORTSPRESENTATION = new InOutArray<DigitalOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_SUPPORTSPRESENTATION[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( CALLSTATUS_SUPPORTSPRESENTATION__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( CALLSTATUS_SUPPORTSPRESENTATION__DigitalOutput__ + i, CALLSTATUS_SUPPORTSPRESENTATION[i+1] );
    }
    
    CALLSTATUS_ISACTIVE = new InOutArray<DigitalOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_ISACTIVE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( CALLSTATUS_ISACTIVE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( CALLSTATUS_ISACTIVE__DigitalOutput__ + i, CALLSTATUS_ISACTIVE[i+1] );
    }
    
    ENTRYOFFSET = new Crestron.Logos.SplusObjects.AnalogInput( ENTRYOFFSET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ENTRYOFFSET__AnalogSerialInput__, ENTRYOFFSET );
    
    ENTRIESPERPAGE = new Crestron.Logos.SplusObjects.AnalogInput( ENTRIESPERPAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ENTRIESPERPAGE__AnalogSerialInput__, ENTRIESPERPAGE );
    
    DTMFSENDCALLSLOT = new Crestron.Logos.SplusObjects.AnalogInput( DTMFSENDCALLSLOT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DTMFSENDCALLSLOT__AnalogSerialInput__, DTMFSENDCALLSLOT );
    
    SELECTEDENTRYNUMBER = new Crestron.Logos.SplusObjects.AnalogInput( SELECTEDENTRYNUMBER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTEDENTRYNUMBER__AnalogSerialInput__, SELECTEDENTRYNUMBER );
    
    PAGESSELECTEDENTRYNUMBER = new Crestron.Logos.SplusObjects.AnalogInput( PAGESSELECTEDENTRYNUMBER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PAGESSELECTEDENTRYNUMBER__AnalogSerialInput__, PAGESSELECTEDENTRYNUMBER );
    
    PHONEBOOKSOURCEID = new Crestron.Logos.SplusObjects.AnalogInput( PHONEBOOKSOURCEID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PHONEBOOKSOURCEID__AnalogSerialInput__, PHONEBOOKSOURCEID );
    
    DISCONNECTCALLWITHID = new Crestron.Logos.SplusObjects.AnalogInput( DISCONNECTCALLWITHID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DISCONNECTCALLWITHID__AnalogSerialInput__, DISCONNECTCALLWITHID );
    
    FARENDCONTROLCALLSLOT = new Crestron.Logos.SplusObjects.AnalogInput( FARENDCONTROLCALLSLOT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FARENDCONTROLCALLSLOT__AnalogSerialInput__, FARENDCONTROLCALLSLOT );
    
    FARENDCONTROLPRESENTATIONSOURCEID = new Crestron.Logos.SplusObjects.AnalogInput( FARENDCONTROLPRESENTATIONSOURCEID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FARENDCONTROLPRESENTATIONSOURCEID__AnalogSerialInput__, FARENDCONTROLPRESENTATIONSOURCEID );
    
    FARENDCONTROLPRESETACTIVATEID = new Crestron.Logos.SplusObjects.AnalogInput( FARENDCONTROLPRESETACTIVATEID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FARENDCONTROLPRESETACTIVATEID__AnalogSerialInput__, FARENDCONTROLPRESETACTIVATEID );
    
    SETVOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogInput( SETVOLUMELEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVOLUMELEVEL__AnalogSerialInput__, SETVOLUMELEVEL );
    
    SEARCHDELAYSTART = new Crestron.Logos.SplusObjects.AnalogInput( SEARCHDELAYSTART__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SEARCHDELAYSTART__AnalogSerialInput__, SEARCHDELAYSTART );
    
    SEARCHDELAYMOD = new Crestron.Logos.SplusObjects.AnalogInput( SEARCHDELAYMOD__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SEARCHDELAYMOD__AnalogSerialInput__, SEARCHDELAYMOD );
    
    SEARCHDELAY = new Crestron.Logos.SplusObjects.AnalogInput( SEARCHDELAY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SEARCHDELAY__AnalogSerialInput__, SEARCHDELAY );
    
    GETVOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( GETVOLUMELEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GETVOLUMELEVEL__AnalogSerialOutput__, GETVOLUMELEVEL );
    
    CURRENTFIRSTPHONEBOOKITEMNUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTFIRSTPHONEBOOKITEMNUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENTFIRSTPHONEBOOKITEMNUMBER__AnalogSerialOutput__, CURRENTFIRSTPHONEBOOKITEMNUMBER );
    
    CURRENTLASTPHONEBOOKITEMNUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTLASTPHONEBOOKITEMNUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENTLASTPHONEBOOKITEMNUMBER__AnalogSerialOutput__, CURRENTLASTPHONEBOOKITEMNUMBER );
    
    TOTALROWSFORSEARCH = new Crestron.Logos.SplusObjects.AnalogOutput( TOTALROWSFORSEARCH__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TOTALROWSFORSEARCH__AnalogSerialOutput__, TOTALROWSFORSEARCH );
    
    NUMBEROFACTIVECALLS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMBEROFACTIVECALLS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMBEROFACTIVECALLS__AnalogSerialOutput__, NUMBEROFACTIVECALLS );
    
    PHONEBOOKPAGESCURRENTPAGE = new Crestron.Logos.SplusObjects.AnalogOutput( PHONEBOOKPAGESCURRENTPAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PHONEBOOKPAGESCURRENTPAGE__AnalogSerialOutput__, PHONEBOOKPAGESCURRENTPAGE );
    
    PHONEBOOKPAGESTOTALPAGES = new Crestron.Logos.SplusObjects.AnalogOutput( PHONEBOOKPAGESTOTALPAGES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PHONEBOOKPAGESTOTALPAGES__AnalogSerialOutput__, PHONEBOOKPAGESTOTALPAGES );
    
    CALLSTATUS_CALLID = new InOutArray<AnalogOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_CALLID[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( CALLSTATUS_CALLID__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( CALLSTATUS_CALLID__AnalogSerialOutput__ + i, CALLSTATUS_CALLID[i+1] );
    }
    
    DTMFSEND = new Crestron.Logos.SplusObjects.StringInput( DTMFSEND__AnalogSerialInput__, 32, this );
    m_StringInputList.Add( DTMFSEND__AnalogSerialInput__, DTMFSEND );
    
    PHONEBOOKSEARCHSTRING = new Crestron.Logos.SplusObjects.StringInput( PHONEBOOKSEARCHSTRING__AnalogSerialInput__, 82, this );
    m_StringInputList.Add( PHONEBOOKSEARCHSTRING__AnalogSerialInput__, PHONEBOOKSEARCHSTRING );
    
    DIALNUMBER = new Crestron.Logos.SplusObjects.StringInput( DIALNUMBER__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( DIALNUMBER__AnalogSerialInput__, DIALNUMBER );
    
    DIALCALLRATE = new Crestron.Logos.SplusObjects.StringInput( DIALCALLRATE__AnalogSerialInput__, 6, this );
    m_StringInputList.Add( DIALCALLRATE__AnalogSerialInput__, DIALCALLRATE );
    
    DIALCALLPROTOCOL = new Crestron.Logos.SplusObjects.StringInput( DIALCALLPROTOCOL__AnalogSerialInput__, 4, this );
    m_StringInputList.Add( DIALCALLPROTOCOL__AnalogSerialInput__, DIALCALLPROTOCOL );
    
    TSTRING_SEND_TEXT = new Crestron.Logos.SplusObjects.StringInput( TSTRING_SEND_TEXT__AnalogSerialInput__, 1450, this );
    m_StringInputList.Add( TSTRING_SEND_TEXT__AnalogSerialInput__, TSTRING_SEND_TEXT );
    
    SSTRING_SEND_TEXT = new Crestron.Logos.SplusObjects.StringInput( SSTRING_SEND_TEXT__AnalogSerialInput__, 256, this );
    m_StringInputList.Add( SSTRING_SEND_TEXT__AnalogSerialInput__, SSTRING_SEND_TEXT );
    
    DEVICE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DEVICE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICE_TX__DOLLAR____AnalogSerialOutput__, DEVICE_TX__DOLLAR__ );
    
    TSTRING_RECEIVE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( TSTRING_RECEIVE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TSTRING_RECEIVE_TEXT__AnalogSerialOutput__, TSTRING_RECEIVE_TEXT );
    
    SSTRING_RECEIVE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SSTRING_RECEIVE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SSTRING_RECEIVE_TEXT__AnalogSerialOutput__, SSTRING_RECEIVE_TEXT );
    
    SELECTEDPHONEBOOK_NAME = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDPHONEBOOK_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDPHONEBOOK_NAME__AnalogSerialOutput__, SELECTEDPHONEBOOK_NAME );
    
    SELECTEDPHONEBOOK_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDPHONEBOOK_NUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDPHONEBOOK_NUMBER__AnalogSerialOutput__, SELECTEDPHONEBOOK_NUMBER );
    
    SELECTEDPHONEBOOK_CALLRATE = new Crestron.Logos.SplusObjects.StringOutput( SELECTEDPHONEBOOK_CALLRATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTEDPHONEBOOK_CALLRATE__AnalogSerialOutput__, SELECTEDPHONEBOOK_CALLRATE );
    
    PHONEBOOK_SEARCH_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PHONEBOOK_SEARCH_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PHONEBOOK_SEARCH_TEXT__AnalogSerialOutput__, PHONEBOOK_SEARCH_TEXT );
    
    GETSYSTEMNAME = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEMNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEMNAME__AnalogSerialOutput__, GETSYSTEMNAME );
    
    GETSYSTEMNETWORKADDRESS = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEMNETWORKADDRESS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEMNETWORKADDRESS__AnalogSerialOutput__, GETSYSTEMNETWORKADDRESS );
    
    GETGATEKEEPERSTATUS = new Crestron.Logos.SplusObjects.StringOutput( GETGATEKEEPERSTATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETGATEKEEPERSTATUS__AnalogSerialOutput__, GETGATEKEEPERSTATUS );
    
    GETGATEKEEPERREGISTRATIONMODE = new Crestron.Logos.SplusObjects.StringOutput( GETGATEKEEPERREGISTRATIONMODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETGATEKEEPERREGISTRATIONMODE__AnalogSerialOutput__, GETGATEKEEPERREGISTRATIONMODE );
    
    GETGATEKEEPERNETWORKADDRESS = new Crestron.Logos.SplusObjects.StringOutput( GETGATEKEEPERNETWORKADDRESS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETGATEKEEPERNETWORKADDRESS__AnalogSerialOutput__, GETGATEKEEPERNETWORKADDRESS );
    
    GETSYSTEMH323ID = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEMH323ID__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEMH323ID__AnalogSerialOutput__, GETSYSTEMH323ID );
    
    GETSYSTEME164ALIAS = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEME164ALIAS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEME164ALIAS__AnalogSerialOutput__, GETSYSTEME164ALIAS );
    
    GETSYSTEMSIPURI = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEMSIPURI__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEMSIPURI__AnalogSerialOutput__, GETSYSTEMSIPURI );
    
    GETSYSTEMSOFTWAREVERSION = new Crestron.Logos.SplusObjects.StringOutput( GETSYSTEMSOFTWAREVERSION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GETSYSTEMSOFTWAREVERSION__AnalogSerialOutput__, GETSYSTEMSOFTWAREVERSION );
    
    FROM_DEVICE_CONFIGURATIONCHANGES = new Crestron.Logos.SplusObjects.StringOutput( FROM_DEVICE_CONFIGURATIONCHANGES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FROM_DEVICE_CONFIGURATIONCHANGES__AnalogSerialOutput__, FROM_DEVICE_CONFIGURATIONCHANGES );
    
    FROM_DEVICE_STATUSCHANGES = new Crestron.Logos.SplusObjects.StringOutput( FROM_DEVICE_STATUSCHANGES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FROM_DEVICE_STATUSCHANGES__AnalogSerialOutput__, FROM_DEVICE_STATUSCHANGES );
    
    MESSAGE_ALERT_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_ALERT_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_ALERT_TEXT__AnalogSerialOutput__, MESSAGE_ALERT_TEXT );
    
    MESSAGE_PROMPT_TITLE = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_TITLE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_TITLE__AnalogSerialOutput__, MESSAGE_PROMPT_TITLE );
    
    MESSAGE_PROMPT_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_TEXT );
    
    MESSAGE_PROMPT_OPTION1_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_OPTION1_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_OPTION1_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_OPTION1_TEXT );
    
    MESSAGE_PROMPT_OPTION2_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_OPTION2_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_OPTION2_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_OPTION2_TEXT );
    
    MESSAGE_PROMPT_OPTION3_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_OPTION3_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_OPTION3_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_OPTION3_TEXT );
    
    MESSAGE_PROMPT_OPTION4_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_OPTION4_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_OPTION4_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_OPTION4_TEXT );
    
    MESSAGE_PROMPT_OPTION5_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_PROMPT_OPTION5_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_PROMPT_OPTION5_TEXT__AnalogSerialOutput__, MESSAGE_PROMPT_OPTION5_TEXT );
    
    PHONEBOOK_SELECTED_FOLDER_NAME = new Crestron.Logos.SplusObjects.StringOutput( PHONEBOOK_SELECTED_FOLDER_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PHONEBOOK_SELECTED_FOLDER_NAME__AnalogSerialOutput__, PHONEBOOK_SELECTED_FOLDER_NAME );
    
    CALLHISTORYNAME = new Crestron.Logos.SplusObjects.StringOutput( CALLHISTORYNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALLHISTORYNAME__AnalogSerialOutput__, CALLHISTORYNAME );
    
    CALLHISTORYNUMBER = new Crestron.Logos.SplusObjects.StringOutput( CALLHISTORYNUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALLHISTORYNUMBER__AnalogSerialOutput__, CALLHISTORYNUMBER );
    
    INCOMINGCALLNUMBER = new Crestron.Logos.SplusObjects.StringOutput( INCOMINGCALLNUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( INCOMINGCALLNUMBER__AnalogSerialOutput__, INCOMINGCALLNUMBER );
    
    INPUT_SOURCE_NAME = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        INPUT_SOURCE_NAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( INPUT_SOURCE_NAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( INPUT_SOURCE_NAME__AnalogSerialOutput__ + i, INPUT_SOURCE_NAME[i+1] );
    }
    
    PHONEBOOK_NAME = new InOutArray<StringOutput>( 255, this );
    for( uint i = 0; i < 255; i++ )
    {
        PHONEBOOK_NAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PHONEBOOK_NAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PHONEBOOK_NAME__AnalogSerialOutput__ + i, PHONEBOOK_NAME[i+1] );
    }
    
    PHONEBOOK_PAGES_NAME = new InOutArray<StringOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        PHONEBOOK_PAGES_NAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PHONEBOOK_PAGES_NAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PHONEBOOK_PAGES_NAME__AnalogSerialOutput__ + i, PHONEBOOK_PAGES_NAME[i+1] );
    }
    
    CALLSTATUS_STATUS = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_STATUS[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_STATUS__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_STATUS__AnalogSerialOutput__ + i, CALLSTATUS_STATUS[i+1] );
    }
    
    CALLSTATUS_CALLTYPE = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_CALLTYPE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_CALLTYPE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_CALLTYPE__AnalogSerialOutput__ + i, CALLSTATUS_CALLTYPE[i+1] );
    }
    
    CALLSTATUS_REMOTESITE = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_REMOTESITE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_REMOTESITE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_REMOTESITE__AnalogSerialOutput__ + i, CALLSTATUS_REMOTESITE[i+1] );
    }
    
    CALLSTATUS_DURATION = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_DURATION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_DURATION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_DURATION__AnalogSerialOutput__ + i, CALLSTATUS_DURATION[i+1] );
    }
    
    CALLSTATUS_TRANSMITCALLRATE = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_TRANSMITCALLRATE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_TRANSMITCALLRATE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_TRANSMITCALLRATE__AnalogSerialOutput__ + i, CALLSTATUS_TRANSMITCALLRATE[i+1] );
    }
    
    CALLSTATUS_RECEIVECALLRATE = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_RECEIVECALLRATE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_RECEIVECALLRATE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_RECEIVECALLRATE__AnalogSerialOutput__ + i, CALLSTATUS_RECEIVECALLRATE[i+1] );
    }
    
    CALLSTATUS_DIRECTION = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALLSTATUS_DIRECTION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CALLSTATUS_DIRECTION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CALLSTATUS_DIRECTION__AnalogSerialOutput__ + i, CALLSTATUS_DIRECTION[i+1] );
    }
    
    DEVICE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DEVICE_RX__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( DEVICE_RX__DOLLAR____AnalogSerialInput__, DEVICE_RX__DOLLAR__ );
    
    COMMTIMEOUT_Callback = new WaitFunction( COMMTIMEOUT_CallbackFn );
    RECEIVEPHONEBOOK_Callback = new WaitFunction( RECEIVEPHONEBOOK_CallbackFn );
    
    RESYNCRONIZECALLSTATUSLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESYNCRONIZECALLSTATUSLIST_OnPush_0, false ) );
    SETVOLUMELEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVOLUMELEVEL_OnChange_1, false ) );
    DEVICE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEVICE_RX__DOLLAR___OnChange_2, true ) );
    PAGESSELECTEDENTRYNUMBER.OnAnalogChange.Add( new InputChangeHandlerWrapper( PAGESSELECTEDENTRYNUMBER_OnChange_3, false ) );
    SELECTEDENTRYNUMBER.OnAnalogChange.Add( new InputChangeHandlerWrapper( SELECTEDENTRYNUMBER_OnChange_4, false ) );
    CLEARSELECTEDENTRYNUMBER.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEARSELECTEDENTRYNUMBER_OnPush_5, false ) );
    GETLOCALPHONEBOOK.OnDigitalPush.Add( new InputChangeHandlerWrapper( GETLOCALPHONEBOOK_OnPush_6, false ) );
    DIALSELECTEDPHONEBOOKENTRYNUMBER.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIALSELECTEDPHONEBOOKENTRYNUMBER_OnPush_7, false ) );
    SEARCHPHONEBOOK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SEARCHPHONEBOOK_OnRelease_8, false ) );
    ENTRYOFFSET.OnAnalogChange.Add( new InputChangeHandlerWrapper( ENTRYOFFSET_OnChange_9, false ) );
    PHONEBOOKSEARCHSTRING.OnSerialChange.Add( new InputChangeHandlerWrapper( PHONEBOOKSEARCHSTRING_OnChange_10, false ) );
    TOPLEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOPLEVEL_OnPush_11, false ) );
    UPONELEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPONELEVEL_OnPush_12, false ) );
    DIALCALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIALCALL_OnPush_13, false ) );
    DISCONNECTCALLWITHID.OnAnalogChange.Add( new InputChangeHandlerWrapper( DISCONNECTCALLWITHID_OnChange_14, false ) );
    CALLCONTROLACCEPTINCOMINGCALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( CALLCONTROLACCEPTINCOMINGCALL_OnPush_15, false ) );
    CALLCONTROLREJECTINCOMINGCALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( CALLCONTROLREJECTINCOMINGCALL_OnPush_16, false ) );
    DISCONNECTALLCALLS.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCONNECTALLCALLS_OnPush_17, false ) );
    DTMFSEND.OnSerialChange.Add( new InputChangeHandlerWrapper( DTMFSEND_OnChange_18, false ) );
    FARENDCONTROLPRESENTATIONSOURCEID.OnAnalogChange.Add( new InputChangeHandlerWrapper( FARENDCONTROLPRESENTATIONSOURCEID_OnChange_19, false ) );
    FARENDCONTROLPRESETACTIVATEID.OnAnalogChange.Add( new InputChangeHandlerWrapper( FARENDCONTROLPRESETACTIVATEID_OnChange_20, false ) );
    FARENDCONTROLCAMERASTOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERASTOP_OnPush_21, false ) );
    TSTRING_SEND_TEXT.OnSerialChange.Add( new InputChangeHandlerWrapper( TSTRING_SEND_TEXT_OnChange_22, false ) );
    SSTRING_SEND_TEXT.OnSerialChange.Add( new InputChangeHandlerWrapper( SSTRING_SEND_TEXT_OnChange_23, false ) );
    FARENDCONTROLCAMERAPANLEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAPANLEFT_OnPush_24, false ) );
    FARENDCONTROLCAMERAPANRIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAPANRIGHT_OnPush_25, false ) );
    FARENDCONTROLCAMERATILTUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERATILTUP_OnPush_26, false ) );
    FARENDCONTROLCAMERATILTDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERATILTDOWN_OnPush_27, false ) );
    FARENDCONTROLCAMERAZOOMIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAZOOMIN_OnPush_28, false ) );
    FARENDCONTROLCAMERAZOOMOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAZOOMOUT_OnPush_29, false ) );
    FARENDCONTROLCAMERAFOCUSIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAFOCUSIN_OnPush_30, false ) );
    FARENDCONTROLCAMERAFOCUSOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FARENDCONTROLCAMERAFOCUSOUT_OnPush_31, false ) );
    DATATOTRACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DATATOTRACE_OnPush_32, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CISCO_C90___C60_CALL_CONTROL_V2_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction COMMTIMEOUT_Callback;
private WaitFunction RECEIVEPHONEBOOK_Callback;


const uint DEVICE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint DEVICE_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint ENTRYOFFSET__AnalogSerialInput__ = 1;
const uint ENTRIESPERPAGE__AnalogSerialInput__ = 2;
const uint DTMFSENDCALLSLOT__AnalogSerialInput__ = 3;
const uint DTMFSEND__AnalogSerialInput__ = 4;
const uint GETLOCALPHONEBOOK__DigitalInput__ = 0;
const uint SELECTEDENTRYNUMBER__AnalogSerialInput__ = 5;
const uint PAGESSELECTEDENTRYNUMBER__AnalogSerialInput__ = 6;
const uint CLEARSELECTEDENTRYNUMBER__DigitalInput__ = 1;
const uint DIALSELECTEDPHONEBOOKENTRYNUMBER__DigitalInput__ = 2;
const uint PHONEBOOKSOURCEID__AnalogSerialInput__ = 7;
const uint TOPLEVEL__DigitalInput__ = 3;
const uint UPONELEVEL__DigitalInput__ = 4;
const uint SEARCHPHONEBOOK__DigitalInput__ = 5;
const uint PHONEBOOKSEARCHSTRING__AnalogSerialInput__ = 8;
const uint CALLCONTROLACCEPTINCOMINGCALL__DigitalInput__ = 6;
const uint CALLCONTROLREJECTINCOMINGCALL__DigitalInput__ = 7;
const uint DISCONNECTCALLWITHID__AnalogSerialInput__ = 9;
const uint DISCONNECTALLCALLS__DigitalInput__ = 8;
const uint DIALNUMBER__AnalogSerialInput__ = 10;
const uint DIALCALLRATE__AnalogSerialInput__ = 11;
const uint DIALCALLPROTOCOL__AnalogSerialInput__ = 12;
const uint DIALCALL__DigitalInput__ = 9;
const uint FARENDCONTROLCALLSLOT__AnalogSerialInput__ = 13;
const uint FARENDCONTROLCAMERAPANLEFT__DigitalInput__ = 10;
const uint FARENDCONTROLCAMERAPANRIGHT__DigitalInput__ = 11;
const uint FARENDCONTROLCAMERATILTUP__DigitalInput__ = 12;
const uint FARENDCONTROLCAMERATILTDOWN__DigitalInput__ = 13;
const uint FARENDCONTROLCAMERAZOOMIN__DigitalInput__ = 14;
const uint FARENDCONTROLCAMERAZOOMOUT__DigitalInput__ = 15;
const uint FARENDCONTROLCAMERAFOCUSIN__DigitalInput__ = 16;
const uint FARENDCONTROLCAMERAFOCUSOUT__DigitalInput__ = 17;
const uint FARENDCONTROLCAMERASTOP__DigitalInput__ = 18;
const uint FARENDCONTROLPRESENTATIONSOURCEID__AnalogSerialInput__ = 14;
const uint FARENDCONTROLPRESETACTIVATEID__AnalogSerialInput__ = 15;
const uint SETVOLUMELEVEL__AnalogSerialInput__ = 16;
const uint RESYNCRONIZECALLSTATUSLIST__DigitalInput__ = 19;
const uint TSTRING_RECEIVE_TEXT__AnalogSerialOutput__ = 1;
const uint TSTRING_SEND_TEXT__AnalogSerialInput__ = 17;
const uint SSTRING_RECEIVE_TEXT__AnalogSerialOutput__ = 2;
const uint SSTRING_SEND_TEXT__AnalogSerialInput__ = 18;
const uint DATATOTRACE__DigitalInput__ = 20;
const uint SEARCHDELAYSTART__AnalogSerialInput__ = 19;
const uint SEARCHDELAYMOD__AnalogSerialInput__ = 20;
const uint SEARCHDELAY__AnalogSerialInput__ = 21;
const uint DEFAULTCALLTYPESIP__DigitalInput__ = 21;
const uint SELECTEDPHONEBOOK_NAME__AnalogSerialOutput__ = 3;
const uint SELECTEDPHONEBOOK_NUMBER__AnalogSerialOutput__ = 4;
const uint SELECTEDPHONEBOOK_CALLRATE__AnalogSerialOutput__ = 5;
const uint PHONEBOOK_SEARCH_TEXT__AnalogSerialOutput__ = 6;
const uint GETVOLUMELEVEL__AnalogSerialOutput__ = 7;
const uint GETSYSTEMNAME__AnalogSerialOutput__ = 8;
const uint GETSYSTEMNETWORKADDRESS__AnalogSerialOutput__ = 9;
const uint GETGATEKEEPERSTATUS__AnalogSerialOutput__ = 10;
const uint GETGATEKEEPERREGISTRATIONMODE__AnalogSerialOutput__ = 11;
const uint GETGATEKEEPERNETWORKADDRESS__AnalogSerialOutput__ = 12;
const uint GETSYSTEMH323ID__AnalogSerialOutput__ = 13;
const uint GETSYSTEME164ALIAS__AnalogSerialOutput__ = 14;
const uint GETSYSTEMSIPURI__AnalogSerialOutput__ = 15;
const uint GETSYSTEMSOFTWAREVERSION__AnalogSerialOutput__ = 16;
const uint FROM_DEVICE_CONFIGURATIONCHANGES__AnalogSerialOutput__ = 17;
const uint FROM_DEVICE_STATUSCHANGES__AnalogSerialOutput__ = 18;
const uint MESSAGE_ALERT_TEXT__AnalogSerialOutput__ = 19;
const uint MESSAGE_ALERT_ISACTIVE__DigitalOutput__ = 0;
const uint MESSAGE_PROMPT_ISACTIVE__DigitalOutput__ = 1;
const uint MESSAGE_PROMPT_TITLE__AnalogSerialOutput__ = 20;
const uint MESSAGE_PROMPT_TEXT__AnalogSerialOutput__ = 21;
const uint MESSAGE_PROMPT_OPTION1_TEXT__AnalogSerialOutput__ = 22;
const uint MESSAGE_PROMPT_OPTION2_TEXT__AnalogSerialOutput__ = 23;
const uint MESSAGE_PROMPT_OPTION3_TEXT__AnalogSerialOutput__ = 24;
const uint MESSAGE_PROMPT_OPTION4_TEXT__AnalogSerialOutput__ = 25;
const uint MESSAGE_PROMPT_OPTION5_TEXT__AnalogSerialOutput__ = 26;
const uint MESSAGE_PROMPT_OPTION1_ISACTIVE__DigitalOutput__ = 2;
const uint MESSAGE_PROMPT_OPTION2_ISACTIVE__DigitalOutput__ = 3;
const uint MESSAGE_PROMPT_OPTION3_ISACTIVE__DigitalOutput__ = 4;
const uint MESSAGE_PROMPT_OPTION4_ISACTIVE__DigitalOutput__ = 5;
const uint MESSAGE_PROMPT_OPTION5_ISACTIVE__DigitalOutput__ = 6;
const uint MESSAGE_PROMPT_OPTION1_WASSELECTED__DigitalOutput__ = 7;
const uint MESSAGE_PROMPT_OPTION2_WASSELECTED__DigitalOutput__ = 8;
const uint MESSAGE_PROMPT_OPTION3_WASSELECTED__DigitalOutput__ = 9;
const uint MESSAGE_PROMPT_OPTION4_WASSELECTED__DigitalOutput__ = 10;
const uint MESSAGE_PROMPT_OPTION5_WASSELECTED__DigitalOutput__ = 11;
const uint PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER__DigitalOutput__ = 12;
const uint CURRENTFIRSTPHONEBOOKITEMNUMBER__AnalogSerialOutput__ = 27;
const uint CURRENTLASTPHONEBOOKITEMNUMBER__AnalogSerialOutput__ = 28;
const uint PHONEBOOK_SELECTED_FOLDER_NAME__AnalogSerialOutput__ = 29;
const uint DIRECTORYDOWNLOADBUSY__DigitalOutput__ = 13;
const uint TOTALROWSFORSEARCH__AnalogSerialOutput__ = 30;
const uint SELECTEDISFOLDER__DigitalOutput__ = 14;
const uint SELECTEDISCONTACT__DigitalOutput__ = 15;
const uint CALLHISTORYNAME__AnalogSerialOutput__ = 31;
const uint CALLHISTORYNUMBER__AnalogSerialOutput__ = 32;
const uint GETREBOOTCODEC_IS_IN_PROGRESS__DigitalOutput__ = 16;
const uint SIGNALINCOMINGCALL__DigitalOutput__ = 17;
const uint DEVICE_ONLINE__DigitalOutput__ = 18;
const uint INCOMINGCALLNUMBER__AnalogSerialOutput__ = 33;
const uint NUMBEROFACTIVECALLS__AnalogSerialOutput__ = 34;
const uint PHONEBOOKPAGESCURRENTPAGE__AnalogSerialOutput__ = 35;
const uint PHONEBOOKPAGESTOTALPAGES__AnalogSerialOutput__ = 36;
const uint DIRECTORYONTOPLEVEL__DigitalOutput__ = 19;
const uint CALLSTATUS_ISCONNECTED__DigitalOutput__ = 20;
const uint CALLSTATUS_SUPPORTSPRESENTATION__DigitalOutput__ = 23;
const uint CALLSTATUS_ISACTIVE__DigitalOutput__ = 26;
const uint INPUT_SOURCE_NAME__AnalogSerialOutput__ = 37;
const uint PHONEBOOK_NAME__AnalogSerialOutput__ = 42;
const uint PHONEBOOK_PAGES_NAME__AnalogSerialOutput__ = 297;
const uint CALLSTATUS_STATUS__AnalogSerialOutput__ = 317;
const uint CALLSTATUS_CALLTYPE__AnalogSerialOutput__ = 320;
const uint CALLSTATUS_REMOTESITE__AnalogSerialOutput__ = 323;
const uint CALLSTATUS_DURATION__AnalogSerialOutput__ = 326;
const uint CALLSTATUS_TRANSMITCALLRATE__AnalogSerialOutput__ = 329;
const uint CALLSTATUS_RECEIVECALLRATE__AnalogSerialOutput__ = 332;
const uint CALLSTATUS_DIRECTION__AnalogSerialOutput__ = 335;
const uint CALLSTATUS_CALLID__AnalogSerialOutput__ = 338;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}

[SplusStructAttribute(-1, true, false)]
public class PHONEBOOK : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  PARENTFOLDER = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  FIRSTCHILD = 0;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  ENTRYNAME;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  FOLDERID;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  CHILDCOUNT = 0;
    
    
    public PHONEBOOK( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ENTRYNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FOLDERID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class CONTACTLIST : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  CONTACTNUMBER;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  CALLRATE;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  CALLTYPE = 0;
    
    
    public CONTACTLIST( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        CONTACTNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        CALLRATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, Owner );
        
        
    }
    
}

}
