using Microsoft.Win32;
using System.Diagnostics;

namespace RegistryLib
{
    public class RegistryUtils
    {
        public static void Register(string clientId)
        {
            var classes = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Classes", true);
            // Client Id
            RegistryKey key = classes.CreateSubKey($"open-taptap-{clientId}");
            // 
            key.SetValue("URL Protocol", "code");
            key.CreateSubKey(@"shell\open\command").SetValue("", $"{Process.GetCurrentProcess().MainModule.FileName} %1");
        }
    }
}
