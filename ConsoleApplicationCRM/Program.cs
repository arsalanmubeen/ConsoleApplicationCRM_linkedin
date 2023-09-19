using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using CRM356Connector;

namespace ConsoleApplicationCRM
{
    public class Program
    {

        static void Main()
        {

            string _userName = GetAppVAR.GetKeyValue("Username");
            string _passWord = GetAppVAR.GetKeyValue("Password");
            string _domain = GetAppVAR.GetKeyValue("Domain");
            string _serviceUri = GetAppVAR.GetKeyValue("ServerAddress");


            string[] tablesToPro = new string[] {
                "phonecalls",
                "tasks",
                "appointments",
                "emails" ,
                "processstages",
                "workflows",
                "contacts",
                "activityparties",
                "campaigns",
                "leads",
                "accounts",
                "incidents",
                "businessunits",
                "systemusers",
                "slakpiinstances",
                "incidentresolutions",
                "EntityDefinitions",
                "activitypointers",
            };

            string ConnString=GetAppVAR.GetKeyValue("ServerStgConnString");

            for (int i = 0; i < tablesToPro.Length; i++)
            {
                LogicalName.GetData(_userName, _passWord, _domain, _serviceUri, tablesToPro[i] + "?$top=10", ConnString);
                Console.WriteLine(tablesToPro[i]);
            }

        }
    }
}
