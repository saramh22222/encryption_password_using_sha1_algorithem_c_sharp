using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace sha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textToHash = textBox2.Text;
            string hashedText = Hash(textToHash);
            textBox3.Text = hashedText;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
        private void label3_Click(object sender, EventArgs e)
        {
            // Add your desired functionality here
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
