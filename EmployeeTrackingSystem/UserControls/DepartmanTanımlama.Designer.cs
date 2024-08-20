namespace EmployeeTrackingSystem.UserControls
{
    partial class DepartmanTanımlama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DepartmanlarDGV = new System.Windows.Forms.DataGridView();
            this.departmanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanlarDataSet = new EmployeeTrackingSystem.DataSets.DepartmanlarDataSet();
            this.DepartmanEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmanAdı = new System.Windows.Forms.TextBox();
            this.departmanlarTableAdapter = new EmployeeTrackingSystem.DataSets.DepartmanlarDataSetTableAdapters.DepartmanlarTableAdapter();
            this.YeniDepartmanAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmanDznBtn = new System.Windows.Forms.Button();
            this.DepartmanSilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanlarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmanlarDGV
            // 
            this.DepartmanlarDGV.AllowUserToAddRows = false;
            this.DepartmanlarDGV.AllowUserToDeleteRows = false;
            this.DepartmanlarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmanlarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DepartmanlarDGV.ColumnHeadersHeight = 25;
            this.DepartmanlarDGV.Location = new System.Drawing.Point(3, 3);
            this.DepartmanlarDGV.Name = "DepartmanlarDGV";
            this.DepartmanlarDGV.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanlarDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DepartmanlarDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DepartmanlarDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanlarDGV.RowTemplate.Height = 25;
            this.DepartmanlarDGV.Size = new System.Drawing.Size(531, 966);
            this.DepartmanlarDGV.TabIndex = 0;
            // 
            // departmanlarBindingSource
            // 
            this.departmanlarBindingSource.DataMember = "Departmanlar";
            this.departmanlarBindingSource.DataSource = this.departmanlarDataSet;
            // 
            // departmanlarDataSet
            // 
            this.departmanlarDataSet.DataSetName = "DepartmanlarDataSet";
            this.departmanlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DepartmanEkleBtn
            // 
            this.DepartmanEkleBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanEkleBtn.Location = new System.Drawing.Point(802, 492);
            this.DepartmanEkleBtn.Name = "DepartmanEkleBtn";
            this.DepartmanEkleBtn.Size = new System.Drawing.Size(149, 55);
            this.DepartmanEkleBtn.TabIndex = 1;
            this.DepartmanEkleBtn.Text = "Departman Ekle";
            this.DepartmanEkleBtn.UseVisualStyleBackColor = true;
            this.DepartmanEkleBtn.Click += new System.EventHandler(this.DepartmanEkleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEPARTMAN ADI:";
            // 
            // DepartmanAdı
            // 
            this.DepartmanAdı.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanAdı.Location = new System.Drawing.Point(988, 401);
            this.DepartmanAdı.Name = "DepartmanAdı";
            this.DepartmanAdı.Size = new System.Drawing.Size(180, 25);
            this.DepartmanAdı.TabIndex = 3;
            // 
            // departmanlarTableAdapter
            // 
            this.departmanlarTableAdapter.ClearBeforeFill = true;
            // 
            // YeniDepartmanAd
            // 
            this.YeniDepartmanAd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniDepartmanAd.Location = new System.Drawing.Point(1425, 401);
            this.YeniDepartmanAd.Name = "YeniDepartmanAd";
            this.YeniDepartmanAd.Size = new System.Drawing.Size(180, 25);
            this.YeniDepartmanAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1229, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "YENİ DEPARTMAN ADI:";
            // 
            // DepartmanDznBtn
            // 
            this.DepartmanDznBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanDznBtn.Location = new System.Drawing.Point(1302, 492);
            this.DepartmanDznBtn.Name = "DepartmanDznBtn";
            this.DepartmanDznBtn.Size = new System.Drawing.Size(235, 55);
            this.DepartmanDznBtn.TabIndex = 4;
            this.DepartmanDznBtn.Text = "Seçili Departmanı Düzenle";
            this.DepartmanDznBtn.UseVisualStyleBackColor = true;
            this.DepartmanDznBtn.Click += new System.EventHandler(this.DepartmanDznBtn_Click);
            // 
            // DepartmanSilBtn
            // 
            this.DepartmanSilBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmanSilBtn.Location = new System.Drawing.Point(979, 492);
            this.DepartmanSilBtn.Name = "DepartmanSilBtn";
            this.DepartmanSilBtn.Size = new System.Drawing.Size(189, 55);
            this.DepartmanSilBtn.TabIndex = 7;
            this.DepartmanSilBtn.Text = "Seçili Departmanı Sil";
            this.DepartmanSilBtn.UseVisualStyleBackColor = true;
            this.DepartmanSilBtn.Click += new System.EventHandler(this.DepartmanSilBtn_Click);
            // 
            // DepartmanTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.DepartmanSilBtn);
            this.Controls.Add(this.YeniDepartmanAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmanDznBtn);
            this.Controls.Add(this.DepartmanAdı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmanEkleBtn);
            this.Controls.Add(this.DepartmanlarDGV);
            this.Name = "DepartmanTanımlama";
            this.Size = new System.Drawing.Size(1800, 972);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanlarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmanlarDGV;
        private System.Windows.Forms.Button DepartmanEkleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepartmanAdı;
        private System.Windows.Forms.BindingSource departmanlarBindingSource;
        private DataSets.DepartmanlarDataSet departmanlarDataSet;
        private DataSets.DepartmanlarDataSetTableAdapters.DepartmanlarTableAdapter departmanlarTableAdapter;
        private System.Windows.Forms.TextBox YeniDepartmanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DepartmanDznBtn;
        private System.Windows.Forms.Button DepartmanSilBtn;
    }
}
