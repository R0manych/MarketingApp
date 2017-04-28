using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;

namespace Desktop.Forms.Client
{
    public partial class EditClientForm : Form
    {
        private DataContextModel.Models.Client _currentClient;

        IClientService _clientService;

        public EditClientForm()
        {
            InitializeComponent();
        }

        public EditClientForm(DataContextModel.Models.Client client)
        {
            InitializeComponent();
            _currentClient = client;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private bool CheckValidation()
        {
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Поле 'Телефон' не может быть пустым");
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                var client = new DataContextModel.Models.Client()
                {
                    Id = _currentClient.Id,
                    Name = textBoxName.Text,
                    Phone = textBoxPhone.Text,
                    Passport = textBoxPassport.Text,
                    Adress = textBoxAdress.Text,
                    Contract = textBoxContract.Text,
                    BankCard = textBoxBank.Text,
                    Birthday = birthdayPicker.Value,
                    Email = textBoxEmail.Text,
                };
                if (comboBoxParent.Text != " ")
                {
                    client.ParentId = _clientService.GetByName(comboBoxParent.Text).Id;
                }
                else
                {
                    client.ParentId = 0;
                }
                _clientService.Update(client);
                Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            _clientService = new ClientService();
            var names = _clientService.GetNames();
            names.Add(" ");
            names.Remove(_clientService.SetName(_currentClient));
            comboBoxParent.DataSource = names;
            if (_currentClient.ParentId != 0)
            {
                comboBoxParent.SelectedItem = _clientService.SetName(_clientService.GetById(_currentClient.ParentId));
            }
            else
            {
                comboBoxParent.SelectedItem = (" ");
            }
            textBoxAdress.Text = _currentClient.Adress == "" ? "Адрес" : _currentClient.Adress;
            textBoxBank.Text = _currentClient.BankCard == "" ? "Банковская карта" : _currentClient.BankCard;
            birthdayPicker.Value = _currentClient.Birthday == null ? DateTime.Now : _currentClient.Birthday;
            textBoxContract.Text = _currentClient.Contract == "" ? "Договор" : _currentClient.Contract;
            textBoxEmail.Text = _currentClient.Email == "" ? "E-mail" : _currentClient.Email;
            textBoxName.Text = _currentClient.Name == "" ? "ФИО" : _currentClient.Name;
            textBoxPassport.Text = _currentClient.Passport == "Пасспорт" ? "" : _currentClient.Passport;
            textBoxPhone.Text = _currentClient.Phone == "" ? "Телефон" : _currentClient.Phone;
        }
    }
}
