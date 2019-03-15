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
    public partial class FormLoadCases : Form
    {
        public FormLoadCases()
        {
            InitializeComponent();
        }

        public DataTable pLoadCases { get; set; }
        

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("LoadCase");

            foreach (DataGridViewRow dgvr in dgvLoadCases.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    DataRow dr = table.NewRow();
                    dr["LoadCase"] = dgvr.Cells["LoadCase"].Value;
                    table.Rows.Add(dr);
                }
               
            }

            pLoadCases = table;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void RefreshDataSource()
        {
            dgvLoadCases.Columns[0].DataPropertyName = pLoadCases.Columns[0].ColumnName;
            dgvLoadCases.DataSource = this.pLoadCases;
        }

    }
}
