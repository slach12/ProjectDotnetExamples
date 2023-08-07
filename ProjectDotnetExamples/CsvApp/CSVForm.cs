using CsvHelper;
using CsvHelper.Configuration;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace CsvApp
{
    public partial class CSVForm : Form
    {
        private BindingList<Client> _clients = new BindingList<Client>();

        private const string ClientsFileName = "clients.csv";
        public CSVForm()
        {
            InitializeComponent();
            if(!File.Exists(ClientsFileName))
                File.Create(ClientsFileName).Close();


            dgvClients.DataSource = _clients;
        }


        private void ClearData()
        {
            tbEmail.Text = "";
            tbName.Text = "";
            dtpAddedDate.Value = DateTime.Now;
            cbIsConfirmed.Checked = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var clien = new Client()
            {
                Email = tbEmail.Text,
                Name = tbName.Text,
                AddedData = dtpAddedDate.Value,
                IsConfirmed = cbIsConfirmed.Checked

            };

            _clients.Add(clien);
            ClearData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //            using var stream =  File.Open(ClientsFileName, FileMode.Append);
            //            using var writer = new StreamWriter(stream);
            //var configClient = new CsvConfiguration(CultureInfo.InvariantCulture)
            //{
            //    HasHeaderRecord = false
            //};
            //using var csv = new CsvWriter(writer, configClient);
            //csv.WriteRecords(_clients);




            using var writer = new StreamWriter(ClientsFileName);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<ClientMap>();
            csv.WriteRecords(_clients);

        }

        private void CSVForm_Load(object sender, EventArgs e)
        {
            using var reader = new StreamReader(ClientsFileName);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);    
            csv.Context.RegisterClassMap<ClientMap>();
            var clients = csv.GetRecords<Client>().ToList();

            FillTable(clients);
        }

        private void FillTable(IList<Client> clients)
        {
            _clients.Clear();
            if (clients == null || !clients.Any())
                return;

            foreach (var client in clients)
            {
                _clients.Add(client);
            }

        }
    }
}