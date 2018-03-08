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

namespace UserModule_TANDBERG_C90_REMOTE_PRESENTATION_TO_OUTPUT_FULLSCREEN
{
    public class UserModuleClass_TANDBERG_C90_REMOTE_PRESENTATION_TO_OUTPUT_FULLSCREEN : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput CALLID;
        Crestron.Logos.SplusObjects.DigitalInput REMOTEPRESENTATION_TO_OUT1;
        Crestron.Logos.SplusObjects.DigitalInput REMOTEPRESENTATION_TO_OUT2;
        Crestron.Logos.SplusObjects.DigitalInput REMOTEPRESENTATION_TO_OUT3;
        Crestron.Logos.SplusObjects.DigitalInput REMOTEPRESENTATION_TO_OUT4;
        Crestron.Logos.SplusObjects.DigitalInput REMOTEPRESENTATION_TO_OUT5;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_MOVE_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_MOVE_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_TILT_UP;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_TILT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_ZOOM_IN;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_ZOOM_OUT;
        Crestron.Logos.SplusObjects.DigitalInput FAR_END_CAMERA_STOP;
        Crestron.Logos.SplusObjects.StringOutput R_PRESENTATION_OUT__DOLLAR__;
        object REMOTEPRESENTATION_TO_OUT1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 31;
                MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand Video Layout Frame Update LayoutId: 1 FrameId: 1 PositionX: 0 PositionY: 0 Width: 10000 Height: 10000 Layer: 5 Border: Off VideoSourceType: remotePresentation VideoSourceId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object REMOTEPRESENTATION_TO_OUT2_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 38;
            MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand Video Layout Frame Update LayoutId: 2 FrameId: 1 PositionX: 0 PositionY: 0 Width: 10000 Height: 10000 Layer: 5 Border: Off VideoSourceType: remotePresentation VideoSourceId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object REMOTEPRESENTATION_TO_OUT3_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 45;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand Video Layout Frame Update LayoutId: 3 FrameId: 1 PositionX: 0 PositionY: 0 Width: 10000 Height: 10000 Layer: 5 Border: Off VideoSourceType: remotePresentation VideoSourceId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REMOTEPRESENTATION_TO_OUT4_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 52;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand Video Layout Frame Update LayoutId: 4 FrameId: 1 PositionX: 0 PositionY: 0 Width: 10000 Height: 10000 Layer: 5 Border: Off VideoSourceType: remotePresentation VideoSourceId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REMOTEPRESENTATION_TO_OUT5_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 59;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand Video Layout Frame Update LayoutId: 5 FrameId: 1 PositionX: 0 PositionY: 0 Width: 10000 Height: 10000 Layer: 5 Border: Off VideoSourceType: remotePresentation VideoSourceId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_MOVE_LEFT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 72;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move CallId: {0:d} Value: Left\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_MOVE_RIGHT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 78;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move CallId: {0:d} Value: Right\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_STOP_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Stop CallId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_TILT_UP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 91;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move Value: Up CallId: {0:d}\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_TILT_DOWN_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 98;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move CallId: {0:d} Value: Down\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_ZOOM_IN_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move CallId: {0:d} Value: ZoomIn\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAR_END_CAMERA_ZOOM_OUT_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 112;
        MakeString ( R_PRESENTATION_OUT__DOLLAR__ , "xCommand FarEndControl Camera Move CallId: {0:d} Value: ZoomOut\r\n", (ushort)CALLID  .UshortValue) ; 
        
        
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
    
    REMOTEPRESENTATION_TO_OUT1 = new Crestron.Logos.SplusObjects.DigitalInput( REMOTEPRESENTATION_TO_OUT1__DigitalInput__, this );
    m_DigitalInputList.Add( REMOTEPRESENTATION_TO_OUT1__DigitalInput__, REMOTEPRESENTATION_TO_OUT1 );
    
    REMOTEPRESENTATION_TO_OUT2 = new Crestron.Logos.SplusObjects.DigitalInput( REMOTEPRESENTATION_TO_OUT2__DigitalInput__, this );
    m_DigitalInputList.Add( REMOTEPRESENTATION_TO_OUT2__DigitalInput__, REMOTEPRESENTATION_TO_OUT2 );
    
    REMOTEPRESENTATION_TO_OUT3 = new Crestron.Logos.SplusObjects.DigitalInput( REMOTEPRESENTATION_TO_OUT3__DigitalInput__, this );
    m_DigitalInputList.Add( REMOTEPRESENTATION_TO_OUT3__DigitalInput__, REMOTEPRESENTATION_TO_OUT3 );
    
    REMOTEPRESENTATION_TO_OUT4 = new Crestron.Logos.SplusObjects.DigitalInput( REMOTEPRESENTATION_TO_OUT4__DigitalInput__, this );
    m_DigitalInputList.Add( REMOTEPRESENTATION_TO_OUT4__DigitalInput__, REMOTEPRESENTATION_TO_OUT4 );
    
