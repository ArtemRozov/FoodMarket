using FoodMarket.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMarket
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            CatalogGrid.Rows.Add("Фрукти");
            CatalogGrid.Rows.Add("Овочі");
            CatalogGrid.Rows.Add("Десерти");
            CatalogGrid.Rows.Add("Напої");

        }

        private void CatalogGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                FructForm fructForm = new FructForm();
                fructForm.Show();
            }

            if (e.RowIndex == 1)
            {
                VegetableForm vegetableForm = new VegetableForm();
                vegetableForm.Show();
            }

            if (e.RowIndex == 2)
            {
                DesertForm desertForm = new DesertForm();
                desertForm.Show();
            }

            if (e.RowIndex == 3)
            {
                DrinkForm drinkForm = new DrinkForm();
                drinkForm.Show();
            }
        }
    }
}
