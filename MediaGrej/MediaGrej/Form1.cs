using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaGrej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bok.Load();
            Film.Load();
        }

        Bok Bok = new Bok();
        Film Film = new Film();

        bool IsAlla = false;
        bool IsBok = false;
        bool IsFilm = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IsAlla = true;
            IsBok = false;
            IsFilm = false;
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IsAlla = false;
            IsBok = true;
            IsFilm = false;
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//add bok
        {
            Bok.AddToList(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)//add film
        {
            Film.AddToList(textBox4.Text, textBox3.Text, Convert.ToInt32(numericUpDown2.Value));
            
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//listbox
        {
            try
            {
                listBox1.Items.Clear();
                if (IsAlla)
                {
                    foreach (string item in Bok.media)
                    {
                        if (item.Contains("(bok"))
                        {
                            listBox1.Items.Add(item);
                        }
                    }

                    foreach (string item in Film.media)
                    {
                        if (item.Contains("(film"))
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                if (IsBok)
                {
                    foreach (string item in Bok.media)
                    {
                        if (item.Contains("(bok"))
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                if (IsFilm)
                {
                    foreach (string item in Film.media)
                    {
                        if (item.Contains("(film"))
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
            }
            catch { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            IsAlla = false;
            IsBok = false;
            IsFilm = true;
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)//save button
        {
            Bok.Save();
            Film.Save();
        }
    }
}
