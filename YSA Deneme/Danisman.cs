using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace YSA_Deneme
{
    
    public partial class Danisman : Form
    {
        OleDbConnection conn = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\SAGLIK.accdb");
        string[] sempt=new string[25];
        string[] sempt_adlar = new string[25];
        string[] sempt_dallan = new string[25];
        string deger = null;
        string[] sikayet_bolge = { "Solunum Yolu","Sindirim Sistemi - Karın","Genel","İdrar Yolu","Eklem"};
        string sorulan_sorular="";
        string secilen_Sorular="";
        string secilen_Dallanma="";
        string hastalik = "";
        string tc = "";
        string[] resim = {"","","","",""};
        string[] yorum = {"","","","","" };
        int q=0,k;
        int secim = 0;
        int rc = 0;
        string id = "";
        public Danisman()
        {
            InitializeComponent();
        }

        string cevir(string sayi)
        {
            if (sayi.Length == 1) sayi = "0" + sayi;
            return sayi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gecici = this.Text.Split('-');
            id = gecici[1];
            if (id[id.Length - 1] == '*')
            {
                groupBox1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                comboBox1.Enabled = false;
                sil.Enabled = false;
                id=id.Remove(id.Length-1,1);
            }
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;
                    comm.CommandText = "Select * FROM Hasta_Gecmis where Id="+id;
                    conn.Open();
                    OleDbDataReader okuyucu = comm.ExecuteReader();
                    while (okuyucu.Read())
                    {                     
                         comboBox1.Text = okuyucu[2].ToString().Trim();
                         textBox2.Text = okuyucu[3].ToString().Trim();
                         txt_Ilaclar.Text= okuyucu[4].ToString().Trim();
                    }
                    okuyucu.Close();
                    comm.CommandText = "Select * FROM Tahliller where Kontrol_No=" + id;
                     okuyucu = comm.ExecuteReader();
                    while (okuyucu.Read())
                    {
                        yorum[rc] = okuyucu[2].ToString().Trim();
                        resim[rc] = okuyucu[3].ToString().Trim();
                        rc++;
                        try
                        {
                            if (rc == 1)
                            { ekle0.Visible = true; ekle0.Image = null; ekle0.Load(resim[0]); }
                            if (rc == 2)
                            { ekle1.Visible = true; ekle1.Image = null; ekle1.Load(resim[1]); }
                            if (rc == 3)
                            { ekle2.Visible = true; ekle2.Image = null; ekle2.Load(resim[2]); }
                            if (rc == 4)
                            { ekle3.Visible = true; ekle3.Image = null; ekle3.Load(resim[3]); }
                            if (rc == 5)
                            { ekle4.Visible = true; ekle4.Image = null; ekle4.Load(resim[4]); }
                            pictureBox1.Load(resim[rc-1]);
                        }                                            
                        catch { }
                        textBox1.Text = yorum[rc-1];                      
                    }
                    okuyucu.Close();
                   
                    conn.Close();
                    this.Text = gecici[0];    
            //this.Text = this.Text.Remove(this.Text.Length - id.Length - 1, id.Length+1);
            for(int i=0;i<5;i++)
                Semptomlar_Liste.Items.Add(sikayet_bolge[i].Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Semptomlar_Liste.CheckedItems.Count>0)
            {
                button3.Enabled = true;
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            deger=Semptomlar_Liste.CheckedIndices[0].ToString();
            label4.Text = "Bolge = "+Semptomlar_Liste.Items[Semptomlar_Liste.CheckedIndices[0]].ToString();
            label4.Left = 430;
            int i=0;
            comm.CommandText = "Select * FROM Semptomlar where Dal_Derece=0 and Semptomlar.Bolge like '%" + deger + "%'  order by rnd(Id_Semptom)";
            conn.Open();
            Semptomlar_Liste.Items.Clear();
            OleDbDataReader okuyucu = comm.ExecuteReader();
            while (okuyucu.Read())
            {
                sempt_adlar[i]=okuyucu[1].ToString().Trim();
                sempt_dallan[i] = okuyucu[4].ToString().Trim();
                sempt[i] = okuyucu[0].ToString().Trim();
                i++;
            }
                okuyucu.Close();
            conn.Close();
            button2.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            Semptomlar_Liste.Visible = false;
            label4.Top = 40;
            textBox5.Visible = true;
            k = 0;
            secim = i;
            textBox5.Text = sempt_adlar[k];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty( sempt_adlar[k]))
            {
                sorulan_sorular +="'"+ sempt[k].ToString().Trim() + "',";
                k++;
                textBox5.Text = sempt_adlar[k];
            }
            else
            {
                MessageBox.Show("Seçenek Bitti");
                button3_Click_1(sender, e);
            }
        }

         string kesisen_sorular(string liste0, string liste1)
        {
            string son = "";
            string[] liste2 = liste0.Split(',');
            string[] liste3 = liste1.Split(',');
            for (int i = 0; i < liste2.Length;i++ )
                {
                    for (int j = 0; j < liste3.Length; j++)
                        if (liste2[i].Equals(liste3[j]))
                        { son += liste2[i] + ","; break; }
                }
            if (liste2.Length == 1)
                son = "Bitti ";
            if (son.Length > 0)
                son = son.Remove(son.Length - 1, 1);
                return son;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (k < secim )
            {
                string yeni_dallanma="";
                secilen_Sorular += "'"+sempt[k].ToString().Trim() + "',";
                sorulan_sorular += "'"+sempt[k].ToString().Trim() + "',";
                textBox2.Text += textBox5.Text.Trim() + "*\r\n";

                if (secilen_Dallanma.Length > 0)
                    { 
                    yeni_dallanma = kesisen_sorular(secilen_Dallanma, sempt_dallan[k]);
                    secilen_Dallanma = yeni_dallanma;
                    }
                else
                secilen_Dallanma = sempt_dallan[k];

                string[] sil = sorulan_sorular.Split(',');
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                int i = 0;
                comm.CommandText = "Select * FROM Semptomlar  where  (Semptomlar.Bolge like '%" + deger + "%') and (";

                if (yeni_dallanma.Equals("Bitti"))
                {
                    MessageBox.Show("Seçenek Bitti");
                    button3_Click_1(sender, e);
                    k = secim; 
                    goto Bitir;
                }
                if(yeni_dallanma.Length>0)
                    comm.CommandText += "Id_Semptom IN (" + yeni_dallanma + ")) and ( Id_Semptom  NOT IN (" + sorulan_sorular.Remove(sorulan_sorular.Length-1,1) + "))"; 
                else
                    comm.CommandText += "Id_Semptom IN (" + sempt_dallan[k] + ")) and ( Id_Semptom  NOT IN (" + sorulan_sorular.Remove(sorulan_sorular.Length-1 , 1) + "))";  
            
                comm.CommandText +=  " order by rnd(Id_Semptom)";
                conn.Open();
                OleDbDataReader okuyucu = comm.ExecuteReader();
                i = 0;
                sempt_adlar = new string[20];
                sempt_dallan = new string[20];

                while (okuyucu.Read())
                {
                    sempt_adlar[i] = okuyucu[1].ToString().Trim();
                    sempt_dallan[i] = okuyucu[4].ToString().Trim();
                    sempt[i] = okuyucu[0].ToString().Trim();
                    i++;
                }
                okuyucu.Close();
                conn.Close();
                if (i == 0)
                {
                    MessageBox.Show("Seçenek Bitti");
                    button3_Click_1(sender, e);
                    k = secim;
                    goto Bitir;
                }
                k = 0;
                secim = i;
                textBox5.Text = sempt_adlar[k];
            }
            else
            {
            Git:
                MessageBox.Show("Seçenek Bitti");
                button3_Click_1(sender, e);
            }
        Bitir:
            {}  
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (secilen_Sorular.Length > 0)
            {
                k = secim;
                button5.Enabled = false;
                button6.Enabled = false;
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                txt_Ilaclar.Text = "";

                comm.CommandText = "Select * FROM Hastaliklar where Bolge='" + deger + "'";
                string[] yenile = secilen_Sorular.Split(',');
                for (int i = 0; i <yenile.Length-1; i++)
                    comm.CommandText += " and Semptomlar like '%" + yenile[i].ToString().Trim().Replace("'","") + "%'";
                conn.Open();
                OleDbDataReader okuyucu = comm.ExecuteReader();
                comboBox1.Items.Clear();
                while (okuyucu.Read())
                {
                    comboBox1.Items.Add(okuyucu[1].ToString().Trim());
                    comboBox1.Text = okuyucu[1].ToString().Trim();
                   // textBox3.Text = okuyucu["Semptomlar"].ToString().Trim();
                }
                okuyucu.Close();

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    comm.CommandText = "Select Ad FROM Semptomlar where Id_Semptom IN(" + textBox3.Text + ") order by Ad";
                    okuyucu = comm.ExecuteReader();
                    textBox3.Text = "";
                    while (okuyucu.Read())
                    {
                        textBox3.Text += okuyucu["Ad"].ToString().Trim() + "\r\n";
                    }
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form yeni = new İlaçlar();
            yeni.ShowDialog();
        }

        private void Danisman_TextChanged(object sender, EventArgs e)
        {
            char a= this.Text[0];

            if (a == '0' || a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9')
             tc = this.Text;  
            else
            { txt_Ilaclar.Text += this.Text+"*\r\n"; this.Text = tc; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =MessageBox.Show("Kaydetmek istediğinizden emin misiniz?","KAYIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Update Hasta_Gecmis set tc=@tc,hastalik=@hastalik,belirtiler=@belirtiler,recete=@recete,tarih=@tarih where Id=" + id;
                comm.Parameters.Add("tc", tc);
                comm.Parameters.Add("hastalik", hastalik);
                comm.Parameters.Add("belirtiler", textBox2.Text.Trim());
                comm.Parameters.Add("recete", txt_Ilaclar.Text.Trim());
                comm.Parameters.Add("tarih", DateTime.Now.ToString());
                conn.Open();
                comm.ExecuteNonQuery();

                comm.Parameters.Clear();
                if (rc > 0)
                {
                    comm.CommandText = "Delete from Tahliller where Kontrol_No=" + id;
                    comm.ExecuteNonQuery();
                    for (int i = 0; i < rc; i++)
                    {
                        comm.CommandText = "Insert Into Tahliller (kontrol_no,yorum,adres) values(@no,@yorum,@adres)";
                        comm.Parameters.Clear();
                        comm.Parameters.Add("no", id);
                        comm.Parameters.Add("yorum", yorum[i]);
                        comm.Parameters.Add("adres", resim[i]);
                        comm.ExecuteNonQuery();                   
                    }
                }
                MessageBox.Show("Kaydedilmiştir");
                conn.Close();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (ekle4.Visible == true)
            { ekle4.Visible = false; resim[4] = ""; yorum[4] = ""; ekle4.Load(Application.StartupPath + @"\ekle.png"); rc--; pictureBox1.Image = ekle3.Image; goto Gec; }
            if (ekle3.Visible == true)
            { ekle3.Visible = false; resim[3] = ""; yorum[3] = ""; ekle3.Load(Application.StartupPath + @"\ekle.png"); rc--; pictureBox1.Image = ekle2.Image; goto Gec; }
            if (ekle2.Visible == true)
            { ekle2.Visible = false; resim[1] = ""; yorum[2] = ""; ekle2.Load(Application.StartupPath + @"\ekle.png"); rc--; pictureBox1.Image = ekle1.Image; goto Gec; }
            if (ekle1.Visible == true)
            { ekle1.Visible = false; resim[1] = ""; yorum[1] = ""; ekle1.Load(Application.StartupPath + @"\ekle.png"); rc--; pictureBox1.Image = ekle0.Image; goto Gec; }
            if (ekle0.Visible == true)
            { resim[0] = ""; yorum[0] = ""; ekle0.Load(Application.StartupPath + "\\ekle.png"); rc--; pictureBox1.Image = null; goto Gec; }
            textBox1.Text = "";
            Gec:{}
        }

        private void ekle0_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ekle0.Image;
            textBox1.Text=yorum[0];
            q = 0;
        }

        private void ekle1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ekle1.Image;
            textBox1.Text = yorum[1];
            q = 1;
        }

        private void ekle2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ekle2.Image;
            textBox1.Text = yorum[2];
            q = 2;
        }

        private void ekle3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ekle3.Image;
            textBox1.Text = yorum[3];
            q = 3;
        }

        private void ekle4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ekle4.Image;
            textBox1.Text = yorum[4];
            q = 4;
           
        }

        private void ekle0_DoubleClick(object sender, EventArgs e)
        {
            if(groupBox1.Enabled==true)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 try
            {
                pictureBox1.Load(openFileDialog1.FileName);
                ekle0.Load(openFileDialog1.FileName);
                ekle1.Visible = true;              
                q = 0;
                resim[q] = openFileDialog1.FileName;
                yorum[q] = textBox1.Text.Trim();
                if(rc==0)rc++;
            }
                 catch { }
            } 
        }

        private void ekle1_DoubleClick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    ekle1.Load(openFileDialog1.FileName);
                    ekle2.Visible = true;
                    q = 1;
                    resim[q] = openFileDialog1.FileName;
                    yorum[q] = textBox1.Text.Trim();
                    if (rc == 1) rc++;
                }
                catch { }
            }
            
        }

        private void ekle2_DoubleClick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    ekle2.Load(openFileDialog1.FileName);
                    ekle3.Visible = true;
                    q = 2;
                    resim[q] = openFileDialog1.FileName;
                    yorum[q] = textBox1.Text.Trim();
                    if (rc == 2) rc++;
                }
                catch { }
            }
            
        }

        private void ekle3_DoubleClick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    ekle3.Load(openFileDialog1.FileName);
                    ekle4.Visible = true;
                    q = 3;
                    resim[q] = openFileDialog1.FileName;
                    yorum[q] = textBox1.Text.Trim();
                    if (rc == 3) rc++;
                }
                catch { }
            }
            
        }

        private void ekle4_DoubleClick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    ekle4.Load(openFileDialog1.FileName);
                    q = 4;
                    resim[q] = openFileDialog1.FileName;
                    yorum[q] = textBox1.Text.Trim();
                    if (rc == 4) rc++;
                }
                catch { }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            button8.Enabled = false;
            hastalik = comboBox1.Text.Trim();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yorum[q] = textBox1.Text.Trim();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form yeni = new Resim();
            yeni.Text = resim[q];
            yeni.ShowDialog();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                    string gecici="";
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;          
                    conn.Open();           
                    if (!string.IsNullOrEmpty(comboBox1.Text.Trim()))
                    {
                        comm.CommandText = "Select Semptomlar FROM Hastaliklar where Ad like '%" + comboBox1.Text.Trim() + "%'";
                        OleDbDataReader okuyucu = comm.ExecuteReader();
                        while (okuyucu.Read())
                        {
                            gecici = okuyucu["Semptomlar"].ToString().Trim() + "\r\n";
                        }
                        okuyucu.Close();

                        comm.CommandText = "Select Ad FROM Semptomlar where Id_Semptom in (" + gecici + ") order by Ad";
                        okuyucu = comm.ExecuteReader();
                        textBox3.Text = "";
                        while (okuyucu.Read())
                        {
                            textBox3.Text += okuyucu["Ad"].ToString().Trim() + "\r\n";
                        }
                        okuyucu.Close();
                    }
                    conn.Close();
                }
        }

    }
}
