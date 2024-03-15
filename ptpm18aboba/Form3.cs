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
    public partial class Form3 : Form
    {

        Form1 form1;
        public Form3(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если все поля пустые, выводим сообщение
                MessageBox.Show("Все поля должны быть заполнены.");
            }
            else if(!Regex.IsMatch(textBox1.Text, @"^\d+$"))
                {
                    // Если введенный текст не является числом, выводим сообщение
                      MessageBox.Show("Введенное значение в textbox1 не является числом.");
                }
            File.WriteAllText("file1.txt", textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text);

            // Вывод сообщения о успешном сохранении
            MessageBox.Show("Данные успешно сохранены в файл NumberRyes.txt");
        }

        }
}
