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
    public partial class ChooceForm : Form
    {
        public ChooceForm()
        {
            InitializeComponent();

            this.Text = "ATM";
            text_on_ATM.Parent = ATM;
            text_on_ATM.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(200, 200, 200);
        }
    }
}
