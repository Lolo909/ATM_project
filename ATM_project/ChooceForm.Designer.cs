namespace ATM_project
{
    partial class ChooceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooceForm));
            frame3_of_ATM = new Panel();
            frame4_of_ATM = new Panel();
            frame2_of_ATM = new Panel();
            frame1_of_ATM = new Panel();
            text_on_ATM = new Label();
            ATM = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button_withdraw = new Button();
            button_deposit = new Button();
            button_transfer = new Button();
            button_check_your_balance = new Button();
            ((System.ComponentModel.ISupportInitialize)ATM).BeginInit();
            SuspendLayout();
            // 
            // frame3_of_ATM
            // 
            frame3_of_ATM.BackColor = SystemColors.ControlText;
            frame3_of_ATM.Location = new Point(55, 25);
            frame3_of_ATM.Name = "frame3_of_ATM";
            frame3_of_ATM.Size = new Size(12, 383);
            frame3_of_ATM.TabIndex = 13;
            // 
            // frame4_of_ATM
            // 
            frame4_of_ATM.BackColor = SystemColors.ControlText;
            frame4_of_ATM.Location = new Point(388, 25);
            frame4_of_ATM.Name = "frame4_of_ATM";
            frame4_of_ATM.Size = new Size(11, 383);
            frame4_of_ATM.TabIndex = 12;
            // 
            // frame2_of_ATM
            // 
            frame2_of_ATM.BackColor = SystemColors.ControlText;
            frame2_of_ATM.Location = new Point(55, 398);
            frame2_of_ATM.Name = "frame2_of_ATM";
            frame2_of_ATM.Size = new Size(343, 10);
            frame2_of_ATM.TabIndex = 11;
            // 
            // frame1_of_ATM
            // 
            frame1_of_ATM.BackColor = SystemColors.ControlText;
            frame1_of_ATM.Location = new Point(55, 25);
            frame1_of_ATM.Name = "frame1_of_ATM";
            frame1_of_ATM.Size = new Size(343, 10);
            frame1_of_ATM.TabIndex = 10;
            // 
            // text_on_ATM
            // 
            text_on_ATM.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            text_on_ATM.ForeColor = Color.Lime;
            text_on_ATM.Location = new Point(107, 160);
            text_on_ATM.Name = "text_on_ATM";
            text_on_ATM.Size = new Size(134, 50);
            text_on_ATM.TabIndex = 9;
            text_on_ATM.Text = "?";
            text_on_ATM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATM
            // 
            ATM.Image = (Image)resources.GetObject("ATM.Image");
            ATM.Location = new Point(55, 31);
            ATM.Name = "ATM";
            ATM.Size = new Size(344, 377);
            ATM.SizeMode = PictureBoxSizeMode.StretchImage;
            ATM.TabIndex = 8;
            ATM.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(471, 25);
            label1.Name = "label1";
            label1.Size = new Size(251, 91);
            label1.TabIndex = 14;
            label1.Text = "Choose what you would like to do:";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(712, 106);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_withdraw
            // 
            button_withdraw.BackColor = Color.Navy;
            button_withdraw.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_withdraw.ForeColor = Color.Lime;
            button_withdraw.Location = new Point(471, 198);
            button_withdraw.Name = "button_withdraw";
            button_withdraw.Size = new Size(251, 54);
            button_withdraw.TabIndex = 16;
            button_withdraw.Text = "withdraw";
            button_withdraw.UseVisualStyleBackColor = false;
            button_withdraw.Click += button_withdraw_Click;
            // 
            // button_deposit
            // 
            button_deposit.BackColor = Color.Navy;
            button_deposit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_deposit.ForeColor = Color.Lime;
            button_deposit.Location = new Point(471, 273);
            button_deposit.Name = "button_deposit";
            button_deposit.Size = new Size(251, 54);
            button_deposit.TabIndex = 17;
            button_deposit.Text = "deposit";
            button_deposit.UseVisualStyleBackColor = false;
            // 
            // button_transfer
            // 
            button_transfer.BackColor = Color.Navy;
            button_transfer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_transfer.ForeColor = Color.Lime;
            button_transfer.Location = new Point(471, 347);
            button_transfer.Name = "button_transfer";
            button_transfer.Size = new Size(251, 54);
            button_transfer.TabIndex = 18;
            button_transfer.Text = "transfer";
            button_transfer.UseVisualStyleBackColor = false;
            // 
            // button_check_your_balance
            // 
            button_check_your_balance.BackColor = Color.Navy;
            button_check_your_balance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_check_your_balance.ForeColor = Color.Lime;
            button_check_your_balance.Location = new Point(471, 128);
            button_check_your_balance.Name = "button_check_your_balance";
            button_check_your_balance.Size = new Size(251, 54);
            button_check_your_balance.TabIndex = 19;
            button_check_your_balance.Text = "check your balance";
            button_check_your_balance.UseVisualStyleBackColor = false;
            // 
            // ChooceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(button_check_your_balance);
            Controls.Add(button_transfer);
            Controls.Add(button_deposit);
            Controls.Add(button_withdraw);
            Controls.Add(label1);
            Controls.Add(frame3_of_ATM);
            Controls.Add(frame4_of_ATM);
            Controls.Add(frame2_of_ATM);
            Controls.Add(frame1_of_ATM);
            Controls.Add(text_on_ATM);
            Controls.Add(ATM);
            Controls.Add(button1);
            Name = "ChooceForm";
            Text = "ChooceForm";
            ((System.ComponentModel.ISupportInitialize)ATM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel frame3_of_ATM;
        private Panel frame4_of_ATM;
        private Panel frame2_of_ATM;
        private Panel frame1_of_ATM;
        private Label text_on_ATM;
        private PictureBox ATM;
        private Label label1;
        private Button button1;
        private Button button_withdraw;
        private Button button_deposit;
        private Button button_transfer;
        private Button button_check_your_balance;
    }
}