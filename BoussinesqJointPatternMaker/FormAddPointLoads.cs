using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoussinesqJointPatternMaker
{
    public partial class AddPointLoadsForm : Form
    {
        public DataTable PointLoadsDataTable { get; set; }

        public AddPointLoadsForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.PointLoadsDataTable = (DataTable)PointLoadsDataGridView.DataSource;
        }
    }
}
