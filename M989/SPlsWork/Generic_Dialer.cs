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

namespace UserModule_GENERIC_DIALER
{
    public class UserModuleClass_GENERIC_DIALER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SELECT_NUM_1;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_NUM_2;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_NONE;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_NUM_1_NUM_2;
        Crestron.Logos.SplusObjects.DigitalInput COPY_NUM_1_TO_NUM_2;
        Crestron.Logos.SplusObjects.DigitalInput DIAL;
        Crestron.Logos.SplusObjects.AnalogInput MAX_PHONE_NUMBER_CHARACTERS;
        Crestron.Logos.SplusObjects.StringInput HEADER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NUMBER_SEPARATER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput FOOTER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NUM_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NUM_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DIRECTORY_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NUM_1_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NUM_2_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TEXT_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IMAXCHARS = 0;
        ushort IFLAG2 = 0;
        ushort IINCOMINGTEXT = 0;
        CrestronString SNUM1;
        CrestronString SNUM2;
        CrestronString SHEADER;
        CrestronString SFOOTER;
        CrestronString SSEPARATER;
        CrestronString SDIRECTORYNAME;
        object SELECT_NUM_1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 75;
                TEXT_FB__DOLLAR__  .UpdateValue ( SNUM1  ) ; 
                __context__.SourceCodeLine = 76;
                IINCOMINGTEXT = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SELECT_NUM_2_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 81;
            TEXT_FB__DOLLAR__  .UpdateValue ( SNUM2  ) ; 
            __context__.SourceCodeLine = 82;
            IINCOMINGTEXT = (ushort) ( 2 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SELECT_DIRECTORY_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        TEXT_FB__DOLLAR__  .UpdateValue ( SDIRECTORYNAME  ) ; 
        __context__.SourceCodeLine = 88;
        IINCOMINGTEXT = (ushort) ( 3 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_NONE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 93;
        IINCOMINGTEXT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COPY_NUM_1_TO_NUM_2_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 98;
        SNUM2  .UpdateValue ( SNUM1  ) ; 
        __context__.SourceCodeLine = 99;
        NUM_2_FB__DOLLAR__  .UpdateValue ( SNUM2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_NUM_1_NUM_2_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        SNUM1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 105;
        SNUM2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 106;
        NUM_1_FB__DOLLAR__  .UpdateValue ( SNUM1  ) ; 
        __context__.SourceCodeLine = 107;
        NUM_2_FB__DOLLAR__  .UpdateValue ( SNUM2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIAL_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 112;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SNUM2 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 114;
            MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}{2}{3}{4}", SHEADER , SNUM1 , SSEPARATER , SNUM2 , SFOOTER ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 116;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNUM2 ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 118;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}{2}", SHEADER , SNUM1 , SFOOTER ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MAX_PHONE_NUMBER_CHARACTERS_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 124;
        IMAXCHARS = (ushort) ( MAX_PHONE_NUMBER_CHARACTERS  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HEADER__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        SHEADER  .UpdateValue ( HEADER__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOOTER__DOLLAR___OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 134;
        SFOOTER  .UpdateValue ( FOOTER__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUMBER_SEPARATER__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        SSEPARATER  .UpdateValue ( NUMBER_SEPARATER__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUM_1__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 144;
        SNUM1  .UpdateValue ( NUM_1__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUM_2__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        SNUM2  .UpdateValue ( NUM_2__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTORY_NAME__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 156;
        SDIRECTORYNAME  .UpdateValue ( DIRECTORY_NAME__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TEXT__DOLLAR___OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG2 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 164;
            IFLAG2 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 165;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINCOMINGTEXT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 167;
                SNUM1  .UpdateValue ( TEXT__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 168;
                NUM_1_FB__DOLLAR__  .UpdateValue ( SNUM1  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 170;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINCOMINGTEXT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 172;
                    SNUM2  .UpdateValue ( TEXT__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 173;
                    NUM_2_FB__DOLLAR__  .UpdateValue ( SNUM2  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 175;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINCOMINGTEXT == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 177;
                        SDIRECTORYNAME  .UpdateValue ( TEXT__DOLLAR__  ) ; 
                        __context__.SourceCodeLine = 178;
                        DIRECTORY_NAME_FB__DOLLAR__  .UpdateValue ( SDIRECTORYNAME  ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 180;
            IFLAG2 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 191;
        IFLAG2 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 192;
        Functions.ClearBuffer ( SHEADER ) ; 
        __context__.SourceCodeLine = 193;
        Functions.ClearBuffer ( SFOOTER ) ; 
        __context__.SourceCodeLine = 194;
        Functions.ClearBuffer ( SSEPARATER ) ; 
        __context__.SourceCodeLine = 195;
        Functions.ClearBuffer ( SNUM1 ) ; 
        __context__.SourceCodeLine = 196;
        Functions.ClearBuffer ( SNUM2 ) ; 
        __context__.SourceCodeLine = 197;
        Functions.ClearBuffer ( SDIRECTORYNAME ) ; 
        __context__.SourceCodeLine = 198;
        NUM_1_FB__DOLLAR__  .UpdateValue ( SNUM1  ) ; 
        __context__.SourceCodeLine = 199;
        NUM_2_FB__DOLLAR__  .UpdateValue ( SNUM2  ) ; 
        __context__.SourceCodeLine = 200;
        DIRECTORY_NAME_FB__DOLLAR__  .UpdateValue ( SDIRECTORYNAME  ) ; 
        __context__.SourceCodeLine = 201;
        TEXT_FB__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 202;
        IINCOMINGTEXT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SNUM1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    SNUM2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    SHEADER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    SFOOTER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    SSEPARATER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SDIRECTORYNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    SELECT_NUM_1 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_NUM_1__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_NUM_1__DigitalInput__, SELECT_NUM_1 );
    
    SELECT_NUM_2 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_NUM_2__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_NUM_2__DigitalInput__, SELECT_NUM_2 );
    
    SELECT_DIRECTORY = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY__DigitalInput__, SELECT_DIRECTORY );
    
    SELECT_NONE = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_NONE__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_NONE__DigitalInput__, SELECT_NONE );
    
    CLEAR_NUM_1_NUM_2 = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_NUM_1_NUM_2__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_NUM_1_NUM_2__DigitalInput__, CLEAR_NUM_1_NUM_2 );
    
    COPY_NUM_1_TO_NUM_2 = new Crestron.Logos.SplusObjects.DigitalInput( COPY_NUM_1_TO_NUM_2__DigitalInput__, this );
    m_DigitalInputList.Add( COPY_NUM_1_TO_NUM_2__DigitalInput__, COPY_NUM_1_TO_NUM_2 );
    
    DIAL = new Crestron.Logos.SplusObjects.DigitalInput( DIAL__DigitalInput__, this );
    m_DigitalInputList.Add( DIAL__DigitalInput__, DIAL );
    
    MAX_PHONE_NUMBER_CHARACTERS = new Crestron.Logos.SplusObjects.AnalogInput( MAX_PHONE_NUMBER_CHARACTERS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_PHONE_NUMBER_CHARACTERS__AnalogSerialInput__, MAX_PHONE_NUMBER_CHARACTERS );
    
    HEADER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( HEADER__DOLLAR____AnalogSerialInput__, 25, this );
    m_StringInputList.Add( HEADER__DOLLAR____AnalogSerialInput__, HEADER__DOLLAR__ );
    
    NUMBER_SEPARATER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NUMBER_SEPARATER__DOLLAR____AnalogSerialInput__, 10, this );
    m_StringInputList.Add( NUMBER_SEPARATER__DOLLAR____AnalogSerialInput__, NUMBER_SEPARATER__DOLLAR__ );
    
    FOOTER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FOOTER__DOLLAR____AnalogSerialInput__, 25, this );
    m_StringInputList.Add( FOOTER__DOLLAR____AnalogSerialInput__, FOOTER__DOLLAR__ );
    
    NUM_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NUM_1__DOLLAR____AnalogSerialInput__, 30, this );
    m_StringInputList.Add( NUM_1__DOLLAR____AnalogSerialInput__, NUM_1__DOLLAR__ );
    
    NUM_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NUM_2__DOLLAR____AnalogSerialInput__, 30, this );
    m_StringInputList.Add( NUM_2__DOLLAR____AnalogSerialInput__, NUM_2__DOLLAR__ );
    
    DIRECTORY_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DIRECTORY_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DIRECTORY_NAME__DOLLAR____AnalogSerialInput__, DIRECTORY_NAME__DOLLAR__ );
    
    TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXT__DOLLAR____AnalogSerialInput__, 30, this );
    m_StringInputList.Add( TEXT__DOLLAR____AnalogSerialInput__, TEXT__DOLLAR__ );
    
    NUM_1_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUM_1_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NUM_1_FB__DOLLAR____AnalogSerialOutput__, NUM_1_FB__DOLLAR__ );
    
    NUM_2_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUM_2_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NUM_2_FB__DOLLAR____AnalogSerialOutput__, NUM_2_FB__DOLLAR__ );
    
    DIRECTORY_NAME_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_FB__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_FB__DOLLAR__ );
    
    TEXT_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TEXT_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEXT_FB__DOLLAR____AnalogSerialOutput__, TEXT_FB__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    
    SELECT_NUM_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_NUM_1_OnPush_0, false ) );
    SELECT_NUM_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_NUM_2_OnPush_1, false ) );
    SELECT_DIRECTORY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_OnPush_2, false ) );
    SELECT_NONE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_NONE_OnPush_3, false ) );
    COPY_NUM_1_TO_NUM_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( COPY_NUM_1_TO_NUM_2_OnPush_4, false ) );
    CLEAR_NUM_1_NUM_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_NUM_1_NUM_2_OnPush_5, false ) );
    DIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIAL_OnPush_6, false ) );
    MAX_PHONE_NUMBER_CHARACTERS.OnAnalogChange.Add( new InputChangeHandlerWrapper( MAX_PHONE_NUMBER_CHARACTERS_OnChange_7, false ) );
    HEADER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( HEADER__DOLLAR___OnChange_8, false ) );
    FOOTER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FOOTER__DOLLAR___OnChange_9, false ) );
    NUMBER_SEPARATER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( NUMBER_SEPARATER__DOLLAR___OnChange_10, false ) );
    NUM_1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( NUM_1__DOLLAR___OnChange_11, false ) );
    NUM_2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( NUM_2__DOLLAR___OnChange_12, false ) );
    DIRECTORY_NAME__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECTORY_NAME__DOLLAR___OnChange_13, false ) );
    TEXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TEXT__DOLLAR___OnChange_14, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_GENERIC_DIALER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SELECT_NUM_1__DigitalInput__ = 0;
