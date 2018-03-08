#ifndef __S2_IPHONE_XML_PROCESSOR_V1_0_0_H__
#define __S2_IPHONE_XML_PROCESSOR_V1_0_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_iPhone_XML_Processor_v1_0_0_REPEATTIMEREXPIRED_DIG_INPUT 0
#define __S2_iPhone_XML_Processor_v1_0_0_CONNECTIONACTIVE_DIG_INPUT 1

#define __S2_iPhone_XML_Processor_v1_0_0_DIG2XML_DIG_INPUT 2
#define __S2_iPhone_XML_Processor_v1_0_0_DIG2XML_ARRAY_LENGTH 2000

/*
* ANALOG_INPUT
*/

#define __S2_iPhone_XML_Processor_v1_0_0_PASSCODE$_STRING_INPUT 0
#define __S2_iPhone_XML_Processor_v1_0_0_PASSCODE$_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __PASSCODE$, __S2_iPhone_XML_Processor_v1_0_0_PASSCODE$_STRING_MAX_LEN );
#define __S2_iPhone_XML_Processor_v1_0_0_PROJECT$_STRING_INPUT 1
#define __S2_iPhone_XML_Processor_v1_0_0_PROJECT$_STRING_MAX_LEN 256
CREATE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __PROJECT$, __S2_iPhone_XML_Processor_v1_0_0_PROJECT$_STRING_MAX_LEN );

#define __S2_iPhone_XML_Processor_v1_0_0_XML_IN_BUFFER_INPUT 2
#define __S2_iPhone_XML_Processor_v1_0_0_XML_IN_BUFFER_MAX_LEN 2000
CREATE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __XML_IN, __S2_iPhone_XML_Processor_v1_0_0_XML_IN_BUFFER_MAX_LEN );

#define __S2_iPhone_XML_Processor_v1_0_0_ANA2XML_ANALOG_INPUT 3
#define __S2_iPhone_XML_Processor_v1_0_0_ANA2XML_ARRAY_LENGTH 1000
#define __S2_iPhone_XML_Processor_v1_0_0_STR2XML_STRING_INPUT 1003
#define __S2_iPhone_XML_Processor_v1_0_0_STR2XML_ARRAY_NUM_ELEMS 500
#define __S2_iPhone_XML_Processor_v1_0_0_STR2XML_ARRAY_NUM_CHARS 256
CREATE_STRING_ARRAY( S2_iPhone_XML_Processor_v1_0_0, __STR2XML, __S2_iPhone_XML_Processor_v1_0_0_STR2XML_ARRAY_NUM_ELEMS, __S2_iPhone_XML_Processor_v1_0_0_STR2XML_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_iPhone_XML_Processor_v1_0_0_RESETREPEATTIMER_DIG_OUTPUT 0
#define __S2_iPhone_XML_Processor_v1_0_0_STOPREPEATTIMER_DIG_OUTPUT 1
#define __S2_iPhone_XML_Processor_v1_0_0_RESETTIMER_DIG_OUTPUT 2

#define __S2_iPhone_XML_Processor_v1_0_0_XML2DIG_DIG_OUTPUT 3
#define __S2_iPhone_XML_Processor_v1_0_0_XML2DIG_ARRAY_LENGTH 2000

/*
* ANALOG_OUTPUT
*/

#define __S2_iPhone_XML_Processor_v1_0_0_XML_OUT_STRING_OUTPUT 0

#define __S2_iPhone_XML_Processor_v1_0_0_XML2ANA_ANALOG_OUTPUT 1
#define __S2_iPhone_XML_Processor_v1_0_0_XML2ANA_ARRAY_LENGTH 1000
#define __S2_iPhone_XML_Processor_v1_0_0_XML2STR_STRING_OUTPUT 1001
#define __S2_iPhone_XML_Processor_v1_0_0_XML2STR_ARRAY_LENGTH 500

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
CREATE_INTARRAY1D( S2_iPhone_XML_Processor_v1_0_0, __DIGITALQUEUE, 2000 );;
CREATE_INTARRAY1D( S2_iPhone_XML_Processor_v1_0_0, __ANALOGQUEUE, 1000 );;
CREATE_INTARRAY1D( S2_iPhone_XML_Processor_v1_0_0, __SERIALQUEUE, 500 );;


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

START_GLOBAL_VAR_STRUCT( S2_iPhone_XML_Processor_v1_0_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __DIG2XML );
   DECLARE_IO_ARRAY( __XML2DIG );
   DECLARE_IO_ARRAY( __ANA2XML );
   DECLARE_IO_ARRAY( __XML2ANA );
   DECLARE_IO_ARRAY( __XML2STR );
   unsigned short __CONNECTIONSTATE;
   unsigned short __LASTDIGITALCHANGED;
   unsigned short __HANDLE;
   unsigned short __SEMAPHORE;
   unsigned short __DIGITALINQUEUE;
   unsigned short __ANALOGINQUEUE;
   unsigned short __SERIALINQUEUE;
   unsigned short __BUILDCONNECTIONRESPONSEFLAG;
   unsigned short __BUILDSERIALFLAG;
   DECLARE_INTARRAY( S2_iPhone_XML_Processor_v1_0_0, __DIGITALQUEUE );
   DECLARE_INTARRAY( S2_iPhone_XML_Processor_v1_0_0, __ANALOGQUEUE );
   DECLARE_INTARRAY( S2_iPhone_XML_Processor_v1_0_0, __SERIALQUEUE );
   DECLARE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __PASSCODE$ );
   DECLARE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __PROJECT$ );
   DECLARE_STRING_ARRAY( S2_iPhone_XML_Processor_v1_0_0, __STR2XML );
   DECLARE_STRING_STRUCT( S2_iPhone_XML_Processor_v1_0_0, __XML_IN );
};

START_NVRAM_VAR_STRUCT( S2_iPhone_XML_Processor_v1_0_0 )
{
};



#endif //__S2_IPHONE_XML_PROCESSOR_V1_0_0_H__

