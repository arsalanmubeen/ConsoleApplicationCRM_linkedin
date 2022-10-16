using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM356Connector
{
    class Filteredstringmap
    {
        public static void Function(string _userName, string _passWord, string _domain, string _serviceUri, string LogicalName)
        {
            LogicalName = HelpingFuns.Singular(LogicalName);
            List<string> props = new List<string>();
            props.Add("FilteredViewName");
            props.Add("AttributeName:Lookup");
            props.Add("AttributeValue:Lookup");
            props.Add("Value:Lookup");
            props.Add("DisplayOrder:Integer");
            props.Add("LangId:Integer");

            DataAccess.CreatingTypetable(props, "FilteredStringMap");
            DataAccess.Create_PROCEDURE(props, "FilteredStringMap");
            string tablename = LogicalName, json = string.Empty;
            string[] Array = new string[] { "PicklistAttributeMetadata", "StatusAttributeMetadata", "StateAttributeMetadata", };
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("FilteredViewName");
            dt.Columns.Add("AttributeName");
            dt.Columns.Add("AttributeValue");
            dt.Columns.Add("Value");
            dt.Columns.Add("DisplayOrder");
            dt.Columns.Add("LangId");

            for (int i = 0; i < Array.Length; i++)
            {
                LogicalName = "EntityDefinitions(LogicalName='" + tablename + "')/Attributes/Microsoft.Dynamics.CRM." + Array[i] + "?$select=LogicalName&$expand=GlobalOptionSet";
                json = HelpingFuns.MakeAPICall(_userName, _passWord, _domain, _serviceUri, LogicalName);
                dt = HelpingFuns.FilteredstringmapHelper(dt, tablename, json);
            }

            DataAccess.FilteredStringMap(dt, "FilteredStringMap", "Filtered" + tablename);
        }
    }
}
