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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.OnayBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.TalepGorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(800, 858);
            this.dgv.TabIndex = 0;
            // 
            // OnayBtn
            // 
            this.OnayBtn.BackColor = System.Drawing.Color.Lime;
            this.OnayBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnayBtn.Location = new System.Drawing.Point(950, 400);
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
            this.RedBtn.Location = new System.Drawing.Point(1275, 400);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(175, 64);
            this.RedBtn.TabIndex = 2;
            this.RedBtn.Text = "RED";
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // TalepGorBtn
            // 
            this.TalepGorBtn.BackColor = System.Drawing.Color.Magenta;
            this.TalepGorBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalepGorBtn.Location = new System.Drawing.Point(1108, 275);
            this.TalepGorBtn.Name = "TalepGorBtn";
            this.TalepGorBtn.Size = new System.Drawing.Size(175, 64);
            this.TalepGorBtn.TabIndex = 3;
            this.TalepGorBtn.Text = "TALEPLERİ GÖRÜNTÜLE";
            this.TalepGorBtn.UseVisualStyleBackColor = false;
            this.TalepGorBtn.Click += new System.EventHandler(this.TalepGorBtn_Click);
            // 
            // OnayTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.TalepGorBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.OnayBtn);
            this.Controls.Add(this.dgv);
            this.Name = "OnayTalepleri";
            this.Size = new System.Drawing.Size(1600, 864);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button OnayBtn;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button TalepGorBtn;
    }
}
