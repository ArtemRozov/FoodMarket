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
    public partial class DrinkForm : Form
    {
        public DrinkForm()
        {
            InitializeComponent();
        }

        private void DrinkForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("МОХІТО", "65");
            dataGridView1.Rows.Add("СМУЗІ БАНАНОВО - МИГДАЛЬНИЙ", "59");
            dataGridView1.Rows.Add("СМУЗІ ЧІА - МАНГО", "59");
            dataGridView1.Rows.Add("МІЛК - ШЕЙК БАНАНОВИЙ", "55");
            dataGridView1.Rows.Add("МІЛК - ШЕЙК ПОЛУНИЧНИЙ", "55");
            dataGridView1.Rows.Add("МІЛК - ШЕЙК ШОКОЛАДНИЙ", "55");
            dataGridView1.Rows.Add("ЛИМОНАД БАЗИЛІК", "45");
            dataGridView1.Rows.Add("ЛИМОНАД МАЛИНА-РОМАШКА", "38");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Hide();

            if (e.RowIndex == 0)
            {
                AddingBasketForm.Src = new LocalBush("МОХІТО", 65);                
            }

            if (e.RowIndex == 1)
            {
                AddingBasketForm.Src = new LocalBush("СМУЗІ БАНАНОВО - МИГДАЛЬНИЙ", 59);
            }

            if (e.RowIndex == 2)
            {
                AddingBasketForm.Src = new LocalBush("СМУЗІ ЧІА - МАНГО", 59);
            }

            if (e.RowIndex == 3)
            {
                AddingBasketForm.Src = new LocalBush("МІЛК - ШЕЙК БАНАНОВИЙ", 55);
            }

            if (e.RowIndex == 4)
            {
                AddingBasketForm.Src = new LocalBush("МІЛК - ШЕЙК ПОЛУНИЧНИЙ", 55);
            }

            if (e.RowIndex == 5)
            {
                AddingBasketForm.Src = new LocalBush("МІЛК - ШЕЙК ШОКОЛАДНИЙ", 55);
            }

            if (e.RowIndex == 6)
            {
                AddingBasketForm.Src = new LocalBush("ЛИМОНАД БАЗИЛІК", 45);
            }

            if (e.RowIndex == 7)
            {
                AddingBasketForm.Src = new LocalBush("ЛИМОНАД МАЛИНА-РОМАШКА", 38);
            }

            AddingBasketForm addingBasketForm = new AddingBasketForm();
            addingBasketForm.Show();
        }

        private void DrinkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
