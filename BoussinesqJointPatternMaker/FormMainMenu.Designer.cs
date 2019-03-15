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
            this.ButtonReviewJoints = new System.Windows.Forms.Button();
            this.ButtonReviewPointLoads = new System.Windows.Forms.Button();
            this.CheckBoxPointsLoaded = new System.Windows.Forms.CheckBox();
            this.ButtonPointLoads = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importantNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLoadCases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxLoadCases = new System.Windows.Forms.CheckBox();
            this.ButtonReviewLoadCases = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLoadJoints
            // 
            this.ButtonLoadJoints.Location = new System.Drawing.Point(12, 49);
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
            this.CheckBoxJointsLoaded.Location = new System.Drawing.Point(108, 56);
            this.CheckBoxJointsLoaded.Name = "CheckBoxJointsLoaded";
            this.CheckBoxJointsLoaded.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxJointsLoaded.TabIndex = 1;
            this.CheckBoxJointsLoaded.TabStop = false;
            this.CheckBoxJointsLoaded.Text = "Loaded";
            this.CheckBoxJointsLoaded.UseVisualStyleBackColor = true;
            // 
            // ButtonReviewJoints
            // 
            this.ButtonReviewJoints.Location = new System.Drawing.Point(201, 49);
            this.ButtonReviewJoints.Name = "ButtonReviewJoints";
            this.ButtonReviewJoints.Size = new System.Drawing.Size(90, 28);
            this.ButtonReviewJoints.TabIndex = 3;
            this.ButtonReviewJoints.Text = "Review";
            this.ButtonReviewJoints.UseVisualStyleBackColor = true;
            this.ButtonReviewJoints.Click += new System.EventHandler(this.ReviewJointsButton_Click);
            // 
            // ButtonReviewPointLoads
            // 
            this.ButtonReviewPointLoads.Location = new System.Drawing.Point(201, 140);
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
            this.CheckBoxPointsLoaded.Location = new System.Drawing.Point(108, 147);
            this.CheckBoxPointsLoaded.Name = "CheckBoxPointsLoaded";
            this.CheckBoxPointsLoaded.Size = new System.Drawing.Size(63, 17);
            this.CheckBoxPointsLoaded.TabIndex = 5;
            this.CheckBoxPointsLoaded.TabStop = false;
            this.CheckBoxPointsLoaded.Text = "Entered";
            this.CheckBoxPointsLoaded.UseVisualStyleBackColor = true;
            // 
            // ButtonPointLoads
            // 
            this.ButtonPointLoads.Location = new System.Drawing.Point(12, 140);
            this.ButtonPointLoads.Name = "ButtonPointLoads";
            this.ButtonPointLoads.Size = new System.Drawing.Size(90, 28);
            this.ButtonPointLoads.TabIndex = 4;
            this.ButtonPointLoads.Text = "Point Loads";
            this.ButtonPointLoads.UseVisualStyleBackColor = true;
            this.ButtonPointLoads.Click += new System.EventHandler(this.ButtonPointLoads_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importantNotesToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // importantNotesToolStripMenuItem
            // 
            this.importantNotesToolStripMenuItem.Name = "importantNotesToolStripMenuItem";
            this.importantNotesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importantNotesToolStripMenuItem.Text = "FAQ";
            this.importantNotesToolStripMenuItem.Click += new System.EventHandler(this.importantNotesToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // ButtonLoadCases
            // 
            this.ButtonLoadCases.Location = new System.Drawing.Point(12, 106);
            this.ButtonLoadCases.Name = "ButtonLoadCases";
            this.ButtonLoadCases.Size = new System.Drawing.Size(90, 28);
            this.ButtonLoadCases.TabIndex = 10;
            this.ButtonLoadCases.Text = "Load Cases";
            this.ButtonLoadCases.UseVisualStyleBackColor = true;
            this.ButtonLoadCases.Click += new System.EventHandler(this.ButtonLoadCases_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Import Joint Coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Create Load Information";
            // 
            // CheckBoxLoadCases
            // 
            this.CheckBoxLoadCases.AutoSize = true;
            this.CheckBoxLoadCases.Enabled = false;
            this.CheckBoxLoadCases.Location = new System.Drawing.Point(108, 113);
            this.CheckBoxLoadCases.Name = "CheckBoxLoadCases";
            this.CheckBoxLoadCases.Size = new System.Drawing.Size(63, 17);
            this.CheckBoxLoadCases.TabIndex = 13;
            this.CheckBoxLoadCases.TabStop = false;
            this.CheckBoxLoadCases.Text = "Created";
            this.CheckBoxLoadCases.UseVisualStyleBackColor = true;
            // 
            // ButtonReviewLoadCases
            // 
            this.ButtonReviewLoadCases.Location = new System.Drawing.Point(201, 106);
            this.ButtonReviewLoadCases.Name = "ButtonReviewLoadCases";
            this.ButtonReviewLoadCases.Size = new System.Drawing.Size(90, 28);
            this.ButtonReviewLoadCases.TabIndex = 14;
            this.ButtonReviewLoadCases.Text = "Review";
            this.ButtonReviewLoadCases.UseVisualStyleBackColor = true;
            this.ButtonReviewLoadCases.Click += new System.EventHandler(this.ButtonReviewLoadCases_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 274);
            this.Controls.Add(this.ButtonReviewLoadCases);
            this.Controls.Add(this.CheckBoxLoadCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLoadCases);
            this.Controls.Add(this.ButtonReviewPointLoads);
            this.Controls.Add(this.CheckBoxPointsLoaded);
            this.Controls.Add(this.ButtonPointLoads);
            this.Controls.Add(this.ButtonReviewJoints);
            this.Controls.Add(this.CheckBoxJointsLoaded);
            this.Controls.Add(this.ButtonLoadJoints);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoadJoints;
        private System.Windows.Forms.CheckBox CheckBoxJointsLoaded;
        private System.Windows.Forms.Button ButtonReviewJoints;
        private System.Windows.Forms.Button ButtonReviewPointLoads;
        private System.Windows.Forms.CheckBox CheckBoxPointsLoaded;
        private System.Windows.Forms.Button ButtonPointLoads;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importantNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.Button ButtonLoadCases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxLoadCases;
        private System.Windows.Forms.Button ButtonReviewLoadCases;
    }
}