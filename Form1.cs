using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YarismaProjesi
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        string kullaniciAd;
        List<Soru> sorular = new List<Soru>();
        int soruIndex = 0;
        int dogruSayisi=0;

        public Form1()
        {
            //Örnek Proje https://github.com/GAZELLE0/Yarisma-Programi/blob/main/Program
            //SQL BAĞLANTI https://github.com/GAZELLE0/Yarisma-Programi/blob/main/SQL%20BAGLANT%C4%B0
            InitializeComponent();
            sqlConnection = new SqlConnection("Server=GAZELLE\\SQLEXPRESS; Database =BilgiYarismasi; User Id =ceylanemre; Password=1234567;");
            sqlConnection.Open();
            siralama();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Kullanicilar WHERE KullaniciAdi = '{textBoxAdi.Text}' AND Sifre = '{textBoxSifre.Text}'", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                sqlDataReader.Close();

                tabControl1.SelectTab(1);
                soruGetir();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                sqlDataReader.Close();
            }
            sqlConnection.Close();
        }

        void sorusecme()
        {
            Random random = new Random();
            textBoxSoru.Text = sorular[soruIndex].soru; 
            List<string>cevap = new List<string>();

            cevap.Add(sorular[soruIndex].dogrucevap);
            cevap.Add(sorular[soruIndex].yanliscevap1);
            cevap.Add(sorular[soruIndex].yanliscevap2);
            cevap.Add(sorular[soruIndex].yanliscevap3);

        //ŞIK KARIŞTIRMA https://stackoverflow.com/questions/273313/randomize-a-listt

            cevap = cevap.OrderBy(a => random.Next()).ToList();
            button1A.Text = cevap[0];
            button2B.Text = cevap[1];
            button3C.Text = cevap[2];
            button4D.Text = cevap[3];

            timer.Start();
        }

        void soruGetir()
        {
            SqlCommand sqlCommand = new SqlCommand($"SELECT TOP 10 * FROM Sorular ORDER BY NEWID()", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while(sqlDataReader.Read())
            {
                Soru soru = new Soru();
                soru.soru = sqlDataReader["Soru"].ToString();
                soru.dogrucevap = sqlDataReader["DogruCevap"].ToString();
                soru.yanliscevap1 = sqlDataReader["YanlisCevap1"].ToString();
                soru.yanliscevap2 = sqlDataReader["YanlisCevap2"].ToString();
                soru.yanliscevap3 = sqlDataReader["YanlisCevap3"].ToString();
                sorular.Add(soru);
            }
            sqlDataReader.Close();
            sorusecme();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressZaman.Maximum != progressZaman.Value)
            {
                
                progressZaman.Value += 1;


            }
            else
            {
                MessageBox.Show("Süre Bitti");
            }
        }

        private void cevapsecme(object sender, EventArgs e)
        {
            Button cevap = (Button)sender;

            if (cevap.Text == sorular[soruIndex].dogrucevap) 
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();
            }
        }

        void dogruCevap()
        {
            MessageBox.Show("Doğru Cevap");
            dogruSayisi++;
            soruIndex++;

            timer.Stop();
            progressZaman.Maximum = 60;
            progressZaman.Value = 0;


            sorusecme();
        }

        void yanlisCevap()
        {
            MessageBox.Show($"Yanlış cevap Skorunuz: {dogruSayisi * 25}");
            yarismaSonlandir();
        }

        void yarismaSonlandir()
        {
            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Skor (KullaniciAdi, SkorPuan) VALUES ('{kullaniciAd}', {dogruSayisi * 25})", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            tabControl1.Enabled = false;
            timer.Enabled = false;
            progressZaman.Value = 0;

        }

        void siralama()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 10 (KullaniciAdi + ': ' + CONVERT(VARCHAR(50), MAX(Skor))) AS SKOR FROM Skor GROUP BY KullaniciAdi", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            int index = 1;
            while (sqlDataReader.Read())
            {
                Label siralamaLabel = new Label();
                siralamaLabel.Top = index * 25;
                siralamaLabel.Width = 500;
                siralamaLabel.Text = index + ". " + sqlDataReader["Skor"].ToString();
                tabPage3.Controls.Add(siralamaLabel);
                index += 1;
            }

            sqlDataReader.Close();


        }
        private void buttonsureekle_Click(object sender, EventArgs e)
        {
            buttonsureekle.Enabled = false;
            progressZaman.Maximum = progressZaman.Maximum + 30;
        }
    }
}
