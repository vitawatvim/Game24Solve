using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = 7.ToString();
            button3.Text = 5.ToString();
            button4.Text = 5.ToString();
            label1.Text = 5.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += 5;
            button2.Enabled = false;
            button3.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += 5;
            button3.Enabled = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += 5;
            button4.Enabled = false;
            button3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (count > 0)
            {
                button5.Enabled = false;
                
            }
            label1.Text += button5.Text;
            count++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UNDO_Click(object sender, EventArgs e)
        {
            
        }
    }
}
