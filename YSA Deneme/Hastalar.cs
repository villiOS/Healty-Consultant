using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YSA_Deneme
{

    public partial class Hastalar : Form
    {
        OleDbConnection conn = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\SAGLIK.accdb");
        string tc = null;
        public Hastalar()
        {
            InitializeComponent();
        }
        void listele(string ara)
        {
            grd_Hastalar.Rows.Clear();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select * FROM Hasta_Kimlik where TC like '%" + ara + "%' or ad like '%" + ara + "%' or soyad like '%" + ara + "%'  ";
            conn.Open();
            OleDbDataReader okuyucu = comm.ExecuteReader();
            while (okuyucu.Read())
            {
                grd_Hastalar.Rows.Add(okuyucu[0].ToString().Trim(), okuyucu[1].ToString().Trim(), okuyucu[2].ToString().Trim(), okuyucu[3].ToString().Trim(), okuyucu[4].ToString().Trim(), okuyucu[5].ToString().Trim(), okuyucu[6].ToString().Trim(), okuyucu[7].ToString().Trim(), okuyucu[8].ToString().Trim());
            }
            okuyucu.Close();
            conn.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Tc.Text = ""; txt_Ad.Text = "";txt_Soyad.Text = "";txt_Kan.Text = ""; txt_Boy.Text = "";
                txt_Kilo.Text = ""; txt_Adres.Text = "";txt_Telefon.Text = ""; tc = "";
                if (grd_Hastalar.RowCount > 1)
                {
                    txt_Tc.Text = grd_Hastalar[0, e.RowIndex].Value.ToString();
                    txt_Ad.Text = grd_Hastalar[1, e.RowIndex].Value.ToString();
                    txt_Soyad.Text = grd_Hastalar[2, e.RowIndex].Value.ToString();
                    txt_Kan.Text = grd_Hastalar[3, e.RowIndex].Value.ToString();
                    txt_Boy.Text = grd_Hastalar[4, e.RowIndex].Value.ToString();
                    txt_Kilo.Text = grd_Hastalar[5, e.RowIndex].Value.ToString();
                    txt_Adres.Text = grd_Hastalar[6, e.RowIndex].Value.ToString();
                    txt_Telefon.Text = grd_Hastalar[7, e.RowIndex].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(grd_Hastalar[8, e.RowIndex].Value.ToString());
                    tc = txt_Tc.Text;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele(txt_Ara.Text.Trim());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void temizle()
        { 
            tc = "";
            txt_Tc.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            txt_Kan.Text = "";
            txt_Boy.Text = "";
            txt_Kilo.Text = "";
            txt_Adres.Text = "";
            txt_Telefon.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Tc.Text.Length == 11)
            {
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                if (tc.Length > 0)
                    comm.CommandText = "Update Hasta_Kimlik set tc=@tc,ad=@ad,soyad=@soyad,kan=@kan,boy=@boy,kilo=@kilo,adres=@adres,telefon=@telefon,d_tarihi=@d_tarihi where TC='" + tc + "'";
                else
                {
                    comm.CommandText = "Insert Into Hasta_Kimlik (tc,ad,soyad,kan,boy,kilo,adres,telefon,d_tarihi) values(@tc,@ad,@soyad,@kan,@boy,@kilo,@adres,@telefon,@d_tarihi)";
                    tc = txt_Tc.Text.Trim();
                }
                comm.Parameters.Add("tc", tc);
                comm.Parameters.Add("ad", txt_Ad.Text.Trim());
                comm.Parameters.Add("soyad", txt_Soyad.Text.Trim());
                comm.Parameters.Add("kan", txt_Kan.Text.Trim());
                comm.Parameters.Add("boy", txt_Boy.Text.Trim());
                comm.Parameters.Add("kilo", txt_Kilo.Text.Trim());
                comm.Parameters.Add("adres", txt_Adres.Text.Trim());
                comm.Parameters.Add("telefon", txt_Telefon.Text.Trim());
                comm.Parameters.Add("d_tarihi", dateTimePicker1.Value.ToShortDateString());
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(txt_Ad.Text.Trim()+" "+txt_Soyad.Text.Trim()+" adlı hasta kaydedildi.");
                temizle();
                listele(tc);           
            }
            else
                MessageBox.Show("Kimlik Numarasında Sorun Var");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc.Length > 0)
            {
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Delete from Hasta_Kimlik where TC='" + tc + "'";
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                temizle();
                listele(tc);
                MessageBox.Show(txt_Ad.Text.Trim() + " " + txt_Soyad.Text.Trim() + " adlı hasta silindi.");
            }
        }

        private void txt_Ara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
