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
    public partial class App : Form
    {

        int i = 0;
        public App()
        {
            InitializeComponent();
            showLabel();
        }

        void showLabel()
        {
            Label lb = new Label();
            lb.Text = "TuongClearlove7";
            this.Controls.Add(lb);
        }

        private void button_Click_1(object sender, EventArgs e)
        {

            //hien thi 1 window form khac
            App2 f2 = new App2();
            f2.Show();
            f2.label1.Text = "Count : " + i;
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hienthi = "Count " + i;
            MessageBox.Show(hienthi);
            //Biến i sẽ tăng khi click vào cả 2 button 
            //2 button event đều sử dụng 1 biến đếm i
            i++;
        }

        private void label_Click_1(object sender, EventArgs e)
        {
            //click vào label sẽ đổi chữ
            label.Text = "App";
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
