using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEsson7_Task1
{
    public partial class Form1 : Form
    {
        Multiplier multiplier;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удвоитель.\nВерсия 0.1b");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Узнаешь число когда доиграешь;)");
        }

        private void tsmNewGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            multiplier = new Multiplier(rnd.Next(0, 100));
            gb1.Enabled = true;
            ShowCurrentEvent();
            lb2.Text = $"Искомое число {multiplier.FinishValue}";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            multiplier.Plus();
            ShowCurrentEvent();
            CheckStatus();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            multiplier.Mult();
            ShowCurrentEvent();
            CheckStatus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            multiplier.Reset();
            ShowCurrentEvent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            multiplier.Back();
            ShowCurrentEvent();
        }
        private void ShowCurrentEvent()
        {
            lb1.Text = "Значение: " + multiplier.CurrentValue.ToString() + " Команд:" + multiplier.commandCount;
        }

        private void CheckStatus()
        {
            switch (multiplier.Check())
            {
                case 1:
                    {
                        MessageBox.Show("Вы проиграли Ваше число " + multiplier.CurrentValue + " больше исходного!");
                        gb1.Enabled = false;
                        break;
                    }
                case 200:
                    {
                        MessageBox.Show("Вы победили!");
                        gb1.Enabled = false;
                        break;
                    }
            }
        }
    }
}
