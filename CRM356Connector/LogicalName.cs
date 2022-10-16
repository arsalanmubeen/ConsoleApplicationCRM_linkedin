using System.Collections.Generic;


namespace CRM356Connector
{
    
    public class LogicalName
    {
        public static string Table = string.Empty;
        public static void GetData(string _userName, string _passWord, string _domain, string _serviceUri, string LogicalName, string ConnString)
        {
            try
            {
                DataAccess.ConnString = ConnString;
                string json = HelpingFuns.MakeAPICall(_userName, _passWord, _domain, _serviceUri, LogicalName);

                if (!string.IsNullOrEmpty(json))
                {
                    dynamic obj = HelpingFuns.DeserializeJSON(json);
                    if (obj != null)
                    {
                        if (LogicalName == "")
                            LogicalName = "LogicalName";
                        if (obj.value.Count != 0)
                        {
                            string tablename;
                            List<string> prop = HelpingFuns.ChildrenProperty(obj);
                            if (LogicalName.Contains("?"))
                                tablename = LogicalName.Split('?')[0];
                            else
                                tablename = LogicalName;

                            string SingularLogicalName = HelpingFuns.Singular(tablename);
                            List<string> props = HelpingFuns.GetAttributeType(prop, SingularLogicalName, _userName, _passWord, _domain, _serviceUri);
                            Filteredstringmap.Function(_userName, _passWord, _domain, _serviceUri, tablename);
                            DataAccess.CreatingTypetable(props, tablename);
                            DataAccess.Create_PROCEDURE(props, tablename);
                            DataAccess.DATA_SET(obj, prop, props, tablename);
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                DataAccess.Error(e.Message,e.HResult, Table);
                if (e.HResult == -2146232060)
                {
                    string tablename;
                    if (LogicalName.Contains("?"))
                        tablename = LogicalName.Split('?')[0];
                    else
                        tablename = LogicalName;

                    DataAccess.StructureWaschange(tablename);

                    GetData(_userName, _passWord, _domain, _serviceUri, LogicalName, ConnString);
                }
            }
        }
    }
}
