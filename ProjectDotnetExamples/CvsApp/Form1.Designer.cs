namespace CvsApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpAddedDate = new System.Windows.Forms.DateTimePicker();
            this.lbAddedDate = new System.Windows.Forms.Label();
            this.cbIsConfirmed = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(27, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(24, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Imię:";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(24, 14);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(89, 16);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Adres e-mail :";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(26, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 22);
            this.tbEmail.TabIndex = 2;
            // 
            // dtpAddedDate
            // 
            this.dtpAddedDate.Location = new System.Drawing.Point(26, 150);
            this.dtpAddedDate.Name = "dtpAddedDate";
            this.dtpAddedDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAddedDate.TabIndex = 4;
            // 
            // lbAddedDate
            // 
            this.lbAddedDate.AutoSize = true;
            this.lbAddedDate.Location = new System.Drawing.Point(24, 131);
            this.lbAddedDate.Name = "lbAddedDate";
            this.lbAddedDate.Size = new System.Drawing.Size(92, 16);
            this.lbAddedDate.TabIndex = 5;
            this.lbAddedDate.Text = "Data dodania:";
            // 
            // cbIsConfirmed
            // 
            this.cbIsConfirmed.AutoSize = true;
            this.cbIsConfirmed.Location = new System.Drawing.Point(31, 209);
            this.cbIsConfirmed.Name = "cbIsConfirmed";
            this.cbIsConfirmed.Size = new System.Drawing.Size(143, 20);
            this.cbIsConfirmed.TabIndex = 6;
            this.cbIsConfirmed.Text = "Czy potwierdzony ?";
            this.cbIsConfirmed.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj klienta";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz dane";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(295, 12);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(493, 426);
            this.dgvClients.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbIsConfirmed);
            this.Controls.Add(this.lbAddedDate);
            this.Controls.Add(this.dtpAddedDate);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpAddedDate;
        private System.Windows.Forms.Label lbAddedDate;
        private System.Windows.Forms.CheckBox cbIsConfirmed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}

