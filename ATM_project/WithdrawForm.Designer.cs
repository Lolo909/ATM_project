namespace ATM_project
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            frame3_of_ATM = new Panel();
            frame4_of_ATM = new Panel();
            frame2_of_ATM = new Panel();
            frame1_of_ATM = new Panel();
            ATM = new PictureBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button_enter = new Button();
            label1 = new Label();
            textBoxAmount = new TextBox();
            button_go_back = new Button();
            label_message = new Label();
            ((System.ComponentModel.ISupportInitialize)ATM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // frame3_of_ATM
            // 
            frame3_of_ATM.BackColor = SystemColors.ControlText;
            frame3_of_ATM.Location = new Point(55, 25);
            frame3_of_ATM.Name = "frame3_of_ATM";
            frame3_of_ATM.Size = new Size(12, 383);
            frame3_of_ATM.TabIndex = 19;
            // 
            // frame4_of_ATM
            // 
            frame4_of_ATM.BackColor = SystemColors.ControlText;
            frame4_of_ATM.Location = new Point(388, 25);
            frame4_of_ATM.Name = "frame4_of_ATM";
            frame4_of_ATM.Size = new Size(11, 383);
            frame4_of_ATM.TabIndex = 18;
            // 
            // frame2_of_ATM
            // 
            frame2_of_ATM.BackColor = SystemColors.ControlText;
            frame2_of_ATM.Location = new Point(55, 398);
            frame2_of_ATM.Name = "frame2_of_ATM";
            frame2_of_ATM.Size = new Size(343, 10);
            frame2_of_ATM.TabIndex = 17;
            // 
            // frame1_of_ATM
            // 
            frame1_of_ATM.BackColor = SystemColors.ControlText;
            frame1_of_ATM.Location = new Point(55, 25);
            frame1_of_ATM.Name = "frame1_of_ATM";
            frame1_of_ATM.Size = new Size(343, 10);
            frame1_of_ATM.TabIndex = 16;
            // 
            // ATM
            // 
            ATM.Image = (Image)resources.GetObject("ATM.Image");
            ATM.Location = new Point(55, 31);
            ATM.Name = "ATM";
            ATM.Size = new Size(344, 377);
            ATM.SizeMode = PictureBoxSizeMode.StretchImage;
            ATM.TabIndex = 14;
            ATM.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(372, 376);
            button3.Name = "button3";
            button3.Size = new Size(10, 10);
            button3.TabIndex = 21;
            button3.Text = "ᐊ GO BACK";
            button3.UseVisualStyleBackColor = false;
            // 
            // button_enter
            // 
            button_enter.BackColor = Color.Navy;
            button_enter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_enter.ForeColor = Color.Lime;
            button_enter.Location = new Point(501, 294);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(193, 54);
            button_enter.TabIndex = 22;
            button_enter.Text = "Enter";
            button_enter.UseVisualStyleBackColor = false;
            button_enter.Click += button_enter_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(487, 160);
            label1.Name = "label1";
            label1.Size = new Size(217, 49);
            label1.TabIndex = 23;
            label1.Text = "Insert amount:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(487, 212);
            textBoxAmount.MaxLength = 4;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(217, 43);
            textBoxAmount.TabIndex = 24;
            textBoxAmount.TextAlign = HorizontalAlignment.Center;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // button_go_back
            // 
            button_go_back.BackColor = Color.Navy;
            button_go_back.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_go_back.ForeColor = Color.Lime;
            button_go_back.Location = new Point(501, 354);
            button_go_back.Name = "button_go_back";
            button_go_back.Size = new Size(193, 54);
            button_go_back.TabIndex = 25;
            button_go_back.Text = "ᐊ GO BACK";
            button_go_back.UseVisualStyleBackColor = false;
            button_go_back.Click += button_go_back_Click;
            // 
            // label_message
            // 
            label_message.BackColor = Color.FromArgb(255, 192, 192);
            label_message.BorderStyle = BorderStyle.FixedSingle;
            label_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_message.ForeColor = Color.Red;
            label_message.Location = new Point(458, 25);
            label_message.Name = "label_message";
            label_message.Size = new Size(271, 121);
            label_message.TabIndex = 26;
            label_message.Text = "message";
            label_message.TextAlign = ContentAlignment.MiddleCenter;
            label_message.Visible = false;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(label_message);
            Controls.Add(button_go_back);
            Controls.Add(textBoxAmount);
            Controls.Add(label1);
            Controls.Add(button_enter);
            Controls.Add(pictureBox1);
            Controls.Add(frame3_of_ATM);
            Controls.Add(frame4_of_ATM);
            Controls.Add(frame2_of_ATM);
            Controls.Add(frame1_of_ATM);
            Controls.Add(ATM);
            Controls.Add(button3);
            Name = "WithdrawForm";
            Text = "WithDrawForm";
            ((System.ComponentModel.ISupportInitialize)ATM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel frame3_of_ATM;
        private Panel frame4_of_ATM;
        private Panel frame2_of_ATM;
        private Panel frame1_of_ATM;
        private PictureBox ATM;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button_enter;
        private Label label1;
        private TextBox textBoxAmount;
        private Button button_go_back;
        private Label label_message;
    }
}