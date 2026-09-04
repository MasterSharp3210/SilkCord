using DiscordRPC;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silk_Client
{
    public partial class Silk : Form
    {
        private DiscordRpcClient? discordClient;
        private bool isRpcStarted = false;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            out SHFILEINFO psfi,
            uint cbFileInfo,
            uint uFlags);

        const uint SHGFI_ICON = 0x100;
        const uint SHGFI_LARGEICON = 0x0;
        const uint SHGFI_USEFILEATTRIBUTES = 0x10;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Silk()
        {
            InitializeComponent();

            SHFILEINFO shinfo = new SHFILEINFO();
            SHGetFileInfo(".exe", 0, out shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON | SHGFI_USEFILEATTRIBUTES);

            if (shinfo.hIcon != IntPtr.Zero)
            {
                this.Icon = Icon.FromHandle(shinfo.hIcon);
            }

            TitlePanel.MouseDown += TitlePanel_MouseDown;

            ApplyDiscordRPC.Text = "Start";
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(
                    this.Handle,
                    WM_NCLBUTTONDOWN,
                    HTCAPTION,
                    0);
            }
        }

        private async void Silk_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            FreeConsole();
        }

        private void ApplyDiscordRPC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ApplicationTextbox.Text))
            {
                MessageBox.Show("Please enter a valid Application ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discordClient == null || discordClient.ApplicationID != ApplicationTextbox.Text)
            {
                discordClient?.Dispose();
                discordClient = new DiscordRpcClient(ApplicationTextbox.Text);
                discordClient.Initialize();
            }

            ActivityType activityType;

            switch (ActivityComboBox.SelectedItem?.ToString())
            {
                case "Watching":
                    activityType = ActivityType.Watching;
                    break;

                case "Listening":
                    activityType = ActivityType.Listening;
                    break;

                case "Playing":
                default:
                    activityType = ActivityType.Playing;
                    break;
            }

            discordClient.SetPresence(new RichPresence()
            {
                Details = DetailsTextbox.Text,
                State = StateTextbox.Text,
                Type = activityType,
                Assets = new Assets()
                {
                    LargeImageKey = LargeTextbox.Text,
                    LargeImageText = LargeTextTextbox.Text,
                    SmallImageKey = SmallTextbox.Text,
                    SmallImageText = SmallTextTextbox.Text
                }
            });

            if (!isRpcStarted)
            {
                isRpcStarted = true;
                ApplyDiscordRPC.Text = "Update";
            }
        }

        private void LoadConfigButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*",
                Title = "Select a configuration file",
                RestoreDirectory = true,
                AutoUpgradeEnabled = false
            };

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=', 2);

                    if (parts.Length != 2)
                        continue;

                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    switch (key)
                    {
                        case "Application":
                            ApplicationTextbox.Text = value;
                            break;

                        case "Activity":
                            ActivityComboBox.SelectedItem = value;
                            break;

                        case "Details":
                            DetailsTextbox.Text = value;
                            break;

                        case "State":
                            StateTextbox.Text = value;
                            break;

                        case "Large":
                            LargeTextbox.Text = value;
                            break;

                        case "LargeText":
                            LargeTextTextbox.Text = value;
                            break;

                        case "Small":
                            SmallTextbox.Text = value;
                            break;

                        case "SmallText":
                            SmallTextTextbox.Text = value;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error while loading configuration:\n\n{ex.Message}",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SaveSettingButton_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*",
                DefaultExt = "cfg",
                AddExtension = true,
                Title = "Save Configuration File",
                RestoreDirectory = true,
                AutoUpgradeEnabled = false
            };

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, new[]
                    {
                        $"Application={ApplicationTextbox.Text}",
                        $"Activity={ActivityComboBox.SelectedItem?.ToString() ?? "Playing"}",
                        $"Details={DetailsTextbox.Text}",
                        $"State={StateTextbox.Text}",
                        $"Large={LargeTextbox.Text}",
                        $"LargeText={LargeTextTextbox.Text}",
                        $"Small={SmallTextbox.Text}",
                        $"SmallText={SmallTextTextbox.Text}"
                    });

                    MessageBox.Show("Config saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error while saving configuration:\n\n{ex.Message}",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            discordClient?.Dispose();
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}