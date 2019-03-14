namespace BoussinesqJointPatternMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadJoints = new System.Windows.Forms.Button();
            this.JointsCheckBox = new System.Windows.Forms.CheckBox();
            this.ImportantNotesButton = new System.Windows.Forms.Button();
            this.ReviewJointsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadJoints
            // 
            this.LoadJoints.Location = new System.Drawing.Point(12, 46);
            this.LoadJoints.Name = "LoadJoints";
            this.LoadJoints.Size = new System.Drawing.Size(90, 28);
            this.LoadJoints.TabIndex = 0;
            this.LoadJoints.Text = "Load Joints";
            this.LoadJoints.UseVisualStyleBackColor = true;
            this.LoadJoints.Click += new System.EventHandler(this.LoadJoints_Click);
            // 
            // JointsCheckBox
            // 
            this.JointsCheckBox.AutoSize = true;
            this.JointsCheckBox.Enabled = false;
            this.JointsCheckBox.Location = new System.Drawing.Point(108, 53);
            this.JointsCheckBox.Name = "JointsCheckBox";
            this.JointsCheckBox.Size = new System.Drawing.Size(62, 17);
            this.JointsCheckBox.TabIndex = 1;
            this.JointsCheckBox.Text = "Loaded";
            this.JointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportantNotesButton
            // 
            this.ImportantNotesButton.Location = new System.Drawing.Point(12, 12);
            this.ImportantNotesButton.Name = "ImportantNotesButton";
            this.ImportantNotesButton.Size = new System.Drawing.Size(90, 28);
            this.ImportantNotesButton.TabIndex = 2;
            this.ImportantNotesButton.Text = "Important Notes";
            this.ImportantNotesButton.UseVisualStyleBackColor = true;
            this.ImportantNotesButton.Click += new System.EventHandler(this.ImportantNotesButton_Click);
            // 
            // ReviewJointsButton
            // 
            this.ReviewJointsButton.Location = new System.Drawing.Point(176, 46);
            this.ReviewJointsButton.Name = "ReviewJointsButton";
            this.ReviewJointsButton.Size = new System.Drawing.Size(90, 28);
            this.ReviewJointsButton.TabIndex = 3;
            this.ReviewJointsButton.Text = "Review Joints";
            this.ReviewJointsButton.UseVisualStyleBackColor = true;
            this.ReviewJointsButton.Click += new System.EventHandler(this.ReviewJointsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.ReviewJointsButton);
            this.Controls.Add(this.ImportantNotesButton);
            this.Controls.Add(this.JointsCheckBox);
            this.Controls.Add(this.LoadJoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadJoints;
        private System.Windows.Forms.CheckBox JointsCheckBox;
        private System.Windows.Forms.Button ImportantNotesButton;
        private System.Windows.Forms.Button ReviewJointsButton;
    }
}