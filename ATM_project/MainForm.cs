using System.Collections;
using System.Collections.Generic;

namespace ATM_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "ATM";
            text_on_ATM.Parent = ATM;
            text_on_ATM.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(200, 200, 200);

            Decimal bankMoney = 1000000;

            Dictionary<string, Decimal> account = new Dictionary<string, Decimal>();
            Dictionary<Dictionary<string, Decimal>, string> accountCard = new Dictionary<Dictionary<string, Decimal>, string>();

            List<Dictionary<string, Decimal>> listOfAccounts = new List<Dictionary<string, Decimal>>();

            List<Dictionary<Dictionary<string, Decimal>, string>> listOfAccountsCards = 
                new List<Dictionary<Dictionary<string, decimal>, string>>();

            //default inputs
            //----------------------------------

            account = new Dictionary<string, Decimal>();
            account.Add("Pesho", (decimal)1500.00);
            
            accountCard = new Dictionary<Dictionary<string, Decimal>, string>();
            accountCard.Add(account, "PIN1");

            listOfAccounts.Add(account);
            listOfAccountsCards.Add(accountCard);

            //----------------------------------



        }
    }
}