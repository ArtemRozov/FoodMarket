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
            dataGridView1.Rows.Add("Кокос", "28 за штуку");
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
