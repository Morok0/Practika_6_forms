using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6_zad_1_forms_1_
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
            int n = Convert.ToInt32(textBox3.Text);
            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rand.Next(-10,10);
            } 
            string str = " ";
            for (int i = 0; i < arr.Length; ++i)
            {
                str += Convert.ToString(arr[i]);
                str += " "+";" + "\r\n";
                
            }
            textBox1.Text = Convert.ToString(str);
            return arr;
        }
        public void Change(int[] arr)
        {
            string str = " ";
            int a = Convert.ToInt32(Box1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= a && arr[i] <= b)
                {
                    arr[i] = 0; 
                }
                 str += Convert.ToString(arr[i]);
                str += " " + ";" + "\r\n";

            }
            textBox5.Text = Convert.ToString(str);
        }

        public int[,] Input2()
        {
            Random rand = new Random();
            string str = " ";
            int n = Convert.ToInt32(textBox7.Text);
            int m= Convert.ToInt32(textBox10.Text);
            int[,] ar = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
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
            textBox4.Text = Convert.ToString(str);
            return ar;
        }
      
        public void Change2(int[,] ar)
        {
            string str = "";
            int a = Convert.ToInt32(textBox9.Text);
            int b = Convert.ToInt32(textBox8.Text);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); ++j)
                {
                    if (ar[i, j] >= a && ar[i, j] <= b)
                        ar[i, j] = 0;
                    str += Convert.ToString(ar[i,j] + " " + "\n");// почему то НЕ выводит пробел в первой строке


                }
                str += " " + " " + "\r\n"; 
            }

            textBox6.Text = Convert.ToString(str);

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int[] myArray = Input();
            Change(myArray);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int[,] myArray2 = Input2();
            Change2(myArray2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; Box1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = ""; textBox8.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox10.Text = ""; textBox4.Text = "";
        }
    }
}
