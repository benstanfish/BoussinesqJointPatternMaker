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
        public DataTable PointLoadsDataTable { get; set; }

        public void RefreshDataSource(System.Data.DataTable table)
        {
            /*
            PointLoadsDataGridView.Columns[0].DataPropertyName = table.Columns[0].ColumnName;
            PointLoadsDataGridView.Columns[1].DataPropertyName = table.Columns[1].ColumnName;
            PointLoadsDataGridView.Columns[2].DataPropertyName = table.Columns[2].ColumnName;
            PointLoadsDataGridView.Columns[3].DataPropertyName = table.Columns[3].ColumnName;
            */

            this.PointLoadsDataGridView.DataSource = table;
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
            PointLoadsDataGridView.EndEdit();
            DataTable table = new DataTable();
            for(int i = 0; i < PointLoadsDataGridView.ColumnCount; i++)
            {
                table.Columns.Add();
            }
            foreach(DataGridViewRow row in PointLoadsDataGridView.Rows)
            {
                DataRow dr = table.NewRow();
                for(int j = 0; j < table.Columns.Count; j++)
                {
                    dr[j] = row.Cells[j];
                }
                table.Rows.Add(dr);
            }

            PointLoadsDataTable = table;
            this.Close();
        }

    }
}
