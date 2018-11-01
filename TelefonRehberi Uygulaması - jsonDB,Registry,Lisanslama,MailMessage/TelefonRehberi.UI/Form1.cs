using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi.UI
{
    public partial class Form1 : Form
    {
        TelefonRehberi.BLL.BusinessLogicLayer bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BLL.BusinessLogicLayer();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
         int sonuc=   bll.KullaniciKontrol(txt_kullaniciAdi.Text, txt_Parola.Text);
            if (sonuc>0)
            {
                AnaForm af = new AnaForm();
                af.Show();
                this.Hide();
            }
            else if(sonuc==-100)
            {
                MessageBox.Show("Form alanlarını eksiksiz olarak doldurunuz");
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi yaptınız");
            }
        }
    }
}
