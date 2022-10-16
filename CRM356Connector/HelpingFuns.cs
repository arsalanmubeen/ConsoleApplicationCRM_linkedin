using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.Data;

namespace CRM356Connector
{

    class HelpingFuns
    {
        public static HttpClient getNewHttpClient(string userName, string password, string domainName, string webAPIBaseAddress)
        {
            HttpClient client = new HttpClient(new HttpClientHandler() { Credentials = new NetworkCredential(userName, password) });
            client.BaseAddress = new Uri(webAPIBaseAddress);
            client.Timeout = new TimeSpan(0, 2, 0);
            return client;
        }

        public static void WritetoFile(string dynObj, string FileLoc = @"C:\Users\igaafar\abc.txt")
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(FileLoc, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine(dynObj);
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }

        public static dynamic DeserializeJSON(string json)
        {
            //Retrieve data about lookup properties.----use this---------------------------------------
            //dynamic data = JObject.Parse(json)["value"];
            //---------------------------------------------------------------------------------
            dynamic data = JObject.Parse(json);
            return data;
        }

        static async Task<string> MakeAPICall_Bridge(string _userName, string _passWord, string _domain, string _serviceUri, string LogicalName)
        {
            var response = string.Empty;
            //string baseAddress = "http://hqdevcrms04/SEDADEVMSCRM/";
            HttpClient client = getNewHttpClient(_userName, _passWord, _domain, _serviceUri);
            client.Timeout = new TimeSpan(1, 2, 0);
            //Retrieve data about lookup properties.-------------------------------------------
            //client.DefaultRequestHeaders.Add("Accept", "application/json");
            //client.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
            //client.DefaultRequestHeaders.Add("OData-Version", "4.0");
            //client.DefaultRequestHeaders.Add("Prefer", "odata.include-annotations=\"*\"");
            //--------------------------------------------------------------------------------
            HttpResponseMessage result = await client.GetAsync(LogicalName);
            //responseTask.Wait();
            // var result = resp.Result;
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }

        public static string MakeAPICall(string _userName, string _passWord, string _domain, string _serviceUri, string LogicalName)
        {
            var t = Task.Run(() => MakeAPICall_Bridge(_userName, _passWord, _domain, _serviceUri, LogicalName));
            t.Wait();
            string json = t.Result;
            return json;
        }

