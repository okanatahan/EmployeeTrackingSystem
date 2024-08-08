namespace EmployeeTrackingSystem.UserControls
{
    partial class IzinTalebiOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IzinBaslangicTar = new System.Windows.Forms.DateTimePicker();
            this.IzinBitisTar = new System.Windows.Forms.DateTimePicker();
            this.IzinTalepBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IzinTipleri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzine Çıkılacak Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(956, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "İzin Bitiş Tarihi:";
            // 
            // IzinBaslangicTar
            // 
            this.IzinBaslangicTar.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinBaslangicTar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinBaslangicTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IzinBaslangicTar.Location = new System.Drawing.Point(659, 366);
            this.IzinBaslangicTar.Name = "IzinBaslangicTar";
            this.IzinBaslangicTar.Size = new System.Drawing.Size(200, 25);
            this.IzinBaslangicTar.TabIndex = 2;
            this.IzinBaslangicTar.ValueChanged += new System.EventHandler(this.IzinBaslangicTar_ValueChanged);
            // 
            // IzinBitisTar
            // 
            this.IzinBitisTar.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinBitisTar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinBitisTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IzinBitisTar.Location = new System.Drawing.Point(1135, 366);
            this.IzinBitisTar.Name = "IzinBitisTar";
            this.IzinBitisTar.Size = new System.Drawing.Size(200, 25);
            this.IzinBitisTar.TabIndex = 3;
            this.IzinBitisTar.Value = new System.DateTime(2024, 7, 30, 0, 0, 0, 0);
            // 
            // IzinTalepBtn
            // 
            this.IzinTalepBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinTalepBtn.Location = new System.Drawing.Point(836, 515);
            this.IzinTalepBtn.Name = "IzinTalepBtn";
            this.IzinTalepBtn.Size = new System.Drawing.Size(130, 49);
            this.IzinTalepBtn.TabIndex = 4;
            this.IzinTalepBtn.Text = "İzin Talep Et";
            this.IzinTalepBtn.UseVisualStyleBackColor = true;
            this.IzinTalepBtn.Click += new System.EventHandler(this.IzinTalepBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "İzin Tipi:";
            // 
            // IzinTipleri
            // 
            this.IzinTipleri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.IzinTipleri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IzinTipleri.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinTipleri.FormattingEnabled = true;
            this.IzinTipleri.Location = new System.Drawing.Point(836, 441);
            this.IzinTipleri.Name = "IzinTipleri";
            this.IzinTipleri.Size = new System.Drawing.Size(219, 25);
            this.IzinTipleri.TabIndex = 6;
            // 
            // IzinTalebiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.IzinTipleri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IzinTalepBtn);
            this.Controls.Add(this.IzinBitisTar);
            this.Controls.Add(this.IzinBaslangicTar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzinTalebiOlustur";
            this.Size = new System.Drawing.Size(1800, 972);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker IzinBaslangicTar;
        private System.Windows.Forms.DateTimePicker IzinBitisTar;
        private System.Windows.Forms.Button IzinTalepBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IzinTipleri;
    }
}
