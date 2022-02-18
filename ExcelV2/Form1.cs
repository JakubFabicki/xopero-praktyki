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

namespace ExcelV2
{
    public partial class Form1 : Form
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string fullPath;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < alpha.Length; i++)
                dataGridView1.Columns.Add(alpha[i].ToString(), alpha[i].ToString());
        }

        private void splitText(string path)
        {
            dataGridView1.Rows.Clear();
            foreach (string line in File.ReadLines(path))
            {
                string[] subs = line.Split(',');
                dataGridView1.Rows.Add(subs);
            }
        }

        private void generateCSV(string path)
        {
            Console.WriteLine(dataGridView1.Rows.Count);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string line = null;

                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        if(dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            line += dataGridView1.Rows[i].Cells[j].Value.ToString();
                            if(j != dataGridView1.Rows[i].Cells.Count - 1)
                                line += ", ";
                        }
                    }
                    writer.WriteLine(line);
                };
            }
        }

        private OpenFileDialog openFileDialog1;
        private void openBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse CSV Files";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog1.FileName;
                Console.WriteLine(fullPath);
                splitText(fullPath);
            }
        }

        private SaveFileDialog saveFileDialog1;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save CSV Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fullPath = saveFileDialog1.FileName;
                Console.WriteLine(fullPath);
                generateCSV(fullPath);
            }
        }

    }
}
