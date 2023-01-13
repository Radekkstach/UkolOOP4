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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false; panel2.Enabled = false;
        }

        NakladniAuto bejk;
        Tahac bejcek;

        private void button1_Click(object sender, EventArgs e)
        {
            bejk = new NakladniAuto(textBox1.Text,(int)numericUpDown1.Value);
            
            MessageBox.Show(bejk.ToString());
            panel1.Enabled = true;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bejk.NalozNaklad((int)numericUpDown2.Value);
                MessageBox.Show(bejk.ToString());
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bejk.VylozitNaklad((int)numericUpDown3.Value);
                MessageBox.Show(bejk.ToString());
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bejcek = new Tahac(textBox2.Text,(int)numericUpDown4.Value,(int)numericUpDown7.Value);
            MessageBox.Show(bejcek.ToString());
            panel2.Enabled = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                bejcek.NalozNaklad((int)numericUpDown6.Value);
                MessageBox.Show(bejcek.ToString());
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bejcek.VylozitNaklad((int)numericUpDown5.Value);
                MessageBox.Show(bejcek.ToString());
            }
            catch { }
        }
    }
}
