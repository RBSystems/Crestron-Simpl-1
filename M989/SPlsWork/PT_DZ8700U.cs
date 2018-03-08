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

namespace UserModule_PT_DZ8700U
{
    public class UserModuleClass_PT_DZ8700U : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POWERON;
        Crestron.Logos.SplusObjects.DigitalInput POWEROFF;
        Crestron.Logos.SplusObjects.DigitalInput POWERTOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput INPUTRGB1;
        Crestron.Logos.SplusObjects.DigitalInput INPUTRGB2;
        Crestron.Logos.SplusObjects.DigitalInput INPUTSVIDEO;
        Crestron.Logos.SplusObjects.DigitalInput INPUTCOMPOSITE;
        Crestron.Logos.SplusObjects.DigitalInput INPUTDVI;
        Crestron.Logos.SplusObjects.DigitalInput LAMPHOUR;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTETOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTEON;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTEOFF;
        Crestron.Logos.SplusObjects.DigitalInput AUTOADJUST;
        Crestron.Logos.SplusObjects.DigitalInput POLL;
        Crestron.Logos.SplusObjects.DigitalInput FUNCONE;
        Crestron.Logos.SplusObjects.DigitalInput PINPOFF;
        Crestron.Logos.SplusObjects.DigitalInput PINPON;
        Crestron.Logos.SplusObjects.DigitalInput PINPSWAP;
        Crestron.Logos.SplusObjects.DigitalInput SUBINPUTRGB1;
        Crestron.Logos.SplusObjects.DigitalInput SUBINPUTRGB2;
        Crestron.Logos.SplusObjects.DigitalInput SUBINPUTSVIDEO;
        Crestron.Logos.SplusObjects.DigitalInput SUBINPUTCOMPOSITE;
        Crestron.Logos.SplusObjects.DigitalInput SUBINPUTDVI;
        Crestron.Logos.SplusObjects.BufferInput PROJ_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POWERISON;
        Crestron.Logos.SplusObjects.DigitalOutput POWERISOFF;
        Crestron.Logos.SplusObjects.DigitalOutput PROJISWARMING;
        Crestron.Logos.SplusObjects.DigitalOutput PROJISCOOLING;
        Crestron.Logos.SplusObjects.DigitalOutput VIDEOMUTEFB;
        Crestron.Logos.SplusObjects.DigitalOutput BLINKFB;
        Crestron.Logos.SplusObjects.DigitalOutput QUERYPOPUP;
        Crestron.Logos.SplusObjects.DigitalOutput PINP_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput PINP_IS_OFF;
        Crestron.Logos.SplusObjects.StringOutput PROJ_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput STATUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LAMPHOURS__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP1HOURS;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP2HOURS;
        ushort CMDSENT = 0;
        ushort VIDEOMUTED = 0;
        ushort PROJISON = 0;
        ushort ISWARMUP = 0;
        ushort ISCOOLDOWN = 0;
        ushort SUBRGB1PENDING = 0;
        ushort SUBRGB2PENDING = 0;
        ushort SUBSVIDEOPENDING = 0;
        ushort SUBCOMPOSITEPENDING = 0;
        ushort SUBDVIPENDING = 0;
        CrestronString LAMP1HOURS__DOLLAR__;
        CrestronString LAMP2HOURS__DOLLAR__;
        ushort SEMAPHORE = 0;
        ushort POLL_SEMAPHORE = 0;
        ushort COMMANDQUEUE = 0;
        private void PROCESSCOMMANDQUE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 248;
            CreateWait ( "QWAIT" , 20 , QWAIT_Callback ) ;
            
            }
            
        public void QWAIT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 250;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 5))  ) ) 
                { 
                __context__.SourceCodeLine = 252;
                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 253;
                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;PON\u0003"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 255;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 257;
                    Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 258;
                    PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;POF\u0003"  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 260;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 7))  ) ) 
                        { 
                        __context__.SourceCodeLine = 262;
                        Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                        __context__.SourceCodeLine = 263;
                        CMDSENT = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 264;
                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;Q$L:1\u0003"  ) ; 
                        __context__.SourceCodeLine = 265;
                        Functions.Delay (  (int) ( 15 ) ) ; 
                        __context__.SourceCodeLine = 266;
                        Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                        __context__.SourceCodeLine = 267;
                        CMDSENT = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 268;
                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;Q$L:2\u0003"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 270;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 8))  ) ) 
                            { 
                            __context__.SourceCodeLine = 272;
                            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                            __context__.SourceCodeLine = 273;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VIDEOMUTED == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 275;
                                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 276;
                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:0\u0003"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 280;
                                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 281;
                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:1\u0003"  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 284;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 9))  ) ) 
                                { 
                                __context__.SourceCodeLine = 286;
                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:RG1\u0003"  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 288;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 290;
                                    PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:RG2\u0003"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 292;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 294;
                                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:SVD\u0003"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 296;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 298;
                                            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:VID\u0003"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 300;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 302;
                                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:DVI\u0003"  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 304;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 14))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 306;
                                                    PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:RG1\u0003"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 308;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 15))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 310;
                                                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:RG2\u0003"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 312;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 16))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 314;
                                                            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:SVD\u0003"  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 316;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 17))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 318;
                                                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:VID\u0003"  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 320;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 18))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 322;
                                                                    PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:DVI\u0003"  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 324;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 19))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 326;
                                                                        Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                        __context__.SourceCodeLine = 327;
                                                                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OCL\u0003"  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 329;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 20))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 331;
                                                                            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                            __context__.SourceCodeLine = 332;
                                                                            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OPP:1\u0003"  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 334;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 21))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 336;
                                                                                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                                __context__.SourceCodeLine = 337;
                                                                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OPP:0\u0003"  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 339;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 22))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 341;
                                                                                    Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                                    __context__.SourceCodeLine = 342;
                                                                                    PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;FC1\u0003"  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 344;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 23))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 346;
                                                                                        Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                                        __context__.SourceCodeLine = 347;
                                                                                        PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:1\u0003"  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 349;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 24))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 351;
                                                                                            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                                            __context__.SourceCodeLine = 352;
                                                                                            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:0\u0003"  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 354;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDQUEUE == 25))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 356;
                                                                                                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                                                                                                __context__.SourceCodeLine = 357;
                                                                                                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OAS\u0003"  ) ; 
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
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object POLL_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 367;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 369;
                POLL_SEMAPHORE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 370;
                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 371;
                CMDSENT = (ushort) ( 3 ) ; 
                __context__.SourceCodeLine = 372;
                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;Q$S\u0003"  ) ; 
                __context__.SourceCodeLine = 373;
                Functions.Delay (  (int) ( 15 ) ) ; 
                __context__.SourceCodeLine = 374;
                Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 375;
                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;QPW\u0003"  ) ; 
                __context__.SourceCodeLine = 376;
                POLL_SEMAPHORE = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object LAMPHOUR_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 383;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 385;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 386;
            CMDSENT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 387;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;Q$L:1\u0003"  ) ; 
            __context__.SourceCodeLine = 388;
            Functions.Delay (  (int) ( 15 ) ) ; 
            __context__.SourceCodeLine = 389;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 390;
            CMDSENT = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 391;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;Q$L:2\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 393;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 395;
                COMMANDQUEUE = (ushort) ( 7 ) ; 
                __context__.SourceCodeLine = 396;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTETOGGLE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 402;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 404;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 405;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VIDEOMUTED == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 407;
                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:0\u0003"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 411;
                PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:1\u0003"  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 414;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 416;
                COMMANDQUEUE = (ushort) ( 8 ) ; 
                __context__.SourceCodeLine = 417;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEON_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 424;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 426;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 427;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:1\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 429;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 431;
                COMMANDQUEUE = (ushort) ( 23 ) ; 
                __context__.SourceCodeLine = 432;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEOFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 438;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 440;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 441;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OSH:0\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 443;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 445;
                COMMANDQUEUE = (ushort) ( 24 ) ; 
                __context__.SourceCodeLine = 446;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOADJUST_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 452;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 454;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 455;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OAS\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 457;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 459;
                COMMANDQUEUE = (ushort) ( 25 ) ; 
                __context__.SourceCodeLine = 460;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FUNCONE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 466;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 468;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;FC1\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 470;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 472;
                COMMANDQUEUE = (ushort) ( 22 ) ; 
                __context__.SourceCodeLine = 473;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PINPOFF_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 480;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 482;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 483;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OPP:0\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 485;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 487;
                COMMANDQUEUE = (ushort) ( 21 ) ; 
                __context__.SourceCodeLine = 488;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PINPON_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 494;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 496;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 497;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OPP:1\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 499;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 501;
                COMMANDQUEUE = (ushort) ( 20 ) ; 
                __context__.SourceCodeLine = 502;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PINPSWAP_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 507;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 509;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;OCL\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 511;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 513;
                COMMANDQUEUE = (ushort) ( 19 ) ; 
                __context__.SourceCodeLine = 514;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERTOGGLE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 520;
        if ( Functions.TestForTrue  ( ( ISCOOLDOWN)  ) ) 
            {
            __context__.SourceCodeLine = 521;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 522;
        if ( Functions.TestForTrue  ( ( ISWARMUP)  ) ) 
            {
            __context__.SourceCodeLine = 523;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 524;
        if ( Functions.TestForTrue  ( ( PROJISON)  ) ) 
            { 
            __context__.SourceCodeLine = 526;
            Functions.Pulse ( 50, QUERYPOPUP ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 530;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;PON\u0003"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERON_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 536;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 538;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 539;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;PON\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 541;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 543;
                COMMANDQUEUE = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 544;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWEROFF_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 550;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 552;
            Functions.ClearBuffer ( PROJ_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 553;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;POF\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 555;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 557;
                COMMANDQUEUE = (ushort) ( 6 ) ; 
                __context__.SourceCodeLine = 558;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBINPUTRGB1_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 564;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 566;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:RG1\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 568;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 570;
                COMMANDQUEUE = (ushort) ( 14 ) ; 
                __context__.SourceCodeLine = 571;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBINPUTRGB2_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 577;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 579;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:RG2\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 581;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 583;
                COMMANDQUEUE = (ushort) ( 15 ) ; 
                __context__.SourceCodeLine = 584;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBINPUTSVIDEO_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 591;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 593;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:SVD\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 595;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 597;
                COMMANDQUEUE = (ushort) ( 16 ) ; 
                __context__.SourceCodeLine = 598;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBINPUTCOMPOSITE_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 604;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 606;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:VID\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 608;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 610;
                COMMANDQUEUE = (ushort) ( 17 ) ; 
                __context__.SourceCodeLine = 611;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBINPUTDVI_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 617;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 619;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;SIS:DVI\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 621;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 623;
                COMMANDQUEUE = (ushort) ( 18 ) ; 
                __context__.SourceCodeLine = 624;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTRGB1_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 630;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 632;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:RG1\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 634;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 636;
                COMMANDQUEUE = (ushort) ( 9 ) ; 
                __context__.SourceCodeLine = 637;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTRGB2_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 643;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 645;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:RG2\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 647;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 649;
                COMMANDQUEUE = (ushort) ( 10 ) ; 
                __context__.SourceCodeLine = 650;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTSVIDEO_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 657;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 659;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:SVD\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 661;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 663;
                COMMANDQUEUE = (ushort) ( 11 ) ; 
                __context__.SourceCodeLine = 664;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTCOMPOSITE_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 671;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 673;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:VID\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 675;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 677;
                COMMANDQUEUE = (ushort) ( 12 ) ; 
                __context__.SourceCodeLine = 678;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUTDVI_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 685;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 687;
            PROJ_TX__DOLLAR__  .UpdateValue ( "\u0002ADZZ;IIS:DVI\u0003"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 689;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEMAPHORE == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (POLL_SEMAPHORE == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 691;
                COMMANDQUEUE = (ushort) ( 13 ) ; 
                __context__.SourceCodeLine = 692;
                PROCESSCOMMANDQUE (  __context__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PROJ_RX__DOLLAR___OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 702;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 704;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 705;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002000\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 707;
                PROJISON = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 708;
                POWERISON  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 709;
                POWERISOFF  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 710;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ISWARMUP == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ISCOOLDOWN == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 712;
                    STATUS__DOLLAR__  .UpdateValue ( "POWER IS OFF"  ) ; 
                    __context__.SourceCodeLine = 713;
                    BLINKFB  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 716;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002001\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 718;
                    PROJISON = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 719;
                    POWERISON  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 720;
                    POWERISOFF  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 721;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ISWARMUP == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (ISCOOLDOWN == 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 723;
                        STATUS__DOLLAR__  .UpdateValue ( "POWER IS ON"  ) ; 
                        __context__.SourceCodeLine = 724;
                        BLINKFB  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 727;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002PON\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 729;
                        PROJISON = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 730;
                        POWERISON  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 731;
                        POWERISOFF  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 733;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002POF\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 735;
                            PROJISON = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 736;
                            POWERISON  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 737;
                            POWERISOFF  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 739;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u00020\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 741;
                                PROJISWARMING  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 742;
                                PROJISCOOLING  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 744;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u00021\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 746;
                                    PROJISWARMING  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 747;
                                    PROJISCOOLING  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 749;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u00022\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 751;
                                        PROJISWARMING  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 752;
                                        PROJISCOOLING  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 754;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u00023\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 756;
                                            PROJISWARMING  .Value = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 757;
                                            PROJISCOOLING  .Value = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 759;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CMDSENT == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( PROJ_RX__DOLLAR__ ) == 6) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 761;
                                                LAMP1HOURS__DOLLAR__  .UpdateValue ( Functions.Mid ( PROJ_RX__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 4 ) )  ) ; 
                                                __context__.SourceCodeLine = 762;
                                                LAMP1HOURS  .Value = (ushort) ( Functions.Atoi( LAMP1HOURS__DOLLAR__ ) ) ; 
                                                __context__.SourceCodeLine = 763;
                                                CMDSENT = (ushort) ( 0 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 765;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CMDSENT == 2) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( PROJ_RX__DOLLAR__ ) == 6) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 767;
                                                    LAMP2HOURS__DOLLAR__  .UpdateValue ( Functions.Mid ( PROJ_RX__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 4 ) )  ) ; 
                                                    __context__.SourceCodeLine = 768;
                                                    LAMP2HOURS  .Value = (ushort) ( Functions.Atoi( LAMP2HOURS__DOLLAR__ ) ) ; 
                                                    __context__.SourceCodeLine = 769;
                                                    CMDSENT = (ushort) ( 0 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 771;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002OSH:1\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 773;
                                                        VIDEOMUTEFB  .Value = (ushort) ( 1 ) ; 
                                                        __context__.SourceCodeLine = 774;
                                                        VIDEOMUTED = (ushort) ( 1 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 776;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002OSH:0\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 778;
                                                            VIDEOMUTEFB  .Value = (ushort) ( 0 ) ; 
                                                            __context__.SourceCodeLine = 779;
                                                            VIDEOMUTED = (ushort) ( 0 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 781;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002OPP:0\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 783;
                                                                PINP_IS_ON  .Value = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 784;
                                                                PINP_IS_OFF  .Value = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 786;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "\u0002OPP:1\u0003" , PROJ_RX__DOLLAR__ ) == 1))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 788;
                                                                    PINP_IS_ON  .Value = (ushort) ( 1 ) ; 
                                                                    __context__.SourceCodeLine = 789;
                                                                    PINP_IS_OFF  .Value = (ushort) ( 0 ) ; 
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
                
                }
            
            __context__.SourceCodeLine = 791;
            SEMAPHORE = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 808;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 814;
        POWERISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 815;
        POWERISOFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 816;
        PROJISON = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 817;
        BLINKFB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 818;
        VIDEOMUTEFB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 819;
        VIDEOMUTED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 820;
        QUERYPOPUP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 821;
        CMDSENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 822;
        STATUS__DOLLAR__  .UpdateValue ( "POWER IS OFF"  ) ; 
        __context__.SourceCodeLine = 823;
        LAMPHOURS__DOLLAR__  .UpdateValue ( "?\r?"  ) ; 
        __context__.SourceCodeLine = 824;
        LAMP1HOURS__DOLLAR__  .UpdateValue ( "?"  ) ; 
        __context__.SourceCodeLine = 825;
        LAMP2HOURS__DOLLAR__  .UpdateValue ( "?"  ) ; 
        __context__.SourceCodeLine = 826;
        COMMANDQUEUE = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 827;
        CMDSENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 828;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 829;
        ISCOOLDOWN = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 830;
        ISWARMUP = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 831;
        PROJISWARMING  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 832;
        PROJISCOOLING  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    LAMP1HOURS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    LAMP2HOURS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    
    POWERON = new Crestron.Logos.SplusObjects.DigitalInput( POWERON__DigitalInput__, this );
    m_DigitalInputList.Add( POWERON__DigitalInput__, POWERON );
    
    POWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( POWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWEROFF__DigitalInput__, POWEROFF );
    
    POWERTOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( POWERTOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( POWERTOGGLE__DigitalInput__, POWERTOGGLE );
    
    INPUTRGB1 = new Crestron.Logos.SplusObjects.DigitalInput( INPUTRGB1__DigitalInput__, this );
    m_DigitalInputList.Add( INPUTRGB1__DigitalInput__, INPUTRGB1 );
    
    INPUTRGB2 = new Crestron.Logos.SplusObjects.DigitalInput( INPUTRGB2__DigitalInput__, this );
    m_DigitalInputList.Add( INPUTRGB2__DigitalInput__, INPUTRGB2 );
    
    INPUTSVIDEO = new Crestron.Logos.SplusObjects.DigitalInput( INPUTSVIDEO__DigitalInput__, this );
    m_DigitalInputList.Add( INPUTSVIDEO__DigitalInput__, INPUTSVIDEO );
    
    INPUTCOMPOSITE = new Crestron.Logos.SplusObjects.DigitalInput( INPUTCOMPOSITE__DigitalInput__, this );
    m_DigitalInputList.Add( INPUTCOMPOSITE__DigitalInput__, INPUTCOMPOSITE );
    
    INPUTDVI = new Crestron.Logos.SplusObjects.DigitalInput( INPUTDVI__DigitalInput__, this );
    m_DigitalInputList.Add( INPUTDVI__DigitalInput__, INPUTDVI );
    
    LAMPHOUR = new Crestron.Logos.SplusObjects.DigitalInput( LAMPHOUR__DigitalInput__, this );
    m_DigitalInputList.Add( LAMPHOUR__DigitalInput__, LAMPHOUR );
    
    VIDEOMUTETOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTETOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTETOGGLE__DigitalInput__, VIDEOMUTETOGGLE );
    
    VIDEOMUTEON = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTEON__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTEON__DigitalInput__, VIDEOMUTEON );
    
    VIDEOMUTEOFF = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTEOFF__DigitalInput__, VIDEOMUTEOFF );
    
    AUTOADJUST = new Crestron.Logos.SplusObjects.DigitalInput( AUTOADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOADJUST__DigitalInput__, AUTOADJUST );
    
    POLL = new Crestron.Logos.SplusObjects.DigitalInput( POLL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL__DigitalInput__, POLL );
    
    FUNCONE = new Crestron.Logos.SplusObjects.DigitalInput( FUNCONE__DigitalInput__, this );
    m_DigitalInputList.Add( FUNCONE__DigitalInput__, FUNCONE );
    
    PINPOFF = new Crestron.Logos.SplusObjects.DigitalInput( PINPOFF__DigitalInput__, this );
    m_DigitalInputList.Add( PINPOFF__DigitalInput__, PINPOFF );
    
    PINPON = new Crestron.Logos.SplusObjects.DigitalInput( PINPON__DigitalInput__, this );
    m_DigitalInputList.Add( PINPON__DigitalInput__, PINPON );
    
    PINPSWAP = new Crestron.Logos.SplusObjects.DigitalInput( PINPSWAP__DigitalInput__, this );
    m_DigitalInputList.Add( PINPSWAP__DigitalInput__, PINPSWAP );
    
    SUBINPUTRGB1 = new Crestron.Logos.SplusObjects.DigitalInput( SUBINPUTRGB1__DigitalInput__, this );
    m_DigitalInputList.Add( SUBINPUTRGB1__DigitalInput__, SUBINPUTRGB1 );
    
    SUBINPUTRGB2 = new Crestron.Logos.SplusObjects.DigitalInput( SUBINPUTRGB2__DigitalInput__, this );
    m_DigitalInputList.Add( SUBINPUTRGB2__DigitalInput__, SUBINPUTRGB2 );
    
    SUBINPUTSVIDEO = new Crestron.Logos.SplusObjects.DigitalInput( SUBINPUTSVIDEO__DigitalInput__, this );
    m_DigitalInputList.Add( SUBINPUTSVIDEO__DigitalInput__, SUBINPUTSVIDEO );
    
    SUBINPUTCOMPOSITE = new Crestron.Logos.SplusObjects.DigitalInput( SUBINPUTCOMPOSITE__DigitalInput__, this );
    m_DigitalInputList.Add( SUBINPUTCOMPOSITE__DigitalInput__, SUBINPUTCOMPOSITE );
    
    SUBINPUTDVI = new Crestron.Logos.SplusObjects.DigitalInput( SUBINPUTDVI__DigitalInput__, this );
    m_DigitalInputList.Add( SUBINPUTDVI__DigitalInput__, SUBINPUTDVI );
    
    POWERISON = new Crestron.Logos.SplusObjects.DigitalOutput( POWERISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERISON__DigitalOutput__, POWERISON );
    
    POWERISOFF = new Crestron.Logos.SplusObjects.DigitalOutput( POWERISOFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERISOFF__DigitalOutput__, POWERISOFF );
    
    PROJISWARMING = new Crestron.Logos.SplusObjects.DigitalOutput( PROJISWARMING__DigitalOutput__, this );
    m_DigitalOutputList.Add( PROJISWARMING__DigitalOutput__, PROJISWARMING );
    
    PROJISCOOLING = new Crestron.Logos.SplusObjects.DigitalOutput( PROJISCOOLING__DigitalOutput__, this );
    m_DigitalOutputList.Add( PROJISCOOLING__DigitalOutput__, PROJISCOOLING );
    
    VIDEOMUTEFB = new Crestron.Logos.SplusObjects.DigitalOutput( VIDEOMUTEFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( VIDEOMUTEFB__DigitalOutput__, VIDEOMUTEFB );
    
    BLINKFB = new Crestron.Logos.SplusObjects.DigitalOutput( BLINKFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( BLINKFB__DigitalOutput__, BLINKFB );
    
    QUERYPOPUP = new Crestron.Logos.SplusObjects.DigitalOutput( QUERYPOPUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( QUERYPOPUP__DigitalOutput__, QUERYPOPUP );
    
    PINP_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( PINP_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( PINP_IS_ON__DigitalOutput__, PINP_IS_ON );
    
    PINP_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( PINP_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( PINP_IS_OFF__DigitalOutput__, PINP_IS_OFF );
    
    LAMP1HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP1HOURS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP1HOURS__AnalogSerialOutput__, LAMP1HOURS );
    
    LAMP2HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP2HOURS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP2HOURS__AnalogSerialOutput__, LAMP2HOURS );
    
    PROJ_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PROJ_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROJ_TX__DOLLAR____AnalogSerialOutput__, PROJ_TX__DOLLAR__ );
    
    STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATUS__DOLLAR____AnalogSerialOutput__, STATUS__DOLLAR__ );
    
    LAMPHOURS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LAMPHOURS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LAMPHOURS__DOLLAR____AnalogSerialOutput__, LAMPHOURS__DOLLAR__ );
    
    PROJ_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( PROJ_RX__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( PROJ_RX__DOLLAR____AnalogSerialInput__, PROJ_RX__DOLLAR__ );
    
    QWAIT_Callback = new WaitFunction( QWAIT_CallbackFn );
    
    POLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_OnPush_0, false ) );
    LAMPHOUR.OnDigitalPush.Add( new InputChangeHandlerWrapper( LAMPHOUR_OnPush_1, false ) );
    VIDEOMUTETOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTETOGGLE_OnPush_2, false ) );
    VIDEOMUTEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTEON_OnPush_3, false ) );
    VIDEOMUTEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTEOFF_OnPush_4, false ) );
    AUTOADJUST.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOADJUST_OnPush_5, false ) );
    FUNCONE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FUNCONE_OnPush_6, false ) );
    PINPOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( PINPOFF_OnPush_7, false ) );
    PINPON.OnDigitalPush.Add( new InputChangeHandlerWrapper( PINPON_OnPush_8, false ) );
    PINPSWAP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PINPSWAP_OnPush_9, false ) );
    POWERTOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERTOGGLE_OnPush_10, false ) );
    POWERON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERON_OnPush_11, false ) );
    POWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWEROFF_OnPush_12, false ) );
    SUBINPUTRGB1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBINPUTRGB1_OnPush_13, false ) );
    SUBINPUTRGB2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBINPUTRGB2_OnPush_14, false ) );
    SUBINPUTSVIDEO.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBINPUTSVIDEO_OnPush_15, false ) );
    SUBINPUTCOMPOSITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBINPUTCOMPOSITE_OnPush_16, false ) );
    SUBINPUTDVI.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBINPUTDVI_OnPush_17, false ) );
    INPUTRGB1.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTRGB1_OnPush_18, false ) );
    INPUTRGB2.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTRGB2_OnPush_19, false ) );
    INPUTSVIDEO.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTSVIDEO_OnPush_20, false ) );
    INPUTCOMPOSITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTCOMPOSITE_OnPush_21, false ) );
    INPUTDVI.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUTDVI_OnPush_22, false ) );
    PROJ_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( PROJ_RX__DOLLAR___OnChange_23, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PT_DZ8700U ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction QWAIT_Callback;


const uint POWERON__DigitalInput__ = 0;
const uint POWEROFF__DigitalInput__ = 1;
const uint POWERTOGGLE__DigitalInput__ = 2;
const uint INPUTRGB1__DigitalInput__ = 3;
const uint INPUTRGB2__DigitalInput__ = 4;
const uint INPUTSVIDEO__DigitalInput__ = 5;
const uint INPUTCOMPOSITE__DigitalInput__ = 6;
const uint INPUTDVI__DigitalInput__ = 7;
const uint LAMPHOUR__DigitalInput__ = 8;
const uint VIDEOMUTETOGGLE__DigitalInput__ = 9;
const uint VIDEOMUTEON__DigitalInput__ = 10;
const uint VIDEOMUTEOFF__DigitalInput__ = 11;
const uint AUTOADJUST__DigitalInput__ = 12;
const uint POLL__DigitalInput__ = 13;
const uint FUNCONE__DigitalInput__ = 14;
const uint PINPOFF__DigitalInput__ = 15;
const uint PINPON__DigitalInput__ = 16;
const uint PINPSWAP__DigitalInput__ = 17;
const uint SUBINPUTRGB1__DigitalInput__ = 18;
const uint SUBINPUTRGB2__DigitalInput__ = 19;
const uint SUBINPUTSVIDEO__DigitalInput__ = 20;
const uint SUBINPUTCOMPOSITE__DigitalInput__ = 21;
const uint SUBINPUTDVI__DigitalInput__ = 22;
const uint PROJ_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint POWERISON__DigitalOutput__ = 0;
const uint POWERISOFF__DigitalOutput__ = 1;
const uint PROJISWARMING__DigitalOutput__ = 2;
const uint PROJISCOOLING__DigitalOutput__ = 3;
const uint VIDEOMUTEFB__DigitalOutput__ = 4;
const uint BLINKFB__DigitalOutput__ = 5;
const uint QUERYPOPUP__DigitalOutput__ = 6;
const uint PINP_IS_ON__DigitalOutput__ = 7;
const uint PINP_IS_OFF__DigitalOutput__ = 8;
const uint PROJ_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint STATUS__DOLLAR____AnalogSerialOutput__ = 1;
const uint LAMPHOURS__DOLLAR____AnalogSerialOutput__ = 2;
const uint LAMP1HOURS__AnalogSerialOutput__ = 3;
const uint LAMP2HOURS__AnalogSerialOutput__ = 4;

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


}
