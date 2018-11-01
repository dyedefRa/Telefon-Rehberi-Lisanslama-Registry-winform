using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi.UI
{
    public partial class LisansEkran : Form
    {
        public LisansEkran()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //Lisans onay butonu
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_LisansKey.Text=="644e1dd7-2a7f-18fb-b8ed-ed78c3f92c2")
            {
                string HarddiskSeriNumarasi = string.Empty;
                string MacAddress = string.Empty;
                string surucu = "C:";
                ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + surucu + "\"");
                disk.Get();

                HarddiskSeriNumarasi=disk["VolumeSerialNumber"].ToString();
                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection NAL=    MACADD.GetInstances();
                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                      MacAddress=  item["MacAddress"].ToString();
                    }
                }
               


                if (!string.IsNullOrEmpty(HarddiskSeriNumarasi)&&!string.IsNullOrEmpty(MacAddress))
                {
                    RegistryKey rk = Registry.CurrentUser.CreateSubKey("TelefonRehberi",RegistryKeyPermissionCheck.ReadWriteSubTree);
                    rk.SetValue("HardDiskSeriNumarasi", HarddiskSeriNumarasi);
                    rk.SetValue("MACAddress", MacAddress);
                    MessageBox.Show("Lisanslama işleminiz tamamlanmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Application.Exit();

                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz lisans numarası yanlış","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
