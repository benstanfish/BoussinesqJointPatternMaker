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
            this.PointLoadsDataGridView.Columns[0].DataPropertyName = table.Columns[0].ColumnName;
            this.PointLoadsDataGridView.Columns[1].DataPropertyName = table.Columns[1].ColumnName;
            this.PointLoadsDataGridView.Columns[2].DataPropertyName = table.Columns[2].ColumnName;
            this.PointLoadsDataGridView.Columns[3].DataPropertyName = table.Columns[3].ColumnName;
            this.PointLoadsDataGridView.Columns[4].DataPropertyName = table.Columns[4].ColumnName;

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

        }

    }
}
