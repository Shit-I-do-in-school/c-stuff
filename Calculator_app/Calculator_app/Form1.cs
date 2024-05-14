using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Form1 : Form
    {
        private calculate calc = null;
        public Form1()
        {
            InitializeComponent();
            calc = new calculate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//minus
        {
            string text1 = tal1.Text;
            double n1 = double.Parse(text1);
            string text2 = tal2.Text;
            double n2 = double.Parse(text2);

            double summa = calc.minusa(n1, n2);
            labelSvar.Text = n1 + " - " + n2 + " = " + summa.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string text1 = tal1.Text;
            double n1 = double.Parse(text1);
            string text2 = tal2.Text;
            double n2 = double.Parse(text2);

            double summa = calc.gångra(n1, n2);
            labelSvar.Text = n1 + " x " + n2 + " = " + summa.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string text1 = tal1.Text;
            double n1 = double.Parse(text1);
            string text2 = tal2.Text;
            double n2 = double.Parse(text2);

            double summa = calc.plusa(n1, n2);
            labelSvar.Text = n1 + " + " + n2 + " = " + summa.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string text1 = tal1.Text;
            double n1 = double.Parse(text1);
            string text2 = tal2.Text;
            double n2 = double.Parse(text2);

            double summa = calc.dela(n1, n2);
            labelSvar.Text = n1 + " / " + n2 + " = " + summa.ToString();
        }

        private void tal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tal2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)//laber svart
        {

        }
    }
}
