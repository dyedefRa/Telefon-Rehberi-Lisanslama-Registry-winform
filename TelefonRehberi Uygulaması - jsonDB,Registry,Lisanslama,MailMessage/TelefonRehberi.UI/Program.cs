using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LisansKontrol();
            //644e1dd7 - 2a7f - 18fb - b8ed - ed78c3f92c2b
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (LisansKontrol())
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new LisansEkran());
            }

        }

        static bool LisansKontrol()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("TelefonRehberi");
            if (rk != null)
            {
                string HarddiskSeriNumarasi = string.Empty;
                string MacAddress = string.Empty;
                string surucu = "C:";
                ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + surucu + "\"");
                disk.Get();

                HarddiskSeriNumarasi = disk["VolumeSerialNumber"].ToString();
                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MACADD.GetInstances();
                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        MacAddress = item["MacAddress"].ToString();
                    }
                }


                string HDDSNSTR = rk.GetValue("HardDiskSeriNumarasi").ToString();
                string MACADDSTR =
                rk.GetValue("MACAddress").ToString();
                if (HarddiskSeriNumarasi==HDDSNSTR&&MacAddress==MACADDSTR)
                {
return true;
                }
                return false;

            }
            else
            {
                return false;
            }

        }
    }
}
