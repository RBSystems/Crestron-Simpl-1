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

namespace UserModule_R25_XML_PARSING_ROOM_SHEDULE_V1_6
{
    public class UserModuleClass_R25_XML_PARSING_ROOM_SHEDULE_V1_6 : SplusObject
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
            
            
            __context__.SourceCodeLine = 174;
            STATUS = (short) ( Functions.SocketConnectClient( TCPTXRX , HOSTNAME , (ushort)( Functions.Atoi( PORT ) ) , (ushort)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 176;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 178;
                Print( "Error connecting socket to address on port") ; 
                __context__.SourceCodeLine = 179;
                GenerateUserError ( "Error connecting socket to address on port") ; 
                __context__.SourceCodeLine = 180;
                return ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 184;
                CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        private void PROCESSXML (  SplusExecutionContext __context__, CrestronString XMLEVENT ) 
            { 
            ushort TITLES = 0;
            ushort TITLEE = 0;
            
            ushort RESSTARTS = 0;
            ushort RESSTARTE = 0;
            ushort RESENDS = 0;
            ushort RESENDE = 0;
            
            
            __context__.SourceCodeLine = 198;
            Print( "\r\ni is {0:d}\r\n", (short)I) ; 
            __context__.SourceCodeLine = 199;
            TITLES = (ushort) ( Functions.Find( "<title>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 200;
            TITLEE = (ushort) ( Functions.Find( "</title>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 205;
            RESSTARTS = (ushort) ( Functions.Find( "<ResStart>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 206;
            RESSTARTE = (ushort) ( Functions.Find( "</ResStart>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 207;
            RESENDS = (ushort) ( Functions.Find( "<ResEnd>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 208;
            RESENDE = (ushort) ( Functions.Find( "</ResEnd>" , XMLEVENT ) ) ; 
            __context__.SourceCodeLine = 215;
            CURRENTCLASS [ I] . TITLE  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (TITLES + 7) ) ,  (int) ( (TITLEE - (TITLES + 7)) ) )  ) ; 
            __context__.SourceCodeLine = 217;
            CURRENTCLASS [ I] . STARTTIME  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (RESSTARTS + 10) ) ,  (int) ( (RESSTARTE - (RESSTARTS + 10)) ) )  ) ; 
            __context__.SourceCodeLine = 219;
            CURRENTCLASS [ I] . ENDTIME  .UpdateValue ( Functions.Mid ( XMLEVENT ,  (int) ( (RESENDS + 8) ) ,  (int) ( (RESENDE - (RESENDS + 8)) ) )  ) ; 
            __context__.SourceCodeLine = 235;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 236;
            Functions.Delay (  (int) ( 10 ) ) ; 
            __context__.SourceCodeLine = 238;
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
            
            
            __context__.SourceCodeLine = 247;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTTIME != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 250;
                HOURS  .UpdateValue ( Functions.Left ( INPUTTIME ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 251;
                MINUTES  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 4 ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 252;
                AM_PM  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 253;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "P"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 255;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "01"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 257;
                        HOURS  .UpdateValue ( "13"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 259;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "02"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 261;
                            HOURS  .UpdateValue ( "14"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 263;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "03"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 265;
                                HOURS  .UpdateValue ( "15"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 267;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "04"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 269;
                                    HOURS  .UpdateValue ( "16"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 271;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "05"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 273;
                                        HOURS  .UpdateValue ( "17"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 275;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "06"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 277;
                                            HOURS  .UpdateValue ( "18"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 279;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "07"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 281;
                                                HOURS  .UpdateValue ( "19"  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 283;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "08"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 285;
                                                    HOURS  .UpdateValue ( "20"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 287;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "09"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 289;
                                                        HOURS  .UpdateValue ( "21"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 291;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "10"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 293;
                                                            HOURS  .UpdateValue ( "22"  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 295;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "11"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 297;
                                                                HOURS  .UpdateValue ( "23"  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 299;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 301;
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
                    __context__.SourceCodeLine = 304;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "A"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 306;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 308;
                            HOURS  .UpdateValue ( "00"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 312;
                            HOURS  .UpdateValue ( HOURS  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 317;
                HH = (ushort) ( Functions.Atoi( HOURS ) ) ; 
                __context__.SourceCodeLine = 318;
                HOURS_TO_MIN = (ushort) ( (HH * 60) ) ; 
                __context__.SourceCodeLine = 319;
                MN = (ushort) ( Functions.Atoi( MINUTES ) ) ; 
                __context__.SourceCodeLine = 320;
                TINTCOMBINED = (ushort) ( (HOURS_TO_MIN + MN) ) ; 
                __context__.SourceCodeLine = 324;
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
            
            
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTTIME != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 336;
                HOURS  .UpdateValue ( Functions.Left ( INPUTTIME ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 337;
                MINUTES  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 4 ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 338;
                AM_PM  .UpdateValue ( Functions.Mid ( INPUTTIME ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 339;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "P"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 341;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "01"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 343;
                        HOURS  .UpdateValue ( "13"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 345;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "02"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 347;
                            HOURS  .UpdateValue ( "14"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 349;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "03"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 351;
                                HOURS  .UpdateValue ( "15"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 353;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "04"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 355;
                                    HOURS  .UpdateValue ( "16"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 357;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "05"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 359;
                                        HOURS  .UpdateValue ( "17"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 361;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "06"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 363;
                                            HOURS  .UpdateValue ( "18"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 365;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "07"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 367;
                                                HOURS  .UpdateValue ( "19"  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 369;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "08"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 371;
                                                    HOURS  .UpdateValue ( "20"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 373;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "09"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 375;
                                                        HOURS  .UpdateValue ( "21"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 377;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "10"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 379;
                                                            HOURS  .UpdateValue ( "22"  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 381;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "11"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 383;
                                                                HOURS  .UpdateValue ( "23"  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 385;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 387;
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
                    __context__.SourceCodeLine = 390;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AM_PM == "A"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 392;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOURS == "12"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 394;
                            HOURS  .UpdateValue ( "00"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 398;
                            HOURS  .UpdateValue ( HOURS  ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 402;
                HH = (ushort) ( Functions.Atoi( HOURS ) ) ; 
                __context__.SourceCodeLine = 404;
                MN = (ushort) ( Functions.Atoi( MINUTES ) ) ; 
                __context__.SourceCodeLine = 406;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MN < 30 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 408;
                    NEWMIN = (ushort) ( (MN + 30) ) ; 
                    __context__.SourceCodeLine = 409;
                    NEWHH = (ushort) ( HH ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 413;
                    NEWMIN = (ushort) ( (MN - 30) ) ; 
                    __context__.SourceCodeLine = 414;
                    NEWHH = (ushort) ( (HH + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 417;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWHH == 24))  ) ) 
                    { 
                    __context__.SourceCodeLine = 419;
                    NEWHH = (ushort) ( 12 ) ; 
                    __context__.SourceCodeLine = 420;
                    NEWAORP  .UpdateValue ( "AM"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 422;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NEWHH > 12 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWHH < 24 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 424;
                        NEWHH = (ushort) ( (NEWHH - 12) ) ; 
                        __context__.SourceCodeLine = 425;
                        NEWAORP  .UpdateValue ( "PM"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 427;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWHH == 12))  ) ) 
                            { 
                            __context__.SourceCodeLine = 429;
                            NEWHH = (ushort) ( 12 ) ; 
                            __context__.SourceCodeLine = 430;
                            NEWAORP  .UpdateValue ( "PM"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 432;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NEWHH >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWHH < 12 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 434;
                                NEWHH = (ushort) ( NEWHH ) ; 
                                __context__.SourceCodeLine = 435;
                                NEWAORP  .UpdateValue ( "AM"  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 437;
                NEWMINUTES  .UpdateValue ( Functions.ItoA (  (int) ( NEWMIN ) )  ) ; 
                __context__.SourceCodeLine = 438;
                NEWHOURS  .UpdateValue ( Functions.ItoA (  (int) ( NEWHH ) )  ) ; 
                __context__.SourceCodeLine = 439;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEWMINUTES ) < 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 441;
                    NEWMINUTES  .UpdateValue ( "0" + NEWMINUTES  ) ; 
                    } 
                
                __context__.SourceCodeLine = 443;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( NEWHOURS ) < 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 445;
                    NEWHOURS  .UpdateValue ( "0" + NEWHOURS  ) ; 
                    } 
                
                __context__.SourceCodeLine = 449;
                TURNOFFTIME  .UpdateValue ( NEWHOURS + ":" + NEWMINUTES + " " + NEWAORP  ) ; 
                __context__.SourceCodeLine = 450;
                return ( TURNOFFTIME ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void CHECKINTERVAL (  SplusExecutionContext __context__ ) 
            { 
            ushort T = 0;
            ushort W = 0;
            
            
            __context__.SourceCodeLine = 459;
            W = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 460;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 463;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(I - 1); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( T  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (T  >= __FN_FORSTART_VAL__1) && (T  <= __FN_FOREND_VAL__1) ) : ( (T  <= __FN_FORSTART_VAL__1) && (T  >= __FN_FOREND_VAL__1) ) ; T  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 466;
                    CLASSENDTIME [ T] = (ushort) ( TIMETOINT( __context__ , CURRENTCLASS[ T ].ENDTIME ) ) ; 
                    __context__.SourceCodeLine = 467;
                    Print( "{0:d} class ends at {1}\r\n", (short)T, CURRENTCLASS [ T] . ENDTIME ) ; 
                    __context__.SourceCodeLine = 468;
                    CLASSNEXTSTARTTIME [ T] = (ushort) ( TIMETOINT( __context__ , CURRENTCLASS[ (T + 1) ].STARTTIME ) ) ; 
                    __context__.SourceCodeLine = 469;
                    Print( "following  class starts at {0}\r\n", CURRENTCLASS [ (T + 1)] . STARTTIME ) ; 
                    __context__.SourceCodeLine = 471;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (CLASSNEXTSTARTTIME[ T ] - CLASSENDTIME[ T ]) > 180 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 473;
                        PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                        __context__.SourceCodeLine = 474;
                        Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                        __context__.SourceCodeLine = 475;
                        W = (ushort) ( (W + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 477;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENTCLASS[ (T + 1) ].STARTTIME == ""))  ) ) 
                            { 
                            __context__.SourceCodeLine = 479;
                            PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                            __context__.SourceCodeLine = 480;
                            Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                            __context__.SourceCodeLine = 481;
                            W = (ushort) ( (W + 1) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 463;
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 485;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 487;
                    T = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 488;
                    PROJ_OFF_TIME [ T ]  .UpdateValue ( ADDHALF (  __context__ , CURRENTCLASS[ T ].ENDTIME)  ) ; 
                    __context__.SourceCodeLine = 489;
                    Print( "Projector will shut off at {0}.\r\n", PROJ_OFF_TIME [ T ] ) ; 
                    __context__.SourceCodeLine = 490;
                    W = (ushort) ( (W + 1) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 492;
            Print( "Projector will shut off {0:d} times.\r\n", (short)W) ; 
            
            }
            
        private void CLEARALLELEMENTS (  SplusExecutionContext __context__ ) 
            { 
            ushort N = 0;
            
            
            __context__.SourceCodeLine = 498;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)9; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( N  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (N  >= __FN_FORSTART_VAL__1) && (N  <= __FN_FOREND_VAL__1) ) : ( (N  <= __FN_FORSTART_VAL__1) && (N  >= __FN_FOREND_VAL__1) ) ; N  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 500;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . TITLE ) ; 
                __context__.SourceCodeLine = 501;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . STARTTIME ) ; 
                __context__.SourceCodeLine = 502;
                Functions.ClearBuffer ( CURRENTCLASS [ N] . ENDTIME ) ; 
                __context__.SourceCodeLine = 503;
                Functions.ClearBuffer ( PROJ_OFF_TIME [ N ] ) ; 
                __context__.SourceCodeLine = 498;
                } 
            
            
            }
            
        object LOGIN_R25_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 541;
                Functions.SocketDisconnectClient ( TCPTXRX ) ; 
                __context__.SourceCodeLine = 543;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOSTNAME == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 545;
                    GenerateUserError ( "The hostname serial input is blank") ; 
                    __context__.SourceCodeLine = 546;
                    return  this ; 
                    } 
                
                __context__.SourceCodeLine = 548;
                Functions.Delay (  (int) ( 25 ) ) ; 
                __context__.SourceCodeLine = 549;
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
            
            
            __context__.SourceCodeLine = 556;
            STATUS = (short) ( Functions.SocketDisconnectClient( TCPTXRX ) ) ; 
            __context__.SourceCodeLine = 557;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATUS == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 559;
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
        
        __context__.SourceCodeLine = 566;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 569;
        SOCKETRETURN  .Value = (ushort) ( Functions.SocketSend( TCPTXRX , ROOMSCHEDULEQUERY ) ) ; 
        __context__.SourceCodeLine = 571;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SOCKETRETURN  .Value > 60000 ))  ) ) 
            { 
            __context__.SourceCodeLine = 573;
            Functions.Delay (  (int) ( 1200 ) ) ; 
            __context__.SourceCodeLine = 574;
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
        
        __context__.SourceCodeLine = 580;
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
        
        
        __context__.SourceCodeLine = 683;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 684;
        GETXML  .UpdateValue ( Functions.Gather ( "</schedule>" , TCPTXRX .  SocketRxBuf )  ) ; 
        __context__.SourceCodeLine = 687;
        if ( Functions.TestForTrue  ( ( Functions.Find( "<events>" , GETXML ))  ) ) 
            { 
            __context__.SourceCodeLine = 690;
            while ( Functions.TestForTrue  ( ( Functions.Find( "</event>" , GETXML ))  ) ) 
                { 
                __context__.SourceCodeLine = 692;
                GETEVENT  .UpdateValue ( Functions.Remove ( "</event>" , GETXML )  ) ; 
                __context__.SourceCodeLine = 694;
                PROCESSXML (  __context__ , GETEVENT) ; 
                __context__.SourceCodeLine = 690;
                } 
            
            __context__.SourceCodeLine = 697;
            Functions.Delay (  (int) ( 25 ) ) ; 
            __context__.SourceCodeLine = 698;
            CHECKINTERVAL (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 702;
            CURRENTTITLE  .UpdateValue ( "NO CLASS TODAY"  ) ; 
            __context__.SourceCodeLine = 703;
            CURRENTSTARTTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 704;
            CURRENTENDTIME  .UpdateValue ( ""  ) ; 
            } 
        
        __context__.SourceCodeLine = 706;
        Print( "There are {0:d} classes today", (short)I) ; 
        __context__.SourceCodeLine = 707;
        Functions.ClearBuffer ( TCPTXRX .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 708;
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
        
        
        __context__.SourceCodeLine = 714;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 716;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(I - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 719;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].STARTTIME))  ) ) 
                    { 
                    __context__.SourceCodeLine = 721;
                    CURRENTTITLE  .UpdateValue ( CURRENTCLASS [ X] . TITLE  ) ; 
                    __context__.SourceCodeLine = 722;
                    CURRENTSTARTTIME  .UpdateValue ( CURRENTCLASS [ X] . STARTTIME  ) ; 
                    __context__.SourceCodeLine = 723;
                    CURRENTENDTIME  .UpdateValue ( CURRENTCLASS [ X] . ENDTIME  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 729;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].ENDTIME))  ) ) 
                        { 
                        __context__.SourceCodeLine = 732;
                        CURRENTTITLE  .UpdateValue ( "NO CLASS PRESENTLY"  ) ; 
                        __context__.SourceCodeLine = 733;
                        CURRENTSTARTTIME  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 734;
                        CURRENTENDTIME  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 738;
                        Functions.Pulse ( 60, TURN_TO_HOMEPAGE ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 741;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIME_O_DAY == PROJ_OFF_TIME[ X ]))  ) ) 
                            { 
                            __context__.SourceCodeLine = 743;
                            Functions.Pulse ( 60, TURN_PROJ_OFF_DELAY30 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 746;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 748;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ (X - 1) ].ENDTIME) ) && Functions.TestForTrue ( Functions.BoolToInt (TIME_O_DAY == CURRENTCLASS[ X ].STARTTIME) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 750;
                                    CURRENTTITLE  .UpdateValue ( CURRENTCLASS [ X] . TITLE  ) ; 
                                    __context__.SourceCodeLine = 751;
                                    CURRENTSTARTTIME  .UpdateValue ( CURRENTCLASS [ X] . STARTTIME  ) ; 
                                    __context__.SourceCodeLine = 752;
                                    CURRENTENDTIME  .UpdateValue ( CURRENTCLASS [ X] . ENDTIME  ) ; 
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 716;
                } 
            
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
        
        __context__.SourceCodeLine = 786;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 787;
        I = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 788;
        CURRENTTITLE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 789;
        CURRENTSTARTTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 790;
        CURRENTENDTIME  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
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

public UserModuleClass_R25_XML_PARSING_ROOM_SHEDULE_V1_6 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




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
