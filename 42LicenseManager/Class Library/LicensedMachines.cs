using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42LicenseManager
{
    public class LicensedMachines
    {
        public int Id { get; set; }
        public string InstallDate { get; set; }
        public string MachineName { get; set; }
        public string MachineNotes { get; set; }
        public int LicenseId { get; set; }

        public void CopyDataTo(LicensedMachines _license)
        {
            _license.Id = Id;
            _license.LicenseId = LicenseId;
            _license.InstallDate = InstallDate;
            _license.MachineName = MachineName;
            _license.MachineNotes = MachineNotes;
        }
    }
}
