using System.Diagnostics;

namespace Silk_Client
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Process? discordProcess = null;

            while (discordProcess == null)
            {
                Process[] processes = Process.GetProcessesByName("Discord");

                if (processes.Length > 0)
                {
                    discordProcess = processes[0];

                    Console.WriteLine($"\nDiscord detected: Discord.exe | PID: {discordProcess.Id}");
                    Console.WriteLine("Press ENTER to continue...");

                    Console.ReadLine();

                    break;
                }

                Console.WriteLine("No Discord found. Open Discord and try again.");
                await Task.Delay(3000);
            }

            Console.WriteLine("Connected");

            ApplicationConfiguration.Initialize();
            Application.Run(new Silk());
        }
    }
}
