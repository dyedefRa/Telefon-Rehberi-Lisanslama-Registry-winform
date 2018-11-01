using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities;

namespace TelefonRehberi.Core
{
    public class DatabaseLogicLayer
    {
        List<RehberKayit> kayitlarim;
        public DatabaseLogicLayer()
        {
            kayitlarim = new List<RehberKayit>();
            VeritabaniKonrolu();
        }

        private void VeritabaniKonrolu()
        {
            bool klasorkontrol = Directory.Exists(@"d:\TelefonRehberiDB");

            if (!klasorkontrol)
            {
                Directory.CreateDirectory(@"d:\TelefonRehberiDB");
                Kullanici demo = new Kullanici();
                demo.Id = Guid.NewGuid();
                demo.KullaniciAdi = "demo";
                demo.Parola = "demo";

                string jsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(demo);
                File.WriteAllText(@"d:\TelefonRehberiDB\kullanici.json", jsonKullaniciText);
            }
        }



        public int YeniKayit(RehberKayit temp)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                kayitlarim.Add(temp);
                JsonDbGuncelle();
                sonuc = 1;

            }
            catch (Exception ex)
            {
                //LOG
                sonuc = 0;

            }
            return sonuc;
        }

        public int KayitGuncelle(RehberKayit temp)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int index = kayitlarim.FindIndex(x => x.Id == temp.Id);
                if (index > -1)
                {
                    kayitlarim[index].Adi = temp.Adi;
                    kayitlarim[index].Soyadi = temp.Soyadi;
                    kayitlarim[index].Tel1 = temp.Tel1;
                    kayitlarim[index].Tel2 = temp.Tel2;
                    kayitlarim[index].Tel3 = temp.Tel3;
                    kayitlarim[index].WebSite = temp.WebSite;
                    kayitlarim[index].Adres = temp.Adres;
                    kayitlarim[index].Aciklama = temp.Aciklama;
                    kayitlarim[index].Adres = temp.Adres;
                }
                JsonDbGuncelle();
                sonuc = 1;

            }
            catch (Exception ex)
            {

                throw;
            }
            return sonuc;

        }

        public int KayitSil(Guid id)
        {
            int sonuc = 0;
           
            try
            {   RehberKayitlariGetir();
                var kayit = kayitlarim.Find(x => x.Id==id);
                if (kayit!=null)
                {
 kayitlarim.Remove(kayit);
                }
               
                JsonDbGuncelle();
                sonuc = 1;

            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;

        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            //if (File.Exists(@"D:\TelefonRehberiDB"))
            //{
            string jsonDbText = File.ReadAllText(@"d:\TelefonRehberiDB\rehber.json");
            kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(jsonDbText);

            //}
            return kayitlarim;
        }

        public int KullaniciKontrol(Kullanici temp)
        {
            int kullaniciSonuc = 0;
            //Parolayı tuttugumuz path i aldık
            if (File.Exists(@"d:\TelefonRehberiDB\kullanici.json"))
            {
                //datayı texte cevırdık
                string jsonKullaniciText = File.ReadAllText(@"d:\TelefonRehberiDB\kullanici.json");
                //cevırdıgımız text zaten json tıpınde bunu deserialize edelim
                var kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanici>(jsonKullaniciText);
                //List<kullanici> tipine cevirdik
                //ve bu listte parametredeki kullanici tipiyle uyusan bir kullanıcı varmı..
                //kullaniciSonuc=   kullanicilar.FindAll(x => x.KullaniciAdi == temp.KullaniciAdi && x.Parola == temp.Parola).ToList().Count;
                if (kullanicilar != null && kullanicilar.KullaniciAdi == temp.KullaniciAdi && kullanicilar.Parola == temp.Parola)
                {
                    kullaniciSonuc = 1;
                }
            }
            return kullaniciSonuc;
        }


        #region YardimciMetodlar

        private void JsonDbGuncelle()
        {
            if (kayitlarim != null && kayitlarim.Count > 0)
            {
                string jsonDb = Newtonsoft.Json.JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(@"d:\TelefonRehberiDB\rehber.json", jsonDb);
            }
        }
        #endregion
    }
}
