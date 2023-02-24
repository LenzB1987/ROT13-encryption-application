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

namespace ROT13_encryption_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ROT13encryption(string input)
        {
            StringBuilder encryptedresults = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in input)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    encryptedresults.Append((char)code);
                }
                else
                    encryptedresults.Append(c);
            }
            return encryptedresults.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = ROT13encryption(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ROT13encryption(textBox1.Text);
        }
    }
}
