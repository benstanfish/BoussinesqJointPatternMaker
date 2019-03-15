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
    public partial class FormAddPointLoads : Form
    {
        public System.Data.DataTable pDataTable { get; set; }

        public void RefreshDataSource()
        {

            dgvPointLoads.Columns[0].DataPropertyName = pDataTable.Columns[0].ColumnName;
            dgvPointLoads.Columns[1].DataPropertyName = pDataTable.Columns[1].ColumnName;
            dgvPointLoads.Columns[2].DataPropertyName = pDataTable.Columns[2].ColumnName;
            dgvPointLoads.Columns[3].DataPropertyName = pDataTable.Columns[3].ColumnName;
            dgvPointLoads.Columns[4].DataPropertyName = pDataTable.Columns[4].ColumnName;

            dgvPointLoads.DataSource = this.pDataTable;
        }

        public FormAddPointLoads()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("PointID");
            table.Columns.Add("X");
            table.Columns.Add("Y");
            table.Columns.Add("Z");
            table.Columns.Add("Magnitude");

            
            foreach (DataGridViewRow dgvr in dgvPointLoads.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    DataRow dr = table.NewRow();
                    dr["PointID"] = dgvr.Cells["PointID"].Value;
                    dr["X"] = dgvr.Cells["X"].Value;
                    dr["Y"] = dgvr.Cells["Y"].Value;
                    dr["Z"] = dgvr.Cells["Z"].Value;
                    dr["Magnitude"] = dgvr.Cells["Magnitude"].Value;
                    table.Rows.Add(dr);
                }
                
            }

            pDataTable = table;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
