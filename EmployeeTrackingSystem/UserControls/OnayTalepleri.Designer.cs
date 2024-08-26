namespace EmployeeTrackingSystem.UserControls
{
    partial class OnayTalepleri
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
            this.OnayTalepleriDGV = new System.Windows.Forms.DataGridView();
            this.OnayBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OnayTalepleriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OnayTalepleriDGV
            // 
            this.OnayTalepleriDGV.AllowUserToAddRows = false;
            this.OnayTalepleriDGV.AllowUserToDeleteRows = false;
            this.OnayTalepleriDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OnayTalepleriDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OnayTalepleriDGV.ColumnHeadersHeight = 30;
            this.OnayTalepleriDGV.Location = new System.Drawing.Point(300, 60);
            this.OnayTalepleriDGV.Name = "OnayTalepleriDGV";
            this.OnayTalepleriDGV.ReadOnly = true;
            this.OnayTalepleriDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OnayTalepleriDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OnayTalepleriDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnayTalepleriDGV.RowTemplate.Height = 30;
            this.OnayTalepleriDGV.Size = new System.Drawing.Size(1200, 600);
            this.OnayTalepleriDGV.TabIndex = 0;
            // 
            // OnayBtn
            // 
            this.OnayBtn.BackColor = System.Drawing.Color.Lime;
            this.OnayBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnayBtn.Location = new System.Drawing.Point(650, 720);
            this.OnayBtn.Name = "OnayBtn";
            this.OnayBtn.Size = new System.Drawing.Size(175, 64);
            this.OnayBtn.TabIndex = 1;
            this.OnayBtn.Text = "ONAY";
            this.OnayBtn.UseVisualStyleBackColor = false;
            this.OnayBtn.Click += new System.EventHandler(this.OnayBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.Red;
            this.RedBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedBtn.Location = new System.Drawing.Point(975, 720);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(175, 64);
            this.RedBtn.TabIndex = 2;
            this.RedBtn.Text = "RED";
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // OnayTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.OnayBtn);
            this.Controls.Add(this.OnayTalepleriDGV);
            this.Name = "OnayTalepleri";
            this.Size = new System.Drawing.Size(1800, 972);
            ((System.ComponentModel.ISupportInitialize)(this.OnayTalepleriDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OnayTalepleriDGV;
        private System.Windows.Forms.Button OnayBtn;
        private System.Windows.Forms.Button RedBtn;
    }
}
