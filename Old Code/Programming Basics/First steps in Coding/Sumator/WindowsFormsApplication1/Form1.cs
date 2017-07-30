using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = decimal.Parse(this.textBox1.Text);
                var num2 = decimal.Parse(this.textBox2.Text);
                var sum = num1 + num2;
                textBoxSum.Text = sum.ToString();
            }
            catch
            {
                textBoxSum.Text = "Error";
            }
        }
    }
}
