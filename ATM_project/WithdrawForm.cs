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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
            pictureBox1.Parent = ATM;
            pictureBox1.BackColor = Color.Transparent;
            this.Text = "ATM";
            this.BackColor = Color.FromArgb(200, 200, 200);
        }
    }
}
