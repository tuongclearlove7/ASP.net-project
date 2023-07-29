using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_chacon
{
    public partial class frm_cha : Form
    {
        public frm_cha()
        {
            InitializeComponent();
        }

        private frm_con con = null;
        private frm_chau chau = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                con = new frm_con();
                con.MdiParent = this;
                con.FormClosed += con_FormClosed;
                con.Show();
            }
            else
            {
                con.Activate();
            }
        }

        private void btn_chau_Click(object sender, EventArgs e)
        {

            if (chau == null)
            {
                chau = new frm_chau();
                chau.MdiParent = this;
                chau.FormClosed += chau_FormClosed;
                chau.Show();
            }
            else
            {
                con.Activate();
            }
        }

        private void con_FormClosed(object sender, FormClosedEventArgs e)
        {
            con = null;
        }

        private void chau_FormClosed(object sender, FormClosedEventArgs e)
        {
            chau = null;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                con = new frm_con();
                con.MdiParent = this;
                con.FormClosed += con_FormClosed;
                con.Show();
            }
            else
            {
                con.Activate();
            }
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            if (chau == null)
            {
                chau = new frm_chau();
                chau.MdiParent = this;
                chau.FormClosed += chau_FormClosed;
                chau.Show();
            }
            else
            {
                con.Activate();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                con = new frm_con();
                con.MdiParent = this;
                con.FormClosed += con_FormClosed;
                con.Show();
            }
            else
            {
                con.Activate();
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (chau == null)
            {
                chau = new frm_chau();
                chau.MdiParent = this;
                chau.FormClosed += chau_FormClosed;
                chau.Show();
            }
            else
            {
                chau.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void frm_cha_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void openFormChauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chau == null)
            {
                chau = new frm_chau();
                chau.MdiParent = this;
                chau.FormClosed += chau_FormClosed;
                chau.Show();
            }
            else
            {
                chau.Activate();
            }
        }

        private void closeFormChauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (chau != null)
            {
                chau.Close();
            }


        }
        private frm_login login = null;

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new frm_login();
                login.MdiParent = this;
                login.FormClosed += chau_FormClosed;
                login.Show();
            }
            else
            {
                login.Activate();
            }
        }
    }
}
