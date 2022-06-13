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
    public partial class DesertForm : Form
    {
        public DesertForm()
        {
            InitializeComponent();
        }

        private void DesertForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Десерт Тірамісу Ді Карамело (140 грам)", "95");
            dataGridView1.Rows.Add("Десерт Мама Луїза (160 грам)", "109");
            dataGridView1.Rows.Add("Сирники Італьяно (150 грам)", "85");
            dataGridView1.Rows.Add("Фіокі Ді Латі з вишневим соусом (220 грам)", "64");
            dataGridView1.Rows.Add("Десерт Фондан шоколадний (170 грам)", "85");
            dataGridView1.Rows.Add("Торта Ді Мітріллі (200 грам)", "84");
            dataGridView1.Rows.Add("Морозиво Домашнє з манго (50 грам)", "40");
            dataGridView1.Rows.Add("Морозиво Вершково - ванільне (50 грам)", "35");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Hide();

            if (e.RowIndex == 0)
            {
                AddingBasketForm.Src = new LocalBush("Десерт Тірамісу Ді Карамело (140 грам)", 95);
            }

            if (e.RowIndex == 1)
            {
                AddingBasketForm.Src = new LocalBush("Десерт Мама Луїза (160 грам)", 109);

            }

            if (e.RowIndex == 2)
            {
                AddingBasketForm.Src = new LocalBush("Сирники Італьяно (150 грам)", 85);

            }

            if (e.RowIndex == 3)
            {
                AddingBasketForm.Src = new LocalBush("Фіокі Ді Латі з вишневим соусом (220 грам)", 64);

            }

            if (e.RowIndex == 4)
            {
                AddingBasketForm.Src = new LocalBush("Десерт Фондан шоколадний (170 грам)", 85);

            }

            if (e.RowIndex == 5)
            {
                AddingBasketForm.Src = new LocalBush("Торта Ді Мітріллі (200 грам)", 84);

            }

            if (e.RowIndex == 6)
            {
                AddingBasketForm.Src = new LocalBush("Морозиво Домашнє з манго (50 грам)", 40);

            }

            if (e.RowIndex == 7)
            {
                AddingBasketForm.Src = new LocalBush("Морозиво Вершково - ванільне (50 грам)", 35);

            }

            AddingBasketForm addingBasketForm = new AddingBasketForm();
            addingBasketForm.Show();
        }

        private void DesertForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
