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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(471, 198);
            button2.Name = "button2";
            button2.Size = new Size(251, 54);
            button2.TabIndex = 16;
            button2.Text = "withdraw";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(471, 273);
            button3.Name = "button3";
            button3.Size = new Size(251, 54);
            button3.TabIndex = 17;
            button3.Text = "deposit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Lime;
            button4.Location = new Point(471, 347);
            button4.Name = "button4";
            button4.Size = new Size(251, 54);
            button4.TabIndex = 18;
            button4.Text = "transfer";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Lime;
            button5.Location = new Point(471, 128);
            button5.Name = "button5";
            button5.Size = new Size(251, 54);
            button5.TabIndex = 19;
            button5.Text = "check your balance";
            button5.UseVisualStyleBackColor = false;
            // 
            // ChooceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}