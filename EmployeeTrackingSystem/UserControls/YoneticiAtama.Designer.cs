namespace EmployeeTrackingSystem.UserControls
{
    partial class YoneticiAtama
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
            this.PersonellerDGV = new System.Windows.Forms.DataGridView();
            this.YoneticiAtaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonellerDGV
            // 
            this.PersonellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PersonellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonellerDGV.Location = new System.Drawing.Point(3, 3);
            this.PersonellerDGV.Name = "PersonellerDGV";
            this.PersonellerDGV.Size = new System.Drawing.Size(1794, 607);
            this.PersonellerDGV.TabIndex = 0;
            // 
            // YoneticiAtaBtn
            // 
            this.YoneticiAtaBtn.BackColor = System.Drawing.Color.Purple;
            this.YoneticiAtaBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoneticiAtaBtn.Location = new System.Drawing.Point(812, 683);
            this.YoneticiAtaBtn.Name = "YoneticiAtaBtn";
            this.YoneticiAtaBtn.Size = new System.Drawing.Size(175, 64);
            this.YoneticiAtaBtn.TabIndex = 2;
            this.YoneticiAtaBtn.Text = "Yönetici Olarak Ata";
            this.YoneticiAtaBtn.UseVisualStyleBackColor = false;
            this.YoneticiAtaBtn.Click += new System.EventHandler(this.YoneticiAtaBtn_Click);
            // 
            // YoneticiAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.YoneticiAtaBtn);
            this.Controls.Add(this.PersonellerDGV);
            this.Name = "YoneticiAtama";
            this.Size = new System.Drawing.Size(1800, 972);
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonellerDGV;
        private System.Windows.Forms.Button YoneticiAtaBtn;
    }
}
