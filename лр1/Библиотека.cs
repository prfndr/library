using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр1
{
    public partial class Библиотека : Form
    {
        public string[][] books = new string[100000][];
        public string path = @"D:\Рабочий стол\субд\1 семак\лр1\lib.txt";
        public int x = 0;
        public int i = 0;


        public Библиотека()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    books[i] = line.Split('|');
                    listBox1.Items.Add(books[i][0]);
                    i++;
                }
            }
        }


        public static object ListBox1 { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string data;
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (maskedTextBox4.Text != ""))
            {
                data = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + maskedTextBox1.Text + "|" + maskedTextBox2.Text + "|" + maskedTextBox3.Text + "|" + comboBox2.Text + "|" + comboBox3.Text + "|" + maskedTextBox4.Text + "|" + maskedTextBox5.Text + "|" + textBox12.Text;
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(Convert.ToString(data));
                    }
                    listBox1.Items.Clear();
                }
                catch
                {
                    MessageBox.Show("Файл занят!");
                }
                i = 0;
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        books[i] = line.Split('|');
                        listBox1.Items.Add(books[i][0]);
                        i++;
                    }
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                textBox12.Clear();
            }
            else 
                MessageBox.Show("Заполните поля");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y;
            y = listBox1.SelectedIndex;
            books[y][0] = textBox1.Text;
            books[y][1] = textBox2.Text;
            books[y][2] = textBox3.Text;
            books[y][3] = maskedTextBox1.Text;
            books[y][4] = maskedTextBox2.Text;
            books[y][5] = maskedTextBox3.Text;
            books[y][6] = comboBox2.Text;
            books[y][7] = comboBox3.Text;
            books[y][8] = maskedTextBox4.Text;
            books[y][9] = maskedTextBox5.Text;
            books[y][10] = textBox12.Text;
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int o = 0; o < i; o++)
                    {
                        for (int p = 0; p < books[o].Length; p++)
                        {
                            if (p == 9)
                                sw.Write(books[o][p]);
                            else
                                sw.Write(books[o][p] + "|");
                        }
                        sw.Write("\n");
                    }
                }
                listBox1.Items.Clear();
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        books[i] = line.Split('|');
                        listBox1.Items.Add(books[i][0]);
                    }
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                textBox12.Clear();
            }
            catch
            {
                MessageBox.Show("Файл занят!");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            textBox1.Text = books[i][0];
            textBox2.Text = books[i][1];
            textBox3.Text = books[i][2];
            maskedTextBox1.Text = books[i][3];
            maskedTextBox2.Text = books[i][4];
            maskedTextBox3.Text = books[i][5];
            comboBox2.Text = books[i][6];
            comboBox3.Text = books[i][7];
            maskedTextBox4.Text = books[i][8];
            maskedTextBox5.Text = books[i][9];
            textBox12.Text = books[i][10];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "по названию")
                x = 0;
            else if (comboBox1.Text == "по автору")
                x = 1;
            else if (comboBox1.Text == "по жанру")
                x = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = false;
            string s1 = textBox11.Text;
            listBox2.Items.Clear();
            for (int o = 0; o < i; o++)
            {
                string s2 = Convert.ToString(books[o][x]);
                if (s2.ToLower().Contains(s1.ToLower())) 
                {
                    listBox2.Items.Add(books[o][0]);
                    check = true;
                }
            }
            if (check == false)
            {
                MessageBox.Show("Поиск не дал результатов.");
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i;
            i = listBox2.SelectedIndex;
            textBox1.Text = books[i][0];
            textBox2.Text = books[i][1];
            textBox3.Text = books[i][2];
            maskedTextBox1.Text = books[i][3];
            maskedTextBox2.Text = books[i][4];
            maskedTextBox3.Text = books[i][5];
            comboBox2.Text = books[i][6];
            comboBox3.Text = books[i][7];
            maskedTextBox4.Text = books[i][8];
            maskedTextBox5.Text = books[i][9];
            textBox12.Text = books[i][10];
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            for (int o = 0; o < i; o++)
            {
                for (int p = 0; p < books[o].Length - 1; p++)
                {
                    if (o >= listBox1.SelectedIndex)
                    {
                        books[o][p] = books[o + 1][p];
                    }
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int o = 0; o < i; o++)
                    {
                        for (int p = 0; p < books[o].Length; p++)
                        {
                            if (p == 9)
                                sw.Write(books[o][p]);
                            else
                                sw.Write(books[o][p] + "|");
                        }
                        sw.Write("\n");
                    }
                }
                listBox1.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Файл занят!");
            }

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    books[i] = line.Split('|');
                    listBox1.Items.Add(books[i][0]);
                }
            }
        }
    }
}

