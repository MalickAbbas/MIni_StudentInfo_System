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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        string[,] set = new string[12, 5];
        int temp = 0;
        public void getData(string[,] a, int count)
        {
            set[count, 0] = a[count, 0];
            set[count, 1] = a[count, 1];
            set[count, 2] = a[count, 2];
            set[count, 3] = a[count, 3];
            set[count, 4] = a[count, 4];
            temp = count;
            
        }
        public void setlist(int count)
        {
            for (int i = 0; i < count; i++)
            {
               
                listBox1.Items.Add(set[i,0]);

            }
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                textBox1.Text = set[0, 0];
                textBox2.Text = set[0, 1];
                textBox3.Text = set[0, 2];
                textBox4.Text = set[0, 3];
                textBox5.Text = set[0, 4];
            }
            else if (listBox1.SelectedIndex == 1)
            {
                textBox1.Text = set[1, 0];
                textBox2.Text = set[1, 1];
                textBox3.Text = set[1, 2];
                textBox4.Text = set[1, 3];
                textBox5.Text = set[1, 4];
            }
        }
    }
}
