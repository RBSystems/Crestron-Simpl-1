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

namespace CrestronModule_IPHONE_XML_PROCESSOR_V1_0_0
{
    public class CrestronModuleClass_IPHONE_XML_PROCESSOR_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput REPEATTIMEREXPIRED;
        Crestron.Logos.SplusObjects.DigitalInput CONNECTIONACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DIG2XML;
        Crestron.Logos.SplusObjects.StringInput PASSCODE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PROJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput XML_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ANA2XML;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> STR2XML;
        Crestron.Logos.SplusObjects.DigitalOutput RESETREPEATTIMER;
        Crestron.Logos.SplusObjects.DigitalOutput STOPREPEATTIMER;
        Crestron.Logos.SplusObjects.DigitalOutput RESETTIMER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> XML2DIG;
        Crestron.Logos.SplusObjects.StringOutput XML_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> XML2ANA;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> XML2STR;
        ushort CONNECTIONSTATE = 0;
        ushort LASTDIGITALCHANGED = 0;
        ushort HANDLE = 0;
        ushort SEMAPHORE = 0;
        ushort DIGITALINQUEUE = 0;
        ushort ANALOGINQUEUE = 0;
        ushort SERIALINQUEUE = 0;
        ushort BUILDCONNECTIONRESPONSEFLAG = 0;
        ushort BUILDSERIALFLAG = 0;
        ushort [] DIGITALQUEUE;
        ushort [] ANALOGQUEUE;
        ushort [] SERIALQUEUE;
        private CrestronString REPLACESPECIALCHARACTERS (  SplusExecutionContext __context__, CrestronString INITIAL__DOLLAR__ , ushort REPLACESPACES ) 
            { 
            ushort I = 0;
            
            ushort TEMP = 0;
            
            CrestronString NEW__DOLLAR__;
            NEW__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            
            
            __context__.SourceCodeLine = 96;
            NEW__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 97;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( INITIAL__DOLLAR__ ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 99;
                TEMP = (ushort) ( Byte( INITIAL__DOLLAR__ , (int)( I ) ) ) ; 
                __context__.SourceCodeLine = 100;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( TEMP > 31 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TEMP < 128 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 102;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TEMP != 62) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMP != 60) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMP != 38) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMP != 34) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMP != 39) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMP != 32) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 103;
                        NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + Functions.Chr (  (int) ( TEMP ) )  ) ; 
                        }
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 106;
                        switch ((int)TEMP)
                        
                            { 
                            case 32 : 
                            
                                { 
                                __context__.SourceCodeLine = 110;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REPLACESPACES == 1))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 111;
                                    NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "_20"  ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 113;
                                    NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + Functions.Chr (  (int) ( TEMP ) )  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 114;
                                break ; 
                                } 
                            
                            goto case 62 ;
                            case 62 : 
                            
                                { 
                                __context__.SourceCodeLine = 118;
                                NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "&gt;"  ) ; 
                                __context__.SourceCodeLine = 119;
                                break ; 
                                } 
                            
                            goto case 60 ;
                            case 60 : 
                            
                                { 
                                __context__.SourceCodeLine = 123;
                                NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "&lt;"  ) ; 
                                __context__.SourceCodeLine = 124;
                                break ; 
                                } 
                            
                            goto case 38 ;
                            case 38 : 
                            
                                { 
                                __context__.SourceCodeLine = 128;
                                NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "&amp;"  ) ; 
                                __context__.SourceCodeLine = 129;
                                break ; 
                                } 
                            
                            goto case 34 ;
                            case 34 : 
                            
                                { 
                                __context__.SourceCodeLine = 133;
                                NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "&quot;"  ) ; 
                                __context__.SourceCodeLine = 134;
                                break ; 
                                } 
                            
                            goto case 39 ;
                            case 39 : 
                            
                                { 
                                __context__.SourceCodeLine = 138;
                                NEW__DOLLAR__  .UpdateValue ( NEW__DOLLAR__ + "&apos;"  ) ; 
                                __context__.SourceCodeLine = 139;
                                break ; 
                                } 
                            
                            break;
                            } 
                            
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 146;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TEMP == 9) ) || Functions.TestForTrue ( Functions.BoolToInt (TEMP == 10) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( TEMP >= 128 ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 147;
                        MakeString ( NEW__DOLLAR__ , "{0}&#{1:d};", NEW__DOLLAR__ , (short)TEMP) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 97;
                } 
            
            __context__.SourceCodeLine = 150;
            return ( NEW__DOLLAR__ ) ; 
            
            }
            
        private void ANALOGOUT (  SplusExecutionContext __context__, ushort JOIN , ushort VALUE ) 
            { 
            
            __context__.SourceCodeLine = 155;
            XML2ANA [ JOIN]  .Value = (ushort) ( VALUE ) ; 
            
            }
            
        private void DIGITALOUT (  SplusExecutionContext __context__, ushort JOIN , ushort VALUE ) 
            { 
            
            __context__.SourceCodeLine = 160;
            XML2DIG [ JOIN]  .Value = (ushort) ( VALUE ) ; 
            
            }
            
        private void SERIALOUT (  SplusExecutionContext __context__, ushort JOIN , CrestronString VALUE__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 165;
            XML2STR [ JOIN]  .UpdateValue ( VALUE__DOLLAR__  ) ; 
            
            }
            
        private void BUILDDIGITAL (  SplusExecutionContext __context__, ushort INDEX , ushort VALUE ) 
            { 
            CrestronString STATE;
            STATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 172;
            STATE  .UpdateValue ( Functions.Lower ( STATE )  ) ; 
            __context__.SourceCodeLine = 173;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 174;
                STATE  .UpdateValue ( "false"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 176;
                STATE  .UpdateValue ( "true"  ) ; 
                }
            
            __context__.SourceCodeLine = 177;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (BUILDCONNECTIONRESPONSEFLAG == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (BUILDSERIALFLAG == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 178;
                Functions.Delay (  (int) ( 1 ) ) ; 
                __context__.SourceCodeLine = 177;
                }
            
            __context__.SourceCodeLine = 179;
            MakeString ( XML_OUT , "<cresnet><data><bool id=\"{0:d}\" value=\"{1}\"/></data></cresnet>", (short)INDEX, STATE ) ; 
            
            }
            
        private void BUILDANALOG (  SplusExecutionContext __context__, ushort INDEX , ushort VALUE ) 
            { 
            
            __context__.SourceCodeLine = 184;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (BUILDCONNECTIONRESPONSEFLAG == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (BUILDSERIALFLAG == 1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 185;
                Functions.Delay (  (int) ( 1 ) ) ; 
                __context__.SourceCodeLine = 184;
                }
            
            __context__.SourceCodeLine = 186;
            MakeString ( XML_OUT , "<cresnet><data><i32 id=\"{0:d}\" value=\"{1:d}\"/></data></cresnet>", (short)INDEX, (ushort)VALUE) ; 
            
            }
            
        private void BUILDSERIAL (  SplusExecutionContext __context__, ushort INDEX , CrestronString VALUE__DOLLAR__ ) 
            { 
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1070, this );
            
            
            __context__.SourceCodeLine = 193;
            MakeString ( TEMP__DOLLAR__ , "<cresnet><data><string id=\"{0:d}\" value=\"{1}\"/></data></cresnet>", (short)INDEX, VALUE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 194;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) > 240 ))  ) ) 
                { 
                __context__.SourceCodeLine = 196;
                BUILDSERIALFLAG = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 197;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 199;
                    XML_OUT  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( 240 ) )  ) ; 
                    __context__.SourceCodeLine = 200;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 240) ) )  ) ; 
                    __context__.SourceCodeLine = 197;
                    } 
                
                __context__.SourceCodeLine = 202;
                BUILDSERIALFLAG = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 204;
            XML_OUT  .UpdateValue ( TEMP__DOLLAR__  ) ; 
            
            }
            
        private void BUILDCONNECTIONRESPONSE (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1100, this );
            
            
            __context__.SourceCodeLine = 211;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 213;
                MakeString ( TEMP__DOLLAR__ , "<cresnet><control><comm><connectResponse><handle>{0:d}</handle><mode isHeartbeatSupported=\"true\" isDigitalRepeatSupported=\"true\"><code>0</code></mode><entryfile>{1}_manifest.xml</entryfile></connectResponse></comm></control></cresnet>", (short)HANDLE, REPLACESPECIALCHARACTERS (  __context__ , PROJECT__DOLLAR__, (ushort)( 1 )) ) ; 
                __context__.SourceCodeLine = 214;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) > 240 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 216;
                    BUILDCONNECTIONRESPONSEFLAG = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 217;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) > 240 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 219;
                        XML_OUT  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( 240 ) )  ) ; 
                        __context__.SourceCodeLine = 220;
                        TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 240) ) )  ) ; 
                        __context__.SourceCodeLine = 217;
                        } 
                    
                    __context__.SourceCodeLine = 222;
                    BUILDCONNECTIONRESPONSEFLAG = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 224;
                XML_OUT  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 228;
                MakeString ( XML_OUT , "<cresnet><control><comm><connectResponse><handle>{0:d}</handle><mode><code>11</code></mode></connectResponse></comm></control></cresnet>", (short)HANDLE) ; 
                } 
            
            
            }
            
        private void BUILDDISCONNECTRESPONSE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 234;
            MakeString ( XML_OUT , "<cresnet><control><comm><disconnectResponse><handle>{0:d}</handle><result>0</result></disconnectResponse></comm></control></cresnet>", (short)HANDLE) ; 
            
            }
            
        private void SENDUPDATEREQUESTRESPONSE (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            ushort FLAG = 0;
            
            ushort COUNTER = 0;
            
            CrestronString STATE__DOLLAR__;
            STATE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1030, this );
            
            
            __context__.SourceCodeLine = 245;
            XML_OUT  .UpdateValue ( "<cresnet><data><updateCommand><clearAll/></updateCommand>"  ) ; 
            __context__.SourceCodeLine = 246;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)2000; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 248;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIG2XML[ I ] .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 250;
                    DIGITALQUEUE [ I] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 251;
                    MakeString ( XML_OUT , "<bool id=\"{0:d}\" value=\"true\"/>", (short)I) ; 
                    } 
                
                __context__.SourceCodeLine = 246;
                } 
            
            __context__.SourceCodeLine = 254;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)1000; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 256;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ANA2XML[ I ] .UshortValue > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 258;
                    ANALOGQUEUE [ I] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 259;
                    MakeString ( XML_OUT , "<i32 id=\"{0:d}\" value=\"{1:d}\"/>", (short)I, (ushort)ANA2XML[ I ] .UshortValue) ; 
                    } 
                
                __context__.SourceCodeLine = 254;
                } 
            
            __context__.SourceCodeLine = 262;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)500; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 264;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STR2XML[ I ] != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 266;
                    SERIALQUEUE [ I] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 267;
                    MakeString ( TEMP__DOLLAR__ , "<string id=\"{0:d}\" value=\"{1}\"/>", (short)I, REPLACESPECIALCHARACTERS (  __context__ , STR2XML[ I ], (ushort)( 0 )) ) ; 
                    __context__.SourceCodeLine = 268;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) > 240 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 270;
                        XML_OUT  .UpdateValue ( Functions.Left ( TEMP__DOLLAR__ ,  (int) ( 240 ) )  ) ; 
                        __context__.SourceCodeLine = 271;
                        TEMP__DOLLAR__  .UpdateValue ( Functions.Right ( TEMP__DOLLAR__ ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 240) ) )  ) ; 
                        __context__.SourceCodeLine = 268;
                        } 
                    
                    __context__.SourceCodeLine = 273;
                    XML_OUT  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 262;
                } 
            
            __context__.SourceCodeLine = 276;
            XML_OUT  .UpdateValue ( "<updateCommand><endOfUpdate/></updateCommand></data></cresnet>"  ) ; 
            __context__.SourceCodeLine = 277;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIGITALINQUEUE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 279;
                CONNECTIONSTATE = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 280;
                COUNTER = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 281;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (DIGITALINQUEUE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( COUNTER < 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 283;
                    COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                    __context__.SourceCodeLine = 284;
                    ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__4 = (ushort)2000; 
                    int __FN_FORSTEP_VAL__4 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (I  >= __FN_FORSTART_VAL__4) && (I  <= __FN_FOREND_VAL__4) ) : ( (I  <= __FN_FORSTART_VAL__4) && (I  >= __FN_FOREND_VAL__4) ) ; I  += (ushort)__FN_FORSTEP_VAL__4) 
                        { 
                        __context__.SourceCodeLine = 286;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIGITALQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 288;
                            BUILDDIGITAL (  __context__ , (ushort)( I ), (ushort)( DIG2XML[ I ] .Value )) ; 
                            __context__.SourceCodeLine = 289;
                            DIGITALQUEUE [ I] = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 284;
                        } 
                    
                    __context__.SourceCodeLine = 292;
                    FLAG = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 293;
                    ushort __FN_FORSTART_VAL__5 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__5 = (ushort)2000; 
                    int __FN_FORSTEP_VAL__5 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (I  >= __FN_FORSTART_VAL__5) && (I  <= __FN_FOREND_VAL__5) ) : ( (I  <= __FN_FORSTART_VAL__5) && (I  >= __FN_FOREND_VAL__5) ) ; I  += (ushort)__FN_FORSTEP_VAL__5) 
                        { 
                        __context__.SourceCodeLine = 295;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DIGITALQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 297;
                            FLAG = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 298;
                            break ; 
                            } 
                        
                        __context__.SourceCodeLine = 293;
                        } 
                    
                    __context__.SourceCodeLine = 301;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FLAG == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 302;
                        DIGITALINQUEUE = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 281;
                    } 
                
                __context__.SourceCodeLine = 304;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COUNTER == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 306;
                    DIGITALINQUEUE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 307;
                    GenerateUserNotice ( "Unable to process all digital transitions to iPhone upon Update Request\r\n") ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 310;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ANALOGINQUEUE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 312;
                CONNECTIONSTATE = (ushort) ( 6 ) ; 
                __context__.SourceCodeLine = 313;
                COUNTER = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 314;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ANALOGINQUEUE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( COUNTER < 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 316;
                    COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                    __context__.SourceCodeLine = 317;
                    ushort __FN_FORSTART_VAL__6 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__6 = (ushort)1000; 
                    int __FN_FORSTEP_VAL__6 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__6; (__FN_FORSTEP_VAL__6 > 0)  ? ( (I  >= __FN_FORSTART_VAL__6) && (I  <= __FN_FOREND_VAL__6) ) : ( (I  <= __FN_FORSTART_VAL__6) && (I  >= __FN_FOREND_VAL__6) ) ; I  += (ushort)__FN_FORSTEP_VAL__6) 
                        { 
                        __context__.SourceCodeLine = 319;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ANALOGQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 321;
                            BUILDANALOG (  __context__ , (ushort)( I ), (ushort)( ANA2XML[ I ] .UshortValue )) ; 
                            __context__.SourceCodeLine = 322;
                            ANALOGQUEUE [ I] = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 317;
                        } 
                    
                    __context__.SourceCodeLine = 325;
                    FLAG = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 326;
                    ushort __FN_FORSTART_VAL__7 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__7 = (ushort)1000; 
                    int __FN_FORSTEP_VAL__7 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__7; (__FN_FORSTEP_VAL__7 > 0)  ? ( (I  >= __FN_FORSTART_VAL__7) && (I  <= __FN_FOREND_VAL__7) ) : ( (I  <= __FN_FORSTART_VAL__7) && (I  >= __FN_FOREND_VAL__7) ) ; I  += (ushort)__FN_FORSTEP_VAL__7) 
                        { 
                        __context__.SourceCodeLine = 328;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ANALOGQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 330;
                            FLAG = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 331;
                            break ; 
                            } 
                        
                        __context__.SourceCodeLine = 326;
                        } 
                    
                    __context__.SourceCodeLine = 334;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FLAG == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 335;
                        ANALOGINQUEUE = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 314;
                    } 
                
                __context__.SourceCodeLine = 337;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COUNTER == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 339;
                    ANALOGINQUEUE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 340;
                    GenerateUserNotice ( "Unable to process all analog transitions to iPhone upon Update Request\r\n") ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 343;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALINQUEUE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 345;
                CONNECTIONSTATE = (ushort) ( 7 ) ; 
                __context__.SourceCodeLine = 346;
                COUNTER = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 347;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SERIALINQUEUE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( COUNTER < 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 349;
                    COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                    __context__.SourceCodeLine = 350;
                    ushort __FN_FORSTART_VAL__8 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__8 = (ushort)500; 
                    int __FN_FORSTEP_VAL__8 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__8; (__FN_FORSTEP_VAL__8 > 0)  ? ( (I  >= __FN_FORSTART_VAL__8) && (I  <= __FN_FOREND_VAL__8) ) : ( (I  <= __FN_FORSTART_VAL__8) && (I  >= __FN_FOREND_VAL__8) ) ; I  += (ushort)__FN_FORSTEP_VAL__8) 
                        { 
                        __context__.SourceCodeLine = 352;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 354;
                            BUILDSERIAL (  __context__ , (ushort)( I ), REPLACESPECIALCHARACTERS( __context__ , STR2XML[ I ] , (ushort)( 0 ) )) ; 
                            __context__.SourceCodeLine = 355;
                            SERIALQUEUE [ I] = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 350;
                        } 
                    
                    __context__.SourceCodeLine = 358;
                    FLAG = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 359;
                    ushort __FN_FORSTART_VAL__9 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__9 = (ushort)500; 
                    int __FN_FORSTEP_VAL__9 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__9; (__FN_FORSTEP_VAL__9 > 0)  ? ( (I  >= __FN_FORSTART_VAL__9) && (I  <= __FN_FOREND_VAL__9) ) : ( (I  <= __FN_FORSTART_VAL__9) && (I  >= __FN_FOREND_VAL__9) ) ; I  += (ushort)__FN_FORSTEP_VAL__9) 
                        { 
                        __context__.SourceCodeLine = 361;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 363;
                            FLAG = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 364;
                            break ; 
                            } 
                        
                        __context__.SourceCodeLine = 359;
                        } 
                    
                    __context__.SourceCodeLine = 367;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FLAG == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 368;
                        SERIALINQUEUE = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 347;
                    } 
                
                __context__.SourceCodeLine = 370;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COUNTER == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 372;
                    SERIALINQUEUE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 373;
                    GenerateUserNotice ( "Unable to process all serial transitions to iPhone upon Update Request\r\n") ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 376;
            CONNECTIONSTATE = (ushort) ( 3 ) ; 
            
            }
            
        private void BUILDHEARTBEATRESPONSE (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            
            __context__.SourceCodeLine = 381;
            MakeString ( XML_OUT , "<cresnet><control><comm><heartbeatResponse><handle>{0:d}</handle><data>{1}</data></heartbeatResponse></comm></control></cresnet>", (short)HANDLE, DATA ) ; 
            
            }
            
        object XML_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort JOIN = 0;
                
                ushort VALUE = 0;
                
                ushort REPEATFLAG = 0;
                
                CrestronString VALUE__DOLLAR__;
                VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
                
                ushort MARKER1 = 0;
                
                ushort MARKER2 = 0;
                
                CrestronString TEMP__DOLLAR__;
                TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                CrestronString TEMP2__DOLLAR__;
                TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
                
                
                __context__.SourceCodeLine = 395;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 397;
                    SEMAPHORE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 398;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</cresnet>" , XML_IN ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 400;
                        TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "</cresnet>" , XML_IN )  ) ; 
                        __context__.SourceCodeLine = 401;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</data></cresnet>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 403;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</updateRequest>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 405;
                                CONNECTIONSTATE = (ushort) ( 2 ) ; 
                                __context__.SourceCodeLine = 406;
                                SENDUPDATEREQUESTRESPONSE (  __context__  ) ; 
                                __context__.SourceCodeLine = 407;
                                RESETTIMER  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 408;
                                RESETTIMER  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 412;
                                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "/>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 414;
                                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Remove ( "/>" , TEMP__DOLLAR__ )  ) ; 
                                    __context__.SourceCodeLine = 415;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<i32" , TEMP2__DOLLAR__ ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 417;
                                        MARKER1 = (ushort) ( Functions.Find( "id=" , TEMP2__DOLLAR__ ) ) ; 
                                        __context__.SourceCodeLine = 418;
                                        MARKER2 = (ushort) ( Functions.Find( "value=" , TEMP2__DOLLAR__ ) ) ; 
                                        __context__.SourceCodeLine = 419;
                                        JOIN = (ushort) ( Functions.Atoi( Functions.Mid( TEMP2__DOLLAR__ , (int)( (MARKER1 + 4) ) , (int)( 5 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 420;
                                        VALUE = (ushort) ( Functions.Atoi( Functions.Mid( TEMP2__DOLLAR__ , (int)( (MARKER2 + 7) ) , (int)( ((Functions.Length( TEMP2__DOLLAR__ ) - MARKER2) - 9) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 421;
                                        ANALOGOUT (  __context__ , (ushort)( JOIN ), (ushort)( VALUE )) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 423;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<bool" , TEMP2__DOLLAR__ ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 425;
                                            MARKER1 = (ushort) ( Functions.Find( "id=" , TEMP2__DOLLAR__ ) ) ; 
                                            __context__.SourceCodeLine = 426;
                                            JOIN = (ushort) ( Functions.Atoi( Functions.Mid( TEMP2__DOLLAR__ , (int)( (MARKER1 + 4) ) , (int)( 5 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 427;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "repeating=\"true\"" , TEMP2__DOLLAR__ ) > 0 ))  ) ) 
                                                {
                                                __context__.SourceCodeLine = 428;
                                                REPEATFLAG = (ushort) ( 1 ) ; 
                                                }
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 430;
                                                REPEATFLAG = (ushort) ( 0 ) ; 
                                                }
                                            
                                            __context__.SourceCodeLine = 431;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "value=\"true\"" , TEMP2__DOLLAR__ ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 433;
                                                VALUE = (ushort) ( 1 ) ; 
                                                __context__.SourceCodeLine = 434;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REPEATFLAG == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 436;
                                                    RESETREPEATTIMER  .Value = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 437;
                                                    RESETREPEATTIMER  .Value = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 438;
                                                    LASTDIGITALCHANGED = (ushort) ( JOIN ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 443;
                                                VALUE = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 444;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (REPEATFLAG == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 446;
                                                    STOPREPEATTIMER  .Value = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 447;
                                                    STOPREPEATTIMER  .Value = (ushort) ( 0 ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            __context__.SourceCodeLine = 450;
                                            DIGITALOUT (  __context__ , (ushort)( JOIN ), (ushort)( VALUE )) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 452;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<string" , TEMP2__DOLLAR__ ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 454;
                                                MARKER1 = (ushort) ( Functions.Find( "id=" , TEMP2__DOLLAR__ ) ) ; 
                                                __context__.SourceCodeLine = 455;
                                                MARKER2 = (ushort) ( Functions.Find( "value=" , TEMP2__DOLLAR__ ) ) ; 
                                                __context__.SourceCodeLine = 456;
                                                JOIN = (ushort) ( Functions.Atoi( Functions.Mid( TEMP2__DOLLAR__ , (int)( (MARKER1 + 4) ) , (int)( 5 ) ) ) ) ; 
                                                __context__.SourceCodeLine = 457;
                                                VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( (MARKER2 + 7) ) ,  (int) ( ((Functions.Length( TEMP2__DOLLAR__ ) - MARKER2) - 9) ) )  ) ; 
                                                __context__.SourceCodeLine = 458;
                                                SERIALOUT (  __context__ , (ushort)( JOIN ), VALUE__DOLLAR__) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 412;
                                    } 
                                
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 463;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</control></cresnet>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 465;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</connectRequest>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 467;
                                    CONNECTIONSTATE = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 468;
                                    TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "</connectRequest>" , TEMP__DOLLAR__ )  ) ; 
                                    __context__.SourceCodeLine = 469;
                                    MARKER1 = (ushort) ( Functions.Find( "<passcode>" , TEMP__DOLLAR__ ) ) ; 
                                    __context__.SourceCodeLine = 470;
                                    MARKER2 = (ushort) ( Functions.Find( "</passcode>" , TEMP__DOLLAR__ , (MARKER1 + 1) ) ) ; 
                                    __context__.SourceCodeLine = 471;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MARKER1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( MARKER2 > 0 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 473;
                                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( (MARKER1 + 10) ) ,  (int) ( ((MARKER2 - MARKER1) - 10) ) )  ) ; 
                                        __context__.SourceCodeLine = 474;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP2__DOLLAR__ == REPLACESPECIALCHARACTERS( __context__ , PASSCODE__DOLLAR__ , (ushort)( 0 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 476;
                                            CONNECTIONSTATE = (ushort) ( 1 ) ; 
                                            __context__.SourceCodeLine = 477;
                                            BUILDCONNECTIONRESPONSE (  __context__ , (ushort)( 1 )) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 481;
                                            BUILDCONNECTIONRESPONSE (  __context__ , (ushort)( 0 )) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 486;
                                        BUILDCONNECTIONRESPONSE (  __context__ , (ushort)( 0 )) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 488;
                                    RESETTIMER  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 489;
                                    RESETTIMER  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 491;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "</heartbeatRequest>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 493;
                                        TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "</heartbeatRequest>" , TEMP__DOLLAR__ )  ) ; 
                                        __context__.SourceCodeLine = 494;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTIONSTATE == 3))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 496;
                                            MARKER1 = (ushort) ( Functions.Find( "<data>" , TEMP__DOLLAR__ ) ) ; 
                                            __context__.SourceCodeLine = 497;
                                            MARKER2 = (ushort) ( Functions.Find( "</data>" , TEMP__DOLLAR__ ) ) ; 
                                            __context__.SourceCodeLine = 498;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MARKER1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( MARKER2 > 0 ) )) ))  ) ) 
                                                {
                                                __context__.SourceCodeLine = 499;
                                                TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( (MARKER1 + 6) ) ,  (int) ( ((MARKER2 - MARKER1) - 6) ) )  ) ; 
                                                }
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 501;
                                                TEMP2__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                }
                                            
                                            __context__.SourceCodeLine = 502;
                                            BUILDHEARTBEATRESPONSE (  __context__ , TEMP2__DOLLAR__) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 504;
                                        RESETTIMER  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 505;
                                        RESETTIMER  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 507;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "/disconnectRequest>" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 509;
                                            TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "</disconnectRequest>" , TEMP__DOLLAR__ )  ) ; 
                                            __context__.SourceCodeLine = 510;
                                            BUILDDISCONNECTRESPONSE (  __context__  ) ; 
                                            __context__.SourceCodeLine = 511;
                                            CONNECTIONSTATE = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            }
                        
                        __context__.SourceCodeLine = 398;
                        } 
                    
                    __context__.SourceCodeLine = 515;
                    SEMAPHORE = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIG2XML_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort INDEX = 0;
            
            
            __context__.SourceCodeLine = 523;
            INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 524;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 3) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 2) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 5) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 7) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 526;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONACTIVE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 2) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 5) )) ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 527;
                    BUILDDIGITAL (  __context__ , (ushort)( INDEX ), (ushort)( DIG2XML[ INDEX ] .Value )) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 528;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTIONACTIVE  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 530;
                        DIGITALQUEUE [ INDEX] = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 531;
                        DIGITALINQUEUE = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ANA2XML_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort INDEX = 0;
        
        
        __context__.SourceCodeLine = 540;
        INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 541;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 3) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 2) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 5) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 7) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 543;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONACTIVE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 2) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE != 6) )) ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 544;
                BUILDANALOG (  __context__ , (ushort)( INDEX ), (ushort)( ANA2XML[ INDEX ] .UshortValue )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 545;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTIONACTIVE  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 547;
                    ANALOGQUEUE [ INDEX] = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 548;
                    ANALOGINQUEUE = (ushort) ( 1 ) ; 
                    } 
                
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STR2XML_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 555;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 3) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 2) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 1) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 5) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 7) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 557;
            SERIALQUEUE [ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ )] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 558;
            SERIALINQUEUE = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REPEATTIMEREXPIRED_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 564;
        DIGITALOUT (  __context__ , (ushort)( LASTDIGITALCHANGED ), (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECTIONACTIVE_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 569;
        CONNECTIONSTATE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    ushort FLAG = 0;
    
    ushort COUNTER = 0;
    
    CrestronString TEMP__DOLLAR__;
    TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 579;
        CONNECTIONSTATE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 580;
        BUILDSERIALFLAG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 581;
        BUILDCONNECTIONRESPONSEFLAG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 582;
        HANDLE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 583;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 584;
        COUNTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 585;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 587;
            Functions.Delay (  (int) ( 50 ) ) ; 
            __context__.SourceCodeLine = 588;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONACTIVE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTIONSTATE == 3) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 590;
                COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                __context__.SourceCodeLine = 591;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( COUNTER > 9 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 593;
                    COUNTER = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 594;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)500; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 596;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALQUEUE[ I ] == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 598;
                            TEMP__DOLLAR__  .UpdateValue ( STR2XML [ I ]  ) ; 
                            __context__.SourceCodeLine = 599;
                            BUILDSERIAL (  __context__ , (ushort)( I ), REPLACESPECIALCHARACTERS( __context__ , TEMP__DOLLAR__ , (ushort)( 0 ) )) ; 
                            __context__.SourceCodeLine = 600;
                            SERIALQUEUE [ I] = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 594;
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 606;
                    FLAG = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 607;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALINQUEUE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 609;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)500; 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 611;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERIALQUEUE[ I ] == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 613;
                                TEMP__DOLLAR__  .UpdateValue ( STR2XML [ I ]  ) ; 
                                __context__.SourceCodeLine = 614;
                                BUILDSERIAL (  __context__ , (ushort)( I ), REPLACESPECIALCHARACTERS( __context__ , TEMP__DOLLAR__ , (ushort)( 0 ) )) ; 
                                __context__.SourceCodeLine = 615;
                                SERIALQUEUE [ I] = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 616;
                                FLAG = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 609;
                            } 
                        
                        __context__.SourceCodeLine = 619;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FLAG == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 620;
                            SERIALINQUEUE = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 585;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    DIGITALQUEUE  = new ushort[ 2001 ];
    ANALOGQUEUE  = new ushort[ 1001 ];
    SERIALQUEUE  = new ushort[ 501 ];
    
    REPEATTIMEREXPIRED = new Crestron.Logos.SplusObjects.DigitalInput( REPEATTIMEREXPIRED__DigitalInput__, this );
    m_DigitalInputList.Add( REPEATTIMEREXPIRED__DigitalInput__, REPEATTIMEREXPIRED );
    
    CONNECTIONACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTIONACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTIONACTIVE__DigitalInput__, CONNECTIONACTIVE );
    
    DIG2XML = new InOutArray<DigitalInput>( 2000, this );
    for( uint i = 0; i < 2000; i++ )
    {
        DIG2XML[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DIG2XML__DigitalInput__ + i, DIG2XML__DigitalInput__, this );
        m_DigitalInputList.Add( DIG2XML__DigitalInput__ + i, DIG2XML[i+1] );
    }
    
    RESETREPEATTIMER = new Crestron.Logos.SplusObjects.DigitalOutput( RESETREPEATTIMER__DigitalOutput__, this );
    m_DigitalOutputList.Add( RESETREPEATTIMER__DigitalOutput__, RESETREPEATTIMER );
    
    STOPREPEATTIMER = new Crestron.Logos.SplusObjects.DigitalOutput( STOPREPEATTIMER__DigitalOutput__, this );
    m_DigitalOutputList.Add( STOPREPEATTIMER__DigitalOutput__, STOPREPEATTIMER );
    
    RESETTIMER = new Crestron.Logos.SplusObjects.DigitalOutput( RESETTIMER__DigitalOutput__, this );
    m_DigitalOutputList.Add( RESETTIMER__DigitalOutput__, RESETTIMER );
    
    XML2DIG = new InOutArray<DigitalOutput>( 2000, this );
    for( uint i = 0; i < 2000; i++ )
    {
        XML2DIG[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( XML2DIG__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( XML2DIG__DigitalOutput__ + i, XML2DIG[i+1] );
    }
    
    ANA2XML = new InOutArray<AnalogInput>( 1000, this );
    for( uint i = 0; i < 1000; i++ )
    {
        ANA2XML[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ANA2XML__AnalogSerialInput__ + i, ANA2XML__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ANA2XML__AnalogSerialInput__ + i, ANA2XML[i+1] );
    }
    
    XML2ANA = new InOutArray<AnalogOutput>( 1000, this );
    for( uint i = 0; i < 1000; i++ )
    {
        XML2ANA[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( XML2ANA__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( XML2ANA__AnalogSerialOutput__ + i, XML2ANA[i+1] );
    }
    
    PASSCODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PASSCODE__DOLLAR____AnalogSerialInput__, 16, this );
    m_StringInputList.Add( PASSCODE__DOLLAR____AnalogSerialInput__, PASSCODE__DOLLAR__ );
    
    PROJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PROJECT__DOLLAR____AnalogSerialInput__, 256, this );
    m_StringInputList.Add( PROJECT__DOLLAR____AnalogSerialInput__, PROJECT__DOLLAR__ );
    
    STR2XML = new InOutArray<StringInput>( 500, this );
    for( uint i = 0; i < 500; i++ )
    {
        STR2XML[i+1] = new Crestron.Logos.SplusObjects.StringInput( STR2XML__AnalogSerialInput__ + i, STR2XML__AnalogSerialInput__, 256, this );
        m_StringInputList.Add( STR2XML__AnalogSerialInput__ + i, STR2XML[i+1] );
    }
    
    XML_OUT = new Crestron.Logos.SplusObjects.StringOutput( XML_OUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( XML_OUT__AnalogSerialOutput__, XML_OUT );
    
    XML2STR = new InOutArray<StringOutput>( 500, this );
    for( uint i = 0; i < 500; i++ )
    {
        XML2STR[i+1] = new Crestron.Logos.SplusObjects.StringOutput( XML2STR__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( XML2STR__AnalogSerialOutput__ + i, XML2STR[i+1] );
    }
    
    XML_IN = new Crestron.Logos.SplusObjects.BufferInput( XML_IN__AnalogSerialInput__, 2000, this );
    m_StringInputList.Add( XML_IN__AnalogSerialInput__, XML_IN );
    
    
    XML_IN.OnSerialChange.Add( new InputChangeHandlerWrapper( XML_IN_OnChange_0, false ) );
    for( uint i = 0; i < 2000; i++ )
        DIG2XML[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( DIG2XML_OnChange_1, false ) );
        
    for( uint i = 0; i < 1000; i++ )
        ANA2XML[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( ANA2XML_OnChange_2, false ) );
        
    for( uint i = 0; i < 500; i++ )
        STR2XML[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( STR2XML_OnChange_3, false ) );
        
    REPEATTIMEREXPIRED.OnDigitalPush.Add( new InputChangeHandlerWrapper( REPEATTIMEREXPIRED_OnPush_4, false ) );
    CONNECTIONACTIVE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CONNECTIONACTIVE_OnRelease_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_IPHONE_XML_PROCESSOR_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint REPEATTIMEREXPIRED__DigitalInput__ = 0;
const uint CONNECTIONACTIVE__DigitalInput__ = 1;
const uint DIG2XML__DigitalInput__ = 2;
const uint PASSCODE__DOLLAR____AnalogSerialInput__ = 0;
const uint PROJECT__DOLLAR____AnalogSerialInput__ = 1;
const uint XML_IN__AnalogSerialInput__ = 2;
const uint ANA2XML__AnalogSerialInput__ = 3;
const uint STR2XML__AnalogSerialInput__ = 1003;
const uint RESETREPEATTIMER__DigitalOutput__ = 0;
const uint STOPREPEATTIMER__DigitalOutput__ = 1;
const uint RESETTIMER__DigitalOutput__ = 2;
const uint XML2DIG__DigitalOutput__ = 3;
const uint XML_OUT__AnalogSerialOutput__ = 0;
const uint XML2ANA__AnalogSerialOutput__ = 1;
const uint XML2STR__AnalogSerialOutput__ = 1001;

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
