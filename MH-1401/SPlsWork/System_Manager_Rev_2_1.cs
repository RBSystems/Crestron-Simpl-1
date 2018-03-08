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

namespace UserModule_SYSTEM_MANAGER_REV_2_1
{
    public class UserModuleClass_SYSTEM_MANAGER_REV_2_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POWERONFB;
        Crestron.Logos.SplusObjects.DigitalInput POWEROFFFB;
        Crestron.Logos.SplusObjects.DigitalInput INPUT1_FB;
        Crestron.Logos.SplusObjects.DigitalInput INPUT2_FB;
        Crestron.Logos.SplusObjects.DigitalInput INPUT3_FB;
        Crestron.Logos.SplusObjects.DigitalInput INPUT4_FB;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_1;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_2;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_3;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_4;
        Crestron.Logos.SplusObjects.DigitalInput SCREENUP;
        Crestron.Logos.SplusObjects.DigitalInput SCREENDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DISPLAYON;
        Crestron.Logos.SplusObjects.DigitalInput DISPLAYOFF;
        Crestron.Logos.SplusObjects.DigitalInput SYNC_POWER;
        Crestron.Logos.SplusObjects.DigitalInput SYNC_INPUT;
        Crestron.Logos.SplusObjects.DigitalInput ENABLEFORCE;
        Crestron.Logos.SplusObjects.DigitalInput ENABLESCREEN;
        Crestron.Logos.SplusObjects.DigitalInput ENABLECOOLDOWN;
        Crestron.Logos.SplusObjects.DigitalInput ENABLEWARMUP;
        Crestron.Logos.SplusObjects.DigitalInput EXIT;
        Crestron.Logos.SplusObjects.DigitalOutput POWERON_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput POWEROFF_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT1_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT2_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT3_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT4_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput SCREENUP_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput SCREENDOWN_PULSE;
        Crestron.Logos.SplusObjects.DigitalOutput COOLBUSY;
        Crestron.Logos.SplusObjects.DigitalOutput COOLDONE;
        Crestron.Logos.SplusObjects.DigitalOutput WARMBUSY;
        Crestron.Logos.SplusObjects.DigitalOutput WARMDONE;
        Crestron.Logos.SplusObjects.DigitalOutput GO2SPLASH;
        Crestron.Logos.SplusObjects.AnalogOutput COOLBAR;
        Crestron.Logos.SplusObjects.AnalogOutput WARMBAR;
        Crestron.Logos.SplusObjects.StringOutput COOLCOUNT;
        Crestron.Logos.SplusObjects.StringOutput WARMCOUNT;
        UShortParameter WARMTIMER;
        UShortParameter COOLTIMER;
        ushort IINPUT = 0;
        ushort IPOWERFB = 0;
        ushort IINPUTFB = 0;
        ushort ISYSSTATE = 0;
        ushort DISPLAY_BUSY = 0;
        private void STARTCOOLDOWN (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 110;
            I = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 111;
            COOLCOUNT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 112;
            if ( Functions.TestForTrue  ( ( ENABLECOOLDOWN  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 114;
                COOLBUSY  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 115;
                DISPLAY_BUSY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 117;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)COOLTIMER  .Value; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 120;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 121;
                    COOLBAR  .Value = (ushort) ( I ) ; 
                    __context__.SourceCodeLine = 122;
                    COOLCOUNT  .UpdateValue ( Functions.ItoA (  (int) ( I ) )  ) ; 
                    __context__.SourceCodeLine = 117;
                    } 
                
                __context__.SourceCodeLine = 126;
                COOLBUSY  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 127;
                COOLDONE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 128;
                COOLDONE  .Value = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 133;
            DISPLAY_BUSY = (ushort) ( 0 ) ; 
            
            }
            
        private void STARTWARMUP (  SplusExecutionContext __context__ ) 
            { 
            ushort J = 0;
            
            
            __context__.SourceCodeLine = 143;
            J = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 144;
            WARMCOUNT  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 145;
            if ( Functions.TestForTrue  ( ( ENABLEWARMUP  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 147;
                WARMBUSY  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 148;
                DISPLAY_BUSY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 150;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)WARMTIMER  .Value; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 153;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 154;
                    WARMBAR  .Value = (ushort) ( J ) ; 
                    __context__.SourceCodeLine = 155;
                    WARMCOUNT  .UpdateValue ( Functions.ItoA (  (int) ( J ) )  ) ; 
                    __context__.SourceCodeLine = 150;
                    } 
                
                __context__.SourceCodeLine = 160;
                WARMBUSY  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 161;
                WARMDONE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 162;
                WARMDONE  .Value = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 166;
            DISPLAY_BUSY = (ushort) ( 0 ) ; 
            
            }
            
        private void CHECKPOWER (  SplusExecutionContext __context__, ushort POWERSTATE ) 
            { 
            
            __context__.SourceCodeLine = 173;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( IPOWERFB ) ) && Functions.TestForTrue ( POWERSTATE )) ) ) && Functions.TestForTrue ( Functions.Not( ENABLEFORCE  .Value ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 176;
                POWERON_PULSE  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 177;
                POWERON_PULSE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 178;
                ISYSSTATE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 180;
                if ( Functions.TestForTrue  ( ( ENABLESCREEN  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 182;
                    SCREENDOWN_PULSE  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 183;
                    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_14__" , 20 , __SPLS_TMPVAR__WAITLABEL_14___Callback ) ;
                    __context__.SourceCodeLine = 184;
                    SCREENDOWN_PULSE  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 186;
                STARTWARMUP (  __context__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 187;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( IPOWERFB ) && Functions.TestForTrue ( Functions.Not( POWERSTATE ) )) ) ) && Functions.TestForTrue ( Functions.Not( ENABLEFORCE  .Value ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 191;
                    POWEROFF_PULSE  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 192;
                    POWEROFF_PULSE  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 193;
                    ISYSSTATE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 195;
                    if ( Functions.TestForTrue  ( ( ENABLESCREEN  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 197;
                        SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 198;
                        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_15__" , 20 , __SPLS_TMPVAR__WAITLABEL_15___Callback ) ;
                        __context__.SourceCodeLine = 199;
                        SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 201;
                    STARTCOOLDOWN (  __context__  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 206;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLEFORCE  .Value ) && Functions.TestForTrue ( Functions.Not( POWERSTATE ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 209;
                        POWEROFF_PULSE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 210;
                        POWEROFF_PULSE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 214;
                        if ( Functions.TestForTrue  ( ( ENABLESCREEN  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 216;
                            SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 217;
                            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_16__" , 20 , __SPLS_TMPVAR__WAITLABEL_16___Callback ) ;
                            __context__.SourceCodeLine = 218;
                            SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 222;
                        if ( Functions.TestForTrue  ( ( ISYSSTATE)  ) ) 
                            {
                            __context__.SourceCodeLine = 223;
                            STARTCOOLDOWN (  __context__  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 225;
                        ISYSSTATE = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 229;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( ENABLEFORCE  .Value ) && Functions.TestForTrue ( POWERSTATE )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 231;
                            POWERON_PULSE  .Value = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 232;
                            POWERON_PULSE  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 235;
                            if ( Functions.TestForTrue  ( ( ENABLESCREEN  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 237;
                                SCREENDOWN_PULSE  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 238;
                                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_17__" , 500 , __SPLS_TMPVAR__WAITLABEL_17___Callback ) ;
                                __context__.SourceCodeLine = 239;
                                SCREENDOWN_PULSE  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 242;
                            if ( Functions.TestForTrue  ( ( Functions.Not( ISYSSTATE ))  ) ) 
                                {
                                __context__.SourceCodeLine = 243;
                                STARTWARMUP (  __context__  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 245;
                            ISYSSTATE = (ushort) ( 1 ) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        public void __SPLS_TMPVAR__WAITLABEL_14___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            {
            __context__.SourceCodeLine = 183;
            ; 
            }
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_15___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            {
            __context__.SourceCodeLine = 198;
            ; 
            }
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_16___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 217;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public void __SPLS_TMPVAR__WAITLABEL_17___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 238;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void CHECKINPUT (  SplusExecutionContext __context__, ushort INPUTSTATE ) 
    { 
    
    __context__.SourceCodeLine = 255;
    if ( Functions.TestForTrue  ( ( Functions.Not( ISYSSTATE ))  ) ) 
        { 
        __context__.SourceCodeLine = 258;
        CHECKPOWER (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 259;
        Functions.Delay (  (int) ( (WARMTIMER  .Value * 100) ) ) ; 
        __context__.SourceCodeLine = 262;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 263;
            Functions.Pulse ( 20, INPUT1_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 264;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 2))  ) ) 
            {
            __context__.SourceCodeLine = 265;
            Functions.Pulse ( 20, INPUT2_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 266;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 3))  ) ) 
            {
            __context__.SourceCodeLine = 267;
            Functions.Pulse ( 20, INPUT3_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 268;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 4))  ) ) 
            {
            __context__.SourceCodeLine = 269;
            Functions.Pulse ( 20, INPUT4_PULSE ) ; 
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 273;
        if ( Functions.TestForTrue  ( ( ISYSSTATE)  ) ) 
            { 
            __context__.SourceCodeLine = 275;
            CHECKPOWER (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 277;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 1))  ) ) 
                {
                __context__.SourceCodeLine = 278;
                Functions.Pulse ( 20, INPUT1_PULSE ) ; 
                }
            
            __context__.SourceCodeLine = 279;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 2))  ) ) 
                {
                __context__.SourceCodeLine = 280;
                Functions.Pulse ( 20, INPUT2_PULSE ) ; 
                }
            
            __context__.SourceCodeLine = 281;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 3))  ) ) 
                {
                __context__.SourceCodeLine = 282;
                Functions.Pulse ( 20, INPUT3_PULSE ) ; 
                }
            
            __context__.SourceCodeLine = 283;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTATE == 4))  ) ) 
                {
                __context__.SourceCodeLine = 284;
                Functions.Pulse ( 20, INPUT4_PULSE ) ; 
                }
            
            } 
        
        }
    
    
    }
    
