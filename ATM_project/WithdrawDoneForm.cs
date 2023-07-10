using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_project
{
    public partial class WithdrawDoneForm : Form
    {
        public WithdrawDoneForm()
        {
            InitializeComponent();

            this.Text = "ATM";
            text_on_ATM.Parent = ATM;
            text_on_ATM.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(200, 200, 200);


            //result_label.Text = WithdrawForm.withdrawFormInstance.ResultFromWithdraw;
            StringBuilder result = new StringBuilder();
            foreach (var item in WithdrawForm.withdrawFormInstance.ResultFromWithdraw)
            {
                result.Append(item.Key + " - " + item.Value + "\n");
            }

            result_label.Text = result.ToString();
        }
    }
}
