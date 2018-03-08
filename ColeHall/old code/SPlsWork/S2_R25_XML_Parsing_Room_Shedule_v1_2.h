#ifndef __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_2_H__
#define __S2_R25_XML_PARSING_ROOM_SHEDULE_V1_2_H__



/*
* STRUCTURE S2_R25_XML_Parsing_Room_Shedule_v1_2__CLASSTIMES
*/
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_TITLE_STRING_MAX_LEN 100
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_STARTTIME_STRING_MAX_LEN 16
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_ENDTIME_STRING_MAX_LEN 16
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_DESCRIPTION_STRING_MAX_LEN 150
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_DISPLAY_STRING_MAX_LEN 100
#define CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_CAPTURETIMES_STRING_MAX_LEN 150
START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES )
{
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__TITLE, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_TITLE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__TITLE );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__STARTTIME, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_STARTTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__STARTTIME );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__ENDTIME, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_ENDTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__ENDTIME );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__DESCRIPTION, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_DESCRIPTION_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__DESCRIPTION );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__DISPLAY, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_DISPLAY_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__DISPLAY );
   CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__CAPTURETIMES, CLASSTIMES__S2_R25_XML_Parsing_Room_Shedule_v1_2_CAPTURETIMES_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES__CAPTURETIMES );
};


/*
* Constructor and Destructor
*/
int S2_R25_XML_Parsing_Room_Shedule_v1_2_CLASSTIMES_Constructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES ) * me, int nVerbose );
int S2_R25_XML_Parsing_Room_Shedule_v1_2_CLASSTIMES_Destructor ( START_STRUCTURE_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_2, CLASSTIMES ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_SENDSCHEDULEQUERY_DIG_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_LOGIN_R25_DIG_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_LOGOUT_R25_DIG_INPUT 2


/*
* ANALOG_INPUT
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_ROOMSCHEDULEQUERY_STRING_INPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_ROOMSCHEDULEQUERY_STRING_MAX_LEN 512
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __ROOMSCHEDULEQUERY, __S2_R25_XML_Parsing_Room_Shedule_v1_2_ROOMSCHEDULEQUERY_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_HOSTNAME_STRING_INPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_HOSTNAME_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __HOSTNAME, __S2_R25_XML_Parsing_Room_Shedule_v1_2_HOSTNAME_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_PORT_STRING_INPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_PORT_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __PORT, __S2_R25_XML_Parsing_Room_Shedule_v1_2_PORT_STRING_MAX_LEN );
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_TIME_O_DAY_STRING_INPUT 3
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_TIME_O_DAY_STRING_MAX_LEN 18
CREATE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __TIME_O_DAY, __S2_R25_XML_Parsing_Room_Shedule_v1_2_TIME_O_DAY_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CONNECTED_FB_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTTITLE_STRING_OUTPUT 0
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTSTARTTIME_STRING_OUTPUT 1
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTENDTIME_STRING_OUTPUT 2
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTDESCRIPTION_STRING_OUTPUT 3
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTDISPLAY_STRING_OUTPUT 4
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTCAPTURETIMES_STRING_OUTPUT 5


/*
* Direct Socket Variables
*/

#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_TCPTXRX_SOCKET 4
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_TCPTXRX_STRING_MAX_LEN 4096
START_SOCKET_DEFINITION( S2_R25_XML_Parsing_Room_Shedule_v1_2, __TCPTXRX )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_R25_XML_Parsing_Room_Shedule_v1_2, SocketRxBuf, __S2_R25_XML_Parsing_Room_Shedule_v1_2_TCPTXRX_STRING_MAX_LEN );
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
#define __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTCLASS_STRUCT_MAX_LEN 8
CREATE_STRUCTURE_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_2, __CURRENTCLASS, CLASSTIMES, __S2_R25_XML_Parsing_Room_Shedule_v1_2_CURRENTCLASS_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __I;
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __ROOMSCHEDULEQUERY );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __HOSTNAME );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __PORT );
   DECLARE_STRING_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2, __TIME_O_DAY );
   DECLARE_SOCKET( S2_R25_XML_Parsing_Room_Shedule_v1_2, __TCPTXRX );
   DECLARE_STRUCT_ARRAY( S2_R25_XML_Parsing_Room_Shedule_v1_2, __CURRENTCLASS );
};

START_NVRAM_VAR_STRUCT( S2_R25_XML_Parsing_Room_Shedule_v1_2 )
{
};



#endif //__S2_R25_XML_PARSING_ROOM_SHEDULE_V1_2_H__

