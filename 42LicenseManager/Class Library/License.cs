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
        public bool ChkBxWillCancel { get; set; }
        public bool ChkBxUninstalled { get; set; }
        public bool ChkBxDeleted { get; set; }


        public string BasicInfo
        {
            get
            {
                return $"{FirstName} {LastName}";
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
