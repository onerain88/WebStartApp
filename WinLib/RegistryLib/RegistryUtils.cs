using Microsoft.Win32;
using System.Diagnostics;

namespace RegistryLib
{
    public class RegistryUtils
    {
        public static void Register()
        {
            var classes = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Classes", true);
            // TODO Client Id
            RegistryKey key = classes.CreateSubKey("wsapp");
            // 
            key.SetValue("URL Protocol", "code");
            key.CreateSubKey(@"shell\open\command").SetValue("", $"{Process.GetCurrentProcess().MainModule.FileName} %1");
        }
    }
}
