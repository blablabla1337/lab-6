using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Работа Андрея Орехова
           До обработчиков кнопок */
        public static string[] Rim = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I", " " };
        public static int[] Des = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1, 0 };
        public static int Max = Rim.Length;
        public string des_rim(int N)
        {
            string s = ""; int i = 0;
            while (N > 0)
            {
                while (Des[i] <= N) { s += Rim[i]; N -= Des[i]; }
                i++;
            }
            return s;
        }
        public int rim_des(string Y)
        {
            int i = 0; int A = 0;
            while ((Y.Length != 0) && (i < Max))
            {
                while (Rim[i] == Y.Substring(0, (Rim[i].Length > Y.Length ? Y.Length : Rim[i].Length)))
                { Y = Y.Substring(0 + Rim[i].Length); A += Des[i]; }
                i++;
            }
            return A;
        }
        // Работа Андрея Медведева
        private void button1_Click(object sender, EventArgs e) 
        {
            int inp = Convert.ToInt32(textBox1.Text);
            if (inp <= 5999) { textBox2.Text = des_rim(inp); } 
            else { Form f = new Form2(); f.Show(); }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string chislo = textBox1.Text;
            for (int i = 0; i < chislo.Length; i++)
            {
                if (chislo[i] == 'I' || chislo[i] == 'V' || chislo[i] == 'X' || chislo[i] == 'L' || chislo[i] == 'C' || chislo[i] == 'D' || chislo[i] == 'M')
                { textBox2.Text = Convert.ToString(rim_des(chislo)); }
                else { Form f1 = new Form3(); f1.Show(); break; }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        { textBox1.Text += "I"; }
        private void button4_Click(object sender, EventArgs e)
        { textBox1.Text += "V"; }
        private void button5_Click(object sender, EventArgs e)
        { textBox1.Text += "X"; }
        private void button6_Click(object sender, EventArgs e)
        { textBox1.Text += "L"; }
        private void button7_Click(object sender, EventArgs e)
        { textBox1.Text += "C"; }
        private void button8_Click(object sender, EventArgs e)
        { textBox1.Text += "D"; }
        private void button9_Click(object sender, EventArgs e)
        { textBox1.Text += "M"; }
    }
}