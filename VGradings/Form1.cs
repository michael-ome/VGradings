using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGradings
{
    public partial class Form1 : Form
    {
        int age;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to the short examination program.\n\nPlease Enter your age in the textbox below.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32(textBox1.Text);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + Convert.ToString(age);
            //label1.Text = label1.Text + Convert.ToString(age);
            //textBox1.Text = "";
        }
        
            
        
    }
}
