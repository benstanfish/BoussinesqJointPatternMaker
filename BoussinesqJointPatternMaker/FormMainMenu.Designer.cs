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
            this.ButtonLoadJoints = new System.Windows.Forms.Button();
            this.CheckBoxJointsLoaded = new System.Windows.Forms.CheckBox();
            this.ButtonImportantNotes = new System.Windows.Forms.Button();
            this.ButtonReviewJoints = new System.Windows.Forms.Button();
            this.ButtonReviewPointLoads = new System.Windows.Forms.Button();
            this.CheckBoxPointsLoaded = new System.Windows.Forms.CheckBox();
            this.ButtonPointLoads = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonVersion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLoadJoints
            // 
            this.ButtonLoadJoints.Location = new System.Drawing.Point(12, 46);
            this.ButtonLoadJoints.Name = "ButtonLoadJoints";
            this.ButtonLoadJoints.Size = new System.Drawing.Size(90, 28);
            this.ButtonLoadJoints.TabIndex = 0;
            this.ButtonLoadJoints.Text = "Joints";
            this.ButtonLoadJoints.UseVisualStyleBackColor = true;
            this.ButtonLoadJoints.Click += new System.EventHandler(this.LoadJoints_Click);
            // 
            // CheckBoxJointsLoaded
            // 
            this.CheckBoxJointsLoaded.AutoSize = true;
            this.CheckBoxJointsLoaded.Enabled = false;
            this.CheckBoxJointsLoaded.Location = new System.Drawing.Point(108, 53);
            this.CheckBoxJointsLoaded.Name = "CheckBoxJointsLoaded";
            this.CheckBoxJointsLoaded.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxJointsLoaded.TabIndex = 1;
            this.CheckBoxJointsLoaded.TabStop = false;
            this.CheckBoxJointsLoaded.Text = "Loaded";
            this.CheckBoxJointsLoaded.UseVisualStyleBackColor = true;
            // 
            // ButtonImportantNotes
            // 
            this.ButtonImportantNotes.Location = new System.Drawing.Point(12, 12);
            this.ButtonImportantNotes.Name = "ButtonImportantNotes";
            this.ButtonImportantNotes.Size = new System.Drawing.Size(90, 28);
            this.ButtonImportantNotes.TabIndex = 2;
            this.ButtonImportantNotes.Text = "Important Notes";
            this.ButtonImportantNotes.UseVisualStyleBackColor = true;
            this.ButtonImportantNotes.Click += new System.EventHandler(this.ImportantNotesButton_Click);
            // 
            // ButtonReviewJoints
            // 
            this.ButtonReviewJoints.Location = new System.Drawing.Point(206, 46);
            this.ButtonReviewJoints.Name = "ButtonReviewJoints";
            this.ButtonReviewJoints.Size = new System.Drawing.Size(90, 28);
            this.ButtonReviewJoints.TabIndex = 3;
            this.ButtonReviewJoints.Text = "Review";
            this.ButtonReviewJoints.UseVisualStyleBackColor = true;
            this.ButtonReviewJoints.Click += new System.EventHandler(this.ReviewJointsButton_Click);
            // 
            // ButtonReviewPointLoads
            // 
            this.ButtonReviewPointLoads.Location = new System.Drawing.Point(206, 80);
            this.ButtonReviewPointLoads.Name = "ButtonReviewPointLoads";
            this.ButtonReviewPointLoads.Size = new System.Drawing.Size(90, 28);
            this.ButtonReviewPointLoads.TabIndex = 6;
            this.ButtonReviewPointLoads.Text = "Review";
            this.ButtonReviewPointLoads.UseVisualStyleBackColor = true;
            this.ButtonReviewPointLoads.Click += new System.EventHandler(this.ButtonReviewPointLoads_Click);
            // 
            // CheckBoxPointsLoaded
            // 
            this.CheckBoxPointsLoaded.AutoSize = true;
            this.CheckBoxPointsLoaded.Enabled = false;
            this.CheckBoxPointsLoaded.Location = new System.Drawing.Point(108, 87);
            this.CheckBoxPointsLoaded.Name = "CheckBoxPointsLoaded";
            this.CheckBoxPointsLoaded.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxPointsLoaded.TabIndex = 5;
            this.CheckBoxPointsLoaded.TabStop = false;
            this.CheckBoxPointsLoaded.Text = "Loaded";
            this.CheckBoxPointsLoaded.UseVisualStyleBackColor = true;
            // 
            // ButtonPointLoads
            // 
            this.ButtonPointLoads.Location = new System.Drawing.Point(12, 80);
            this.ButtonPointLoads.Name = "ButtonPointLoads";
            this.ButtonPointLoads.Size = new System.Drawing.Size(90, 28);
            this.ButtonPointLoads.TabIndex = 4;
            this.ButtonPointLoads.Text = "Point Loads";
            this.ButtonPointLoads.UseVisualStyleBackColor = true;
            this.ButtonPointLoads.Click += new System.EventHandler(this.ButtonPointLoads_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(206, 219);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(90, 28);
            this.ButtonQuit.TabIndex = 7;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonVersion
            // 
            this.ButtonVersion.Location = new System.Drawing.Point(206, 12);
            this.ButtonVersion.Name = "ButtonVersion";
            this.ButtonVersion.Size = new System.Drawing.Size(90, 28);
            this.ButtonVersion.TabIndex = 8;
            this.ButtonVersion.Text = "About";
            this.ButtonVersion.UseVisualStyleBackColor = true;
            this.ButtonVersion.Click += new System.EventHandler(this.ButtonVersion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 255);
            this.Controls.Add(this.ButtonVersion);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonReviewPointLoads);
            this.Controls.Add(this.CheckBoxPointsLoaded);
            this.Controls.Add(this.ButtonPointLoads);
            this.Controls.Add(this.ButtonReviewJoints);
            this.Controls.Add(this.ButtonImportantNotes);
            this.Controls.Add(this.CheckBoxJointsLoaded);
            this.Controls.Add(this.ButtonLoadJoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoadJoints;
        private System.Windows.Forms.CheckBox CheckBoxJointsLoaded;
        private System.Windows.Forms.Button ButtonImportantNotes;
        private System.Windows.Forms.Button ButtonReviewJoints;
        private System.Windows.Forms.Button ButtonReviewPointLoads;
        private System.Windows.Forms.CheckBox CheckBoxPointsLoaded;
        private System.Windows.Forms.Button ButtonPointLoads;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonVersion;
    }
}