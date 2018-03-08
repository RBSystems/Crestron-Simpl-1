#ifndef __S2_GENERIC_DIALER_H__
#define __S2_GENERIC_DIALER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Generic_Dialer_SELECT_NUM_1_DIG_INPUT 0
#define __S2_Generic_Dialer_SELECT_NUM_2_DIG_INPUT 1
#define __S2_Generic_Dialer_SELECT_DIRECTORY_DIG_INPUT 2
#define __S2_Generic_Dialer_SELECT_NONE_DIG_INPUT 3
#define __S2_Generic_Dialer_CLEAR_NUM_1_NUM_2_DIG_INPUT 4
#define __S2_Generic_Dialer_COPY_NUM_1_TO_NUM_2_DIG_INPUT 5
#define __S2_Generic_Dialer_DIAL_DIG_INPUT 6


/*
* ANALOG_INPUT
*/
#define __S2_Generic_Dialer_MAX_PHONE_NUMBER_CHARACTERS_ANALOG_INPUT 0

#define __S2_Generic_Dialer_HEADER$_STRING_INPUT 1
#define __S2_Generic_Dialer_HEADER$_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Generic_Dialer, __HEADER$, __S2_Generic_Dialer_HEADER$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_NUMBER_SEPARATER$_STRING_INPUT 2
#define __S2_Generic_Dialer_NUMBER_SEPARATER$_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Generic_Dialer, __NUMBER_SEPARATER$, __S2_Generic_Dialer_NUMBER_SEPARATER$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_FOOTER$_STRING_INPUT 3
#define __S2_Generic_Dialer_FOOTER$_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Generic_Dialer, __FOOTER$, __S2_Generic_Dialer_FOOTER$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_NUM_1$_STRING_INPUT 4
#define __S2_Generic_Dialer_NUM_1$_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Generic_Dialer, __NUM_1$, __S2_Generic_Dialer_NUM_1$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_NUM_2$_STRING_INPUT 5
#define __S2_Generic_Dialer_NUM_2$_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Generic_Dialer, __NUM_2$, __S2_Generic_Dialer_NUM_2$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_DIRECTORY_NAME$_STRING_INPUT 6
#define __S2_Generic_Dialer_DIRECTORY_NAME$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Generic_Dialer, __DIRECTORY_NAME$, __S2_Generic_Dialer_DIRECTORY_NAME$_STRING_MAX_LEN );
#define __S2_Generic_Dialer_TEXT$_STRING_INPUT 7
#define __S2_Generic_Dialer_TEXT$_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Generic_Dialer, __TEXT$, __S2_Generic_Dialer_TEXT$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Generic_Dialer_NUM_1_FB$_STRING_OUTPUT 0
#define __S2_Generic_Dialer_NUM_2_FB$_STRING_OUTPUT 1
#define __S2_Generic_Dialer_DIRECTORY_NAME_FB$_STRING_OUTPUT 2
#define __S2_Generic_Dialer_TEXT_FB$_STRING_OUTPUT 3
#define __S2_Generic_Dialer_TO_DEVICE$_STRING_OUTPUT 4


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
#define __S2_Generic_Dialer_SNUM1_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SNUM1, __S2_Generic_Dialer_SNUM1_STRING_MAX_LEN );
#define __S2_Generic_Dialer_SNUM2_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SNUM2, __S2_Generic_Dialer_SNUM2_STRING_MAX_LEN );
#define __S2_Generic_Dialer_SHEADER_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SHEADER, __S2_Generic_Dialer_SHEADER_STRING_MAX_LEN );
#define __S2_Generic_Dialer_SFOOTER_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SFOOTER, __S2_Generic_Dialer_SFOOTER_STRING_MAX_LEN );
#define __S2_Generic_Dialer_SSEPARATER_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SSEPARATER, __S2_Generic_Dialer_SSEPARATER_STRING_MAX_LEN );
#define __S2_Generic_Dialer_SDIRECTORYNAME_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Generic_Dialer, __SDIRECTORYNAME, __S2_Generic_Dialer_SDIRECTORYNAME_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Generic_Dialer )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __HEADER$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __NUMBER_SEPARATER$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __FOOTER$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __NUM_1$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __NUM_2$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __DIRECTORY_NAME$ );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __TEXT$ );
};

START_NVRAM_VAR_STRUCT( S2_Generic_Dialer )
{
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SNUM1 );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SNUM2 );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SHEADER );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SFOOTER );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SSEPARATER );
   DECLARE_STRING_STRUCT( S2_Generic_Dialer, __SDIRECTORYNAME );
   unsigned short __IMAXCHARS;
   unsigned short __IFLAG2;
   unsigned short __IINCOMINGTEXT;
};



#endif //__S2_GENERIC_DIALER_H__

