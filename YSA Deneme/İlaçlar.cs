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
    public partial class İlaçlar : Form
    {
        string ilac = null;
        OleDbConnection conn = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\SAGLIK.accdb");
        public İlaçlar()
        {
            InitializeComponent();
        }

        public void listele(string ara)
        {
            Ilaclar.Rows.Clear();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select * FROM Ilaclar where Ad like '%" + ara + "%' order by Ad";
            conn.Open();
            OleDbDataReader okuyucu = comm.ExecuteReader();
            while (okuyucu.Read())
            {
                Ilaclar.Rows.Add(okuyucu[0].ToString().Trim(), okuyucu[1].ToString().Trim(), okuyucu[2].ToString().Trim(), okuyucu[3].ToString().Trim());
            }
            okuyucu.Close();
            conn.Close();
        }

        private void Ilaclar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Application.OpenForms[1].Text = ilac;
            }
        }

        private void Ilaclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ilac = "";
                if (Ilaclar.RowCount > 1)
                    ilac = Ilaclar[1, e.RowIndex].Value.ToString().Trim();
            }
            catch { }
        }

        private void İlaçlar_Load(object sender, EventArgs e)
        {
            listele("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele(txt_Ara.Text.Trim());
        }

        private void txt_Ara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ilac.Length>0)
                button1_Click(sender, e);
        }


    }
}
