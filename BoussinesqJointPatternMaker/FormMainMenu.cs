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
        private DataTable PointsDataTable { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.CheckBoxJointsLoaded.Checked = false;
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
            NotesForm nf = new NotesForm();
            nf.Show();
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
            if (points.ShowDialog() == DialogResult.OK)
            {
   
                this.PointsDataTable = points.PointLoadsDataTable;
                this.CheckBoxPointsLoaded.Checked = true;
 
            }
            else
            {
            }

        }

        private void ButtonReviewPointLoads_Click(object sender, EventArgs e)
        {
            FormAddPointLoads review = new FormAddPointLoads();
            review.RefreshDataSource(PointsDataTable);
            review.Show();
        }
    }
}
