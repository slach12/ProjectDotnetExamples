using System.Collections.Specialized;
using System.Diagnostics;
using System.IO.Compression;

namespace ZipApp
{
    public partial class Form1 : Form
    {
        private readonly string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "Files");
        public Form1()
        {
            InitializeComponent();
            CreateFileDirectory();
        }



        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbZipPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void btnZipFile_Click(object sender, EventArgs e)
        {
            if (!IsZipPathSelected())
            {
                ShowMessageZipPathIsNotSelected();
                return;
            }

            ZipFolder();

            MessageBox.Show("Folder zosta³ skompresowany.");
        }


        private void btnCopyZipFile_Click(object sender, EventArgs e)
        {
            if (!IsZipPathSelected())
            {
                ShowMessageZipPathIsNotSelected();
                return;
            }


            var zipPath = GetZipPath();

            if (!File.Exists(zipPath))
            {
                MessageBox.Show("¯adne pliki nie zosta³y jeszcze skompresowane.");
                return;
            }

            Clipboard.SetFileDropList(new StringCollection { zipPath });

        }


        private void btnChooseZipFile_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = _filePath;
            openFileDialog.Filter = "Zip files (*.zip)|*.zip";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbUnzipFile.Text = openFileDialog.FileName;
            }
        }

        private void btnUzipFile_Click(object sender, EventArgs e)
        {
            var selectedPath = lbUnzipFile.Text;
            if (!IsUnZipPathSelected())
            {
                ShowMessageUnZipPathIsNotSelected();
                return;
            }




            if (!File.Exists(selectedPath))
            {
                MessageBox.Show("Wybrany plik nie istieniej.");
                return;
            }

            var destinationDirectoryName = GetUnzipDestinationDirectoryName();

            ZipFile.ExtractToDirectory(selectedPath, destinationDirectoryName, true);

            MessageBox.Show("Wybrany plik zosta³ rozpakowany.");

        }

        private string GetUnzipDestinationDirectoryName()
        {
            var selectedPath = lbUnzipFile.Text;
            return Path.Combine(Path.GetDirectoryName(selectedPath), Path.GetFileNameWithoutExtension(selectedPath));
        }

        private void btnShowUnzipFiles_Click(object sender, EventArgs e)
        {
            if (!IsUnZipPathSelected())
            {
                ShowMessageUnZipPathIsNotSelected();
                return;
            }



            var destinationDirectoryName = GetUnzipDestinationDirectoryName();

            if (!Directory.Exists(destinationDirectoryName))
            {
                MessageBox.Show("Pliki nie zosta³y jeszcze rozpakowane.");
                return;
            }
            var startInfo = new ProcessStartInfo
            {
                Arguments = destinationDirectoryName,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);

        }

        private void CreateFileDirectory()
        {
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(_filePath);
            }
        }
        private bool IsZipPathSelected()
        {
            return !string.IsNullOrWhiteSpace(lbZipPath.Text);
        }

        private static void ShowMessageZipPathIsNotSelected()
        {
            MessageBox.Show("Wybierz proszê najpierw folder , który chcesz skompresowaæ");
        }

        private bool IsUnZipPathSelected()
        {
            return !string.IsNullOrWhiteSpace(lbUnzipFile.Text);
        }

        private static void ShowMessageUnZipPathIsNotSelected()
        {
            MessageBox.Show("Wybierz proszê najpierw plik , który chcesz rozpakowaæ");
        }
        private void ZipFolder()
        {
            var destinationFileName = GetZipPath();
            if (File.Exists(destinationFileName))
            {
                File.Delete(destinationFileName);
            }
            ZipFile.CreateFromDirectory(lbZipPath.Text, destinationFileName);
        }

        private string GetZipPath()
        {
            var compressedFileName = $"{Path.GetFileName(lbZipPath.Text)}.zip";
            var destinationFileName = Path.Combine(_filePath, compressedFileName);
            return destinationFileName;
        }



    }
}