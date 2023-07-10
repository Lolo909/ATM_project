namespace ATM_project
{
    partial class WithdrawDoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawDoneForm));
            frame3_of_ATM = new Panel();
            frame4_of_ATM = new Panel();
            frame2_of_ATM = new Panel();
            frame1_of_ATM = new Panel();
            ATM = new PictureBox();
            text_on_ATM = new Label();
            label1 = new Label();
            result_label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
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
            // text_on_ATM
            // 
            text_on_ATM.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            text_on_ATM.ForeColor = Color.Lime;
            text_on_ATM.Location = new Point(107, 160);
            text_on_ATM.Name = "text_on_ATM";
            text_on_ATM.Size = new Size(134, 50);
            text_on_ATM.TabIndex = 10;
            text_on_ATM.Text = "✓";
            text_on_ATM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(470, 31);
            label1.Name = "label1";
            label1.Size = new Size(251, 91);
            label1.TabIndex = 15;
            label1.Text = "Done.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // result_label
            // 
            result_label.BackColor = Color.Navy;
            result_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            result_label.ForeColor = Color.Yellow;
            result_label.Location = new Point(470, 122);
            result_label.Name = "result_label";
            result_label.Size = new Size(251, 286);
            result_label.TabIndex = 16;
            result_label.Text = "100 - 0\r\n50 - 0\r\n20 - 0\r\n10 - 0";
            result_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Location = new Point(470, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 10);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(470, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 10);
            panel2.TabIndex = 18;
            // 
            // WithdrawDoneForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(result_label);
            Controls.Add(label1);
            Controls.Add(text_on_ATM);
            Controls.Add(frame3_of_ATM);
            Controls.Add(frame4_of_ATM);
            Controls.Add(frame2_of_ATM);
            Controls.Add(frame1_of_ATM);
            Controls.Add(ATM);
            Name = "WithdrawDoneForm";
            Text = "WithdrawDoneForm";
            ((System.ComponentModel.ISupportInitialize)ATM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel frame3_of_ATM;
        private Panel frame4_of_ATM;
        private Panel frame2_of_ATM;
        private Panel frame1_of_ATM;
        private PictureBox ATM;
        private Label text_on_ATM;
        private Label label1;
        private Label result_label;
        private Panel panel1;
        private Panel panel2;
    }
}