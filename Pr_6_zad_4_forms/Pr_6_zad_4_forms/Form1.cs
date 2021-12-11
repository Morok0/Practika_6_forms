using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6_zad_4_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            string str1 = " ";
            string str2 = " ";
            Random rnd = new Random();
            int n = 0, k = 0;
            k = Convert.ToInt32(textBox1.Text);
            n = Convert.ToInt32(textBox2.Text);
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
                a[i] = new int[k];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                {
                    a[i][j] = rnd.Next(0, 10);
                    str += Convert.ToString(a[i][j]);
                    str += "\r\n";
                }
                str += "\r\n";

            }
            textBox3.Text = Convert.ToString(str);
            int[] X = new int[k];
            for (int i = 0; i < k; i++)
            {
                str1 += Convert.ToString(X[i] = rnd.Next(0, 10));
                str1 += "\r\n";

            }
            textBox5.Text = Convert.ToString(str1);

            for (int i = 1; i < a.Length; i += 2)
            {
                a[i] = X;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    str2 += Convert.ToString(a[i][j]);
                    str2 += "\r\n";
                }
                str2 += "\r\n";
            }
            textBox4.Text = Convert.ToString(str2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
        }
    }
}