        public static IList<string> ChildrenProperty(dynamic obj)
        {
            var Property = new List<string>();
            var jObj = (JObject)obj.value.First;
            string valueForchk = string.Empty;
            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;
                    try
                    {
                        valueForchk = (string)prop.Value;
                        Property.Add(prop.Name);
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains("not convert Object to String"))
                        {
                            var jObjunder = (JObject)token.First;
                            foreach (JToken tokenunder in jObjunder.Children())
                            {
                                if (tokenunder is JProperty)
                                {
                                    var propunder = tokenunder as JProperty;
                                    Property.Add(prop.Name + "_" + propunder.Name);
                                }
                            }
                        }
                    }
                }
            }
            return Property;
        }

        public static IList<object> VALUEProperty(dynamic obj)
        {
            var Property = new List<object>();
            var jObj = (JObject)obj;

            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;
                    try
                    {
                        Property.Add((string)prop.Value);
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains("not convert Object to String"))
                        {
                            var jObjunder = (JObject)token.First;
                            foreach (JToken tokenunder in jObjunder.Children())
                            {
                                if (tokenunder is JProperty)
                                {
                                    var propunder = tokenunder as JProperty;
                                    Property.Add(propunder.Value);
                                }
                            }
                        }
                    }
                }
            }
            return Property;
        }

        public static string GetTableStructure(IList<string> prop)
        {
            string CloumnName = string.Empty;
            bool A = true;
            for (int i = 0; i < prop.Count; i++)
            {
                string[] data = new string[2];
                if (prop[i].Contains(":"))
                    data = prop[i].Split(':');
                else
                {
                    data[0] = prop[i];
                    data[1] = "String";
                }
                if (A)
                {
                    A = false;
                    CloumnName = "[" + prop[i] + "]" + " [nvarchar](255) NULL ";
                }
                else
                    CloumnName = CloumnName + ",\n " + "[" + data[0] + "]" + " " + SQLColumnType(data[1]) + "";
            }
            return CloumnName;
        }

        public static List<string> GetAttributeType(List<string> prop, string SingularLogicalName, string _userName, string _passWord, string _domain, string _serviceUri)
        {
            for (int i = 0; i < prop.Count; i++)
            {
                string Column = prop[i].StartsWith("_") ? prop[i].Remove(0, 1).Replace("_value", "") : prop[i];
                string LogicalName = "EntityDefinitions(LogicalName='" + SingularLogicalName + "')/Attributes(LogicalName='" + Column + "')?$select=AttributeType";
                string childAttributeType = MakeAPICall(_userName, _passWord, _domain, _serviceUri, LogicalName);
                if (!string.IsNullOrEmpty(childAttributeType))
                {
                    dynamic obj = DeserializeJSON(childAttributeType);
                    if (obj != null)
                    {
                        prop[i] = prop[i] + ":" + obj.AttributeType;
                    }

                }
            }

            return prop;
        }

        public static string SQLColumnType(string column)
        {
            switch (column)
            {
                case "String":
                    column = "[nvarchar](4000) NULL";
                    break;
                case "bigint":
                    column = "bigint NULL";
                    break;
                case "State":
                    column = "int NULL";
                    break;
                case "Integer":
                    column = "int NULL";
                    break;
                case "Boolean":
                    column = "bit NULL";
                    break;
                case "Lookup":
                    column = "[nvarchar](255)  NULL";
                    break;
                case "DateTime":
                    column = "datetime  NULL";
                    break;
                case "Virtual":
                    column = "[nvarchar](max) NULL";
                    break;
                case "Uniqueidentifier":
                    column = "Uniqueidentifier NULL";
                    break;
                case "Picklist":
                    column = "int NULL";
                    break;
                case "Decimal":
                    column = "float NULL";
                    break;
                case "Memo":
                    column = "[nvarchar](max) NULL";
                    break;
                case "PartyList":
                    column = "[nvarchar](4000) NULL";
                    break;
                case "EntityName":
                    column = "[nvarchar](4000) NULL";
                    break;
                case "Owner":
                    column = "uniqueidentifier NULL";
                    break;
                case "Status":
                    column = "int NULL";
                    break;
                case "Double":
                    column = "float NULL";
                    break;
                case "Money":
                    column = "Money NULL";
                    break;
                case "Customer":
                    column = "uniqueidentifier NULL";
                    break;
                default:
                    column = "[nvarchar](4000) NULL";
                    break;
            }




            return column;
        }

        private static readonly PluralizationService service = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-US"));
        public static string Singular(string tablename)
        {
            tablename = tablename.Contains("seda_") ? "seda_" + service.Singularize(tablename.Replace("seda_", "")) : service.Singularize(tablename);
            return tablename;
        }

        public static DataTable FilteredstringmapHelper(DataTable dt, string tablename, string json)
        {
            int DisplayOrder = 0, LangId = 0;
            string FilteredViewName = string.Empty, AttributeName = string.Empty, AttributeValue = string.Empty, Value = string.Empty;
            if (!string.IsNullOrEmpty(json))
            {
                dynamic obj = HelpingFuns.DeserializeJSON(json);
                if (obj != null)
                {
                    foreach (var item in obj.value)
                    {
                        FilteredViewName = "Filtered" + tablename;
                        AttributeName = item["LogicalName"];
                        DisplayOrder = 1;
                        foreach (var GlobalOptionSetitem in item.GlobalOptionSet.Options)
                        {
                            AttributeValue = GlobalOptionSetitem["Value"];
                            foreach (var Labelitem in GlobalOptionSetitem.Label.LocalizedLabels)
                            {
                                DataRow ARS = dt.NewRow();
                                Value = Labelitem["Label"];
                                LangId = Labelitem["LanguageCode"] == null ? null : Convert.ToInt32(Labelitem["LanguageCode"]);
                                ARS["FilteredViewName"] = FilteredViewName;
                                ARS["AttributeName"] = AttributeName;
                                ARS["AttributeValue"] = AttributeValue;
                                ARS["Value"] = Value;
                                ARS["DisplayOrder"] = DisplayOrder;
                                ARS["LangId"] = LangId;

                                dt.Rows.Add(ARS);

                            }
                            DisplayOrder++;
                        }
                    }

                }
                return dt;
            }
            else
                return dt;
        }

    }
}
