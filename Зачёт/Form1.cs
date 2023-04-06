using System.Data;
using System.Text.RegularExpressions;

namespace Зачёт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] glasn = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            string str = textBox1.Text;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glasn.Length; j++)
                {
                    if (glasn[j] == str[i]) 
                    {
                        count++;
                    }
                }
            }
            textBox2.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}