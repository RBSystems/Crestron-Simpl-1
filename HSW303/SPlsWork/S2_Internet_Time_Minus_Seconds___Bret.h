#ifndef __S2_INTERNET_TIME_MINUS_SECONDS___BRET_H__
#define __S2_INTERNET_TIME_MINUS_SECONDS___BRET_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/

#define __S2_Internet_Time_Minus_Seconds___Bret_TIMEFROMNAVY_STRING_INPUT 0
#define __S2_Internet_Time_Minus_Seconds___Bret_TIMEFROMNAVY_STRING_MAX_LEN 2048
CREATE_STRING_STRUCT( S2_Internet_Time_Minus_Seconds___Bret, __TIMEFROMNAVY, __S2_Internet_Time_Minus_Seconds___Bret_TIMEFROMNAVY_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Internet_Time_Minus_Seconds___Bret_OUTPUTTIME_STRING_OUTPUT 0
#define __S2_Internet_Time_Minus_Seconds___Bret_TIMEONLY_STRING_OUTPUT 1


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

START_GLOBAL_VAR_STRUCT( S2_Internet_Time_Minus_Seconds___Bret )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __SEMAPHORE;
   DECLARE_STRING_STRUCT( S2_Internet_Time_Minus_Seconds___Bret, __TIMEFROMNAVY );
};

START_NVRAM_VAR_STRUCT( S2_Internet_Time_Minus_Seconds___Bret )
{
};



#endif //__S2_INTERNET_TIME_MINUS_SECONDS___BRET_H__

