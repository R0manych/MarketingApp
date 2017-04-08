using Desktop.Forms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Product
{
    public partial class ViewProductForm : Form
    {
        public ViewProductForm()
        {
            InitializeComponent();
        }

        private bool _isModified;

        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            _isModified = false;
            productsTableAdapter.Fill(marketingAppDataDataSet.Products);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.EndEdit();
                productsTableAdapter.Update(marketingAppDataDataSet.Products);
                MessageBox.Show("Данные обновлены");
                _isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи {ex.Message}");
            }
        }

        private void ViewProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isModified)
            {
                var acceptForm = new AcceptForm("Закрыть без сохранения изменений?");
                acceptForm.ShowDialog();
                e.Cancel = !acceptForm.Accepted;
            }
        }

        private void dataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!_isModified)
                _isModified = true;
        }
    }
}
