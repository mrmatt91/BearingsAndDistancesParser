namespace BearingsAndDistancesParser
{
    partial class BearingDistance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDirection1 = new System.Windows.Forms.ComboBox();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.cmbDirection2 = new System.Windows.Forms.ComboBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.03681F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.96319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.Controls.Add(this.cmbDirection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDegrees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMinutes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSeconds, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDirection2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDistance, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbDirection1
            // 
            this.cmbDirection1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection1.FormattingEnabled = true;
            this.cmbDirection1.Location = new System.Drawing.Point(3, 3);
            this.cmbDirection1.Name = "cmbDirection1";
            this.cmbDirection1.Size = new System.Drawing.Size(56, 23);
            this.cmbDirection1.TabIndex = 0;
            // 
            // txtDegrees
            // 
            this.txtDegrees.Location = new System.Drawing.Point(68, 3);
            this.txtDegrees.MaxLength = 3;
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.Size = new System.Drawing.Size(95, 23);
            this.txtDegrees.TabIndex = 1;
            this.txtDegrees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDegrees_KeyPress);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(173, 3);
            this.txtMinutes.MaxLength = 3;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(100, 23);
            this.txtMinutes.TabIndex = 2;
            this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutes_KeyPress);
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(279, 3);
            this.txtSeconds.MaxLength = 3;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(97, 23);
            this.txtSeconds.TabIndex = 3;
            this.txtSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeconds_KeyPress);
            // 
            // cmbDirection2
            // 
            this.cmbDirection2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection2.FormattingEnabled = true;
            this.cmbDirection2.Location = new System.Drawing.Point(382, 3);
            this.cmbDirection2.Name = "cmbDirection2";
            this.cmbDirection2.Size = new System.Drawing.Size(58, 23);
            this.cmbDirection2.TabIndex = 4;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(446, 3);
            this.txtDistance.MaxLength = 7;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(95, 23);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistance_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(547, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(268, 51);
            this.txtDescription.TabIndex = 6;
            // 
            // BearingDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BearingDistance";
            this.Size = new System.Drawing.Size(818, 61);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbDirection1;
        private TextBox txtDegrees;
        private TextBox txtMinutes;
        private TextBox txtSeconds;
        private ComboBox cmbDirection2;
        private TextBox txtDistance;
        private TextBox txtDescription;
    }
}
