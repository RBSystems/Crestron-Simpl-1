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

namespace CrestronModule_KEYPROA
{
    public class CrestronModuleClass_KEYPROA : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARDGO;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput BACK;
        Crestron.Logos.SplusObjects.AnalogInput MAXCHARACTERS;
        Crestron.Logos.SplusObjects.AnalogInput KEYBOARDAN;
        Crestron.Logos.SplusObjects.StringInput TEXTIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TEXT__DOLLAR__;
        object KEYBOARDGO_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 42;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEXTIN__DOLLAR__ ) < MAXCHARACTERS  .UshortValue ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 44;
                    TEXT__DOLLAR__  .UpdateValue ( TEXTIN__DOLLAR__ + Functions.Chr (  (int) ( KEYBOARDAN  .UshortValue ) )  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CLEAR_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 50;
            TEXT__DOLLAR__  .UpdateValue ( ""  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object BACK_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 55;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEXTIN__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 57;
            TEXT__DOLLAR__  .UpdateValue ( Functions.Left ( TEXTIN__DOLLAR__ ,  (int) ( (Functions.Length( TEXTIN__DOLLAR__ ) - 1) ) )  ) ; 
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
        
        __context__.SourceCodeLine = 70;
        TEXT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    KEYBOARDGO = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARDGO__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARDGO__DigitalInput__, KEYBOARDGO );
    
    CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR__DigitalInput__, CLEAR );
    
    BACK = new Crestron.Logos.SplusObjects.DigitalInput( BACK__DigitalInput__, this );
    m_DigitalInputList.Add( BACK__DigitalInput__, BACK );
    
    MAXCHARACTERS = new Crestron.Logos.SplusObjects.AnalogInput( MAXCHARACTERS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAXCHARACTERS__AnalogSerialInput__, MAXCHARACTERS );
    
    KEYBOARDAN = new Crestron.Logos.SplusObjects.AnalogInput( KEYBOARDAN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( KEYBOARDAN__AnalogSerialInput__, KEYBOARDAN );
    
    TEXTIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXTIN__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( TEXTIN__DOLLAR____AnalogSerialInput__, TEXTIN__DOLLAR__ );
    
    TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEXT__DOLLAR____AnalogSerialOutput__, TEXT__DOLLAR__ );
    
    
    KEYBOARDGO.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARDGO_OnPush_0, false ) );
    CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_OnPush_1, false ) );
    BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACK_OnPush_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_KEYPROA ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KEYBOARDGO__DigitalInput__ = 0;
const uint CLEAR__DigitalInput__ = 1;
const uint BACK__DigitalInput__ = 2;
const uint MAXCHARACTERS__AnalogSerialInput__ = 0;
const uint KEYBOARDAN__AnalogSerialInput__ = 1;
const uint TEXTIN__DOLLAR____AnalogSerialInput__ = 2;
const uint TEXT__DOLLAR____AnalogSerialOutput__ = 0;

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