private void POWER_SYNC (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 309;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISYSSTATE != IPOWERFB))  ) ) 
        { 
        __context__.SourceCodeLine = 311;
        if ( Functions.TestForTrue  ( ( ISYSSTATE)  ) ) 
            { 
            __context__.SourceCodeLine = 313;
            Functions.Pulse ( 20, POWERON_PULSE ) ; 
            __context__.SourceCodeLine = 314;
            ISYSSTATE = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 316;
        if ( Functions.TestForTrue  ( ( Functions.Not( ISYSSTATE ))  ) ) 
            { 
            __context__.SourceCodeLine = 319;
            Functions.Pulse ( 20, POWEROFF_PULSE ) ; 
            __context__.SourceCodeLine = 321;
            ISYSSTATE = (ushort) ( 0 ) ; 
            } 
        
        } 
    
    
    }
    
private void INPUT_SYNC (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 335;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUT != IINPUTFB))  ) ) 
        { 
        __context__.SourceCodeLine = 339;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUT == 1))  ) ) 
            {
            __context__.SourceCodeLine = 340;
            Functions.Pulse ( 20, INPUT1_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 341;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUT == 2))  ) ) 
            {
            __context__.SourceCodeLine = 342;
            Functions.Pulse ( 20, INPUT2_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 343;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUT == 3))  ) ) 
            {
            __context__.SourceCodeLine = 344;
            Functions.Pulse ( 20, INPUT3_PULSE ) ; 
            }
        
        __context__.SourceCodeLine = 345;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUT == 4))  ) ) 
            {
            __context__.SourceCodeLine = 346;
            Functions.Pulse ( 20, INPUT4_PULSE ) ; 
            }
        
        } 
    
    
    }
    
