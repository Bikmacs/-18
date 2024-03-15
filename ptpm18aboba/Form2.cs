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

namespace ptpm18aboba
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка, не пустые ли все текстовые поля
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text))
            {
                // Если все поля пустые, выводим сообщение
                MessageBox.Show("Все поля должны быть заполнены.");
            }
            else
            {
                // Проверка введенного текста в textbox1
                if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))
                {
                    // Если введенный текст не является числом, выводим сообщение
                    MessageBox.Show("Введенное значение в textbox1 не является числом.");
                }
                else
                {
                    // Проверка введенного текста в textbox2 и textbox3
                    if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(textBox3.Text, @"^[a-zA-Z]+$"))
                    {
                        // Если введенный текст не является буквой, выводим сообщение
                        MessageBox.Show("Введенные значения в textbox2 и textbox3 не являются буквами.");
                    }
                    else
                    {
                        // Проверка введенного текста в textbox4
                        if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))
                        {
                            // Если введенный текст не является числом, выводим сообщение
                            MessageBox.Show("Введенное значение в textbox4 не является числом.");
                        }
                        else
                        {
                            // Если хотя бы одно поле не пустое, выводим сообщение о успешной проверке
                            MessageBox.Show("Данные проверены и введены верно.");
                        }
                    }
                }
            }
            // Сохранение данных из всех текстовых полей в файл
            File.WriteAllText("file1.txt", textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text);

            // Вывод сообщения о успешном сохранении
            MessageBox.Show("Данные успешно сохранены в файл VnutReys.txt");
        }
    }
}
