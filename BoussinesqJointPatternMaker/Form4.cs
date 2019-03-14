﻿using System;
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


        public MainForm()
        {
            InitializeComponent();
            this.JointsCheckBox.Checked = false;
        }

        private void LoadJoints_Click(object sender, EventArgs e)
        {
            JointCoordinatesForm joints = new JointCoordinatesForm();

            if (joints.ShowDialog() == DialogResult.OK)
            {
                this.JointsDataTable = joints.JointDataTable;
                this.JointsCheckBox.Checked = true;
            }
            else
            {
                MessageBox.Show("Hello Professor Falken...");
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
            review.JointDataTable = JointsDataTable;
            
            review.Show();

        }
    }
}
