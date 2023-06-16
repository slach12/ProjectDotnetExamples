namespace ShopApp
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
            lbName = new Label();
            lbAmount = new Label();
            tbName = new TextBox();
            nudAmount = new NumericUpDown();
            btAdd = new Button();
            dgvShoping = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShoping).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 17);
            lbName.Name = "lbName";
            lbName.Size = new Size(54, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Nazwa";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Location = new Point(12, 87);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(50, 20);
            lbAmount.TabIndex = 1;
            lbAmount.Text = "Kwota";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 40);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 27);
            tbName.TabIndex = 2;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(12, 110);
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(150, 27);
            nudAmount.TabIndex = 3;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(12, 189);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(150, 29);
            btAdd.TabIndex = 4;
            btAdd.Text = "Dodaj";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // dgvShoping
            // 
            dgvShoping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoping.Location = new Point(178, 40);
            dgvShoping.Name = "dgvShoping";
            dgvShoping.RowHeadersWidth = 51;
            dgvShoping.RowTemplate.Height = 29;
            dgvShoping.Size = new Size(610, 360);
            dgvShoping.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvShoping);
            Controls.Add(btAdd);
            Controls.Add(nudAmount);
            Controls.Add(tbName);
            Controls.Add(lbAmount);
            Controls.Add(lbName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShoping).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbAmount;
        private TextBox tbName;
        private NumericUpDown nudAmount;
        private Button btAdd;
        private DataGridView dgvShoping;
    }
}