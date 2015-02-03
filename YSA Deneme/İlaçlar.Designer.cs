namespace YSA_Deneme
{
    partial class İlaçlar
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
            this.Ilaclar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ilaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // Ilaclar
            // 
            this.Ilaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ilaclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Doz,
            this.Miktar});
            this.Ilaclar.Location = new System.Drawing.Point(12, 52);
            this.Ilaclar.Name = "Ilaclar";
            this.Ilaclar.Size = new System.Drawing.Size(366, 198);
            this.Ilaclar.TabIndex = 0;
            this.Ilaclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ilaclar_CellClick);
            this.Ilaclar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ilaclar_KeyDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.Width = 150;
            // 
            // Doz
            // 
            this.Doz.HeaderText = "Doz";
            this.Doz.Name = "Doz";
            this.Doz.Width = 70;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(54, 21);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(100, 20);
            this.txt_Ara.TabIndex = 6;
            this.txt_Ara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Ara_KeyDown);
            // 
            // İlaçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(390, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.Ilaclar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "İlaçlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İlaçlar";
            this.Load += new System.EventHandler(this.İlaçlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ilaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ilaclar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
    }
}