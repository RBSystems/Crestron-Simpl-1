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

namespace UserModule_USESHUTTER_V0_1
{
    public class UserModuleClass_USESHUTTER_V0_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput CHECKTIME;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_SHUTTER;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_POWER;
        ushort NHOUR = 0;
        CrestronString THE_TIME;
        private void UPDATETIME (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 132;
            THE_TIME  .UpdateValue ( Functions.Time ( )  ) ; 
            __context__.SourceCodeLine = 133;
            NHOUR = (ushort) ( Functions.Atoi( THE_TIME ) ) ; 
            __context__.SourceCodeLine = 134;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( NHOUR > 7 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NHOUR < 19 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 136;
                ENABLE_SHUTTER  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 137;
                ENABLE_POWER  .Value = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 142;
                ENABLE_SHUTTER  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 143;
                ENABLE_POWER  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        object CHECKTIME_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 178;
                UPDATETIME (  __context__  ) ; 
                
                
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
            
            __context__.SourceCodeLine = 193;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 194;
            UPDATETIME (  __context__  ) ; 
            
            
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
        THE_TIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        CHECKTIME = new Crestron.Logos.SplusObjects.DigitalInput( CHECKTIME__DigitalInput__, this );
        m_DigitalInputList.Add( CHECKTIME__DigitalInput__, CHECKTIME );
        
        ENABLE_SHUTTER = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_SHUTTER__DigitalOutput__, this );
        m_DigitalOutputList.Add( ENABLE_SHUTTER__DigitalOutput__, ENABLE_SHUTTER );
        
        ENABLE_POWER = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_POWER__DigitalOutput__, this );
        m_DigitalOutputList.Add( ENABLE_POWER__DigitalOutput__, ENABLE_POWER );
        
        
        CHECKTIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHECKTIME_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_USESHUTTER_V0_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint CHECKTIME__DigitalInput__ = 0;
    const uint ENABLE_SHUTTER__DigitalOutput__ = 0;
    const uint ENABLE_POWER__DigitalOutput__ = 1;
    
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
