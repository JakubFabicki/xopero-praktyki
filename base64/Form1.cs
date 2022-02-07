using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64
{
    public partial class Form1 : Form
    {
        algBase64 obj;

        public Form1()
        {
            InitializeComponent();
            obj = new algBase64();
            test();
        }

        private void normalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(normalTextBox.Text);
                char[] value = obj.encodeBase64Algoritm(data);
                string result;
                base64TextBox.Text = result = new string(value);
            }
        }

        private void base64TextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string data = base64TextBox.Text;
                byte[] value = obj.decodeBase64Algoritm(data.ToCharArray());
                string result = System.Text.Encoding.ASCII.GetString(value);
                normalTextBox.Text = result;
            }
        }

        private void test()
        {
            Base64Test test = new Base64Test();
            if (test.testBase64Result())
                Console.WriteLine("Pomyslnie");
            else
                Console.WriteLine("nie");
        }
    }
}
