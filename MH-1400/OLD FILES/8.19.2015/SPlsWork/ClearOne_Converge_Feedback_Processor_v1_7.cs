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

namespace UserModule_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_7
{
    public class UserModuleClass_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_7 : SplusObject
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
        CrestronString VALUE__DOLLAR__;
        CrestronString FUNCTION__DOLLAR__;
        CrestronString CHANNEL__DOLLAR__;
        CrestronString CHANNEL2__DOLLAR__;
        CrestronString DEVICEMSG__DOLLAR__;
        private void PROCESS2 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 65;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 66;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 67;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 67;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 68;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 69;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , VALUE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 70;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS3 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 75;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 76;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 77;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 77;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 78;
            PARAMETER = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 79;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 80;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}{5}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , VALUE__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 81;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS4 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 86;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 87;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 88;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 89;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS5 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 94;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( 1 ) )  ) ; 
            __context__.SourceCodeLine = 95;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 96;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 97;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESS6 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 102;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 103;
            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 104;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 104;
                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                }
            
            __context__.SourceCodeLine = 105;
            PARAMETER = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 106;
            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 107;
            VALUE = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 108;
            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}{3}{4}{5}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
            __context__.SourceCodeLine = 109;
            Functions.ProcessLogic ( ) ; 
            
            }
            
        private void PROCESSDEVICEMSG (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 124;
            MARKER1 = (ushort) ( Functions.Find( "#" , DEVICEMSG__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 125;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MARKER1 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 127;
                DEVICEMSG__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( MARKER1 ) ,  (int) ( (Functions.Length( DEVICEMSG__DOLLAR__ ) - MARKER1) ) )  ) ; 
                __context__.SourceCodeLine = 128;
                TYPE = (ushort) ( Byte( DEVICEMSG__DOLLAR__ , (int)( 2 ) ) ) ; 
                __context__.SourceCodeLine = 129;
                UNIT = (ushort) ( (Byte( DEVICEMSG__DOLLAR__ , (int)( 3 ) ) - 48) ) ; 
                __context__.SourceCodeLine = 130;
                MARKER1 = (ushort) ( Functions.Find( " " , DEVICEMSG__DOLLAR__ , 5 ) ) ; 
                __context__.SourceCodeLine = 131;
                MARKER2 = (ushort) ( Functions.Find( " " , DEVICEMSG__DOLLAR__ , (MARKER1 + 1) ) ) ; 
                __context__.SourceCodeLine = 132;
                MARKER3 = (ushort) ( Functions.Find( " " , DEVICEMSG__DOLLAR__ , (MARKER2 + 1) ) ) ; 
                __context__.SourceCodeLine = 133;
                MARKER4 = (ushort) ( Functions.Find( "\u000D" , DEVICEMSG__DOLLAR__ , (MARKER3 + 1) ) ) ; 
                __context__.SourceCodeLine = 134;
                FUNCTION__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (MARKER1 - 5) ) )  ) ; 
                __context__.SourceCodeLine = 135;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "GAIN"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 137;
                    CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 138;
                    CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 139;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 139;
                        CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 140;
                    PARAMETER = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 141;
                    VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 142;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                        {
                        __context__.SourceCodeLine = 142;
                        VALUE = (ushort) ( (65 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 143;
                        VALUE = (ushort) ( (65 + Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 144;
                    MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0001{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                    __context__.SourceCodeLine = 145;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 147;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MUTE"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 149;
                        FIELD = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 150;
                        PROCESS3 (  __context__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 152;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NOM"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 154;
                            FIELD = (ushort) ( 3 ) ; 
                            __context__.SourceCodeLine = 155;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                {
                                __context__.SourceCodeLine = 156;
                                PROCESS3 (  __context__  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 158;
                                PROCESS2 (  __context__  ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 160;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AGC"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 162;
                                FIELD = (ushort) ( 4 ) ; 
                                __context__.SourceCodeLine = 163;
                                PROCESS3 (  __context__  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 165;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "PP"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 167;
                                    FIELD = (ushort) ( 5 ) ; 
                                    __context__.SourceCodeLine = 168;
                                    PROCESS2 (  __context__  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 170;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MLINE"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 172;
                                        FIELD = (ushort) ( 6 ) ; 
                                        __context__.SourceCodeLine = 173;
                                        PROCESS2 (  __context__  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 175;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AAMB"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 177;
                                            FIELD = (ushort) ( 7 ) ; 
                                            __context__.SourceCodeLine = 178;
                                            PROCESS2 (  __context__  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 180;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "DECAY"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 182;
                                                FIELD = (ushort) ( 8 ) ; 
                                                __context__.SourceCodeLine = 183;
                                                PROCESS2 (  __context__  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 185;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "CHAIRO"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 187;
                                                    FIELD = (ushort) ( 9 ) ; 
                                                    __context__.SourceCodeLine = 188;
                                                    PROCESS2 (  __context__  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 190;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AMBLVL"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 192;
                                                        CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 193;
                                                        CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                        __context__.SourceCodeLine = 194;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 194;
                                                            CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 195;
                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 196;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 196;
                                                            VALUE = (ushort) ( (80 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                            }
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 197;
                                                            VALUE = (ushort) ( (80 + Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 198;
                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000A{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                        __context__.SourceCodeLine = 199;
                                                        Functions.ProcessLogic ( ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 201;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "LMO"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 203;
                                                            FIELD = (ushort) ( 11 ) ; 
                                                            __context__.SourceCodeLine = 204;
                                                            PROCESS2 (  __context__  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 206;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "FMP"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 208;
                                                                FIELD = (ushort) ( 12 ) ; 
                                                                __context__.SourceCodeLine = 209;
                                                                PROCESS2 (  __context__  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 211;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MMAX"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 213;
                                                                    FIELD = (ushort) ( 13 ) ; 
                                                                    __context__.SourceCodeLine = 214;
                                                                    PROCESS2 (  __context__  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 216;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "GATE"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 218;
                                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER4 - MARKER1) - 1) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 219;
                                                                        VALUE__DOLLAR__  .UpdateValue ( Functions.Right ( VALUE__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
                                                                        __context__.SourceCodeLine = 220;
                                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000E\u0000{2}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , VALUE__DOLLAR__ ) ; 
                                                                        __context__.SourceCodeLine = 221;
                                                                        Functions.ProcessLogic ( ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 223;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "MTRXLVL"))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 225;
                                                                            MARKER5 = (ushort) ( Functions.Find( " " , DEVICEMSG__DOLLAR__ , (MARKER3 + 1) ) ) ; 
                                                                            __context__.SourceCodeLine = 226;
                                                                            MARKER6 = (ushort) ( Functions.Find( " " , DEVICEMSG__DOLLAR__ , (MARKER5 + 1) ) ) ; 
                                                                            __context__.SourceCodeLine = 227;
                                                                            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 228;
                                                                            CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                            __context__.SourceCodeLine = 229;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                                                {
                                                                                __context__.SourceCodeLine = 229;
                                                                                CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                                                }
                                                                            
                                                                            __context__.SourceCodeLine = 230;
                                                                            PARAMETER = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                            __context__.SourceCodeLine = 231;
                                                                            CHANNEL2__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER5 - MARKER3) - 1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 232;
                                                                            CHANNEL2 = (ushort) ( Byte( CHANNEL2__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                            __context__.SourceCodeLine = 233;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL2 > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL2 < 58 ) )) ))  ) ) 
                                                                                {
                                                                                __context__.SourceCodeLine = 233;
                                                                                CHANNEL2 = (ushort) ( Functions.Atoi( CHANNEL2__DOLLAR__ ) ) ; 
                                                                                }
                                                                            
                                                                            __context__.SourceCodeLine = 234;
                                                                            PARAMETER2 = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER5 + 1) ) , (int)( ((MARKER6 - MARKER5) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                            __context__.SourceCodeLine = 235;
                                                                            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER6 + 1) ) ,  (int) ( ((MARKER4 - MARKER6) - 1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 236;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( VALUE__DOLLAR__ , (int)( 1 ) ) == 45))  ) ) 
                                                                                {
                                                                                __context__.SourceCodeLine = 236;
                                                                                VALUE = (ushort) ( (60 - Functions.Atoi( VALUE__DOLLAR__ )) ) ; 
                                                                                }
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 237;
                                                                                VALUE = (ushort) ( 60 ) ; 
                                                                                }
                                                                            
                                                                            __context__.SourceCodeLine = 238;
                                                                            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u000F{2}{3}{4}{5}{6}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( CHANNEL2 ) ) , Functions.Chr (  (int) ( PARAMETER2 ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                            __context__.SourceCodeLine = 239;
                                                                            Functions.ProcessLogic ( ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 241;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AEC"))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 243;
                                                                                FIELD = (ushort) ( 16 ) ; 
                                                                                __context__.SourceCodeLine = 244;
                                                                                PROCESS2 (  __context__  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 246;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NCSEL"))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 248;
                                                                                    FIELD = (ushort) ( 17 ) ; 
                                                                                    __context__.SourceCodeLine = 249;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 250;
                                                                                        PROCESS3 (  __context__  ) ; 
                                                                                        }
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 252;
                                                                                        PROCESS2 (  __context__  ) ; 
                                                                                        }
                                                                                    
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 254;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "NCD"))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 256;
                                                                                        CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER1 + 1) ) ,  (int) ( ((MARKER2 - MARKER1) - 1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 257;
                                                                                        CHANNEL = (ushort) ( Byte( CHANNEL__DOLLAR__ , (int)( 1 ) ) ) ; 
                                                                                        __context__.SourceCodeLine = 258;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL > 47 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHANNEL < 58 ) )) ))  ) ) 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 258;
                                                                                            CHANNEL = (ushort) ( Functions.Atoi( CHANNEL__DOLLAR__ ) ) ; 
                                                                                            }
                                                                                        
                                                                                        __context__.SourceCodeLine = 259;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 55))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 261;
                                                                                            PARAMETER = (ushort) ( Byte( Functions.Mid( DEVICEMSG__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( ((MARKER3 - MARKER2) - 1) ) ) , (int)( 1 ) ) ) ; 
                                                                                            __context__.SourceCodeLine = 262;
                                                                                            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER3 + 1) ) ,  (int) ( ((MARKER4 - MARKER3) - 1) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 263;
                                                                                            VALUE = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) - 6) ) ; 
                                                                                            __context__.SourceCodeLine = 264;
                                                                                            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0012{2}{3}{4}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( PARAMETER ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 268;
                                                                                            VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( DEVICEMSG__DOLLAR__ ,  (int) ( (MARKER2 + 1) ) ,  (int) ( ((MARKER4 - MARKER2) - 1) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 269;
                                                                                            VALUE = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) - 6) ) ; 
                                                                                            __context__.SourceCodeLine = 270;
                                                                                            MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}\u0012{2}{3}\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( CHANNEL ) ) , Functions.Chr (  (int) ( VALUE ) ) ) ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 272;
                                                                                        Functions.ProcessLogic ( ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 274;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AA"))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 276;
                                                                                            FIELD = (ushort) ( 19 ) ; 
                                                                                            __context__.SourceCodeLine = 277;
                                                                                            PROCESS4 (  __context__  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 279;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "TE"))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 281;
                                                                                                FIELD = (ushort) ( 20 ) ; 
                                                                                                __context__.SourceCodeLine = 282;
                                                                                                PROCESS4 (  __context__  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 284;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "AD"))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 286;
                                                                                                    FIELD = (ushort) ( 21 ) ; 
                                                                                                    __context__.SourceCodeLine = 287;
                                                                                                    PROCESS4 (  __context__  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 289;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RXBOOST"))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 291;
                                                                                                        FIELD = (ushort) ( 22 ) ; 
                                                                                                        __context__.SourceCodeLine = 292;
                                                                                                        PROCESS4 (  __context__  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 294;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RXBSTEN"))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 296;
                                                                                                            FIELD = (ushort) ( 23 ) ; 
                                                                                                            __context__.SourceCodeLine = 297;
                                                                                                            PROCESS4 (  __context__  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 299;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "RING"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 301;
                                                                                                                FIELD = (ushort) ( 24 ) ; 
                                                                                                                __context__.SourceCodeLine = 302;
                                                                                                                MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}1\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) ) ; 
                                                                                                                __context__.SourceCodeLine = 303;
                                                                                                                Functions.ProcessLogic ( ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 305;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "SIGGENEN"))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 307;
                                                                                                                    FIELD = (ushort) ( 25 ) ; 
                                                                                                                    __context__.SourceCodeLine = 308;
                                                                                                                    PROCESS5 (  __context__  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 310;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "FE"))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 312;
                                                                                                                        FIELD = (ushort) ( 26 ) ; 
                                                                                                                        __context__.SourceCodeLine = 313;
                                                                                                                        PROCESS3 (  __context__  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 315;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XCOMPSEL"))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 317;
                                                                                                                            FIELD = (ushort) ( 27 ) ; 
                                                                                                                            __context__.SourceCodeLine = 318;
                                                                                                                            PROCESS3 (  __context__  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 320;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XAA"))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 322;
                                                                                                                                FIELD = (ushort) ( 28 ) ; 
                                                                                                                                __context__.SourceCodeLine = 323;
                                                                                                                                PROCESS6 (  __context__  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 325;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XTE"))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 327;
                                                                                                                                    FIELD = (ushort) ( 29 ) ; 
                                                                                                                                    __context__.SourceCodeLine = 328;
                                                                                                                                    PROCESS6 (  __context__  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 330;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FUNCTION__DOLLAR__ == "XRING"))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 332;
                                                                                                                                        FIELD = (ushort) ( 30 ) ; 
                                                                                                                                        __context__.SourceCodeLine = 333;
                                                                                                                                        MakeString ( TOPROGRAM__DOLLAR__ , "\u00FD{0}{1}{2}1\u00FE", Functions.Chr (  (int) ( TYPE ) ) , Functions.Chr (  (int) ( UNIT ) ) , Functions.Chr (  (int) ( FIELD ) ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 334;
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
            
            
            }
            
        object FROM_DEVICE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 342;
                while ( Functions.TestForTrue  ( ( 1)  ) ) 
                    { 
                    __context__.SourceCodeLine = 344;
                    try 
                        { 
                        __context__.SourceCodeLine = 346;
                        DEVICEMSG__DOLLAR__  .UpdateValue ( Functions.Gather ( "\u000D\u000A" , FROM_DEVICE__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 347;
                        PROCESSDEVICEMSG (  __context__  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        __context__.SourceCodeLine = 351;
                        Print( "Problem processing Device Rx Message\r\n") ; 
                        
                        }
                        
                        __context__.SourceCodeLine = 342;
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
                
                __context__.SourceCodeLine = 380;
                RXOK = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            return __obj__;
            }
            
        
        public override void LogosSplusInitialize()
        {
            _SplusNVRAM = new SplusNVRAM( this );
            VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            FUNCTION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            CHANNEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            CHANNEL2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            DEVICEMSG__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            TOPROGRAM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOPROGRAM__DOLLAR____AnalogSerialOutput__, this );
            m_StringOutputList.Add( TOPROGRAM__DOLLAR____AnalogSerialOutput__, TOPROGRAM__DOLLAR__ );
            
            FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 1000, this );
            m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
            
            
            FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_0, true ) );
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_CLEARONE_CONVERGE_FEEDBACK_PROCESSOR_V1_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
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
