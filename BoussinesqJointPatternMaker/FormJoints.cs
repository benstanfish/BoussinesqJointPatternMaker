using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace BoussinesqJointPatternMaker
{
    public partial class JointCoordinatesForm : Form
    {
        
        public System.Data.DataTable JointDataTable { get; set; }
        public void DisableButtons()
        {
            this.ButtonImportJoints.Enabled = false;
            this.ButtonInstructions.Enabled = false;
            this.ButtonApply.Enabled = false;
        }
        public void RefreshDataSource(System.Data.DataTable table)
        {

            JointCoordinatesDataGridView.Columns[0].DataPropertyName = table.Columns[0].ColumnName;
            JointCoordinatesDataGridView.Columns[1].DataPropertyName = table.Columns[1].ColumnName;
            JointCoordinatesDataGridView.Columns[2].DataPropertyName = table.Columns[2].ColumnName;
            JointCoordinatesDataGridView.Columns[3].DataPropertyName = table.Columns[3].ColumnName;

            this.JointCoordinatesDataGridView.DataSource = table;
        }

        public JointCoordinatesForm()
        {
            InitializeComponent();
        }

        private string GetExcelFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Excel File with Joint Coordinates";
            ofd.Filter = "Excel Files (*.xlsx)|*.xlsx" + "|" +
                "Excel Macro Files (*.xlsm)|*.xlsm" + "|" +
                "Comma Seperated Text File (*.csv)|*.csv"+"|"+
                "All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(ofd.FileName);
                return ofd.FileName;
            }
            else
            {
                return "";
            }
        }
        
        private System.Data.DataTable GetExcelTable(string path)
        {
            var oXL = new Excel.Application();
            oXL.Visible = false;
            oXL.DisplayAlerts = false;
            Workbook wk = oXL.Workbooks.Open(path);
            Worksheet ws = wk.Worksheets.get_Item(1) as Worksheet;
            Range usedRange = ws.UsedRange;

            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("JointID");
            table.Columns.Add("X");
            table.Columns.Add("Y");
            table.Columns.Add("Z");

            for (int i = 3; i < usedRange.Rows.Count; i++)
            {
                table.Rows.Add(
                    usedRange.Cells[i + 1, 1].value, 
                    usedRange.Cells[i + 1, 4].value,
                    usedRange.Cells[i + 1, 5].value,
                    usedRange.Cells[i + 1, 7].value
                    );
            }
            
            wk.Close(false, null, null);
            oXL.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wk);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);

            return table;
        }
        
        private void ImportJointsButton_Click(object sender, EventArgs e)
        {

            System.Data.DataTable table = new System.Data.DataTable();
            table = GetExcelTable(GetExcelFilePath());

            JointCoordinatesDataGridView.Columns[0].DataPropertyName = table.Columns[0].ColumnName;
            JointCoordinatesDataGridView.Columns[1].DataPropertyName = table.Columns[1].ColumnName;
            JointCoordinatesDataGridView.Columns[2].DataPropertyName = table.Columns[2].ColumnName;
            JointCoordinatesDataGridView.Columns[3].DataPropertyName = table.Columns[3].ColumnName;

            JointCoordinatesDataGridView.DataSource = table;

            this.JointDataTable = table;
        }


        private void ShowMeHowButton_Click(object sender, EventArgs e)
        {
            FormJointInstructions form2 = new FormJointInstructions();
            form2.Show();
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
