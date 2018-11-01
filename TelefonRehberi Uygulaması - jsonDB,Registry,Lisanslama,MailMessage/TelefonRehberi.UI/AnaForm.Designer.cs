namespace TelefonRehberi.UI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_List = new System.Windows.Forms.ListBox();
            this.grp_2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_YeniKayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Web = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Tel3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tel1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.btn_XmlAl = new System.Windows.Forms.Button();
            this.btn_JsonVer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_List);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Liste";
            // 
            // lst_List
            // 
            this.lst_List.FormattingEnabled = true;
            this.lst_List.ItemHeight = 16;
            this.lst_List.Location = new System.Drawing.Point(6, 22);
            this.lst_List.Name = "lst_List";
            this.lst_List.Size = new System.Drawing.Size(195, 516);
            this.lst_List.TabIndex = 0;
            this.lst_List.DoubleClick += new System.EventHandler(this.lst_List_DoubleClick);
            // 
            // grp_2
            // 
            this.grp_2.Controls.Add(this.button5);
            this.grp_2.Controls.Add(this.btn_Sil);
            this.grp_2.Controls.Add(this.btn_Guncelle);
            this.grp_2.Controls.Add(this.btn_YeniKayit);
            this.grp_2.Controls.Add(this.tabControl1);
            this.grp_2.Location = new System.Drawing.Point(225, 12);
            this.grp_2.Name = "grp_2";
            this.grp_2.Size = new System.Drawing.Size(616, 399);
            this.grp_2.TabIndex = 1;
            this.grp_2.TabStop = false;
            this.grp_2.Text = "Yeni Rehber Kaydı";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(539, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(305, 355);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(288, 31);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(6, 355);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(288, 31);
            this.btn_Guncelle.TabIndex = 17;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_YeniKayit
            // 
            this.btn_YeniKayit.Location = new System.Drawing.Point(7, 318);
            this.btn_YeniKayit.Name = "btn_YeniKayit";
            this.btn_YeniKayit.Size = new System.Drawing.Size(587, 31);
            this.btn_YeniKayit.TabIndex = 16;
            this.btn_YeniKayit.Text = "Yeni Kayıt Ekle";
            this.btn_YeniKayit.UseVisualStyleBackColor = true;
            this.btn_YeniKayit.Click += new System.EventHandler(this.btn_YeniKayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Adress);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_Web);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_Email);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_Tel3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_Tel2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_Tel1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Soyad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Ad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(300, 46);
            this.txt_Adress.Multiline = true;
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(277, 170);
            this.txt_Adress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres";
            // 
            // txt_Web
            // 
            this.txt_Web.Location = new System.Drawing.Point(81, 194);
            this.txt_Web.Name = "txt_Web";
            this.txt_Web.Size = new System.Drawing.Size(197, 22);
            this.txt_Web.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Web Site";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(81, 166);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(197, 22);
            this.txt_Email.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-mail";
            // 
            // txt_Tel3
            // 
            this.txt_Tel3.Location = new System.Drawing.Point(81, 138);
            this.txt_Tel3.Name = "txt_Tel3";
            this.txt_Tel3.Size = new System.Drawing.Size(197, 22);
            this.txt_Tel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon III";
            // 
            // txt_Tel2
            // 
            this.txt_Tel2.Location = new System.Drawing.Point(81, 110);
            this.txt_Tel2.Name = "txt_Tel2";
            this.txt_Tel2.Size = new System.Drawing.Size(197, 22);
            this.txt_Tel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon II";
            // 
            // txt_Tel1
            // 
            this.txt_Tel1.Location = new System.Drawing.Point(81, 82);
            this.txt_Tel1.Name = "txt_Tel1";
            this.txt_Tel1.Size = new System.Drawing.Size(197, 22);
            this.txt_Tel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon I";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(81, 54);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(197, 22);
            this.txt_Soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad ";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(81, 26);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(197, 22);
            this.txt_Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_Aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(-4, -1);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(591, 252);
            this.txt_Aciklama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Durum);
            this.groupBox3.Controls.Add(this.btn_XmlAl);
            this.groupBox3.Controls.Add(this.btn_JsonVer);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(225, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data AL/VER";
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Durum.Location = new System.Drawing.Point(29, 90);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(175, 20);
            this.lbl_Durum.TabIndex = 4;
            this.lbl_Durum.Text = "Durum : Beklemede";
            // 
            // btn_XmlAl
            // 
            this.btn_XmlAl.Location = new System.Drawing.Point(309, 21);
            this.btn_XmlAl.Name = "btn_XmlAl";
            this.btn_XmlAl.Size = new System.Drawing.Size(93, 56);
            this.btn_XmlAl.TabIndex = 3;
            this.btn_XmlAl.Text = "XML AL";
            this.btn_XmlAl.UseVisualStyleBackColor = true;
            // 
            // btn_JsonVer
            // 
            this.btn_JsonVer.Location = new System.Drawing.Point(210, 21);
            this.btn_JsonVer.Name = "btn_JsonVer";
            this.btn_JsonVer.Size = new System.Drawing.Size(93, 56);
            this.btn_JsonVer.TabIndex = 2;
            this.btn_JsonVer.Text = "JSON VER";
            this.btn_JsonVer.UseVisualStyleBackColor = true;
            this.btn_JsonVer.Click += new System.EventHandler(this.btn_JsonVer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "CSV VER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "XML VER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grp_2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Web;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Tel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_YeniKayit;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Button btn_XmlAl;
        private System.Windows.Forms.Button btn_JsonVer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_List;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button button5;
    }
}