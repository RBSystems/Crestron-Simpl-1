#ifndef __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_4_H__
#define __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_4_H__



/*
* STRUCTURE S2_R25_XML_Parsing_Room_Shedule_v1_4__CLASSTIMES
*/
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_TITLE_STRING_MAX_LEN 60
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_STARTTIME_STRING_MAX_LEN 16
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_ENDTIME_STRING_MAX_LEN 16
START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES )
{
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__TITLE, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_TITLE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__TITLE );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__STARTTIME, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_STARTTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__STARTTIME );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__ENDTIME, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_4_ENDTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES__ENDTIME );
};


/*
* Constructor and Destructor
*/
int S2_R25_XML_Parsing_Room_Shedule_v1_4_CLASSTIMES_Constructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES ) * me, int nVerbose );
int S2_R25_XML_Parsing_Room_Shedule_v1_4_CLASSTIMES_Destructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_4, CLASSTIMES ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_SENDSCHEDULEQUERY_DIG_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_LOGIN_R25_DIG_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_LOGOUT_R25_DIG_INPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CLEARYESTERDAY_DIG_INPUT 3


/*
* ANALOG_INPUT
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_ROOMSCHEDULEQUERY_STRING_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_ROOMSCHEDULEQUERY_STRING_MAX_LEN 512
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __ROOMSCHEDULEQUERY, __S2_R25_XML_Parsing_Room_Shedule_v1_4_ROOMSCHEDULEQUERY_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_HOSTNAME_STRING_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_HOSTNAME_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __HOSTNAME, __S2_R25_XML_Parsing_Room_Shedule_v1_4_HOSTNAME_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_PORT_STRING_INPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_PORT_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __PORT, __S2_R25_XML_Parsing_Room_Shedule_v1_4_PORT_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TIME_O_DAY_STRING_INPUT 3
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TIME_O_DAY_STRING_MAX_LEN 18
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __TIME_O_DAY, __S2_R25_XML_Parsing_Room_Shedule_v1_4_TIME_O_DAY_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CONNECTED_FB_DIG_OUTPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TURN_PROJ_OFF_DELAY30_DIG_OUTPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TURN_TO_HOMEPAGE_DIG_OUTPUT 2


/*
* ANALOG_OUTPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_SOCKETRETURN_ANALOG_OUTPUT 0

#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CURRENTTITLE_STRING_OUTPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CURRENTSTARTTIME_STRING_OUTPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CURRENTENDTIME_STRING_OUTPUT 3


/*
* Direct Socket Variables
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TCPTXRX_SOCKET 4
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_TCPTXRX_STRING_MAX_LEN 4096
START_SOCKET_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_4, __TCPTXRX )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_R25_XML_Parsing_Room_Shedule_v1_4, SocketRxBuf, __S2_R25_XML_Parsing_Room_Shedule_v1_4_TCPTXRX_STRING_MAX_LEN );
};



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
CREATE_INTARRAY1D( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CLASSENDTIME, 10 );;
CREATE_INTARRAY1D( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CLASSNEXTSTARTTIME, 10 );;


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
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_PROJ_OFF_TIME_ARRAY_NUM_ELEMS 10
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_PROJ_OFF_TIME_ARRAY_NUM_CHARS 8
CREATE_STRING_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __PROJ_OFF_TIME, __S2_R25_XML_Parsing_Room_Shedule_v1_4_PROJ_OFF_TIME_ARRAY_NUM_ELEMS, __S2_R25_XML_Parsing_Room_Shedule_v1_4_PROJ_OFF_TIME_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_4_CURRENTCLASS_STRUCT_MAX_LEN 10
CREATE_STRUCTURE_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CURRENTCLASS, CLASSTIMES, __S2_R25_XML_Parsing_Room_Shedule_v1_4_CURRENTCLASS_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __I;
   DECLARE_INTARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CLASSENDTIME );
   DECLARE_INTARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CLASSNEXTSTARTTIME );
   DECLARE_STRING_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __PROJ_OFF_TIME );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __ROOMSCHEDULEQUERY );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __HOSTNAME );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __PORT );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4, __TIME_O_DAY );
   DECLARE_SOCKET( S2_R25_XML_Parsing_Room_Shedule_v1_4, __TCPTXRX );
   DECLARE_STRUCT_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_4, __CURRENTCLASS );
};

START_NVRAM_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_4 )
{
};



#endif //__S2_R25_XML_PARSING_ROOM_SHEDULE_V1_4_H__

