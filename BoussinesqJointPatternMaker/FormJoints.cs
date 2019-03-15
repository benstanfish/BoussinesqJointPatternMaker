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

        /* NOT CURRENTLY USED
        public System.Data.DataTable ReturnJointCoordinateFromExcel(string filePath)
        {
            try
            {
                if (filePath == string.Empty)
                {
                    return null;
                }
                else
                {
                    Excel.Application oXL = new Excel.Application();
                    oXL.Visible = false;
                    oXL.DisplayAlerts = false;
                    Excel.Workbook wk = oXL.Workbooks.Open(filePath);
                    Excel.Worksheet ws = wk.Worksheets.get_Item(1) as Worksheet;

                    // string rng = ws.UsedRange.Address.ToString();

                    Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                    Range range = ws.get_Range("A3", last);

                    int lastUsedRow = last.Row;
                    int lastUsedColumn = last.Column;
                    int totalUsedRows = last.Row - 2;

                    System.Data.DataTable table = new System.Data.DataTable();
                    table.Columns.Add("JointID", typeof(string));
                    table.Columns.Add("X", typeof(double));
                    table.Columns.Add("Y", typeof(double));
                    table.Columns.Add("Z", typeof(double));

                    for (int i = 1; i < totalUsedRows; i++)
                    {
                        table.Rows.Add(
                            range.Cells[i, 1].value,
                            range.Cells[i, 4].value,
                            range.Cells[i, 5].value,
                            range.Cells[i, 7].value);
                    }

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wk);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                    wk.Close(false, null, null);
                    wk = null;
                    oXL.Quit();
                    oXL = null;
                    

                    return table;
                }
            }
            catch
            {
                return null;
            }
        }
        */
        
        private System.Data.DataTable GetExcelTable(string path)
        {
            var oXL = new Excel.Application();
            oXL.Visible = false;
            oXL.DisplayAlerts = false;
            Workbook wk = oXL.Workbooks.Open(path);
            Worksheet ws = wk.Worksheets.get_Item(1) as Worksheet;
            Range usedRange = ws.UsedRange;
            // Range copyRange = ws.Range["A3", usedRange.Cells[usedRange.Rows.Count,usedRange.Columns.Count]];

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
