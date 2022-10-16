using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CRM356Connector
{
    class DataAccess
    {

        public static string ConnString = string.Empty;

        #region Not in use
        #region CreateTableType
        public static void CreateTableType()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("CreateTempTables", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();


            }
        }
        #endregion

        #region LogicaNname
        public static void LogicalNames(dynamic dynObj)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table LogicalNames", conn);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < count; i++)
                {
                    cmd = new SqlCommand("LogicalNames_SP", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("Name", (string)dynObj.value[i].name);
                    cmd.Parameters.AddWithValue("Kind", (string)dynObj.value[i].kind);
                    cmd.Parameters.AddWithValue("URL", (string)dynObj.value[i].url);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

        #region Phonecall

        public static void Phonecall(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Phonecall", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("statecode");
                dt.Columns.Add("_regardingobjectid_value");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("description");
                dt.Columns.Add("leftvoicemail");
                dt.Columns.Add("createdon");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("isbilled");
                dt.Columns.Add("subject");
                dt.Columns.Add("directioncode");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("isregularactivity");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("actualstart");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("activitytypecode");
                dt.Columns.Add("isworkflowcreated");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("actualend");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("activityid");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("exchangeitemid");
                dt.Columns.Add("ismapiprivate");
                dt.Columns.Add("seriesid");
                dt.Columns.Add("deliverylastattemptedon");
                dt.Columns.Add("_sendermailboxid_value");
                dt.Columns.Add("scheduledend");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("community");
                dt.Columns.Add("sortdate");
                dt.Columns.Add("instancetypecode");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("processid");
                dt.Columns.Add("_serviceid_value");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("stageid");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("exchangeweblink");
                dt.Columns.Add("scheduleddurationminutes");
                dt.Columns.Add("senton");
                dt.Columns.Add("scheduledstart");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("postponeactivityprocessinguntil");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("deliveryprioritycode");
                dt.Columns.Add("actualdurationminutes");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("activityadditionalparams");
                dt.Columns.Add("_seda_type_value");
                dt.Columns.Add("_seda_lead_value");
                dt.Columns.Add("_seda_customer_value");
                dt.Columns.Add("seda_isinterested");
                dt.Columns.Add("phonenumber");
                dt.Columns.Add("category");
                dt.Columns.Add("seda_iscompleted");
                dt.Columns.Add("subcategory");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("_seda_event_value");
                dt.Columns.Add("subscriptionid");
                dt.Columns.Add("_seda_callreason_value");
                dt.Columns.Add("_seda_case_value");
                dt.Columns.Add("seda_issubscribedevent");
                dt.Columns.Add("_seda_contact_value");
                dt.Columns.Add("importsequencenumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["_regardingobjectid_value"] = (string)dynObj.value[i]._regardingobjectid_value;
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["leftvoicemail"] = dynObj.value[i].leftvoicemail == null ? null : Convert.ToBoolean(dynObj.value[i].leftvoicemail);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["isbilled"] = dynObj.value[i].isbilled == null ? null : Convert.ToBoolean(dynObj.value[i].isbilled);
                    _Ars["subject"] = (string)dynObj.value[i].subject;
                    _Ars["directioncode"] = dynObj.value[i].directioncode == null ? null : Convert.ToBoolean(dynObj.value[i].directioncode);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["prioritycode"] = dynObj.value[i].prioritycode == null ? null : Convert.ToInt32(dynObj.value[i].prioritycode);
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["isregularactivity"] = dynObj.value[i].isregularactivity == null ? null : Convert.ToInt32(dynObj.value[i].isregularactivity);
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["actualstart"] = (string)dynObj.value[i].actualstart;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["activitytypecode"] = (string)dynObj.value[i].activitytypecode;
                    _Ars["isworkflowcreated"] = dynObj.value[i].isworkflowcreated == null ? null : Convert.ToBoolean(dynObj.value[i].isworkflowcreated);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["actualend"] = (string)dynObj.value[i].actualend;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["activityid"] = (string)dynObj.value[i].activityid;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["exchangeitemid"] = dynObj.value[i].exchangeitemid == null ? null : Convert.ToInt32(dynObj.value[i].exchangeitemid);
                    _Ars["ismapiprivate"] = (string)dynObj.value[i].ismapiprivate;
                    _Ars["seriesid"] = dynObj.value[i].seriesid == null ? null : Convert.ToInt32(dynObj.value[i].seriesid);
                    _Ars["deliverylastattemptedon"] = (string)dynObj.value[i].deliverylastattemptedon;
                    _Ars["_sendermailboxid_value"] = (string)dynObj.value[i]._sendermailboxid_value;
                    _Ars["scheduledend"] = (string)dynObj.value[i].scheduledend;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["community"] = (string)dynObj.value[i].community;
                    _Ars["sortdate"] = (string)dynObj.value[i].sortdate;
                    _Ars["instancetypecode"] = (string)dynObj.value[i].instancetypecode;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["processid"] = dynObj.value[i].processid == null ? null : Convert.ToInt32(dynObj.value[i].processid);
                    _Ars["_serviceid_value"] = (string)dynObj.value[i]._serviceid_value;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["stageid"] = dynObj.value[i].stageid == null ? null : Convert.ToInt32(dynObj.value[i].stageid);
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["exchangeweblink"] = (string)dynObj.value[i].exchangeweblink;
                    _Ars["scheduleddurationminutes"] = (string)dynObj.value[i].scheduleddurationminutes;
                    _Ars["senton"] = (string)dynObj.value[i].senton;
                    _Ars["scheduledstart"] = (string)dynObj.value[i].scheduledstart;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["postponeactivityprocessinguntil"] = (string)dynObj.value[i].postponeactivityprocessinguntil;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["deliveryprioritycode"] = (string)dynObj.value[i].deliveryprioritycode;
                    _Ars["actualdurationminutes"] = (string)dynObj.value[i].actualdurationminutes;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["activityadditionalparams"] = (string)dynObj.value[i].activityadditionalparams;
                    _Ars["_seda_type_value"] = dynObj.value[i]._seda_type_value == null ? null : Convert.ToInt32(dynObj.value[i]._seda_type_value);
                    _Ars["_seda_lead_value"] = dynObj.value[i]._seda_lead_value == null ? null : Convert.ToInt32(dynObj.value[i]._seda_lead_value);
                    _Ars["_seda_customer_value"] = (string)dynObj.value[i]._seda_customer_value;
                    _Ars["seda_isinterested"] = dynObj.value[i].seda_isinterested == null ? null : Convert.ToInt32(dynObj.value[i].seda_isinterested);
                    _Ars["phonenumber"] = (string)dynObj.value[i].phonenumber;
                    _Ars["category"] = (string)dynObj.value[i].category;
                    _Ars["seda_iscompleted"] = dynObj.value[i].seda_iscompleted == null ? null : Convert.ToInt32(dynObj.value[i].seda_iscompleted);
                    _Ars["subcategory"] = (string)dynObj.value[i].subcategory;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["_seda_event_value"] = dynObj.value[i]._seda_event_value == null ? null : Convert.ToInt32(dynObj.value[i]._seda_event_value);
                    _Ars["subscriptionid"] = dynObj.value[i].subscriptionid == null ? null : Convert.ToInt32(dynObj.value[i].subscriptionid);
                    _Ars["_seda_callreason_value"] = (string)dynObj.value[i]._seda_callreason_value;
                    _Ars["_seda_case_value"] = dynObj.value[i]._seda_case_value == null ? null : Convert.ToInt32(dynObj.value[i]._seda_case_value);
                    _Ars["seda_issubscribedevent"] = dynObj.value[i].seda_issubscribedevent == null ? null : Convert.ToInt32(dynObj.value[i].seda_issubscribedevent);
                    _Ars["_seda_contact_value"] = dynObj.value[i]._seda_contact_value == null ? null : Convert.ToInt32(dynObj.value[i]._seda_contact_value);
                    _Ars["importsequencenumber"] = dynObj.value[i].importsequencenumber == null ? null : Convert.ToInt32(dynObj.value[i].importsequencenumber);
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Phonecall_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("PhoneTable", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Task
        public static void Task(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Task", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("statecode");
                dt.Columns.Add("_regardingobjectid_value");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("createdon");
                dt.Columns.Add("isbilled");
                dt.Columns.Add("subject");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("isregularactivity");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("activitytypecode");
                dt.Columns.Add("isworkflowcreated");
                dt.Columns.Add("seda_type");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("activityid");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("exchangeitemid");
                dt.Columns.Add("ismapiprivate");
                dt.Columns.Add("seriesid");
                dt.Columns.Add("deliverylastattemptedon");
                dt.Columns.Add("_sendermailboxid_value");
                dt.Columns.Add("scheduledend");
                dt.Columns.Add("description");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("community");
                dt.Columns.Add("sortdate");
                dt.Columns.Add("instancetypecode");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("processid");
                dt.Columns.Add("_serviceid_value");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("stageid");
                dt.Columns.Add("actualstart");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("exchangeweblink");
                dt.Columns.Add("scheduleddurationminutes");
                dt.Columns.Add("senton");
                dt.Columns.Add("scheduledstart");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("postponeactivityprocessinguntil");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("deliveryprioritycode");
                dt.Columns.Add("actualdurationminutes");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("activityadditionalparams");
                dt.Columns.Add("leftvoicemail");
                dt.Columns.Add("actualend");
                dt.Columns.Add("subscriptionid");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("subcategory");
                dt.Columns.Add("percentcomplete");
                dt.Columns.Add("crmtaskassigneduniqueid");
                dt.Columns.Add("category");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["_regardingobjectid_value"] = (string)dynObj.value[i]._regardingobjectid_value;
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["isbilled"] = dynObj.value[i].isbilled == null ? null : Convert.ToBoolean(dynObj.value[i].isbilled);
                    _Ars["subject"] = (string)dynObj.value[i].subject;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["prioritycode"] = dynObj.value[i].prioritycode == null ? null : Convert.ToInt32(dynObj.value[i].prioritycode);
                    _Ars["isregularactivity"] = dynObj.value[i].isregularactivity == null ? null : Convert.ToBoolean(dynObj.value[i].isregularactivity);
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["activitytypecode"] = (string)dynObj.value[i].activitytypecode;
                    _Ars["isworkflowcreated"] = dynObj.value[i].isworkflowcreated == null ? null : Convert.ToBoolean(dynObj.value[i].isworkflowcreated);
                    _Ars["seda_type"] = dynObj.value[i].seda_type == null ? null : Convert.ToBoolean(dynObj.value[i].seda_type);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["activityid"] = (string)dynObj.value[i].activityid;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["exchangeitemid"] = dynObj.value[i].exchangeitemid == null ? null : Convert.ToInt32(dynObj.value[i].exchangeitemid);
                    _Ars["ismapiprivate"] = (string)dynObj.value[i].ismapiprivate;
                    _Ars["seriesid"] = dynObj.value[i].seriesid == null ? null : Convert.ToInt32(dynObj.value[i].seriesid);
                    _Ars["deliverylastattemptedon"] = (string)dynObj.value[i].deliverylastattemptedon;
                    _Ars["_sendermailboxid_value"] = (string)dynObj.value[i]._sendermailboxid_value;
                    _Ars["scheduledend"] = (string)dynObj.value[i].scheduledend;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["community"] = (string)dynObj.value[i].community;
                    _Ars["sortdate"] = (string)dynObj.value[i].sortdate;
                    _Ars["instancetypecode"] = (string)dynObj.value[i].instancetypecode;
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["processid"] = dynObj.value[i].processid == null ? null : Convert.ToInt32(dynObj.value[i].processid);
                    _Ars["_serviceid_value"] = (string)dynObj.value[i]._serviceid_value;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["stageid"] = dynObj.value[i].stageid == null ? null : Convert.ToInt32(dynObj.value[i].stageid);
                    _Ars["actualstart"] = (string)dynObj.value[i].actualstart;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["exchangeweblink"] = (string)dynObj.value[i].exchangeweblink;
                    _Ars["scheduleddurationminutes"] = dynObj.value[i].scheduleddurationminutes == null ? null : Convert.ToInt32(dynObj.value[i].scheduleddurationminutes);
                    _Ars["senton"] = (string)dynObj.value[i].senton;
                    _Ars["scheduledstart"] = (string)dynObj.value[i].scheduledstart;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["postponeactivityprocessinguntil"] = (string)dynObj.value[i].postponeactivityprocessinguntil;
                    _Ars["exchangerate"] = dynObj.value[i].exchangerate == null ? null : Convert.ToInt32(dynObj.value[i].exchangerate);
                    _Ars["deliveryprioritycode"] = (string)dynObj.value[i].deliveryprioritycode;
                    _Ars["actualdurationminutes"] = (string)dynObj.value[i].actualdurationminutes;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["activityadditionalparams"] = (string)dynObj.value[i].activityadditionalparams;
                    _Ars["leftvoicemail"] = (string)dynObj.value[i].leftvoicemail;
                    _Ars["actualend"] = (string)dynObj.value[i].actualend;
                    _Ars["subscriptionid"] = dynObj.value[i].subscriptionid == null ? null : Convert.ToInt32(dynObj.value[i].subscriptionid);
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["subcategory"] = (string)dynObj.value[i].subcategory;
                    _Ars["percentcomplete"] = dynObj.value[i].percentcomplete == null ? null : Convert.ToInt32(dynObj.value[i].percentcomplete);
                    _Ars["crmtaskassigneduniqueid"] = (string)dynObj.value[i].crmtaskassigneduniqueid;
                    _Ars["category"] = (string)dynObj.value[i].category;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Task_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Task_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Appointments
        public static void Appointments(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Appointments", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("scheduledstart");
                dt.Columns.Add("scheduleddurationminutes");
                dt.Columns.Add("_regardingobjectid_value");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("createdon");
                dt.Columns.Add("statecode");
                dt.Columns.Add("isbilled");
                dt.Columns.Add("subject");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("isdraft");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("isregularactivity");
                dt.Columns.Add("isalldayevent");
                dt.Columns.Add("ismapiprivate");
                dt.Columns.Add("scheduledend");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("activitytypecode");
                dt.Columns.Add("instancetypecode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("isworkflowcreated");
                dt.Columns.Add("attachmenterrors");
                dt.Columns.Add("actualend");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("activityid");
                dt.Columns.Add("actualdurationminutes");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("exchangeitemid");
                dt.Columns.Add("seriesid");
                dt.Columns.Add("deliverylastattemptedon");
                dt.Columns.Add("_sendermailboxid_value");
                dt.Columns.Add("description");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("community");
                dt.Columns.Add("sortdate");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("processid");
                dt.Columns.Add("_serviceid_value");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("stageid");
                dt.Columns.Add("actualstart");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("exchangeweblink");
                dt.Columns.Add("senton");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("postponeactivityprocessinguntil");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("deliveryprioritycode");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("activityadditionalparams");
                dt.Columns.Add("leftvoicemail");
                dt.Columns.Add("subscriptionid");
                dt.Columns.Add("category");
                dt.Columns.Add("location");
                dt.Columns.Add("originalstartdate");
                dt.Columns.Add("outlookownerapptid");
                dt.Columns.Add("isunsafe");
                dt.Columns.Add("subcategory");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("modifiedfieldsmask");
                dt.Columns.Add("globalobjectid");
                dt.Columns.Add("overriddencreatedon");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["scheduledstart"] = (string)dynObj.value[i].scheduledstart;
                    _Ars["scheduleddurationminutes"] = dynObj.value[i].scheduleddurationminutes == null ? null : Convert.ToInt32(dynObj.value[i].scheduleddurationminutes);
                    _Ars["_regardingobjectid_value"] = (string)dynObj.value[i]._regardingobjectid_value;
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["isbilled"] = dynObj.value[i].isbilled == null ? null : Convert.ToBoolean(dynObj.value[i].isbilled);
                    _Ars["subject"] = (string)dynObj.value[i].subject;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["prioritycode"] = dynObj.value[i].prioritycode == null ? null : Convert.ToInt32(dynObj.value[i].prioritycode);
                    _Ars["isdraft"] = dynObj.value[i].isdraft == null ? null : Convert.ToBoolean(dynObj.value[i].isdraft);
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["isregularactivity"] = dynObj.value[i].isregularactivity == null ? null : Convert.ToBoolean(dynObj.value[i].isregularactivity);
                    _Ars["isalldayevent"] = dynObj.value[i].isalldayevent == null ? null : Convert.ToBoolean(dynObj.value[i].isalldayevent);
                    _Ars["ismapiprivate"] = dynObj.value[i].ismapiprivate == null ? null : Convert.ToBoolean(dynObj.value[i].ismapiprivate);
                    _Ars["scheduledend"] = (string)dynObj.value[i].scheduledend;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["activitytypecode"] = (string)dynObj.value[i].activitytypecode;
                    _Ars["instancetypecode"] = dynObj.value[i].instancetypecode == null ? null : Convert.ToInt32(dynObj.value[i].instancetypecode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["isworkflowcreated"] = dynObj.value[i].isworkflowcreated == null ? null : Convert.ToBoolean(dynObj.value[i].isworkflowcreated);
                    _Ars["attachmenterrors"] = dynObj.value[i].attachmenterrors == null ? null : Convert.ToInt32(dynObj.value[i].attachmenterrors);
                    _Ars["actualend"] = (string)dynObj.value[i].actualend;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["activityid"] = (string)dynObj.value[i].activityid;
                    _Ars["actualdurationminutes"] = dynObj.value[i].actualdurationminutes == null ? null : Convert.ToInt32(dynObj.value[i].actualdurationminutes);
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["exchangeitemid"] = (string)dynObj.value[i].exchangeitemid;
                    _Ars["seriesid"] = (string)dynObj.value[i].seriesid;
                    _Ars["deliverylastattemptedon"] = (string)dynObj.value[i].deliverylastattemptedon;
                    _Ars["_sendermailboxid_value"] = (string)dynObj.value[i]._sendermailboxid_value;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["community"] = (string)dynObj.value[i].community;
                    _Ars["sortdate"] = (string)dynObj.value[i].sortdate;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["_serviceid_value"] = (string)dynObj.value[i]._serviceid_value;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["actualstart"] = (string)dynObj.value[i].actualstart;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["exchangeweblink"] = (string)dynObj.value[i].exchangeweblink;
                    _Ars["senton"] = (string)dynObj.value[i].senton;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["postponeactivityprocessinguntil"] = (string)dynObj.value[i].postponeactivityprocessinguntil;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["deliveryprioritycode"] = (string)dynObj.value[i].deliveryprioritycode;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["activityadditionalparams"] = (string)dynObj.value[i].activityadditionalparams;
                    _Ars["leftvoicemail"] = (string)dynObj.value[i].leftvoicemail;
                    _Ars["subscriptionid"] = (string)dynObj.value[i].subscriptionid;
                    _Ars["category"] = (string)dynObj.value[i].category;
                    _Ars["location"] = (string)dynObj.value[i].location;
                    _Ars["originalstartdate"] = (string)dynObj.value[i].originalstartdate;
                    _Ars["outlookownerapptid"] = (string)dynObj.value[i].outlookownerapptid;
                    _Ars["isunsafe"] = (string)dynObj.value[i].isunsafe;
                    _Ars["subcategory"] = (string)dynObj.value[i].subcategory;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["modifiedfieldsmask"] = (string)dynObj.value[i].modifiedfieldsmask;
                    _Ars["globalobjectid"] = (string)dynObj.value[i].globalobjectid;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Appointment_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Appointment", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Emails
        public static void Emails(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Emails", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("notifications");
                dt.Columns.Add("statecode");
                dt.Columns.Add("trackingtoken");
                dt.Columns.Add("_regardingobjectid_value");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("correlationmethod");
                dt.Columns.Add("senton");
                dt.Columns.Add("baseconversationindexhash");
                dt.Columns.Add("description");
                dt.Columns.Add("createdon");
                dt.Columns.Add("attachmentcount");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("isbilled");
                dt.Columns.Add("subject");
                dt.Columns.Add("deliveryreceiptrequested");
                dt.Columns.Add("directioncode");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("readreceiptrequested");
                dt.Columns.Add("_sendermailboxid_value");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("compressed");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("isregularactivity");
                dt.Columns.Add("messageid");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("activitytypecode");
                dt.Columns.Add("deliveryattempts");
                dt.Columns.Add("sender");
                dt.Columns.Add("isworkflowcreated");
                dt.Columns.Add("deliveryprioritycode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("actualend");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("torecipients");
                dt.Columns.Add("activityid");
                dt.Columns.Add("conversationindex");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("exchangeitemid");
                dt.Columns.Add("ismapiprivate");
                dt.Columns.Add("seriesid");
                dt.Columns.Add("deliverylastattemptedon");
                dt.Columns.Add("scheduledend");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("community");
                dt.Columns.Add("sortdate");
                dt.Columns.Add("instancetypecode");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("processid");
                dt.Columns.Add("_serviceid_value");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("stageid");
                dt.Columns.Add("actualstart");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("exchangeweblink");
                dt.Columns.Add("scheduleddurationminutes");
                dt.Columns.Add("scheduledstart");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("postponeactivityprocessinguntil");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("actualdurationminutes");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("activityadditionalparams");
                dt.Columns.Add("leftvoicemail");
                dt.Columns.Add("reminderactioncardid");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("emailremindertext");
                dt.Columns.Add("emailtrackingid");
                dt.Columns.Add("emailreminderexpirytime");
                dt.Columns.Add("isunsafe");
                dt.Columns.Add("subcategory");
                dt.Columns.Add("_parentactivityid_value");
                dt.Columns.Add("postponeemailprocessinguntil");
                dt.Columns.Add("category");
                dt.Columns.Add("replycount");
                dt.Columns.Add("_sendersaccount_value");
                dt.Columns.Add("emailreminderstatus");
                dt.Columns.Add("linksclickedcount");
                dt.Columns.Add("submittedby");
                dt.Columns.Add("_emailsender_value");
                dt.Columns.Add("conversationtrackingid");
                dt.Columns.Add("opencount");
                dt.Columns.Add("delayedemailsendtime");
                dt.Columns.Add("mimetype");
                dt.Columns.Add("followemailuserpreference");
                dt.Columns.Add("_templateid_value");
                dt.Columns.Add("inreplyto");
                dt.Columns.Add("lastopenedtime");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("isemailreminderset");
                dt.Columns.Add("isemailfollowed");
                dt.Columns.Add("emailremindertype");
                dt.Columns.Add("attachmentopencount");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["notifications"] = dynObj.value[i].notifications == null ? null : Convert.ToInt32(dynObj.value[i].notifications);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["trackingtoken"] = (string)dynObj.value[i].trackingtoken;
                    _Ars["_regardingobjectid_value"] = (string)dynObj.value[i]._regardingobjectid_value;
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["correlationmethod"] = dynObj.value[i].correlationmethod == null ? null : Convert.ToInt32(dynObj.value[i].correlationmethod);
                    _Ars["senton"] = (string)dynObj.value[i].senton;
                    _Ars["baseconversationindexhash"] = dynObj.value[i].baseconversationindexhash == null ? null : Convert.ToInt32(dynObj.value[i].baseconversationindexhash);
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["attachmentcount"] = dynObj.value[i].attachmentcount == null ? null : Convert.ToInt32(dynObj.value[i].attachmentcount);
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["isbilled"] = dynObj.value[i].isbilled == null ? null : Convert.ToBoolean(dynObj.value[i].isbilled);
                    _Ars["subject"] = (string)dynObj.value[i].subject;
                    _Ars["deliveryreceiptrequested"] = dynObj.value[i].deliveryreceiptrequested == null ? null : Convert.ToBoolean(dynObj.value[i].deliveryreceiptrequested);
                    _Ars["directioncode"] = dynObj.value[i].directioncode == null ? null : Convert.ToBoolean(dynObj.value[i].directioncode);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["readreceiptrequested"] = dynObj.value[i].readreceiptrequested == null ? null : Convert.ToBoolean(dynObj.value[i].readreceiptrequested);
                    _Ars["_sendermailboxid_value"] = (string)dynObj.value[i]._sendermailboxid_value;
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["prioritycode"] = dynObj.value[i].prioritycode == null ? null : Convert.ToInt32(dynObj.value[i].prioritycode);
                    _Ars["compressed"] = dynObj.value[i].compressed == null ? null : Convert.ToBoolean(dynObj.value[i].compressed);
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["isregularactivity"] = dynObj.value[i].isregularactivity == null ? null : Convert.ToBoolean(dynObj.value[i].isregularactivity);
                    _Ars["messageid"] = (string)dynObj.value[i].messageid;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["activitytypecode"] = (string)dynObj.value[i].activitytypecode;
                    _Ars["deliveryattempts"] = dynObj.value[i].deliveryattempts == null ? null : Convert.ToInt32(dynObj.value[i].deliveryattempts);
                    _Ars["sender"] = (string)dynObj.value[i].sender;
                    _Ars["isworkflowcreated"] = dynObj.value[i].isworkflowcreated == null ? null : Convert.ToBoolean(dynObj.value[i].isworkflowcreated);
                    _Ars["deliveryprioritycode"] = dynObj.value[i].deliveryprioritycode == null ? null : Convert.ToInt32(dynObj.value[i].deliveryprioritycode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["actualend"] = (string)dynObj.value[i].actualend;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["torecipients"] = (string)dynObj.value[i].torecipients;
                    _Ars["activityid"] = (string)dynObj.value[i].activityid;
                    _Ars["conversationindex"] = (string)dynObj.value[i].conversationindex;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["exchangeitemid"] = (string)dynObj.value[i].exchangeitemid;
                    _Ars["ismapiprivate"] = (string)dynObj.value[i].ismapiprivate;
                    _Ars["seriesid"] = (string)dynObj.value[i].seriesid;
                    _Ars["deliverylastattemptedon"] = (string)dynObj.value[i].deliverylastattemptedon;
                    _Ars["scheduledend"] = (string)dynObj.value[i].scheduledend;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["community"] = (string)dynObj.value[i].community;
                    _Ars["sortdate"] = (string)dynObj.value[i].sortdate;
                    _Ars["instancetypecode"] = (string)dynObj.value[i].instancetypecode;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["_serviceid_value"] = (string)dynObj.value[i]._serviceid_value;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["actualstart"] = (string)dynObj.value[i].actualstart;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["exchangeweblink"] = (string)dynObj.value[i].exchangeweblink;
                    _Ars["scheduleddurationminutes"] = (string)dynObj.value[i].scheduleddurationminutes;
                    _Ars["scheduledstart"] = (string)dynObj.value[i].scheduledstart;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["postponeactivityprocessinguntil"] = (string)dynObj.value[i].postponeactivityprocessinguntil;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["actualdurationminutes"] = (string)dynObj.value[i].actualdurationminutes;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["activityadditionalparams"] = (string)dynObj.value[i].activityadditionalparams;
                    _Ars["leftvoicemail"] = (string)dynObj.value[i].leftvoicemail;
                    _Ars["reminderactioncardid"] = (string)dynObj.value[i].reminderactioncardid;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["emailremindertext"] = (string)dynObj.value[i].emailremindertext;
                    _Ars["emailtrackingid"] = (string)dynObj.value[i].emailtrackingid;
                    _Ars["emailreminderexpirytime"] = (string)dynObj.value[i].emailreminderexpirytime;
                    _Ars["isunsafe"] = (string)dynObj.value[i].isunsafe;
                    _Ars["subcategory"] = (string)dynObj.value[i].subcategory;
                    _Ars["_parentactivityid_value"] = (string)dynObj.value[i]._parentactivityid_value;
                    _Ars["postponeemailprocessinguntil"] = (string)dynObj.value[i].postponeemailprocessinguntil;
                    _Ars["category"] = (string)dynObj.value[i].category;
                    _Ars["replycount"] = (string)dynObj.value[i].replycount;
                    _Ars["_sendersaccount_value"] = (string)dynObj.value[i]._sendersaccount_value;
                    _Ars["emailreminderstatus"] = (string)dynObj.value[i].emailreminderstatus;
                    _Ars["linksclickedcount"] = (string)dynObj.value[i].linksclickedcount;
                    _Ars["submittedby"] = (string)dynObj.value[i].submittedby;
                    _Ars["_emailsender_value"] = (string)dynObj.value[i]._emailsender_value;
                    _Ars["conversationtrackingid"] = (string)dynObj.value[i].conversationtrackingid;
                    _Ars["opencount"] = (string)dynObj.value[i].opencount;
                    _Ars["delayedemailsendtime"] = (string)dynObj.value[i].delayedemailsendtime;
                    _Ars["mimetype"] = (string)dynObj.value[i].mimetype;
                    _Ars["followemailuserpreference"] = (string)dynObj.value[i].followemailuserpreference;
                    _Ars["_templateid_value"] = (string)dynObj.value[i]._templateid_value;
                    _Ars["inreplyto"] = (string)dynObj.value[i].inreplyto;
                    _Ars["lastopenedtime"] = (string)dynObj.value[i].lastopenedtime;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["isemailreminderset"] = (string)dynObj.value[i].isemailreminderset;
                    _Ars["isemailfollowed"] = (string)dynObj.value[i].isemailfollowed;
                    _Ars["emailremindertype"] = (string)dynObj.value[i].emailremindertype;
                    _Ars["attachmentopencount"] = (string)dynObj.value[i].attachmentopencount;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Emails_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Emails", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region ProcessStages
        public static void ProcessStages(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table ProcessStages", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("_processid_value");
                dt.Columns.Add("owningbusinessunit");
                dt.Columns.Add("stagename");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("primaryentitytypecode");
                dt.Columns.Add("clientdata");
                dt.Columns.Add("processstageid");
                dt.Columns.Add("stagecategory");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["_processid_value"] = (string)dynObj.value[i]._processid_value;
                    _Ars["owningbusinessunit"] = (string)dynObj.value[i].owningbusinessunit;
                    _Ars["stagename"] = (string)dynObj.value[i].stagename;
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["primaryentitytypecode"] = (string)dynObj.value[i].primaryentitytypecode;
                    _Ars["clientdata"] = (string)dynObj.value[i].clientdata;
                    _Ars["processstageid"] = (string)dynObj.value[i].processstageid;
                    _Ars["stagecategory"] = dynObj.value[i].stagecategory == null ? null : Convert.ToInt32(dynObj.value[i].stagecategory);
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("ProcessStages_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("ProcessStages_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region WorkFlows
        public static void WorkFlows(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table WorkFlows", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("category");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("istransacted");
                dt.Columns.Add("workflowidunique");
                dt.Columns.Add("description");
                dt.Columns.Add("createdon");
                dt.Columns.Add("triggeroncreate");
                dt.Columns.Add("xaml");
                dt.Columns.Add("runas");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("triggerondelete");
                dt.Columns.Add("clientdata");
                dt.Columns.Add("asyncautodelete");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("businessprocesstype");
                dt.Columns.Add("solutionid");
                dt.Columns.Add("ismanaged");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("name");
                dt.Columns.Add("mode");
                dt.Columns.Add("introducedversion");
                dt.Columns.Add("iscrmuiworkflow");
                dt.Columns.Add("workflowid");
                dt.Columns.Add("_activeworkflowid_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("syncworkflowlogonfailure");
                dt.Columns.Add("subprocess");
                dt.Columns.Add("scope");
                dt.Columns.Add("ondemand");
                dt.Columns.Add("componentstate");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("overwritetime");
                dt.Columns.Add("primaryentity");
                dt.Columns.Add("type");
                dt.Columns.Add("deletestage");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("entityimage");
                dt.Columns.Add("inputparameters");
                dt.Columns.Add("entityimage_timestamp");
                dt.Columns.Add("uniquename");
                dt.Columns.Add("processroleassignment");
                dt.Columns.Add("formid");
                dt.Columns.Add("updatestage");
                dt.Columns.Add("rank");
                dt.Columns.Add("uidata");
                dt.Columns.Add("_plugintypeid_value");
                dt.Columns.Add("rendererobjecttypecode");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("triggeronupdateattributelist");
                dt.Columns.Add("_parentworkflowid_value");
                dt.Columns.Add("entityimage_url");
                dt.Columns.Add("languagecode");
                dt.Columns.Add("processorder");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("entityimageid");
                dt.Columns.Add("createstage");
                dt.Columns.Add("_sdkmessageid_value");
                dt.Columns.Add("iscustomizable_Value");
                dt.Columns.Add("iscustomizable_CanBeChanged");
                dt.Columns.Add("iscustomizable_ManagedPropertyLogicalName");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["category"] = dynObj.value[i].category == null ? null : Convert.ToInt32(dynObj.value[i].category);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["istransacted"] = dynObj.value[i].istransacted == null ? null : Convert.ToBoolean(dynObj.value[i].istransacted);
                    _Ars["workflowidunique"] = (string)dynObj.value[i].workflowidunique;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["triggeroncreate"] = dynObj.value[i].triggeroncreate == null ? null : Convert.ToBoolean(dynObj.value[i].triggeroncreate);
                    _Ars["xaml"] = (string)dynObj.value[i].xaml;
                    _Ars["runas"] = dynObj.value[i].runas == null ? null : Convert.ToInt32(dynObj.value[i].runas);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["triggerondelete"] = dynObj.value[i].triggerondelete == null ? null : Convert.ToBoolean(dynObj.value[i].triggerondelete);
                    _Ars["clientdata"] = (string)dynObj.value[i].clientdata;
                    _Ars["asyncautodelete"] = dynObj.value[i].asyncautodelete == null ? null : Convert.ToBoolean(dynObj.value[i].asyncautodelete);
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["businessprocesstype"] = (string)dynObj.value[i].businessprocesstype;
                    _Ars["solutionid"] = (string)dynObj.value[i].solutionid;
                    _Ars["ismanaged"] = dynObj.value[i].ismanaged == null ? null : Convert.ToBoolean(dynObj.value[i].ismanaged);
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["name"] = (string)dynObj.value[i].name;
                    _Ars["mode"] = dynObj.value[i].mode == null ? null : Convert.ToInt32(dynObj.value[i].mode);
                    _Ars["introducedversion"] = (string)dynObj.value[i].introducedversion;
                    _Ars["iscrmuiworkflow"] = dynObj.value[i].iscrmuiworkflow == null ? null : Convert.ToBoolean(dynObj.value[i].iscrmuiworkflow);
                    _Ars["workflowid"] = (string)dynObj.value[i].workflowid;
                    _Ars["_activeworkflowid_value"] = (string)dynObj.value[i]._activeworkflowid_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["syncworkflowlogonfailure"] = dynObj.value[i].syncworkflowlogonfailure == null ? null : Convert.ToBoolean(dynObj.value[i].syncworkflowlogonfailure);
                    _Ars["subprocess"] = dynObj.value[i].subprocess == null ? null : Convert.ToBoolean(dynObj.value[i].subprocess);
                    _Ars["scope"] = dynObj.value[i].scope == null ? null : Convert.ToInt32(dynObj.value[i].scope);
                    _Ars["ondemand"] = dynObj.value[i].ondemand == null ? null : Convert.ToBoolean(dynObj.value[i].ondemand);
                    _Ars["componentstate"] = dynObj.value[i].componentstate == null ? null : Convert.ToInt32(dynObj.value[i].componentstate);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["overwritetime"] = (string)dynObj.value[i].overwritetime;
                    _Ars["primaryentity"] = (string)dynObj.value[i].primaryentity;
                    _Ars["type"] = dynObj.value[i].type == null ? null : Convert.ToInt32(dynObj.value[i].type);
                    _Ars["deletestage"] = (string)dynObj.value[i].deletestage;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["entityimage"] = (string)dynObj.value[i].entityimage;
                    _Ars["inputparameters"] = (string)dynObj.value[i].inputparameters;
                    _Ars["entityimage_timestamp"] = (string)dynObj.value[i].entityimage_timestamp;
                    _Ars["uniquename"] = (string)dynObj.value[i].uniquename;
                    _Ars["processroleassignment"] = (string)dynObj.value[i].processroleassignment;
                    _Ars["formid"] = (string)dynObj.value[i].formid;
                    _Ars["updatestage"] = (string)dynObj.value[i].updatestage;
                    _Ars["rank"] = (string)dynObj.value[i].rank;
                    _Ars["uidata"] = (string)dynObj.value[i].uidata;
                    _Ars["_plugintypeid_value"] = (string)dynObj.value[i]._plugintypeid_value;
                    _Ars["rendererobjecttypecode"] = (string)dynObj.value[i].rendererobjecttypecode;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["triggeronupdateattributelist"] = (string)dynObj.value[i].triggeronupdateattributelist;
                    _Ars["_parentworkflowid_value"] = (string)dynObj.value[i]._parentworkflowid_value;
                    _Ars["entityimage_url"] = (string)dynObj.value[i].entityimage_url;
                    _Ars["languagecode"] = (string)dynObj.value[i].languagecode;
                    _Ars["processorder"] = (string)dynObj.value[i].processorder;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["entityimageid"] = (string)dynObj.value[i].entityimageid;
                    _Ars["createstage"] = (string)dynObj.value[i].createstage;
                    _Ars["_sdkmessageid_value"] = (string)dynObj.value[i]._sdkmessageid_value;
                    _Ars["iscustomizable_Value"] = dynObj.value[i].iscustomizable.Value == null ? null : Convert.ToBoolean(dynObj.value[i].iscustomizable.Value);
                    _Ars["iscustomizable_CanBeChanged"] = dynObj.value[i].iscustomizable.CanBeChanged == null ? null : Convert.ToBoolean(dynObj.value[i].iscustomizable.CanBeChanged);
                    _Ars["iscustomizable_ManagedPropertyLogicalName"] = (string)dynObj.value[i].iscustomizable.ManagedPropertyLogicalName;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("WorkFlows_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("WorkFlows_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region contacts
        public static void contacts(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table contacts", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("customertypecode");
                dt.Columns.Add("mobilephone");
                dt.Columns.Add("merged");
                dt.Columns.Add("territorycode");
                dt.Columns.Add("emailaddress1");
                dt.Columns.Add("haschildrencode");
                dt.Columns.Add("_seda_lead_value");
                dt.Columns.Add("preferredappointmenttimecode");
                dt.Columns.Add("isbackofficecustomer");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("lastusedincampaign");
                dt.Columns.Add("lastname");
                dt.Columns.Add("donotphone");
                dt.Columns.Add("preferredcontactmethodcode");
                dt.Columns.Add("educationcode");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("customersizecode");
                dt.Columns.Add("firstname");
                dt.Columns.Add("seda_contacttype");
                dt.Columns.Add("donotpostalmail");
                dt.Columns.Add("yomifullname");
                dt.Columns.Add("address2_addresstypecode");
                dt.Columns.Add("donotemail");
                dt.Columns.Add("seda_email");
                dt.Columns.Add("address2_shippingmethodcode");
                dt.Columns.Add("fullname");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("address1_addressid");
                dt.Columns.Add("address2_freighttermscode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_verificationurl");
                dt.Columns.Add("_originatingleadid_value");
                dt.Columns.Add("donotsendmm");
                dt.Columns.Add("donotfax");
                dt.Columns.Add("leadsourcecode");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("creditonhold");
                dt.Columns.Add("seda_iscreatedfromwebsite");
                dt.Columns.Add("telephone1");
                dt.Columns.Add("address3_addressid");
                dt.Columns.Add("donotbulkemail");
                dt.Columns.Add("seda_isprimarycontact");
                dt.Columns.Add("seda_isanemployee");
                dt.Columns.Add("_seda_positionid_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("shippingmethodcode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("donotbulkpostalmail");
                dt.Columns.Add("_parentcustomerid_value");
                dt.Columns.Add("contactid");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("participatesinworkflow");
                dt.Columns.Add("statecode");
                dt.Columns.Add("address2_addressid");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("address1_longitude");
                dt.Columns.Add("address2_name");
                dt.Columns.Add("seda_verificationcode");
                dt.Columns.Add("processid");
                dt.Columns.Add("governmentid");
                dt.Columns.Add("assistantname");
                dt.Columns.Add("creditlimit");
                dt.Columns.Add("timespentbymeonemailandmeetings");
                dt.Columns.Add("followemail");
                dt.Columns.Add("aging60");
                dt.Columns.Add("entityimage");
                dt.Columns.Add("_modifiedbyexternalparty_value");
                dt.Columns.Add("address2_line3");
                dt.Columns.Add("suffix");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("annualincome_base");
                dt.Columns.Add("address2_longitude");
                dt.Columns.Add("address1_latitude");
                dt.Columns.Add("address1_addresstypecode");
                dt.Columns.Add("emailaddress2");
                dt.Columns.Add("middlename");
                dt.Columns.Add("anniversary");
                dt.Columns.Add("familystatuscode");
                dt.Columns.Add("birthdate");
                dt.Columns.Add("emailaddress3");
                dt.Columns.Add("marketingonly");
                dt.Columns.Add("subscriptionid");
                dt.Columns.Add("address2_latitude");
                dt.Columns.Add("address3_telephone2");
                dt.Columns.Add("address3_line2");
                dt.Columns.Add("address2_telephone1");
                dt.Columns.Add("address2_upszone");
                dt.Columns.Add("msdyn_gdproptout");
                dt.Columns.Add("pager");
                dt.Columns.Add("aging90");
                dt.Columns.Add("address3_line3");
                dt.Columns.Add("address2_county");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("address1_county");
                dt.Columns.Add("_masterid_value");
                dt.Columns.Add("aging90_base");
                dt.Columns.Add("paymenttermscode");
                dt.Columns.Add("_preferredserviceid_value");
                dt.Columns.Add("address2_primarycontactname");
                dt.Columns.Add("address2_composite");
                dt.Columns.Add("salutation");
                dt.Columns.Add("address3_latitude");
                dt.Columns.Add("address2_utcoffset");
                dt.Columns.Add("websiteurl");
                dt.Columns.Add("employeeid");
                dt.Columns.Add("spousesname");
                dt.Columns.Add("entityimage_url");
                dt.Columns.Add("address3_shippingmethodcode");
                dt.Columns.Add("seda_linkedinprofile");
                dt.Columns.Add("ftpsiteurl");
                dt.Columns.Add("address1_name");
                dt.Columns.Add("address1_line2");
                dt.Columns.Add("address1_fax");
                dt.Columns.Add("yomifirstname");
                dt.Columns.Add("callback");
                dt.Columns.Add("address3_fax");
                dt.Columns.Add("address1_composite");
                dt.Columns.Add("address2_line1");
                dt.Columns.Add("address3_primarycontactname");
                dt.Columns.Add("seda_personality");
                dt.Columns.Add("_parentcontactid_value");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("aging30");
                dt.Columns.Add("seda_walkincompanyname");
                dt.Columns.Add("address1_telephone1");
                dt.Columns.Add("jobtitle");
                dt.Columns.Add("address1_stateorprovince");
                dt.Columns.Add("address1_telephone2");
                dt.Columns.Add("yomilastname");
                dt.Columns.Add("entityimageid");
                dt.Columns.Add("preferredappointmentdaycode");
                dt.Columns.Add("aging30_base");
                dt.Columns.Add("address3_line1");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("seda_nationality");
                dt.Columns.Add("seda_passportnumberorid");
                dt.Columns.Add("address1_line1");
                dt.Columns.Add("nickname");
                dt.Columns.Add("childrensnames");
                dt.Columns.Add("_preferredequipmentid_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("_accountid_value");
                dt.Columns.Add("address1_freighttermscode");
                dt.Columns.Add("address3_name");
                dt.Columns.Add("address1_city");
                dt.Columns.Add("address1_shippingmethodcode");
                dt.Columns.Add("address1_utcoffset");
                dt.Columns.Add("address2_telephone2");
                dt.Columns.Add("annualincome");
                dt.Columns.Add("yomimiddlename");
                dt.Columns.Add("stageid");
                dt.Columns.Add("numberofchildren");
                dt.Columns.Add("address2_stateorprovince");
                dt.Columns.Add("assistantphone");
                dt.Columns.Add("address3_stateorprovince");
                dt.Columns.Add("address2_country");
                dt.Columns.Add("seda_commercialregistrationnumber");
                dt.Columns.Add("address1_upszone");
                dt.Columns.Add("telephone2");
                dt.Columns.Add("address1_postalcode");
                dt.Columns.Add("address1_telephone3");
                dt.Columns.Add("fax");
                dt.Columns.Add("gendercode");
                dt.Columns.Add("address3_telephone1");
                dt.Columns.Add("address2_postofficebox");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("telephone3");
                dt.Columns.Add("seda_characteristics");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("address1_country");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("_preferredsystemuserid_value");
                dt.Columns.Add("address3_county");
                dt.Columns.Add("externaluseridentifier");
                dt.Columns.Add("description");
                dt.Columns.Add("address1_line3");
                dt.Columns.Add("company");
                dt.Columns.Add("address2_fax");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("address3_addresstypecode");
                dt.Columns.Add("address1_primarycontactname");
                dt.Columns.Add("managername");
                dt.Columns.Add("address3_telephone3");
                dt.Columns.Add("seda_verifieddate");
                dt.Columns.Add("department");
                dt.Columns.Add("business2");
                dt.Columns.Add("creditlimit_base");
                dt.Columns.Add("managerphone");
                dt.Columns.Add("aging60_base");
                dt.Columns.Add("_defaultpricelevelid_value");
                dt.Columns.Add("address3_composite");
                dt.Columns.Add("address2_city");
                dt.Columns.Add("seda_primarycontactforagency");
                dt.Columns.Add("address2_telephone3");
                dt.Columns.Add("seda_passportexpirydate");
                dt.Columns.Add("accountrolecode");
                dt.Columns.Add("entityimage_timestamp");
                dt.Columns.Add("address3_freighttermscode");
                dt.Columns.Add("address3_city");
                dt.Columns.Add("address1_postofficebox");
                dt.Columns.Add("_createdbyexternalparty_value");
                dt.Columns.Add("address3_upszone");
                dt.Columns.Add("home2");
                dt.Columns.Add("address3_postalcode");
                dt.Columns.Add("address3_postofficebox");
                dt.Columns.Add("address2_postalcode");
                dt.Columns.Add("address3_country");
                dt.Columns.Add("address3_utcoffset");
                dt.Columns.Add("address2_line2");
                dt.Columns.Add("seda_source");
                dt.Columns.Add("address3_longitude");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["customertypecode"] = dynObj.value[i].customertypecode == null ? null : Convert.ToInt32(dynObj.value[i].customertypecode);
                    _Ars["mobilephone"] = (string)dynObj.value[i].mobilephone;
                    _Ars["merged"] = dynObj.value[i].merged == null ? null : Convert.ToBoolean(dynObj.value[i].merged);
                    _Ars["territorycode"] = dynObj.value[i].territorycode == null ? null : Convert.ToInt32(dynObj.value[i].territorycode);
                    _Ars["emailaddress1"] = (string)dynObj.value[i].emailaddress1;
                    _Ars["haschildrencode"] = dynObj.value[i].haschildrencode == null ? null : Convert.ToInt32(dynObj.value[i].haschildrencode);
                    _Ars["_seda_lead_value"] = (string)dynObj.value[i]._seda_lead_value;
                    _Ars["preferredappointmenttimecode"] = dynObj.value[i].preferredappointmenttimecode == null ? null : Convert.ToInt32(dynObj.value[i].preferredappointmenttimecode);
                    _Ars["isbackofficecustomer"] = dynObj.value[i].isbackofficecustomer == null ? null : Convert.ToBoolean(dynObj.value[i].isbackofficecustomer);
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["lastusedincampaign"] = (string)dynObj.value[i].lastusedincampaign;
                    _Ars["lastname"] = (string)dynObj.value[i].lastname;
                    _Ars["donotphone"] = dynObj.value[i].donotphone == null ? null : Convert.ToBoolean(dynObj.value[i].donotphone);
                    _Ars["preferredcontactmethodcode"] = dynObj.value[i].preferredcontactmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].preferredcontactmethodcode);
                    _Ars["educationcode"] = dynObj.value[i].educationcode == null ? null : Convert.ToInt32(dynObj.value[i].educationcode);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["customersizecode"] = dynObj.value[i].customersizecode == null ? null : Convert.ToInt32(dynObj.value[i].customersizecode);
                    _Ars["firstname"] = (string)dynObj.value[i].firstname;
                    _Ars["seda_contacttype"] = dynObj.value[i].seda_contacttype == null ? null : Convert.ToInt32(dynObj.value[i].seda_contacttype);
                    _Ars["donotpostalmail"] = dynObj.value[i].donotpostalmail == null ? null : Convert.ToBoolean(dynObj.value[i].donotpostalmail);
                    _Ars["yomifullname"] = (string)dynObj.value[i].yomifullname;
                    _Ars["address2_addresstypecode"] = dynObj.value[i].address2_addresstypecode == null ? null : Convert.ToInt32(dynObj.value[i].address2_addresstypecode);
                    _Ars["donotemail"] = dynObj.value[i].donotemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotemail);
                    _Ars["seda_email"] = dynObj.value[i].seda_email == null ? null : Convert.ToBoolean(dynObj.value[i].seda_email);
                    _Ars["address2_shippingmethodcode"] = dynObj.value[i].address2_shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].address2_shippingmethodcode);
                    _Ars["fullname"] = (string)dynObj.value[i].fullname;
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["address1_addressid"] = (string)dynObj.value[i].address1_addressid;
                    _Ars["address2_freighttermscode"] = dynObj.value[i].address2_freighttermscode == null ? null : Convert.ToInt32(dynObj.value[i].address2_freighttermscode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_verificationurl"] = (string)dynObj.value[i].seda_verificationurl;
                    _Ars["_originatingleadid_value"] = (string)dynObj.value[i]._originatingleadid_value;
                    _Ars["donotsendmm"] = dynObj.value[i].donotsendmm == null ? null : Convert.ToBoolean(dynObj.value[i].donotsendmm);
                    _Ars["donotfax"] = dynObj.value[i].donotfax == null ? null : Convert.ToBoolean(dynObj.value[i].donotfax);
                    _Ars["leadsourcecode"] = dynObj.value[i].leadsourcecode == null ? null : Convert.ToInt32(dynObj.value[i].leadsourcecode);
                    _Ars["versionnumber"] = dynObj.value[i].versionnumber == null ? null : Convert.ToInt32(dynObj.value[i].versionnumber);
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["creditonhold"] = dynObj.value[i].creditonhold == null ? null : Convert.ToBoolean(dynObj.value[i].creditonhold);
                    _Ars["seda_iscreatedfromwebsite"] = dynObj.value[i].seda_iscreatedfromwebsite == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iscreatedfromwebsite);
                    _Ars["telephone1"] = (string)dynObj.value[i].telephone1;
                    _Ars["address3_addressid"] = (string)dynObj.value[i].address3_addressid;
                    _Ars["donotbulkemail"] = dynObj.value[i].donotbulkemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotbulkemail);
                    _Ars["seda_isprimarycontact"] = dynObj.value[i].seda_isprimarycontact == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isprimarycontact);
                    _Ars["seda_isanemployee"] = dynObj.value[i].seda_isanemployee == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isanemployee);
                    _Ars["_seda_positionid_value"] = (string)dynObj.value[i]._seda_positionid_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["shippingmethodcode"] = dynObj.value[i].shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].shippingmethodcode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["donotbulkpostalmail"] = dynObj.value[i].donotbulkpostalmail == null ? null : Convert.ToBoolean(dynObj.value[i].donotbulkpostalmail);
                    _Ars["_parentcustomerid_value"] = (string)dynObj.value[i]._parentcustomerid_value;
                    _Ars["contactid"] = (string)dynObj.value[i].contactid;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["participatesinworkflow"] = dynObj.value[i].participatesinworkflow == null ? null : Convert.ToBoolean(dynObj.value[i].participatesinworkflow);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["address2_addressid"] = (string)dynObj.value[i].address2_addressid;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["address1_longitude"] = (string)dynObj.value[i].address1_longitude;
                    _Ars["address2_name"] = (string)dynObj.value[i].address2_name;
                    _Ars["seda_verificationcode"] = (string)dynObj.value[i].seda_verificationcode;
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["governmentid"] = (string)dynObj.value[i].governmentid;
                    _Ars["assistantname"] = (string)dynObj.value[i].assistantname;
                    _Ars["creditlimit"] = (string)dynObj.value[i].creditlimit;
                    _Ars["timespentbymeonemailandmeetings"] = (string)dynObj.value[i].timespentbymeonemailandmeetings;
                    _Ars["followemail"] = (string)dynObj.value[i].followemail;
                    _Ars["aging60"] = (string)dynObj.value[i].aging60;
                    _Ars["entityimage"] = (string)dynObj.value[i].entityimage;
                    _Ars["_modifiedbyexternalparty_value"] = (string)dynObj.value[i]._modifiedbyexternalparty_value;
                    _Ars["address2_line3"] = (string)dynObj.value[i].address2_line3;
                    _Ars["suffix"] = (string)dynObj.value[i].suffix;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["annualincome_base"] = (string)dynObj.value[i].annualincome_base;
                    _Ars["address2_longitude"] = (string)dynObj.value[i].address2_longitude;
                    _Ars["address1_latitude"] = (string)dynObj.value[i].address1_latitude;
                    _Ars["address1_addresstypecode"] = (string)dynObj.value[i].address1_addresstypecode;
                    _Ars["emailaddress2"] = (string)dynObj.value[i].emailaddress2;
                    _Ars["middlename"] = (string)dynObj.value[i].middlename;
                    _Ars["anniversary"] = (string)dynObj.value[i].anniversary;
                    _Ars["familystatuscode"] = (string)dynObj.value[i].familystatuscode;
                    _Ars["birthdate"] = (string)dynObj.value[i].birthdate;
                    _Ars["emailaddress3"] = (string)dynObj.value[i].emailaddress3;
                    _Ars["marketingonly"] = (string)dynObj.value[i].marketingonly;
                    _Ars["subscriptionid"] = (string)dynObj.value[i].subscriptionid;
                    _Ars["address2_latitude"] = (string)dynObj.value[i].address2_latitude;
                    _Ars["address3_telephone2"] = (string)dynObj.value[i].address3_telephone2;
                    _Ars["address3_line2"] = (string)dynObj.value[i].address3_line2;
                    _Ars["address2_telephone1"] = (string)dynObj.value[i].address2_telephone1;
                    _Ars["address2_upszone"] = (string)dynObj.value[i].address2_upszone;
                    _Ars["msdyn_gdproptout"] = (string)dynObj.value[i].msdyn_gdproptout;
                    _Ars["pager"] = (string)dynObj.value[i].pager;
                    _Ars["aging90"] = (string)dynObj.value[i].aging90;
                    _Ars["address3_line3"] = (string)dynObj.value[i].address3_line3;
                    _Ars["address2_county"] = (string)dynObj.value[i].address2_county;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["address1_county"] = (string)dynObj.value[i].address1_county;
                    _Ars["_masterid_value"] = (string)dynObj.value[i]._masterid_value;
                    _Ars["aging90_base"] = (string)dynObj.value[i].aging90_base;
                    _Ars["paymenttermscode"] = (string)dynObj.value[i].paymenttermscode;
                    _Ars["_preferredserviceid_value"] = (string)dynObj.value[i]._preferredserviceid_value;
                    _Ars["address2_primarycontactname"] = (string)dynObj.value[i].address2_primarycontactname;
                    _Ars["address2_composite"] = (string)dynObj.value[i].address2_composite;
                    _Ars["salutation"] = (string)dynObj.value[i].salutation;
                    _Ars["address3_latitude"] = (string)dynObj.value[i].address3_latitude;
                    _Ars["address2_utcoffset"] = (string)dynObj.value[i].address2_utcoffset;
                    _Ars["websiteurl"] = (string)dynObj.value[i].websiteurl;
                    _Ars["employeeid"] = (string)dynObj.value[i].employeeid;
                    _Ars["spousesname"] = (string)dynObj.value[i].spousesname;
                    _Ars["entityimage_url"] = (string)dynObj.value[i].entityimage_url;
                    _Ars["address3_shippingmethodcode"] = (string)dynObj.value[i].address3_shippingmethodcode;
                    _Ars["seda_linkedinprofile"] = (string)dynObj.value[i].seda_linkedinprofile;
                    _Ars["ftpsiteurl"] = (string)dynObj.value[i].ftpsiteurl;
                    _Ars["address1_name"] = (string)dynObj.value[i].address1_name;
                    _Ars["address1_line2"] = (string)dynObj.value[i].address1_line2;
                    _Ars["address1_fax"] = (string)dynObj.value[i].address1_fax;
                    _Ars["yomifirstname"] = (string)dynObj.value[i].yomifirstname;
                    _Ars["callback"] = (string)dynObj.value[i].callback;
                    _Ars["address3_fax"] = (string)dynObj.value[i].address3_fax;
                    _Ars["address1_composite"] = (string)dynObj.value[i].address1_composite;
                    _Ars["address2_line1"] = (string)dynObj.value[i].address2_line1;
                    _Ars["address3_primarycontactname"] = (string)dynObj.value[i].address3_primarycontactname;
                    _Ars["seda_personality"] = (string)dynObj.value[i].seda_personality;
                    _Ars["_parentcontactid_value"] = (string)dynObj.value[i]._parentcontactid_value;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["aging30"] = (string)dynObj.value[i].aging30;
                    _Ars["seda_walkincompanyname"] = (string)dynObj.value[i].seda_walkincompanyname;
                    _Ars["address1_telephone1"] = (string)dynObj.value[i].address1_telephone1;
                    _Ars["jobtitle"] = (string)dynObj.value[i].jobtitle;
                    _Ars["address1_stateorprovince"] = (string)dynObj.value[i].address1_stateorprovince;
                    _Ars["address1_telephone2"] = (string)dynObj.value[i].address1_telephone2;
                    _Ars["yomilastname"] = (string)dynObj.value[i].yomilastname;
                    _Ars["entityimageid"] = (string)dynObj.value[i].entityimageid;
                    _Ars["preferredappointmentdaycode"] = (string)dynObj.value[i].preferredappointmentdaycode;
                    _Ars["aging30_base"] = (string)dynObj.value[i].aging30_base;
                    _Ars["address3_line1"] = (string)dynObj.value[i].address3_line1;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["seda_nationality"] = (string)dynObj.value[i].seda_nationality;
                    _Ars["seda_passportnumberorid"] = (string)dynObj.value[i].seda_passportnumberorid;
                    _Ars["address1_line1"] = (string)dynObj.value[i].address1_line1;
                    _Ars["nickname"] = (string)dynObj.value[i].nickname;
                    _Ars["childrensnames"] = (string)dynObj.value[i].childrensnames;
                    _Ars["_preferredequipmentid_value"] = (string)dynObj.value[i]._preferredequipmentid_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["_accountid_value"] = (string)dynObj.value[i]._accountid_value;
                    _Ars["address1_freighttermscode"] = (string)dynObj.value[i].address1_freighttermscode;
                    _Ars["address3_name"] = (string)dynObj.value[i].address3_name;
                    _Ars["address1_city"] = (string)dynObj.value[i].address1_city;
                    _Ars["address1_shippingmethodcode"] = (string)dynObj.value[i].address1_shippingmethodcode;
                    _Ars["address1_utcoffset"] = (string)dynObj.value[i].address1_utcoffset;
                    _Ars["address2_telephone2"] = (string)dynObj.value[i].address2_telephone2;
                    _Ars["annualincome"] = (string)dynObj.value[i].annualincome;
                    _Ars["yomimiddlename"] = (string)dynObj.value[i].yomimiddlename;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["numberofchildren"] = (string)dynObj.value[i].numberofchildren;
                    _Ars["address2_stateorprovince"] = (string)dynObj.value[i].address2_stateorprovince;
                    _Ars["assistantphone"] = (string)dynObj.value[i].assistantphone;
                    _Ars["address3_stateorprovince"] = (string)dynObj.value[i].address3_stateorprovince;
                    _Ars["address2_country"] = (string)dynObj.value[i].address2_country;
                    _Ars["seda_commercialregistrationnumber"] = (string)dynObj.value[i].seda_commercialregistrationnumber;
                    _Ars["address1_upszone"] = (string)dynObj.value[i].address1_upszone;
                    _Ars["telephone2"] = (string)dynObj.value[i].telephone2;
                    _Ars["address1_postalcode"] = (string)dynObj.value[i].address1_postalcode;
                    _Ars["address1_telephone3"] = (string)dynObj.value[i].address1_telephone3;
                    _Ars["fax"] = (string)dynObj.value[i].fax;
                    _Ars["gendercode"] = (string)dynObj.value[i].gendercode;
                    _Ars["address3_telephone1"] = (string)dynObj.value[i].address3_telephone1;
                    _Ars["address2_postofficebox"] = (string)dynObj.value[i].address2_postofficebox;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["telephone3"] = (string)dynObj.value[i].telephone3;
                    _Ars["seda_characteristics"] = (string)dynObj.value[i].seda_characteristics;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["address1_country"] = (string)dynObj.value[i].address1_country;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["_preferredsystemuserid_value"] = (string)dynObj.value[i]._preferredsystemuserid_value;
                    _Ars["address3_county"] = (string)dynObj.value[i].address3_county;
                    _Ars["externaluseridentifier"] = (string)dynObj.value[i].externaluseridentifier;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["address1_line3"] = (string)dynObj.value[i].address1_line3;
                    _Ars["company"] = (string)dynObj.value[i].company;
                    _Ars["address2_fax"] = (string)dynObj.value[i].address2_fax;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["address3_addresstypecode"] = (string)dynObj.value[i].address3_addresstypecode;
                    _Ars["address1_primarycontactname"] = (string)dynObj.value[i].address1_primarycontactname;
                    _Ars["managername"] = (string)dynObj.value[i].managername;
                    _Ars["address3_telephone3"] = (string)dynObj.value[i].address3_telephone3;
                    _Ars["seda_verifieddate"] = (string)dynObj.value[i].seda_verifieddate;
                    _Ars["department"] = (string)dynObj.value[i].department;
                    _Ars["business2"] = (string)dynObj.value[i].business2;
                    _Ars["creditlimit_base"] = (string)dynObj.value[i].creditlimit_base;
                    _Ars["managerphone"] = (string)dynObj.value[i].managerphone;
                    _Ars["aging60_base"] = (string)dynObj.value[i].aging60_base;
                    _Ars["_defaultpricelevelid_value"] = (string)dynObj.value[i]._defaultpricelevelid_value;
                    _Ars["address3_composite"] = (string)dynObj.value[i].address3_composite;
                    _Ars["address2_city"] = (string)dynObj.value[i].address2_city;
                    _Ars["seda_primarycontactforagency"] = (string)dynObj.value[i].seda_primarycontactforagency;
                    _Ars["address2_telephone3"] = (string)dynObj.value[i].address2_telephone3;
                    _Ars["seda_passportexpirydate"] = (string)dynObj.value[i].seda_passportexpirydate;
                    _Ars["accountrolecode"] = (string)dynObj.value[i].accountrolecode;
                    _Ars["entityimage_timestamp"] = (string)dynObj.value[i].entityimage_timestamp;
                    _Ars["address3_freighttermscode"] = (string)dynObj.value[i].address3_freighttermscode;
                    _Ars["address3_city"] = (string)dynObj.value[i].address3_city;
                    _Ars["address1_postofficebox"] = (string)dynObj.value[i].address1_postofficebox;
                    _Ars["_createdbyexternalparty_value"] = (string)dynObj.value[i]._createdbyexternalparty_value;
                    _Ars["address3_upszone"] = (string)dynObj.value[i].address3_upszone;
                    _Ars["home2"] = (string)dynObj.value[i].home2;
                    _Ars["address3_postalcode"] = (string)dynObj.value[i].address3_postalcode;
                    _Ars["address3_postofficebox"] = (string)dynObj.value[i].address3_postofficebox;
                    _Ars["address2_postalcode"] = (string)dynObj.value[i].address2_postalcode;
                    _Ars["address3_country"] = (string)dynObj.value[i].address3_country;
                    _Ars["address3_utcoffset"] = (string)dynObj.value[i].address3_utcoffset;
                    _Ars["address2_line2"] = (string)dynObj.value[i].address2_line2;
                    _Ars["seda_source"] = (string)dynObj.value[i].seda_source;
                    _Ars["address3_longitude"] = (string)dynObj.value[i].address3_longitude;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("contacts_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("contacts_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Leads
        public static void Leads(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Leads", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("entityimage_url");
                dt.Columns.Add("mobilephone");
                dt.Columns.Add("merged");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("seda_industrialcityplotnumber");
                dt.Columns.Add("emailaddress1");
                dt.Columns.Add("confirminterest");
                dt.Columns.Add("seda_crissuingdate");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("seda_arabicname");
                dt.Columns.Add("_parentcontactid_value");
                dt.Columns.Add("address1_postofficebox");
                dt.Columns.Add("seda_companysizecode");
                dt.Columns.Add("decisionmaker");
                dt.Columns.Add("seda_isfirstrequest");
                dt.Columns.Add("seda_segment");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("seda_isrejected");
                dt.Columns.Add("seda_crnexpirationdate");
                dt.Columns.Add("lastusedincampaign");
                dt.Columns.Add("address1_shippingmethodcode");
                dt.Columns.Add("seda_targetingwholesale");
                dt.Columns.Add("address1_composite");
                dt.Columns.Add("lastname");
                dt.Columns.Add("donotpostalmail");
                dt.Columns.Add("seda_crntype");
                dt.Columns.Add("donotphone");
                dt.Columns.Add("preferredcontactmethodcode");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("address1_telephone1");
                dt.Columns.Add("entityimage_timestamp");
                dt.Columns.Add("seda_marketcap");
                dt.Columns.Add("_seda_country_value");
                dt.Columns.Add("firstname");
                dt.Columns.Add("leadqualitycode");
                dt.Columns.Add("companyname");
                dt.Columns.Add("evaluatefit");
                dt.Columns.Add("yomifullname");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_targetingtrader");
                dt.Columns.Add("address2_addresstypecode");
                dt.Columns.Add("donotemail");
                dt.Columns.Add("seda_leadtype");
                dt.Columns.Add("address2_shippingmethodcode");
                dt.Columns.Add("fullname");
                dt.Columns.Add("address1_telephone3");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("address1_addressid");
                dt.Columns.Add("seda_isexporter");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("seda_industrialcitynumber");
                dt.Columns.Add("seda_targetingretailer");
                dt.Columns.Add("_seda_city_value");
                dt.Columns.Add("donotsendmm");
                dt.Columns.Add("donotfax");
                dt.Columns.Add("seda_verificationcode");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("address1_line1");
                dt.Columns.Add("seda_iscreatedfromwebsite");
                dt.Columns.Add("seda_iagreetopublishmyrepresentativepersoncont");
                dt.Columns.Add("telephone1");
                dt.Columns.Add("_seda_contactpositionid_value");
                dt.Columns.Add("_parentaccountid_value");
                dt.Columns.Add("seda_businesslegalstructuretxt");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("seda_businesstypecode");
                dt.Columns.Add("seda_iagreetopublishmyproductslistdetails");
                dt.Columns.Add("address1_addresstypecode");
                dt.Columns.Add("donotbulkemail");
                dt.Columns.Add("seda_industrialactivity");
                dt.Columns.Add("leadid");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("websiteurl");
                dt.Columns.Add("seda_iagreetopublishmycompanyinformation");
                dt.Columns.Add("entityimage");
                dt.Columns.Add("seda_acceptancedate");
                dt.Columns.Add("address1_fax");
                dt.Columns.Add("seda_marketcap_base");
                dt.Columns.Add("salesstagecode");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("seda_completionpercentage");
                dt.Columns.Add("seda_verificationdate");
                dt.Columns.Add("seda_factorycode");
                dt.Columns.Add("participatesinworkflow");
                dt.Columns.Add("statecode");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("address2_addressid");
                dt.Columns.Add("seda_commercialregistrationnumber");
                dt.Columns.Add("address1_postalcode");
                dt.Columns.Add("seda_generalganagergame");
                dt.Columns.Add("entityimageid");
                dt.Columns.Add("yomimiddlename");
                dt.Columns.Add("exeseda_leadcontactlastname");
                dt.Columns.Add("exeseda_customerisqualified");
                dt.Columns.Add("middlename");
                dt.Columns.Add("seda_migrated");
                dt.Columns.Add("seda_mcilegaltype");
                dt.Columns.Add("sic");
                dt.Columns.Add("numberofemployees");
                dt.Columns.Add("exeseda_companycontactfirstname");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_exeseda_trainingsessionsservicescovered_value");
                dt.Columns.Add("address1_name");
                dt.Columns.Add("address2_line3");
                dt.Columns.Add("exeseda_storageconditioncapabilities");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("exeseda_customerprofileyearsofexperience");
                dt.Columns.Add("exeseda_exporterisqualified");
                dt.Columns.Add("seda_exporterrevenuepercentage");
                dt.Columns.Add("yomilastname");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("address1_stateorprovince");
                dt.Columns.Add("exeseda_airfreightexpressiatanumber");
                dt.Columns.Add("seda_gosicertificate");
                dt.Columns.Add("address2_fax");
                dt.Columns.Add("_qualifyingopportunityid_value");
                dt.Columns.Add("seda_arabicmissingdetails");
                dt.Columns.Add("_exeseda_ccexitportair_value");
                dt.Columns.Add("exeseda_compilationtype");
                dt.Columns.Add("telephone2");
                dt.Columns.Add("exeseda_buyerisqualified");
                dt.Columns.Add("seda_isfirsttimephonelead");
                dt.Columns.Add("followemail");
                dt.Columns.Add("address2_composite");
                dt.Columns.Add("seda_reason");
                dt.Columns.Add("_relatedobjectid_value");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("estimatedamount_base");
                dt.Columns.Add("exeseda_leadcontactfirstname");
                dt.Columns.Add("exeseda_yooisinformationmanagementsolutions");
                dt.Columns.Add("_exeseda_citiesservedintheregion_value");
                dt.Columns.Add("address2_line2");
                dt.Columns.Add("seda_crissuedby");
                dt.Columns.Add("exeseda_yearsofoperationinservicetraining");
                dt.Columns.Add("_exeseda_exportercontactposition_value");
                dt.Columns.Add("exeseda_annualexportvalue");
                dt.Columns.Add("_customerid_value");
                dt.Columns.Add("seda_region");
                dt.Columns.Add("exeseda_emaillci");
                dt.Columns.Add("exeseda_businessturnover");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("address2_postofficebox");
                dt.Columns.Add("seda_zibcode");
                dt.Columns.Add("exeseda_positionlcf");
                dt.Columns.Add("exeseda_sizeperstoragecondition");
                dt.Columns.Add("_exeseda_coveredareaid_value");
                dt.Columns.Add("exeseda_vatcertificatenumbersme");
                dt.Columns.Add("description");
                dt.Columns.Add("exeseda_yooislandfreight");
                dt.Columns.Add("exeseda_namelcf");
                dt.Columns.Add("exeseda_emaillcf");
                dt.Columns.Add("address2_telephone3");
                dt.Columns.Add("emailaddress2");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("seda_productcategory");
                dt.Columns.Add("exeseda_knowhowonexportdescription");
                dt.Columns.Add("seda_isfirstmciupdate");
                dt.Columns.Add("exeseda_phonenumbersme");
                dt.Columns.Add("exeseda_preferredcommunicationtypedirect");
                dt.Columns.Add("exeseda_namelci");
                dt.Columns.Add("exeseda_rejectionreasons");
                dt.Columns.Add("address2_postalcode");
                dt.Columns.Add("revenue");
                dt.Columns.Add("stageid");
                dt.Columns.Add("exeseda_detailssummation");
                dt.Columns.Add("_exeseda_tailoredservicescovered_value");
                dt.Columns.Add("exeseda_registrationenddate");
                dt.Columns.Add("seda_exporterrevenue");
                dt.Columns.Add("exeseda_description");
                dt.Columns.Add("address2_country");
                dt.Columns.Add("exeseda_namesme");
                dt.Columns.Add("budgetamount");
                dt.Columns.Add("leadsourcecode");
                dt.Columns.Add("exeseda_websiteurllci");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("address1_longitude");
                dt.Columns.Add("_originatingcaseid_value");
                dt.Columns.Add("address1_country");
                dt.Columns.Add("exeseda_buyerarabicname");
                dt.Columns.Add("exeseda_numberofemployees");
                dt.Columns.Add("purchaseprocess");
                dt.Columns.Add("exeseda_yooislegalservices");
                dt.Columns.Add("timespentbymeonemailandmeetings");
                dt.Columns.Add("exeseda_yearsofoperationinservicetailored");
                dt.Columns.Add("exeseda_buyerisverified");
                dt.Columns.Add("address2_stateorprovince");
                dt.Columns.Add("emailaddress3");
                dt.Columns.Add("exeseda_moreinformation");
                dt.Columns.Add("msdyn_gdproptout");
                dt.Columns.Add("address2_longitude");
                dt.Columns.Add("_exeseda_city_value");
                dt.Columns.Add("yomifirstname");
                dt.Columns.Add("exeseda_websiteurlsme");
                dt.Columns.Add("subject");
                dt.Columns.Add("fax");
                dt.Columns.Add("exeseda_yooiscargoinsurance");
                dt.Columns.Add("exeseda_yooispackaging");
                dt.Columns.Add("address1_telephone2");
                dt.Columns.Add("exeseda_preferredcommunicationenglishlanguage");
                dt.Columns.Add("_exeseda_ccexitportland_value");
                dt.Columns.Add("exeseda_modeofshipment");
                dt.Columns.Add("seda_mainactivity");
                dt.Columns.Add("exeseda_positionlci");
                dt.Columns.Add("yomicompanyname");
                dt.Columns.Add("processid");
                dt.Columns.Add("_masterid_value");
                dt.Columns.Add("exeseda_yooisairfreightcargocustomsclearance");
                dt.Columns.Add("exeseda_tradelicenceexpirydate");
                dt.Columns.Add("_exeseda_wcountryofwarehouses_value");
                dt.Columns.Add("exeseda_yooisairfreightexpress");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("seda_englishbio");
                dt.Columns.Add("exeseda_officefaxnumberlci");
                dt.Columns.Add("exeseda_exporterisverified");
                dt.Columns.Add("address2_telephone2");
                dt.Columns.Add("estimatedamount");
                dt.Columns.Add("address2_line1");
                dt.Columns.Add("exeseda_tradelicencenumber");
                dt.Columns.Add("seda_otherprimarycontactposition");
                dt.Columns.Add("seda_arabicbio");
                dt.Columns.Add("seda_englishmissingdetails");
                dt.Columns.Add("industrycode");
                dt.Columns.Add("_campaignid_value");
                dt.Columns.Add("seda_zakatcertificate");
                dt.Columns.Add("address2_utcoffset");
                dt.Columns.Add("seda_customersource");
                dt.Columns.Add("exeseda_preferredcommunicationarabiclanguage");
                dt.Columns.Add("exeseda_airfreightcargoiatanumber");
                dt.Columns.Add("new_seda_migrate");
                dt.Columns.Add("schedulefollowup_qualify");
                dt.Columns.Add("purchasetimeframe");
                dt.Columns.Add("exeseda_yooiswarehousing");
                dt.Columns.Add("telephone3");
                dt.Columns.Add("address2_name");
                dt.Columns.Add("exeseda_yooisseafreight");
                dt.Columns.Add("address1_line3");
                dt.Columns.Add("exeseda_vatcertificatenumberlcf");
                dt.Columns.Add("seda_ismcilead");
                dt.Columns.Add("pager");
                dt.Columns.Add("exeseda_officeemaillcf");
                dt.Columns.Add("exeseda_businessregistrationnumber");
                dt.Columns.Add("exeseda_officephonenumberlcf");
                dt.Columns.Add("qualificationcomments");
                dt.Columns.Add("exeseda_officeemailsme");
                dt.Columns.Add("_exeseda_cargotypehandledhscode_value");
                dt.Columns.Add("exeseda_yooismarketingandadvertisingsupport");
                dt.Columns.Add("_exeseda_servicecategory_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("_exeseda_customercontactposition_value");
                dt.Columns.Add("address2_latitude");
                dt.Columns.Add("schedulefollowup_prospect");
                dt.Columns.Add("exeseda_companycontactlastname");
                dt.Columns.Add("seda_prioritycustomer");
                dt.Columns.Add("seda_totalrevenue");
                dt.Columns.Add("exeseda_phonenumberlci");
                dt.Columns.Add("estimatedvalue");
                dt.Columns.Add("exeseda_officeemaillci");
                dt.Columns.Add("seda_attention");
                dt.Columns.Add("_seda_mailingcity_value");
                dt.Columns.Add("exeseda_emailsme");
                dt.Columns.Add("address1_utcoffset");
                dt.Columns.Add("seda_isindustrial");
                dt.Columns.Add("address2_city");
                dt.Columns.Add("seda_productcode");
                dt.Columns.Add("address2_county");
                dt.Columns.Add("_contactid_value");
                dt.Columns.Add("jobtitle");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("_seda_sector_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("address2_upszone");
                dt.Columns.Add("exeseda_sptype");
                dt.Columns.Add("_exeseda_country_value");
                dt.Columns.Add("exeseda_yooisairfreightcargo");
                dt.Columns.Add("exeseda_positionsme");
                dt.Columns.Add("address1_county");
                dt.Columns.Add("budgetamount_base");
                dt.Columns.Add("exeseda_buyername");
                dt.Columns.Add("exeseda_preferredcommunicationtypefromportal");
                dt.Columns.Add("seda_crstatus");
                dt.Columns.Add("exeseda_keyprojectsundertaken");
                dt.Columns.Add("revenue_base");
                dt.Columns.Add("exeseda_officefaxnumberlcf");
                dt.Columns.Add("exeseda_websiteurllcf");
                dt.Columns.Add("exeseda_yoowebsitesetup");
                dt.Columns.Add("address1_upszone");
                dt.Columns.Add("need");
                dt.Columns.Add("exeseda_officefaxnumbersme");
                dt.Columns.Add("exeseda_keyclients");
                dt.Columns.Add("seda_totalrevenue_base");
                dt.Columns.Add("salutation");
                dt.Columns.Add("exeseda_approximatecompanysize");
                dt.Columns.Add("salesstage");
                dt.Columns.Add("address1_city");
                dt.Columns.Add("seda_businesslegalstructure");
                dt.Columns.Add("address2_telephone1");
                dt.Columns.Add("budgetstatus");
                dt.Columns.Add("_exeseda_seafreightlistofassociatedcarriers_value");
                dt.Columns.Add("exeseda_vatcertificatenumberlci");
                dt.Columns.Add("_exeseda_ccexitportsea_value");
                dt.Columns.Add("exeseda_officephonenumbersme");
                dt.Columns.Add("exeseda_customerisverified");
                dt.Columns.Add("exeseda_officephonenumberlci");
                dt.Columns.Add("_accountid_value");
                dt.Columns.Add("address1_line2");
                dt.Columns.Add("exeseda_phonenumberlcf");
                dt.Columns.Add("exeseda_yooistestingandcertification");
                dt.Columns.Add("estimatedclosedate");
                dt.Columns.Add("address1_latitude");
                dt.Columns.Add("seda_exporterrevenue_base");
                dt.Columns.Add("seda_productname");
                dt.Columns.Add("initialcommunication");
                dt.Columns.Add("exeseda_isqualified");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["prioritycode"] = dynObj.value[i].prioritycode == null ? null : Convert.ToInt32(dynObj.value[i].prioritycode);
                    _Ars["entityimage_url"] = (string)dynObj.value[i].entityimage_url;
                    _Ars["mobilephone"] = (string)dynObj.value[i].mobilephone;
                    _Ars["merged"] = dynObj.value[i].merged == null ? null : Convert.ToBoolean(dynObj.value[i].merged);
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["seda_industrialcityplotnumber"] = (string)dynObj.value[i].seda_industrialcityplotnumber;
                    _Ars["emailaddress1"] = (string)dynObj.value[i].emailaddress1;
                    _Ars["confirminterest"] = dynObj.value[i].confirminterest == null ? null : Convert.ToBoolean(dynObj.value[i].confirminterest);
                    _Ars["seda_crissuingdate"] = (string)dynObj.value[i].seda_crissuingdate;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["seda_arabicname"] = (string)dynObj.value[i].seda_arabicname;
                    _Ars["_parentcontactid_value"] = (string)dynObj.value[i]._parentcontactid_value;
                    _Ars["address1_postofficebox"] = (string)dynObj.value[i].address1_postofficebox;
                    _Ars["seda_companysizecode"] = dynObj.value[i].seda_companysizecode == null ? null : Convert.ToInt32(dynObj.value[i].seda_companysizecode);
                    _Ars["decisionmaker"] = dynObj.value[i].decisionmaker == null ? null : Convert.ToBoolean(dynObj.value[i].decisionmaker);
                    _Ars["seda_isfirstrequest"] = dynObj.value[i].seda_isfirstrequest == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isfirstrequest);
                    _Ars["seda_segment"] = (string)dynObj.value[i].seda_segment;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["seda_isrejected"] = dynObj.value[i].seda_isrejected == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isrejected);
                    _Ars["seda_crnexpirationdate"] = (string)dynObj.value[i].seda_crnexpirationdate;
                    _Ars["lastusedincampaign"] = (string)dynObj.value[i].lastusedincampaign;
                    _Ars["address1_shippingmethodcode"] = dynObj.value[i].address1_shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].address1_shippingmethodcode);
                    _Ars["seda_targetingwholesale"] = dynObj.value[i].seda_targetingwholesale == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingwholesale);
                    _Ars["address1_composite"] = (string)dynObj.value[i].address1_composite;
                    _Ars["lastname"] = (string)dynObj.value[i].lastname;
                    _Ars["donotpostalmail"] = dynObj.value[i].donotpostalmail == null ? null : Convert.ToBoolean(dynObj.value[i].donotpostalmail);
                    _Ars["seda_crntype"] = (string)dynObj.value[i].seda_crntype;
                    _Ars["donotphone"] = dynObj.value[i].donotphone == null ? null : Convert.ToBoolean(dynObj.value[i].donotphone);
                    _Ars["preferredcontactmethodcode"] = dynObj.value[i].preferredcontactmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].preferredcontactmethodcode);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["address1_telephone1"] = (string)dynObj.value[i].address1_telephone1;
                    _Ars["entityimage_timestamp"] = (string)dynObj.value[i].entityimage_timestamp;
                    _Ars["seda_marketcap"] = (string)dynObj.value[i].seda_marketcap;
                    _Ars["_seda_country_value"] = (string)dynObj.value[i]._seda_country_value;
                    _Ars["firstname"] = (string)dynObj.value[i].firstname;
                    _Ars["leadqualitycode"] = dynObj.value[i].leadqualitycode == null ? null : Convert.ToInt32(dynObj.value[i].leadqualitycode);
                    _Ars["companyname"] = (string)dynObj.value[i].companyname;
                    _Ars["evaluatefit"] = dynObj.value[i].evaluatefit == null ? null : Convert.ToBoolean(dynObj.value[i].evaluatefit);
                    _Ars["yomifullname"] = (string)dynObj.value[i].yomifullname;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_targetingtrader"] = dynObj.value[i].seda_targetingtrader == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingtrader);
                    _Ars["address2_addresstypecode"] = dynObj.value[i].address2_addresstypecode == null ? null : Convert.ToInt32(dynObj.value[i].address2_addresstypecode);
                    _Ars["donotemail"] = dynObj.value[i].donotemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotemail);
                    _Ars["seda_leadtype"] = (string)dynObj.value[i].seda_leadtype;
                    _Ars["address2_shippingmethodcode"] = dynObj.value[i].address2_shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].address2_shippingmethodcode);
                    _Ars["fullname"] = (string)dynObj.value[i].fullname;
                    _Ars["address1_telephone3"] = (string)dynObj.value[i].address1_telephone3;
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["address1_addressid"] = (string)dynObj.value[i].address1_addressid;
                    _Ars["seda_isexporter"] = dynObj.value[i].seda_isexporter == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isexporter);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["seda_industrialcitynumber"] = (string)dynObj.value[i].seda_industrialcitynumber;
                    _Ars["seda_targetingretailer"] = dynObj.value[i].seda_targetingretailer == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingretailer);
                    _Ars["_seda_city_value"] = (string)dynObj.value[i]._seda_city_value;
                    _Ars["donotsendmm"] = dynObj.value[i].donotsendmm == null ? null : Convert.ToBoolean(dynObj.value[i].donotsendmm);
                    _Ars["donotfax"] = dynObj.value[i].donotfax == null ? null : Convert.ToBoolean(dynObj.value[i].donotfax);
                    _Ars["seda_verificationcode"] = (string)dynObj.value[i].seda_verificationcode;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["address1_line1"] = (string)dynObj.value[i].address1_line1;
                    _Ars["seda_iscreatedfromwebsite"] = dynObj.value[i].seda_iscreatedfromwebsite == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iscreatedfromwebsite);
                    _Ars["seda_iagreetopublishmyrepresentativepersoncont"] = dynObj.value[i].seda_iagreetopublishmyrepresentativepersoncont == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmyrepresentativepersoncont);
                    _Ars["telephone1"] = (string)dynObj.value[i].telephone1;
                    _Ars["_seda_contactpositionid_value"] = (string)dynObj.value[i]._seda_contactpositionid_value;
                    _Ars["_parentaccountid_value"] = (string)dynObj.value[i]._parentaccountid_value;
                    _Ars["seda_businesslegalstructuretxt"] = (string)dynObj.value[i].seda_businesslegalstructuretxt;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["seda_businesstypecode"] = dynObj.value[i].seda_businesstypecode == null ? null : Convert.ToInt32(dynObj.value[i].seda_businesstypecode);
                    _Ars["seda_iagreetopublishmyproductslistdetails"] = dynObj.value[i].seda_iagreetopublishmyproductslistdetails == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmyproductslistdetails);
                    _Ars["address1_addresstypecode"] = dynObj.value[i].address1_addresstypecode == null ? null : Convert.ToInt32(dynObj.value[i].address1_addresstypecode);
                    _Ars["donotbulkemail"] = dynObj.value[i].donotbulkemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotbulkemail);
                    _Ars["seda_industrialactivity"] = (string)dynObj.value[i].seda_industrialactivity;
                    _Ars["leadid"] = (string)dynObj.value[i].leadid;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["websiteurl"] = (string)dynObj.value[i].websiteurl;
                    _Ars["seda_iagreetopublishmycompanyinformation"] = dynObj.value[i].seda_iagreetopublishmycompanyinformation == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmycompanyinformation);
                    _Ars["entityimage"] = (string)dynObj.value[i].entityimage;
                    _Ars["seda_acceptancedate"] = (string)dynObj.value[i].seda_acceptancedate;
                    _Ars["address1_fax"] = (string)dynObj.value[i].address1_fax;
                    _Ars["seda_marketcap_base"] = (string)dynObj.value[i].seda_marketcap_base;
                    _Ars["salesstagecode"] = dynObj.value[i].salesstagecode == null ? null : Convert.ToInt32(dynObj.value[i].salesstagecode);
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["seda_completionpercentage"] = (string)dynObj.value[i].seda_completionpercentage;
                    _Ars["seda_verificationdate"] = (string)dynObj.value[i].seda_verificationdate;
                    _Ars["seda_factorycode"] = (string)dynObj.value[i].seda_factorycode;
                    _Ars["participatesinworkflow"] = dynObj.value[i].participatesinworkflow == null ? null : Convert.ToBoolean(dynObj.value[i].participatesinworkflow);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["address2_addressid"] = (string)dynObj.value[i].address2_addressid;
                    _Ars["seda_commercialregistrationnumber"] = (string)dynObj.value[i].seda_commercialregistrationnumber;
                    _Ars["address1_postalcode"] = (string)dynObj.value[i].address1_postalcode;
                    _Ars["seda_generalganagergame"] = (string)dynObj.value[i].seda_generalganagergame;
                    _Ars["entityimageid"] = (string)dynObj.value[i].entityimageid;
                    _Ars["yomimiddlename"] = (string)dynObj.value[i].yomimiddlename;
                    _Ars["exeseda_leadcontactlastname"] = (string)dynObj.value[i].exeseda_leadcontactlastname;
                    _Ars["exeseda_customerisqualified"] = (string)dynObj.value[i].exeseda_customerisqualified;
                    _Ars["middlename"] = (string)dynObj.value[i].middlename;
                    _Ars["seda_migrated"] = (string)dynObj.value[i].seda_migrated;
                    _Ars["seda_mcilegaltype"] = (string)dynObj.value[i].seda_mcilegaltype;
                    _Ars["sic"] = (string)dynObj.value[i].sic;
                    _Ars["numberofemployees"] = (string)dynObj.value[i].numberofemployees;
                    _Ars["exeseda_companycontactfirstname"] = (string)dynObj.value[i].exeseda_companycontactfirstname;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_exeseda_trainingsessionsservicescovered_value"] = (string)dynObj.value[i]._exeseda_trainingsessionsservicescovered_value;
                    _Ars["address1_name"] = (string)dynObj.value[i].address1_name;
                    _Ars["address2_line3"] = (string)dynObj.value[i].address2_line3;
                    _Ars["exeseda_storageconditioncapabilities"] = (string)dynObj.value[i].exeseda_storageconditioncapabilities;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["exeseda_customerprofileyearsofexperience"] = (string)dynObj.value[i].exeseda_customerprofileyearsofexperience;
                    _Ars["exeseda_exporterisqualified"] = (string)dynObj.value[i].exeseda_exporterisqualified;
                    _Ars["seda_exporterrevenuepercentage"] = (string)dynObj.value[i].seda_exporterrevenuepercentage;
                    _Ars["yomilastname"] = (string)dynObj.value[i].yomilastname;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["address1_stateorprovince"] = (string)dynObj.value[i].address1_stateorprovince;
                    _Ars["exeseda_airfreightexpressiatanumber"] = (string)dynObj.value[i].exeseda_airfreightexpressiatanumber;
                    _Ars["seda_gosicertificate"] = (string)dynObj.value[i].seda_gosicertificate;
                    _Ars["address2_fax"] = (string)dynObj.value[i].address2_fax;
                    _Ars["_qualifyingopportunityid_value"] = (string)dynObj.value[i]._qualifyingopportunityid_value;
                    _Ars["seda_arabicmissingdetails"] = (string)dynObj.value[i].seda_arabicmissingdetails;
                    _Ars["_exeseda_ccexitportair_value"] = (string)dynObj.value[i]._exeseda_ccexitportair_value;
                    _Ars["exeseda_compilationtype"] = (string)dynObj.value[i].exeseda_compilationtype;
                    _Ars["telephone2"] = (string)dynObj.value[i].telephone2;
                    _Ars["exeseda_buyerisqualified"] = (string)dynObj.value[i].exeseda_buyerisqualified;
                    _Ars["seda_isfirsttimephonelead"] = (string)dynObj.value[i].seda_isfirsttimephonelead;
                    _Ars["followemail"] = (string)dynObj.value[i].followemail;
                    _Ars["address2_composite"] = (string)dynObj.value[i].address2_composite;
                    _Ars["seda_reason"] = (string)dynObj.value[i].seda_reason;
                    _Ars["_relatedobjectid_value"] = (string)dynObj.value[i]._relatedobjectid_value;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["estimatedamount_base"] = (string)dynObj.value[i].estimatedamount_base;
                    _Ars["exeseda_leadcontactfirstname"] = (string)dynObj.value[i].exeseda_leadcontactfirstname;
                    _Ars["exeseda_yooisinformationmanagementsolutions"] = (string)dynObj.value[i].exeseda_yooisinformationmanagementsolutions;
                    _Ars["_exeseda_citiesservedintheregion_value"] = (string)dynObj.value[i]._exeseda_citiesservedintheregion_value;
                    _Ars["address2_line2"] = (string)dynObj.value[i].address2_line2;
                    _Ars["seda_crissuedby"] = (string)dynObj.value[i].seda_crissuedby;
                    _Ars["exeseda_yearsofoperationinservicetraining"] = (string)dynObj.value[i].exeseda_yearsofoperationinservicetraining;
                    _Ars["_exeseda_exportercontactposition_value"] = (string)dynObj.value[i]._exeseda_exportercontactposition_value;
                    _Ars["exeseda_annualexportvalue"] = (string)dynObj.value[i].exeseda_annualexportvalue;
                    _Ars["_customerid_value"] = (string)dynObj.value[i]._customerid_value;
                    _Ars["seda_region"] = (string)dynObj.value[i].seda_region;
                    _Ars["exeseda_emaillci"] = (string)dynObj.value[i].exeseda_emaillci;
                    _Ars["exeseda_businessturnover"] = (string)dynObj.value[i].exeseda_businessturnover;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["address2_postofficebox"] = (string)dynObj.value[i].address2_postofficebox;
                    _Ars["seda_zibcode"] = (string)dynObj.value[i].seda_zibcode;
                    _Ars["exeseda_positionlcf"] = (string)dynObj.value[i].exeseda_positionlcf;
                    _Ars["exeseda_sizeperstoragecondition"] = (string)dynObj.value[i].exeseda_sizeperstoragecondition;
                    _Ars["_exeseda_coveredareaid_value"] = (string)dynObj.value[i]._exeseda_coveredareaid_value;
                    _Ars["exeseda_vatcertificatenumbersme"] = (string)dynObj.value[i].exeseda_vatcertificatenumbersme;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["exeseda_yooislandfreight"] = (string)dynObj.value[i].exeseda_yooislandfreight;
                    _Ars["exeseda_namelcf"] = (string)dynObj.value[i].exeseda_namelcf;
                    _Ars["exeseda_emaillcf"] = (string)dynObj.value[i].exeseda_emaillcf;
                    _Ars["address2_telephone3"] = (string)dynObj.value[i].address2_telephone3;
                    _Ars["emailaddress2"] = (string)dynObj.value[i].emailaddress2;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["seda_productcategory"] = (string)dynObj.value[i].seda_productcategory;
                    _Ars["exeseda_knowhowonexportdescription"] = (string)dynObj.value[i].exeseda_knowhowonexportdescription;
                    _Ars["seda_isfirstmciupdate"] = (string)dynObj.value[i].seda_isfirstmciupdate;
                    _Ars["exeseda_phonenumbersme"] = (string)dynObj.value[i].exeseda_phonenumbersme;
                    _Ars["exeseda_preferredcommunicationtypedirect"] = (string)dynObj.value[i].exeseda_preferredcommunicationtypedirect;
                    _Ars["exeseda_namelci"] = (string)dynObj.value[i].exeseda_namelci;
                    _Ars["exeseda_rejectionreasons"] = (string)dynObj.value[i].exeseda_rejectionreasons;
                    _Ars["address2_postalcode"] = (string)dynObj.value[i].address2_postalcode;
                    _Ars["revenue"] = (string)dynObj.value[i].revenue;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["exeseda_detailssummation"] = (string)dynObj.value[i].exeseda_detailssummation;
                    _Ars["_exeseda_tailoredservicescovered_value"] = (string)dynObj.value[i]._exeseda_tailoredservicescovered_value;
                    _Ars["exeseda_registrationenddate"] = (string)dynObj.value[i].exeseda_registrationenddate;
                    _Ars["seda_exporterrevenue"] = (string)dynObj.value[i].seda_exporterrevenue;
                    _Ars["exeseda_description"] = (string)dynObj.value[i].exeseda_description;
                    _Ars["address2_country"] = (string)dynObj.value[i].address2_country;
                    _Ars["exeseda_namesme"] = (string)dynObj.value[i].exeseda_namesme;
                    _Ars["budgetamount"] = (string)dynObj.value[i].budgetamount;
                    _Ars["leadsourcecode"] = (string)dynObj.value[i].leadsourcecode;
                    _Ars["exeseda_websiteurllci"] = (string)dynObj.value[i].exeseda_websiteurllci;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["address1_longitude"] = (string)dynObj.value[i].address1_longitude;
                    _Ars["_originatingcaseid_value"] = (string)dynObj.value[i]._originatingcaseid_value;
                    _Ars["address1_country"] = (string)dynObj.value[i].address1_country;
                    _Ars["exeseda_buyerarabicname"] = (string)dynObj.value[i].exeseda_buyerarabicname;
                    _Ars["exeseda_numberofemployees"] = (string)dynObj.value[i].exeseda_numberofemployees;
                    _Ars["purchaseprocess"] = (string)dynObj.value[i].purchaseprocess;
                    _Ars["exeseda_yooislegalservices"] = (string)dynObj.value[i].exeseda_yooislegalservices;
                    _Ars["timespentbymeonemailandmeetings"] = (string)dynObj.value[i].timespentbymeonemailandmeetings;
                    _Ars["exeseda_yearsofoperationinservicetailored"] = (string)dynObj.value[i].exeseda_yearsofoperationinservicetailored;
                    _Ars["exeseda_buyerisverified"] = (string)dynObj.value[i].exeseda_buyerisverified;
                    _Ars["address2_stateorprovince"] = (string)dynObj.value[i].address2_stateorprovince;
                    _Ars["emailaddress3"] = (string)dynObj.value[i].emailaddress3;
                    _Ars["exeseda_moreinformation"] = (string)dynObj.value[i].exeseda_moreinformation;
                    _Ars["msdyn_gdproptout"] = (string)dynObj.value[i].msdyn_gdproptout;
                    _Ars["address2_longitude"] = (string)dynObj.value[i].address2_longitude;
                    _Ars["_exeseda_city_value"] = (string)dynObj.value[i]._exeseda_city_value;
                    _Ars["yomifirstname"] = (string)dynObj.value[i].yomifirstname;
                    _Ars["exeseda_websiteurlsme"] = (string)dynObj.value[i].exeseda_websiteurlsme;
                    _Ars["subject"] = (string)dynObj.value[i].subject;
                    _Ars["fax"] = (string)dynObj.value[i].fax;
                    _Ars["exeseda_yooiscargoinsurance"] = (string)dynObj.value[i].exeseda_yooiscargoinsurance;
                    _Ars["exeseda_yooispackaging"] = (string)dynObj.value[i].exeseda_yooispackaging;
                    _Ars["address1_telephone2"] = (string)dynObj.value[i].address1_telephone2;
                    _Ars["exeseda_preferredcommunicationenglishlanguage"] = (string)dynObj.value[i].exeseda_preferredcommunicationenglishlanguage;
                    _Ars["_exeseda_ccexitportland_value"] = (string)dynObj.value[i]._exeseda_ccexitportland_value;
                    _Ars["exeseda_modeofshipment"] = (string)dynObj.value[i].exeseda_modeofshipment;
                    _Ars["seda_mainactivity"] = (string)dynObj.value[i].seda_mainactivity;
                    _Ars["exeseda_positionlci"] = (string)dynObj.value[i].exeseda_positionlci;
                    _Ars["yomicompanyname"] = (string)dynObj.value[i].yomicompanyname;
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["_masterid_value"] = (string)dynObj.value[i]._masterid_value;
                    _Ars["exeseda_yooisairfreightcargocustomsclearance"] = (string)dynObj.value[i].exeseda_yooisairfreightcargocustomsclearance;
                    _Ars["exeseda_tradelicenceexpirydate"] = (string)dynObj.value[i].exeseda_tradelicenceexpirydate;
                    _Ars["_exeseda_wcountryofwarehouses_value"] = (string)dynObj.value[i]._exeseda_wcountryofwarehouses_value;
                    _Ars["exeseda_yooisairfreightexpress"] = (string)dynObj.value[i].exeseda_yooisairfreightexpress;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["seda_englishbio"] = (string)dynObj.value[i].seda_englishbio;
                    _Ars["exeseda_officefaxnumberlci"] = (string)dynObj.value[i].exeseda_officefaxnumberlci;
                    _Ars["exeseda_exporterisverified"] = (string)dynObj.value[i].exeseda_exporterisverified;
                    _Ars["address2_telephone2"] = (string)dynObj.value[i].address2_telephone2;
                    _Ars["estimatedamount"] = (string)dynObj.value[i].estimatedamount;
                    _Ars["address2_line1"] = (string)dynObj.value[i].address2_line1;
                    _Ars["exeseda_tradelicencenumber"] = (string)dynObj.value[i].exeseda_tradelicencenumber;
                    _Ars["seda_otherprimarycontactposition"] = (string)dynObj.value[i].seda_otherprimarycontactposition;
                    _Ars["seda_arabicbio"] = (string)dynObj.value[i].seda_arabicbio;
                    _Ars["seda_englishmissingdetails"] = (string)dynObj.value[i].seda_englishmissingdetails;
                    _Ars["industrycode"] = (string)dynObj.value[i].industrycode;
                    _Ars["_campaignid_value"] = (string)dynObj.value[i]._campaignid_value;
                    _Ars["seda_zakatcertificate"] = (string)dynObj.value[i].seda_zakatcertificate;
                    _Ars["address2_utcoffset"] = (string)dynObj.value[i].address2_utcoffset;
                    _Ars["seda_customersource"] = (string)dynObj.value[i].seda_customersource;
                    _Ars["exeseda_preferredcommunicationarabiclanguage"] = (string)dynObj.value[i].exeseda_preferredcommunicationarabiclanguage;
                    _Ars["exeseda_airfreightcargoiatanumber"] = (string)dynObj.value[i].exeseda_airfreightcargoiatanumber;
                    _Ars["new_seda_migrate"] = (string)dynObj.value[i].new_seda_migrate;
                    _Ars["schedulefollowup_qualify"] = (string)dynObj.value[i].schedulefollowup_qualify;
                    _Ars["purchasetimeframe"] = (string)dynObj.value[i].purchasetimeframe;
                    _Ars["exeseda_yooiswarehousing"] = (string)dynObj.value[i].exeseda_yooiswarehousing;
                    _Ars["telephone3"] = (string)dynObj.value[i].telephone3;
                    _Ars["address2_name"] = (string)dynObj.value[i].address2_name;
                    _Ars["exeseda_yooisseafreight"] = (string)dynObj.value[i].exeseda_yooisseafreight;
                    _Ars["address1_line3"] = (string)dynObj.value[i].address1_line3;
                    _Ars["exeseda_vatcertificatenumberlcf"] = (string)dynObj.value[i].exeseda_vatcertificatenumberlcf;
                    _Ars["seda_ismcilead"] = (string)dynObj.value[i].seda_ismcilead;
                    _Ars["pager"] = (string)dynObj.value[i].pager;
                    _Ars["exeseda_officeemaillcf"] = (string)dynObj.value[i].exeseda_officeemaillcf;
                    _Ars["exeseda_businessregistrationnumber"] = (string)dynObj.value[i].exeseda_businessregistrationnumber;
                    _Ars["exeseda_officephonenumberlcf"] = (string)dynObj.value[i].exeseda_officephonenumberlcf;
                    _Ars["qualificationcomments"] = (string)dynObj.value[i].qualificationcomments;
                    _Ars["exeseda_officeemailsme"] = (string)dynObj.value[i].exeseda_officeemailsme;
                    _Ars["_exeseda_cargotypehandledhscode_value"] = (string)dynObj.value[i]._exeseda_cargotypehandledhscode_value;
                    _Ars["exeseda_yooismarketingandadvertisingsupport"] = (string)dynObj.value[i].exeseda_yooismarketingandadvertisingsupport;
                    _Ars["_exeseda_servicecategory_value"] = (string)dynObj.value[i]._exeseda_servicecategory_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["_exeseda_customercontactposition_value"] = (string)dynObj.value[i]._exeseda_customercontactposition_value;
                    _Ars["address2_latitude"] = (string)dynObj.value[i].address2_latitude;
                    _Ars["schedulefollowup_prospect"] = (string)dynObj.value[i].schedulefollowup_prospect;
                    _Ars["exeseda_companycontactlastname"] = (string)dynObj.value[i].exeseda_companycontactlastname;
                    _Ars["seda_prioritycustomer"] = (string)dynObj.value[i].seda_prioritycustomer;
                    _Ars["seda_totalrevenue"] = (string)dynObj.value[i].seda_totalrevenue;
                    _Ars["exeseda_phonenumberlci"] = (string)dynObj.value[i].exeseda_phonenumberlci;
                    _Ars["estimatedvalue"] = (string)dynObj.value[i].estimatedvalue;
                    _Ars["exeseda_officeemaillci"] = (string)dynObj.value[i].exeseda_officeemaillci;
                    _Ars["seda_attention"] = (string)dynObj.value[i].seda_attention;
                    _Ars["_seda_mailingcity_value"] = (string)dynObj.value[i]._seda_mailingcity_value;
                    _Ars["exeseda_emailsme"] = (string)dynObj.value[i].exeseda_emailsme;
                    _Ars["address1_utcoffset"] = (string)dynObj.value[i].address1_utcoffset;
                    _Ars["seda_isindustrial"] = (string)dynObj.value[i].seda_isindustrial;
                    _Ars["address2_city"] = (string)dynObj.value[i].address2_city;
                    _Ars["seda_productcode"] = (string)dynObj.value[i].seda_productcode;
                    _Ars["address2_county"] = (string)dynObj.value[i].address2_county;
                    _Ars["_contactid_value"] = (string)dynObj.value[i]._contactid_value;
                    _Ars["jobtitle"] = (string)dynObj.value[i].jobtitle;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["_seda_sector_value"] = (string)dynObj.value[i]._seda_sector_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["address2_upszone"] = (string)dynObj.value[i].address2_upszone;
                    _Ars["exeseda_sptype"] = (string)dynObj.value[i].exeseda_sptype;
                    _Ars["_exeseda_country_value"] = (string)dynObj.value[i]._exeseda_country_value;
                    _Ars["exeseda_yooisairfreightcargo"] = (string)dynObj.value[i].exeseda_yooisairfreightcargo;
                    _Ars["exeseda_positionsme"] = (string)dynObj.value[i].exeseda_positionsme;
                    _Ars["address1_county"] = (string)dynObj.value[i].address1_county;
                    _Ars["budgetamount_base"] = (string)dynObj.value[i].budgetamount_base;
                    _Ars["exeseda_buyername"] = (string)dynObj.value[i].exeseda_buyername;
                    _Ars["exeseda_preferredcommunicationtypefromportal"] = (string)dynObj.value[i].exeseda_preferredcommunicationtypefromportal;
                    _Ars["seda_crstatus"] = (string)dynObj.value[i].seda_crstatus;
                    _Ars["exeseda_keyprojectsundertaken"] = (string)dynObj.value[i].exeseda_keyprojectsundertaken;
                    _Ars["revenue_base"] = (string)dynObj.value[i].revenue_base;
                    _Ars["exeseda_officefaxnumberlcf"] = (string)dynObj.value[i].exeseda_officefaxnumberlcf;
                    _Ars["exeseda_websiteurllcf"] = (string)dynObj.value[i].exeseda_websiteurllcf;
                    _Ars["exeseda_yoowebsitesetup"] = (string)dynObj.value[i].exeseda_yoowebsitesetup;
                    _Ars["address1_upszone"] = (string)dynObj.value[i].address1_upszone;
                    _Ars["need"] = (string)dynObj.value[i].need;
                    _Ars["exeseda_officefaxnumbersme"] = (string)dynObj.value[i].exeseda_officefaxnumbersme;
                    _Ars["exeseda_keyclients"] = (string)dynObj.value[i].exeseda_keyclients;
                    _Ars["seda_totalrevenue_base"] = (string)dynObj.value[i].seda_totalrevenue_base;
                    _Ars["salutation"] = (string)dynObj.value[i].salutation;
                    _Ars["exeseda_approximatecompanysize"] = (string)dynObj.value[i].exeseda_approximatecompanysize;
                    _Ars["salesstage"] = (string)dynObj.value[i].salesstage;
                    _Ars["address1_city"] = (string)dynObj.value[i].address1_city;
                    _Ars["seda_businesslegalstructure"] = (string)dynObj.value[i].seda_businesslegalstructure;
                    _Ars["address2_telephone1"] = (string)dynObj.value[i].address2_telephone1;
                    _Ars["budgetstatus"] = (string)dynObj.value[i].budgetstatus;
                    _Ars["_exeseda_seafreightlistofassociatedcarriers_value"] = (string)dynObj.value[i]._exeseda_seafreightlistofassociatedcarriers_value;
                    _Ars["exeseda_vatcertificatenumberlci"] = (string)dynObj.value[i].exeseda_vatcertificatenumberlci;
                    _Ars["_exeseda_ccexitportsea_value"] = (string)dynObj.value[i]._exeseda_ccexitportsea_value;
                    _Ars["exeseda_officephonenumbersme"] = (string)dynObj.value[i].exeseda_officephonenumbersme;
                    _Ars["exeseda_customerisverified"] = (string)dynObj.value[i].exeseda_customerisverified;
                    _Ars["exeseda_officephonenumberlci"] = (string)dynObj.value[i].exeseda_officephonenumberlci;
                    _Ars["_accountid_value"] = (string)dynObj.value[i]._accountid_value;
                    _Ars["address1_line2"] = (string)dynObj.value[i].address1_line2;
                    _Ars["exeseda_phonenumberlcf"] = (string)dynObj.value[i].exeseda_phonenumberlcf;
                    _Ars["exeseda_yooistestingandcertification"] = (string)dynObj.value[i].exeseda_yooistestingandcertification;
                    _Ars["estimatedclosedate"] = (string)dynObj.value[i].estimatedclosedate;
                    _Ars["address1_latitude"] = (string)dynObj.value[i].address1_latitude;
                    _Ars["seda_exporterrevenue_base"] = (string)dynObj.value[i].seda_exporterrevenue_base;
                    _Ars["seda_productname"] = (string)dynObj.value[i].seda_productname;
                    _Ars["initialcommunication"] = (string)dynObj.value[i].initialcommunication;
                    _Ars["exeseda_isqualified"] = (string)dynObj.value[i].exeseda_isqualified;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Leads_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Leads_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Accounts

        public static void Accounts(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Accounts", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("address2_addresstypecode");
                dt.Columns.Add("merged");
                dt.Columns.Add("accountnumber");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("seda_industrialcityplotnumber");
                dt.Columns.Add("seda_industrialcitynumber");
                dt.Columns.Add("emailaddress1");
                dt.Columns.Add("seda_crissuingdate");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("seda_attention");
                dt.Columns.Add("openrevenue_state");
                dt.Columns.Add("address1_postofficebox");
                dt.Columns.Add("name");
                dt.Columns.Add("websiteurl");
                dt.Columns.Add("opendeals");
                dt.Columns.Add("seda_companysizecode");
                dt.Columns.Add("seda_segment");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("_primarycontactid_value");
                dt.Columns.Add("seda_crnexpirationdate");
                dt.Columns.Add("marketcap");
                dt.Columns.Add("lastusedincampaign");
                dt.Columns.Add("address1_shippingmethodcode");
                dt.Columns.Add("seda_targetingwholesale");
                dt.Columns.Add("address1_composite");
                dt.Columns.Add("donotpostalmail");
                dt.Columns.Add("accountratingcode");
                dt.Columns.Add("seda_crntype");
                dt.Columns.Add("donotphone");
                dt.Columns.Add("preferredcontactmethodcode");
                dt.Columns.Add("seda_generalmanagernam");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("accountclassificationcode");
                dt.Columns.Add("entityimage_timestamp");
                dt.Columns.Add("seda_exporteracceptancedate");
                dt.Columns.Add("customersizecode");
                dt.Columns.Add("_seda_country_value");
                dt.Columns.Add("seda_businesstype");
                dt.Columns.Add("entityimage_url");
                dt.Columns.Add("seda_targetingtrader");
                dt.Columns.Add("openrevenue_base");
                dt.Columns.Add("businesstypecode");
                dt.Columns.Add("donotemail");
                dt.Columns.Add("opendeals_state");
                dt.Columns.Add("address2_shippingmethodcode");
                dt.Columns.Add("address1_telephone2");
                dt.Columns.Add("address1_telephone3");
                dt.Columns.Add("seda_emailverified");
                dt.Columns.Add("address1_telephone1");
                dt.Columns.Add("seda_isexporter");
                dt.Columns.Add("address2_freighttermscode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_targetingretailer");
                dt.Columns.Add("_seda_city_value");
                dt.Columns.Add("_originatingleadid_value");
                dt.Columns.Add("openrevenue");
                dt.Columns.Add("donotsendmm");
                dt.Columns.Add("donotfax");
                dt.Columns.Add("seda_accounttype");
                dt.Columns.Add("donotbulkpostalmail");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("address1_line1");
                dt.Columns.Add("address1_line2");
                dt.Columns.Add("address1_line3");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("creditonhold");
                dt.Columns.Add("seda_iscreatedfromwebsite");
                dt.Columns.Add("seda_iagreetopublishmyrepresentativepersoncont");
                dt.Columns.Add("seda_registrationdate");
                dt.Columns.Add("_seda_exporterleadid_value");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("seda_businesslegalstructuretxt");
                dt.Columns.Add("accountid");
                dt.Columns.Add("address1_addresstypecode");
                dt.Columns.Add("donotbulkemail");
                dt.Columns.Add("seda_industrialactivity");
                dt.Columns.Add("shippingmethodcode");
                dt.Columns.Add("seda_arabicname");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("seda_iagreetopublishmycompanyinformation");
                dt.Columns.Add("entityimage");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("territorycode");
                dt.Columns.Add("openrevenue_date");
                dt.Columns.Add("seda_allowedtosubmitincentiverequest");
                dt.Columns.Add("seda_exporterrequestdate");
                dt.Columns.Add("seda_iagreetopublishmyproductslistdetails");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("address1_addressid");
                dt.Columns.Add("seda_factorycode");
                dt.Columns.Add("participatesinworkflow");
                dt.Columns.Add("statecode");
                dt.Columns.Add("address2_addressid");
                dt.Columns.Add("address1_postalcode");
                dt.Columns.Add("marketcap_base");
                dt.Columns.Add("entityimageid");
                dt.Columns.Add("seda_verifieddate");
                dt.Columns.Add("opendeals_date");
                dt.Columns.Add("exeseda_namelcf");
                dt.Columns.Add("address1_freighttermscode");
                dt.Columns.Add("seda_marketresearchselectionscoring");
                dt.Columns.Add("telephone3");
                dt.Columns.Add("new_channeltomarketsalesprocessscoringex");
                dt.Columns.Add("exeseda_officefaxnumberlcf");
                dt.Columns.Add("seda_zakatcertificatetype");
                dt.Columns.Add("exeseda_tradelicenceexpirydate");
                dt.Columns.Add("exeseda_lastname");
                dt.Columns.Add("new_marketresearchselectionscoringex");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("address1_longitude");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("exeseda_companyrepresentativefullname");
                dt.Columns.Add("_preferredsystemuserid_value");
                dt.Columns.Add("exeseda_officeemaillci");
                dt.Columns.Add("exeseda_positionsme");
                dt.Columns.Add("exeseda_pricingstars");
                dt.Columns.Add("exeseda_yooispackaging");
                dt.Columns.Add("creditlimit_base");
                dt.Columns.Add("seda_staffattituderate");
                dt.Columns.Add("exeseda_customeryearsofexperience");
                dt.Columns.Add("seda_interestedinmarketresearch");
                dt.Columns.Add("exeseda_websiteurlsme");
                dt.Columns.Add("seda_entityttype");
                dt.Columns.Add("new_whatdoesexcellencelooklikemarket");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("preferredappointmenttimecode");
                dt.Columns.Add("_exeseda_ccexitportsea_value");
                dt.Columns.Add("address2_name");
                dt.Columns.Add("seda_interestedintrademissions");
                dt.Columns.Add("seda_zakatexpgregorian");
                dt.Columns.Add("seda_exporterrevenue");
                dt.Columns.Add("address2_upszone");
                dt.Columns.Add("exeseda_phonenumbersme");
                dt.Columns.Add("seda_valueofmoneyrate");
                dt.Columns.Add("seda_zakatcertificate");
                dt.Columns.Add("_preferredequipmentid_value");
                dt.Columns.Add("exeseda_yearsofoperationinservicetailored");
                dt.Columns.Add("seda_isassesmentrenewalrequired");
                dt.Columns.Add("exeseda_yooisci");
                dt.Columns.Add("emailaddress2");
                dt.Columns.Add("exeseda_emaillcf");
                dt.Columns.Add("exeseda_yooisairfreightexpress");
                dt.Columns.Add("seda_zakatservicemodifieddate");
                dt.Columns.Add("exeseda_buyername");
                dt.Columns.Add("address1_stateorprovince");
                dt.Columns.Add("seda_interestedinworkshop");
                dt.Columns.Add("exeseda_professionalismstars");
                dt.Columns.Add("_seda_sector_value");
                dt.Columns.Add("exeseda_numberofemployees");
                dt.Columns.Add("new_blocked");
                dt.Columns.Add("seda_idurl");
                dt.Columns.Add("exeseda_brochurestatus");
                dt.Columns.Add("address2_city");
                dt.Columns.Add("seda_zakatlicesnseno");
                dt.Columns.Add("exeseda_yearsofoperationinservicetraining");
                dt.Columns.Add("address1_upszone");
                dt.Columns.Add("_seda_serviceproviderlead_value");
                dt.Columns.Add("new_attendedevents");
                dt.Columns.Add("exeseda_positionlci");
                dt.Columns.Add("exeseda_accountcontactlastname");
                dt.Columns.Add("exeseda_officeemaillcf");
                dt.Columns.Add("exeseda_preferredcommunicationarabiclanguage");
                dt.Columns.Add("seda_totalrate");
                dt.Columns.Add("_seda_assessors_value");
                dt.Columns.Add("exeseda_registrationenddate");
                dt.Columns.Add("exeseda_positionlcf");
                dt.Columns.Add("_masterid_value");
                dt.Columns.Add("seda_strategicclient");
                dt.Columns.Add("exeseda_preferredcommunicationtypedirect");
                dt.Columns.Add("exeseda_officefaxnumbersme");
                dt.Columns.Add("address2_latitude");
                dt.Columns.Add("exeseda_ischampion");
                dt.Columns.Add("new_pricingandfundingscoring");
                dt.Columns.Add("_territoryid_value");
                dt.Columns.Add("address2_utcoffset");
                dt.Columns.Add("aging30_base");
                dt.Columns.Add("exeseda_qualityofservicestars");
                dt.Columns.Add("seda_arabicbio");
                dt.Columns.Add("telephone2");
                dt.Columns.Add("exeseda_yooisairfreightcargocustomsclearance");
                dt.Columns.Add("telephone1");
                dt.Columns.Add("seda_exporterrevenuepercentage");
                dt.Columns.Add("exeseda_vatcertificatenumberlcf");
                dt.Columns.Add("_exeseda_cargotypehandledhscode_value");
                dt.Columns.Add("new_pricingandfunding");
                dt.Columns.Add("paymenttermscode");
                dt.Columns.Add("new_comments");
                dt.Columns.Add("address2_line3");
                dt.Columns.Add("_modifiedbyexternalparty_value");
                dt.Columns.Add("exeseda_airfreightcargoiatanumber");
                dt.Columns.Add("_exeseda_serviceprovidercity_value");
                dt.Columns.Add("exeseda_serviceprovidertype");
                dt.Columns.Add("new_whatdoesexcellencelooklikeproduct");
                dt.Columns.Add("address2_country");
                dt.Columns.Add("exeseda_championfromdate");
                dt.Columns.Add("address2_postofficebox");
                dt.Columns.Add("exeseda_websiteurllcf");
                dt.Columns.Add("seda_zakatexphijri");
                dt.Columns.Add("stageid");
                dt.Columns.Add("exeseda_yooiscargoinsurance");
                dt.Columns.Add("industrycode");
                dt.Columns.Add("exeseda_emailsme");
                dt.Columns.Add("address1_primarycontactname");
                dt.Columns.Add("_seda_customsmsactivity_value");
                dt.Columns.Add("yominame");
                dt.Columns.Add("_defaultpricelevelid_value");
                dt.Columns.Add("_exeseda_exporterclassification_value");
                dt.Columns.Add("address2_telephone2");
                dt.Columns.Add("seda_businesstype_if");
                dt.Columns.Add("seda_blacklistedforincentive");
                dt.Columns.Add("processid");
                dt.Columns.Add("exeseda_vatcertificatenumberlci");
                dt.Columns.Add("_preferredserviceid_value");
                dt.Columns.Add("address2_composite");
                dt.Columns.Add("exeseda_officephonenumberlci");
                dt.Columns.Add("exeseda_accountcontactfirstname");
                dt.Columns.Add("exeseda_annualexportvalue");
                dt.Columns.Add("seda_delegationurl");
                dt.Columns.Add("_exeseda_serviceprovidercountry_value");
                dt.Columns.Add("_slainvokedid_value");
                dt.Columns.Add("seda_productcode");
                dt.Columns.Add("seda_zakatserviceerror");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("new_marketselection");
                dt.Columns.Add("seda_zakatnumber");
                dt.Columns.Add("new_scoresummarypricing");
                dt.Columns.Add("seda_serviceproviderrequestdate");
                dt.Columns.Add("exeseda_emaillci");
                dt.Columns.Add("new_scoresummaryvision");
                dt.Columns.Add("exeseda_yooisairfreightcargo");
                dt.Columns.Add("new_currentassessment");
                dt.Columns.Add("_new_manager_value");
                dt.Columns.Add("exeseda_phonenumberlcf");
                dt.Columns.Add("address2_county");
                dt.Columns.Add("exeseda_sizeperstoragecondition");
                dt.Columns.Add("exeseda_brochureapprovaldatetime");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("new_pricingfundingexportdrivescoringex");
                dt.Columns.Add("primarysatoriid");
                dt.Columns.Add("exeseda_knowhowonexportdescription");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("primarytwitterid");
                dt.Columns.Add("_exeseda_exeseda_contactposition_value");
                dt.Columns.Add("seda_prioritycustomer");
                dt.Columns.Add("ftpsiteurl");
                dt.Columns.Add("sic");
                dt.Columns.Add("seda_reason");
                dt.Columns.Add("sharesoutstanding");
                dt.Columns.Add("_exeseda_accountcontactposition_value");
                dt.Columns.Add("seda_qualityofworkrate");
                dt.Columns.Add("numberofemployees");
                dt.Columns.Add("seda_visitdate");
                dt.Columns.Add("seda_exporterrevenue_base");
                dt.Columns.Add("new_productsservicesscoringex");
                dt.Columns.Add("exeseda_yooistestingandcertification");
                dt.Columns.Add("seda_crissuedby");
                dt.Columns.Add("exeseda_yooislandfreight");
                dt.Columns.Add("address1_utcoffset");
                dt.Columns.Add("exeseda_preferredcommunicationtypefromportal");
                dt.Columns.Add("exeseda_modeofshipment");
                dt.Columns.Add("revenue_base");
                dt.Columns.Add("marketingonly");
                dt.Columns.Add("address2_telephone3");
                dt.Columns.Add("new_scoresummarymarket");
                dt.Columns.Add("address1_latitude");
                dt.Columns.Add("exeseda_yooiswarehousing");
                dt.Columns.Add("seda_zakattinnumber");
                dt.Columns.Add("seda_verificationcode");
                dt.Columns.Add("new_scoresummaryproduct");
                dt.Columns.Add("seda_businesslegalstructure");
                dt.Columns.Add("seda_zakatissuedatehijri");
                dt.Columns.Add("address2_line1");
                dt.Columns.Add("exeseda_championtodate");
                dt.Columns.Add("new_marketresearchscoringex");
                dt.Columns.Add("seda_englishbio");
                dt.Columns.Add("seda_mainactivity");
                dt.Columns.Add("new_whatdoesexcellencelooklikevision");
                dt.Columns.Add("exeseda_officefaxnumberlci");
                dt.Columns.Add("exeseda_yooisseafreight");
                dt.Columns.Add("address2_postalcode");
                dt.Columns.Add("seda_gosicertificate");
                dt.Columns.Add("seda_thiqaexpirydate");
                dt.Columns.Add("seda_thiqaactivites");
                dt.Columns.Add("new_commitmentvisionscoringex");
                dt.Columns.Add("exeseda_isbrochureuploaded");
                dt.Columns.Add("seda_punctualityrate");
                dt.Columns.Add("address2_stateorprovince");
                dt.Columns.Add("seda_thiqaissuedate");
                dt.Columns.Add("exeseda_preferredcommunicationenglishlanguage");
                dt.Columns.Add("exeseda_buyerarabicname");
                dt.Columns.Add("exeseda_airfreightexpressiatanumber");
                dt.Columns.Add("exeseda_yoowebsitesetup");
                dt.Columns.Add("seda_pricingfundingexportdrivescoring");
                dt.Columns.Add("seda_productservicetype");
                dt.Columns.Add("seda_productsservicesscoring");
                dt.Columns.Add("exeseda_keyprojectsundertaken");
                dt.Columns.Add("aging90");
                dt.Columns.Add("_exeseda_coveredareaid_value");
                dt.Columns.Add("exeseda_vatcertificatenumbersme");
                dt.Columns.Add("seda_nterestedinxhibitions");
                dt.Columns.Add("_createdbyexternalparty_value");
                dt.Columns.Add("_exeseda_ccexitportland_value");
                dt.Columns.Add("_exeseda_ccexitportair_value");
                dt.Columns.Add("seda_zakatissuedategregorian");
                dt.Columns.Add("exeseda_businessregistrationnumber");
                dt.Columns.Add("address1_county");
                dt.Columns.Add("description");
                dt.Columns.Add("exeseda_officephonenumbersme");
                dt.Columns.Add("new_marketresaech");
                dt.Columns.Add("address1_fax");
                dt.Columns.Add("exeseda_yooislegalservices");
                dt.Columns.Add("aging60");
                dt.Columns.Add("new_productscoring");
                dt.Columns.Add("exeseda_phonenumberlci");
                dt.Columns.Add("seda_productcategory");
                dt.Columns.Add("exeseda_websiteurllci");
                dt.Columns.Add("exeseda_namesme");
                dt.Columns.Add("accountcategorycode");
                dt.Columns.Add("seda_servicedemand");
                dt.Columns.Add("address1_name");
                dt.Columns.Add("exeseda_namelci");
                dt.Columns.Add("exeseda_tradelicence");
                dt.Columns.Add("aging30");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("exeseda_businessturnover");
                dt.Columns.Add("exeseda_officephonenumberlcf");
                dt.Columns.Add("seda_serviceprovideracceptancedate");
                dt.Columns.Add("new_finalscoreresult");
                dt.Columns.Add("new_scoresummary");
                dt.Columns.Add("preferredappointmentdaycode");
                dt.Columns.Add("exeseda_yooismarketingandadvertisingsuppo");
                dt.Columns.Add("address1_country");
                dt.Columns.Add("exeseda_timelinessstars");
                dt.Columns.Add("_parentaccountid_value");
                dt.Columns.Add("seda_businesstype_ex");
                dt.Columns.Add("exeseda_firstname");
                dt.Columns.Add("fax");
                dt.Columns.Add("seda_channeltomarketsalesprocessscoring");
                dt.Columns.Add("exeseda_yooisinformationmanagementsolutions");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("address2_telephone1");
                dt.Columns.Add("timespentbymeonemailandmeetings");
                dt.Columns.Add("exeseda_officeemailsme");
                dt.Columns.Add("stockexchange");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("aging90_base");
                dt.Columns.Add("tickersymbol");
                dt.Columns.Add("seda_serviceusage");
                dt.Columns.Add("seda_productname");
                dt.Columns.Add("new_whatdoesexcellencelooklikesales");
                dt.Columns.Add("ownershipcode");
                dt.Columns.Add("seda_marketresearchscoring");
                dt.Columns.Add("address2_fax");
                dt.Columns.Add("_exeseda_wcountryofwarehouses_value");
                dt.Columns.Add("aging60_base");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("_exeseda_servicecategory_value");
                dt.Columns.Add("customertypecode");
                dt.Columns.Add("exeseda_approximatecompanysize");
                dt.Columns.Add("new_whatdoesexcellencelooklikepricing");
                dt.Columns.Add("seda_scoring");
                dt.Columns.Add("emailaddress3");
                dt.Columns.Add("seda_commitmentvisionscoring");
                dt.Columns.Add("seda_otherservicesrecommendations");
                dt.Columns.Add("creditlimit");
                dt.Columns.Add("followemail");
                dt.Columns.Add("address2_longitude");
                dt.Columns.Add("new_salesprocess");
                dt.Columns.Add("seda_crstatus");
                dt.Columns.Add("address2_line2");
                dt.Columns.Add("seda_takenindepthassessment");
                dt.Columns.Add("revenue");
                dt.Columns.Add("address2_primarycontactname");
                dt.Columns.Add("seda_studiesremainingdownloads");
                dt.Columns.Add("new_commitmentandvision");
                dt.Columns.Add("new_scoresummarysales");
                dt.Columns.Add("exeseda_storageconditioncapabilities");
                dt.Columns.Add("exeseda_keyclients");
                dt.Columns.Add("seda_crurl");
                dt.Columns.Add("address1_city");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["address2_addresstypecode"] = dynObj.value[i].address2_addresstypecode == null ? null : Convert.ToInt32(dynObj.value[i].address2_addresstypecode);
                    _Ars["merged"] = dynObj.value[i].merged == null ? null : Convert.ToBoolean(dynObj.value[i].merged);
                    _Ars["accountnumber"] = (string)dynObj.value[i].accountnumber;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["seda_industrialcityplotnumber"] = (string)dynObj.value[i].seda_industrialcityplotnumber;
                    _Ars["seda_industrialcitynumber"] = (string)dynObj.value[i].seda_industrialcitynumber;
                    _Ars["emailaddress1"] = (string)dynObj.value[i].emailaddress1;
                    _Ars["seda_crissuingdate"] = (string)dynObj.value[i].seda_crissuingdate;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["seda_attention"] = (string)dynObj.value[i].seda_attention;
                    _Ars["openrevenue_state"] = dynObj.value[i].openrevenue_state == null ? null : Convert.ToInt32(dynObj.value[i].openrevenue_state);
                    _Ars["address1_postofficebox"] = (string)dynObj.value[i].address1_postofficebox;
                    _Ars["name"] = (string)dynObj.value[i].name;
                    _Ars["websiteurl"] = (string)dynObj.value[i].websiteurl;
                    _Ars["opendeals"] = dynObj.value[i].opendeals == null ? null : Convert.ToInt32(dynObj.value[i].opendeals);
                    _Ars["seda_companysizecode"] = dynObj.value[i].seda_companysizecode == null ? null : Convert.ToInt32(dynObj.value[i].seda_companysizecode);
                    _Ars["seda_segment"] = (string)dynObj.value[i].seda_segment;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["_primarycontactid_value"] = (string)dynObj.value[i]._primarycontactid_value;
                    _Ars["seda_crnexpirationdate"] = (string)dynObj.value[i].seda_crnexpirationdate;
                    _Ars["marketcap"] = (string)dynObj.value[i].marketcap;
                    _Ars["lastusedincampaign"] = (string)dynObj.value[i].lastusedincampaign;
                    _Ars["address1_shippingmethodcode"] = dynObj.value[i].address1_shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].address1_shippingmethodcode);
                    _Ars["seda_targetingwholesale"] = dynObj.value[i].seda_targetingwholesale == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingwholesale);
                    _Ars["address1_composite"] = (string)dynObj.value[i].address1_composite;
                    _Ars["donotpostalmail"] = dynObj.value[i].donotpostalmail == null ? null : Convert.ToBoolean(dynObj.value[i].donotpostalmail);
                    _Ars["accountratingcode"] = dynObj.value[i].accountratingcode == null ? null : Convert.ToInt32(dynObj.value[i].accountratingcode);
                    _Ars["seda_crntype"] = (string)dynObj.value[i].seda_crntype;
                    _Ars["donotphone"] = dynObj.value[i].donotphone == null ? null : Convert.ToBoolean(dynObj.value[i].donotphone);
                    _Ars["preferredcontactmethodcode"] = dynObj.value[i].preferredcontactmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].preferredcontactmethodcode);
                    _Ars["seda_generalmanagernam"] = (string)dynObj.value[i].seda_generalmanagernam;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["accountclassificationcode"] = dynObj.value[i].accountclassificationcode == null ? null : Convert.ToInt32(dynObj.value[i].accountclassificationcode);
                    _Ars["entityimage_timestamp"] = (string)dynObj.value[i].entityimage_timestamp;
                    _Ars["seda_exporteracceptancedate"] = (string)dynObj.value[i].seda_exporteracceptancedate;
                    _Ars["customersizecode"] = dynObj.value[i].customersizecode == null ? null : Convert.ToInt32(dynObj.value[i].customersizecode);
                    _Ars["_seda_country_value"] = (string)dynObj.value[i]._seda_country_value;
                    _Ars["seda_businesstype"] = dynObj.value[i].seda_businesstype == null ? null : Convert.ToInt32(dynObj.value[i].seda_businesstype);
                    _Ars["entityimage_url"] = (string)dynObj.value[i].entityimage_url;
                    _Ars["seda_targetingtrader"] = dynObj.value[i].seda_targetingtrader == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingtrader);
                    _Ars["openrevenue_base"] = (string)dynObj.value[i].openrevenue_base;
                    _Ars["businesstypecode"] = dynObj.value[i].businesstypecode == null ? null : Convert.ToInt32(dynObj.value[i].businesstypecode);
                    _Ars["donotemail"] = dynObj.value[i].donotemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotemail);
                    _Ars["opendeals_state"] = dynObj.value[i].opendeals_state == null ? null : Convert.ToInt32(dynObj.value[i].opendeals_state);
                    _Ars["address2_shippingmethodcode"] = dynObj.value[i].address2_shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].address2_shippingmethodcode);
                    _Ars["address1_telephone2"] = (string)dynObj.value[i].address1_telephone2;
                    _Ars["address1_telephone3"] = (string)dynObj.value[i].address1_telephone3;
                    _Ars["seda_emailverified"] = dynObj.value[i].seda_emailverified == null ? null : Convert.ToBoolean(dynObj.value[i].seda_emailverified);
                    _Ars["address1_telephone1"] = (string)dynObj.value[i].address1_telephone1;
                    _Ars["seda_isexporter"] = dynObj.value[i].seda_isexporter == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isexporter);
                    _Ars["address2_freighttermscode"] = dynObj.value[i].address2_freighttermscode == null ? null : Convert.ToInt32(dynObj.value[i].address2_freighttermscode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_targetingretailer"] = dynObj.value[i].seda_targetingretailer == null ? null : Convert.ToBoolean(dynObj.value[i].seda_targetingretailer);
                    _Ars["_seda_city_value"] = (string)dynObj.value[i]._seda_city_value;
                    _Ars["_originatingleadid_value"] = (string)dynObj.value[i]._originatingleadid_value;
                    _Ars["openrevenue"] = (string)dynObj.value[i].openrevenue;
                    _Ars["donotsendmm"] = dynObj.value[i].donotsendmm == null ? null : Convert.ToBoolean(dynObj.value[i].donotsendmm);
                    _Ars["donotfax"] = dynObj.value[i].donotfax == null ? null : Convert.ToBoolean(dynObj.value[i].donotfax);
                    _Ars["seda_accounttype"] = (string)dynObj.value[i].seda_accounttype;
                    _Ars["donotbulkpostalmail"] = dynObj.value[i].donotbulkpostalmail == null ? null : Convert.ToBoolean(dynObj.value[i].donotbulkpostalmail);
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["address1_line1"] = (string)dynObj.value[i].address1_line1;
                    _Ars["address1_line2"] = (string)dynObj.value[i].address1_line2;
                    _Ars["address1_line3"] = (string)dynObj.value[i].address1_line3;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["creditonhold"] = dynObj.value[i].creditonhold == null ? null : Convert.ToBoolean(dynObj.value[i].creditonhold);
                    _Ars["seda_iscreatedfromwebsite"] = dynObj.value[i].seda_iscreatedfromwebsite == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iscreatedfromwebsite);
                    _Ars["seda_iagreetopublishmyrepresentativepersoncont"] = dynObj.value[i].seda_iagreetopublishmyrepresentativepersoncont == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmyrepresentativepersoncont);
                    _Ars["seda_registrationdate"] = (string)dynObj.value[i].seda_registrationdate;
                    _Ars["_seda_exporterleadid_value"] = (string)dynObj.value[i]._seda_exporterleadid_value;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["seda_businesslegalstructuretxt"] = (string)dynObj.value[i].seda_businesslegalstructuretxt;
                    _Ars["accountid"] = (string)dynObj.value[i].accountid;
                    _Ars["address1_addresstypecode"] = dynObj.value[i].address1_addresstypecode == null ? null : Convert.ToInt32(dynObj.value[i].address1_addresstypecode);
                    _Ars["donotbulkemail"] = dynObj.value[i].donotbulkemail == null ? null : Convert.ToBoolean(dynObj.value[i].donotbulkemail);
                    _Ars["seda_industrialactivity"] = (string)dynObj.value[i].seda_industrialactivity;
                    _Ars["shippingmethodcode"] = dynObj.value[i].shippingmethodcode == null ? null : Convert.ToInt32(dynObj.value[i].shippingmethodcode);
                    _Ars["seda_arabicname"] = (string)dynObj.value[i].seda_arabicname;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["seda_iagreetopublishmycompanyinformation"] = dynObj.value[i].seda_iagreetopublishmycompanyinformation == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmycompanyinformation);
                    _Ars["entityimage"] = (string)dynObj.value[i].entityimage;
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["territorycode"] = dynObj.value[i].territorycode == null ? null : Convert.ToInt32(dynObj.value[i].territorycode);
                    _Ars["openrevenue_date"] = (string)dynObj.value[i].openrevenue_date;
                    _Ars["seda_allowedtosubmitincentiverequest"] = dynObj.value[i].seda_allowedtosubmitincentiverequest == null ? null : Convert.ToBoolean(dynObj.value[i].seda_allowedtosubmitincentiverequest);
                    _Ars["seda_exporterrequestdate"] = (string)dynObj.value[i].seda_exporterrequestdate;
                    _Ars["seda_iagreetopublishmyproductslistdetails"] = dynObj.value[i].seda_iagreetopublishmyproductslistdetails == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iagreetopublishmyproductslistdetails);
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["address1_addressid"] = (string)dynObj.value[i].address1_addressid;
                    _Ars["seda_factorycode"] = (string)dynObj.value[i].seda_factorycode;
                    _Ars["participatesinworkflow"] = dynObj.value[i].participatesinworkflow == null ? null : Convert.ToBoolean(dynObj.value[i].participatesinworkflow);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["address2_addressid"] = (string)dynObj.value[i].address2_addressid;
                    _Ars["address1_postalcode"] = (string)dynObj.value[i].address1_postalcode;
                    _Ars["marketcap_base"] = (string)dynObj.value[i].marketcap_base;
                    _Ars["entityimageid"] = (string)dynObj.value[i].entityimageid;
                    _Ars["seda_verifieddate"] = (string)dynObj.value[i].seda_verifieddate;
                    _Ars["opendeals_date"] = (string)dynObj.value[i].opendeals_date;
                    _Ars["exeseda_namelcf"] = (string)dynObj.value[i].exeseda_namelcf;
                    _Ars["address1_freighttermscode"] = (string)dynObj.value[i].address1_freighttermscode;
                    _Ars["seda_marketresearchselectionscoring"] = (string)dynObj.value[i].seda_marketresearchselectionscoring;
                    _Ars["telephone3"] = (string)dynObj.value[i].telephone3;
                    _Ars["new_channeltomarketsalesprocessscoringex"] = (string)dynObj.value[i].new_channeltomarketsalesprocessscoringex;
                    _Ars["exeseda_officefaxnumberlcf"] = (string)dynObj.value[i].exeseda_officefaxnumberlcf;
                    _Ars["seda_zakatcertificatetype"] = (string)dynObj.value[i].seda_zakatcertificatetype;
                    _Ars["exeseda_tradelicenceexpirydate"] = (string)dynObj.value[i].exeseda_tradelicenceexpirydate;
                    _Ars["exeseda_lastname"] = (string)dynObj.value[i].exeseda_lastname;
                    _Ars["new_marketresearchselectionscoringex"] = (string)dynObj.value[i].new_marketresearchselectionscoringex;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["address1_longitude"] = (string)dynObj.value[i].address1_longitude;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["exeseda_companyrepresentativefullname"] = (string)dynObj.value[i].exeseda_companyrepresentativefullname;
                    _Ars["_preferredsystemuserid_value"] = (string)dynObj.value[i]._preferredsystemuserid_value;
                    _Ars["exeseda_officeemaillci"] = (string)dynObj.value[i].exeseda_officeemaillci;
                    _Ars["exeseda_positionsme"] = (string)dynObj.value[i].exeseda_positionsme;
                    _Ars["exeseda_pricingstars"] = (string)dynObj.value[i].exeseda_pricingstars;
                    _Ars["exeseda_yooispackaging"] = (string)dynObj.value[i].exeseda_yooispackaging;
                    _Ars["creditlimit_base"] = (string)dynObj.value[i].creditlimit_base;
                    _Ars["seda_staffattituderate"] = (string)dynObj.value[i].seda_staffattituderate;
                    _Ars["exeseda_customeryearsofexperience"] = (string)dynObj.value[i].exeseda_customeryearsofexperience;
                    _Ars["seda_interestedinmarketresearch"] = dynObj.value[i].seda_interestedinmarketresearch == null ? null : Convert.ToBoolean(dynObj.value[i].seda_interestedinmarketresearch);
                    _Ars["exeseda_websiteurlsme"] = (string)dynObj.value[i].exeseda_websiteurlsme;
                    _Ars["seda_entityttype"] = (string)dynObj.value[i].seda_entityttype;
                    _Ars["new_whatdoesexcellencelooklikemarket"] = (string)dynObj.value[i].new_whatdoesexcellencelooklikemarket;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["preferredappointmenttimecode"] = (string)dynObj.value[i].preferredappointmenttimecode;
                    _Ars["_exeseda_ccexitportsea_value"] = (string)dynObj.value[i]._exeseda_ccexitportsea_value;
                    _Ars["address2_name"] = (string)dynObj.value[i].address2_name;
                    _Ars["seda_interestedintrademissions"] = dynObj.value[i].seda_interestedintrademissions == null ? null : Convert.ToBoolean(dynObj.value[i].seda_interestedintrademissions);
                    _Ars["seda_zakatexpgregorian"] = (string)dynObj.value[i].seda_zakatexpgregorian;
                    _Ars["seda_exporterrevenue"] = (string)dynObj.value[i].seda_exporterrevenue;
                    _Ars["address2_upszone"] = (string)dynObj.value[i].address2_upszone;
                    _Ars["exeseda_phonenumbersme"] = (string)dynObj.value[i].exeseda_phonenumbersme;
                    _Ars["seda_valueofmoneyrate"] = (string)dynObj.value[i].seda_valueofmoneyrate;
                    _Ars["seda_zakatcertificate"] = (string)dynObj.value[i].seda_zakatcertificate;
                    _Ars["_preferredequipmentid_value"] = (string)dynObj.value[i]._preferredequipmentid_value;
                    _Ars["exeseda_yearsofoperationinservicetailored"] = (string)dynObj.value[i].exeseda_yearsofoperationinservicetailored;
                    _Ars["seda_isassesmentrenewalrequired"] = (string)dynObj.value[i].seda_isassesmentrenewalrequired;
                    _Ars["exeseda_yooisci"] = (string)dynObj.value[i].exeseda_yooisci;
                    _Ars["emailaddress2"] = (string)dynObj.value[i].emailaddress2;
                    _Ars["exeseda_emaillcf"] = (string)dynObj.value[i].exeseda_emaillcf;
                    _Ars["exeseda_yooisairfreightexpress"] = (string)dynObj.value[i].exeseda_yooisairfreightexpress;
                    _Ars["seda_zakatservicemodifieddate"] = (string)dynObj.value[i].seda_zakatservicemodifieddate;
                    _Ars["exeseda_buyername"] = (string)dynObj.value[i].exeseda_buyername;
                    _Ars["address1_stateorprovince"] = (string)dynObj.value[i].address1_stateorprovince;
                    _Ars["seda_interestedinworkshop"] = dynObj.value[i].seda_interestedinworkshop == null ? null : Convert.ToBoolean(dynObj.value[i].seda_interestedinworkshop);
                    _Ars["exeseda_professionalismstars"] = (string)dynObj.value[i].exeseda_professionalismstars;
                    _Ars["_seda_sector_value"] = (string)dynObj.value[i]._seda_sector_value;
                    _Ars["exeseda_numberofemployees"] = (string)dynObj.value[i].exeseda_numberofemployees;
                    _Ars["new_blocked"] = (string)dynObj.value[i].new_blocked;
                    _Ars["seda_idurl"] = (string)dynObj.value[i].seda_idurl;
                    _Ars["exeseda_brochurestatus"] = (string)dynObj.value[i].exeseda_brochurestatus;
                    _Ars["address2_city"] = (string)dynObj.value[i].address2_city;
                    _Ars["seda_zakatlicesnseno"] = (string)dynObj.value[i].seda_zakatlicesnseno;
                    _Ars["exeseda_yearsofoperationinservicetraining"] = (string)dynObj.value[i].exeseda_yearsofoperationinservicetraining;
                    _Ars["address1_upszone"] = (string)dynObj.value[i].address1_upszone;
                    _Ars["_seda_serviceproviderlead_value"] = (string)dynObj.value[i]._seda_serviceproviderlead_value;
                    _Ars["new_attendedevents"] = (string)dynObj.value[i].new_attendedevents;
                    _Ars["exeseda_positionlci"] = (string)dynObj.value[i].exeseda_positionlci;
                    _Ars["exeseda_accountcontactlastname"] = (string)dynObj.value[i].exeseda_accountcontactlastname;
                    _Ars["exeseda_officeemaillcf"] = (string)dynObj.value[i].exeseda_officeemaillcf;
                    _Ars["exeseda_preferredcommunicationarabiclanguage"] = (string)dynObj.value[i].exeseda_preferredcommunicationarabiclanguage;
                    _Ars["seda_totalrate"] = (string)dynObj.value[i].seda_totalrate;
                    _Ars["_seda_assessors_value"] = (string)dynObj.value[i]._seda_assessors_value;
                    _Ars["exeseda_registrationenddate"] = (string)dynObj.value[i].exeseda_registrationenddate;
                    _Ars["exeseda_positionlcf"] = (string)dynObj.value[i].exeseda_positionlcf;
                    _Ars["_masterid_value"] = (string)dynObj.value[i]._masterid_value;
                    _Ars["seda_strategicclient"] = (string)dynObj.value[i].seda_strategicclient;
                    _Ars["exeseda_preferredcommunicationtypedirect"] = (string)dynObj.value[i].exeseda_preferredcommunicationtypedirect;
                    _Ars["exeseda_officefaxnumbersme"] = (string)dynObj.value[i].exeseda_officefaxnumbersme;
                    _Ars["address2_latitude"] = (string)dynObj.value[i].address2_latitude;
                    _Ars["exeseda_ischampion"] = (string)dynObj.value[i].exeseda_ischampion;
                    _Ars["new_pricingandfundingscoring"] = (string)dynObj.value[i].new_pricingandfundingscoring;
                    _Ars["_territoryid_value"] = (string)dynObj.value[i]._territoryid_value;
                    _Ars["address2_utcoffset"] = (string)dynObj.value[i].address2_utcoffset;
                    _Ars["aging30_base"] = (string)dynObj.value[i].aging30_base;
                    _Ars["exeseda_qualityofservicestars"] = (string)dynObj.value[i].exeseda_qualityofservicestars;
                    _Ars["seda_arabicbio"] = (string)dynObj.value[i].seda_arabicbio;
                    _Ars["telephone2"] = (string)dynObj.value[i].telephone2;
                    _Ars["exeseda_yooisairfreightcargocustomsclearance"] = (string)dynObj.value[i].exeseda_yooisairfreightcargocustomsclearance;
                    _Ars["telephone1"] = (string)dynObj.value[i].telephone1;
                    _Ars["seda_exporterrevenuepercentage"] = (string)dynObj.value[i].seda_exporterrevenuepercentage;
                    _Ars["exeseda_vatcertificatenumberlcf"] = (string)dynObj.value[i].exeseda_vatcertificatenumberlcf;
                    _Ars["_exeseda_cargotypehandledhscode_value"] = (string)dynObj.value[i]._exeseda_cargotypehandledhscode_value;
                    _Ars["new_pricingandfunding"] = (string)dynObj.value[i].new_pricingandfunding;
                    _Ars["paymenttermscode"] = (string)dynObj.value[i].paymenttermscode;
                    _Ars["new_comments"] = (string)dynObj.value[i].new_comments;
                    _Ars["address2_line3"] = (string)dynObj.value[i].address2_line3;
                    _Ars["_modifiedbyexternalparty_value"] = (string)dynObj.value[i]._modifiedbyexternalparty_value;
                    _Ars["exeseda_airfreightcargoiatanumber"] = (string)dynObj.value[i].exeseda_airfreightcargoiatanumber;
                    _Ars["_exeseda_serviceprovidercity_value"] = (string)dynObj.value[i]._exeseda_serviceprovidercity_value;
                    _Ars["exeseda_serviceprovidertype"] = (string)dynObj.value[i].exeseda_serviceprovidertype;
                    _Ars["new_whatdoesexcellencelooklikeproduct"] = (string)dynObj.value[i].new_whatdoesexcellencelooklikeproduct;
                    _Ars["address2_country"] = (string)dynObj.value[i].address2_country;
                    _Ars["exeseda_championfromdate"] = (string)dynObj.value[i].exeseda_championfromdate;
                    _Ars["address2_postofficebox"] = (string)dynObj.value[i].address2_postofficebox;
                    _Ars["exeseda_websiteurllcf"] = (string)dynObj.value[i].exeseda_websiteurllcf;
                    _Ars["seda_zakatexphijri"] = (string)dynObj.value[i].seda_zakatexphijri;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["exeseda_yooiscargoinsurance"] = (string)dynObj.value[i].exeseda_yooiscargoinsurance;
                    _Ars["industrycode"] = (string)dynObj.value[i].industrycode;
                    _Ars["exeseda_emailsme"] = (string)dynObj.value[i].exeseda_emailsme;
                    _Ars["address1_primarycontactname"] = (string)dynObj.value[i].address1_primarycontactname;
                    _Ars["_seda_customsmsactivity_value"] = (string)dynObj.value[i]._seda_customsmsactivity_value;
                    _Ars["yominame"] = (string)dynObj.value[i].yominame;
                    _Ars["_defaultpricelevelid_value"] = (string)dynObj.value[i]._defaultpricelevelid_value;
                    _Ars["_exeseda_exporterclassification_value"] = (string)dynObj.value[i]._exeseda_exporterclassification_value;
                    _Ars["address2_telephone2"] = (string)dynObj.value[i].address2_telephone2;
                    _Ars["seda_businesstype_if"] = (string)dynObj.value[i].seda_businesstype_if;
                    _Ars["seda_blacklistedforincentive"] = (string)dynObj.value[i].seda_blacklistedforincentive;
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["exeseda_vatcertificatenumberlci"] = (string)dynObj.value[i].exeseda_vatcertificatenumberlci;
                    _Ars["_preferredserviceid_value"] = (string)dynObj.value[i]._preferredserviceid_value;
                    _Ars["address2_composite"] = (string)dynObj.value[i].address2_composite;
                    _Ars["exeseda_officephonenumberlci"] = (string)dynObj.value[i].exeseda_officephonenumberlci;
                    _Ars["exeseda_accountcontactfirstname"] = (string)dynObj.value[i].exeseda_accountcontactfirstname;
                    _Ars["exeseda_annualexportvalue"] = (string)dynObj.value[i].exeseda_annualexportvalue;
                    _Ars["seda_delegationurl"] = (string)dynObj.value[i].seda_delegationurl;
                    _Ars["_exeseda_serviceprovidercountry_value"] = (string)dynObj.value[i]._exeseda_serviceprovidercountry_value;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    _Ars["seda_productcode"] = (string)dynObj.value[i].seda_productcode;
                    _Ars["seda_zakatserviceerror"] = (string)dynObj.value[i].seda_zakatserviceerror;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["new_marketselection"] = (string)dynObj.value[i].new_marketselection;
                    _Ars["seda_zakatnumber"] = (string)dynObj.value[i].seda_zakatnumber;
                    _Ars["new_scoresummarypricing"] = (string)dynObj.value[i].new_scoresummarypricing;
                    _Ars["seda_serviceproviderrequestdate"] = (string)dynObj.value[i].seda_serviceproviderrequestdate;
                    _Ars["exeseda_emaillci"] = (string)dynObj.value[i].exeseda_emaillci;
                    _Ars["new_scoresummaryvision"] = (string)dynObj.value[i].new_scoresummaryvision;
                    _Ars["exeseda_yooisairfreightcargo"] = (string)dynObj.value[i].exeseda_yooisairfreightcargo;
                    _Ars["new_currentassessment"] = (string)dynObj.value[i].new_currentassessment;
                    _Ars["_new_manager_value"] = (string)dynObj.value[i]._new_manager_value;
                    _Ars["exeseda_phonenumberlcf"] = (string)dynObj.value[i].exeseda_phonenumberlcf;
                    _Ars["address2_county"] = (string)dynObj.value[i].address2_county;
                    _Ars["exeseda_sizeperstoragecondition"] = (string)dynObj.value[i].exeseda_sizeperstoragecondition;
                    _Ars["exeseda_brochureapprovaldatetime"] = (string)dynObj.value[i].exeseda_brochureapprovaldatetime;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["new_pricingfundingexportdrivescoringex"] = (string)dynObj.value[i].new_pricingfundingexportdrivescoringex;
                    _Ars["primarysatoriid"] = (string)dynObj.value[i].primarysatoriid;
                    _Ars["exeseda_knowhowonexportdescription"] = (string)dynObj.value[i].exeseda_knowhowonexportdescription;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["primarytwitterid"] = (string)dynObj.value[i].primarytwitterid;
                    _Ars["_exeseda_exeseda_contactposition_value"] = (string)dynObj.value[i]._exeseda_exeseda_contactposition_value;
                    _Ars["seda_prioritycustomer"] = dynObj.value[i].seda_prioritycustomer == null ? null : Convert.ToBoolean(dynObj.value[i].seda_prioritycustomer);
                    _Ars["ftpsiteurl"] = (string)dynObj.value[i].ftpsiteurl;
                    _Ars["sic"] = (string)dynObj.value[i].sic;
                    _Ars["seda_reason"] = (string)dynObj.value[i].seda_reason;
                    _Ars["sharesoutstanding"] = (string)dynObj.value[i].sharesoutstanding;
                    _Ars["_exeseda_accountcontactposition_value"] = (string)dynObj.value[i]._exeseda_accountcontactposition_value;
                    _Ars["seda_qualityofworkrate"] = (string)dynObj.value[i].seda_qualityofworkrate;
                    _Ars["numberofemployees"] = (string)dynObj.value[i].numberofemployees;
                    _Ars["seda_visitdate"] = (string)dynObj.value[i].seda_visitdate;
                    _Ars["seda_exporterrevenue_base"] = (string)dynObj.value[i].seda_exporterrevenue_base;
                    _Ars["new_productsservicesscoringex"] = (string)dynObj.value[i].new_productsservicesscoringex;
                    _Ars["exeseda_yooistestingandcertification"] = (string)dynObj.value[i].exeseda_yooistestingandcertification;
                    _Ars["seda_crissuedby"] = (string)dynObj.value[i].seda_crissuedby;
                    _Ars["exeseda_yooislandfreight"] = (string)dynObj.value[i].exeseda_yooislandfreight;
                    _Ars["address1_utcoffset"] = (string)dynObj.value[i].address1_utcoffset;
                    _Ars["exeseda_preferredcommunicationtypefromportal"] = (string)dynObj.value[i].exeseda_preferredcommunicationtypefromportal;
                    _Ars["exeseda_modeofshipment"] = (string)dynObj.value[i].exeseda_modeofshipment;
                    _Ars["revenue_base"] = (string)dynObj.value[i].revenue_base;
                    _Ars["marketingonly"] = (string)dynObj.value[i].marketingonly;
                    _Ars["address2_telephone3"] = (string)dynObj.value[i].address2_telephone3;
                    _Ars["new_scoresummarymarket"] = (string)dynObj.value[i].new_scoresummarymarket;
                    _Ars["address1_latitude"] = (string)dynObj.value[i].address1_latitude;
                    _Ars["exeseda_yooiswarehousing"] = (string)dynObj.value[i].exeseda_yooiswarehousing;
                    _Ars["seda_zakattinnumber"] = (string)dynObj.value[i].seda_zakattinnumber;
                    _Ars["seda_verificationcode"] = (string)dynObj.value[i].seda_verificationcode;
                    _Ars["new_scoresummaryproduct"] = (string)dynObj.value[i].new_scoresummaryproduct;
                    _Ars["seda_businesslegalstructure"] = (string)dynObj.value[i].seda_businesslegalstructure;
                    _Ars["seda_zakatissuedatehijri"] = (string)dynObj.value[i].seda_zakatissuedatehijri;
                    _Ars["address2_line1"] = (string)dynObj.value[i].address2_line1;
                    _Ars["exeseda_championtodate"] = (string)dynObj.value[i].exeseda_championtodate;
                    _Ars["new_marketresearchscoringex"] = (string)dynObj.value[i].new_marketresearchscoringex;
                    _Ars["seda_englishbio"] = (string)dynObj.value[i].seda_englishbio;
                    _Ars["seda_mainactivity"] = (string)dynObj.value[i].seda_mainactivity;
                    _Ars["new_whatdoesexcellencelooklikevision"] = (string)dynObj.value[i].new_whatdoesexcellencelooklikevision;
                    _Ars["exeseda_officefaxnumberlci"] = (string)dynObj.value[i].exeseda_officefaxnumberlci;
                    _Ars["exeseda_yooisseafreight"] = (string)dynObj.value[i].exeseda_yooisseafreight;
                    _Ars["address2_postalcode"] = (string)dynObj.value[i].address2_postalcode;
                    _Ars["seda_gosicertificate"] = (string)dynObj.value[i].seda_gosicertificate;
                    _Ars["seda_thiqaexpirydate"] = (string)dynObj.value[i].seda_thiqaexpirydate;
                    _Ars["seda_thiqaactivites"] = (string)dynObj.value[i].seda_thiqaactivites;
                    _Ars["new_commitmentvisionscoringex"] = (string)dynObj.value[i].new_commitmentvisionscoringex;
                    _Ars["exeseda_isbrochureuploaded"] = (string)dynObj.value[i].exeseda_isbrochureuploaded;
                    _Ars["seda_punctualityrate"] = (string)dynObj.value[i].seda_punctualityrate;
                    _Ars["address2_stateorprovince"] = (string)dynObj.value[i].address2_stateorprovince;
                    _Ars["seda_thiqaissuedate"] = (string)dynObj.value[i].seda_thiqaissuedate;
                    _Ars["exeseda_preferredcommunicationenglishlanguage"] = (string)dynObj.value[i].exeseda_preferredcommunicationenglishlanguage;
                    _Ars["exeseda_buyerarabicname"] = (string)dynObj.value[i].exeseda_buyerarabicname;
                    _Ars["exeseda_airfreightexpressiatanumber"] = (string)dynObj.value[i].exeseda_airfreightexpressiatanumber;
                    _Ars["exeseda_yoowebsitesetup"] = (string)dynObj.value[i].exeseda_yoowebsitesetup;
                    _Ars["seda_pricingfundingexportdrivescoring"] = (string)dynObj.value[i].seda_pricingfundingexportdrivescoring;
                    _Ars["seda_productservicetype"] = (string)dynObj.value[i].seda_productservicetype;
                    _Ars["seda_productsservicesscoring"] = (string)dynObj.value[i].seda_productsservicesscoring;
                    _Ars["exeseda_keyprojectsundertaken"] = (string)dynObj.value[i].exeseda_keyprojectsundertaken;
                    _Ars["aging90"] = (string)dynObj.value[i].aging90;
                    _Ars["_exeseda_coveredareaid_value"] = (string)dynObj.value[i]._exeseda_coveredareaid_value;
                    _Ars["exeseda_vatcertificatenumbersme"] = (string)dynObj.value[i].exeseda_vatcertificatenumbersme;
                    _Ars["seda_nterestedinxhibitions"] = dynObj.value[i].seda_nterestedinxhibitions == null ? null : Convert.ToBoolean(dynObj.value[i].seda_nterestedinxhibitions);
                    _Ars["_createdbyexternalparty_value"] = (string)dynObj.value[i]._createdbyexternalparty_value;
                    _Ars["_exeseda_ccexitportland_value"] = (string)dynObj.value[i]._exeseda_ccexitportland_value;
                    _Ars["_exeseda_ccexitportair_value"] = (string)dynObj.value[i]._exeseda_ccexitportair_value;
                    _Ars["seda_zakatissuedategregorian"] = (string)dynObj.value[i].seda_zakatissuedategregorian;
                    _Ars["exeseda_businessregistrationnumber"] = (string)dynObj.value[i].exeseda_businessregistrationnumber;
                    _Ars["address1_county"] = (string)dynObj.value[i].address1_county;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["exeseda_officephonenumbersme"] = (string)dynObj.value[i].exeseda_officephonenumbersme;
                    _Ars["new_marketresaech"] = (string)dynObj.value[i].new_marketresaech;
                    _Ars["address1_fax"] = (string)dynObj.value[i].address1_fax;
                    _Ars["exeseda_yooislegalservices"] = (string)dynObj.value[i].exeseda_yooislegalservices;
                    _Ars["aging60"] = (string)dynObj.value[i].aging60;
                    _Ars["new_productscoring"] = (string)dynObj.value[i].new_productscoring;
                    _Ars["exeseda_phonenumberlci"] = (string)dynObj.value[i].exeseda_phonenumberlci;
                    _Ars["seda_productcategory"] = (string)dynObj.value[i].seda_productcategory;
                    _Ars["exeseda_websiteurllci"] = (string)dynObj.value[i].exeseda_websiteurllci;
                    _Ars["exeseda_namesme"] = (string)dynObj.value[i].exeseda_namesme;
                    _Ars["accountcategorycode"] = (string)dynObj.value[i].accountcategorycode;
                    _Ars["seda_servicedemand"] = (string)dynObj.value[i].seda_servicedemand;
                    _Ars["address1_name"] = (string)dynObj.value[i].address1_name;
                    _Ars["exeseda_namelci"] = (string)dynObj.value[i].exeseda_namelci;
                    _Ars["exeseda_tradelicence"] = (string)dynObj.value[i].exeseda_tradelicence;
                    _Ars["aging30"] = (string)dynObj.value[i].aging30;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["exeseda_businessturnover"] = (string)dynObj.value[i].exeseda_businessturnover;
                    _Ars["exeseda_officephonenumberlcf"] = (string)dynObj.value[i].exeseda_officephonenumberlcf;
                    _Ars["seda_serviceprovideracceptancedate"] = (string)dynObj.value[i].seda_serviceprovideracceptancedate;
                    _Ars["new_finalscoreresult"] = (string)dynObj.value[i].new_finalscoreresult;
                    _Ars["new_scoresummary"] = (string)dynObj.value[i].new_scoresummary;
                    _Ars["preferredappointmentdaycode"] = (string)dynObj.value[i].preferredappointmentdaycode;
                    _Ars["exeseda_yooismarketingandadvertisingsuppo"] = (string)dynObj.value[i].exeseda_yooismarketingandadvertisingsuppo;
                    _Ars["address1_country"] = (string)dynObj.value[i].address1_country;
                    _Ars["exeseda_timelinessstars"] = (string)dynObj.value[i].exeseda_timelinessstars;
                    _Ars["_parentaccountid_value"] = (string)dynObj.value[i]._parentaccountid_value;
                    _Ars["seda_businesstype_ex"] = (string)dynObj.value[i].seda_businesstype_ex;
                    _Ars["exeseda_firstname"] = (string)dynObj.value[i].exeseda_firstname;
                    _Ars["fax"] = (string)dynObj.value[i].fax;
                    _Ars["seda_channeltomarketsalesprocessscoring"] = (string)dynObj.value[i].seda_channeltomarketsalesprocessscoring;
                    _Ars["exeseda_yooisinformationmanagementsolutions"] = (string)dynObj.value[i].exeseda_yooisinformationmanagementsolutions;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["address2_telephone1"] = (string)dynObj.value[i].address2_telephone1;
                    _Ars["timespentbymeonemailandmeetings"] = (string)dynObj.value[i].timespentbymeonemailandmeetings;
                    _Ars["exeseda_officeemailsme"] = (string)dynObj.value[i].exeseda_officeemailsme;
                    _Ars["stockexchange"] = (string)dynObj.value[i].stockexchange;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["aging90_base"] = (string)dynObj.value[i].aging90_base;
                    _Ars["tickersymbol"] = (string)dynObj.value[i].tickersymbol;
                    _Ars["seda_serviceusage"] = (string)dynObj.value[i].seda_serviceusage;
                    _Ars["seda_productname"] = (string)dynObj.value[i].seda_productname;
                    _Ars["new_whatdoesexcellencelooklikesales"] = (string)dynObj.value[i].new_whatdoesexcellencelooklikesales;
                    _Ars["ownershipcode"] = (string)dynObj.value[i].ownershipcode;
                    _Ars["seda_marketresearchscoring"] = (string)dynObj.value[i].seda_marketresearchscoring;
                    _Ars["address2_fax"] = (string)dynObj.value[i].address2_fax;
                    _Ars["_exeseda_wcountryofwarehouses_value"] = (string)dynObj.value[i]._exeseda_wcountryofwarehouses_value;
                    _Ars["aging60_base"] = (string)dynObj.value[i].aging60_base;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["_exeseda_servicecategory_value"] = (string)dynObj.value[i]._exeseda_servicecategory_value;
                    _Ars["customertypecode"] = (string)dynObj.value[i].customertypecode;
                    _Ars["exeseda_approximatecompanysize"] = (string)dynObj.value[i].exeseda_approximatecompanysize;
                    _Ars["new_whatdoesexcellencelooklikepricing"] = (string)dynObj.value[i].new_whatdoesexcellencelooklikepricing;
                    _Ars["seda_scoring"] = (string)dynObj.value[i].seda_scoring;
                    _Ars["emailaddress3"] = (string)dynObj.value[i].emailaddress3;
                    _Ars["seda_commitmentvisionscoring"] = (string)dynObj.value[i].seda_commitmentvisionscoring;
                    _Ars["seda_otherservicesrecommendations"] = (string)dynObj.value[i].seda_otherservicesrecommendations;
                    _Ars["creditlimit"] = (string)dynObj.value[i].creditlimit;
                    _Ars["followemail"] = (string)dynObj.value[i].followemail;
                    _Ars["address2_longitude"] = (string)dynObj.value[i].address2_longitude;
                    _Ars["new_salesprocess"] = (string)dynObj.value[i].new_salesprocess;
                    _Ars["seda_crstatus"] = (string)dynObj.value[i].seda_crstatus;
                    _Ars["address2_line2"] = (string)dynObj.value[i].address2_line2;
                    _Ars["seda_takenindepthassessment"] = dynObj.value[i].seda_takenindepthassessment == null ? null : Convert.ToBoolean(dynObj.value[i].seda_takenindepthassessment);
                    _Ars["revenue"] = (string)dynObj.value[i].revenue;
                    _Ars["address2_primarycontactname"] = (string)dynObj.value[i].address2_primarycontactname;
                    _Ars["seda_studiesremainingdownloads"] = (string)dynObj.value[i].seda_studiesremainingdownloads;
                    _Ars["new_commitmentandvision"] = (string)dynObj.value[i].new_commitmentandvision;
                    _Ars["new_scoresummarysales"] = (string)dynObj.value[i].new_scoresummarysales;
                    _Ars["exeseda_storageconditioncapabilities"] = (string)dynObj.value[i].exeseda_storageconditioncapabilities;
                    _Ars["exeseda_keyclients"] = (string)dynObj.value[i].exeseda_keyclients;
                    _Ars["seda_crurl"] = (string)dynObj.value[i].seda_crurl;
                    _Ars["address1_city"] = (string)dynObj.value[i].address1_city;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Accounts_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Accounts_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Incidents
        public static void Incidents(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Incidents", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("severitycode");
                dt.Columns.Add("incidentid");
                dt.Columns.Add("blockedprofile");
                dt.Columns.Add("merged");
                dt.Columns.Add("isescalated");
                dt.Columns.Add("seda_isindustrywithintargetedsegments");
                dt.Columns.Add("title");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("servicestage");
                dt.Columns.Add("seda_caseassignmentflag");
                dt.Columns.Add("_seda_casecategory_value");
                dt.Columns.Add("_primarycontactid_value");
                dt.Columns.Add("_seda_subcategory_value");
                dt.Columns.Add("resolvebyslastatus");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("description");
                dt.Columns.Add("seda_newstatussettime");
                dt.Columns.Add("stageid");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_isissuerelevanttosector");
                dt.Columns.Add("decremententitlementterm");
                dt.Columns.Add("routecase");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("seda_wastopmanagementinvolved");
                dt.Columns.Add("processid");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("followuptaskcreated");
                dt.Columns.Add("firstresponsesent");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("firstresponseslastatus");
                dt.Columns.Add("seda_cancellationreason");
                dt.Columns.Add("caseorigincode");
                dt.Columns.Add("isdecrementing");
                dt.Columns.Add("activitiescomplete");
                dt.Columns.Add("_seda_department_value");
                dt.Columns.Add("customercontacted");
                dt.Columns.Add("seda_casetypec");
                dt.Columns.Add("checkemail");
                dt.Columns.Add("seda_canceledfromwebsite");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("ticketnumber");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("seda_iscasecategorychanged");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("seda_issuerequiredifferentapproach");
                dt.Columns.Add("incidentstagecode");
                dt.Columns.Add("statecode");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("seda_othercategory");
                dt.Columns.Add("_customerid_value");
                dt.Columns.Add("seda_othersubcategory");
                dt.Columns.Add("seda_resolvable");
                dt.Columns.Add("seda_impactcategory");
                dt.Columns.Add("_seda_existingotherevent_value");
                dt.Columns.Add("seda_barrieruser");
                dt.Columns.Add("_subjectid_value");
                dt.Columns.Add("seda_reporttxt");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_seda_barriertypen_value");
                dt.Columns.Add("_parentcaseid_value");
                dt.Columns.Add("seda_impactseverity");
                dt.Columns.Add("_seda_caseassignmentid_value");
                dt.Columns.Add("entityimageid");
                dt.Columns.Add("seda_impactassessed");
                dt.Columns.Add("_contractdetailid_value");
                dt.Columns.Add("productserialnumber");
                dt.Columns.Add("_modifiedbyexternalparty_value");
                dt.Columns.Add("seda_impacttypes");
                dt.Columns.Add("_seda_cities_value");
                dt.Columns.Add("seda_exportenablementurgency");
                dt.Columns.Add("sentimentvalue");
                dt.Columns.Add("seda_duration");
                dt.Columns.Add("emailaddress");
                dt.Columns.Add("responseby");
                dt.Columns.Add("seda_casebarrierportalfield_name");
                dt.Columns.Add("billedserviceunits");
                dt.Columns.Add("_firstresponsebykpiid_value");
                dt.Columns.Add("contractservicelevelcode");
                dt.Columns.Add("seda_exportenablementpriority");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("_seda_country_value");
                dt.Columns.Add("seda_relevantstockholders");
                dt.Columns.Add("seda_casebarrierportalfield_lname");
                dt.Columns.Add("_slaid_value");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("followupby");
                dt.Columns.Add("seda_resolution");
                dt.Columns.Add("exeseda_inquirytype");
                dt.Columns.Add("seda_issuedate");
                dt.Columns.Add("_masterid_value");
                dt.Columns.Add("seda_tradebarrierfeedback");
                dt.Columns.Add("_seda_casedepartments_value");
                dt.Columns.Add("seda_existingothereventselection");
                dt.Columns.Add("seda_rootcauseanalyzed");
                dt.Columns.Add("seda_mobile");
                dt.Columns.Add("_seda_lead_value");
                dt.Columns.Add("_seda_tempcontact_value");
                dt.Columns.Add("seda_estresolutiondateidentified");
                dt.Columns.Add("seda_exportenablementteamcomment");
                dt.Columns.Add("_existingcase_value");
                dt.Columns.Add("entityimage");
                dt.Columns.Add("_productid_value");
                dt.Columns.Add("_seda_slalookup_value");
                dt.Columns.Add("_kbarticleid_value");
                dt.Columns.Add("seda_exportenablementresolutionmethod");
                dt.Columns.Add("messagetypecode");
                dt.Columns.Add("lastonholdtime");
                dt.Columns.Add("_seda_participant_value");
                dt.Columns.Add("seda_holdassignment");
                dt.Columns.Add("_exeseda_buyerid_value");
                dt.Columns.Add("exchangerate");
                dt.Columns.Add("seda_barrierclassification");
                dt.Columns.Add("_accountid_value");
                dt.Columns.Add("_resolvebykpiid_value");
                dt.Columns.Add("seda_impactofsolution");
                dt.Columns.Add("seda_reviewprovided");
                dt.Columns.Add("entityimage_timestamp");
                dt.Columns.Add("seda_ticketnumber");
                dt.Columns.Add("traversedpath");
                dt.Columns.Add("seda_exportenablementstatus");
                dt.Columns.Add("_contractid_value");
                dt.Columns.Add("seda_relevantstakeholdersidentified");
                dt.Columns.Add("seda_caseownerassigned");
                dt.Columns.Add("prioritycode");
                dt.Columns.Add("seda_casebarrierportalfield_mobile");
                dt.Columns.Add("escalatedon");
                dt.Columns.Add("seda_freqoffollowupidentified");
                dt.Columns.Add("seda_appropiratesolutionselected");
                dt.Columns.Add("seda_othercasetypetxt");
                dt.Columns.Add("exeseda_buyerfeedback");
                dt.Columns.Add("seda_procedurestakentoresolvethebarrier");
                dt.Columns.Add("seda_casebarrierportalfield_email");
                dt.Columns.Add("onholdtime");
                dt.Columns.Add("_transactioncurrencyid_value");
                dt.Columns.Add("entityimage_url");
                dt.Columns.Add("_seda_barriertyper_value");
                dt.Columns.Add("_seda_industry_value");
                dt.Columns.Add("_seda_genralcategoryr_value");
                dt.Columns.Add("seda_barrierclassificationidentified");
                dt.Columns.Add("seda_exportenablementbarriertype");
                dt.Columns.Add("numberofchildincidents");
                dt.Columns.Add("seda_suggestedsolution");
                dt.Columns.Add("seda_othereventtxt");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("resolveby");
                dt.Columns.Add("seda_subject");
                dt.Columns.Add("seda_crnumbertxt");
                dt.Columns.Add("seda_eeresolutionmethod");
                dt.Columns.Add("_seda_position_value");
                dt.Columns.Add("actualserviceunits");
                dt.Columns.Add("seda_firstassignmentdate");
                dt.Columns.Add("_seda_year_value");
                dt.Columns.Add("influencescore");
                dt.Columns.Add("seda_casebarrier_estdresolutiondate");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("customersatisfactioncode");
                dt.Columns.Add("seda_businessdevteamcomments");
                dt.Columns.Add("_seda_caseservices_value");
                dt.Columns.Add("_socialprofileid_value");
                dt.Columns.Add("seda_assignedtoagencydate");
                dt.Columns.Add("seda_email");
                dt.Columns.Add("_entitlementid_value");
                dt.Columns.Add("seda_barriertype");
                dt.Columns.Add("seda_exportenablementagency");
                dt.Columns.Add("_seda_sector_value");
                dt.Columns.Add("_createdbyexternalparty_value");
                dt.Columns.Add("seda_resolutiondate");
                dt.Columns.Add("casetypecode");
                dt.Columns.Add("seda_cname");
                dt.Columns.Add("seda_barrierclassificationtxt");
                dt.Columns.Add("seda_assignedtoeeteam");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("_seda_events_value");
                dt.Columns.Add("seda_planofimplementationdefined");
                dt.Columns.Add("_contactid_value");
                dt.Columns.Add("_slainvokedid_value");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["severitycode"] = dynObj.value[i].severitycode == null ? null : Convert.ToInt32(dynObj.value[i].severitycode);
                    _Ars["incidentid"] = (string)dynObj.value[i].incidentid;
                    _Ars["blockedprofile"] = dynObj.value[i].blockedprofile == null ? null : Convert.ToBoolean(dynObj.value[i].blockedprofile);
                    _Ars["merged"] = dynObj.value[i].merged == null ? null : Convert.ToBoolean(dynObj.value[i].merged);
                    _Ars["isescalated"] = dynObj.value[i].isescalated == null ? null : Convert.ToBoolean(dynObj.value[i].isescalated);
                    _Ars["seda_isindustrywithintargetedsegments"] = dynObj.value[i].seda_isindustrywithintargetedsegments == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isindustrywithintargetedsegments);
                    _Ars["title"] = (string)dynObj.value[i].title;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["servicestage"] = dynObj.value[i].servicestage == null ? null : Convert.ToInt32(dynObj.value[i].servicestage);
                    _Ars["seda_caseassignmentflag"] = dynObj.value[i].seda_caseassignmentflag == null ? null : Convert.ToBoolean(dynObj.value[i].seda_caseassignmentflag);
                    _Ars["_seda_casecategory_value"] = (string)dynObj.value[i]._seda_casecategory_value;
                    _Ars["_primarycontactid_value"] = (string)dynObj.value[i]._primarycontactid_value;
                    _Ars["_seda_subcategory_value"] = (string)dynObj.value[i]._seda_subcategory_value;
                    _Ars["resolvebyslastatus"] = dynObj.value[i].resolvebyslastatus == null ? null : Convert.ToInt32(dynObj.value[i].resolvebyslastatus);
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["description"] = (string)dynObj.value[i].description;
                    _Ars["seda_newstatussettime"] = (string)dynObj.value[i].seda_newstatussettime;
                    _Ars["stageid"] = (string)dynObj.value[i].stageid;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_isissuerelevanttosector"] = dynObj.value[i].seda_isissuerelevanttosector == null ? null : Convert.ToBoolean(dynObj.value[i].seda_isissuerelevanttosector);
                    _Ars["decremententitlementterm"] = dynObj.value[i].decremententitlementterm == null ? null : Convert.ToBoolean(dynObj.value[i].decremententitlementterm);
                    _Ars["routecase"] = dynObj.value[i].routecase == null ? null : Convert.ToBoolean(dynObj.value[i].routecase);
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["seda_wastopmanagementinvolved"] = dynObj.value[i].seda_wastopmanagementinvolved == null ? null : Convert.ToBoolean(dynObj.value[i].seda_wastopmanagementinvolved);
                    _Ars["processid"] = (string)dynObj.value[i].processid;
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["followuptaskcreated"] = dynObj.value[i].followuptaskcreated == null ? null : Convert.ToBoolean(dynObj.value[i].followuptaskcreated);
                    _Ars["firstresponsesent"] = dynObj.value[i].firstresponsesent == null ? null : Convert.ToBoolean(dynObj.value[i].firstresponsesent);
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["firstresponseslastatus"] = dynObj.value[i].firstresponseslastatus == null ? null : Convert.ToInt32(dynObj.value[i].firstresponseslastatus);
                    _Ars["seda_cancellationreason"] = (string)dynObj.value[i].seda_cancellationreason;
                    _Ars["caseorigincode"] = dynObj.value[i].caseorigincode == null ? null : Convert.ToInt32(dynObj.value[i].caseorigincode);
                    _Ars["isdecrementing"] = dynObj.value[i].isdecrementing == null ? null : Convert.ToBoolean(dynObj.value[i].isdecrementing);
                    _Ars["activitiescomplete"] = dynObj.value[i].activitiescomplete == null ? null : Convert.ToBoolean(dynObj.value[i].activitiescomplete);
                    _Ars["_seda_department_value"] = (string)dynObj.value[i]._seda_department_value;
                    _Ars["customercontacted"] = dynObj.value[i].customercontacted == null ? null : Convert.ToBoolean(dynObj.value[i].customercontacted);
                    _Ars["seda_casetypec"] = (string)dynObj.value[i].seda_casetypec;
                    _Ars["checkemail"] = dynObj.value[i].checkemail == null ? null : Convert.ToBoolean(dynObj.value[i].checkemail);
                    _Ars["seda_canceledfromwebsite"] = dynObj.value[i].seda_canceledfromwebsite == null ? null : Convert.ToBoolean(dynObj.value[i].seda_canceledfromwebsite);
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["ticketnumber"] = (string)dynObj.value[i].ticketnumber;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["seda_iscasecategorychanged"] = dynObj.value[i].seda_iscasecategorychanged == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iscasecategorychanged);
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["seda_issuerequiredifferentapproach"] = dynObj.value[i].seda_issuerequiredifferentapproach == null ? null : Convert.ToBoolean(dynObj.value[i].seda_issuerequiredifferentapproach);
                    _Ars["incidentstagecode"] = dynObj.value[i].incidentstagecode == null ? null : Convert.ToInt32(dynObj.value[i].incidentstagecode);
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["seda_othercategory"] = (string)dynObj.value[i].seda_othercategory;
                    _Ars["_customerid_value"] = (string)dynObj.value[i]._customerid_value;
                    _Ars["seda_othersubcategory"] = (string)dynObj.value[i].seda_othersubcategory;
                    _Ars["seda_resolvable"] = (string)dynObj.value[i].seda_resolvable;
                    _Ars["seda_impactcategory"] = (string)dynObj.value[i].seda_impactcategory;
                    _Ars["_seda_existingotherevent_value"] = (string)dynObj.value[i]._seda_existingotherevent_value;
                    _Ars["seda_barrieruser"] = (string)dynObj.value[i].seda_barrieruser;
                    _Ars["_subjectid_value"] = (string)dynObj.value[i]._subjectid_value;
                    _Ars["seda_reporttxt"] = (string)dynObj.value[i].seda_reporttxt;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_seda_barriertypen_value"] = (string)dynObj.value[i]._seda_barriertypen_value;
                    _Ars["_parentcaseid_value"] = (string)dynObj.value[i]._parentcaseid_value;
                    _Ars["seda_impactseverity"] = (string)dynObj.value[i].seda_impactseverity;
                    _Ars["_seda_caseassignmentid_value"] = (string)dynObj.value[i]._seda_caseassignmentid_value;
                    _Ars["entityimageid"] = (string)dynObj.value[i].entityimageid;
                    _Ars["seda_impactassessed"] = (string)dynObj.value[i].seda_impactassessed;
                    _Ars["_contractdetailid_value"] = (string)dynObj.value[i]._contractdetailid_value;
                    _Ars["productserialnumber"] = (string)dynObj.value[i].productserialnumber;
                    _Ars["_modifiedbyexternalparty_value"] = (string)dynObj.value[i]._modifiedbyexternalparty_value;
                    _Ars["seda_impacttypes"] = (string)dynObj.value[i].seda_impacttypes;
                    _Ars["_seda_cities_value"] = (string)dynObj.value[i]._seda_cities_value;
                    _Ars["seda_exportenablementurgency"] = (string)dynObj.value[i].seda_exportenablementurgency;
                    _Ars["sentimentvalue"] = (string)dynObj.value[i].sentimentvalue;
                    _Ars["seda_duration"] = (string)dynObj.value[i].seda_duration;
                    _Ars["emailaddress"] = (string)dynObj.value[i].emailaddress;
                    _Ars["responseby"] = (string)dynObj.value[i].responseby;
                    _Ars["seda_casebarrierportalfield_name"] = (string)dynObj.value[i].seda_casebarrierportalfield_name;
                    _Ars["billedserviceunits"] = (string)dynObj.value[i].billedserviceunits;
                    _Ars["_firstresponsebykpiid_value"] = (string)dynObj.value[i]._firstresponsebykpiid_value;
                    _Ars["contractservicelevelcode"] = (string)dynObj.value[i].contractservicelevelcode;
                    _Ars["seda_exportenablementpriority"] = (string)dynObj.value[i].seda_exportenablementpriority;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["_seda_country_value"] = (string)dynObj.value[i]._seda_country_value;
                    _Ars["seda_relevantstockholders"] = (string)dynObj.value[i].seda_relevantstockholders;
                    _Ars["seda_casebarrierportalfield_lname"] = (string)dynObj.value[i].seda_casebarrierportalfield_lname;
                    _Ars["_slaid_value"] = (string)dynObj.value[i]._slaid_value;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["followupby"] = (string)dynObj.value[i].followupby;
                    _Ars["seda_resolution"] = (string)dynObj.value[i].seda_resolution;
                    _Ars["exeseda_inquirytype"] = (string)dynObj.value[i].exeseda_inquirytype;
                    _Ars["seda_issuedate"] = (string)dynObj.value[i].seda_issuedate;
                    _Ars["_masterid_value"] = (string)dynObj.value[i]._masterid_value;
                    _Ars["seda_tradebarrierfeedback"] = (string)dynObj.value[i].seda_tradebarrierfeedback;
                    _Ars["_seda_casedepartments_value"] = (string)dynObj.value[i]._seda_casedepartments_value;
                    _Ars["seda_existingothereventselection"] = (string)dynObj.value[i].seda_existingothereventselection;
                    _Ars["seda_rootcauseanalyzed"] = (string)dynObj.value[i].seda_rootcauseanalyzed;
                    _Ars["seda_mobile"] = (string)dynObj.value[i].seda_mobile;
                    _Ars["_seda_lead_value"] = (string)dynObj.value[i]._seda_lead_value;
                    _Ars["_seda_tempcontact_value"] = (string)dynObj.value[i]._seda_tempcontact_value;
                    _Ars["seda_estresolutiondateidentified"] = (string)dynObj.value[i].seda_estresolutiondateidentified;
                    _Ars["seda_exportenablementteamcomment"] = (string)dynObj.value[i].seda_exportenablementteamcomment;
                    _Ars["_existingcase_value"] = (string)dynObj.value[i]._existingcase_value;
                    _Ars["entityimage"] = (string)dynObj.value[i].entityimage;
                    _Ars["_productid_value"] = (string)dynObj.value[i]._productid_value;
                    _Ars["_seda_slalookup_value"] = (string)dynObj.value[i]._seda_slalookup_value;
                    _Ars["_kbarticleid_value"] = (string)dynObj.value[i]._kbarticleid_value;
                    _Ars["seda_exportenablementresolutionmethod"] = (string)dynObj.value[i].seda_exportenablementresolutionmethod;
                    _Ars["messagetypecode"] = (string)dynObj.value[i].messagetypecode;
                    _Ars["lastonholdtime"] = (string)dynObj.value[i].lastonholdtime;
                    _Ars["_seda_participant_value"] = (string)dynObj.value[i]._seda_participant_value;
                    _Ars["seda_holdassignment"] = (string)dynObj.value[i].seda_holdassignment;
                    _Ars["_exeseda_buyerid_value"] = (string)dynObj.value[i]._exeseda_buyerid_value;
                    _Ars["exchangerate"] = (string)dynObj.value[i].exchangerate;
                    _Ars["seda_barrierclassification"] = (string)dynObj.value[i].seda_barrierclassification;
                    _Ars["_accountid_value"] = (string)dynObj.value[i]._accountid_value;
                    _Ars["_resolvebykpiid_value"] = (string)dynObj.value[i]._resolvebykpiid_value;
                    _Ars["seda_impactofsolution"] = (string)dynObj.value[i].seda_impactofsolution;
                    _Ars["seda_reviewprovided"] = (string)dynObj.value[i].seda_reviewprovided;
                    _Ars["entityimage_timestamp"] = (string)dynObj.value[i].entityimage_timestamp;
                    _Ars["seda_ticketnumber"] = (string)dynObj.value[i].seda_ticketnumber;
                    _Ars["traversedpath"] = (string)dynObj.value[i].traversedpath;
                    _Ars["seda_exportenablementstatus"] = (string)dynObj.value[i].seda_exportenablementstatus;
                    _Ars["_contractid_value"] = (string)dynObj.value[i]._contractid_value;
                    _Ars["seda_relevantstakeholdersidentified"] = (string)dynObj.value[i].seda_relevantstakeholdersidentified;
                    _Ars["seda_caseownerassigned"] = (string)dynObj.value[i].seda_caseownerassigned;
                    _Ars["prioritycode"] = (string)dynObj.value[i].prioritycode;
                    _Ars["seda_casebarrierportalfield_mobile"] = (string)dynObj.value[i].seda_casebarrierportalfield_mobile;
                    _Ars["escalatedon"] = (string)dynObj.value[i].escalatedon;
                    _Ars["seda_freqoffollowupidentified"] = (string)dynObj.value[i].seda_freqoffollowupidentified;
                    _Ars["seda_appropiratesolutionselected"] = (string)dynObj.value[i].seda_appropiratesolutionselected;
                    _Ars["seda_othercasetypetxt"] = (string)dynObj.value[i].seda_othercasetypetxt;
                    _Ars["exeseda_buyerfeedback"] = (string)dynObj.value[i].exeseda_buyerfeedback;
                    _Ars["seda_procedurestakentoresolvethebarrier"] = (string)dynObj.value[i].seda_procedurestakentoresolvethebarrier;
                    _Ars["seda_casebarrierportalfield_email"] = (string)dynObj.value[i].seda_casebarrierportalfield_email;
                    _Ars["onholdtime"] = (string)dynObj.value[i].onholdtime;
                    _Ars["_transactioncurrencyid_value"] = (string)dynObj.value[i]._transactioncurrencyid_value;
                    _Ars["entityimage_url"] = (string)dynObj.value[i].entityimage_url;
                    _Ars["_seda_barriertyper_value"] = (string)dynObj.value[i]._seda_barriertyper_value;
                    _Ars["_seda_industry_value"] = (string)dynObj.value[i]._seda_industry_value;
                    _Ars["_seda_genralcategoryr_value"] = (string)dynObj.value[i]._seda_genralcategoryr_value;
                    _Ars["seda_barrierclassificationidentified"] = (string)dynObj.value[i].seda_barrierclassificationidentified;
                    _Ars["seda_exportenablementbarriertype"] = (string)dynObj.value[i].seda_exportenablementbarriertype;
                    _Ars["numberofchildincidents"] = (string)dynObj.value[i].numberofchildincidents;
                    _Ars["seda_suggestedsolution"] = (string)dynObj.value[i].seda_suggestedsolution;
                    _Ars["seda_othereventtxt"] = (string)dynObj.value[i].seda_othereventtxt;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["resolveby"] = (string)dynObj.value[i].resolveby;
                    _Ars["seda_subject"] = (string)dynObj.value[i].seda_subject;
                    _Ars["seda_crnumbertxt"] = (string)dynObj.value[i].seda_crnumbertxt;
                    _Ars["seda_eeresolutionmethod"] = (string)dynObj.value[i].seda_eeresolutionmethod;
                    _Ars["_seda_position_value"] = (string)dynObj.value[i]._seda_position_value;
                    _Ars["actualserviceunits"] = (string)dynObj.value[i].actualserviceunits;
                    _Ars["seda_firstassignmentdate"] = (string)dynObj.value[i].seda_firstassignmentdate;
                    _Ars["_seda_year_value"] = (string)dynObj.value[i]._seda_year_value;
                    _Ars["influencescore"] = (string)dynObj.value[i].influencescore;
                    _Ars["seda_casebarrier_estdresolutiondate"] = (string)dynObj.value[i].seda_casebarrier_estdresolutiondate;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["customersatisfactioncode"] = (string)dynObj.value[i].customersatisfactioncode;
                    _Ars["seda_businessdevteamcomments"] = (string)dynObj.value[i].seda_businessdevteamcomments;
                    _Ars["_seda_caseservices_value"] = (string)dynObj.value[i]._seda_caseservices_value;
                    _Ars["_socialprofileid_value"] = (string)dynObj.value[i]._socialprofileid_value;
                    _Ars["seda_assignedtoagencydate"] = (string)dynObj.value[i].seda_assignedtoagencydate;
                    _Ars["seda_email"] = (string)dynObj.value[i].seda_email;
                    _Ars["_entitlementid_value"] = (string)dynObj.value[i]._entitlementid_value;
                    _Ars["seda_barriertype"] = (string)dynObj.value[i].seda_barriertype;
                    _Ars["seda_exportenablementagency"] = (string)dynObj.value[i].seda_exportenablementagency;
                    _Ars["_seda_sector_value"] = (string)dynObj.value[i]._seda_sector_value;
                    _Ars["_createdbyexternalparty_value"] = (string)dynObj.value[i]._createdbyexternalparty_value;
                    _Ars["seda_resolutiondate"] = (string)dynObj.value[i].seda_resolutiondate;
                    _Ars["casetypecode"] = (string)dynObj.value[i].casetypecode;
                    _Ars["seda_cname"] = (string)dynObj.value[i].seda_cname;
                    _Ars["seda_barrierclassificationtxt"] = (string)dynObj.value[i].seda_barrierclassificationtxt;
                    _Ars["seda_assignedtoeeteam"] = (string)dynObj.value[i].seda_assignedtoeeteam;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["_seda_events_value"] = (string)dynObj.value[i]._seda_events_value;
                    _Ars["seda_planofimplementationdefined"] = (string)dynObj.value[i].seda_planofimplementationdefined;
                    _Ars["_contactid_value"] = (string)dynObj.value[i]._contactid_value;
                    _Ars["_slainvokedid_value"] = (string)dynObj.value[i]._slainvokedid_value;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Incidents_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Incidents_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_barriertypes
        public static void Seda_barriertypes(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_barriertypes", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("seda_iscustomerbarrrier");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("seda_barriertypeid");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("seda_arabicname");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("createdon");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("overriddencreatedon");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["seda_iscustomerbarrrier"] = dynObj.value[i].seda_iscustomerbarrrier == null ? null : Convert.ToBoolean(dynObj.value[i].seda_iscustomerbarrrier);
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["seda_barriertypeid"] = (string)dynObj.value[i].seda_barriertypeid;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["seda_arabicname"] = (string)dynObj.value[i].seda_arabicname;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_barriertypes_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_barriertypes_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_potentialbuyercontacts
        public static void Seda_potentialbuyercontacts(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_potentialbuyercontacts", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("seda_importdate");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_seda_potentialbuyer_value");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("seda_syncby");
                dt.Columns.Add("seda_potentialbuyercontactid");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("seda_phone");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_email");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("_owningteam_value");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["seda_importdate"] = (string)dynObj.value[i].seda_importdate;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_seda_potentialbuyer_value"] = (string)dynObj.value[i]._seda_potentialbuyer_value;
                    _Ars["timezoneruleversionnumber"] = dynObj.value[i].timezoneruleversionnumber == null ? null : Convert.ToInt32(dynObj.value[i].timezoneruleversionnumber);
                    _Ars["seda_syncby"] = (string)dynObj.value[i].seda_syncby;
                    _Ars["seda_potentialbuyercontactid"] = (string)dynObj.value[i].seda_potentialbuyercontactid;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["seda_phone"] = (string)dynObj.value[i].seda_phone;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_email"] = (string)dynObj.value[i].seda_email;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_potentialbuyercontacts_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_potentialbuyercontacts_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_potentialbuyeropportunityimports
        public static void Seda_potentialbuyeropportunityimports(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_potentialbuyeropportunityimports", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("seda_potentialbuyeropportunityimportid");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("createdon");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("timezoneruleversionnumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = (string)dynObj.value[i].statuscode;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["seda_potentialbuyeropportunityimportid"] = (string)dynObj.value[i].seda_potentialbuyeropportunityimportid;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_potentialbuyeropportunityimports_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_potentialbuyeropportunityimports_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_potentialbuyeropportunitycustomers
        public static void Seda_potentialbuyeropportunitycustomers(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_potentialbuyeropportunitycustomers", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("_seda_opportunity_value");
                dt.Columns.Add("seda_customerresponded");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("seda_remarks");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("_seda_customer_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_potentialbuyeropportunitycustomerid");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("importsequencenumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["_seda_opportunity_value"] = (string)dynObj.value[i]._seda_opportunity_value;
                    _Ars["seda_customerresponded"] = dynObj.value[i].seda_customerresponded == null ? null : Convert.ToBoolean(dynObj.value[i].seda_customerresponded);
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["seda_remarks"] = (string)dynObj.value[i].seda_remarks;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["_seda_customer_value"] = (string)dynObj.value[i]._seda_customer_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_potentialbuyeropportunitycustomerid"] = (string)dynObj.value[i].seda_potentialbuyeropportunitycustomerid;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_potentialbuyeropportunitycustomers_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_potentialbuyeropportunitycustomers_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_productbuyerses
        public static void Seda_productbuyerses(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_productbuyerses", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("seda_numberofemployees");
                dt.Columns.Add("createdon");
                dt.Columns.Add("_seda_position_value");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("seda_email");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_businesstype");
                dt.Columns.Add("seda_mobile");
                dt.Columns.Add("_seda_city_value");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("_seda_country_value");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("seda_address");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("seda_productbuyersid");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("seda_companywebsite");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("seda_companyenglishname");
                dt.Columns.Add("timezoneruleversionnumber");
                dt.Columns.Add("seda_companyfax");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("seda_syncby");
                dt.Columns.Add("_seda_attache_value");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("seda_companyphone");
                dt.Columns.Add("seda_verifyemail");
                dt.Columns.Add("seda_numberofopportunities");
                dt.Columns.Add("seda_importdate");
                dt.Columns.Add("seda_businessregistrationnumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["seda_numberofemployees"] = dynObj.value[i].seda_numberofemployees == null ? null : Convert.ToInt32(dynObj.value[i].seda_numberofemployees);
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["_seda_position_value"] = (string)dynObj.value[i]._seda_position_value;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["seda_email"] = (string)dynObj.value[i].seda_email;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_businesstype"] = (string)dynObj.value[i].seda_businesstype;
                    _Ars["seda_mobile"] = (string)dynObj.value[i].seda_mobile;
                    _Ars["_seda_city_value"] = (string)dynObj.value[i]._seda_city_value;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["_seda_country_value"] = (string)dynObj.value[i]._seda_country_value;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["seda_address"] = (string)dynObj.value[i].seda_address;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["seda_productbuyersid"] = (string)dynObj.value[i].seda_productbuyersid;
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["seda_companywebsite"] = (string)dynObj.value[i].seda_companywebsite;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["seda_companyenglishname"] = (string)dynObj.value[i].seda_companyenglishname;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    _Ars["seda_companyfax"] = (string)dynObj.value[i].seda_companyfax;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["seda_syncby"] = (string)dynObj.value[i].seda_syncby;
                    _Ars["_seda_attache_value"] = (string)dynObj.value[i]._seda_attache_value;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["seda_companyphone"] = (string)dynObj.value[i].seda_companyphone;
                    _Ars["seda_verifyemail"] = (string)dynObj.value[i].seda_verifyemail;
                    _Ars["seda_numberofopportunities"] = (string)dynObj.value[i].seda_numberofopportunities;
                    _Ars["seda_importdate"] = (string)dynObj.value[i].seda_importdate;
                    _Ars["seda_businessregistrationnumber"] = (string)dynObj.value[i].seda_businessregistrationnumber;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_productbuyerses_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_productbuyerses_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_casebarrierstakeholders
        public static void Seda_casebarrierstakeholders(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_casebarrierstakeholders", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("_organizationid_value");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("seda_casebarrierstakeholderid");
                dt.Columns.Add("createdon");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("seda_name");
                dt.Columns.Add("seda_stakeholderemailaddress");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("_seda_stakeholderid_value");
                dt.Columns.Add("emailaddress");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("seda_type");
                dt.Columns.Add("seda_stakeholderrepresentative");
                dt.Columns.Add("seda_nameeng");
                dt.Columns.Add("seda_description");
                dt.Columns.Add("timezoneruleversionnumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["_organizationid_value"] = (string)dynObj.value[i]._organizationid_value;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["importsequencenumber"] = (string)dynObj.value[i].importsequencenumber;
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["seda_casebarrierstakeholderid"] = (string)dynObj.value[i].seda_casebarrierstakeholderid;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["seda_name"] = (string)dynObj.value[i].seda_name;
                    _Ars["seda_stakeholderemailaddress"] = (string)dynObj.value[i].seda_stakeholderemailaddress;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["_seda_stakeholderid_value"] = (string)dynObj.value[i]._seda_stakeholderid_value;
                    _Ars["emailaddress"] = (string)dynObj.value[i].emailaddress;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["seda_type"] = (string)dynObj.value[i].seda_type;
                    _Ars["seda_stakeholderrepresentative"] = (string)dynObj.value[i].seda_stakeholderrepresentative;
                    _Ars["seda_nameeng"] = (string)dynObj.value[i].seda_nameeng;
                    _Ars["seda_description"] = (string)dynObj.value[i].seda_description;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_casebarrierstakeholders_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_casebarrierstakeholders_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Seda_hsserieses
        public static void Seda_hsserieses(dynamic dynObj)
        {
            CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;

                SqlCommand cmd = new SqlCommand(" truncate table Seda_hsserieses", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("odata");
                dt.Columns.Add("seda_productcode");
                dt.Columns.Add("versionnumber");
                dt.Columns.Add("_owningbusinessunit_value");
                dt.Columns.Add("statecode");
                dt.Columns.Add("statuscode");
                dt.Columns.Add("importsequencenumber");
                dt.Columns.Add("new_hslevel");
                dt.Columns.Add("_createdby_value");
                dt.Columns.Add("_ownerid_value");
                dt.Columns.Add("_modifiedby_value");
                dt.Columns.Add("_owninguser_value");
                dt.Columns.Add("createdon");
                dt.Columns.Add("seda_productcategory");
                dt.Columns.Add("modifiedon");
                dt.Columns.Add("seda_hsseriesid");
                dt.Columns.Add("_seda_subsector_value");
                dt.Columns.Add("_owningteam_value");
                dt.Columns.Add("_seda_sector_value");
                dt.Columns.Add("_modifiedonbehalfby_value");
                dt.Columns.Add("_createdonbehalfby_value");
                dt.Columns.Add("_seda_caseproductid_value");
                dt.Columns.Add("utcconversiontimezonecode");
                dt.Columns.Add("overriddencreatedon");
                dt.Columns.Add("timezoneruleversionnumber");

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    _Ars["odata"] = "WEBapi";
                    _Ars["seda_productcode"] = (string)dynObj.value[i].seda_productcode;
                    _Ars["versionnumber"] = (string)dynObj.value[i].versionnumber;
                    _Ars["_owningbusinessunit_value"] = (string)dynObj.value[i]._owningbusinessunit_value;
                    _Ars["statecode"] = dynObj.value[i].statecode == null ? null : Convert.ToInt32(dynObj.value[i].statecode);
                    _Ars["statuscode"] = dynObj.value[i].statuscode == null ? null : Convert.ToInt32(dynObj.value[i].statuscode);
                    _Ars["importsequencenumber"] = dynObj.value[i].importsequencenumber == null ? null : Convert.ToInt32(dynObj.value[i].importsequencenumber);
                    _Ars["new_hslevel"] = dynObj.value[i].new_hslevel == null ? null : Convert.ToInt32(dynObj.value[i].new_hslevel);
                    _Ars["_createdby_value"] = (string)dynObj.value[i]._createdby_value;
                    _Ars["_ownerid_value"] = (string)dynObj.value[i]._ownerid_value;
                    _Ars["_modifiedby_value"] = (string)dynObj.value[i]._modifiedby_value;
                    _Ars["_owninguser_value"] = (string)dynObj.value[i]._owninguser_value;
                    _Ars["createdon"] = (string)dynObj.value[i].createdon;
                    _Ars["seda_productcategory"] = (string)dynObj.value[i].seda_productcategory;
                    _Ars["modifiedon"] = (string)dynObj.value[i].modifiedon;
                    _Ars["seda_hsseriesid"] = (string)dynObj.value[i].seda_hsseriesid;
                    _Ars["_seda_subsector_value"] = (string)dynObj.value[i]._seda_subsector_value;
                    _Ars["_owningteam_value"] = (string)dynObj.value[i]._owningteam_value;
                    _Ars["_seda_sector_value"] = (string)dynObj.value[i]._seda_sector_value;
                    _Ars["_modifiedonbehalfby_value"] = (string)dynObj.value[i]._modifiedonbehalfby_value;
                    _Ars["_createdonbehalfby_value"] = (string)dynObj.value[i]._createdonbehalfby_value;
                    _Ars["_seda_caseproductid_value"] = (string)dynObj.value[i]._seda_caseproductid_value;
                    _Ars["utcconversiontimezonecode"] = (string)dynObj.value[i].utcconversiontimezonecode;
                    _Ars["overriddencreatedon"] = (string)dynObj.value[i].overriddencreatedon;
                    _Ars["timezoneruleversionnumber"] = (string)dynObj.value[i].timezoneruleversionnumber;
                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand("Seda_hsserieses_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("Seda_hsserieses_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #endregion

        #region When Table Structure Was change
        public static void StructureWaschange(string TableName)
        {
            string CloumnName = string.Empty;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand cmd;
            using (conn)
            {
                try
                {
                    CloumnName = " Drop PROCEDURE " + TableName + "_SP";
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }

                try
                {
                    CloumnName = " Drop Type " + TableName + "_type_table ";
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }
                try
                {
                    CloumnName = " Drop Table " + TableName;
                    cmd = new SqlCommand(CloumnName, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    DataAccess.Error(e.Message, e.HResult, CloumnName);
                }


            }
        }
        #endregion


        #region CreatingTypetable
        public static void CreatingTypetable(List<string> prop, string TableTypeName)
        {
            LogicalName.Table = TableTypeName + " Table_Type";
            string CloumnName = HelpingFuns.GetTableStructure(prop);
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                CloumnName = " IF TYPE_ID(N'" + TableTypeName + "_type_table') IS NULL \n begin \n CREATE TYPE " + TableTypeName + "_type_table AS TABLE (\n" + CloumnName + "\n) \n end";
                SqlCommand cmd = new SqlCommand(CloumnName, conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region PROCEDURE_CHECK
        public static bool PROCEDURE_CHECK(string PROCEDUREname)
        {
            int newProdID = 0;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("SELECT count(1) FROM sys.objects WHERE type = 'P' AND name = '" + PROCEDUREname + "'", conn);
                object result = cmd.ExecuteScalar();
                newProdID = (result == null ? newProdID : Convert.ToInt32(result));

                if (newProdID > 0)
                    return false;
                else
                    return true;
            }
        }
        #endregion

        #region Table_CHECK
        public static bool Table_CHECK(string tablename)
        {
            int newProdID = 0;
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("select count(1) from INFORMATION_SCHEMA.TABLES where TABLE_NAME=N'" + tablename + "'", conn);
                object result = cmd.ExecuteScalar();
                newProdID = (result == null ? newProdID : Convert.ToInt32(result));

                if (newProdID > 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Create_PROCEDURE
        public static void Create_PROCEDURE(IList<string> prop, string TableName)
        {
            LogicalName.Table = TableName + " Table_Name";
            string PROCEDURE_NAME = TableName + "_SP";
            if (PROCEDURE_CHECK(PROCEDURE_NAME))
            {

                string CloumnName = HelpingFuns.GetTableStructure(prop);
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();
                using (conn)
                {
                    PROCEDURE_NAME = "CREATE PROCEDURE " + PROCEDURE_NAME + "\n @" + TableName + "_var  " + TableName + "_type_table readonly \n AS \n BEGIN \n \n SET NOCOUNT ON; \n if NOT EXISTS  (select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME=N'" + TableName + "') \n BEGIN \n CREATE TABLE [dbo].[" + TableName + "] \n (\n" + CloumnName + "\n) \n END \n INSERT INTO [dbo].[" + TableName + "] \n select * from @" + TableName + "_var \n END";

                    SqlCommand cmd = new SqlCommand(PROCEDURE_NAME, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DATA_SET
        public static void DATA_SET(dynamic dynObj, List<string> prop, List<string> props, string TABLE_NAME)
        {
            //CreateTableType();
            LogicalName.Table = TABLE_NAME + " Data_Entry";
            SqlConnection conn = new SqlConnection(ConnString);

            conn.Open();
            using (conn)
            {
                int count = dynObj.value.Count;
                SqlCommand cmd;
                if (Table_CHECK(TABLE_NAME))
                {
                    cmd = new SqlCommand(" truncate table " + TABLE_NAME + "", conn);
                    cmd.ExecuteNonQuery();
                }
                DataTable dt = new DataTable();
                dt.Clear();
                for (int i = 0; i < props.Count; i++)
                {
                    string[] Array = props[i].Split(':');

                    props[i] = Array.Length != 1 ? Array[0] + " " + HelpingFuns.SQLColumnType(Array[1]) : Array[0];

                }

                for (int i = 0; i < prop.Count; i++)
                {
                    dt.Columns.Add(prop[i]);
                }

                for (int i = 0; i < count; i++)
                {
                    DataRow _Ars = dt.NewRow();
                    List<object> ValuesProp = HelpingFuns.VALUEProperty(dynObj.value[i]);
                    DateTime date;
                    String AA = "";

                    for (int y = 0; y < prop.Count; y++)
                    {
                        if (props[y].EndsWith("datetime  NULL") && ValuesProp[y] != null)
                        {
                            date = DateTime.Parse((string)ValuesProp[y], CultureInfo.CreateSpecificCulture("en-GB"));
                            AA =  string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", date);
                        }

                        _Ars[prop[y]] =

                        props[y].EndsWith("int NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt32(ValuesProp[y]) :
                        props[y].EndsWith("bigint NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt64(ValuesProp[y]) :
                        props[y].EndsWith("bit NULL") ? ValuesProp[y] == null ? null : (bool?)Convert.ToBoolean(ValuesProp[y]) :
                        // props[y].EndsWith("datetime  NULL") ? ValuesProp[y] == null ? null : (DateTime?)Convert.ToDateTime((string)ValuesProp[y]) :
                        props[y].EndsWith("datetime  NULL") ? ValuesProp[y] == null ? null : (DateTime?)DateTime.Parse((string)AA) :
                        props[y].EndsWith("float NULL") ? ValuesProp[y] == null ? null : (float?)float.Parse((string)ValuesProp[y]) :
                        props[y].EndsWith("Money NULL") ? ValuesProp[y] == null ? null : (int?)Convert.ToInt64(ValuesProp[y]) :
                        ValuesProp[y];
                    }

                    dt.Rows.Add(_Ars);
                }

                cmd = new SqlCommand(TABLE_NAME + "_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue(TABLE_NAME + "_Var", dt);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region FilteredStringMap
        public static void FilteredStringMap(DataTable dynObj, string TABLE_NAME, string onetime)
        {
            //CreateTableType();
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {

                SqlCommand cmd;
                if (Table_CHECK(TABLE_NAME))
                {
                    cmd = new SqlCommand("delete FROM " + TABLE_NAME + " where [FilteredViewName] = '" + onetime + "'", conn);
                    cmd.ExecuteNonQuery();
                }
                cmd = new SqlCommand(TABLE_NAME + "_SP", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue(TABLE_NAME + "_Var", dynObj);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region ERROR       
        public static void Error(string ErrorSrting, int ErrorCode, string OnError)
        {            //CreateTableType(); 
            String dateMy = Convert.ToString(DateTime.Now);
            dateMy = DateTime.Parse(dateMy, CultureInfo.CreateSpecificCulture("en-GB")).ToString("yyyy-MM-dd HH:mm:ss.fff");
            ErrorSrting = ErrorSrting.Replace("'", "''");
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO [dbo].[ErrorLog]([ErrorMessage],[date],[ErrorCode],[OnError])VALUES('" + ErrorSrting + "','" + dateMy + "'," + ErrorCode + ",'" + OnError + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
