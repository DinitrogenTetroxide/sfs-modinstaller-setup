using System.Net.NetworkInformation;

namespace ModInstallerInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath;

        private void selectDirBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "SFS executable (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBox1.Text = filePath.Length > 26 ? filePath.Substring(0, 26) + "..." : filePath;
                }
            }
        }

        private async void installBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath) && filePath.Contains("Spaceflight Simulator.exe"))
            {
                await Task.Run(downloadInstaller);
            }
            else
            {
                SetStatus("No valid SFS executable in the selected directory!");
            }
        }

        private async Task downloadInstaller()
        {
            SetStatus("Downloading...");

            HttpClient client = new();
            HttpRequestMessage req = new(HttpMethod.Get, "https://github.com/Neptune-Sky/SFSModInstaller/releases/latest/download/ModInstaller.dll");
            HttpResponseMessage resp = await client.SendAsync(req);

            string modsFolderPath = filePath.Replace("Spaceflight Simulator.exe", "Mods");
            string modInstallerPath = modsFolderPath + "/ModInstaller.dll";

            if (!resp.IsSuccessStatusCode)
            {
                SetStatus("Failed to download");
                return;
            }
            try
            {
                SetStatus("Installing...");
                byte[] downloadedContent = await resp.Content.ReadAsByteArrayAsync();

                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
                await File.WriteAllBytesAsync(modInstallerPath, downloadedContent);

                SetStatus("Install success!");

            } catch (Exception)
            {
                SetStatus("Failed to install");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SetStatus(string status)
        {
            label1.BeginInvoke(new Action(() =>
            {
                label1.Text = "Status: " + status;
            }));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void runGameBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filePath);
        }
    }
}