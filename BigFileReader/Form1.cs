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
    public partial class BigFile : Form
    {
        const int readLenght = 100000000;
        int length;
        string tekst;
        int searchIndex;
        string fullPath;
        bool error = false;

        public BigFile()
        {
            InitializeComponent();
            //fileGenerator();
        }

        //user function

        private void readBigFile()
        {
            if (fullPath != null)
            {
                using (MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(fullPath, FileMode.OpenOrCreate, "log-map"))
                {
                    using (MemoryMappedViewAccessor viewAccessor = memoryMappedFile.CreateViewAccessor())
                    {
                        byte[] bytes = new byte[readLenght];
                        try
                        {
                            viewAccessor.ReadArray(length, bytes, 0, readLenght);
                        }
                        catch
                        {
                            MessageBox.Show("Plik nie posiada więcej stron, załaduj plik ponownie!");
                            error = true;
                        }
                        tekst = Encoding.UTF8.GetString(bytes).Trim('\0');
                    }
                }
                Thread.Sleep(0);
            }
            else
                MessageBox.Show("Najpierw załaduj plik!");
        }

        private void search()
        {
            if (tekst != null && searchBox.Text.Length != 0)
            {
                string searchText = searchBox.Text;

                if (!searchChbox.Checked)
                {
                    if (searchIndex + searchText.Length >= tekst.Length)
                        searchIndex = 0;
                }
                else
                {
                    if (searchIndex + searchText.Length >= tekst.Length)
                    {
                        length += readLenght;
                        Thread t = new Thread(new ThreadStart(readBigFile));
                        t.Start();
                        numericUpDown1.Value++;
                        t.Join();
                        textBox1.Text = tekst;
                        searchIndex = 0;
                        Console.WriteLine("tak");
                    }
                }

                int searchIndexReturn = tekst.IndexOf(searchText, searchIndex, tekst.Length - searchIndex);

                if (searchIndexReturn != -1)
                {
                    textBox1.Select();
                    textBox1.Select(searchIndexReturn, searchText.Length);
                    searchIndex += searchIndexReturn + searchText.Length;
                }
                else if (searchIndex > 0)
                {
                    MessageBox.Show("Nie znaleziono więcej pasujących elementów");
                    searchIndex = 0;
                }
                else
                    MessageBox.Show("Nie znaleziono żadnego pasującego elementu");
            }
            else if (tekst == null && searchBox.Text.Length != 0)
                MessageBox.Show("Załaduj plik!");
            else if (searchBox.Text.Length == 0 && tekst != null)
                MessageBox.Show("Wprowadź wyszukiwany tekst!");
            else
                MessageBox.Show("Załaduj plik, a następnie wprowadź wyszukiwany tekst!");
        }


        //windows form function


        private void button1_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                length += readLenght;
                Thread t = new Thread(new ThreadStart(readBigFile));
                t.Start();
                numericUpDown1.Value++;
                t.Join();
                textBox1.Text = tekst;
            }
            else
                MessageBox.Show("Wystąpił błąd, załaduj plik ponownie!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Wybierz plik, który chcesz przeglądać";
            fullPath = openFileDialog1.FileName;

            numericUpDown1.Value = 1;
            length = 0;
            error = false;

            Thread t = new Thread(new ThreadStart(readBigFile));
            t.Start();
            t.Join();
            textBox1.Text = tekst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                if (numericUpDown1.Value > 1)
                {
                    length -= readLenght;
                    Thread t = new Thread(new ThreadStart(readBigFile));
                    t.Start();
                    numericUpDown1.Value--;
                    t.Join();
                    textBox1.Text = tekst;
                }
                else
                    MessageBox.Show("Znajdujesz się aktualnie na pierwszej stronie!");
            }
            else
                MessageBox.Show("Wystąpił błąd, załaduj plik ponownie!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!error)
                search();
            else
                MessageBox.Show("Wystąpił błąd, załaduj plik ponownie!");
        }


        //big file generator function


        private void fileGenerator()
        {
            byte[] bigFile = new byte[400000000];
            string path = @"c:\temp\MyTests.txt";
            using (FileStream fs = File.Create(path))
            {
                for (int i = 0; i < 99999997; i++)
                    bigFile[i] += (byte)'a';
                for (int i = 99999997; i < 199999997; i++)
                    bigFile[i] += (byte)'b';
                for (int i = 199999997; i < 299999997; i++)
                    bigFile[i] += (byte)'c';
                for (int i = 300000000; i < 400000000; i++)
                    bigFile[i] += (byte)'d';
                fs.Write(bigFile, 0, bigFile.Length);
            }
        }
    }
}
