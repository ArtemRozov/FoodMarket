using FoodMarket.Scripts;
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
            Hide();
            if (e.RowIndex == 0)
            {
                AddingBasketForm.Src = new LocalBush("Капуста", 27);
            }

            if (e.RowIndex == 1)
            {
                AddingBasketForm.Src = new LocalBush("Баклажан", 90);
            }

            if (e.RowIndex == 2)
            {
                AddingBasketForm.Src = new LocalBush("Буряк", 25);
            }

            if (e.RowIndex == 3)
            {
                AddingBasketForm.Src = new LocalBush("Кабачки", 55);
            }

            if (e.RowIndex == 4)
            {
                AddingBasketForm.Src = new LocalBush("Картопля", 16);
            }

            if (e.RowIndex == 5)
            {
                AddingBasketForm.Src = new LocalBush("Помідор", 50);
            }

            if (e.RowIndex == 6)
            {
                AddingBasketForm.Src = new LocalBush("Огірок", 34);
            }

            if (e.RowIndex == 7)
            {
                AddingBasketForm.Src = new LocalBush("Броколі", 60);
            }

            AddingBasketForm addingBasketForm = new AddingBasketForm();
            addingBasketForm.Show();
        }

        private void VegetableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
