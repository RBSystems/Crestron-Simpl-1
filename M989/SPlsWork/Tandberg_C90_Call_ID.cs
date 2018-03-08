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

namespace UserModule_TANDBERG_C90_CALL_ID
{
    public class UserModuleClass_TANDBERG_C90_CALL_ID : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.BufferInput DEVICE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput CALLID;
        ushort SEMAPHORE = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        private CrestronString GETSTRINGAFTERTOKEN (  SplusExecutionContext __context__, CrestronString TEXT , CrestronString TOKEN ) 
            { 
            ushort MARKER1 = 0;
            ushort MARKER2 = 0;
            
            CrestronString RETVAL;
            RETVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 20;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , TEXT ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                TEXT  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( 1 ) ,  (int) ( (Functions.Find( "\u000D\u000A" , TEXT ) - 1) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 24;
            MARKER1 = (ushort) ( (Functions.Find( TOKEN , TEXT ) + Functions.Length( TOKEN )) ) ; 
            __context__.SourceCodeLine = 25;
            MARKER2 = (ushort) ( (Functions.Length( TEXT ) - (MARKER1 - 1)) ) ; 
            __context__.SourceCodeLine = 26;
            RETVAL  .UpdateValue ( Functions.Mid ( TEXT ,  (int) ( MARKER1 ) ,  (int) ( MARKER2 ) )  ) ; 
            __context__.SourceCodeLine = 27;
            return ( RETVAL ) ; 
            
            }
            
        object DEVICE_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 40;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 42;
                    SEMAPHORE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 44;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , DEVICE_RX__DOLLAR__ ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 46;
                        TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , DEVICE_RX__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 47;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "*s Call " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 49;
                            TEMPSTRING__DOLLAR__  .UpdateValue ( GETSTRINGAFTERTOKEN (  __context__ , TEMPSTRING__DOLLAR__, "*s Call ")  ) ; 
                            __context__.SourceCodeLine = 51;
                            CALLID  .Value = (ushort) ( Functions.Atoi( Functions.Remove( " " , TEMPSTRING__DOLLAR__ ) ) ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 44;
                        } 
                    
                    __context__.SourceCodeLine = 54;
                    SEMAPHORE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 55;
                    Functions.ClearBuffer ( DEVICE_RX__DOLLAR__ ) ; 
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
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
        
        CALLID = new Crestron.Logos.SplusObjects.AnalogOutput( CALLID__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CALLID__AnalogSerialOutput__, CALLID );
        
        DEVICE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DEVICE_RX__DOLLAR____AnalogSerialInput__, 1000, this );
        m_StringInputList.Add( DEVICE_RX__DOLLAR____AnalogSerialInput__, DEVICE_RX__DOLLAR__ );
        
        
        DEVICE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEVICE_RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_TANDBERG_C90_CALL_ID ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DEVICE_RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint CALLID__AnalogSerialOutput__ = 0;
    
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
