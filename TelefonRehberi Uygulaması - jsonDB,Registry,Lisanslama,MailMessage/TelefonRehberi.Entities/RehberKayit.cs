using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.Entities
{
  public  class RehberKayit
    {
        public Guid Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Tel3 { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return $"{Adi} {Soyadi} - {Tel1}";
        }
    }
}
