#ifndef __S2_R25_XML_FORMATTED_TIME_H__
#define __S2_R25_XML_FORMATTED_TIME_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/

#define __S2_R25_XML_Formatted_Time_SERIALIZED_TIME_STRING_INPUT 0
#define __S2_R25_XML_Formatted_Time_SERIALIZED_TIME_STRING_MAX_LEN 8
CREATE_STRING_STRUCT( S2_R25_XML_Formatted_Time, __SERIALIZED_TIME, __S2_R25_XML_Formatted_Time_SERIALIZED_TIME_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_R25_XML_Formatted_Time_XML_FORMATTED_TIME_STRING_OUTPUT 0


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

START_GLOBAL_VAR_STRUCT( S2_R25_XML_Formatted_Time )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_R25_XML_Formatted_Time, __SERIALIZED_TIME );
};

START_NVRAM_VAR_STRUCT( S2_R25_XML_Formatted_Time )
{
};



#endif //__S2_R25_XML_FORMATTED_TIME_H__

