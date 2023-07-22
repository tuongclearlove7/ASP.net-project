using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class App2 : Form
    {
        int i = 0;
        public App2()
        {
            InitializeComponent();
            //label1.Text = "Count : " + i;
            //i++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_soA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_total_Click(object sender, EventArgs e)
        {

            try
            {
                int a = Convert.ToInt32(txt_soA.Text);
                int b = Convert.ToInt32(txt_soB.Text);

                txt_ketqua.Text = (a + b).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập k đúng định dạng");
            }
           


        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt_soA.Text);
                int b = Convert.ToInt32(txt_soB.Text);

                txt_ketqua.Text = (a - b).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập k đúng định dạng");
            }
        }

        private void txt_soB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
