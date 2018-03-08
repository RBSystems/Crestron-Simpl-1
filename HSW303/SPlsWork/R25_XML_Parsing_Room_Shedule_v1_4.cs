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

namespace UserModule_R25_XML_PARSING_ROOM_SHEDULE_V1_4
{
    public class UserModuleClass_R25_XML_PARSING_ROOM_SHEDULE_V1_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SENDSCHEDULEQUERY;
        Crestron.Logos.SplusObjects.DigitalInput LOGIN_R25;
        Crestron.Logos.SplusObjects.DigitalInput LOGOUT_R25;
        Crestron.Logos.SplusObjects.DigitalInput CLEARYESTERDAY;
        Crestron.Logos.SplusObjects.StringInput ROOMSCHEDULEQUERY;
        Crestron.Logos.SplusObjects.StringInput HOSTNAME;
        Crestron.Logos.SplusObjects.StringInput PORT;
        Crestron.Logos.SplusObjects.StringInput TIME_O_DAY;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput TURN_PROJ_OFF_DELAY30;
        Crestron.Logos.SplusObjects.DigitalOutput TURN_TO_HOMEPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput SOCKETRETURN;
        Crestron.Logos.SplusObjects.StringOutput CURRENTTITLE;
        Crestron.Logos.SplusObjects.StringOutput CURRENTSTARTTIME;
        Crestron.Logos.SplusObjects.StringOutput CURRENTENDTIME;
        SplusTcpClient TCPTXRX;
        CLASSTIMES [] CURRENTCLASS;
        ushort I = 0;
        ushort [] CLASSENDTIME;
        ushort [] CLASSNEXTSTARTTIME;
        CrestronString [] PROJ_OFF_TIME;
        private void TRYLOGIN (  SplusExecutionContext __context__ ) 
            { 
            short STATUS = 0;
            
            
            __context__.SourceCodeLine = 173;
            STATUS = (short) ( Functions.SocketConnectClient( TCPTXRX , HOSTNAME , (ushort)( Functions.Atoi( PORT ) ) , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 175;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 177;
                Print( "Error connecting socket to address on port") ; 
                __context__.SourceCodeLine = 178;
                GenerateUserError ( "Error connecting socket to address on port") ; 
                __context__.SourceCodeLine = 179;
                return ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 183;
                CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        private void PROCESSXML (  SplusExecutionContext __context__, CrestronString XMLEVENT ) 
            { 
            ushort TITLES = 0;
            ushort TITLEE = 0;
            
            ushort STARTS = 0;
            ushort STARTE = 0;
            
            ushort ENDS = 0;
            ushort ENDE = 0;
            
            
            __context__.SourceCodeLine = 197;
            Print( "\r\ni is {0:d}\r\n", (short)I) ; 
            __context__.SourceCodeLine = 198;
            TITLES = (ushort) ( Functions.Find( "<title>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 199;
            TITLEE = (ushort) ( Functions.Find( "</title>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 200;
            STARTS = (ushort) ( Functions.Find( "<start>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 201;
            STARTE = (ushort) ( Functions.Find( "</start>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 202;
            ENDS = (ushort) ( Functions.Find( "<end>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 203;
            ENDE = (ushort) ( Functions.Find( "</end>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 210;
            CURRENTCLASS [ I] . TITLE  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (TITLES + 7) ) ,  (int) ( (TITLEE - (TITLES + 7)) ) )  ) ; 
            __context__.SourceCodeLine = 212;
            CURRENTCLASS [ I] . STARTTIME  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (STARTS + 7) ) ,  (int) ( (STARTE - (STARTS + 7)) ) )  ) ; 
            __context__.SourceCodeLine = 214;
            CURRENTCLASS [ I] . ENDTIME  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (ENDS + 5) ) ,  (int) ( (ENDE - (ENDS + 5)) ) )  ) ; 
            __context__.SourceCodeLine = 230;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 231;
            Functions.Delay (  (int) ( 10 ) ) ; 
            __context__.SourceCodeLine = 233;
            I = (ushort) ( (I + 1) ) ; 
            
            }
            
        private ushort TIMETOINT (  SplusExecutionContext __context__, CrestronString INPUTTIME ) 
            { 
            CrestronString HOURS;
            CrestronString MINUTES;
            CrestronString AM_PM;
            CrestronString TIME_COMBINED;
            HOURS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            MINUTES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            AM_PM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            TIME_COMBINED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            ushort HH = 0;
            ushort MN = 0;
            ushort AORP = 0;
            ushort TINTCOMBINED = 0;
            ushort HOURS_TO_MIN = 0;
            
            
            __context__.SourceCodeLine = 242;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTTIME != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 245;
                HOURS  .UpdateValue ( Functions.Left ( INPUTTIME ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 246;
                MINUTES  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 4 ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 247;
                AM_PM  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 248;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "P"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 250;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "01"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 252;
                        HOURS  .UpdateValue ( "13"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 254;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "02"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 256;
                            HOURS  .UpdateValue ( "14"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 258;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "03"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 260;
                                HOURS  .UpdateValue ( "15"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 262;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "04"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 264;
                                    HOURS  .UpdateValue ( "16"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 266;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "05"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 268;
                                        HOURS  .UpdateValue ( "17"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 270;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "06"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 272;
                                            HOURS  .UpdateValue ( "18"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 274;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "07"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 276;
                                                HOURS  .UpdateValue ( "19"  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 278;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "08"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 280;
                                                    HOURS  .UpdateValue ( "20"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 282;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "09"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 284;
                                                        HOURS  .UpdateValue ( "21"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 286;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "10"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 288;
                                                            HOURS  .UpdateValue ( "22"  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 290;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "11"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 292;
                                                                HOURS  .UpdateValue ( "23"  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 294;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 296;
                                                                    HOURS  .UpdateValue ( "12"  ) ; 
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
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 299;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "A"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 301;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 303;
                            HOURS  .UpdateValue ( "00"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 307;
                            HOURS  .UpdateValue ( HOURS  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 312;
                HH = (ushort) ( Functions.Atoi( HOURS ) ) ; 
                __context__.SourceCodeLine = 313;
                HOURS_TO_MIN = (ushort) ( (HH * 60) ) ; 
                __context__.SourceCodeLine = 314;
                MN = (ushort) ( Functions.Atoi( MINUTES ) ) ; 
                __context__.SourceCodeLine = 315;
                TINTCOMBINED = (ushort) ( (HOURS_TO_MIN + MN) ) ; 
                __context__.SourceCodeLine = 319;
                return (ushort)( TINTCOMBINED) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString ADDHALF (  SplusExecutionContext __context__, CrestronString INPUTTIME ) 
            { 
            CrestronString HOURS;
            CrestronString MINUTES;
            CrestronString AM_PM;
            HOURS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            MINUTES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            AM_PM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            CrestronString NEWHOURS;
            CrestronString NEWMINUTES;
            CrestronString NEWAORP;
            CrestronString TURNOFFTIME;
            NEWHOURS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            NEWMINUTES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            NEWAORP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            TURNOFFTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            ushort HH = 0;
            ushort MN = 0;
            ushort NEWMIN = 0;
            ushort NEWHH = 0;
            
            
            __context__.SourceCodeLine = 329;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTTIME != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 331;
                HOURS  .UpdateValue ( Functions.Left ( INPUTTIME ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 332;
                MINUTES  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 4 ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 333;
                AM_PM  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 334;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "P"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 336;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "01"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 338;
                        HOURS  .UpdateValue ( "13"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 340;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "02"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 342;
                            HOURS  .UpdateValue ( "14"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 344;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "03"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 346;
                                HOURS  .UpdateValue ( "15"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 348;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "04"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 350;
                                    HOURS  .UpdateValue ( "16"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 352;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "05"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 354;
                                        HOURS  .UpdateValue ( "17"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 356;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "06"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 358;
                                            HOURS  .UpdateValue ( "18"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 360;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "07"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 362;
                                                HOURS  .UpdateValue ( "19"  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 364;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "08"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 366;
                                                    HOURS  .UpdateValue ( "20"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 368;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "09"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 370;
                                                        HOURS  .UpdateValue ( "21"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 372;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "10"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 374;
                                                            HOURS  .UpdateValue ( "22"  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 376;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "11"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 378;
                                                                HOURS  .UpdateValue ( "23"  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 380;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 382;
                                                                    HOURS  .UpdateValue ( "12"  ) ; 
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
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 385;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "A"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 387;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 389;
                            HOURS  .UpdateValue ( "00"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 393;
                            HOURS  .UpdateValue ( HOURS  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 397;
                HH = (ushort) ( Functions.Atoi( HOURS ) ) ; 
                __context__.SourceCodeLine = 399;
                MN = (ushort) ( Functions.Atoi( MINUTES ) ) ; 
                __context__.SourceCodeLine = 401;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MN < 30 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 403;
                    NEWMIN = (ushort) ( (MN + 30) ) ; 
                    __context__.SourceCodeLine = 404;
                    NEWHH = (ushort) ( HH ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 408;
                    NEWMIN = (ushort) ( (MN - 30) ) ; 
                    __context__.SourceCodeLine = 409;
                    NEWHH = (ushort) ( (HH + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 412;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWHH == 24))  ) ) 
                    { 
                    __context__.SourceCodeLine = 414;
                    NEWHH = (ushort) ( 12 ) ; 
                    __context__.SourceCodeLine = 415;
                    NEWAORP  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 417;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NEWHH > 12 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWHH < 24 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 419;
                        NEWHH = (ushort) ( (NEWHH - 12) ) ; 
                        __context__.SourceCodeLine = 420;
                        NEWAORP  .UpdateValue ( "PM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 422;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWHH == 12))  ) ) 
                            { 
                            __context__.SourceCodeLine = 424;
                            NEWHH = (ushort) ( 12 ) ; 
                            __context__.SourceCodeLine = 425;
                            NEWAORP  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 427;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NEWHH >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWHH < 12 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 429;
                                NEWHH = (ushort) ( NEWHH ) ; 
                                __context__.SourceCodeLine = 430;
                                NEWAORP  .UpdateValue ( "AM"  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 432;
                NEWMINUTES  .UpdateValue ( Functions.ItoA (  (int) ( NEWMIN ) )  ) ; 
                __context__.SourceCodeLine = 433;
                NEWHOURS  .UpdateValue ( Functions.ItoA (  (int) ( NEWHH ) )  ) ; 
                __context__.SourceCodeLine = 434;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEWMINUTES ) < 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 436;
                    NEWMINUTES  .UpdateValue ( "0" + NEWMINUTES  ) ; 
                    } 
                
                __context__.SourceCodeLine = 438;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEWHOURS ) < 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 440;
                    NEWHOURS  .UpdateValue ( "0" + NEWHOURS  ) ; 
                    } 
                
                __context__.SourceCodeLine = 444;
                TURNOFFTIME  .UpdateValue ( NEWHOURS + ":" + NEWMINUTES + " " + NEWAORP  ) ; 
                __context__.SourceCodeLine = 445;
                return ( TURNOFFTIME ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void CHECKINTERVAL (  SplusExecutionContext __context__ ) 
            { 
            ushort T = 0;
            ushort W = 0;
            
            
            __context__.SourceCodeLine = 454;
            W = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 455;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 458;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(I - 1); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( T  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (T  >= __FN_FORSTART_VAL__1) && (T  <= __FN_FOREND_VAL__1) ) : ( (T  <= __FN_FORSTART_VAL__1) && (T  >= __FN_FOREND_VAL__1) ) ; T  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 461;
                    CLASSENDTIME [ T] = (ushort) ( TIMETOINT( __context__ , CURRENTCLASS[ T ].ENDTIME ) ) ; 
                    __context__.SourceCodeLine = 462;
                    Print( "{0:d} class ends at {1}\r\n", (short)T, CURRENTCLASS [ T] . ENDTIME ) ; 
                    __context__.SourceCodeLine = 463;
                    CLASSNEXTSTARTTIME [ T] = (ushort) ( TIMETOINT( __context__ , CURRENTCLASS[ (T + 1) ].STARTTIME ) ) ; 
                    __context__.SourceCodeLine = 464;
                    Print( "following  class starts at {0}\r\n", CURRENTCLASS [ (T + 1)] . STARTTIME ) ; 
                    __context__.SourceCodeLine = 466;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (CLASSNEXTSTARTTIME[ T ] - CLASSENDTIME[ T ]) > 180 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 468;
                        PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                        __context__.SourceCodeLine = 469;
                        Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                        __context__.SourceCodeLine = 470;
                        W = (ushort) ( (W + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 472;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENTCLASS[ (T + 1) ].STARTTIME == ""))  ) ) 
                            { 
                            __context__.SourceCodeLine = 474;
                            PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                            __context__.SourceCodeLine = 475;
                            Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                            __context__.SourceCodeLine = 476;
                            W = (ushort) ( (W + 1) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 458;
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 480;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 482;
                    T = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 483;
                    PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                    __context__.SourceCodeLine = 484;
                    Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                    __context__.SourceCodeLine = 485;
                    W = (ushort) ( (W + 1) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 487;
            Print( "Projector will shut off {0:d} times.\r\n", (short)W) ; 
            
            }
            
        private void CLEARALLELEMENTS (  SplusExecutionContext __context__ ) 
            { 
            ushort N = 0;
            
            
            __context__.SourceCodeLine = 493;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)9; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( N  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (N  >= __FN_FORSTART_VAL__1) && (N  <= __FN_FOREND_VAL__1) ) : ( (N  <= __FN_FORSTART_VAL__1) && (N  >= __FN_FOREND_VAL__1) ) ; N  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 495;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . TITLE ) ; 
                __context__.SourceCodeLine = 496;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . STARTTIME ) ; 
                __context__.SourceCodeLine = 497;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . ENDTIME ) ; 
                __context__.SourceCodeLine = 498;
                Functions.ClearBuffer ( PROJ_OFF_TIME [ N ] ) ; 
                __context__.SourceCodeLine = 493;
                } 
            
            
            }
            
        object LOGIN_R25_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 536;
                Functions.SocketDisconnectClient ( TCPTXRX ) ; 
                __context__.SourceCodeLine = 538;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOSTNAME == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 540;
                    GenerateUserError ( "The hostname serial input is blank") ; 
                    __context__.SourceCodeLine = 541;
                    return  this ; 
                    } 
                
                __context__.SourceCodeLine = 543;
                Functions.Delay (  (int) ( 25 ) ) ; 
                __context__.SourceCodeLine = 544;
                TRYLOGIN (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LOGOUT_R25_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            short STATUS = 0;
            
            
            __context__.SourceCodeLine = 551;
            STATUS = (short) ( Functions.SocketDisconnectClient( TCPTXRX ) ) ; 
            __context__.SourceCodeLine = 552;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATUS == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 554;
                CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SENDSCHEDULEQUERY_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 561;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 564;
        SOCKETRETURN  .Value = (ushort) ( Functions.SocketSend( TCPTXRX , ROOMSCHEDULEQUERY ) ) ; 
        __context__.SourceCodeLine = 566;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SOCKETRETURN  .Value > 60000 ))  ) ) 
            { 
            __context__.SourceCodeLine = 568;
            Functions.Delay (  (int) ( 1200 ) ) ; 
            __context__.SourceCodeLine = 569;
            TRYLOGIN (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEARYESTERDAY_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 575;
        CLEARALLELEMENTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TCPTXRX_OnSocketReceive_4 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        CrestronString GETXML;
        GETXML  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4096, this );
        
        CrestronString GETEVENT;
        GETEVENT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 678;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 679;
        GETXML  .UpdateValue ( Functions.Gather ( "</schedule>" , TCPTXRX .  SocketRxBuf )  ) ; 
        __context__.SourceCodeLine = 682;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<events>" , GETXML ))  ) ) 
            { 
            __context__.SourceCodeLine = 685;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</event>" , GETXML ))  ) ) 
                { 
                __context__.SourceCodeLine = 687;
                GETEVENT  .UpdateValue ( Functions.Remove ( "</event>" , GETXML )  ) ; 
                __context__.SourceCodeLine = 689;
                PROCESSXML (  __context__ , GETEVENT) ; 
                __context__.SourceCodeLine = 685;
                } 
            
            __context__.SourceCodeLine = 692;
            Functions.Delay (  (int) ( 25 ) ) ; 
            __context__.SourceCodeLine = 693;
            CHECKINTERVAL (  __context__  ) ; 
            } 
        
        __context__.SourceCodeLine = 695;
        Print( "There are {0:d} classes today", (short)I) ; 
        __context__.SourceCodeLine = 696;
        Functions.ClearBuffer ( TCPTXRX .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 697;
        Functions.ClearBuffer ( GETXML ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object TIME_O_DAY_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 703;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)(I - 1); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 706;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].STARTTIME))  ) ) 
                { 
                __context__.SourceCodeLine = 708;
                CURRENTTITLE  .UpdateValue ( CURRENTCLASS [ X] . TITLE  ) ; 
                __context__.SourceCodeLine = 709;
                CURRENTSTARTTIME  .UpdateValue ( CURRENTCLASS [ X] . STARTTIME  ) ; 
                __context__.SourceCodeLine = 710;
                CURRENTENDTIME  .UpdateValue ( CURRENTCLASS [ X] . ENDTIME  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 716;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].ENDTIME))  ) ) 
                    { 
                    __context__.SourceCodeLine = 719;
                    CURRENTTITLE  .UpdateValue ( "NO CLASS PRESENTLY"  ) ; 
                    __context__.SourceCodeLine = 720;
                    CURRENTSTARTTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 721;
                    CURRENTENDTIME  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 725;
                    Functions.Pulse ( 60, TURN_TO_HOMEPAGE ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 728;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == PROJ_OFF_TIME[ X ]))  ) ) 
                        { 
                        __context__.SourceCodeLine = 730;
                        Functions.Pulse ( 60, TURN_PROJ_OFF_DELAY30 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 733;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 735;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ (X - 1) ].ENDTIME) ) && Functions.TestForTrue ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].STARTTIME) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 737;
                                CURRENTTITLE  .UpdateValue ( CURRENTCLASS [ X] . TITLE  ) ; 
                                __context__.SourceCodeLine = 738;
                                CURRENTSTARTTIME  .UpdateValue ( CURRENTCLASS [ X] . STARTTIME  ) ; 
                                __context__.SourceCodeLine = 739;
                                CURRENTENDTIME  .UpdateValue ( CURRENTCLASS [ X] . ENDTIME  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 703;
            } 
        
        
        
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
        
        __context__.SourceCodeLine = 773;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 774;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 775;
        CURRENTTITLE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 776;
        CURRENTSTARTTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 777;
        CURRENTENDTIME  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    CLASSENDTIME  = new ushort[ 11 ];
    CLASSNEXTSTARTTIME  = new ushort[ 11 ];
    PROJ_OFF_TIME  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        PROJ_OFF_TIME [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
    TCPTXRX  = new SplusTcpClient ( 4096, this );
    CURRENTCLASS  = new CLASSTIMES[ 11 ];
    for( uint i = 0; i < 11; i++ )
    {
        CURRENTCLASS [i] = new CLASSTIMES( this, true );
        CURRENTCLASS [i].PopulateCustomAttributeList( false );
        
    }
    
    SENDSCHEDULEQUERY = new Crestron.Logos.SplusObjects.DigitalInput( SENDSCHEDULEQUERY__DigitalInput__, this );
    m_DigitalInputList.Add( SENDSCHEDULEQUERY__DigitalInput__, SENDSCHEDULEQUERY );
    
    LOGIN_R25 = new Crestron.Logos.SplusObjects.DigitalInput( LOGIN_R25__DigitalInput__, this );
    m_DigitalInputList.Add( LOGIN_R25__DigitalInput__, LOGIN_R25 );
    
    LOGOUT_R25 = new Crestron.Logos.SplusObjects.DigitalInput( LOGOUT_R25__DigitalInput__, this );
    m_DigitalInputList.Add( LOGOUT_R25__DigitalInput__, LOGOUT_R25 );
    
    CLEARYESTERDAY = new Crestron.Logos.SplusObjects.DigitalInput( CLEARYESTERDAY__DigitalInput__, this );
    m_DigitalInputList.Add( CLEARYESTERDAY__DigitalInput__, CLEARYESTERDAY );
    
    CONNECTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECTED_FB__DigitalOutput__, CONNECTED_FB );
    
    TURN_PROJ_OFF_DELAY30 = new Crestron.Logos.SplusObjects.DigitalOutput( TURN_PROJ_OFF_DELAY30__DigitalOutput__, this );
    m_DigitalOutputList.Add( TURN_PROJ_OFF_DELAY30__DigitalOutput__, TURN_PROJ_OFF_DELAY30 );
    
    TURN_TO_HOMEPAGE = new Crestron.Logos.SplusObjects.DigitalOutput( TURN_TO_HOMEPAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( TURN_TO_HOMEPAGE__DigitalOutput__, TURN_TO_HOMEPAGE );
    
    SOCKETRETURN = new Crestron.Logos.SplusObjects.AnalogOutput( SOCKETRETURN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOCKETRETURN__AnalogSerialOutput__, SOCKETRETURN );
    
    ROOMSCHEDULEQUERY = new Crestron.Logos.SplusObjects.StringInput( ROOMSCHEDULEQUERY__AnalogSerialInput__, 512, this );
    m_StringInputList.Add( ROOMSCHEDULEQUERY__AnalogSerialInput__, ROOMSCHEDULEQUERY );
    
    HOSTNAME = new Crestron.Logos.SplusObjects.StringInput( HOSTNAME__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( HOSTNAME__AnalogSerialInput__, HOSTNAME );
    
    PORT = new Crestron.Logos.SplusObjects.StringInput( PORT__AnalogSerialInput__, 4, this );
    m_StringInputList.Add( PORT__AnalogSerialInput__, PORT );
    
    TIME_O_DAY = new Crestron.Logos.SplusObjects.StringInput( TIME_O_DAY__AnalogSerialInput__, 18, this );
    m_StringInputList.Add( TIME_O_DAY__AnalogSerialInput__, TIME_O_DAY );
    
    CURRENTTITLE = new Crestron.Logos.SplusObjects.StringOutput( CURRENTTITLE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTTITLE__AnalogSerialOutput__, CURRENTTITLE );
    
    CURRENTSTARTTIME = new Crestron.Logos.SplusObjects.StringOutput( CURRENTSTARTTIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTSTARTTIME__AnalogSerialOutput__, CURRENTSTARTTIME );
    
    CURRENTENDTIME = new Crestron.Logos.SplusObjects.StringOutput( CURRENTENDTIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENTENDTIME__AnalogSerialOutput__, CURRENTENDTIME );
    
    
    LOGIN_R25.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOGIN_R25_OnPush_0, false ) );
    LOGOUT_R25.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOGOUT_R25_OnPush_1, false ) );
    SENDSCHEDULEQUERY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDSCHEDULEQUERY_OnPush_2, false ) );
    CLEARYESTERDAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEARYESTERDAY_OnPush_3, false ) );
    TCPTXRX.OnSocketReceive.Add( new SocketHandlerWrapper( TCPTXRX_OnSocketReceive_4, false ) );
    TIME_O_DAY.OnSerialChange.Add( new InputChangeHandlerWrapper( TIME_O_DAY_OnChange_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_R25_XML_PARSING_ROOM_SHEDULE_V1_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SENDSCHEDULEQUERY__DigitalInput__ = 0;
const uint LOGIN_R25__DigitalInput__ = 1;
const uint LOGOUT_R25__DigitalInput__ = 2;
const uint CLEARYESTERDAY__DigitalInput__ = 3;
const uint ROOMSCHEDULEQUERY__AnalogSerialInput__ = 0;
const uint HOSTNAME__AnalogSerialInput__ = 1;
const uint PORT__AnalogSerialInput__ = 2;
const uint TIME_O_DAY__AnalogSerialInput__ = 3;
const uint CONNECTED_FB__DigitalOutput__ = 0;
const uint TURN_PROJ_OFF_DELAY30__DigitalOutput__ = 1;
const uint TURN_TO_HOMEPAGE__DigitalOutput__ = 2;
const uint SOCKETRETURN__AnalogSerialOutput__ = 0;
const uint CURRENTTITLE__AnalogSerialOutput__ = 1;
const uint CURRENTSTARTTIME__AnalogSerialOutput__ = 2;
const uint CURRENTENDTIME__AnalogSerialOutput__ = 3;

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
public class CLASSTIMES : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  TITLE;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  STARTTIME;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  ENDTIME;
    
    
    public CLASSTIMES( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        TITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, Owner );
        STARTTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, Owner );
        ENDTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, Owner );
        
        
    }
    
}

}
