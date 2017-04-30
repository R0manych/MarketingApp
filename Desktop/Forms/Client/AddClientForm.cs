using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Client
{
    public partial class AddClientForm : Form
    {
        IClientService _clientService;

        public AddClientForm()
        {
            InitializeComponent();
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
                _clientService.Add(client);
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
            comboBoxParent.DataSource = names;
        }
    }
}
