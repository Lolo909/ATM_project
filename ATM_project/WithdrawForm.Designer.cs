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
            button2 = new Button();
            label1 = new Label();
            textBoxCODE = new TextBox();
            button1 = new Button();
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
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(501, 294);
            button2.Name = "button2";
            button2.Size = new Size(193, 54);
            button2.TabIndex = 22;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(488, 98);
            label1.Name = "label1";
            label1.Size = new Size(217, 49);
            label1.TabIndex = 23;
            label1.Text = "Insert amount:";
            // 
            // textBoxCODE
            // 
            textBoxCODE.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCODE.Location = new Point(488, 175);
            textBoxCODE.MaxLength = 4;
            textBoxCODE.Name = "textBoxCODE";
            textBoxCODE.Size = new Size(217, 43);
            textBoxCODE.TabIndex = 24;
            textBoxCODE.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(501, 354);
            button1.Name = "button1";
            button1.Size = new Size(193, 54);
            button1.TabIndex = 25;
            button1.Text = "ᐊ GO BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(button1);
            Controls.Add(textBoxCODE);
            Controls.Add(label1);
            Controls.Add(button2);
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
        private Button button2;
        private Label label1;
        private TextBox textBoxCODE;
        private Button button1;
    }
}