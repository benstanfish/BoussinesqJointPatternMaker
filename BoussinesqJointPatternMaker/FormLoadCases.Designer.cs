namespace BoussinesqJointPatternMaker
{
    partial class FormLoadCases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadCases));
            this.dgvLoadCases = new System.Windows.Forms.DataGridView();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LoadCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadCases)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoadCases
            // 
            this.dgvLoadCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoadCase});
            this.dgvLoadCases.Location = new System.Drawing.Point(12, 12);
            this.dgvLoadCases.Name = "dgvLoadCases";
            this.dgvLoadCases.Size = new System.Drawing.Size(440, 352);
            this.dgvLoadCases.TabIndex = 0;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(296, 370);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 1;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(377, 370);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LoadCase
            // 
            this.LoadCase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadCase.HeaderText = "Load Case";
            this.LoadCase.Name = "LoadCase";
            // 
            // FormLoadCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 401);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.dgvLoadCases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoadCases";
            this.Text = "Load Cases";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadCases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadCases;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadCase;
    }
}