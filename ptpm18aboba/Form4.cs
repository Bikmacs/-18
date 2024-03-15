using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ptpm18aboba
{
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если все поля пустые, выводим сообщение
                MessageBox.Show("Все поля должны быть заполнены.");
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                // Если введенный текст не является числом, выводим сообщение
                MessageBox.Show("Введенное значение в textbox1 не является числом.");
            }
            if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))
            {
                // Если введенный текст не является буквой, выводим сообщение
                MessageBox.Show("Введенные значения в textbox2 и textbox3 не являются буквами.");
            }

            File.WriteAllText("file1.txt", textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine);
            
            // Вывод сообщения о успешном сохранении
            MessageBox.Show("Данные успешно сохранены в файл VnutReys.txt");
        }
    }
}
