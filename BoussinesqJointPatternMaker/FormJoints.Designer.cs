namespace BoussinesqJointPatternMaker
{
    partial class JointCoordinatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointCoordinatesForm));
            this.JointCoordinatesDataGridView = new System.Windows.Forms.DataGridView();
            this.Joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonImportJoints = new System.Windows.Forms.Button();
            this.ButtonInstructions = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JointCoordinatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // JointCoordinatesDataGridView
            // 
            this.JointCoordinatesDataGridView.AllowUserToAddRows = false;
            this.JointCoordinatesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JointCoordinatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.JointCoordinatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Joint,
            this.X,
            this.Y,
            this.Z});
            this.JointCoordinatesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.JointCoordinatesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.JointCoordinatesDataGridView.Name = "JointCoordinatesDataGridView";
            this.JointCoordinatesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JointCoordinatesDataGridView.Size = new System.Drawing.Size(423, 508);
            this.JointCoordinatesDataGridView.TabIndex = 0;
            // 
            // Joint
            // 
            this.Joint.HeaderText = "Joint";
            this.Joint.Name = "Joint";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // ButtonImportJoints
            // 
            this.ButtonImportJoints.Location = new System.Drawing.Point(441, 12);
            this.ButtonImportJoints.Name = "ButtonImportJoints";
            this.ButtonImportJoints.Size = new System.Drawing.Size(95, 26);
            this.ButtonImportJoints.TabIndex = 1;
            this.ButtonImportJoints.Text = "Import Joints";
            this.ButtonImportJoints.UseVisualStyleBackColor = true;
            this.ButtonImportJoints.Click += new System.EventHandler(this.ImportJointsButton_Click);
            // 
            // ButtonInstructions
            // 
            this.ButtonInstructions.Location = new System.Drawing.Point(441, 44);
            this.ButtonInstructions.Name = "ButtonInstructions";
            this.ButtonInstructions.Size = new System.Drawing.Size(95, 25);
            this.ButtonInstructions.TabIndex = 4;
            this.ButtonInstructions.Text = "Instructions";
            this.ButtonInstructions.UseVisualStyleBackColor = true;
            this.ButtonInstructions.Click += new System.EventHandler(this.ShowMeHowButton_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Location = new System.Drawing.Point(441, 462);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(95, 26);
            this.ButtonApply.TabIndex = 5;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(441, 494);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(95, 26);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // JointCoordinatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 530);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonInstructions);
            this.Controls.Add(this.ButtonImportJoints);
            this.Controls.Add(this.JointCoordinatesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JointCoordinatesForm";
            this.Opacity = 0.95D;
            this.Text = "Joint Coordinates";
            ((System.ComponentModel.ISupportInitialize)(this.JointCoordinatesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JointCoordinatesDataGridView;
        private System.Windows.Forms.Button ButtonImportJoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.Button ButtonInstructions;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonClose;
    }
}

