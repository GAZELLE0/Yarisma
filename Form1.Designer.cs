namespace YarismaProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressZaman = new System.Windows.Forms.ProgressBar();
            this.button4D = new System.Windows.Forms.Button();
            this.button3C = new System.Windows.Forms.Button();
            this.button2B = new System.Windows.Forms.Button();
            this.button1A = new System.Windows.Forms.Button();
            this.textBoxSoru = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonsureekle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Navy;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonGiris);
            this.tabPage1.Controls.Add(this.textBoxSifre);
            this.tabPage1.Controls.Add(this.textBoxAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(69, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonGiris.Location = new System.Drawing.Point(72, 215);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(131, 52);
            this.buttonGiris.TabIndex = 2;
            this.buttonGiris.Text = "GİRİŞ";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(72, 148);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(131, 22);
            this.textBoxSifre.TabIndex = 1;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(72, 83);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(131, 22);
            this.textBoxAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Navy;
            this.tabPage2.Controls.Add(this.buttonsureekle);
            this.tabPage2.Controls.Add(this.progressZaman);
            this.tabPage2.Controls.Add(this.button4D);
            this.tabPage2.Controls.Add(this.button3C);
            this.tabPage2.Controls.Add(this.button2B);
            this.tabPage2.Controls.Add(this.button1A);
            this.tabPage2.Controls.Add(this.textBoxSoru);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YARIŞMA";
            // 
            // progressZaman
            // 
            this.progressZaman.Location = new System.Drawing.Point(40, 481);
            this.progressZaman.Name = "progressZaman";
            this.progressZaman.Size = new System.Drawing.Size(976, 38);
            this.progressZaman.TabIndex = 5;
            // 
            // button4D
            // 
            this.button4D.Location = new System.Drawing.Point(439, 369);
            this.button4D.Name = "button4D";
            this.button4D.Size = new System.Drawing.Size(176, 68);
            this.button4D.TabIndex = 4;
            this.button4D.Text = "D";
            this.button4D.UseVisualStyleBackColor = true;
            this.button4D.Click += new System.EventHandler(this.cevapsecme);
            // 
            // button3C
            // 
            this.button3C.Location = new System.Drawing.Point(109, 369);
            this.button3C.Name = "button3C";
            this.button3C.Size = new System.Drawing.Size(176, 68);
            this.button3C.TabIndex = 3;
            this.button3C.Text = "C";
            this.button3C.UseVisualStyleBackColor = true;
            this.button3C.Click += new System.EventHandler(this.cevapsecme);
            // 
            // button2B
            // 
            this.button2B.Location = new System.Drawing.Point(439, 249);
            this.button2B.Name = "button2B";
            this.button2B.Size = new System.Drawing.Size(176, 68);
            this.button2B.TabIndex = 2;
            this.button2B.Text = "B";
            this.button2B.UseVisualStyleBackColor = true;
            this.button2B.Click += new System.EventHandler(this.cevapsecme);
            // 
            // button1A
            // 
            this.button1A.Location = new System.Drawing.Point(109, 249);
            this.button1A.Name = "button1A";
            this.button1A.Size = new System.Drawing.Size(176, 68);
            this.button1A.TabIndex = 1;
            this.button1A.Text = "A";
            this.button1A.UseVisualStyleBackColor = true;
            this.button1A.Click += new System.EventHandler(this.cevapsecme);
            // 
            // textBoxSoru
            // 
            this.textBoxSoru.Location = new System.Drawing.Point(69, 50);
            this.textBoxSoru.Multiline = true;
            this.textBoxSoru.Name = "textBoxSoru";
            this.textBoxSoru.Size = new System.Drawing.Size(555, 133);
            this.textBoxSoru.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TOP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonsureekle
            // 
            this.buttonsureekle.Location = new System.Drawing.Point(741, 80);
            this.buttonsureekle.Name = "buttonsureekle";
            this.buttonsureekle.Size = new System.Drawing.Size(157, 63);
            this.buttonsureekle.TabIndex = 6;
            this.buttonsureekle.Text = "Süre Ekle";
            this.buttonsureekle.UseVisualStyleBackColor = true;
            this.buttonsureekle.Click += new System.EventHandler(this.buttonsureekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 640);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxSoru;
        private System.Windows.Forms.Button button4D;
        private System.Windows.Forms.Button button3C;
        private System.Windows.Forms.Button button2B;
        private System.Windows.Forms.Button button1A;
        private System.Windows.Forms.ProgressBar progressZaman;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonsureekle;
    }
}

