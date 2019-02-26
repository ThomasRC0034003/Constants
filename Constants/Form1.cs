using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//            double pi = 3.14159253589793;
            double c = 29972458;
//            richTextBox1.AppendText(pi.ToString("N3") + "\n");
  //          richTextBox1.AppendText(pi.ToString("N5") + "\n");
  //          richTextBox1.AppendText(pi.ToString("N15") + "\n");
            richTextBox1.AppendText(c.ToString() + "\n");
   //         richTextBox1.AppendText(pi.ToString("0") + "\n");
            richTextBox1.AppendText(c.ToString("N3") + "\n");
            richTextBox1.AppendText(c.ToString("0.0000000000000000E00") + "\n");
            string s = "3";
            string pi = "3.141592";
            int i = int.Parse(s);
            double d = double.Parse(pi);
            string s2 = "3.2";
            try
            {
                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
                int i2 = 0;
            }
            

            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
                richTextBox1.AppendText(d2.ToString() + "\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
