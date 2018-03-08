#ifndef __S2_ROOMVIEWMSG_H__
#define __S2_ROOMVIEWMSG_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_RoomViewMsg_SEND_DIG_INPUT 0
#define __S2_RoomViewMsg_CLEAR_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_RoomViewMsg_SEVERITY_ANALOG_INPUT 0

#define __S2_RoomViewMsg_MSG_STRING_INPUT 1
#define __S2_RoomViewMsg_MSG_STRING_MAX_LEN 245
CREATE_STRING_STRUCT( S2_RoomViewMsg, __MSG, __S2_RoomViewMsg_MSG_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_RoomViewMsg_FORMATTEDMSG_STRING_OUTPUT 0


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
#define __S2_RoomViewMsg_SAVEDMSG_STRING_MAX_LEN 255
CREATE_STRING_STRUCT( S2_RoomViewMsg, __SAVEDMSG, __S2_RoomViewMsg_SAVEDMSG_STRING_MAX_LEN );
#define __S2_RoomViewMsg_PREFIX_ARRAY_NUM_ELEMS 5
#define __S2_RoomViewMsg_PREFIX_ARRAY_NUM_CHARS 255
CREATE_STRING_ARRAY( S2_RoomViewMsg, __PREFIX, __S2_RoomViewMsg_PREFIX_ARRAY_NUM_ELEMS, __S2_RoomViewMsg_PREFIX_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_RoomViewMsg )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_RoomViewMsg, __MSG );
};

START_NVRAM_VAR_STRUCT( S2_RoomViewMsg )
{
   DECLARE_STRING_STRUCT( S2_RoomViewMsg, __SAVEDMSG );
   DECLARE_STRING_ARRAY( S2_RoomViewMsg, __PREFIX );
   unsigned short __SAVEDSEVERITY;
};



#endif //__S2_ROOMVIEWMSG_H__

