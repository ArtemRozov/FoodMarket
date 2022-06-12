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
            dataGridView1.Rows.Add("Десерт Тірамісу Ді Карамело", "95 (140 грам)");
            dataGridView1.Rows.Add("Десерт Мама Луїза", "109 (160 грам)");
            dataGridView1.Rows.Add("Сирники Італьяно", "85 (150 грам)");
            dataGridView1.Rows.Add("Фіокі Ді Латі з вишневим соусом", "64 (220 грам)");
            dataGridView1.Rows.Add("Десерт Фондан шоколадний", "85 (170 грам)");
            dataGridView1.Rows.Add("Торта Ді Мітріллі", "84 (200 грам)");
            dataGridView1.Rows.Add("Морозиво Домашнє з манго", "40 (50 грам)");
            dataGridView1.Rows.Add("Морозиво Вершково - ванільне", "35 (50 грам)");
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
