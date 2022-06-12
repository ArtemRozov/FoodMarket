using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMarket.Forms
{
    public partial class VegetableForm : Form
    {
        public VegetableForm()
        {
            InitializeComponent();
        }

        private void VegetableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Капуста", "27");
            dataGridView1.Rows.Add("Баклажан", "90");
            dataGridView1.Rows.Add("Буряк", "25");
            dataGridView1.Rows.Add("Кабачки", "55");
            dataGridView1.Rows.Add("Картопля", "16");
            dataGridView1.Rows.Add("Помідор", "50");
            dataGridView1.Rows.Add("Огірок", "34");
            dataGridView1.Rows.Add("Броколі", "60");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 1)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 2)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 3)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 4)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 5)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 6)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }

            if (e.RowIndex == 7)
            {
                AddingBasketForm addingBasketForm = new AddingBasketForm();
                addingBasketForm.Show();
            }
        }
    }
}
