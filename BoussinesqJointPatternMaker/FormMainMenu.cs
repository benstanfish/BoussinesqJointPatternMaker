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
    public partial class MainForm : Form
    {
        private DataTable JointsDataTable { get; set; }
        private DataTable LoadCasesDataTable { get; set; }
        private DataTable PointsDataTable { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.CheckBoxJointsLoaded.Checked = false;
            this.CheckBoxPointsLoaded.Checked = false;
        }

        private void LoadJoints_Click(object sender, EventArgs e)
        {
            JointCoordinatesForm joints = new JointCoordinatesForm();

            if (joints.ShowDialog() == DialogResult.OK)
            {
                this.JointsDataTable = joints.JointDataTable;
                this.CheckBoxJointsLoaded.Checked = true;
                
            }
            else
            {
            }
            
        }

        private void ImportantNotesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReviewJointsButton_Click(object sender, EventArgs e)
        {
            JointCoordinatesForm review = new JointCoordinatesForm();
            review.DisableButtons();
            review.RefreshDataSource(JointsDataTable);
            review.Show();

        }

        private void ButtonPointLoads_Click(object sender, EventArgs e)
        {
            FormAddPointLoads points = new FormAddPointLoads();
            points.pLoadCaseTable = LoadCasesDataTable;
            if (points.ShowDialog() == DialogResult.OK)
            {
                this.PointsDataTable = points.pDataTable;
                
                this.CheckBoxPointsLoaded.Checked = true;
            }
            else
            {
            }

        }

        private void ButtonReviewPointLoads_Click(object sender, EventArgs e)
        {
            FormAddPointLoads review = new FormAddPointLoads();
            review.pDataTable = PointsDataTable;

            review.RefreshDataSource();
            review.Show();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            
        }


        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.Show();
        }

        private void importantNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesForm nf = new NotesForm();
            nf.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnalysis fa = new FormAnalysis();
            fa.Show();
        }

        private void ButtonLoadCases_Click(object sender, EventArgs e)
        {
            FormLoadCases loadCases = new FormLoadCases();
            if (loadCases.ShowDialog() == DialogResult.OK)
            {
                this.LoadCasesDataTable = loadCases.pLoadCases;
                this.CheckBoxLoadCases.Checked = true;
            }
            else
            {
            }
        }

        private void ButtonReviewLoadCases_Click(object sender, EventArgs e)
        {
            FormLoadCases review = new FormLoadCases();
            review.pLoadCases = LoadCasesDataTable;
            review.RefreshDataSource();
            review.Show();
        }
    }
}
