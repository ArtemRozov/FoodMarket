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
    public partial class AddingBasketForm : Form
    {
        public static LocalBush Src { get; set; }
        public static List<LocalBush> SrcForBasket { get; set; } = new List<LocalBush>();
        public AddingBasketForm()
        {
            InitializeComponent();
        }

        private void AddingBasketForm_Load(object sender, EventArgs e)
        {
            label2.Text = Src.Name;
            label7.Text = Src.Price.ToString();
            label6.Text = Src.Price + " грн";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label6.Text = (Int32.Parse(Src.Price.ToString()) * Int32.Parse(textBox1.Text)).ToString() + " грн";
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {            
            int lngth = label6.Text.Length;
            SrcForBasket.Add(new LocalBush(Src.Name, Int32.Parse(label6.Text.Substring(0, lngth - 4)), Int32.Parse(textBox1.Text)));
            Hide();
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }

        private void AddingBasketForm_FormClosing(object sender, FormClosingEventArgs e)
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
