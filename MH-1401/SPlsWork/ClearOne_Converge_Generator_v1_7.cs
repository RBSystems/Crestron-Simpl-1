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

namespace UserModule_CLEARONE_CONVERGE_GENERATOR_V1_7
{
    public class UserModuleClass_CLEARONE_CONVERGE_GENERATOR_V1_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput VOLUMEMXB;
        Crestron.Logos.SplusObjects.AnalogInput VOLUMEMXB2;
        Crestron.Logos.SplusObjects.AnalogInput AMBLVLMXB;
        Crestron.Logos.SplusObjects.AnalogInput AMBLVLMXB2;
        Crestron.Logos.SplusObjects.AnalogInput NOISEMXB;
        Crestron.Logos.SplusObjects.AnalogInput NOISEMXB2;
        Crestron.Logos.SplusObjects.StringInput STARTOFCOMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput STARTOFCOMMAND2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput STARTOFCOMMAND3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VOLUMETEXT;
        Crestron.Logos.SplusObjects.StringOutput AMBLVLTEXT;
        Crestron.Logos.SplusObjects.StringOutput NOISETEXT;
        object STARTOFCOMMAND__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 69;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:d} A\r", STARTOFCOMMAND__DOLLAR__ , (short)VOLUMEMXB  .UshortValue) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUMEMXB2_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 74;
            MakeString ( VOLUMETEXT , "{0:d}db", (short)VOLUMEMXB2  .UshortValue) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STARTOFCOMMAND2__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 79;
        MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:d}\r", STARTOFCOMMAND2__DOLLAR__ , (short)AMBLVLMXB  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AMBLVLMXB2_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        MakeString ( AMBLVLTEXT , "{0:d}db", (short)AMBLVLMXB2  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STARTOFCOMMAND3__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 89;
        MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:d}\r", STARTOFCOMMAND3__DOLLAR__ , (short)NOISEMXB  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NOISEMXB2_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 94;
        MakeString ( NOISETEXT , "{0:d}db", (short)NOISEMXB2  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    VOLUMEMXB = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMEMXB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMEMXB__AnalogSerialInput__, VOLUMEMXB );
    
    VOLUMEMXB2 = new Crestron.Logos.SplusObjects.AnalogInput( VOLUMEMXB2__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUMEMXB2__AnalogSerialInput__, VOLUMEMXB2 );
    
    AMBLVLMXB = new Crestron.Logos.SplusObjects.AnalogInput( AMBLVLMXB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AMBLVLMXB__AnalogSerialInput__, AMBLVLMXB );
    
    AMBLVLMXB2 = new Crestron.Logos.SplusObjects.AnalogInput( AMBLVLMXB2__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AMBLVLMXB2__AnalogSerialInput__, AMBLVLMXB2 );
    
    NOISEMXB = new Crestron.Logos.SplusObjects.AnalogInput( NOISEMXB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NOISEMXB__AnalogSerialInput__, NOISEMXB );
    
    NOISEMXB2 = new Crestron.Logos.SplusObjects.AnalogInput( NOISEMXB2__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NOISEMXB2__AnalogSerialInput__, NOISEMXB2 );
    
    STARTOFCOMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STARTOFCOMMAND__DOLLAR____AnalogSerialInput__, 24, this );
    m_StringInputList.Add( STARTOFCOMMAND__DOLLAR____AnalogSerialInput__, STARTOFCOMMAND__DOLLAR__ );
    
    STARTOFCOMMAND2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STARTOFCOMMAND2__DOLLAR____AnalogSerialInput__, 16, this );
    m_StringInputList.Add( STARTOFCOMMAND2__DOLLAR____AnalogSerialInput__, STARTOFCOMMAND2__DOLLAR__ );
    
    STARTOFCOMMAND3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STARTOFCOMMAND3__DOLLAR____AnalogSerialInput__, 16, this );
    m_StringInputList.Add( STARTOFCOMMAND3__DOLLAR____AnalogSerialInput__, STARTOFCOMMAND3__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    VOLUMETEXT = new Crestron.Logos.SplusObjects.StringOutput( VOLUMETEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( VOLUMETEXT__AnalogSerialOutput__, VOLUMETEXT );
    
    AMBLVLTEXT = new Crestron.Logos.SplusObjects.StringOutput( AMBLVLTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AMBLVLTEXT__AnalogSerialOutput__, AMBLVLTEXT );
    
    NOISETEXT = new Crestron.Logos.SplusObjects.StringOutput( NOISETEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOISETEXT__AnalogSerialOutput__, NOISETEXT );
    
    
    STARTOFCOMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( STARTOFCOMMAND__DOLLAR___OnChange_0, false ) );
    VOLUMEMXB2.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUMEMXB2_OnChange_1, false ) );
    STARTOFCOMMAND2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( STARTOFCOMMAND2__DOLLAR___OnChange_2, false ) );
    AMBLVLMXB2.OnAnalogChange.Add( new InputChangeHandlerWrapper( AMBLVLMXB2_OnChange_3, false ) );
    STARTOFCOMMAND3__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( STARTOFCOMMAND3__DOLLAR___OnChange_4, false ) );
    NOISEMXB2.OnAnalogChange.Add( new InputChangeHandlerWrapper( NOISEMXB2_OnChange_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CLEARONE_CONVERGE_GENERATOR_V1_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUMEMXB__AnalogSerialInput__ = 0;
const uint VOLUMEMXB2__AnalogSerialInput__ = 1;
const uint AMBLVLMXB__AnalogSerialInput__ = 2;
const uint AMBLVLMXB2__AnalogSerialInput__ = 3;
const uint NOISEMXB__AnalogSerialInput__ = 4;
const uint NOISEMXB2__AnalogSerialInput__ = 5;
const uint STARTOFCOMMAND__DOLLAR____AnalogSerialInput__ = 6;
const uint STARTOFCOMMAND2__DOLLAR____AnalogSerialInput__ = 7;
const uint STARTOFCOMMAND3__DOLLAR____AnalogSerialInput__ = 8;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 0;
const uint VOLUMETEXT__AnalogSerialOutput__ = 1;
const uint AMBLVLTEXT__AnalogSerialOutput__ = 2;
const uint NOISETEXT__AnalogSerialOutput__ = 3;

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