const uint SELECT_NUM_2__DigitalInput__ = 1;
const uint SELECT_DIRECTORY__DigitalInput__ = 2;
const uint SELECT_NONE__DigitalInput__ = 3;
const uint CLEAR_NUM_1_NUM_2__DigitalInput__ = 4;
const uint COPY_NUM_1_TO_NUM_2__DigitalInput__ = 5;
const uint DIAL__DigitalInput__ = 6;
const uint MAX_PHONE_NUMBER_CHARACTERS__AnalogSerialInput__ = 0;
const uint HEADER__DOLLAR____AnalogSerialInput__ = 1;
const uint NUMBER_SEPARATER__DOLLAR____AnalogSerialInput__ = 2;
const uint FOOTER__DOLLAR____AnalogSerialInput__ = 3;
const uint NUM_1__DOLLAR____AnalogSerialInput__ = 4;
const uint NUM_2__DOLLAR____AnalogSerialInput__ = 5;
const uint DIRECTORY_NAME__DOLLAR____AnalogSerialInput__ = 6;
const uint TEXT__DOLLAR____AnalogSerialInput__ = 7;
const uint NUM_1_FB__DOLLAR____AnalogSerialOutput__ = 0;
const uint NUM_2_FB__DOLLAR____AnalogSerialOutput__ = 1;
const uint DIRECTORY_NAME_FB__DOLLAR____AnalogSerialOutput__ = 2;
const uint TEXT_FB__DOLLAR____AnalogSerialOutput__ = 3;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 4;

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
