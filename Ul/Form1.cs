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
        private Bank bank;

        public Form1()
        {
            InitializeComponent();
            workBeeBox.SelectedIndex = 0;
            bank = new Bank();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(bank, new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(bank, new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker(bank, new string[] { "Utrzymanie ula", "Patrol z żądłami" });
            workers[3] = new Worker(bank, new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" });
            queen = new Queen(workers);
        }

        private void shiftBtn_Click(object sender, EventArgs e)
        {
            queen.WorkTheNextShift();
            raportBox.Text = queen.Raport();
            moneyBox.Text = bank.Money.ToString();
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
