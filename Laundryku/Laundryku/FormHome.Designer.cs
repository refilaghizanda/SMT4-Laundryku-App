namespace Laundryku
{
    partial class FormHome
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
            panelUnguAtas = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panelUnguAtas.SuspendLayout();
            SuspendLayout();
            // 
            // panelUnguAtas
            // 
            panelUnguAtas.BackColor = Color.FromArgb(76, 82, 112);
            panelUnguAtas.Controls.Add(button2);
            panelUnguAtas.Controls.Add(button1);
            panelUnguAtas.Controls.Add(panel7);
            panelUnguAtas.Controls.Add(label2);
            panelUnguAtas.Controls.Add(label1);
            panelUnguAtas.Dock = DockStyle.Top;
            panelUnguAtas.Location = new Point(0, 0);
            panelUnguAtas.Name = "panelUnguAtas";
            panelUnguAtas.Size = new Size(950, 95);
            panelUnguAtas.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 82, 112);
            button2.BackgroundImage = Properties.Resources.LogoBtnLaporan;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(113, 3);
            button2.Name = "button2";
            button2.Size = new Size(80, 75);
            button2.TabIndex = 3;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 82, 112);
            button1.BackgroundImage = Properties.Resources.LogoBtnMesin;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(15, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 75);
            button1.TabIndex = 2;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Home;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(387, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 52);
            panel7.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 16;
            label2.Text = "Laporan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 78);
            label1.Name = "label1";
            label1.Size = new Size(54, 13);
            label1.TabIndex = 15;
            label1.Text = "Transaksi";
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.SelamatDatang;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(314, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(328, 53);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.LogoMesinBesar;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(345, 222);
            panel6.Name = "panel6";
            panel6.Size = new Size(297, 236);
            panel6.TabIndex = 1;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 252);
            ClientSize = new Size(950, 502);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panelUnguAtas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            panelUnguAtas.ResumeLayout(false);
            panelUnguAtas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUnguAtas;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Panel panel7;
        private Button button1;
        private Button button2;
    }
}