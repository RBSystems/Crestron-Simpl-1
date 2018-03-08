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

namespace UserModule_R25_XML_FORMATTED_TIME
{
    public class UserModuleClass_R25_XML_FORMATTED_TIME : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.StringInput SERIALIZED_TIME;
        Crestron.Logos.SplusObjects.StringOutput XML_FORMATTED_TIME;
        object SERIALIZED_TIME_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 179;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SERIALIZED_TIME ) == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 181;
                    XML_FORMATTED_TIME  .UpdateValue ( "0" + SERIALIZED_TIME  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 183;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SERIALIZED_TIME ) == 8))  ) ) 
                        { 
                        __context__.SourceCodeLine = 185;
                        XML_FORMATTED_TIME  .UpdateValue ( SERIALIZED_TIME  ) ; 
                        } 
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SERIALIZED_TIME = new Crestron.Logos.SplusObjects.StringInput( SERIALIZED_TIME__AnalogSerialInput__, 8, this );
        m_StringInputList.Add( SERIALIZED_TIME__AnalogSerialInput__, SERIALIZED_TIME );
        
        XML_FORMATTED_TIME = new Crestron.Logos.SplusObjects.StringOutput( XML_FORMATTED_TIME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( XML_FORMATTED_TIME__AnalogSerialOutput__, XML_FORMATTED_TIME );
        
        
        SERIALIZED_TIME.OnSerialChange.Add( new InputChangeHandlerWrapper( SERIALIZED_TIME_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_R25_XML_FORMATTED_TIME ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SERIALIZED_TIME__AnalogSerialInput__ = 0;
    const uint XML_FORMATTED_TIME__AnalogSerialOutput__ = 0;
    
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
