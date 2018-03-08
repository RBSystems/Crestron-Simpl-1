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

namespace CrestronModule_ALPHAPASS
{
    public class CrestronModuleClass_ALPHAPASS : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_BACKDOOR;
        Crestron.Logos.SplusObjects.DigitalInput SET_BACKDOOR;
        Crestron.Logos.SplusObjects.DigitalInput SET_MASTER_1;
        Crestron.Logos.SplusObjects.DigitalInput SET_MASTER_2;
        Crestron.Logos.SplusObjects.DigitalInput SET_MASTER_3;
        Crestron.Logos.SplusObjects.DigitalInput SET_MASTER_4;
        Crestron.Logos.SplusObjects.DigitalInput SET_MASTER_5;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput ENTER;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT1;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT2;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT3;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT4;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT5;
        Crestron.Logos.SplusObjects.DigitalInput SET_DEFAULT_BACKDOOR;
        Crestron.Logos.SplusObjects.StringInput PASSWORD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DEFAULT_BACKDOOR__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SET_BACKDOOR_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SET_MASTER_1_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SET_MASTER_2_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SET_MASTER_3_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SET_MASTER_4_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SET_MASTER_5_FB;
        Crestron.Logos.SplusObjects.AnalogOutput COMPARE_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MASTER_OUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput STARS__DOLLAR__;
        private ushort FCOMPAREPASSWORDS (  SplusExecutionContext __context__, CrestronString SCOMPARE ) 
            { 
            ushort A = 0;
            
            
            __context__.SourceCodeLine = 74;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)6; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 76;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (A == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 78;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ENABLE_BACKDOOR  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 80;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SMASTER__DOLLAR__[ A ] != "-"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 82;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCOMPARE == _SplusNVRAM.SMASTER__DOLLAR__[ 6 ]))  ) ) 
                                { 
                                __context__.SourceCodeLine = 84;
                                return (ushort)( 6) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 89;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SMASTER__DOLLAR__[ A ] != "-"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 91;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCOMPARE == _SplusNVRAM.SMASTER__DOLLAR__[ A ]))  ) ) 
                            { 
                            __context__.SourceCodeLine = 93;
                            return (ushort)( A) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 74;
                } 
            
            __context__.SourceCodeLine = 97;
            return (ushort)( 0) ; 
            
            }
            
        object ENTER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 107;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PASSWORD__DOLLAR__ ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( PASSWORD__DOLLAR__ ) <= 20 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 109;
                    _SplusNVRAM.STEMPPASSWORD  .UpdateValue ( PASSWORD__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 110;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IMASTER == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 112;
                        _SplusNVRAM.ICOMPARESTATUS = (ushort) ( FCOMPAREPASSWORDS( __context__ , _SplusNVRAM.STEMPPASSWORD ) ) ; 
                        __context__.SourceCodeLine = 113;
                        COMPARE_STATUS  .Value = (ushort) ( _SplusNVRAM.ICOMPARESTATUS ) ; 
                        __context__.SourceCodeLine = 114;
                        Functions.ProcessLogic ( ) ; 
                        __context__.SourceCodeLine = 115;
                        _SplusNVRAM.ICOMPARESTATUS = (ushort) ( 10 ) ; 
                        __context__.SourceCodeLine = 116;
                        COMPARE_STATUS  .Value = (ushort) ( _SplusNVRAM.ICOMPARESTATUS ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 120;
                        _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  .UpdateValue ( PASSWORD__DOLLAR__  ) ; 
                        __context__.SourceCodeLine = 121;
                        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 122;
                        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 123;
                        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 124;
                        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 125;
                        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 126;
                        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 127;
                        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 128;
                        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 131;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INITIALIZE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 137;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)6; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _SplusNVRAM.B  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.B  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.B  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.B  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.B  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.B  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 139;
                _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.B ]  .UpdateValue ( "-"  ) ; 
                __context__.SourceCodeLine = 137;
                } 
            
            __context__.SourceCodeLine = 141;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 142;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 143;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 144;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 145;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 146;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 147;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 148;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SET_DEFAULT1_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 1 ]  .UpdateValue ( _SplusNVRAM.SDEFAULT1__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 154;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 155;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 156;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 157;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 158;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 159;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 160;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 161;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_DEFAULT2_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 166;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 2 ]  .UpdateValue ( _SplusNVRAM.SDEFAULT2__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 167;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 168;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 169;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 170;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 171;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 172;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 173;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 174;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_DEFAULT3_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 179;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 3 ]  .UpdateValue ( _SplusNVRAM.SDEFAULT3__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 180;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 181;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 182;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 183;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 184;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 185;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 186;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 187;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_DEFAULT4_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 4 ]  .UpdateValue ( _SplusNVRAM.SDEFAULT4__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 193;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 194;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 195;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 196;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 197;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 198;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 199;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 200;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_DEFAULT5_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 5 ]  .UpdateValue ( _SplusNVRAM.SDEFAULT5__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 206;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 207;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 208;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 209;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 210;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 211;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 212;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 213;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_DEFAULT_BACKDOOR_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 218;
        _SplusNVRAM.SMASTER__DOLLAR__ [ 6 ]  .UpdateValue ( _SplusNVRAM.SDEFAULTBACKDOOR__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 219;
        SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 220;
        SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 221;
        SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 222;
        SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 223;
        SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 224;
        SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 225;
        _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 226;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT1__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 231;
        _SplusNVRAM.SDEFAULT1__DOLLAR__  .UpdateValue ( DEFAULT1__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT2__DOLLAR___OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 236;
        _SplusNVRAM.SDEFAULT2__DOLLAR__  .UpdateValue ( DEFAULT2__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT3__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 241;
        _SplusNVRAM.SDEFAULT3__DOLLAR__  .UpdateValue ( DEFAULT3__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT4__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 246;
        _SplusNVRAM.SDEFAULT4__DOLLAR__  .UpdateValue ( DEFAULT4__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT5__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 251;
        _SplusNVRAM.SDEFAULT5__DOLLAR__  .UpdateValue ( DEFAULT5__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT_BACKDOOR__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 256;
        _SplusNVRAM.SDEFAULTBACKDOOR__DOLLAR__  .UpdateValue ( DEFAULT_BACKDOOR__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_MASTER_1_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 271;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_MASTER_1_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 273;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 274;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 275;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 276;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 277;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 278;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 279;
            SET_MASTER_1_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 280;
            _SplusNVRAM.IMASTER = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 281;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 285;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 286;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 287;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 288;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 289;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 290;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 291;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 292;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_MASTER_2_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 298;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_MASTER_2_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 300;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 301;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 302;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 303;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 304;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 305;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 306;
            SET_MASTER_2_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 307;
            _SplusNVRAM.IMASTER = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 308;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 312;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 313;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 314;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 315;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 316;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 317;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 318;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 319;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_MASTER_3_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 325;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_MASTER_3_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 327;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 328;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 329;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 330;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 331;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 332;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 333;
            SET_MASTER_3_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 334;
            _SplusNVRAM.IMASTER = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 335;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 339;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 340;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 341;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 342;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 343;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 344;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 345;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 346;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_MASTER_4_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 352;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_MASTER_4_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 354;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 355;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 356;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 357;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 358;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 359;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 360;
            SET_MASTER_4_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 361;
            _SplusNVRAM.IMASTER = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 362;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 366;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 367;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 368;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 369;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 370;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 371;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 372;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 373;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_MASTER_5_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 379;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_MASTER_5_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 381;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 382;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 383;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 384;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 385;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 386;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 387;
            SET_MASTER_5_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 388;
            _SplusNVRAM.IMASTER = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 389;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 393;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 394;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 395;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 396;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 397;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 398;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 399;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 400;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_BACKDOOR_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 406;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SET_BACKDOOR_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 408;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 409;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 410;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 411;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 412;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 413;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 414;
            SET_BACKDOOR_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 415;
            _SplusNVRAM.IMASTER = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 416;
            MASTER_OUT__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMASTER__DOLLAR__ [ _SplusNVRAM.IMASTER ]  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 420;
            SET_BACKDOOR_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 421;
            SET_MASTER_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 422;
            SET_MASTER_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 423;
            SET_MASTER_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 424;
            SET_MASTER_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 425;
            SET_MASTER_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 426;
            _SplusNVRAM.IMASTER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 427;
            MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PASSWORD__DOLLAR___OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 433;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PASSWORD__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 435;
            _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 436;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( PASSWORD__DOLLAR__ ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _SplusNVRAM.B  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.B  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.B  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.B  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.B  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.B  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 438;
                _SplusNVRAM.STEMP  .UpdateValue ( _SplusNVRAM.STEMP + "*"  ) ; 
                __context__.SourceCodeLine = 436;
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 443;
            _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
            } 
        
        __context__.SourceCodeLine = 445;
        STARS__DOLLAR__  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 455;
        _SplusNVRAM.ICOMPARESTATUS = (ushort) ( 10 ) ; 
        __context__.SourceCodeLine = 456;
        COMPARE_STATUS  .Value = (ushort) ( _SplusNVRAM.ICOMPARESTATUS ) ; 
        __context__.SourceCodeLine = 457;
        _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 458;
        STARS__DOLLAR__  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
        __context__.SourceCodeLine = 459;
        MASTER_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.STEMPPASSWORD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULT1__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULT2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULT3__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULT4__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULT5__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SDEFAULTBACKDOOR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SMASTER__DOLLAR__  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        _SplusNVRAM.SMASTER__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    ENABLE_BACKDOOR = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_BACKDOOR__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_BACKDOOR__DigitalInput__, ENABLE_BACKDOOR );
    
    SET_BACKDOOR = new Crestron.Logos.SplusObjects.DigitalInput( SET_BACKDOOR__DigitalInput__, this );
    m_DigitalInputList.Add( SET_BACKDOOR__DigitalInput__, SET_BACKDOOR );
    
    SET_MASTER_1 = new Crestron.Logos.SplusObjects.DigitalInput( SET_MASTER_1__DigitalInput__, this );
    m_DigitalInputList.Add( SET_MASTER_1__DigitalInput__, SET_MASTER_1 );
    
    SET_MASTER_2 = new Crestron.Logos.SplusObjects.DigitalInput( SET_MASTER_2__DigitalInput__, this );
    m_DigitalInputList.Add( SET_MASTER_2__DigitalInput__, SET_MASTER_2 );
    
    SET_MASTER_3 = new Crestron.Logos.SplusObjects.DigitalInput( SET_MASTER_3__DigitalInput__, this );
    m_DigitalInputList.Add( SET_MASTER_3__DigitalInput__, SET_MASTER_3 );
    
    SET_MASTER_4 = new Crestron.Logos.SplusObjects.DigitalInput( SET_MASTER_4__DigitalInput__, this );
    m_DigitalInputList.Add( SET_MASTER_4__DigitalInput__, SET_MASTER_4 );
    
    SET_MASTER_5 = new Crestron.Logos.SplusObjects.DigitalInput( SET_MASTER_5__DigitalInput__, this );
    m_DigitalInputList.Add( SET_MASTER_5__DigitalInput__, SET_MASTER_5 );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalInput( ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER__DigitalInput__, ENTER );
    
    SET_DEFAULT1 = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT1__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT1__DigitalInput__, SET_DEFAULT1 );
    
    SET_DEFAULT2 = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT2__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT2__DigitalInput__, SET_DEFAULT2 );
    
    SET_DEFAULT3 = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT3__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT3__DigitalInput__, SET_DEFAULT3 );
    
    SET_DEFAULT4 = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT4__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT4__DigitalInput__, SET_DEFAULT4 );
    
    SET_DEFAULT5 = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT5__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT5__DigitalInput__, SET_DEFAULT5 );
    
    SET_DEFAULT_BACKDOOR = new Crestron.Logos.SplusObjects.DigitalInput( SET_DEFAULT_BACKDOOR__DigitalInput__, this );
    m_DigitalInputList.Add( SET_DEFAULT_BACKDOOR__DigitalInput__, SET_DEFAULT_BACKDOOR );
    
    SET_BACKDOOR_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_BACKDOOR_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_BACKDOOR_FB__DigitalOutput__, SET_BACKDOOR_FB );
    
    SET_MASTER_1_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_MASTER_1_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_MASTER_1_FB__DigitalOutput__, SET_MASTER_1_FB );
    
    SET_MASTER_2_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_MASTER_2_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_MASTER_2_FB__DigitalOutput__, SET_MASTER_2_FB );
    
    SET_MASTER_3_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_MASTER_3_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_MASTER_3_FB__DigitalOutput__, SET_MASTER_3_FB );
    
    SET_MASTER_4_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_MASTER_4_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_MASTER_4_FB__DigitalOutput__, SET_MASTER_4_FB );
    
    SET_MASTER_5_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SET_MASTER_5_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SET_MASTER_5_FB__DigitalOutput__, SET_MASTER_5_FB );
    
    COMPARE_STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( COMPARE_STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COMPARE_STATUS__AnalogSerialOutput__, COMPARE_STATUS );
    
    PASSWORD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PASSWORD__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( PASSWORD__DOLLAR____AnalogSerialInput__, PASSWORD__DOLLAR__ );
    
    DEFAULT1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT1__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT1__DOLLAR____AnalogSerialInput__, DEFAULT1__DOLLAR__ );
    
    DEFAULT2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT2__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT2__DOLLAR____AnalogSerialInput__, DEFAULT2__DOLLAR__ );
    
    DEFAULT3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT3__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT3__DOLLAR____AnalogSerialInput__, DEFAULT3__DOLLAR__ );
    
    DEFAULT4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT4__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT4__DOLLAR____AnalogSerialInput__, DEFAULT4__DOLLAR__ );
    
    DEFAULT5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT5__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT5__DOLLAR____AnalogSerialInput__, DEFAULT5__DOLLAR__ );
    
    DEFAULT_BACKDOOR__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEFAULT_BACKDOOR__DOLLAR____AnalogSerialInput__, 20, this );
    m_StringInputList.Add( DEFAULT_BACKDOOR__DOLLAR____AnalogSerialInput__, DEFAULT_BACKDOOR__DOLLAR__ );
    
    MASTER_OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MASTER_OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MASTER_OUT__DOLLAR____AnalogSerialOutput__, MASTER_OUT__DOLLAR__ );
    
    STARS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STARS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( STARS__DOLLAR____AnalogSerialOutput__, STARS__DOLLAR__ );
    
    
    ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_OnPush_0, false ) );
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_1, false ) );
    SET_DEFAULT1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT1_OnPush_2, false ) );
    SET_DEFAULT2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT2_OnPush_3, false ) );
    SET_DEFAULT3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT3_OnPush_4, false ) );
    SET_DEFAULT4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT4_OnPush_5, false ) );
    SET_DEFAULT5.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT5_OnPush_6, false ) );
    SET_DEFAULT_BACKDOOR.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_DEFAULT_BACKDOOR_OnPush_7, false ) );
    DEFAULT1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT1__DOLLAR___OnChange_8, false ) );
    DEFAULT2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT2__DOLLAR___OnChange_9, false ) );
    DEFAULT3__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT3__DOLLAR___OnChange_10, false ) );
    DEFAULT4__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT4__DOLLAR___OnChange_11, false ) );
    DEFAULT5__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT5__DOLLAR___OnChange_12, false ) );
    DEFAULT_BACKDOOR__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEFAULT_BACKDOOR__DOLLAR___OnChange_13, false ) );
    SET_MASTER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_MASTER_1_OnPush_14, false ) );
    SET_MASTER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_MASTER_2_OnPush_15, false ) );
    SET_MASTER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_MASTER_3_OnPush_16, false ) );
    SET_MASTER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_MASTER_4_OnPush_17, false ) );
    SET_MASTER_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_MASTER_5_OnPush_18, false ) );
    SET_BACKDOOR.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_BACKDOOR_OnPush_19, false ) );
    PASSWORD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( PASSWORD__DOLLAR___OnChange_20, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_ALPHAPASS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE_BACKDOOR__DigitalInput__ = 0;
const uint SET_BACKDOOR__DigitalInput__ = 1;
const uint SET_MASTER_1__DigitalInput__ = 2;
const uint SET_MASTER_2__DigitalInput__ = 3;
const uint SET_MASTER_3__DigitalInput__ = 4;
const uint SET_MASTER_4__DigitalInput__ = 5;
const uint SET_MASTER_5__DigitalInput__ = 6;
const uint INITIALIZE__DigitalInput__ = 7;
const uint ENTER__DigitalInput__ = 8;
const uint SET_DEFAULT1__DigitalInput__ = 9;
const uint SET_DEFAULT2__DigitalInput__ = 10;
const uint SET_DEFAULT3__DigitalInput__ = 11;
const uint SET_DEFAULT4__DigitalInput__ = 12;
const uint SET_DEFAULT5__DigitalInput__ = 13;
const uint SET_DEFAULT_BACKDOOR__DigitalInput__ = 14;
const uint PASSWORD__DOLLAR____AnalogSerialInput__ = 0;
const uint DEFAULT1__DOLLAR____AnalogSerialInput__ = 1;
const uint DEFAULT2__DOLLAR____AnalogSerialInput__ = 2;
const uint DEFAULT3__DOLLAR____AnalogSerialInput__ = 3;
const uint DEFAULT4__DOLLAR____AnalogSerialInput__ = 4;
const uint DEFAULT5__DOLLAR____AnalogSerialInput__ = 5;
const uint DEFAULT_BACKDOOR__DOLLAR____AnalogSerialInput__ = 6;
const uint SET_BACKDOOR_FB__DigitalOutput__ = 0;
const uint SET_MASTER_1_FB__DigitalOutput__ = 1;
const uint SET_MASTER_2_FB__DigitalOutput__ = 2;
const uint SET_MASTER_3_FB__DigitalOutput__ = 3;
const uint SET_MASTER_4_FB__DigitalOutput__ = 4;
const uint SET_MASTER_5_FB__DigitalOutput__ = 5;
const uint COMPARE_STATUS__AnalogSerialOutput__ = 0;
const uint MASTER_OUT__DOLLAR____AnalogSerialOutput__ = 1;
const uint STARS__DOLLAR____AnalogSerialOutput__ = 2;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort ICOMPARESTATUS = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort IMASTER = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort B = 0;
            [SplusStructAttribute(3, false, true)]
            public CrestronString [] SMASTER__DOLLAR__;
            [SplusStructAttribute(4, false, true)]
            public CrestronString STEMPPASSWORD;
            [SplusStructAttribute(5, false, true)]
            public CrestronString STEMP;
            [SplusStructAttribute(6, false, true)]
            public CrestronString SDEFAULT1__DOLLAR__;
            [SplusStructAttribute(7, false, true)]
            public CrestronString SDEFAULT2__DOLLAR__;
            [SplusStructAttribute(8, false, true)]
            public CrestronString SDEFAULT3__DOLLAR__;
            [SplusStructAttribute(9, false, true)]
            public CrestronString SDEFAULT4__DOLLAR__;
            [SplusStructAttribute(10, false, true)]
            public CrestronString SDEFAULT5__DOLLAR__;
            [SplusStructAttribute(11, false, true)]
            public CrestronString SDEFAULTBACKDOOR__DOLLAR__;
            
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
