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
            ((TextBox)sender).Text = "";
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
                var cient = new DataContextModel.Models.Client()
                {
                    Name = textBoxName.Text,
                    Phone = textBoxPhone.Text,
                    Passport = textBoxPassport.Text,
                    Adress = textBoxAdress.Text,
                    Contract = textBoxContract.Text,
                    BankCard = textBoxBank.Text,
                    Birthday = birthdayPicker.Value,
                    Email = textBoxEmail.Text,
                    ParentId = _clientService.GetByName(comboBoxParent.Text).Id
                };
                _clientService.Update(cient);
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
            comboBoxParent.Items.Add(_clientService.GetNames());
            if (_currentClient.Parent != null)
                comboBoxParent.SelectedItem = _clientService.SetName(_currentClient.Parent);
            textBoxAdress.Text = _currentClient.Adress;
            textBoxBank.Text = _currentClient.BankCard;
            birthdayPicker.Value = _currentClient.Birthday;
            textBoxContract.Text = _currentClient.Contract;
            textBoxEmail.Text = _currentClient.Email;
            textBoxName.Text = _currentClient.Name;
            textBoxPassport.Text = _currentClient.Passport;
            textBoxPhone.Text = _currentClient.Phone;
        }
    }
}
