using Newtonsoft.Json;
using ShopApp.Models;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ShopApp
{
    public partial class Form1 : Form
    {

        private BindingList<Purchase> _purchases = new BindingList<Purchase>();
        private string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");


        public Form1()
        {
            InitializeComponent();

            CreateDataFile();

            GetData();

            dgvShoping.DataSource = _purchases;
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _purchases = JsonConvert.DeserializeObject<BindingList<Purchase>>(json);

            if ( _purchases == null || ! _purchases.Any()) {
                _purchases = new BindingList<Purchase>();
            }
        }

        private void CreateDataFile()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Dispose();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddPurchase();

            SaveData();

            ClearFields();
        }

        private void ClearFields()
        {
            tbName.Text = "";
            nudAmount.Value = 0;
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_purchases);
            File.WriteAllText(_filePath, json);
        }

        private void AddPurchase()
        {
            var purchase = new Purchase
            {
                Amount = nudAmount.Value,
                Name = tbName.Text,
                CreatedDate = DateTime.UtcNow,
            };
            _purchases.Add(purchase);
        }
    }
}