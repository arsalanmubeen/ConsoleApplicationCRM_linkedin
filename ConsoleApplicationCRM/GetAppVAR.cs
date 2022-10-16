using System.Configuration;

namespace ConsoleApplicationCRM
{
    class GetAppVAR
    {
        public static string GetKeyValue(string key)
        {
            if (ConfigurationManager.AppSettings[key] == null)
            {
                return string.Empty;
            }
            else
            {
                return ConfigurationManager.AppSettings[key];
            }
        }
    }
}
