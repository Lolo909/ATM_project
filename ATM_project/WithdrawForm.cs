using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

       

        private static int[] nominals = { 100, 50, 20, 10 };

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

            resultFromWithdraw = nominals.ToDictionary(item => item, item => 0);
           
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

                //TODO if there is not enough money
                MainForm mainFormIns = MainForm.mainFormInstance;
               
                    foreach (KeyValuePair<string, decimal> code in mainFormIns.AccountCardAmount)
                {
                    if (code.Key.Equals(mainFormIns.CodeCard))
                    {
                        mainFormIns.AccountCardAmount[code.Key] -= inputAmount;
                        mainFormIns.BankMoney -= inputAmount;

                        mainFormIns.conn.Open();

                        try{
                            UpdateDBMoney(mainFormIns, code);
                        }
                        catch(Exception ex) {
                            this.Hide();
                            MainForm mainForm = MainForm.mainFormInstance;
                            mainForm.label_message.Text = "There is problem with the database.\n" +
                                "Please, try again later.";
                            mainForm.textBoxCODE.Clear();
                            mainForm.textBoxPIN.Clear();
                            mainForm.label_message.Visible = true;
                            mainForm.AccountCardAmount.Clear();
                            mainForm.AccountCardINFO.Clear();
                            mainForm.conn.Close();
                            mainForm.ShowDialog();
                        }
                        
                        mainFormIns.conn.Close();


                        //method 1:
                        balancedWithdrawMoney(amountForWithdraw);

                        //method 2:
                        //fromLargestToSmallestWithdrawMoney(amountForWithdraw);

                        this.Hide();
                        WithdrawDoneForm withdrawDoneForm = new WithdrawDoneForm();
                        withdrawDoneForm.ShowDialog();


                        break;
                    }
                }


            }
        }
        //Method which withdraw the amount in balanced way.
        //i.e. You will get your amount divided by all denominations.
        public void balancedWithdrawMoney(int amountForWithdraw)
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
                        break;
                    }

                }

                i++;
                if (i == 4)
                {
                    i = 0;
                }
            }
        }

        //Method which withdraw the amount in descending way.
        //i.e. You will get your amount divided from the largest denomination to the smallest.
        public void fromLargestToSmallestWithdrawMoney(int amountForWithdraw)
        {
            int i = 0;
            while (amountForWithdraw != 0)
            {
                if (amountForWithdraw >= nominals[i])
                {
                    amountForWithdraw -= nominals[i];
                    resultFromWithdraw[nominals[i]] += 1;
                }
                else
                {
                    i++;
                }
                
            }
            
        }

        private void UpdateDBMoney(MainForm mainFormIns, KeyValuePair<string, decimal> code)
        {
            SqlTransaction objTrans = null;

            using (mainFormIns.conn)
            {
                objTrans = mainFormIns.conn.BeginTransaction();
                string queryUpdateCardtable = "UPDATE cardtable SET Amount = " + mainFormIns.AccountCardAmount[code.Key] + " WHERE Code='" + code.Key + "';";
                string queryUpdateBank = "UPDATE bank SET BankMoney = " + mainFormIns.BankMoney + " WHERE Id=1;";
                SqlCommand cmdCardtable = new SqlCommand(queryUpdateCardtable, mainFormIns.conn);
                cmdCardtable.Transaction = objTrans;
                SqlCommand cmdBank = new SqlCommand(queryUpdateBank, mainFormIns.conn);
                cmdBank.Transaction = objTrans;

                try
                {
                    cmdCardtable.ExecuteNonQuery();
                    cmdBank.ExecuteNonQuery();
                    objTrans.Commit();
                }
                catch(Exception ex)
                {
                    objTrans.Rollback();
                   throw new Exception();
                                   
                }               

            }
           
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
