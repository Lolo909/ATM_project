namespace ATM_project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ATM = new PictureBox();
            text_on_ATM = new Label();
            frame1_of_ATM = new Panel();
            frame2_of_ATM = new Panel();
            frame4_of_ATM = new Panel();
            frame3_of_ATM = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBoxCODE = new TextBox();
            textBoxPIN = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ATM).BeginInit();
            SuspendLayout();
            // 
            // ATM
            // 
            ATM.Image = (Image)resources.GetObject("ATM.Image");
            ATM.Location = new Point(55, 31);
            ATM.Name = "ATM";
            ATM.Size = new Size(344, 377);
            ATM.SizeMode = PictureBoxSizeMode.StretchImage;
            ATM.TabIndex = 1;
            ATM.TabStop = false;
            // 
            // text_on_ATM
            // 
            text_on_ATM.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            text_on_ATM.ForeColor = Color.Lime;
            text_on_ATM.Location = new Point(107, 175);
            text_on_ATM.Name = "text_on_ATM";
            text_on_ATM.Size = new Size(134, 33);
            text_on_ATM.TabIndex = 2;
            text_on_ATM.Text = "Welcome!";
            // 
            // frame1_of_ATM
            // 
            frame1_of_ATM.BackColor = SystemColors.ControlText;
            frame1_of_ATM.Location = new Point(55, 25);
            frame1_of_ATM.Name = "frame1_of_ATM";
            frame1_of_ATM.Size = new Size(343, 10);
            frame1_of_ATM.TabIndex = 3;
            // 
            // frame2_of_ATM
            // 
            frame2_of_ATM.BackColor = SystemColors.ControlText;
            frame2_of_ATM.Location = new Point(55, 398);
            frame2_of_ATM.Name = "frame2_of_ATM";
            frame2_of_ATM.Size = new Size(343, 10);
            frame2_of_ATM.TabIndex = 5;
            // 
            // frame4_of_ATM
            // 
            frame4_of_ATM.BackColor = SystemColors.ControlText;
            frame4_of_ATM.Location = new Point(388, 25);
            frame4_of_ATM.Name = "frame4_of_ATM";
            frame4_of_ATM.Size = new Size(11, 383);
            frame4_of_ATM.TabIndex = 6;
            // 
            // frame3_of_ATM
            // 
            frame3_of_ATM.BackColor = SystemColors.ControlText;
            frame3_of_ATM.Location = new Point(55, 25);
            frame3_of_ATM.Name = "frame3_of_ATM";
            frame3_of_ATM.Size = new Size(12, 383);
            frame3_of_ATM.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(422, 139);
            label1.Name = "label1";
            label1.Size = new Size(107, 51);
            label1.TabIndex = 8;
            label1.Text = "Code:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(447, 242);
            label2.Name = "label2";
            label2.Size = new Size(82, 54);
            label2.TabIndex = 9;
            label2.Text = "PIN:";
            // 
            // textBoxCODE
            // 
            textBoxCODE.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCODE.Location = new Point(525, 147);
            textBoxCODE.MaxLength = 12;
            textBoxCODE.Name = "textBoxCODE";
            textBoxCODE.Size = new Size(193, 43);
            textBoxCODE.TabIndex = 10;
            // 
            // textBoxPIN
            // 
            textBoxPIN.Cursor = Cursors.IBeam;
            textBoxPIN.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPIN.Location = new Point(525, 245);
            textBoxPIN.MaxLength = 4;
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.PasswordChar = '*';
            textBoxPIN.Size = new Size(193, 43);
            textBoxPIN.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(525, 337);
            button1.Name = "button1";
            button1.Size = new Size(193, 54);
            button1.TabIndex = 12;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 453);
            Controls.Add(button1);
            Controls.Add(textBoxPIN);
            Controls.Add(textBoxCODE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(frame3_of_ATM);
            Controls.Add(frame4_of_ATM);
            Controls.Add(frame2_of_ATM);
            Controls.Add(frame1_of_ATM);
            Controls.Add(text_on_ATM);
            Controls.Add(ATM);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)ATM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ATM;
        private Label text_on_ATM;
        private Panel frame1_of_ATM;
        private Panel frame2_of_ATM;
        private Panel frame4_of_ATM;
        private Panel frame3_of_ATM;
        private Label label1;
        private Label label2;
        private TextBox textBoxCODE;
        private TextBox textBoxPIN;
        private Button button1;
    }
}