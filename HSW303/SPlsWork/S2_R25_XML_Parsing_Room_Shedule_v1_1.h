#ifndef __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_1_H__
#define __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_1_H__



/*
* STRUCTURE S2_R25_XML_Parsing_Room_Shedule_v1_1__CLASS
*/
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_TITLE_STRING_MAX_LEN 100
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_STARTTIME_STRING_MAX_LEN 16
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_ENDTIME_STRING_MAX_LEN 16
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_DESCRIPTION_STRING_MAX_LEN 300
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_DISPLAY_STRING_MAX_LEN 100
#define CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_CAPTURETIMES_STRING_MAX_LEN 100
START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS )
{
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__TITLE, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_TITLE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__TITLE );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__STARTTIME, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_STARTTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__STARTTIME );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__ENDTIME, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_ENDTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__ENDTIME );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__DESCRIPTION, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_DESCRIPTION_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__DESCRIPTION );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__DISPLAY, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_DISPLAY_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__DISPLAY );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__CAPTURETIMES, CLASS__S2_R25_XML_Parsing_Room_Shedule_v1_1_CAPTURETIMES_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS__CAPTURETIMES );
};


/*
* Constructor and Destructor
*/
int S2_R25_XML_Parsing_Room_Shedule_v1_1_CLASS_Constructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS ) * me, int nVerbose );
int S2_R25_XML_Parsing_Room_Shedule_v1_1_CLASS_Destructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_1, CLASS ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_SENDSCHEDULEQUERY_DIG_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_LOGIN_R25_DIG_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_LOGOUT_R25_DIG_INPUT 2


/*
* ANALOG_INPUT
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_ROOMSCHEDULEQUERY_STRING_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_ROOMSCHEDULEQUERY_STRING_MAX_LEN 512
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __ROOMSCHEDULEQUERY, __S2_R25_XML_Parsing_Room_Shedule_v1_1_ROOMSCHEDULEQUERY_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_HOSTNAME_STRING_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_HOSTNAME_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __HOSTNAME, __S2_R25_XML_Parsing_Room_Shedule_v1_1_HOSTNAME_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_PORT_STRING_INPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_PORT_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __PORT, __S2_R25_XML_Parsing_Room_Shedule_v1_1_PORT_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TIME_O_DAY_STRING_INPUT 3
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TIME_O_DAY_STRING_MAX_LEN 18
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __TIME_O_DAY, __S2_R25_XML_Parsing_Room_Shedule_v1_1_TIME_O_DAY_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CONNECTED_FB_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTTITLE_STRING_OUTPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTSTARTTIME_STRING_OUTPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTENDTIME_STRING_OUTPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTDESCRIPTION_STRING_OUTPUT 3
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTDISPLAY_STRING_OUTPUT 4
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTCAPTURETIMES_STRING_OUTPUT 5

#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TITLE_STRING_OUTPUT 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TITLE_ARRAY_LENGTH 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_STARTTIME_STRING_OUTPUT 12
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_STARTTIME_ARRAY_LENGTH 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_ENDTIME_STRING_OUTPUT 18
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_ENDTIME_ARRAY_LENGTH 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_DESCRIPTION_STRING_OUTPUT 24
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_DESCRIPTION_ARRAY_LENGTH 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_DISPLAY_STRING_OUTPUT 30
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_DISPLAY_ARRAY_LENGTH 6
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CAPTURETIMES_STRING_OUTPUT 36
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CAPTURETIMES_ARRAY_LENGTH 12

/*
* Direct Socket Variables
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TCPTXRX_SOCKET 4
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_TCPTXRX_STRING_MAX_LEN 4096
START_SOCKET_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_1, __TCPTXRX )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_R25_XML_Parsing_Room_Shedule_v1_1, SocketRxBuf, __S2_R25_XML_Parsing_Room_Shedule_v1_1_TCPTXRX_STRING_MAX_LEN );
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
#define __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTCLASS_STRUCT_MAX_LEN 7
CREATE_STRUCTURE_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_1, __CURRENTCLASS, CLASS, __S2_R25_XML_Parsing_Room_Shedule_v1_1_CURRENTCLASS_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __TITLE );
   DECLARE_IO_ARRAY( __STARTTIME );
   DECLARE_IO_ARRAY( __ENDTIME );
   DECLARE_IO_ARRAY( __DESCRIPTION );
   DECLARE_IO_ARRAY( __DISPLAY );
   DECLARE_IO_ARRAY( __CAPTURETIMES );
   unsigned short __I;
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __ROOMSCHEDULEQUERY );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __HOSTNAME );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __PORT );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1, __TIME_O_DAY );
   DECLARE_SOCKET( S2_R25_XML_Parsing_Room_Shedule_v1_1, __TCPTXRX );
   DECLARE_STRUCT_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_1, __CURRENTCLASS );
};

START_NVRAM_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_1 )
{
};



#endif //__S2_R25_XML_PARSING_ROOM_SHEDULE_V1_1_H__

