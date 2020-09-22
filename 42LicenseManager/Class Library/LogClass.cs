using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42LicenseManager
{
    public class LogClass
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int LicenseId { get; set; }
        public string Log { get; set; }


        public void CopyLogTo(LogClass _Log)
        {
            _Log.Id = Id;
            _Log.Date = Date;
            _Log.LicenseId = LicenseId;
            _Log.Log = Log;
        }
    }
}
