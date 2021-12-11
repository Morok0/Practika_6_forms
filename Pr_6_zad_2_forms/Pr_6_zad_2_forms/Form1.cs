using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6_zad_2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Input()
        {
            Random rand = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rand.Next(-10, 10);
            }
            string str = " ";
            for (int i = 0; i < arr.Length; ++i)
            {
                str += Convert.ToString(arr[i]);
                str += " " + "\r\n";

            }
            textBox2.Text = Convert.ToString(str);
            return arr;
        }
        public void Change(int[] arr)
        {
            string str = " ";
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == temp)
                {
                    arr[i] = 0;
                } 
                str += Convert.ToString(arr[i]);
                str += " " + "\r\n";
            }
           
            textBox3.Text = Convert.ToString(str);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[] myArray = Input();
            Change(myArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }
    }
}
