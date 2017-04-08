using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Common
{
    public partial class AcceptForm : Form
    {
        public AcceptForm()
        {
            InitializeComponent();
            Accepted = false;
        }

        public bool Accepted;

        public AcceptForm(string textMessage)
        {
            InitializeComponent();
            Accepted = false;
            label1.Text = textMessage;      
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Accepted = true;
            Close();
        }
    }
}
