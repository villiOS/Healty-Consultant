using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;



namespace YSA_Deneme
{
    public partial class Main_Form : Form
    {
        OleDbConnection conn = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\SAGLIK.accdb");
        string id = "", hastalik="";
        public Main_Form()
        {
            InitializeComponent();
        }

        public void listele(string ara)
        {
            Hastalar.Rows.Clear();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select * FROM Hasta_Kimlik where TC like '%"+ara+"%' or ad like '%"+ara+"%' or soyad like '%"+ara+"%'  ";
            conn.Open();
            OleDbDataReader okuyucu = comm.ExecuteReader();
            while (okuyucu.Read())
            {
                Hastalar.Rows.Add(okuyucu[0].ToString().Trim(), okuyucu[1].ToString().Trim(), okuyucu[2].ToString().Trim(), okuyucu[3].ToString().Trim(), okuyucu[4].ToString().Trim(), okuyucu[5].ToString().Trim(), okuyucu[6].ToString().Trim(), okuyucu[7].ToString().Trim(), okuyucu[8].ToString().Trim());
            }
            okuyucu.Close();
            conn.Close();
        }
        void Gecmis_Listele(string deger)
        {
            Gecmis.Rows.Clear();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select * FROM Hasta_Gecmis where TC='" + deger + "' order by Tarih";
            conn.Open();
            OleDbDataReader okuyucu = comm.ExecuteReader();
            int i = 0;
            while (okuyucu.Read())
            {
                Gecmis.Rows.Add(okuyucu[0].ToString().Trim(), okuyucu[1].ToString().Trim(), okuyucu[2].ToString().Trim(), okuyucu[3].ToString().Trim(), okuyucu[4].ToString().Trim(), okuyucu[5].ToString().Trim());
                if(okuyucu[2].ToString().Trim().Length>0)
                    Gecmis.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                else
                    Gecmis.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                i++;
            }
            okuyucu.Close();
            conn.Close();
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            listele(txt_Ara.Text.Trim());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hastaKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new Hastalar();
            yeni.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Tc.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Yeni kontrole başlamak istediğinizden emin misiniz?", "YENI KONTROL", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;
                    comm.CommandText = "Insert Into Hasta_Gecmis (tc,tarih) values(@tc,@tarih)";
                    comm.Parameters.Add("tc", txt_Tc.Text.Trim());
                    comm.Parameters.Add("tarih", DateTime.Now.ToString());
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Gecmis_Listele(txt_Tc.Text.Trim());
                }
            }
        }

        
        private void Hastalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Tc.Text = "";
                txt_Ad.Text = "";
                txt_Soyad.Text = "";
                txt_Kan.Text = "";
                txt_Boy.Text = "";
                txt_Kilo.Text = "";
                txt_Adres.Text = "";
                txt_Telefon.Text = "";
                txt_Yas.Text = "";
                if (Hastalar.RowCount > 1)
                {
                    txt_Tc.Text = Hastalar[0, e.RowIndex].Value.ToString();
                    txt_Ad.Text = Hastalar[1, e.RowIndex].Value.ToString();
                    txt_Soyad.Text = Hastalar[2, e.RowIndex].Value.ToString();
                    txt_Kan.Text = Hastalar[3, e.RowIndex].Value.ToString();
                    txt_Boy.Text = Hastalar[4, e.RowIndex].Value.ToString();
                    txt_Kilo.Text = Hastalar[5, e.RowIndex].Value.ToString();
                    txt_Adres.Text = Hastalar[6, e.RowIndex].Value.ToString();
                    txt_Telefon.Text = Hastalar[7, e.RowIndex].Value.ToString();
                    TimeSpan tarih = DateTime.Now-DateTime.Parse(Hastalar[8, e.RowIndex].Value.ToString());
                    int fark = tarih.Days; 
                    txt_Yas.Text = (fark/365).ToString();
                    Gecmis.Rows.Clear();
                    conn.Close();
                    Gecmis_Listele(txt_Tc.Text.Trim());
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Length > 0)
            {
                Form yeni = new Danisman();
                yeni.Text = txt_Tc.Text+"-"+id;
                yeni.ShowDialog();
            }
        }

        private void Gecmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = "";
            hastalik = "";
            label12.Text = "";
            try
            {
                if (Gecmis.RowCount > 1)
                {
                    id = Gecmis[0, e.RowIndex].Value.ToString();
                    hastalik = Gecmis[2, e.RowIndex].Value.ToString();
                }
                if (hastalik.Length > 0)
                { label12.Text = "Teşhis = " + hastalik; id += "*"; }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if ((id.Length > 0) && (hastalik.Length == 0))
            {
                DialogResult dialogResult = MessageBox.Show("Henüz Teşhis Konulmamıştır. \r\n Silmek istediğinizden emin misiniz?", "SİLME", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;
                    comm.CommandText = "Delete from Hasta_Gecmis where Id=" + id;
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Gecmis_Listele(txt_Tc.Text.Trim());

                }
            }
        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
           Gecmis_Listele(txt_Tc.Text.Trim());
            
        }

        private void txt_Ara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender,e);
        }
    }
}
