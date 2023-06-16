namespace FileApp
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
            btnSave = new Button();
            tbFileName = new TextBox();
            rtbContent = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btnRead = new Button();
            btnDelete = new Button();
            btnCopy = new Button();
            lbUserInfo = new Label();
            tbUserName = new TextBox();
            btnUserNameSave = new Button();
            lbUserName = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 53);
            btnSave.TabIndex = 0;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(52, 79);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(210, 27);
            tbFileName.TabIndex = 1;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(268, 79);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(520, 363);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Nazwa Pliku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 56);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Zawartość Pliku";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(52, 171);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(210, 53);
            btnRead.TabIndex = 5;
            btnRead.Text = "Wczytaj";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(52, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 53);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Usuń plik";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(52, 289);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(210, 53);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Kopiuj plik";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lbUserInfo
            // 
            lbUserInfo.AutoSize = true;
            lbUserInfo.Location = new Point(268, 451);
            lbUserInfo.Name = "lbUserInfo";
            lbUserInfo.Size = new Size(54, 20);
            lbUserInfo.TabIndex = 8;
            lbUserInfo.Text = "Nazwa";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(363, 448);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(249, 27);
            tbUserName.TabIndex = 9;
            // 
            // btnUserNameSave
            // 
            btnUserNameSave.Location = new Point(618, 448);
            btnUserNameSave.Name = "btnUserNameSave";
            btnUserNameSave.Size = new Size(170, 27);
            btnUserNameSave.TabIndex = 10;
            btnUserNameSave.Text = "Zapsi";
            btnUserNameSave.UseVisualStyleBackColor = true;
            btnUserNameSave.Click += btnUserNameSave_Click;
            // 
            // lbUserName
            // 
            lbUserName.Location = new Point(387, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(401, 28);
            lbUserName.TabIndex = 11;
            lbUserName.Text = " ";
            lbUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(lbUserName);
            Controls.Add(btnUserNameSave);
            Controls.Add(tbUserName);
            Controls.Add(lbUserInfo);
            Controls.Add(btnCopy);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbContent);
            Controls.Add(tbFileName);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox tbFileName;
        private RichTextBox rtbContent;
        private Label label1;
        private Label label2;
        private Button btnRead;
        private Button btnDelete;
        private Button btnCopy;
        private Label lbUserInfo;
        private TextBox tbUserName;
        private Button btnUserNameSave;
        private Label lbUserName;
    }
}