object POWERONFB_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 376;
        IPOWERFB = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWEROFFFB_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 384;
        IPOWERFB = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCREENUP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 391;
        SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 392;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_18__" , 20 , __SPLS_TMPVAR__WAITLABEL_18___Callback ) ;
        __context__.SourceCodeLine = 393;
        SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_18___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 392;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SCREENDOWN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 401;
        SCREENDOWN_PULSE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 402;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_19__" , 20 , __SPLS_TMPVAR__WAITLABEL_19___Callback ) ;
        __context__.SourceCodeLine = 403;
        SCREENDOWN_PULSE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_19___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 402;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object DISPLAYON_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 412;
        Functions.Pulse ( 20, POWERON_PULSE ) ; 
        __context__.SourceCodeLine = 413;
        ISYSSTATE = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISPLAYOFF_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 421;
        Functions.Pulse ( 20, POWEROFF_PULSE ) ; 
        __context__.SourceCodeLine = 423;
        ISYSSTATE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_1_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 429;
        if ( Functions.TestForTrue  ( ( Functions.Not( DISPLAY_BUSY ))  ) ) 
            { 
            __context__.SourceCodeLine = 432;
            CHECKINPUT (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 433;
            IINPUT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 434;
            ISYSSTATE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_2_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 444;
        if ( Functions.TestForTrue  ( ( Functions.Not( DISPLAY_BUSY ))  ) ) 
            { 
            __context__.SourceCodeLine = 446;
            CHECKINPUT (  __context__ , (ushort)( 2 )) ; 
            __context__.SourceCodeLine = 447;
            IINPUT = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 448;
            ISYSSTATE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_3_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 455;
        if ( Functions.TestForTrue  ( ( Functions.Not( DISPLAY_BUSY ))  ) ) 
            { 
            __context__.SourceCodeLine = 457;
            CHECKINPUT (  __context__ , (ushort)( 3 )) ; 
            __context__.SourceCodeLine = 458;
            IINPUT = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 459;
            ISYSSTATE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_4_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 467;
        if ( Functions.TestForTrue  ( ( Functions.Not( DISPLAY_BUSY ))  ) ) 
            { 
            __context__.SourceCodeLine = 469;
            CHECKINPUT (  __context__ , (ushort)( 4 )) ; 
            __context__.SourceCodeLine = 470;
            IINPUT = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 471;
            ISYSSTATE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT1_FB_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 485;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_20__" , 20 , __SPLS_TMPVAR__WAITLABEL_20___Callback ) ;
        __context__.SourceCodeLine = 486;
        IINPUTFB = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_20___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 485;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object INPUT1_FB_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 491;
        IINPUTFB = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT2_FB_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 498;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_21__" , 20 , __SPLS_TMPVAR__WAITLABEL_21___Callback ) ;
        __context__.SourceCodeLine = 499;
        IINPUTFB = (ushort) ( 2 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_21___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 498;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object INPUT2_FB_OnRelease_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 505;
        IINPUTFB = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT3_FB_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 512;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_22__" , 20 , __SPLS_TMPVAR__WAITLABEL_22___Callback ) ;
        __context__.SourceCodeLine = 513;
        IINPUTFB = (ushort) ( 3 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_22___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 512;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object INPUT3_FB_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 518;
        IINPUTFB = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT4_FB_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 525;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_23__" , 20 , __SPLS_TMPVAR__WAITLABEL_23___Callback ) ;
        __context__.SourceCodeLine = 526;
        IINPUTFB = (ushort) ( 4 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_23___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 525;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object INPUT4_FB_OnRelease_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 531;
        IINPUTFB = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYNC_POWER_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 545;
        POWER_SYNC (  __context__  ) ; 
        __context__.SourceCodeLine = 546;
        Trace( "PowerState CheckSync {0:d}", (ushort)ISYSSTATE) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYNC_INPUT_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 554;
        INPUT_SYNC (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EXIT_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 564;
        Trace( "Exit Start PowerState CheckSync {0:d}", (ushort)ISYSSTATE) ; 
        __context__.SourceCodeLine = 566;
        IINPUT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 568;
        SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 569;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_24__" , 20 , __SPLS_TMPVAR__WAITLABEL_24___Callback ) ;
        __context__.SourceCodeLine = 570;
        SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 574;
        CHECKPOWER (  __context__ , (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 575;
        if ( Functions.TestForTrue  ( ( Functions.Not( IPOWERFB ))  ) ) 
            { 
            __context__.SourceCodeLine = 577;
            GO2SPLASH  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 578;
            GO2SPLASH  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 579;
            SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 580;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_25__" , 20 , __SPLS_TMPVAR__WAITLABEL_25___Callback ) ;
            __context__.SourceCodeLine = 581;
            SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 589;
        ISYSSTATE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 591;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_26__" , 20 , __SPLS_TMPVAR__WAITLABEL_26___Callback ) ;
        __context__.SourceCodeLine = 592;
        SCREENUP_PULSE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 594;
        SCREENUP_PULSE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 597;
        Trace( "Exit Ends PowerState CheckSync {0:d}", (ushort)ISYSSTATE) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_24___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 569;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public void __SPLS_TMPVAR__WAITLABEL_25___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 580;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public void __SPLS_TMPVAR__WAITLABEL_26___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 591;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 662;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_27__" , 500 , __SPLS_TMPVAR__WAITLABEL_27___Callback ) ;
        __context__.SourceCodeLine = 663;
        ISYSSTATE = (ushort) ( IPOWERFB ) ; 
        __context__.SourceCodeLine = 664;
        IINPUT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 665;
        COOLBUSY  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 665;
        if ( Functions.TestForTrue  ( ( Functions.Not( DISPLAY_BUSY ))  ) ) 
            {
            __context__.SourceCodeLine = 666;
            DISPLAY_BUSY = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 667;
        WARMBUSY  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    
public void __SPLS_TMPVAR__WAITLABEL_27___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 662;
            ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POWERONFB = new Crestron.Logos.SplusObjects.DigitalInput( POWERONFB__DigitalInput__, this );
    m_DigitalInputList.Add( POWERONFB__DigitalInput__, POWERONFB );
    
    POWEROFFFB = new Crestron.Logos.SplusObjects.DigitalInput( POWEROFFFB__DigitalInput__, this );
    m_DigitalInputList.Add( POWEROFFFB__DigitalInput__, POWEROFFFB );
    
    INPUT1_FB = new Crestron.Logos.SplusObjects.DigitalInput( INPUT1_FB__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT1_FB__DigitalInput__, INPUT1_FB );
    
    INPUT2_FB = new Crestron.Logos.SplusObjects.DigitalInput( INPUT2_FB__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT2_FB__DigitalInput__, INPUT2_FB );
    
    INPUT3_FB = new Crestron.Logos.SplusObjects.DigitalInput( INPUT3_FB__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT3_FB__DigitalInput__, INPUT3_FB );
    
    INPUT4_FB = new Crestron.Logos.SplusObjects.DigitalInput( INPUT4_FB__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT4_FB__DigitalInput__, INPUT4_FB );
    
    INPUT_1 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_1__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_1__DigitalInput__, INPUT_1 );
    
    INPUT_2 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_2__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_2__DigitalInput__, INPUT_2 );
    
    INPUT_3 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_3__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_3__DigitalInput__, INPUT_3 );
    
    INPUT_4 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_4__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_4__DigitalInput__, INPUT_4 );
    
    SCREENUP = new Crestron.Logos.SplusObjects.DigitalInput( SCREENUP__DigitalInput__, this );
    m_DigitalInputList.Add( SCREENUP__DigitalInput__, SCREENUP );
    
    SCREENDOWN = new Crestron.Logos.SplusObjects.DigitalInput( SCREENDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SCREENDOWN__DigitalInput__, SCREENDOWN );
    
    DISPLAYON = new Crestron.Logos.SplusObjects.DigitalInput( DISPLAYON__DigitalInput__, this );
    m_DigitalInputList.Add( DISPLAYON__DigitalInput__, DISPLAYON );
    
    DISPLAYOFF = new Crestron.Logos.SplusObjects.DigitalInput( DISPLAYOFF__DigitalInput__, this );
    m_DigitalInputList.Add( DISPLAYOFF__DigitalInput__, DISPLAYOFF );
    
    SYNC_POWER = new Crestron.Logos.SplusObjects.DigitalInput( SYNC_POWER__DigitalInput__, this );
    m_DigitalInputList.Add( SYNC_POWER__DigitalInput__, SYNC_POWER );
    
    SYNC_INPUT = new Crestron.Logos.SplusObjects.DigitalInput( SYNC_INPUT__DigitalInput__, this );
    m_DigitalInputList.Add( SYNC_INPUT__DigitalInput__, SYNC_INPUT );
    
    ENABLEFORCE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLEFORCE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLEFORCE__DigitalInput__, ENABLEFORCE );
    
    ENABLESCREEN = new Crestron.Logos.SplusObjects.DigitalInput( ENABLESCREEN__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLESCREEN__DigitalInput__, ENABLESCREEN );
    
    ENABLECOOLDOWN = new Crestron.Logos.SplusObjects.DigitalInput( ENABLECOOLDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLECOOLDOWN__DigitalInput__, ENABLECOOLDOWN );
    
    ENABLEWARMUP = new Crestron.Logos.SplusObjects.DigitalInput( ENABLEWARMUP__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLEWARMUP__DigitalInput__, ENABLEWARMUP );
    
    EXIT = new Crestron.Logos.SplusObjects.DigitalInput( EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( EXIT__DigitalInput__, EXIT );
    
    POWERON_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( POWERON_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERON_PULSE__DigitalOutput__, POWERON_PULSE );
    
    POWEROFF_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( POWEROFF_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWEROFF_PULSE__DigitalOutput__, POWEROFF_PULSE );
    
    INPUT1_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT1_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT1_PULSE__DigitalOutput__, INPUT1_PULSE );
    
    INPUT2_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT2_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT2_PULSE__DigitalOutput__, INPUT2_PULSE );
    
    INPUT3_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT3_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT3_PULSE__DigitalOutput__, INPUT3_PULSE );
    
    INPUT4_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT4_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT4_PULSE__DigitalOutput__, INPUT4_PULSE );
    
    SCREENUP_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( SCREENUP_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCREENUP_PULSE__DigitalOutput__, SCREENUP_PULSE );
    
    SCREENDOWN_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( SCREENDOWN_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCREENDOWN_PULSE__DigitalOutput__, SCREENDOWN_PULSE );
    
    COOLBUSY = new Crestron.Logos.SplusObjects.DigitalOutput( COOLBUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( COOLBUSY__DigitalOutput__, COOLBUSY );
    
    COOLDONE = new Crestron.Logos.SplusObjects.DigitalOutput( COOLDONE__DigitalOutput__, this );
    m_DigitalOutputList.Add( COOLDONE__DigitalOutput__, COOLDONE );
    
    WARMBUSY = new Crestron.Logos.SplusObjects.DigitalOutput( WARMBUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( WARMBUSY__DigitalOutput__, WARMBUSY );
    
    WARMDONE = new Crestron.Logos.SplusObjects.DigitalOutput( WARMDONE__DigitalOutput__, this );
    m_DigitalOutputList.Add( WARMDONE__DigitalOutput__, WARMDONE );
    
    GO2SPLASH = new Crestron.Logos.SplusObjects.DigitalOutput( GO2SPLASH__DigitalOutput__, this );
    m_DigitalOutputList.Add( GO2SPLASH__DigitalOutput__, GO2SPLASH );
    
    COOLBAR = new Crestron.Logos.SplusObjects.AnalogOutput( COOLBAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COOLBAR__AnalogSerialOutput__, COOLBAR );
    
    WARMBAR = new Crestron.Logos.SplusObjects.AnalogOutput( WARMBAR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WARMBAR__AnalogSerialOutput__, WARMBAR );
    
    COOLCOUNT = new Crestron.Logos.SplusObjects.StringOutput( COOLCOUNT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( COOLCOUNT__AnalogSerialOutput__, COOLCOUNT );
    
    WARMCOUNT = new Crestron.Logos.SplusObjects.StringOutput( WARMCOUNT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( WARMCOUNT__AnalogSerialOutput__, WARMCOUNT );
    
    WARMTIMER = new UShortParameter( WARMTIMER__Parameter__, this );
    m_ParameterList.Add( WARMTIMER__Parameter__, WARMTIMER );
    
    COOLTIMER = new UShortParameter( COOLTIMER__Parameter__, this );
    m_ParameterList.Add( COOLTIMER__Parameter__, COOLTIMER );
    
    __SPLS_TMPVAR__WAITLABEL_14___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_14___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_15___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_15___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_16___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_16___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_17___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_17___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_18___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_18___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_19___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_19___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_20___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_20___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_21___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_21___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_22___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_22___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_23___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_23___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_24___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_24___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_25___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_25___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_26___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_26___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_27___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_27___CallbackFn );
    
    POWERONFB.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERONFB_OnPush_0, false ) );
    POWEROFFFB.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWEROFFFB_OnPush_1, false ) );
    SCREENUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCREENUP_OnPush_2, false ) );
    SCREENDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCREENDOWN_OnPush_3, false ) );
    DISPLAYON.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISPLAYON_OnPush_4, false ) );
    DISPLAYOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISPLAYOFF_OnPush_5, false ) );
    INPUT_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_1_OnPush_6, false ) );
    INPUT_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_2_OnPush_7, false ) );
    INPUT_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_3_OnPush_8, false ) );
    INPUT_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_4_OnPush_9, false ) );
    INPUT1_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT1_FB_OnPush_10, false ) );
    INPUT1_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( INPUT1_FB_OnRelease_11, false ) );
    INPUT2_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT2_FB_OnPush_12, false ) );
    INPUT2_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( INPUT2_FB_OnRelease_13, false ) );
    INPUT3_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT3_FB_OnPush_14, false ) );
    INPUT3_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( INPUT3_FB_OnRelease_15, false ) );
    INPUT4_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT4_FB_OnPush_16, false ) );
    INPUT4_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( INPUT4_FB_OnRelease_17, false ) );
    SYNC_POWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYNC_POWER_OnPush_18, false ) );
    SYNC_INPUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYNC_INPUT_OnPush_19, false ) );
    EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXIT_OnPush_20, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SYSTEM_MANAGER_REV_2_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_14___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_15___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_16___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_17___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_18___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_19___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_20___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_21___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_22___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_23___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_24___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_25___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_26___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_27___Callback;


