using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифр_перестановки
{
    public partial class Form1 : Form
    {
        shifr a;
        public Form1()
        {
            InitializeComponent();

            a = new shifr();

            saveFileDialog1.Filter = "Text files (*.txt |*.txt |All files(*.*) | *.*";
            openFileDialog1.Filter = "Text files (*.txt |*.txt |All files(*.*) | *.*";
        }

        private void button2_Click(object sender, EventArgs e)// Кнопка збереження файлу
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;     
            System.IO.File.WriteAllText(filename, textBox1.Text + "\n" + textBox2.Text);
            MessageBox.Show("Файл успішно збережений!"); ;
        }

        private void button3_Click(object sender, EventArgs e)//Кнопка завантаження файлу
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; 
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл успішно відкритий!");
        }
        private void button1_Click(object sender, EventArgs e)// Кнопка закриття
        {
            Close();
        }
        private void button4_Click(object sender, EventArgs e)// Кнопка виконання програми
        {
            a.SetKey(textBox3.Text);
            if (radioButton1.Checked)
                textBox2.Text = a.Encrypt(textBox1.Text);
            else
                textBox2.Text = a.Decrypt(textBox1.Text);
        }
    }
}
