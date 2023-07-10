using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ATM_project
{

    public partial class MainForm : Form
    {
        Decimal bankMoney = 1000000;
        public decimal BankMoney
        {
            get { return bankMoney; }
            set { bankMoney = value; }

        }

        Dictionary<string, string> account = new Dictionary<string, string>();
        Dictionary<string, string> accountCardINFO = new Dictionary<string, string>();
        Dictionary<string, decimal> accountCardAmount = new Dictionary<string, decimal>();

        public Dictionary<string, decimal> AccountCardAmount
        {
            get { return accountCardAmount; }
            set { accountCardAmount = value; }
        }

        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        string codeCard;

        public string CodeCard
        {
            get { return codeCard; }
            set { codeCard = value; }
        }
      
        public static MainForm mainFormInstance;
      
        public MainForm()
        {
            InitializeComponent();
            mainFormInstance = this;

            this.Text = "ATM";
            text_on_ATM.Parent = ATM;
            text_on_ATM.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(200, 200, 200);



            //default inputs
            //----------------------------------

            //account = new Dictionary<string,string>();
            account.Add("Pesho", "Cod1");

            //accountCardINFO = new Dictionary<string, string>();
            accountCardINFO.Add("Cod1", "PIN1");

            //accountCardAmount = new Dictionary<string, Decimal>();
            accountCardAmount.Add("Cod1", (decimal)1500.00);

            //----------------------------------

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            string error = "ERROR";

            bool isCodeInDictionary = accountCardINFO.TryGetValue(textBoxCODE.Text, out error);

            if (!isCodeInDictionary)
            {
                textBoxPIN.Clear();
                label_message.Text = "Wrong CODE or PIN!";
                label_message.Visible = true;
            }
            else if (accountCardINFO[textBoxCODE.Text].Equals(textBoxPIN.Text))
            {

                foreach (var code in account)
                {
                    if (code.Value.Equals(textBoxCODE.Text))
                    {
                        user = code.Key;
                        break;
                    }
                }

                codeCard = textBoxCODE.Text;

                this.Hide();
                ChooceForm chooceForm = new ChooceForm();
                chooceForm.ShowDialog();
            }
            else
            {
                textBoxPIN.Clear();
                label_message.Text = "Wrong CODE or PIN!";
                label_message.Visible = true;
            }
        }

        private void textBoxPIN_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
        }

        private void textBoxCODE_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCODE.Text, "[^A-Za-z0-9]"))
            {

                label_message.Text = "Please enter only numbers or letters.";

                textBoxCODE.Text = "";

                label_message.Visible = true;
            }
            else
            {
                label_message.Visible = false;
            }
        }
    }
}