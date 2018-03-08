#ifndef __S2_CAMIDJ_RAM_V1_H__
#define __S2_CAMIDJ_RAM_V1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_CamiDJ_Ram_v1_STORE_DIG_INPUT 0


/*
* ANALOG_INPUT
*/



#define __S2_CamiDJ_Ram_v1_SPEED_ANALOG_INPUT 0
#define __S2_CamiDJ_Ram_v1_SPEED_ARRAY_LENGTH 12

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/


#define __S2_CamiDJ_Ram_v1_STORED_SPEED_ANALOG_OUTPUT 0
#define __S2_CamiDJ_Ram_v1_STORED_SPEED_ARRAY_LENGTH 12

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
CREATE_INTARRAY1D( S2_CamiDJ_Ram_v1, __ISPEED, 12 );;


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

START_GLOBAL_VAR_STRUCT( S2_CamiDJ_Ram_v1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SPEED );
   DECLARE_IO_ARRAY( __STORED_SPEED );
};

START_NVRAM_VAR_STRUCT( S2_CamiDJ_Ram_v1 )
{
   unsigned short __ILASTMODIFIEDINDEX;
   DECLARE_INTARRAY( S2_CamiDJ_Ram_v1, __ISPEED );
};



#endif //__S2_CAMIDJ_RAM_V1_H__

