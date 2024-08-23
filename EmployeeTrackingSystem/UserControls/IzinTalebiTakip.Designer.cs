namespace EmployeeTrackingSystem.UserControls
{
    partial class IzinTalebiTakip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IzinTalepleriDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IzinTalepleriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // IzinTalepleriDGV
            // 
            this.IzinTalepleriDGV.AllowUserToAddRows = false;
            this.IzinTalepleriDGV.AllowUserToDeleteRows = false;
            this.IzinTalepleriDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IzinTalepleriDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IzinTalepleriDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IzinTalepleriDGV.ColumnHeadersHeight = 25;
            this.IzinTalepleriDGV.Location = new System.Drawing.Point(300, 161);
            this.IzinTalepleriDGV.Name = "IzinTalepleriDGV";
            this.IzinTalepleriDGV.ReadOnly = true;
            this.IzinTalepleriDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IzinTalepleriDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinTalepleriDGV.Size = new System.Drawing.Size(1200, 600);
            this.IzinTalepleriDGV.TabIndex = 0;
            // 
            // IzinTalebiTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.IzinTalepleriDGV);
            this.Name = "IzinTalebiTakip";
            this.Size = new System.Drawing.Size(1800, 972);
            ((System.ComponentModel.ISupportInitialize)(this.IzinTalepleriDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IzinTalepleriDGV;
    }
}
