using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ul
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            workBeeBox.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, 175);
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żądłami" }, 275);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" }, 149);
            queen = new Queen(workers, 275);
        }

        private void shiftBtn_Click(object sender, EventArgs e)
        {
            queen.WorkTheNextShift();
            raportBox.Text = queen.Raport();
        }

        private void workBtn_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workBeeBox.Text, (int)shiftsNum.Value))
                MessageBox.Show("Dodano zadanie pomyślnie");
            else
                MessageBox.Show("Nie udało się przydzielić zadania");
            raportBox.Text = queen.Raport();
        }
    }
}
