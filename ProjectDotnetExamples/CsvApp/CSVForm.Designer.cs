namespace CsvApp
{
    partial class CSVForm
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
            tbEmail = new TextBox();
            lbEmail = new Label();
            lbName = new Label();
            tbName = new TextBox();
            dgvClients = new DataGridView();
            lbAddedDate = new Label();
            dtpAddedDate = new DateTimePicker();
            cbIsConfirmed = new CheckBox();
            btnAdd = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 45);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 0;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 22);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(101, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Adres e-mail :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 90);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Imię:";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 113);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 2;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(204, 12);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.Height = 29;
            dgvClients.Size = new Size(584, 426);
            dgvClients.TabIndex = 4;
            // 
            // lbAddedDate
            // 
            lbAddedDate.AutoSize = true;
            lbAddedDate.Location = new Point(12, 181);
            lbAddedDate.Name = "lbAddedDate";
            lbAddedDate.Size = new Size(103, 20);
            lbAddedDate.TabIndex = 5;
            lbAddedDate.Text = "Data dodania:";
            // 
            // dtpAddedDate
            // 
            dtpAddedDate.Location = new Point(12, 204);
            dtpAddedDate.Name = "dtpAddedDate";
            dtpAddedDate.Size = new Size(125, 27);
            dtpAddedDate.TabIndex = 6;
            // 
            // cbIsConfirmed
            // 
            cbIsConfirmed.AutoSize = true;
            cbIsConfirmed.Location = new Point(12, 258);
            cbIsConfirmed.Name = "cbIsConfirmed";
            cbIsConfirmed.Size = new Size(160, 24);
            cbIsConfirmed.TabIndex = 7;
            cbIsConfirmed.Text = "Czy potwierdzony ?";
            cbIsConfirmed.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Dodaj klienta";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Zapisz dane";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CSVForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(cbIsConfirmed);
            Controls.Add(dtpAddedDate);
            Controls.Add(lbAddedDate);
            Controls.Add(dgvClients);
            Controls.Add(lbName);
            Controls.Add(tbName);
            Controls.Add(lbEmail);
            Controls.Add(tbEmail);
            Name = "CSVForm";
            Text = "Form1";
            Load += CSVForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private Label lbEmail;
        private Label lbName;
        private TextBox tbName;
        private DataGridView dgvClients;
        private Label lbAddedDate;
        private DateTimePicker dtpAddedDate;
        private CheckBox cbIsConfirmed;
        private Button btnAdd;
        private Button btnSave;
    }
}