    REMOTEPRESENTATION_TO_OUT5 = new Crestron.Logos.SplusObjects.DigitalInput( REMOTEPRESENTATION_TO_OUT5__DigitalInput__, this );
    m_DigitalInputList.Add( REMOTEPRESENTATION_TO_OUT5__DigitalInput__, REMOTEPRESENTATION_TO_OUT5 );
    
    FAR_END_CAMERA_MOVE_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_MOVE_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_MOVE_LEFT__DigitalInput__, FAR_END_CAMERA_MOVE_LEFT );
    
    FAR_END_CAMERA_MOVE_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_MOVE_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_MOVE_RIGHT__DigitalInput__, FAR_END_CAMERA_MOVE_RIGHT );
    
    FAR_END_CAMERA_TILT_UP = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_TILT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_TILT_UP__DigitalInput__, FAR_END_CAMERA_TILT_UP );
    
    FAR_END_CAMERA_TILT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_TILT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_TILT_DOWN__DigitalInput__, FAR_END_CAMERA_TILT_DOWN );
    
    FAR_END_CAMERA_ZOOM_IN = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_ZOOM_IN__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_ZOOM_IN__DigitalInput__, FAR_END_CAMERA_ZOOM_IN );
    
    FAR_END_CAMERA_ZOOM_OUT = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_ZOOM_OUT__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_ZOOM_OUT__DigitalInput__, FAR_END_CAMERA_ZOOM_OUT );
    
    FAR_END_CAMERA_STOP = new Crestron.Logos.SplusObjects.DigitalInput( FAR_END_CAMERA_STOP__DigitalInput__, this );
    m_DigitalInputList.Add( FAR_END_CAMERA_STOP__DigitalInput__, FAR_END_CAMERA_STOP );
    
    CALLID = new Crestron.Logos.SplusObjects.AnalogInput( CALLID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CALLID__AnalogSerialInput__, CALLID );
    
    R_PRESENTATION_OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( R_PRESENTATION_OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( R_PRESENTATION_OUT__DOLLAR____AnalogSerialOutput__, R_PRESENTATION_OUT__DOLLAR__ );
    
    
    REMOTEPRESENTATION_TO_OUT1.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOTEPRESENTATION_TO_OUT1_OnPush_0, false ) );
    REMOTEPRESENTATION_TO_OUT2.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOTEPRESENTATION_TO_OUT2_OnPush_1, false ) );
    REMOTEPRESENTATION_TO_OUT3.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOTEPRESENTATION_TO_OUT3_OnPush_2, false ) );
    REMOTEPRESENTATION_TO_OUT4.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOTEPRESENTATION_TO_OUT4_OnPush_3, false ) );
    REMOTEPRESENTATION_TO_OUT5.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOTEPRESENTATION_TO_OUT5_OnPush_4, false ) );
    FAR_END_CAMERA_MOVE_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_MOVE_LEFT_OnPush_5, false ) );
    FAR_END_CAMERA_MOVE_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_MOVE_RIGHT_OnPush_6, false ) );
    FAR_END_CAMERA_STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_STOP_OnPush_7, false ) );
    FAR_END_CAMERA_TILT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_TILT_UP_OnPush_8, false ) );
    FAR_END_CAMERA_TILT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_TILT_DOWN_OnPush_9, false ) );
    FAR_END_CAMERA_ZOOM_IN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_ZOOM_IN_OnPush_10, false ) );
    FAR_END_CAMERA_ZOOM_OUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( FAR_END_CAMERA_ZOOM_OUT_OnPush_11, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TANDBERG_C90_REMOTE_PRESENTATION_TO_OUTPUT_FULLSCREEN ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CALLID__AnalogSerialInput__ = 0;
const uint REMOTEPRESENTATION_TO_OUT1__DigitalInput__ = 0;
const uint REMOTEPRESENTATION_TO_OUT2__DigitalInput__ = 1;
const uint REMOTEPRESENTATION_TO_OUT3__DigitalInput__ = 2;
const uint REMOTEPRESENTATION_TO_OUT4__DigitalInput__ = 3;
const uint REMOTEPRESENTATION_TO_OUT5__DigitalInput__ = 4;
const uint FAR_END_CAMERA_MOVE_LEFT__DigitalInput__ = 5;
const uint FAR_END_CAMERA_MOVE_RIGHT__DigitalInput__ = 6;
const uint FAR_END_CAMERA_TILT_UP__DigitalInput__ = 7;
const uint FAR_END_CAMERA_TILT_DOWN__DigitalInput__ = 8;
const uint FAR_END_CAMERA_ZOOM_IN__DigitalInput__ = 9;
const uint FAR_END_CAMERA_ZOOM_OUT__DigitalInput__ = 10;
const uint FAR_END_CAMERA_STOP__DigitalInput__ = 11;
const uint R_PRESENTATION_OUT__DOLLAR____AnalogSerialOutput__ = 0;

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
