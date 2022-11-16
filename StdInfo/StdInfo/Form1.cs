using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] get =new string[12,5];
        int count = 0;
        Form2 test = new Form2();
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Fill all the Fields");
                reset();
            }
            else
            {
                if (count < 15)
                {
                    get[count, 0] = textBox1.Text;
                    get[count, 1] = textBox2.Text;
                    get[count, 2] = textBox3.Text;
                    get[count, 3] = textBox4.Text;
                    get[count, 4] = textBox5.Text;
                    test.getData(get, count);
                    count++;
                    MessageBox.Show("Added Succesfully");
                    reset();
                }
                else
                {
                    MessageBox.Show("Out Of Bound");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            test.setlist(count);
            test.Show();   
        }
    }
}
