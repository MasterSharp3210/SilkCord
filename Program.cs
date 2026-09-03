using System.Diagnostics;

namespace Silk_Client
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            bool discordOpened = Process.GetProcessesByName("Discord").Length > 0;
            
            if (discordOpened) {
                Console.WriteLine("Connected");

                ApplicationConfiguration.Initialize();
                Application.Run(new Silk());
            }

            else
            {
                Console.WriteLine("No Discord process found.");
                Console.ReadKey();
            }
        }
    }
}