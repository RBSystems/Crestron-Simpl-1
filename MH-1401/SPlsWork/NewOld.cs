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

namespace CrestronModule_NEWOLD
{
    public class CrestronModuleClass_NEWOLD : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RETRIGGER;
        Crestron.Logos.SplusObjects.BufferInput CONSOLE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput NEWPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput EXISTINGPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput DIFFERENTPROGRAM;
        Crestron.Logos.SplusObjects.DigitalOutput DIFFERENTCOMPILEDONDATE;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_TX__DOLLAR__;
        CrestronString TEMPSOURCEFILE;
        CrestronString TEMPCOMPILEDON;
        ushort DONEFLAG = 0;
        private void GETINFO (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 29;
            NEWPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 30;
            EXISTINGPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 31;
            DIFFERENTPROGRAM  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 32;
            DIFFERENTCOMPILEDONDATE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 34;
            DONEFLAG = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 36;
            Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 37;
            Functions.ClearBuffer ( TEMPSOURCEFILE ) ; 
            __context__.SourceCodeLine = 38;
            Functions.ClearBuffer ( TEMPCOMPILEDON ) ; 
            __context__.SourceCodeLine = 39;
            __context__.SourceCodeLine = 42;
            MakeString ( CONSOLE_TX__DOLLAR__ , "PROGCOMMENTS:{0:d}\r\n", (short)GetProgramNumber()) ; 
            
            
            }
            
        object CONSOLE_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort POS1 = 0;
                ushort POS2 = 0;
                
                
                __context__.SourceCodeLine = 50;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMPSOURCEFILE ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 52;
                    POS1 = (ushort) ( Functions.Find( "\u000D\u000ASource File:  " , CONSOLE_RX__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 53;
                    POS2 = (ushort) ( Functions.Find( "\u000D" , CONSOLE_RX__DOLLAR__ , (POS1 + 1) ) ) ; 
                    __context__.SourceCodeLine = 54;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( POS1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( POS2 > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 56;
                        TEMPSOURCEFILE  .UpdateValue ( Functions.Mid ( CONSOLE_RX__DOLLAR__ ,  (int) ( (POS1 + 16) ) ,  (int) ( (POS2 - (POS1 + 16)) ) )  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( TEMPCOMPILEDON ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    POS1 = (ushort) ( Functions.Find( "\u000D\u000ACompiled On:  " , CONSOLE_RX__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 63;
                    POS2 = (ushort) ( Functions.Find( "\u000D" , CONSOLE_RX__DOLLAR__ , (POS1 + 1) ) ) ; 
                    __context__.SourceCodeLine = 64;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( POS1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( POS2 > 0 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 66;
                        TEMPCOMPILEDON  .UpdateValue ( Functions.Mid ( CONSOLE_RX__DOLLAR__ ,  (int) ( (POS1 + 16) ) ,  (int) ( (POS2 - (POS1 + 16)) ) )  ) ; 
                        __context__.SourceCodeLine = 69;
                        DONEFLAG = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 73;
                if ( Functions.TestForTrue  ( ( DONEFLAG)  ) ) 
                    { 
                    __context__.SourceCodeLine = 75;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSOURCEFILE != _SplusNVRAM.SOURCEFILE))  ) ) 
                        { 
                        __context__.SourceCodeLine = 77;
                        _SplusNVRAM.SOURCEFILE  .UpdateValue ( TEMPSOURCEFILE  ) ; 
                        __context__.SourceCodeLine = 77;
                        DIFFERENTPROGRAM  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPCOMPILEDON != _SplusNVRAM.COMPILEDON))  ) ) 
                        { 
                        __context__.SourceCodeLine = 82;
                        _SplusNVRAM.COMPILEDON  .UpdateValue ( TEMPCOMPILEDON  ) ; 
                        __context__.SourceCodeLine = 83;
                        DIFFERENTCOMPILEDONDATE  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 86;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DIFFERENTPROGRAM  .Value ) || Functions.TestForTrue ( DIFFERENTCOMPILEDONDATE  .Value )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 88;
                        NEWPROGRAM  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 92;
                        EXISTINGPROGRAM  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 98;
                    DONEFLAG = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object RETRIGGER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 104;
            GETINFO (  __context__  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 109;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 110;
        GETINFO (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.SOURCEFILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _SplusNVRAM.COMPILEDON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    TEMPSOURCEFILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    TEMPCOMPILEDON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    
    RETRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( RETRIGGER__DigitalInput__, this );
    m_DigitalInputList.Add( RETRIGGER__DigitalInput__, RETRIGGER );
    
    NEWPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( NEWPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEWPROGRAM__DigitalOutput__, NEWPROGRAM );
    
    EXISTINGPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( EXISTINGPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( EXISTINGPROGRAM__DigitalOutput__, EXISTINGPROGRAM );
    
    DIFFERENTPROGRAM = new Crestron.Logos.SplusObjects.DigitalOutput( DIFFERENTPROGRAM__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIFFERENTPROGRAM__DigitalOutput__, DIFFERENTPROGRAM );
    
    DIFFERENTCOMPILEDONDATE = new Crestron.Logos.SplusObjects.DigitalOutput( DIFFERENTCOMPILEDONDATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIFFERENTCOMPILEDONDATE__DigitalOutput__, DIFFERENTCOMPILEDONDATE );
    
    CONSOLE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, CONSOLE_TX__DOLLAR__ );
    
    CONSOLE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CONSOLE_RX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( CONSOLE_RX__DOLLAR____AnalogSerialInput__, CONSOLE_RX__DOLLAR__ );
    
    
    CONSOLE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_RX__DOLLAR___OnChange_0, false ) );
    RETRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( RETRIGGER_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_NEWOLD ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RETRIGGER__DigitalInput__ = 0;
const uint CONSOLE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint NEWPROGRAM__DigitalOutput__ = 0;
const uint EXISTINGPROGRAM__DigitalOutput__ = 1;
const uint DIFFERENTPROGRAM__DigitalOutput__ = 2;
const uint DIFFERENTCOMPILEDONDATE__DigitalOutput__ = 3;
const uint CONSOLE_TX__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public CrestronString SOURCEFILE;
            [SplusStructAttribute(1, false, true)]
            public CrestronString COMPILEDON;
            
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
