using ICSharpCode.SharpZipLib.BZip2;

namespace CompressorTool.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetPropertiesToInitialize();
        }

        private void SetPropertiesToInitialize()
        {
            saveFileDialog1.Filter = "Log Files | *.log";
            saveFileDialog1.DefaultExt = "log";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog(this);

            if (result != DialogResult.OK) return;

            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog(this);

            if (result != DialogResult.OK) return;

            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) return;

            ProcessFiles(textBox1.Text, textBox2.Text);
        }

        private void ProcessFiles(string bz2FilesRootDirectory, string bz2FilesCompressDestiny)
        {
            //procura por arquivos

            var files = Directory.GetFiles(bz2FilesRootDirectory, "*.log", SearchOption.TopDirectoryOnly);

            //comprime arquivos

            foreach (var file in files)
            {
                var destinyPath =
                    Path.Combine(bz2FilesCompressDestiny, $"{Path.GetFileNameWithoutExtension(file)}.bz2");

                Console.WriteLine($"Compactando o arquivo {Path.GetFileName(file)} via BZIP2!");

                BZip2.Compress(File.OpenRead(file), File.Create(destinyPath), true, 9);
            }

        }
    }
}