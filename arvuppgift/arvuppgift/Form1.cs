using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arvuppgift
{
    public partial class Form1 : Form
    {
        //skapa global objekt
        Cirkel cirkel = null; 
        Rektangel rektangel = null;
        Triangel triangel = null;
        Kvadrat kvadrat = null;

        //skapa global variabler
        double tal1;
        double tal2;

        double tel1;
        double tel2;
        double tel3;

        double kva;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//spara cikel input
        {
            try
            {
                cirkel = new Cirkel(Convert.ToDouble(textBox1.Text));
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)//bärekna cirkel button
        {
            try
            {
                label1.Text = "Area: " + Convert.ToString(cirkel.getArea());
                label2.Text = "Omkrets: " + Convert.ToString(cirkel.getOmkrets());
            } catch//ifall error skriv Not a Number
            {
                label1.Text = "NaN";
                label2.Text = "NaN";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//spara rektangel input
        {
            try
            {
                tal1 = Convert.ToDouble(textBox2.Text);
                
            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//spara rektangel input
        {
            try
            {
                tal2 = Convert.ToDouble(textBox3.Text);
            }
            catch { }
            
        }

        private void button2_Click(object sender, EventArgs e)//bärekna rektangel button
        {
            try
            {
                rektangel = new Rektangel(tal1, tal2);

                label3.Text = "Area: " + Convert.ToString(rektangel.getArea());
                label4.Text = "Omkrets: " + Convert.ToString(rektangel.getOmkrets());
            }
            catch//ifall error skriv Not a Number
            {
                label3.Text = "NaN";
                label4.Text = "NaN";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//spara triangel input
        {
            tel1 = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)//spara triangel input
        {
            tel2 = Convert.ToDouble(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)//spara triangel input
        {
            tel3 = Convert.ToDouble(textBox6.Text);
        }

        private void button3_Click(object sender, EventArgs e)//bärekna triangel button
        {
            try
            {
                triangel = new Triangel(tel1, tel2, tel3);

                label5.Text = "Area: " + Convert.ToString(triangel.getArea());
                label6.Text = "Omkrets: " + Convert.ToString(triangel.getOmkrets());
            }
            catch//ifall error skriv Not a Number
            {
                label5.Text = "NaN";
                label6.Text = "NaN";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)// spara kvadrat input
        {
            kva = Convert.ToDouble(textBox7.Text);
        }

        private void button4_Click(object sender, EventArgs e)//bärekna kvadrat button
        {
            try
            {
                kvadrat = new Kvadrat(kva);

                label7.Text = "Area: " + Convert.ToString(kvadrat.getArea());
                label8.Text = "Omkrets: " + Convert.ToString(kvadrat.getOmkrets());
            }
            catch//ifall error skriv Not a Number
            {
                label7.Text = "NaN";
                label8.Text = "NaN";
            }
        }
    }
}
