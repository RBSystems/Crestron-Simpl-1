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

namespace UserModule_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_5
{
    public class UserModuleClass_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_5 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TOPROGRAM__DOLLAR__;
        ushort RXOK = 0;
        ushort MARKER1 = 0;
        ushort MARKER2 = 0;
        ushort MARKER3 = 0;
        ushort MARKER4 = 0;
        ushort MARKER5 = 0;
        ushort MARKER6 = 0;
        ushort VALUE = 0;
        ushort CHANNEL = 0;
        ushort PARAMETER = 0;
        ushort UNIT = 0;
        ushort TYPE = 0;
        ushort FIELD = 0;
        ushort CHANNEL2 = 0;
        ushort PARAMETER2 = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        CrestronString VALUE__DOLLAR__;
        CrestronString FUNCTION__DOLLAR__;
        CrestronString CHANNEL__DOLLAR__;
        CrestronString CHANNEL2__DOLLAR__;
        private void PROCESS2 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 64;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 65;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 66;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 66;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 67;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 68;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , VALUE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 69;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS3 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 74;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 75;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 76;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 76;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 77;
            PARAMETER = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 78;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 79;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}{5}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , VALUE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 80;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS4 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 85;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 86;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 87;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 88;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS5 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 93;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( 1 ) )  ) ; 
            __context__.SourceCodeLine = 94;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 95;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 96;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS6 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 101;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 102;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 103;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 103;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 104;
            PARAMETER = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 105;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 106;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 107;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}{5}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 108;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        object FROM_DEVICE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 121;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RXOK == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 123;
                    RXOK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 124;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D\u000A" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 126;
                        TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , FROM_DEVICE__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 127;
                        MARKER1 = (ushort) ( Functions.Find( "#" , TEMPSTRING__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 128;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MARKER1 > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 130;
                            TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( MARKER1 ) ,  (int) ( (Functions.Length( TEMPSTRING__DOLLAR__ ) - MARKER1) ) )  ) ; 
                            __context__.SourceCodeLine = 131;
                            TYPE = (ushort) ( Byte( TEMPSTRING__DOLLAR__ , (int)( 2 ) ) ) ; 
                            __context__.SourceCodeLine = 132;
                            UNIT = (ushort) ( (Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) - 48) ) ; 
                            __context__.SourceCodeLine = 133;
                            MARKER1 = (ushort) ( Functions.Find( " " , TEMPSTRING__DOLLAR__ , 5 ) ) ; 
                            __context__.SourceCodeLine = 134;
                            MARKER2 = (ushort) ( Functions.Find( " " , TEMPSTRING__DOLLAR__ , (MARKER1 + 1) ) ) ; 
                            __context__.SourceCodeLine = 135;
                            MARKER3 = (ushort) ( Functions.Find( " " , TEMPSTRING__DOLLAR__ , (MARKER2 + 1) ) ) ; 
                            __context__.SourceCodeLine = 136;
                            MARKER4 = (ushort) ( Functions.Find( "\u000D" , TEMPSTRING__DOLLAR__ , (MARKER3 + 1) ) ) ; 
                            __context__.SourceCodeLine = 137;
                            FUNCTION__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (MARKER1 - 5) ) )  ) ; 
                            __context__.SourceCodeLine = 138;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "GAIN"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 140;
                                CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 141;
                                CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 142;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 142;
                                    CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 143;
                                PARAMETER = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 144;
                                VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
                                __context__.SourceCodeLine = 145;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 145;
                                    VALUE = (ushort) ( (65 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 146;
                                    VALUE = (ushort) ( (65 + Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 147;
                                MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0001{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                __context__.SourceCodeLine = 148;
                                Functions.ProcessLogic ( ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 150;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MUTE"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 152;
                                    FIELD = (ushort) ( 2 ) ; 
                                    __context__.SourceCodeLine = 153;
                                    PROCESS3 (  __context__  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 155;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NOM"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 157;
                                        FIELD = (ushort) ( 3 ) ; 
                                        __context__.SourceCodeLine = 158;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 159;
                                            PROCESS3 (  __context__  ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 161;
                                            PROCESS2 (  __context__  ) ; 
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 163;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AGC"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 165;
                                            FIELD = (ushort) ( 4 ) ; 
                                            __context__.SourceCodeLine = 166;
                                            PROCESS3 (  __context__  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 168;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "PP"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 170;
                                                FIELD = (ushort) ( 5 ) ; 
                                                __context__.SourceCodeLine = 171;
                                                PROCESS2 (  __context__  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 173;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MLINE"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 175;
                                                    FIELD = (ushort) ( 6 ) ; 
                                                    __context__.SourceCodeLine = 176;
                                                    PROCESS2 (  __context__  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 178;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AAMB"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 180;
                                                        FIELD = (ushort) ( 7 ) ; 
                                                        __context__.SourceCodeLine = 181;
                                                        PROCESS2 (  __context__  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 183;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "DECAY"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 185;
                                                            FIELD = (ushort) ( 8 ) ; 
                                                            __context__.SourceCodeLine = 186;
                                                            PROCESS2 (  __context__  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 188;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "CHAIRO"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 190;
                                                                FIELD = (ushort) ( 9 ) ; 
                                                                __context__.SourceCodeLine = 191;
                                                                PROCESS2 (  __context__  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 193;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AMBLVL"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 195;
                                                                    CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 196;
                                                                    CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                    __context__.SourceCodeLine = 197;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                                        {
                                                                        __context__.SourceCodeLine = 197;
                                                                        CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                                        }
                                                                    
                                                                    __context__.SourceCodeLine = 198;
                                                                    VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 199;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                                                                        {
                                                                        __context__.SourceCodeLine = 199;
                                                                        VALUE = (ushort) ( (80 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                                        }
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 200;
                                                                        VALUE = (ushort) ( (80 + Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                                        }
                                                                    
                                                                    __context__.SourceCodeLine = 201;
                                                                    MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000A{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                    __context__.SourceCodeLine = 202;
                                                                    Functions.ProcessLogic ( ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 204;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "LMO"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 206;
                                                                        FIELD = (ushort) ( 11 ) ; 
                                                                        __context__.SourceCodeLine = 207;
                                                                        PROCESS2 (  __context__  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 209;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "FMP"))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 211;
                                                                            FIELD = (ushort) ( 12 ) ; 
                                                                            __context__.SourceCodeLine = 212;
                                                                            PROCESS2 (  __context__  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 214;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MMAX"))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 216;
                                                                                FIELD = (ushort) ( 13 ) ; 
                                                                                __context__.SourceCodeLine = 217;
                                                                                PROCESS2 (  __context__  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 219;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "GATE"))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 221;
                                                                                    VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER4 - MARKER1) - 1) ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 222;
                                                                                    VALUE__DOLLAR__  .UpdateValue ( Functions.Right ( VALUE__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 223;
                                                                                    MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000E\u0000{2}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , VALUE__DOLLAR__ ) ; 
                                                                                    __context__.SourceCodeLine = 224;
                                                                                    Functions.ProcessLogic ( ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 226;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MTRXLVL"))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 228;
                                                                                        MARKER5 = (ushort) ( Functions.Find( " " , TEMPSTRING__DOLLAR__ , (MARKER3 + 1) ) ) ; 
                                                                                        __context__.SourceCodeLine = 229;
                                                                                        MARKER6 = (ushort) ( Functions.Find( " " , TEMPSTRING__DOLLAR__ , (MARKER5 + 1) ) ) ; 
                                                                                        __context__.SourceCodeLine = 230;
                                                                                        CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 231;
                                                                                        CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 232;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 232;
                                                                                            CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                                                            }
                                                                                        
                                                                                        __context__.SourceCodeLine = 233;
                                                                                        PARAMETER = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 234;
                                                                                        CHANNEL2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER5 - MARKER3) - 1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 235;
                                                                                        CHANNEL2 = (ushort) ( Byte( CHANNEL2__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 236;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL2 > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL2 < 58 ) )) ))  ) ) 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 236;
                                                                                            CHANNEL2 = (ushort) ( Functions.Atoi( CHANNEL2__DOLLAR__ ) ) ; 
                                                                                            }
                                                                                        
                                                                                        __context__.SourceCodeLine = 237;
                                                                                        PARAMETER2 = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER5 + 1) ) , (int)( ((MARKER6 - MARKER5) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 238;
                                                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER6 + 1) ) ,  (int) ( ((MARKER4 - MARKER6) - 1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 239;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 239;
                                                                                            VALUE = (ushort) ( (60 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                                                            }
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 240;
                                                                                            VALUE = (ushort) ( 60 ) ; 
                                                                                            }
                                                                                        
                                                                                        __context__.SourceCodeLine = 241;
                                                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000F{2}{3}{4}{5}{6}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( CHANNEL2 ) ) , Functions.Chr (  (int) ( PARAMETER2 ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 242;
                                                                                        Functions.ProcessLogic ( ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 244;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AEC"))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 246;
                                                                                            FIELD = (ushort) ( 16 ) ; 
                                                                                            __context__.SourceCodeLine = 247;
                                                                                            PROCESS2 (  __context__  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 249;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NCSEL"))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 251;
                                                                                                FIELD = (ushort) ( 17 ) ; 
                                                                                                __context__.SourceCodeLine = 252;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 253;
                                                                                                    PROCESS3 (  __context__  ) ; 
                                                                                                    }
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 255;
                                                                                                    PROCESS2 (  __context__  ) ; 
                                                                                                    }
                                                                                                
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 257;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NCD"))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 259;
                                                                                                    CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                                                                    __context__.SourceCodeLine = 260;
                                                                                                    CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                                                    __context__.SourceCodeLine = 261;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 261;
                                                                                                        CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                                                                        }
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 262;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 264;
                                                                                                        PARAMETER = (ushort) ( Byte( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                                                        __context__.SourceCodeLine = 265;
                                                                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 266;
                                                                                                        VALUE = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) - 6) ) ; 
                                                                                                        __context__.SourceCodeLine = 267;
                                                                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0012{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 271;
                                                                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 272;
                                                                                                        VALUE = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) - 6) ) ; 
                                                                                                        __context__.SourceCodeLine = 273;
                                                                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0012{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 275;
                                                                                                    Functions.ProcessLogic ( ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 277;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AA"))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 279;
                                                                                                        FIELD = (ushort) ( 19 ) ; 
                                                                                                        __context__.SourceCodeLine = 280;
                                                                                                        PROCESS4 (  __context__  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 282;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "TE"))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 284;
                                                                                                            FIELD = (ushort) ( 20 ) ; 
                                                                                                            __context__.SourceCodeLine = 285;
                                                                                                            PROCESS4 (  __context__  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 287;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AD"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 289;
                                                                                                                FIELD = (ushort) ( 21 ) ; 
                                                                                                                __context__.SourceCodeLine = 290;
                                                                                                                PROCESS4 (  __context__  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 292;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RXBOOST"))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 294;
                                                                                                                    FIELD = (ushort) ( 22 ) ; 
                                                                                                                    __context__.SourceCodeLine = 295;
                                                                                                                    PROCESS4 (  __context__  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 297;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RXBSTEN"))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 299;
                                                                                                                        FIELD = (ushort) ( 23 ) ; 
                                                                                                                        __context__.SourceCodeLine = 300;
                                                                                                                        PROCESS4 (  __context__  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 302;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RING"))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 304;
                                                                                                                            FIELD = (ushort) ( 24 ) ; 
                                                                                                                            __context__.SourceCodeLine = 305;
                                                                                                                            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}1\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 306;
                                                                                                                            Functions.ProcessLogic ( ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 308;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "SIGGENEN"))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 310;
                                                                                                                                FIELD = (ushort) ( 25 ) ; 
                                                                                                                                __context__.SourceCodeLine = 311;
                                                                                                                                PROCESS5 (  __context__  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 313;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "FE"))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 315;
                                                                                                                                    FIELD = (ushort) ( 26 ) ; 
                                                                                                                                    __context__.SourceCodeLine = 316;
                                                                                                                                    PROCESS3 (  __context__  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 318;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XCOMPSEL"))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 320;
                                                                                                                                        FIELD = (ushort) ( 27 ) ; 
                                                                                                                                        __context__.SourceCodeLine = 321;
                                                                                                                                        PROCESS3 (  __context__  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    else 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 323;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XAA"))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 325;
                                                                                                                                            FIELD = (ushort) ( 28 ) ; 
                                                                                                                                            __context__.SourceCodeLine = 326;
                                                                                                                                            PROCESS6 (  __context__  ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        else 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 328;
                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XTE"))  ) ) 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 330;
                                                                                                                                                FIELD = (ushort) ( 29 ) ; 
                                                                                                                                                __context__.SourceCodeLine = 331;
                                                                                                                                                PROCESS6 (  __context__  ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            else 
                                                                                                                                                {
                                                                                                                                                __context__.SourceCodeLine = 333;
                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XRING"))  ) ) 
                                                                                                                                                    { 
                                                                                                                                                    __context__.SourceCodeLine = 335;
                                                                                                                                                    FIELD = (ushort) ( 30 ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 336;
                                                                                                                                                    MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}1\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) ) ; 
                                                                                                                                                    __context__.SourceCodeLine = 337;
                                                                                                                                                    Functions.ProcessLogic ( ) ; 
                                                                                                                                                    } 
                                                                                                                                                
                                                                                                                                                }
                                                                                                                                            
                                                                                                                                            }
                                                                                                                                        
                                                                                                                                        }
                                                                                                                                    
                                                                                                                                    }
                                                                                                                                
                                                                                                                                }
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 124;
                        } 
                    
                    __context__.SourceCodeLine = 341;
                    RXOK = (ushort) ( 1 ) ; 
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
            
            __context__.SourceCodeLine = 353;
            RXOK = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        FUNCTION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
        CHANNEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        CHANNEL2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        
        TOPROGRAM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOPROGRAM__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TOPROGRAM__DOLLAR____AnalogSerialOutput__, TOPROGRAM__DOLLAR__ );
        
        FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 1000, this );
        m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
        
        
        FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_5 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
    const uint TOPROGRAM__DOLLAR____AnalogSerialOutput__ = 0;
    
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
