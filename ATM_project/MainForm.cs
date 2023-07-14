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
            
            string query = "Select COUNT(Code) FROM cardtable";
            SqlCommand cmd = new SqlCommand(query, conn);            
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();

            if (!reader1.Read())
            {                               
                query = "INSERT INTO cardtable(Code,PIN,Amount) values('Cod1','PIN1','" + (decimal)1600.00 + "') " +
                "INSERT INTO cardtable(Code,PIN,Amount) values('Cod2','PIN2','" + (decimal)1750.00 + "') ";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            conn.Open();
            query = "Select * FROM bank WHERE Id=1";
            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            if (!reader2.Read())
            {
                conn.Close();
                conn.Open();
                query = "INSERT INTO bank(Id,BankMoney) values(1,'"+ (decimal)1000000.00 +"')";
                //query = "UPDATE bank SET BankMoney = " + (decimal)1000000.00 + " WHERE Id=1;";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteReader();
                bankMoney = (decimal)1000000.00;
            }
            else
            {
                conn.Close();
                conn.Open();
                string query3 = "Select BankMoney From bank Where Id=1";
                SqlCommand cmd3 = new SqlCommand(query3, conn);               
                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (reader3.Read())
                {
                    string convert = reader3.GetValue(0).ToString();
                    bankMoney = Convert.ToDecimal(convert);
                }              
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
            
            string query = "Select * From cardtable Where Code=@val1";            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@val1", cardCode);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            

            bool isCodeInDatabase = false;
            if (reader1.Read())
            {
                isCodeInDatabase=true;                
                accountCardINFO.Add(reader1.GetValue(1).ToString(), reader1.GetValue(2).ToString());
                accountCardAmount.Add(reader1.GetValue(1).ToString(), (decimal)reader1.GetValue(3));
            }
            conn.Close();
            if (!isCodeInDatabase)
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

        
    }
}