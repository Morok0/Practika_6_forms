using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6_zad_3_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] Input2( int n)
        {
            Random rand = new Random();
            string str = " ";
            
            int[,] ar = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    ar[i, j] = rand.Next(-10, 10);
                }
            for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    str += Convert.ToString(ar[i, j] + " " + "\n");//почему то выводит пробел в первой строке

                }
                str += " " + " " + "\r\n";//более адыкватного вывода в матрицу не придумал

            }
            textBox2.Text = Convert.ToString(str);
            return ar;
        }

        public void Change2(int[,] ar,int n)
        {
            double sum=0;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); ++j)
                {
                    if (i + j == n - 1)
                    {
                        sum += ar[i, j];
                    }
                }
            }

            textBox3.Text = Convert.ToString(sum);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(textBox1.Text);
            int[,] myArray2 = Input2( n);
            Change2(myArray2, n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = ""; textBox2.Text = ""; textBox1.Text = "";
        }
    }
}
