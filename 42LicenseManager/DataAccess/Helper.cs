using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42LicenseManager
{
    class Helper
    {
        public static string CnnVal(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string CnnValCustom(string DBDIR_Name)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["GDataLicensesCustom"].ConnectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {DBDIR_Name}; Integrated Security = True; Connect Timeout = 30";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            return ConfigurationManager.ConnectionStrings["GDataLicensesCustom"].ConnectionString;
        }
    }
}
