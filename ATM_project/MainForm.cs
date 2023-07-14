using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ATM_project
{

    public partial class MainForm : Form
    {
        public static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Strypes\source\repos\ATM_project\ATM_project\DTO\Database1.mdf;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(cs);

        decimal bankMoney;
        public decimal BankMoney
        {
            get { return bankMoney; }
            set { bankMoney = value; }

        }

        Dictionary<string, string> account = new Dictionary<string, string>();
        Dictionary<string, string> accountCardINFO = new Dictionary<string, string>();
        Dictionary<string, decimal> accountCardAmount = new Dictionary<string, decimal>();

        public Dictionary<string, string> AccountCardINFO
        {
            get { return accountCardINFO; }
            set { accountCardINFO = value; }
        }
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

            conn.Open();

            SqlDataReader readerForCheckingIfThereIsMoneyInTheBank;
            readerForCheckingIfThereIsMoneyInTheBank = MethodForCheckingIfThereIsMoneyInTheBank();

            if (!readerForCheckingIfThereIsMoneyInTheBank.Read())
            {
                bankMoney = (decimal)1000000.00;
            }
            else
            {
                string convert = readerForCheckingIfThereIsMoneyInTheBank.GetValue(0).ToString();
                bankMoney = Convert.ToDecimal(convert);
            }

            conn.Close();

            //default inputs:
            account.Add("Pesho", "Cod1");
            //----------------------------------
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            conn.Open();

            string cardCode = textBoxCODE.Text;

            SqlDataReader readerForCheckingIfTheCodeIsInDB;
            readerForCheckingIfTheCodeIsInDB = MethodForCheckingIfTheCodeOfTheCardIsInDB(cardCode);

            bool isCodeInDatabase = false;
            if (readerForCheckingIfTheCodeIsInDB.Read())
            {
                isCodeInDatabase = true;
                accountCardINFO.Add(readerForCheckingIfTheCodeIsInDB.GetValue(1).ToString(), readerForCheckingIfTheCodeIsInDB.GetValue(2).ToString());
                accountCardAmount.Add(readerForCheckingIfTheCodeIsInDB.GetValue(1).ToString(), (decimal)readerForCheckingIfTheCodeIsInDB.GetValue(3));
            }
            conn.Close();

            if (isCodeInDatabase && accountCardINFO[textBoxCODE.Text].Equals(textBoxPIN.Text))
            {
                foreach (var code in account)
                {
                    if (code.Value.Equals(textBoxCODE.Text))
                    {
                        user = code.Key;
                        break;
                    }
                }

                accountCardINFO.Clear();

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

        private SqlDataReader MethodForCheckingIfThereIsMoneyInTheBank()
        {
            string query = "Select BankMoney FROM bank WHERE Id=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader readerForCheckingIfThereIsMoneyInTheBank;
            return readerForCheckingIfThereIsMoneyInTheBank = cmd.ExecuteReader();
        }
        private SqlDataReader MethodForCheckingIfTheCodeOfTheCardIsInDB(string cardCode)
        {
            string query = "Select * From cardtable Where Code=@val1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@val1", cardCode);
            SqlDataReader readerForCheckingIfTheCodeIsInDB;
            return readerForCheckingIfTheCodeIsInDB = cmd.ExecuteReader();
        }


    }
}