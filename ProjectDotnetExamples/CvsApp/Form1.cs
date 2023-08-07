using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvsApp
{
    public partial class Form1 : Form
    {

        private BindingList<Client> _clients = new BindingList<Client>();
        public Form1()
        {
            InitializeComponent();

            dgvClients.DataSource = _clients;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var clien = new Client() {
                Email = tbEmail.Text,
                Name = tbName.Text,
                AddedData = dtpAddedDate.Value,
                IsConfirmed = cbIsConfirmed.Checked

            };

            _clients.Add(clien);
            ClearData();
        }

        private void ClearData()
        {
            tbEmail.Text = "";
            tbName.Text = "";
            dtpAddedDate.Value = DateTime.Now;
            cbIsConfirmed.Checked = false;


        }
    }
}
