#ifndef __S2_SONY_ZOOM_PROCESSOR_3_H__
#define __S2_SONY_ZOOM_PROCESSOR_3_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Sony_Zoom_Processor_3_CHECKZOOM_DIG_INPUT 0
#define __S2_Sony_Zoom_Processor_3_EVI_D30_DIG_INPUT 1
#define __S2_Sony_Zoom_Processor_3_EVI_D70_DIG_INPUT 2
#define __S2_Sony_Zoom_Processor_3_EVI_D100_DIG_INPUT 3


/*
* ANALOG_INPUT
*/
#define __S2_Sony_Zoom_Processor_3_ADDRESS_ANALOG_INPUT 0

#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_1_STRING_INPUT 1
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_1, __S2_Sony_Zoom_Processor_3_PAN_SPEED_1_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_2_STRING_INPUT 2
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_2, __S2_Sony_Zoom_Processor_3_PAN_SPEED_2_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_3_STRING_INPUT 3
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_3_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_3, __S2_Sony_Zoom_Processor_3_PAN_SPEED_3_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_1_STRING_INPUT 4
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TILT_SPEED_1, __S2_Sony_Zoom_Processor_3_TILT_SPEED_1_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_2_STRING_INPUT 5
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TILT_SPEED_2, __S2_Sony_Zoom_Processor_3_TILT_SPEED_2_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_1_STRING_INPUT 6
#define __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __ZOOM_SPEED_1, __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_1_STRING_MAX_LEN );
#define __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_2_STRING_INPUT 7
#define __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __ZOOM_SPEED_2, __S2_Sony_Zoom_Processor_3_ZOOM_SPEED_2_STRING_MAX_LEN );

#define __S2_Sony_Zoom_Processor_3_FROMDEVICE$_BUFFER_INPUT 8
#define __S2_Sony_Zoom_Processor_3_FROMDEVICE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __FROMDEVICE$, __S2_Sony_Zoom_Processor_3_FROMDEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Sony_Zoom_Processor_3_ZOOMIN_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Sony_Zoom_Processor_3_ZOOMSCALE_ANALOG_OUTPUT 0
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_1_OUT_ANALOG_OUTPUT 1
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_2_OUT_ANALOG_OUTPUT 2
#define __S2_Sony_Zoom_Processor_3_PAN_SPEED_3_OUT_ANALOG_OUTPUT 3
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_1_OUT_ANALOG_OUTPUT 4
#define __S2_Sony_Zoom_Processor_3_TILT_SPEED_2_OUT_ANALOG_OUTPUT 5
#define __S2_Sony_Zoom_Processor_3_ZOOM_IN_SPEED_1_OUT_ANALOG_OUTPUT 6
#define __S2_Sony_Zoom_Processor_3_ZOOM_IN_SPEED_2_OUT_ANALOG_OUTPUT 7
#define __S2_Sony_Zoom_Processor_3_ZOOM_OUT_SPEED_1_OUT_ANALOG_OUTPUT 8
#define __S2_Sony_Zoom_Processor_3_ZOOM_OUT_SPEED_2_OUT_ANALOG_OUTPUT 9

#define __S2_Sony_Zoom_Processor_3_TODEVICE$_STRING_OUTPUT 10


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

CREATE_INTARRAY2D( S2_Sony_Zoom_Processor_3, __IPANSPEED, 3, 3 );;
CREATE_INTARRAY2D( S2_Sony_Zoom_Processor_3, __ITILTSPEED, 2, 3 );;
CREATE_INTARRAY2D( S2_Sony_Zoom_Processor_3, __IZOOMINSPEED, 2, 3 );;
CREATE_INTARRAY2D( S2_Sony_Zoom_Processor_3, __IZOOMOUTSPEED, 2, 3 );;

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
#define __S2_Sony_Zoom_Processor_3_TEMPSTRING$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TEMPSTRING$, __S2_Sony_Zoom_Processor_3_TEMPSTRING$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Sony_Zoom_Processor_3 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __PAN_SPEED_3 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TILT_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TILT_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __ZOOM_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __ZOOM_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __FROMDEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Sony_Zoom_Processor_3 )
{
   DECLARE_STRING_STRUCT( S2_Sony_Zoom_Processor_3, __TEMPSTRING$ );
   unsigned short __ZOOMWAITING;
   unsigned short __SEMAPHORE;
   unsigned short __OUTHEADER;
   unsigned short __INHEADER;
   unsigned short __ICAMERA;
   DECLARE_INTARRAY( S2_Sony_Zoom_Processor_3, __IPANSPEED );
   DECLARE_INTARRAY( S2_Sony_Zoom_Processor_3, __ITILTSPEED );
   DECLARE_INTARRAY( S2_Sony_Zoom_Processor_3, __IZOOMINSPEED );
   DECLARE_INTARRAY( S2_Sony_Zoom_Processor_3, __IZOOMOUTSPEED );
};



#endif //__S2_SONY_ZOOM_PROCESSOR_3_H__

