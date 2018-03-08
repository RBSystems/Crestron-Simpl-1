#ifndef __S2_CLEARONE_CONVERGE_GENERATOR_V1_1_H__
#define __S2_CLEARONE_CONVERGE_GENERATOR_V1_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_ClearOne_Converge_Generator_v1_1_VOLUMEMXB_ANALOG_INPUT 0
#define __S2_ClearOne_Converge_Generator_v1_1_VOLUMEMXB2_ANALOG_INPUT 1
#define __S2_ClearOne_Converge_Generator_v1_1_AMBLVLMXB_ANALOG_INPUT 2
#define __S2_ClearOne_Converge_Generator_v1_1_AMBLVLMXB2_ANALOG_INPUT 3
#define __S2_ClearOne_Converge_Generator_v1_1_NOISEMXB_ANALOG_INPUT 4
#define __S2_ClearOne_Converge_Generator_v1_1_NOISEMXB2_ANALOG_INPUT 5

#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND$_STRING_INPUT 6
#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND$_STRING_MAX_LEN 24
CREATE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND$, __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND$_STRING_MAX_LEN );
#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND2$_STRING_INPUT 7
#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND2$_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND2$, __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND2$_STRING_MAX_LEN );
#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND3$_STRING_INPUT 8
#define __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND3$_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND3$, __S2_ClearOne_Converge_Generator_v1_1_STARTOFCOMMAND3$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_ClearOne_Converge_Generator_v1_1_TO_DEVICE$_STRING_OUTPUT 0
#define __S2_ClearOne_Converge_Generator_v1_1_VOLUMETEXT_STRING_OUTPUT 1
#define __S2_ClearOne_Converge_Generator_v1_1_AMBLVLTEXT_STRING_OUTPUT 2
#define __S2_ClearOne_Converge_Generator_v1_1_NOISETEXT_STRING_OUTPUT 3


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_ClearOne_Converge_Generator_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND$ );
   DECLARE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND2$ );
   DECLARE_STRING_STRUCT( S2_ClearOne_Converge_Generator_v1_1, __STARTOFCOMMAND3$ );
};

START_NVRAM_VAR_STRUCT( S2_ClearOne_Converge_Generator_v1_1 )
{
};



#endif //__S2_CLEARONE_CONVERGE_GENERATOR_V1_1_H__

