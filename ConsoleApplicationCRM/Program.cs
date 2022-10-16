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


            string[] tablesToPro = new string[] {//"",
                //"phonecalls",
                //"tasks",
                //"appointments",
                //"emails" ,
                //"processstages",
                //"workflows",
                //"contacts",
                //"activityparties",
                //"campaigns",
                //"seda_studysectorses",
                //"seda_assessmentdetails",
                //"leads",
                //"accounts",
                //"incidents",
                //"seda_barriertypes",
                //"seda_potentialbuyeropportunityimports",
                //"seda_potentialbuyercontacts",
                //"seda_potentialbuyeropportunitycustomers",
                //"seda_productbuyerses",
                //"seda_casebarrierstakeholders",
                //"seda_hsserieses",
                //"seda_customerproducts",
                //"businessunits",
                //"seda_cities",
                //"seda_countries",
                //"seda_regions",
                //"seda_sectors",
                //"seda_isicdivisions",
                //"seda_isicsections",
                //"seda_casecategories",
                //"seda_casesubcategories",
                //"systemusers",
                //"seda_casestakeholderses"
                //,"seda_potentialbuyeropportunities"
                //,"slakpiinstances"
                //,"seda_customersectors"
                //,"incidentresolutions"
               //, "EntityDefinitions"
               "activitypointers"
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
