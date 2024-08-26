// stolen from ccapi (the rat was removed from the code dw) ;_)
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace xvapi
{
    internal class setup
    {
        internal static string CurrentDirectory = System.Environment.CurrentDirectory;
        internal static string CeleryDirectory = Path.GetTempPath() + "\\celery";
        private static WebClient versioncheckclient = new WebClient();

        internal static void load()
        {
            if (!Directory.Exists(setup.CurrentDirectory + "\\autoexec"))
                Directory.CreateDirectory(setup.CurrentDirectory + "\\autoexec");
            if (!Directory.Exists(setup.CeleryDirectory))
                Directory.CreateDirectory(setup.CeleryDirectory);
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\celeryhome.txt", setup.CurrentDirectory);
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\robloxexe.txt", "");
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\autolaunch.txt", "");
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\callback.txt", "");
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\CeleryLog.txt", "");
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\robloxexe.txt", "");
            System.IO.File.WriteAllText(setup.CeleryDirectory + "\\launchargs.txt", "");
            if (!Directory.Exists(setup.CeleryDirectory + "\\workspace"))
                Directory.CreateDirectory(setup.CeleryDirectory + "\\workspace");
            if (!Directory.Exists(setup.CurrentDirectory + "\\autoexec"))
                Directory.CreateDirectory(setup.CurrentDirectory + "\\autoexec");
            if (!System.IO.File.Exists(setup.CurrentDirectory + "\\autoexec\\autoexec.lua"))
                System.IO.File.WriteAllText(setup.CurrentDirectory + "\\autoexec\\autoexec.lua", "");
            if (!Directory.Exists(setup.CurrentDirectory + "\\bin"))
                Directory.CreateDirectory("bin");
        }
    }
}
