using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading;

namespace BigFileReader
{
    public partial class Form1 : Form
    {
        const int readLenght = 100000000;
        int length;
        string tekst;

        public Form1()
        {
            InitializeComponent();
            //fileGenerator();
        }

        private void readBigFile()
        {
            long fileLength;
            using (MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(@"c:\temp\MyTests.txt", FileMode.OpenOrCreate, "log-map"))
            {
                using (MemoryMappedViewAccessor viewAccessor = memoryMappedFile.CreateViewAccessor())
                {
                    byte[] bytes = new byte[readLenght];
                    viewAccessor.ReadArray(length, bytes, 0, readLenght);
                    tekst = Encoding.UTF8.GetString(bytes).Trim('\0');
                }
            }
            Thread.Sleep(0);
        }

        private void fileGenerator()
        {
            byte[] bigFile = new byte[400000000];
            string path = @"c:\temp\MyTests.txt";
            using (FileStream fs = File.Create(path))
            {
                for (int i = 0; i < 100000000; i++)
                    bigFile[i] += (byte)'a';
                for (int i = 100000000; i < 200000000; i++)
                    bigFile[i] += (byte)'b';
                for (int i = 200000000; i < 300000000; i++)
                    bigFile[i] += (byte)'c';
                for (int i = 300000000; i < 400000000; i++)
                    bigFile[i] += (byte)'d';
                fs.Write(bigFile, 0, bigFile.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            length += readLenght;
            Thread t = new Thread(new ThreadStart(readBigFile));
            t.Start();
            numericUpDown1.Value++;
            t.Join();
            textBox1.Text = tekst;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(readBigFile));
            t.Start();
            t.Join();
            textBox1.Text = tekst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 1)
            {
                length -= readLenght;
                Thread t = new Thread(new ThreadStart(readBigFile));
                t.Start();
                numericUpDown1.Value--;
                t.Join();
                textBox1.Text = tekst;
            }
        }

        private void search()
        {
            int tak = tekst.IndexOf("a", 0, tekst.Length);
            Console.WriteLine(tak.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
