using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileApp
{
    public partial class Form1 : Form
    {
        private const string FileNameUserName    = "user-name.txt";

        public Form1()
        {
            InitializeComponent();
            var userNamePath = GetFullPath(FileNameUserName);
            if (File.Exists(userNamePath))
            {
                //Nazwa jest ustawiona
                var userName = File.ReadAllText(userNamePath);
                
                SetUserName(userName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var fileName = tbFileName.Text;

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Proszê podaj nazwê pliku.");
                return;
            }

            var path = GetFullPath(fileName);

            if (File.Exists(path))
            {
                MessageBox.Show("Plik o podanej nazwie ju¿ istnieje! Wpisz proszê inn¹ nazwê pliku.");
                return;
            }

            /*            using (FileStream fileStream = File.Create(path))
                        {
                            var text = rtbContent.Text;
                            var content = Encoding.UTF8.GetBytes(text);
                            fileStream.Write(content, 0, content.Length);

                        }
            */

            File.WriteAllText(path, rtbContent.Text);

            var fileInfo = new FileInfo(path);
            fileInfo.LastWriteTime = DateTime.Now;

            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.LastWriteTime = DateTime.Now;
        }



        private void btnRead_Click(object sender, EventArgs e)
        {
            var fileName = tbFileName.Text;

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Proszê podaj nazwê pliku.");
                return;
            }

            var path = GetFullPath(fileName);

            rtbContent.Text = File.ReadAllText(path);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var fileName = tbFileName.Text;

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Proszê podaj nazwê pliku.");
                return;
            }

            var path = GetFullPath(fileName);

            File.Delete(path);

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var fileName = tbFileName.Text;

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Proszê podaj nazwê pliku.");
                return;
            }

            var path = GetFullPath(fileName);

            File.Copy(path, "D:\\Google Drive\\Programowanie\\C#\\AkademiaDotNet_KS\\ProjectDotnetExamples\\ProjectDotnetExamples\\FileApp\\bin\\Debug\\net7.0-windows\\myfiles\\nowy_plik.txt");
        }

        private static string GetFullPath(string fileName)
        {
            var binPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            var expectedDirectory = Path.Combine(binPath, "myfiles");

            if (!Directory.Exists(expectedDirectory))
            {
                Directory.CreateDirectory(expectedDirectory);
            }

            return Path.Combine(expectedDirectory, fileName);

        }

        private void btnUserNameSave_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Proszê podaj nazwê u¿ytkownika!");
                return;
            }

            var path = GetFullPath(FileNameUserName);
            File.WriteAllText(path, userName);

            SetUserName(userName);
        }

        private void SetUserName(string userName)
        {
            lbUserName.Text = $"Witaj {userName} !";
            lbUserInfo.Visible = false;
            tbUserName.Visible = false;
            btnUserNameSave.Visible = false;
        }
    }
}