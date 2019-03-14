﻿namespace BoussinesqJointPatternMaker
{
    partial class AddPointLoadsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPointLoadsForm));
            this.PointLoadsDataGridView = new System.Windows.Forms.DataGridView();
            this.PointID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magnitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PointLoadsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PointLoadsDataGridView
            // 
            this.PointLoadsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PointLoadsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointLoadsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointID,
            this.X,
            this.Y,
            this.Z,
            this.Magnitude});
            this.PointLoadsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PointLoadsDataGridView.Name = "PointLoadsDataGridView";
            this.PointLoadsDataGridView.Size = new System.Drawing.Size(520, 415);
            this.PointLoadsDataGridView.TabIndex = 0;
            // 
            // PointID
            // 
            this.PointID.HeaderText = "Point ID";
            this.PointID.Name = "PointID";
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
            // Magnitude
            // 
            this.Magnitude.HeaderText = "Magnitude";
            this.Magnitude.Name = "Magnitude";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 433);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 28);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(444, 433);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(88, 28);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AddPointLoadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 467);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PointLoadsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPointLoadsForm";
            this.Text = "Add New Point Loads";
            ((System.ComponentModel.ISupportInitialize)(this.PointLoadsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PointLoadsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magnitude;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ApplyButton;
    }
}