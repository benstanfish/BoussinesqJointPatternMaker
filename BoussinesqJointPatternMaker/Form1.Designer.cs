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
            this.ImportJointsButton = new System.Windows.Forms.Button();
            this.Joint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowMeHowButton = new System.Windows.Forms.Button();
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
            this.JointCoordinatesDataGridView.Location = new System.Drawing.Point(12, 26);
            this.JointCoordinatesDataGridView.Name = "JointCoordinatesDataGridView";
            this.JointCoordinatesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JointCoordinatesDataGridView.Size = new System.Drawing.Size(423, 508);
            this.JointCoordinatesDataGridView.TabIndex = 0;
            // 
            // ImportJointsButton
            // 
            this.ImportJointsButton.Location = new System.Drawing.Point(441, 26);
            this.ImportJointsButton.Name = "ImportJointsButton";
            this.ImportJointsButton.Size = new System.Drawing.Size(95, 26);
            this.ImportJointsButton.TabIndex = 1;
            this.ImportJointsButton.Text = "Import Joints";
            this.ImportJointsButton.UseVisualStyleBackColor = true;
            this.ImportJointsButton.Click += new System.EventHandler(this.ImportJointsButton_Click);
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
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(441, 508);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 26);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Import Joint Coordinates from SAP or SAFE";
            // 
            // ShowMeHowButton
            // 
            this.ShowMeHowButton.Location = new System.Drawing.Point(441, 58);
            this.ShowMeHowButton.Name = "ShowMeHowButton";
            this.ShowMeHowButton.Size = new System.Drawing.Size(95, 25);
            this.ShowMeHowButton.TabIndex = 4;
            this.ShowMeHowButton.Text = "How?";
            this.ShowMeHowButton.UseVisualStyleBackColor = true;
            this.ShowMeHowButton.Click += new System.EventHandler(this.ShowMeHowButton_Click);
            // 
            // JointCoordinatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 546);
            this.Controls.Add(this.ShowMeHowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ImportJointsButton);
            this.Controls.Add(this.JointCoordinatesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JointCoordinatesForm";
            this.Opacity = 0.95D;
            this.Text = "Joint Coordinates";
            ((System.ComponentModel.ISupportInitialize)(this.JointCoordinatesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JointCoordinatesDataGridView;
        private System.Windows.Forms.Button ImportJointsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joint;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowMeHowButton;
    }
}

