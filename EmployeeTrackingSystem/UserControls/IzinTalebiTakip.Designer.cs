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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tlp_grntl_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(400, 130);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(800, 464);
            this.dgv.TabIndex = 0;
            // 
            // tlp_grntl_btn
            // 
            this.tlp_grntl_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.tlp_grntl_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp_grntl_btn.Location = new System.Drawing.Point(712, 655);
            this.tlp_grntl_btn.Name = "tlp_grntl_btn";
            this.tlp_grntl_btn.Size = new System.Drawing.Size(175, 64);
            this.tlp_grntl_btn.TabIndex = 4;
            this.tlp_grntl_btn.Text = "TALEPLERİ GÖRÜNTÜLE";
            this.tlp_grntl_btn.UseVisualStyleBackColor = false;
            this.tlp_grntl_btn.Click += new System.EventHandler(this.tlp_grntl_btn_Click);
            // 
            // IzinTalebiTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tlp_grntl_btn);
            this.Controls.Add(this.dgv);
            this.Name = "IzinTalebiTakip";
            this.Size = new System.Drawing.Size(1600, 864);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button tlp_grntl_btn;
    }
}
