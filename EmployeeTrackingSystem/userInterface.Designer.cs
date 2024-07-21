namespace EmployeeTrackingSystem
{
    partial class userInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userInterface));
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.yonetici_atama_btn = new System.Windows.Forms.Button();
            this.personel_tanımlama_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(1667, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 580);
            this.panel1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::EmployeeTrackingSystem.Properties.Resources.approval;
            this.button6.Location = new System.Drawing.Point(1221, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 150);
            this.button6.TabIndex = 7;
            this.button6.Text = "Onay Talepleri";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::EmployeeTrackingSystem.Properties.Resources.request;
            this.button5.Location = new System.Drawing.Point(846, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 150);
            this.button5.TabIndex = 6;
            this.button5.Text = "İzin Talebi Oluştur";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::EmployeeTrackingSystem.Properties.Resources.permission;
            this.button4.Location = new System.Drawing.Point(471, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 150);
            this.button4.TabIndex = 5;
            this.button4.Text = "İzin Tipi Tanımlama";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::EmployeeTrackingSystem.Properties.Resources.department;
            this.button3.Location = new System.Drawing.Point(280, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 150);
            this.button3.TabIndex = 4;
            this.button3.Text = "Departman Tanımlama";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // yonetici_atama_btn
            // 
            this.yonetici_atama_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yonetici_atama_btn.Image = global::EmployeeTrackingSystem.Properties.Resources.manager_approval;
            this.yonetici_atama_btn.Location = new System.Drawing.Point(471, 83);
            this.yonetici_atama_btn.Name = "yonetici_atama_btn";
            this.yonetici_atama_btn.Size = new System.Drawing.Size(175, 150);
            this.yonetici_atama_btn.TabIndex = 3;
            this.yonetici_atama_btn.Text = "Yönetici Atama";
            this.yonetici_atama_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yonetici_atama_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yonetici_atama_btn.UseVisualStyleBackColor = true;
            // 
            // personel_tanımlama_btn
            // 
            this.personel_tanımlama_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personel_tanımlama_btn.Image = ((System.Drawing.Image)(resources.GetObject("personel_tanımlama_btn.Image")));
            this.personel_tanımlama_btn.Location = new System.Drawing.Point(280, 83);
            this.personel_tanımlama_btn.Name = "personel_tanımlama_btn";
            this.personel_tanımlama_btn.Size = new System.Drawing.Size(175, 150);
            this.personel_tanımlama_btn.TabIndex = 2;
            this.personel_tanımlama_btn.Text = "Personel Tanımlama";
            this.personel_tanımlama_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personel_tanımlama_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personel_tanımlama_btn.UseVisualStyleBackColor = true;
            // 
            // userInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.yonetici_atama_btn);
            this.Controls.Add(this.personel_tanımlama_btn);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button yonetici_atama_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button personel_tanımlama_btn;
    }
}