using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Windows32ChangerUSERowner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Windows User Owner Changer";
            Console.Beep();
            bool success = true;
            Console.WriteLine("Changing Owner to Current USER...");
            Thread.Sleep(5000);
            if (success)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "cmd";
                info.Arguments = @"/k takeown /f C:\Windows\System32 && icacls C:\Windows\System32 /grant %username%:F && takeown /f C:\Windows\System32\drivers && icacls C:\Windows\System32\drivers /grant %username%:F && exit";
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
                Console.WriteLine("Successfully Changed!!!");
                Thread.Sleep(2100);
                Environment.Exit(125);
            }
            else
            {
                Thread.Sleep(5000);
                Console.WriteLine("Failed to Changed!!!");
                Thread.Sleep(2500);
                Environment.Exit(112);
                success = false;
            }
        }
    }
}
