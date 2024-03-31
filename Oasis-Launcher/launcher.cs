using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Oasis_Launcher
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/hypecrazed/oasis";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void launcher_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string savedGamePath = File.ReadAllText("gamepath.txt").Trim();

            if (!string.IsNullOrEmpty(savedGamePath))
            {
                string gameExecutablePath = Path.Combine(savedGamePath, "Recroom_Release.exe");

                if (File.Exists(gameExecutablePath))
                {
                    Process.Start(gameExecutablePath);
                }
                else
                {
                    MessageBox.Show("The game executable 'Recroom_Release.exe' was not found in the provided game path.");
                }
            }
            else
            {
                MessageBox.Show("Please set the game path before launching the game.");
                return;
            }
           }

        private void button1_Click(object sender, EventArgs e)
        {
            string steamPath = @"C:\Program Files (x86)\Steam\steam.exe"; // If this isn't done, the game will not launch.

            if (File.Exists(steamPath))
            {
                File.Move(steamPath, Path.Combine(Path.GetDirectoryName(steamPath), "stea.exe"));
                MessageBox.Show("Steam updates have been bypassed, you can now launch Rec Room. You will not be able to use Steam until the bypass is reverted!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string steaPath = @"C:\Program Files (x86)\Steam\stea.exe"; // This just reverts the update bypass

            if (File.Exists(steaPath))
            {
                File.Move(steaPath, Path.Combine(Path.GetDirectoryName(steaPath), "steam.exe"));
                MessageBox.Show("Steam updates bypass has been reverted, you can now use Steam again.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string gamePath = pathTextbox.Text.Trim();

                if (!string.IsNullOrEmpty(gamePath))
                {
                    File.WriteAllText("gamepath.txt", gamePath);
                    MessageBox.Show("Game path saved successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid game path.");
                }
            }
        }
    }
}