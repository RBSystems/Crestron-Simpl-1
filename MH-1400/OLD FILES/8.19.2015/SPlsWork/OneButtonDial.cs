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

namespace UserModule_ONEBUTTONDIAL
{
    public class UserModuleClass_ONEBUTTONDIAL : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DIAL_ANSWER;
        Crestron.Logos.SplusObjects.StringInput DIAL_STRING;
        Crestron.Logos.SplusObjects.DigitalOutput DIAL;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_HOOK;
        object DIAL_ANSWER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 70;
                if ( Functions.TestForTrue  ( ( Functions.Length( DIAL_STRING ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 72;
                    DIAL  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 73;
                    DIAL  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 77;
                    OFF_HOOK  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 78;
                    OFF_HOOK  .Value = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        DIAL_ANSWER = new Crestron.Logos.SplusObjects.DigitalInput( DIAL_ANSWER__DigitalInput__, this );
        m_DigitalInputList.Add( DIAL_ANSWER__DigitalInput__, DIAL_ANSWER );
        
        DIAL = new Crestron.Logos.SplusObjects.DigitalOutput( DIAL__DigitalOutput__, this );
        m_DigitalOutputList.Add( DIAL__DigitalOutput__, DIAL );
        
        OFF_HOOK = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_HOOK__DigitalOutput__, this );
        m_DigitalOutputList.Add( OFF_HOOK__DigitalOutput__, OFF_HOOK );
        
        DIAL_STRING = new Crestron.Logos.SplusObjects.StringInput( DIAL_STRING__AnalogSerialInput__, 42, this );
        m_StringInputList.Add( DIAL_STRING__AnalogSerialInput__, DIAL_STRING );
        
        
        DIAL_ANSWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIAL_ANSWER_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_ONEBUTTONDIAL ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DIAL_ANSWER__DigitalInput__ = 0;
    const uint DIAL_STRING__AnalogSerialInput__ = 0;
    const uint DIAL__DigitalOutput__ = 0;
    const uint OFF_HOOK__DigitalOutput__ = 1;
    
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
