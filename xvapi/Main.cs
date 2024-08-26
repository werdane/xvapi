using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;
namespace xvapi
{
    public class Main
    {
        public static status CurrentStatus;

        public static bool IsAClient() => Process.GetProcessesByName("RobloxPlayerBeta").Length != 0;

        public static Process Client()
        {
            return Main.IsAClient() ? Process.GetProcessesByName("RobloxPlayerBeta")[0] : null;
        }

        public static status Inject(string path)
        {
            
            setup.load();
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show(path + " not found.");
                return status.FAILED;
            }

            if (!Main.IsAClient())
            {
                try
                {
                    Main.CurrentStatus = status.CLIENT_NOT_FOUND;
                    return status.CLIENT_NOT_FOUND;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Main.CurrentStatus = status.FAILED;
                    return status.FAILED;
                }
            }
            try
            {
                System.Diagnostics.Process.Start(path);
                Main.CurrentStatus = status.INJECTED;
                return status.INJECTED;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Main.CurrentStatus = status.FAILED;
                return status.FAILED;
            }
        }

        public static void Execute(string source)
        {
            try
            {
                System.IO.File.WriteAllBytes(Path.GetTempPath() + "celery\\myfile.txt", Encoding.UTF8.GetBytes(source));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
