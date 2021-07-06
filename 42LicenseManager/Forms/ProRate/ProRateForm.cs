using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Forms.ProRate
{
    public partial class ProRateForm : Form
    {
        DataTable table = new DataTable();

        public ProRateForm()
        {
            InitializeComponent();

            table.Columns.Add("Install/Current Expiration Date", System.Type.GetType("System.DateTime"));
            table.Columns.Add("Expires in (Months)");
        }

        private void aButtonAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(aDTPickerOldExpiration.Value.Date, (DateTime.Now - aDTPickerOldExpiration.Value).ToString());

            aDGVTable.DataSource = table;
        }
    }
}
