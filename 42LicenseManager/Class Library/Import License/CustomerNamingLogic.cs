using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _42LicenseManager.Class_Library.Import_License
{
    public static class CustomerNamingLogic
    {
        /// <summary>
        /// Takes the customer name ("42 Tech Solutions, Inc" or "I - Nathan Ebersole") and determines what is a company name/first/last.
        /// </summary>
        /// <param name="customerLicense"></param>
        /// <param name="CustomerName"></param>
        public static void SortNames (License customerLicense, string CustomerName)
        {
            #region Residential
            // Residential Name (with a first and last name)
            if (CustomerName.StartsWith("I - "))
            {
                CustomerName = CustomerName.Remove(0, 4); // "I - Nathan Ebersole" = "Nathan Ebersole"
                int firstSpaceIndex = CustomerName.IndexOf(" ");
                customerLicense.FirstName = CustomerName.Substring(0, firstSpaceIndex);
                customerLicense.LastName = CustomerName.Substring(firstSpaceIndex + 1);
            }
            #endregion

            #region Business
            else
            {
                customerLicense.CompanyName = CustomerName;
            }
            #endregion
        }
    }
}