const uint POWERONFB__DigitalInput__ = 0;
const uint POWEROFFFB__DigitalInput__ = 1;
const uint INPUT1_FB__DigitalInput__ = 2;
const uint INPUT2_FB__DigitalInput__ = 3;
const uint INPUT3_FB__DigitalInput__ = 4;
const uint INPUT4_FB__DigitalInput__ = 5;
const uint INPUT_1__DigitalInput__ = 6;
const uint INPUT_2__DigitalInput__ = 7;
const uint INPUT_3__DigitalInput__ = 8;
const uint INPUT_4__DigitalInput__ = 9;
const uint SCREENUP__DigitalInput__ = 10;
const uint SCREENDOWN__DigitalInput__ = 11;
const uint DISPLAYON__DigitalInput__ = 12;
const uint DISPLAYOFF__DigitalInput__ = 13;
const uint SYNC_POWER__DigitalInput__ = 14;
const uint SYNC_INPUT__DigitalInput__ = 15;
const uint ENABLEFORCE__DigitalInput__ = 16;
const uint ENABLESCREEN__DigitalInput__ = 17;
const uint ENABLECOOLDOWN__DigitalInput__ = 18;
const uint ENABLEWARMUP__DigitalInput__ = 19;
const uint EXIT__DigitalInput__ = 20;
const uint POWERON_PULSE__DigitalOutput__ = 0;
const uint POWEROFF_PULSE__DigitalOutput__ = 1;
const uint INPUT1_PULSE__DigitalOutput__ = 2;
const uint INPUT2_PULSE__DigitalOutput__ = 3;
const uint INPUT3_PULSE__DigitalOutput__ = 4;
const uint INPUT4_PULSE__DigitalOutput__ = 5;
const uint SCREENUP_PULSE__DigitalOutput__ = 6;
const uint SCREENDOWN_PULSE__DigitalOutput__ = 7;
const uint COOLBUSY__DigitalOutput__ = 8;
const uint COOLDONE__DigitalOutput__ = 9;
const uint WARMBUSY__DigitalOutput__ = 10;
const uint WARMDONE__DigitalOutput__ = 11;
const uint GO2SPLASH__DigitalOutput__ = 12;
const uint COOLBAR__AnalogSerialOutput__ = 0;
const uint WARMBAR__AnalogSerialOutput__ = 1;
const uint COOLCOUNT__AnalogSerialOutput__ = 2;
const uint WARMCOUNT__AnalogSerialOutput__ = 3;
const uint WARMTIMER__Parameter__ = 10;
const uint COOLTIMER__Parameter__ = 11;

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
