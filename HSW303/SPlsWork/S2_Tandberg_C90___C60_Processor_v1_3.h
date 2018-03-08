#ifndef __S2_TANDBERG_C90___C60_PROCESSOR_V1_3_H__
#define __S2_TANDBERG_C90___C60_PROCESSOR_V1_3_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETLOCALPHONEBOOK_DIG_INPUT 0
#define __S2_Tandberg_C90___C60_Processor_v1_3_CLEARSELECTEDENTRYNUMBER_DIG_INPUT 1
#define __S2_Tandberg_C90___C60_Processor_v1_3_DIALSELECTEDPHONEBOOKENTRYNUMBER_DIG_INPUT 2
#define __S2_Tandberg_C90___C60_Processor_v1_3_UPONELEVEL_DIG_INPUT 3
#define __S2_Tandberg_C90___C60_Processor_v1_3_SEARCHPHONEBOOK_DIG_INPUT 4


/*
* ANALOG_INPUT
*/
#define __S2_Tandberg_C90___C60_Processor_v1_3_ENTRYOFFSET_ANALOG_INPUT 0
#define __S2_Tandberg_C90___C60_Processor_v1_3_ENTRIESPERPAGE_ANALOG_INPUT 1
#define __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDENTRYNUMBER_ANALOG_INPUT 3
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKSOURCEID_ANALOG_INPUT 4
#define __S2_Tandberg_C90___C60_Processor_v1_3_SETVOLUMELEVEL_ANALOG_INPUT 5

#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKSEARCHSTRING_STRING_INPUT 6
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKSEARCHSTRING_STRING_MAX_LEN 82
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __PHONEBOOKSEARCHSTRING, __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKSEARCHSTRING_STRING_MAX_LEN );

#define __S2_Tandberg_C90___C60_Processor_v1_3_DEVICE_RX$_BUFFER_INPUT 2
#define __S2_Tandberg_C90___C60_Processor_v1_3_DEVICE_RX$_BUFFER_MAX_LEN 20000
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __DEVICE_RX$, __S2_Tandberg_C90___C60_Processor_v1_3_DEVICE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_ALERT_ISACTIVE_DIG_OUTPUT 0
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_ISACTIVE_DIG_OUTPUT 1
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION1_ISACTIVE_DIG_OUTPUT 2
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION2_ISACTIVE_DIG_OUTPUT 3
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION3_ISACTIVE_DIG_OUTPUT 4
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION4_ISACTIVE_DIG_OUTPUT 5
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION5_ISACTIVE_DIG_OUTPUT 6
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION1_WASSELECTED_DIG_OUTPUT 7
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION2_WASSELECTED_DIG_OUTPUT 8
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION3_WASSELECTED_DIG_OUTPUT 9
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION4_WASSELECTED_DIG_OUTPUT 10
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION5_WASSELECTED_DIG_OUTPUT 11
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_SEARCHRESULT_IS_FROM_SUBFOLDER_DIG_OUTPUT 12
#define __S2_Tandberg_C90___C60_Processor_v1_3_SEARCHISACTIVE_DIG_OUTPUT 13

#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_ISFOLDER_DIG_OUTPUT 14
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_ISFOLDER_ARRAY_LENGTH 20

/*
* ANALOG_OUTPUT
*/
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETVOLUMELEVEL_ANALOG_OUTPUT 5
#define __S2_Tandberg_C90___C60_Processor_v1_3_CURRENTFIRSTPHONEBOOKITEMNUMBER_ANALOG_OUTPUT 26
#define __S2_Tandberg_C90___C60_Processor_v1_3_CURRENTLASTPHONEBOOKITEMNUMBER_ANALOG_OUTPUT 27
#define __S2_Tandberg_C90___C60_Processor_v1_3_TOTALROWSFORSEARCH_ANALOG_OUTPUT 29

#define __S2_Tandberg_C90___C60_Processor_v1_3_DEVICE_TX$_STRING_OUTPUT 0
#define __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDPHONEBOOK_NAME_STRING_OUTPUT 1
#define __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDPHONEBOOK_NUMBER_STRING_OUTPUT 2
#define __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDPHONEBOOK_CALLRATE_STRING_OUTPUT 3
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_SEARCH_TEXT_STRING_OUTPUT 4
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEMNAME_STRING_OUTPUT 6
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEMNETWORKADDRESS_STRING_OUTPUT 7
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETGATEKEEPERSTATUS_STRING_OUTPUT 8
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETGATEKEEPERREGISTRATIONMODE_STRING_OUTPUT 9
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETGATEKEEPERNETWORKADDRESS_STRING_OUTPUT 10
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEMH323ID_STRING_OUTPUT 11
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEME164ALIAS_STRING_OUTPUT 12
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEMSIPURI_STRING_OUTPUT 13
#define __S2_Tandberg_C90___C60_Processor_v1_3_GETSYSTEMSOFTWAREVERSION_STRING_OUTPUT 14
#define __S2_Tandberg_C90___C60_Processor_v1_3_FROM_DEVICE_CONFIGURATIONCHANGES_STRING_OUTPUT 15
#define __S2_Tandberg_C90___C60_Processor_v1_3_FROM_DEVICE_STATUSCHANGES_STRING_OUTPUT 16
#define __S2_Tandberg_C90___C60_Processor_v1_3_FROM_DEVICE_OTHERCHANGES_STRING_OUTPUT 17
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_ALERT_TEXT_STRING_OUTPUT 18
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_TITLE_STRING_OUTPUT 19
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_TEXT_STRING_OUTPUT 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION1_TEXT_STRING_OUTPUT 21
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION2_TEXT_STRING_OUTPUT 22
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION3_TEXT_STRING_OUTPUT 23
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION4_TEXT_STRING_OUTPUT 24
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_OPTION5_TEXT_STRING_OUTPUT 25
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_SELECTED_FOLDER_NAME_STRING_OUTPUT 28

