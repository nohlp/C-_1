using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_Task2
{
    public partial class frm1 : Form
    {
        GameDigits gd;
        public int rndValue;

        public frm1()
        {
            InitializeComponent();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Угадай число.\nВерсия 0.1b\n");
        }

        private void tsmNewGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rndValue = rnd.Next(0, 100);
            groupBox1.Enabled = true;
            gd = new GameDigits(rndValue);
            labelInfo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int outValue;
            if (int.TryParse(userInputValue.Text, out outValue)) {
                    outValue = gd.UserInputhValue;
                gd.UserInputhValue = Convert.ToInt16(userInputValue.Text);
                switch (gd.CheckDigits())
                {
                    case 100:
                        {
                            MessageBox.Show($"Вы угадали за {gd.UserSteps} попыток! Это было число {gd.FinishValue}");
                            groupBox1.Enabled = false;
                            labelInfo.Text = "";
                            userInputValue.Text = "";
                            break;
                        }
                    case 2:
                        {
                            labelInfo.Text = $"Искомое число меньше";
                            break;
                        }
                    case 1:
                        {
                            labelInfo.Text = $"Искомое число больше";
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Необходимо вводить только числа от 0 до 100");
            }
        }
    }
}
