namespace YSA_Deneme
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hastalar = new System.Windows.Forms.DataGridView();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Kilo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Boy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Gecmis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belirtiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.d_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKayitToolStripMenuItem
            // 
            this.hastaKayitToolStripMenuItem.Name = "hastaKayitToolStripMenuItem";
            this.hastaKayitToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hastaKayitToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayitToolStripMenuItem.Click += new System.EventHandler(this.hastaKayitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Hastalar
            // 
            this.Hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hastalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TC,
            this.Ad,
            this.Soyad,
            this.Kan,
            this.Boy,
            this.Kilo,
            this.Telefon,
            this.Adres,
            this.d_tarih});
            this.Hastalar.Location = new System.Drawing.Point(12, 108);
            this.Hastalar.Name = "Hastalar";
            this.Hastalar.Size = new System.Drawing.Size(596, 158);
            this.Hastalar.TabIndex = 1;
            this.Hastalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hastalar_CellDoubleClick);
            // 
            // TC
            // 
            this.TC.HeaderText = "TC";
            this.TC.Name = "TC";
            this.TC.Width = 75;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.Width = 110;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 110;
            // 
            // Kan
            // 
            this.Kan.HeaderText = "Kan Grubu";
            this.Kan.Name = "Kan";
            this.Kan.Width = 90;
            // 
            // Boy
            // 
            this.Boy.HeaderText = "Boy";
            this.Boy.Name = "Boy";
            this.Boy.Width = 60;
            // 
            // Kilo
            // 
            this.Kilo.HeaderText = "Kilo";
            this.Kilo.Name = "Kilo";
            this.Kilo.Width = 60;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = false;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Sağlık Danışmanı";
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(51, 40);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(100, 20);
            this.txt_Ara.TabIndex = 3;
            this.txt_Ara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Ara_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Enabled = false;
            this.txt_Tc.Location = new System.Drawing.Point(70, 273);
            this.txt_Tc.MaxLength = 11;
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(104, 20);
            this.txt_Tc.TabIndex = 7;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Enabled = false;
            this.txt_Ad.Location = new System.Drawing.Point(219, 273);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(159, 20);
            this.txt_Ad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(184, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Enabled = false;
            this.txt_Soyad.Location = new System.Drawing.Point(438, 273);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(172, 20);
            this.txt_Soyad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(395, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad";
            // 
            // txt_Kilo
            // 
            this.txt_Kilo.Enabled = false;
            this.txt_Kilo.Location = new System.Drawing.Point(338, 299);
            this.txt_Kilo.Name = "txt_Kilo";
            this.txt_Kilo.Size = new System.Drawing.Size(106, 20);
            this.txt_Kilo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(308, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kilo";
            // 
            // txt_Boy
            // 
            this.txt_Boy.Enabled = false;
            this.txt_Boy.Location = new System.Drawing.Point(219, 299);
            this.txt_Boy.Name = "txt_Boy";
            this.txt_Boy.Size = new System.Drawing.Size(68, 20);
            this.txt_Boy.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(184, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Boy";
            // 
            // txt_Kan
            // 
            this.txt_Kan.Enabled = false;
            this.txt_Kan.Location = new System.Drawing.Point(70, 299);
            this.txt_Kan.MaxLength = 11;
            this.txt_Kan.Name = "txt_Kan";
            this.txt_Kan.Size = new System.Drawing.Size(104, 20);
            this.txt_Kan.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kan Grubu";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Enabled = false;
            this.txt_Telefon.Location = new System.Drawing.Point(475, 325);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(133, 20);
            this.txt_Telefon.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(423, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefon";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Enabled = false;
            this.txt_Adres.Location = new System.Drawing.Point(70, 325);
            this.txt_Adres.MaxLength = 11;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(340, 20);
            this.txt_Adres.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Adres";
            // 
            // Gecmis
            // 
            this.Gecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gecmis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.Belirtiler,
            this.dataGridViewTextBoxColumn6,
            this.Tarih});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gecmis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gecmis.Location = new System.Drawing.Point(15, 392);
            this.Gecmis.Name = "Gecmis";
            this.Gecmis.Size = new System.Drawing.Size(596, 158);
            this.Gecmis.TabIndex = 24;
            this.Gecmis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gecmis_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hastalık";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // Belirtiler
            // 
            this.Belirtiler.HeaderText = "Belirtiler";
            this.Belirtiler.Name = "Belirtiler";
            this.Belirtiler.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Recete";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "HASTALIK GEÇMİŞİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "HASTALAR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "YENİ KONTROL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "İŞLEMİ GÖSTER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "SİL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(150, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 26);
            this.label12.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(475, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Yaş";
            // 
            // txt_Yas
            // 
            this.txt_Yas.Enabled = false;
            this.txt_Yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yas.Location = new System.Drawing.Point(523, 297);
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Size = new System.Drawing.Size(85, 24);
            this.txt_Yas.TabIndex = 34;
            // 
            // d_tarih
            // 
            this.d_tarih.HeaderText = "d_tarih";
            this.d_tarih.Name = "d_tarih";
            this.d_tarih.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 605);
            this.Controls.Add(this.txt_Yas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Gecmis);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Kilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Boy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Kan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Hastalar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Doktor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gecmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView Hastalar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Kilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Boy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Kan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Gecmis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belirtiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_tarih;
    }
}