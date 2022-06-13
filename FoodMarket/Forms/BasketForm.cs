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
    public partial class BasketForm : Form
    {
        public static int Count { get; set; }
        public static string[] Buy { get; set; }
        public static int[] CountTovards { get; set; }
        public BasketForm()
        {
            InitializeComponent();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            int price = 0;

            for(int i = 0; i < AddingBasketForm.SrcForBasket.Count; i++)
            {
                dataGridView1.Rows.Add(AddingBasketForm.SrcForBasket[i].Name, 
                    AddingBasketForm.SrcForBasket[i].Count,
                    AddingBasketForm.SrcForBasket[i].Price);

                price += AddingBasketForm.SrcForBasket[i].Price;
            }

            label2.Text = price.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddingBasketForm.SrcForBasket.Remove(AddingBasketForm.SrcForBasket[e.RowIndex]);
            dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
             

            Buy = new string[AddingBasketForm.SrcForBasket.Count];
            CountTovards = new int[AddingBasketForm.SrcForBasket.Count];

            for (int i = 0; i < Buy.Length; i++)
            {
                Buy[i] = AddingBasketForm.SrcForBasket[i].Name;
                CountTovards[i] = AddingBasketForm.SrcForBasket[i].Count;
            }
           
            Count = int.Parse(label2.Text);

            AddingBasketForm.SrcForBasket.Clear();
            dataGridView1.Rows.Clear();

            CabinetForm.Count++;
            CabinetForm.Price.Add(Count);
            for(int i = 0; i < Buy.Length; i++)
            {
                CabinetForm.Tovards.Add(Buy[i]);
                CabinetForm.CountTovards.Add(CountTovards[i]);
            }

            Hide();
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }

        private void BasketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
