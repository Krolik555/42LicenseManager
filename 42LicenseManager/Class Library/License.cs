using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42LicenseManager
{
    public class License
    {
        public int Id { get; set; }
        public string ReviewStatus { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RenewalStatus { get; set; }
        public int PCCount { get; set; }
        public bool Active { get; set; }
        public string Notes { get; set; }
        public bool ChkBxAutoRenew { get; set; }
        public bool ChkBxUninstalled { get; set; }
        public bool ChkBxDeleted { get; set; }


        public string Firstname_LastName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        /// <summary>
        /// Gets Company name if exists else First and Last name.
        /// </summary>
        public string Identifiable_Name
        {
            get
            {
                string _IdentifiableName = "";
                if (CompanyName != "")
                {
                    _IdentifiableName = CompanyName;
                }
                else
                {
                    _IdentifiableName = FirstName + " " + LastName;
                }
                return _IdentifiableName;
            }
        }

        public void CopyDataTo (License _license)
        {
            _license.Id = Id;
            _license.ReviewStatus = ReviewStatus;
            _license.CompanyName = CompanyName;
            _license.FirstName = FirstName;
            _license.LastName = LastName;
            _license.ExpirationDate = ExpirationDate;
            _license.RenewalStatus = RenewalStatus;
            _license.PCCount = PCCount;
            _license.Active = Active;
            _license.Notes = Notes;
            
        }
    }

}
