using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonRehberi.Entities;

namespace TelefonRehberi.UI
{
    public partial class AnaForm : Form
    {
        TelefonRehberi.BLL.BusinessLogicLayer bll;

        public AnaForm()
        {
            InitializeComponent();
            bll = new BLL.BusinessLogicLayer();
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            int sonuc = bll.YeniKayitEkle(Guid.NewGuid(), txt_Ad.Text, txt_Soyad.Text, txt_Tel1.Text, txt_Tel2.Text, txt_Tel3.Text, txt_Adress.Text, txt_Email.Text, txt_Web.Text, txt_Aciklama.Text);
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız başarıyla eklendi..");
                Doldur();
                Temizle();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Eksik parametre hatası..Lütfen ad, soyad , email ve tel alanları doldurunuz");
            }
            else
            {
                MessageBox.Show("Kayıt ekleme bölümünde sorun oluştu..");
            }


        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Doldur();

        }

        public void Doldur()
        {
            var deger = bll.RehberKayitGetir();
            if (deger != null && deger.Count > 0)
            {
                lst_List.DataSource = deger;
            }
        }

        public void Temizle()
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_Tel1.Clear();
            txt_Tel2.Clear();
            txt_Tel3.Clear();
            txt_Email.Clear();
            txt_Adress.Clear();
            txt_Web.Clear();
            txt_Aciklama.Clear();
        }

        private void lst_List_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            var currentItem = (RehberKayit)lb.SelectedItem;
            txt_Ad.Text = currentItem.Adi;
            txt_Soyad.Text = currentItem.Soyadi;
            txt_Tel1.Text = currentItem.Tel1;
            txt_Tel2.Text = currentItem.Tel2;
            txt_Tel3.Text = currentItem.Tel3;
            txt_Email.Text = currentItem.Email;
            txt_Adress.Text = currentItem.Adres;
            txt_Web.Text = currentItem.WebSite;
            txt_Aciklama.Text = currentItem.Aciklama;
            grp_2.Text = "Rehber Kayıt Güncelle";

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

            if (lst_List.SelectedItem != null)
            {

                var seciliKayit = (RehberKayit)lst_List.SelectedItem;


                int sonuc = bll.KayitGuncelle(seciliKayit.Id, txt_Ad.Text, txt_Soyad.Text, txt_Tel1.Text, txt_Tel2.Text, txt_Tel3.Text, txt_Adress.Text, txt_Email.Text, txt_Web.Text, txt_Aciklama.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt başarıyla guncellendi");
                    Doldur();
                }
                else if (sonuc == -100)
                {
                    MessageBox.Show("Eksik parametre hatası");
                }
                else
                {
                    MessageBox.Show("Guncelleme de sorun oluştu");
                }

            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (lst_List.SelectedItem != null)
            {
                var currentID = ((RehberKayit)lst_List.SelectedItem).Id;
                int sonuc = bll.KayitSil(currentID);
                if (sonuc > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                    Doldur();
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //XML VER
            int sonuc = bll.XMLVer();
            if (sonuc > 0)
            {
                lbl_Durum.Text = "Durum Açıklaması : XML Data-Ver Tamamlandı";
            }
            else
            {
                lbl_Durum.Text = "Durum Açıklaması :XML Hata oluştu";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CSV VER

            int sonuc = bll.CSVVer();
            if (sonuc > 0)
            {
                lbl_Durum.Text = "Durum Açıklaması : CSV Data-Ver Tamamlandı";
            }
            else
            {
                lbl_Durum.Text = "Durum Açıklaması :CSV de Hata oluştu";

            }

        }

        private void btn_JsonVer_Click(object sender, EventArgs e)
        {
            int sonuc = bll.JsonVer();

            if (sonuc > 0)
            {
                lbl_Durum.Text = "Durum Açıklaması : Json Data-Ver Tamamlandı";
            }
            else
            {
                lbl_Durum.Text = "Durum Açıklaması : Json de Hata oluştu";

            }
        }
    }
}
