namespace ZipApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbZipPath = new Label();
            btnCopyZipFile = new Button();
            btnZipFile = new Button();
            btnChooseFolder = new Button();
            groupBox2 = new GroupBox();
            lbUnzipFile = new Label();
            btnShowUnzipFiles = new Button();
            btnUzipFile = new Button();
            btnChooseZipFile = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cornsilk;
            groupBox1.Controls.Add(lbZipPath);
            groupBox1.Controls.Add(btnCopyZipFile);
            groupBox1.Controls.Add(btnZipFile);
            groupBox1.Controls.Add(btnChooseFolder);
            groupBox1.Location = new Point(34, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pakowanie plików (ZIP)";
            // 
            // lbZipPath
            // 
            lbZipPath.Location = new Point(37, 131);
            lbZipPath.Name = "lbZipPath";
            lbZipPath.Size = new Size(332, 45);
            lbZipPath.TabIndex = 3;
            // 
            // btnCopyZipFile
            // 
            btnCopyZipFile.Location = new Point(37, 279);
            btnCopyZipFile.Name = "btnCopyZipFile";
            btnCopyZipFile.Size = new Size(332, 63);
            btnCopyZipFile.TabIndex = 2;
            btnCopyZipFile.Text = "Kopiuj skompresowany plik";
            btnCopyZipFile.UseVisualStyleBackColor = true;
            btnCopyZipFile.Click += btnCopyZipFile_Click;
            // 
            // btnZipFile
            // 
            btnZipFile.Location = new Point(37, 179);
            btnZipFile.Name = "btnZipFile";
            btnZipFile.Size = new Size(332, 63);
            btnZipFile.TabIndex = 1;
            btnZipFile.Text = "Skompresuj pliki";
            btnZipFile.UseVisualStyleBackColor = true;
            btnZipFile.Click += btnZipFile_Click;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(37, 52);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(332, 63);
            btnChooseFolder.TabIndex = 0;
            btnChooseFolder.Text = "Wybierz folder";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(lbUnzipFile);
            groupBox2.Controls.Add(btnShowUnzipFiles);
            groupBox2.Controls.Add(btnUzipFile);
            groupBox2.Controls.Add(btnChooseZipFile);
            groupBox2.Location = new Point(470, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 399);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rozpakowywanie plików (UNZIP)";
            // 
            // lbUnzipFile
            // 
            lbUnzipFile.AutoSize = true;
            lbUnzipFile.Location = new Point(37, 145);
            lbUnzipFile.MaximumSize = new Size(255, 0);
            lbUnzipFile.Name = "lbUnzipFile";
            lbUnzipFile.Size = new Size(0, 20);
            lbUnzipFile.TabIndex = 3;
            // 
            // btnShowUnzipFiles
            // 
            btnShowUnzipFiles.Location = new Point(37, 279);
            btnShowUnzipFiles.Name = "btnShowUnzipFiles";
            btnShowUnzipFiles.Size = new Size(332, 63);
            btnShowUnzipFiles.TabIndex = 2;
            btnShowUnzipFiles.Text = "Pokaż rozpakowane pliki";
            btnShowUnzipFiles.UseVisualStyleBackColor = true;
            btnShowUnzipFiles.Click += btnShowUnzipFiles_Click;
            // 
            // btnUzipFile
            // 
            btnUzipFile.Location = new Point(37, 179);
            btnUzipFile.Name = "btnUzipFile";
            btnUzipFile.Size = new Size(332, 63);
            btnUzipFile.TabIndex = 1;
            btnUzipFile.Text = "Rozpakuj pliki";
            btnUzipFile.UseVisualStyleBackColor = true;
            btnUzipFile.Click += btnUzipFile_Click;
            // 
            // btnChooseZipFile
            // 
            btnChooseZipFile.Location = new Point(37, 52);
            btnChooseZipFile.Name = "btnChooseZipFile";
            btnChooseZipFile.Size = new Size(332, 63);
            btnChooseZipFile.TabIndex = 0;
            btnChooseZipFile.Text = "Wybierz plik .zip ...";
            btnChooseZipFile.UseVisualStyleBackColor = true;
            btnChooseZipFile.Click += btnChooseZipFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 466);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbZipPath;
        private Button btnCopyZipFile;
        private Button btnZipFile;
        private Button btnChooseFolder;
        private GroupBox groupBox2;
        private Label lbUnzipFile;
        private Button btnShowUnzipFiles;
        private Button btnUzipFile;
        private Button btnChooseZipFile;
    }
}