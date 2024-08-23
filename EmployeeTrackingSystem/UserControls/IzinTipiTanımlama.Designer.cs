namespace EmployeeTrackingSystem.UserControls
{
    partial class IzinTipiTanımlama
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IzinEkleBtn = new System.Windows.Forms.Button();
            this.IzinAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IzinTipleriDGV = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iZINTIPIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinTipleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izinTipleriDataSet = new EmployeeTrackingSystem.DataSets.IzinTipleriDataSet();
            this.IzinSilBtn = new System.Windows.Forms.Button();
            this.izinTipleriTableAdapter = new EmployeeTrackingSystem.DataSets.IzinTipleriDataSetTableAdapters.IzinTipleriTableAdapter();
            this.IzniDznBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YeniİzinAdı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IzinTipleriDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinTipleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinTipleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzinEkleBtn
            // 
            this.IzinEkleBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinEkleBtn.Location = new System.Drawing.Point(680, 462);
            this.IzinEkleBtn.Name = "IzinEkleBtn";
            this.IzinEkleBtn.Size = new System.Drawing.Size(125, 48);
            this.IzinEkleBtn.TabIndex = 1;
            this.IzinEkleBtn.Text = "İZİN EKLE";
            this.IzinEkleBtn.UseVisualStyleBackColor = true;
            this.IzinEkleBtn.Click += new System.EventHandler(this.IzinEkleBtn_Click);
            // 
            // IzinAdı
            // 
            this.IzinAdı.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinAdı.Location = new System.Drawing.Point(841, 395);
            this.IzinAdı.Name = "IzinAdı";
            this.IzinAdı.Size = new System.Drawing.Size(196, 25);
            this.IzinAdı.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "İZİN TİPİ:";
            // 
            // IzinTipleriDGV
            // 
            this.IzinTipleriDGV.AllowUserToAddRows = false;
            this.IzinTipleriDGV.AllowUserToDeleteRows = false;
            this.IzinTipleriDGV.AutoGenerateColumns = false;
            this.IzinTipleriDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IzinTipleriDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IzinTipleriDGV.ColumnHeadersHeight = 25;
            this.IzinTipleriDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iZINTIPIDataGridViewTextBoxColumn});
            this.IzinTipleriDGV.DataSource = this.izinTipleriBindingSource;
            this.IzinTipleriDGV.Location = new System.Drawing.Point(3, 3);
            this.IzinTipleriDGV.Name = "IzinTipleriDGV";
            this.IzinTipleriDGV.ReadOnly = true;
            this.IzinTipleriDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IzinTipleriDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinTipleriDGV.Size = new System.Drawing.Size(374, 966);
            this.IzinTipleriDGV.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iZINTIPIDataGridViewTextBoxColumn
            // 
            this.iZINTIPIDataGridViewTextBoxColumn.DataPropertyName = "IZIN_TIPI";
            this.iZINTIPIDataGridViewTextBoxColumn.HeaderText = "IZIN_TIPI";
            this.iZINTIPIDataGridViewTextBoxColumn.Name = "iZINTIPIDataGridViewTextBoxColumn";
            this.iZINTIPIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izinTipleriBindingSource
            // 
            this.izinTipleriBindingSource.DataMember = "IzinTipleri";
            this.izinTipleriBindingSource.DataSource = this.izinTipleriDataSet;
            // 
            // izinTipleriDataSet
            // 
            this.izinTipleriDataSet.DataSetName = "IzinTipleriDataSet";
            this.izinTipleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IzinSilBtn
            // 
            this.IzinSilBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzinSilBtn.Location = new System.Drawing.Point(848, 462);
            this.IzinSilBtn.Name = "IzinSilBtn";
            this.IzinSilBtn.Size = new System.Drawing.Size(189, 48);
            this.IzinSilBtn.TabIndex = 4;
            this.IzinSilBtn.Text = "SEÇİLİ İZİNİ SİL";
            this.IzinSilBtn.UseVisualStyleBackColor = true;
            this.IzinSilBtn.Click += new System.EventHandler(this.IzinSilBtn_Click);
            // 
            // izinTipleriTableAdapter
            // 
            this.izinTipleriTableAdapter.ClearBeforeFill = true;
            // 
            // IzniDznBtn
            // 
            this.IzniDznBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzniDznBtn.Location = new System.Drawing.Point(1250, 462);
            this.IzniDznBtn.Name = "IzniDznBtn";
            this.IzniDznBtn.Size = new System.Drawing.Size(210, 48);
            this.IzniDznBtn.TabIndex = 7;
            this.IzniDznBtn.Text = "SEÇİLİ İZNİ DÜZENLE";
            this.IzniDznBtn.UseVisualStyleBackColor = true;
            this.IzniDznBtn.Click += new System.EventHandler(this.IzniDznBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1165, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "YENİ İZİN ADI:";
            // 
            // YeniİzinAdı
            // 
            this.YeniİzinAdı.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniİzinAdı.Location = new System.Drawing.Point(1330, 395);
            this.YeniİzinAdı.Name = "YeniİzinAdı";
            this.YeniİzinAdı.Size = new System.Drawing.Size(196, 25);
            this.YeniİzinAdı.TabIndex = 5;
            // 
            // IzinTipiTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.IzniDznBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YeniİzinAdı);
            this.Controls.Add(this.IzinSilBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IzinAdı);
            this.Controls.Add(this.IzinEkleBtn);
            this.Controls.Add(this.IzinTipleriDGV);
            this.Name = "IzinTipiTanımlama";
            this.Size = new System.Drawing.Size(1800, 972);
            ((System.ComponentModel.ISupportInitialize)(this.IzinTipleriDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinTipleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinTipleriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IzinEkleBtn;
        private System.Windows.Forms.TextBox IzinAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView IzinTipleriDGV;
        private System.Windows.Forms.Button IzinSilBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iZINTIPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource izinTipleriBindingSource;
        private DataSets.IzinTipleriDataSet izinTipleriDataSet;
        private DataSets.IzinTipleriDataSetTableAdapters.IzinTipleriTableAdapter izinTipleriTableAdapter;
        private System.Windows.Forms.Button IzniDznBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YeniİzinAdı;
    }
}
