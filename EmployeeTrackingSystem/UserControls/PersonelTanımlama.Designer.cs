namespace EmployeeTrackingSystem.UserControls
{
    partial class PersonelTanımlama
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
            this.PersonelEkleBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SenkronInput = new System.Windows.Forms.ComboBox();
            this.UnvanInput = new System.Windows.Forms.ComboBox();
            this.CalismaKonumuInput = new System.Windows.Forms.ComboBox();
            this.CalismaSekliInput = new System.Windows.Forms.ComboBox();
            this.cikisTar = new System.Windows.Forms.DateTimePicker();
            this.girisTar = new System.Windows.Forms.DateTimePicker();
            this.SgkInput = new System.Windows.Forms.TextBox();
            this.SicilEkInput = new System.Windows.Forms.TextBox();
            this.DurumInput = new System.Windows.Forms.TextBox();
            this.GecisInput = new System.Windows.Forms.TextBox();
            this.YakaInput = new System.Windows.Forms.TextBox();
            this.SicilInput = new System.Windows.Forms.TextBox();
            this.SoyadInput = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AdInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.companyDataSet = new EmployeeTrackingSystem.CompanyDataSet();
            this.isletmelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmelerTableAdapter = new EmployeeTrackingSystem.CompanyDataSetTableAdapters.IsletmelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelEkleBtn
            // 
            this.PersonelEkleBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonelEkleBtn.Location = new System.Drawing.Point(756, 800);
            this.PersonelEkleBtn.Name = "PersonelEkleBtn";
            this.PersonelEkleBtn.Size = new System.Drawing.Size(137, 44);
            this.PersonelEkleBtn.TabIndex = 6;
            this.PersonelEkleBtn.Text = "Personel Ekle";
            this.PersonelEkleBtn.UseVisualStyleBackColor = true;
            this.PersonelEkleBtn.Click += new System.EventHandler(this.PersonelEkleBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1594, 325);
            this.dataGridView1.TabIndex = 60;
            // 
            // SenkronInput
            // 
            this.SenkronInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenkronInput.FormattingEnabled = true;
            this.SenkronInput.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.SenkronInput.Location = new System.Drawing.Point(799, 750);
            this.SenkronInput.Name = "SenkronInput";
            this.SenkronInput.Size = new System.Drawing.Size(200, 25);
            this.SenkronInput.TabIndex = 109;
            // 
            // UnvanInput
            // 
            this.UnvanInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnvanInput.FormattingEnabled = true;
            this.UnvanInput.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Şef",
            "Uzman",
            "Uzman Yardımcısı",
            "Görevli"});
            this.UnvanInput.Location = new System.Drawing.Point(278, 750);
            this.UnvanInput.Name = "UnvanInput";
            this.UnvanInput.Size = new System.Drawing.Size(200, 25);
            this.UnvanInput.TabIndex = 108;
            // 
            // CalismaKonumuInput
            // 
            this.CalismaKonumuInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalismaKonumuInput.FormattingEnabled = true;
            this.CalismaKonumuInput.Items.AddRange(new object[] {
            "Ofis",
            "Uzaktan",
            "Hibrit"});
            this.CalismaKonumuInput.Location = new System.Drawing.Point(1275, 519);
            this.CalismaKonumuInput.Name = "CalismaKonumuInput";
            this.CalismaKonumuInput.Size = new System.Drawing.Size(200, 25);
            this.CalismaKonumuInput.TabIndex = 107;
            // 
            // CalismaSekliInput
            // 
            this.CalismaSekliInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalismaSekliInput.FormattingEnabled = true;
            this.CalismaSekliInput.Items.AddRange(new object[] {
            "Tam Zamanlı",
            "Yarı Zamanlı"});
            this.CalismaSekliInput.Location = new System.Drawing.Point(1275, 461);
            this.CalismaSekliInput.Name = "CalismaSekliInput";
            this.CalismaSekliInput.Size = new System.Drawing.Size(200, 25);
            this.CalismaSekliInput.TabIndex = 106;
            // 
            // cikisTar
            // 
            this.cikisTar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cikisTar.Location = new System.Drawing.Point(278, 692);
            this.cikisTar.Name = "cikisTar";
            this.cikisTar.Size = new System.Drawing.Size(200, 25);
            this.cikisTar.TabIndex = 105;
            // 
            // girisTar
            // 
            this.girisTar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.girisTar.Location = new System.Drawing.Point(278, 633);
            this.girisTar.Name = "girisTar";
            this.girisTar.Size = new System.Drawing.Size(200, 25);
            this.girisTar.TabIndex = 104;
            // 
            // SgkInput
            // 
            this.SgkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SgkInput.Location = new System.Drawing.Point(1275, 693);
            this.SgkInput.Name = "SgkInput";
            this.SgkInput.Size = new System.Drawing.Size(200, 24);
            this.SgkInput.TabIndex = 102;
            // 
            // SicilEkInput
            // 
            this.SicilEkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SicilEkInput.Location = new System.Drawing.Point(1275, 634);
            this.SicilEkInput.Name = "SicilEkInput";
            this.SicilEkInput.Size = new System.Drawing.Size(200, 24);
            this.SicilEkInput.TabIndex = 101;
            // 
            // DurumInput
            // 
            this.DurumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurumInput.Location = new System.Drawing.Point(1275, 575);
            this.DurumInput.Name = "DurumInput";
            this.DurumInput.Size = new System.Drawing.Size(200, 24);
            this.DurumInput.TabIndex = 100;
            // 
            // GecisInput
            // 
            this.GecisInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GecisInput.Location = new System.Drawing.Point(799, 693);
            this.GecisInput.Name = "GecisInput";
            this.GecisInput.Size = new System.Drawing.Size(200, 24);
            this.GecisInput.TabIndex = 97;
            // 
            // YakaInput
            // 
            this.YakaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YakaInput.Location = new System.Drawing.Point(799, 346);
            this.YakaInput.Name = "YakaInput";
            this.YakaInput.Size = new System.Drawing.Size(200, 24);
            this.YakaInput.TabIndex = 91;
            // 
            // SicilInput
            // 
            this.SicilInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SicilInput.Location = new System.Drawing.Point(278, 462);
            this.SicilInput.Name = "SicilInput";
            this.SicilInput.Size = new System.Drawing.Size(200, 24);
            this.SicilInput.TabIndex = 90;
            // 
            // SoyadInput
            // 
            this.SoyadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyadInput.Location = new System.Drawing.Point(278, 404);
            this.SoyadInput.Name = "SoyadInput";
            this.SoyadInput.Size = new System.Drawing.Size(200, 24);
            this.SoyadInput.TabIndex = 89;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1084, 756);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 19);
            this.label24.TabIndex = 88;
            this.label24.Text = "MASRAF KODU:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1084, 698);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 19);
            this.label23.TabIndex = 87;
            this.label23.Text = "SGK NO:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1084, 639);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 19);
            this.label22.TabIndex = 86;
            this.label22.Text = "SİCİL EK:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1084, 581);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 19);
            this.label21.TabIndex = 85;
            this.label21.Text = "DURUM:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1084, 525);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 19);
            this.label20.TabIndex = 84;
            this.label20.Text = "ÇALIŞMA KONUMU:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1084, 467);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 19);
            this.label19.TabIndex = 83;
            this.label19.Text = "ÇALIŞMA ŞEKLİ:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1084, 409);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 19);
            this.label18.TabIndex = 82;
            this.label18.Text = "TAŞERON KODU:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1084, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 19);
            this.label17.TabIndex = 81;
            this.label17.Text = "SENDİKA KODU:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(563, 756);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 19);
            this.label16.TabIndex = 80;
            this.label16.Text = "SENKRON:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(563, 698);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 19);
            this.label15.TabIndex = 79;
            this.label15.Text = "GEÇİŞ KODU:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(563, 639);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 19);
            this.label14.TabIndex = 78;
            this.label14.Text = "LOKASYON KODU:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(563, 580);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "POZİSYON KODU:";
            // 
            // AdInput
            // 
            this.AdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdInput.Location = new System.Drawing.Point(278, 346);
            this.AdInput.Name = "AdInput";
            this.AdInput.Size = new System.Drawing.Size(200, 24);
            this.AdInput.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(563, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 19);
            this.label12.TabIndex = 75;
            this.label12.Text = "DEPARTMAN ALT KODU:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(563, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 19);
            this.label11.TabIndex = 74;
            this.label11.Text = "DEPARTMAN KODU:";
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kadın.Location = new System.Drawing.Point(380, 524);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(65, 20);
            this.kadın.TabIndex = 73;
            this.kadın.TabStop = true;
            this.kadın.Text = "KADIN";
            this.kadın.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erkek.Location = new System.Drawing.Point(278, 524);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(68, 20);
            this.erkek.TabIndex = 72;
            this.erkek.TabStop = true;
            this.erkek.Text = "ERKEK";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "CİNSİYET:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(563, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "YAKA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 69;
            this.label8.Text = "İŞLETME KODU:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 756);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "UNVAN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "ÇIKIŞ TARİHİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "GİRİŞ TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "DOĞUM TARİHİ:";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(278, 574);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 25);
            this.dob.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "SİCİL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "AD:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.isletmelerBindingSource;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(799, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 110;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(799, 461);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 25);
            this.comboBox2.TabIndex = 111;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(799, 519);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 25);
            this.comboBox3.TabIndex = 112;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(799, 574);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 25);
            this.comboBox4.TabIndex = 113;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(799, 633);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 25);
            this.comboBox5.TabIndex = 114;
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(1275, 345);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 25);
            this.comboBox6.TabIndex = 115;
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(1275, 403);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(200, 25);
            this.comboBox7.TabIndex = 116;
            // 
            // comboBox8
            // 
            this.comboBox8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(1275, 750);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(200, 25);
            this.comboBox8.TabIndex = 117;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isletmelerBindingSource
            // 
            this.isletmelerBindingSource.DataMember = "Isletmeler";
            this.isletmelerBindingSource.DataSource = this.companyDataSet;
            // 
            // isletmelerTableAdapter
            // 
            this.isletmelerTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SenkronInput);
            this.Controls.Add(this.UnvanInput);
            this.Controls.Add(this.CalismaKonumuInput);
            this.Controls.Add(this.CalismaSekliInput);
            this.Controls.Add(this.cikisTar);
            this.Controls.Add(this.girisTar);
            this.Controls.Add(this.SgkInput);
            this.Controls.Add(this.SicilEkInput);
            this.Controls.Add(this.DurumInput);
            this.Controls.Add(this.GecisInput);
            this.Controls.Add(this.YakaInput);
            this.Controls.Add(this.SicilInput);
            this.Controls.Add(this.SoyadInput);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AdInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PersonelEkleBtn);
            this.Name = "PersonelTanımlama";
            this.Size = new System.Drawing.Size(1600, 864);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PersonelEkleBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SenkronInput;
        private System.Windows.Forms.ComboBox UnvanInput;
        private System.Windows.Forms.ComboBox CalismaKonumuInput;
        private System.Windows.Forms.ComboBox CalismaSekliInput;
        private System.Windows.Forms.DateTimePicker cikisTar;
        private System.Windows.Forms.DateTimePicker girisTar;
        private System.Windows.Forms.TextBox SgkInput;
        private System.Windows.Forms.TextBox SicilEkInput;
        private System.Windows.Forms.TextBox DurumInput;
        private System.Windows.Forms.TextBox GecisInput;
        private System.Windows.Forms.TextBox YakaInput;
        private System.Windows.Forms.TextBox SicilInput;
        private System.Windows.Forms.TextBox SoyadInput;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AdInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton kadın;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource isletmelerBindingSource;
        private CompanyDataSet companyDataSet;
        private CompanyDataSetTableAdapters.IsletmelerTableAdapter isletmelerTableAdapter;
    }
}