#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_NAME_STRING_OUTPUT 30
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOK_NAME_ARRAY_LENGTH 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INPUT_SOURCE_NAME_STRING_OUTPUT 50
#define __S2_Tandberg_C90___C60_Processor_v1_3_INPUT_SOURCE_NAME_ARRAY_LENGTH 5

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
CREATE_INTARRAY1D( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_ID, 20 );;
CREATE_INTARRAY1D( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_ISFOLDER, 20 );;


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
#define __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDFOLDERID_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __SELECTEDFOLDERID, __S2_Tandberg_C90___C60_Processor_v1_3_SELECTEDFOLDERID_STRING_MAX_LEN );
#define __S2_Tandberg_C90___C60_Processor_v1_3_TEMPSTRING$_STRING_MAX_LEN 3000
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __TEMPSTRING$, __S2_Tandberg_C90___C60_Processor_v1_3_TEMPSTRING$_STRING_MAX_LEN );
#define __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKENTRYTYPE_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __PHONEBOOKENTRYTYPE, __S2_Tandberg_C90___C60_Processor_v1_3_PHONEBOOKENTRYTYPE_STRING_MAX_LEN );
#define __S2_Tandberg_C90___C60_Processor_v1_3_SSEARCHTEXT_STRING_MAX_LEN 82
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __SSEARCHTEXT, __S2_Tandberg_C90___C60_Processor_v1_3_SSEARCHTEXT_STRING_MAX_LEN );
#define __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_FEEDBACKID_STRING_MAX_LEN 255
CREATE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __MESSAGE_PROMPT_FEEDBACKID, __S2_Tandberg_C90___C60_Processor_v1_3_MESSAGE_PROMPT_FEEDBACKID_STRING_MAX_LEN );
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_FOLDERID_ARRAY_NUM_ELEMS 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_FOLDERID_ARRAY_NUM_CHARS 40
CREATE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_FOLDERID, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_FOLDERID_ARRAY_NUM_ELEMS, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_FOLDERID_ARRAY_NUM_CHARS );
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NAME_ARRAY_NUM_ELEMS 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NAME_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_NAME, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NAME_ARRAY_NUM_ELEMS, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NAME_ARRAY_NUM_CHARS );
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NUMBER_ARRAY_NUM_ELEMS 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NUMBER_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_NUMBER, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NUMBER_ARRAY_NUM_ELEMS, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_NUMBER_ARRAY_NUM_CHARS );
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CALLRATE_ARRAY_NUM_ELEMS 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CALLRATE_ARRAY_NUM_CHARS 20
CREATE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_CALLRATE, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CALLRATE_ARRAY_NUM_ELEMS, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CALLRATE_ARRAY_NUM_CHARS );
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CONTACTID_ARRAY_NUM_ELEMS 20
#define __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CONTACTID_ARRAY_NUM_CHARS 40
CREATE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_CONTACTID, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CONTACTID_ARRAY_NUM_ELEMS, __S2_Tandberg_C90___C60_Processor_v1_3_INTERNALPHONEBOOKCACHE_CONTACTID_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __PHONEBOOK_ISFOLDER );
   DECLARE_IO_ARRAY( __PHONEBOOK_NAME );
   DECLARE_IO_ARRAY( __INPUT_SOURCE_NAME );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __PHONEBOOKSEARCHSTRING );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __DEVICE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3 )
{
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __SELECTEDFOLDERID );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __TEMPSTRING$ );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __PHONEBOOKENTRYTYPE );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __SSEARCHTEXT );
   DECLARE_STRING_STRUCT( S2_Tandberg_C90___C60_Processor_v1_3, __MESSAGE_PROMPT_FEEDBACKID );
   DECLARE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_FOLDERID );
   DECLARE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_NAME );
   DECLARE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_NUMBER );
   DECLARE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_CALLRATE );
   DECLARE_STRING_ARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_CONTACTID );
   unsigned short __SEMAPHORE;
   unsigned short __PREVIOUSFOUNDCONTACTITEM;
   unsigned short __NEXTAVAILABLEDIRENTRY;
   unsigned short __INTERNALENTRYOFFSET;
   unsigned short __NUMBER;
   unsigned short __PARAMATER;
   unsigned short __LEVEL;
   unsigned short __INTERNALPHONEBOOKFIRST_ID;
   unsigned short __INTERNALPHONEBOOKLAST_ID;
   unsigned short __CONTACTITEM;
   unsigned short __ENTITYID;
   unsigned short __TMP;
   DECLARE_INTARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_ID );
   DECLARE_INTARRAY( S2_Tandberg_C90___C60_Processor_v1_3, __INTERNALPHONEBOOKCACHE_ISFOLDER );
};



#endif //__S2_TANDBERG_C90___C60_PROCESSOR_V1_3_H__

