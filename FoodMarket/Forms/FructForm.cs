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
    public partial class FructForm : Form
    {
        public FructForm()
        {
            InitializeComponent();
        }

        private void FructForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Яблуко", "17");
            dataGridView1.Rows.Add("Банан", "45");
            dataGridView1.Rows.Add("Апельсин", "39");
            dataGridView1.Rows.Add("Гранат", "130");
            dataGridView1.Rows.Add("Грейпфрукт", "35");
            dataGridView1.Rows.Add("Киві", "60");
            dataGridView1.Rows.Add("Груша", "20");
            dataGridView1.Rows.Add("Кокос (ціна за штуку)", "28");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           

            Hide();

            if (e.RowIndex == 0)
            {
                AddingBasketForm.Src = new LocalBush("Яблуко", 17);
            }

            if (e.RowIndex == 1)
            {
                AddingBasketForm.Src = new LocalBush("Банан", 45);
            }

            if (e.RowIndex == 2)
            {
                AddingBasketForm.Src = new LocalBush("Апельсин", 39);
            }

            if (e.RowIndex == 3)
            {
                AddingBasketForm.Src = new LocalBush("Гранат", 130);
            }

            if (e.RowIndex == 4)
            {
                AddingBasketForm.Src = new LocalBush("Грейпфрукт", 35);
            }

            if (e.RowIndex == 5)
            {
                AddingBasketForm.Src = new LocalBush("Киві", 60);
            }

            if (e.RowIndex == 6)
            {
                AddingBasketForm.Src = new LocalBush("Груша", 20);

            }

            if (e.RowIndex == 7)
            {
                AddingBasketForm.Src = new LocalBush("Кокос", 28);
            }

            AddingBasketForm addingBasketForm = new AddingBasketForm();
            addingBasketForm.Show();
        }

        private void FructForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
