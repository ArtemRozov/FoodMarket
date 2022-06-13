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
    public partial class CabinetInfo : Form
    {
        public CabinetInfo()
        {
            InitializeComponent();
        }

        private void CabinetInfo_Load(object sender, EventArgs e)
        {
            string tmp = "";
            for(int i = 0; i < CabinetForm.Tovards.Count; i++)
            {
                tmp += CabinetForm.Tovards[i] + " - " + CabinetForm.CountTovards[i] + '\n';
            }
            CabinetForm.Tovards.Clear();
            CabinetForm.CountTovards.Clear();
            label1.Text = tmp;
        }

        private void CabinetInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            CabinetForm cabinetForm = new CabinetForm();
            cabinetForm.Show();
        }
    }
}
