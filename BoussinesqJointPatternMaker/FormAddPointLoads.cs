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
            /*
            PointLoadsDataGridView.Columns[0].DataPropertyName = table.Columns[0].ColumnName;
            PointLoadsDataGridView.Columns[1].DataPropertyName = table.Columns[1].ColumnName;
            PointLoadsDataGridView.Columns[2].DataPropertyName = table.Columns[2].ColumnName;
            PointLoadsDataGridView.Columns[3].DataPropertyName = table.Columns[3].ColumnName;
            PointLoadsDataGridView.Columns[4].DataPropertyName = table.Columns[4].ColumnName;
            */

            this.PointLoadsDataGridView.DataSource = pDataTable;
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

            /*
            DataTable table = new DataTable();

            
            for (int i = 0; i < PointLoadsDataGridView.ColumnCount; i++)
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
            */



            this.Close();
        }

        //void PointLoadsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    if (PointLoadsDataGridView.IsCurrentCellDirty)
        //    {
        //        PointLoadsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //    }
        //}

        private void PointLoadsDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            PointLoadsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
