using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.WorkerManager
{
    public partial class WorkerReport : Form
    {
        public WorkerReport()
        {
            InitializeComponent();
        }

        private void WorkerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsWorker.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DsWorker.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
