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
    public partial class CabinetForm : Form
    {
        public static int Count { get; set; } = 0;
        public static List<int> Price { get; set; } = new List<int>();
        public static List<string> Tovards { get; set; } = new List<string>();
        public static List<int> CountTovards { get; set; } = new List<int>();
        public CabinetForm()
        {
            InitializeComponent();
        }

        private void CabinetForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, Price[i]);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Hide();
            CabinetInfo cabinetInfo = new CabinetInfo();
            cabinetInfo.Show();
        }

        private void CabinetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
