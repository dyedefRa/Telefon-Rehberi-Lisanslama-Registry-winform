using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TelefonRehberi.Entities;

namespace TelefonRehberi.BLL
{
   public class BusinessLogicLayer
    {
        TelefonRehberi.Core.DatabaseLogicLayer dll;
        public BusinessLogicLayer()
        {
            dll = new Core.DatabaseLogicLayer();
        }

        public int KullaniciKontrol(string kullaniciAdi,string parola)
        {
            int sonuc = 0;
            if (!string.IsNullOrEmpty(kullaniciAdi)&&!string.IsNullOrEmpty(parola))
            {
                Kullanici temp = new Kullanici();
                temp.KullaniciAdi = kullaniciAdi;
                temp.Parola = parola;
                sonuc = dll.KullaniciKontrol(temp);
            }
            else
            {
                sonuc = -100;
            }
            return sonuc;
        }


        public int YeniKayitEkle(Guid id,string ad, string soyad,string tel1,string tel2,string tel3,string adres,string email,string web,string aciklama)
        {
            int sonuc = 0;
            if (id!=Guid.Empty && !string.IsNullOrEmpty(ad)&&!string.IsNullOrEmpty(soyad)&&!string.IsNullOrEmpty(tel1))
            {
                RehberKayit rk = new RehberKayit();
                rk.Id = id;
                rk.Adi = ad;
                rk.Soyadi = soyad;
                rk.Tel1 = tel1;
                rk.Tel2 = tel2;
                rk.Tel3 = tel3;
                rk.Adres = adres;
                rk.WebSite = web;
                rk.Email = email;
                rk.Aciklama = aciklama;

                sonuc = dll.YeniKayit(rk);
            }
            else
            {
                //Eksik parametre
                return -100;
            }
            return sonuc;
        }

        public int KayitGuncelle(Guid id, string ad, string soyad, string tel1, string tel2, string tel3, string adres, string email, string web, string aciklama)
        {
            int sonuc = 0;
            if (id!=Guid.Empty&&!string.IsNullOrEmpty(ad)&!string.IsNullOrEmpty(soyad)&&!string.IsNullOrEmpty(tel1))
            {
                RehberKayit temp = new RehberKayit();
                temp.Id = id;
                temp.Adi = ad;
                temp.Soyadi = soyad;
                temp.Tel1 = tel1;
                temp.Tel2 = tel2;
                temp.Tel3 = tel3;
                temp.Aciklama = aciklama;
                temp.Email = email;
                temp.WebSite = web;
                temp.Adres = adres;
                sonuc = dll.KayitGuncelle(temp);

            }
            else
            {
                sonuc = -100;
            }


            return sonuc;


        }

        public int KayitSil(Guid id)
        {
          return  dll.KayitSil(id);
        }
        public List<RehberKayit> RehberKayitGetir()
        {
            return dll.RehberKayitlariGetir();
        }


        public int XMLVer()
        {
            int sonuc = 0;
            try
            {
                var allKayit = dll.RehberKayitlariGetir();
                XDocument xdoc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8","yes"), new XElement("RehberKayitlar", allKayit.Select(x => new XElement("Kayit",
                       new XElement("ID", x.Id),
                       new XElement("Ad", x.Adi),
                       new XElement("Soyad", x.Soyadi),
                       new XElement("TelefonI", x.Tel1),
                       new XElement("TelefonII", x.Tel2),
                       new XElement("TelefonIII", x.Tel3),
                       new XElement("Email", x.Email),
                       new XElement("Adres", x.Adres),
                       new XElement("WebSite", x.WebSite),
                       new XElement("Aciklama", x.Aciklama)))));

                xdoc.Save(@"d:\TelefonRehberiDB\xmlVer.xml");
                sonuc = 1;

            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;
        }

        public int CSVVer()
        {
            int sonuc = 0;

            try
            {
                var butunKayitlar = dll.RehberKayitlariGetir();
                StreamWriter sw = new StreamWriter(@"D:\TelefonRehberiDB\csvVer.csv");
                CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(sw);

                writer.WriteHeader(typeof(RehberKayit));
                foreach (var item in butunKayitlar)
                {
                    writer.WriteRecord(item);
                }
                sw.Close();
                sonuc = 1;

            }
            catch (Exception ex)
            {
             

                sonuc = 0;
            }


            return sonuc;
        }

        public int JsonVer()
        {
            int sonuc = 0;
            try
            {
                var butunKayitlar = dll.RehberKayitlariGetir();
               string jsonText= Newtonsoft.Json.JsonConvert.SerializeObject(butunKayitlar);
                File.WriteAllText(@"d:\TelefonRehberiDB\verJson.json", jsonText);
                sonuc = 1;
            }
            catch (Exception ex)
            {

                sonuc = 0;
            }
            return sonuc;

        }
    }
}
