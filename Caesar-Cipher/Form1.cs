using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Crypt(int steps, string word)
        {
            if (textBox1.Text != null && textBox4.Text != null)
            {
                int[] new_array = new int[word.Length];
                char[] new_chars = new char[word.Length];
                char[] word_to_chars = new char[word.Length];

                word_to_chars = word.ToCharArray();

                for (int i = 0; i < word.Length; i++)
                {
                    new_array[i] = (int)(word_to_chars[i]);
                }

                for (int j = 0; j < new_array.Length; j++)
                {
                    new_chars[j] = (char)(new_array[j] + steps);
                }

                String final = new string(new_chars);

                textBox2.Text = final;

                return final;
            }
            return "Неверное значение!";
        }

        public string Decrypt(int steps, string crypted_word)
        {
            if (textBox3.Text != null && textBox4.Text != null)
            {
                int[] new_array = new int[crypted_word.Length];
                char[] new_chars = new char[crypted_word.Length];
                char[] word_to_chars = new char[crypted_word.Length];

                word_to_chars = crypted_word.ToCharArray();

                for (int i = 0; i < crypted_word.Length; i++)
                {
                    new_array[i] = (int)(word_to_chars[i]);
                }

                for (int j = 0; j < new_array.Length; j++)
                {
                    new_chars[j] = (char)(new_array[j] - steps);
                }

                String final = new string(new_chars);

                textBox3.Text = final;

                return final;             
            }
            return "Неверное значение!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crypt(int.Parse(textBox4.Text), textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decrypt(int.Parse(textBox4.Text), textBox2.Text);
        }
    }
}
