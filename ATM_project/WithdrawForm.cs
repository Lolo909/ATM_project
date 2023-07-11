using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM_project
{
    public partial class WithdrawForm : Form
    {

        public static WithdrawForm withdrawFormInstance;

        Dictionary<int, int> resultFromWithdraw = new Dictionary<int, int>();

        public Dictionary<int, int> ResultFromWithdraw
        {
            get { return resultFromWithdraw; }
            set { resultFromWithdraw = value; }
        }
        public WithdrawForm()
        {
            InitializeComponent();
            withdrawFormInstance = this;

            pictureBox1.Parent = ATM;
            pictureBox1.BackColor = Color.Transparent;
            this.Text = "ATM";
            this.BackColor = Color.FromArgb(200, 200, 200);

            resultFromWithdraw.Add(100,0);
            resultFromWithdraw.Add(50,0);
            resultFromWithdraw.Add(20,0);
            resultFromWithdraw.Add(10,0);
        }

        private void button_go_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooceForm chooceForm = new ChooceForm();
            chooceForm.ShowDialog();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {            
           
            int inputAmount = Int32.Parse(textBoxAmount.Text);

            if (inputAmount < 10 || inputAmount > 3000 || inputAmount % 10 != 0)
            {
                                
                label_message.Visible = true;
                label_message.Text = "Your amount must be\r\n" +
                    "bigger than 10,\r\n" +
                    "smaller than 3000\r\n" +
                    "and а multiple of ten!";

            }
            else
            {
                
                int amountForWithdraw = inputAmount;
                
                int[] nominals = {100, 50, 20, 10};

                //TODO if there is not enough money
                MainForm mainFormIns = MainForm.mainFormInstance;
               
                    foreach (KeyValuePair<string, decimal> code in mainFormIns.AccountCardAmount)
                {
                    if (code.Key.Equals(mainFormIns.CodeCard))
                    {
                        mainFormIns.AccountCardAmount[code.Key] = mainFormIns.AccountCardAmount[code.Key] - inputAmount;
                        mainFormIns.BankMoney = mainFormIns.BankMoney - inputAmount;


                        //method 1:
                        //method1ForWithdrawMoney(amountForWithdraw, nominals);

                        //method 2:
                        method2ForWithdrawMoney(amountForWithdraw);

                        
                        break;
                    }
                }


            }
        }
        private void method1ForWithdrawMoney(int amountForWithdraw, int[] nominals)
        {
             int i = 0;
            while (i < 4)
            {
                if (amountForWithdraw >= nominals[i])
                {
                    amountForWithdraw -= nominals[i];
                    resultFromWithdraw[nominals[i]] += 1;

                    if (amountForWithdraw == 0)
                    {
                        this.Hide();
                        WithdrawDoneForm withdrawDoneForm = new WithdrawDoneForm();
                        withdrawDoneForm.ShowDialog();
                    }

                }

                i++;
                if (i == 4)
                {
                    i = 0;
                }
            }
        }

        private void method2ForWithdrawMoney(int amountForWithdraw)
        {
            while (amountForWithdraw != 0)
            {
                if (amountForWithdraw >= 100)
                {
                    amountForWithdraw -= 100;
                    resultFromWithdraw[100] += 1;
                }
                else if (amountForWithdraw >= 50)
                {
                    amountForWithdraw -= 50;
                    resultFromWithdraw[50] += 1;
                }
                else if (amountForWithdraw >= 20)
                {
                    amountForWithdraw -= 20;
                    resultFromWithdraw[20] += 1;
                }
                else
                {
                    amountForWithdraw -= 10;
                    resultFromWithdraw[10] += 1;
                }
            }
            this.Hide();
            WithdrawDoneForm withdrawDoneForm = new WithdrawDoneForm();
            withdrawDoneForm.ShowDialog();
        }
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "[^0-9]"))
            {
                
                label_message.Text = "Please enter only numbers.";

                textBoxAmount.Text = "";

                label_message.Visible = true;
            }
            else
            {
                label_message.Visible = false;
            }
        }
    }
}
