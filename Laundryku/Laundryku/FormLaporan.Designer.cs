namespace Laundryku
{
    partial class FormLaporan
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
            button1 = new Button();
            label1 = new Label();
            panel7 = new Panel();
            Laporan = new ListBox();
            button3 = new Button();
            panelUnguAtas.SuspendLayout();
            SuspendLayout();
            // 
            // panelUnguAtas
            // 
            panelUnguAtas.BackColor = Color.FromArgb(76, 82, 112);
            panelUnguAtas.Controls.Add(button1);
            panelUnguAtas.Controls.Add(label1);
            panelUnguAtas.Controls.Add(panel7);
            panelUnguAtas.Dock = DockStyle.Top;
            panelUnguAtas.Location = new Point(0, 0);
            panelUnguAtas.Name = "panelUnguAtas";
            panelUnguAtas.Size = new Size(950, 95);
            panelUnguAtas.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 82, 112);
            button1.BackgroundImage = Properties.Resources.RumahHijau_removebg_preview;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(844, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 77);
            button1.TabIndex = 23;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(866, 82);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 20;
            label1.Text = "Home";
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Laporan_removebg_preview;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(387, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 52);
            panel7.TabIndex = 19;
            // 
            // Laporan
            // 
            Laporan.FormattingEnabled = true;
            Laporan.ItemHeight = 15;
            Laporan.Location = new Point(174, 140);
            Laporan.Name = "Laporan";
            Laporan.Size = new Size(618, 304);
            Laporan.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(76, 82, 112);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(37, 113);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 18;
            button3.Text = "Tampilkan Data";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 252);
            ClientSize = new Size(950, 502);
            Controls.Add(button3);
            Controls.Add(Laporan);
            Controls.Add(panelUnguAtas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLaporan";
            StartPosition = FormStartPosition.CenterScreen;
            panelUnguAtas.ResumeLayout(false);
            panelUnguAtas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUnguAtas;
        private Label label1;
        private Panel panel7;
        private Button button1;
        private ListBox Laporan;
        private Button button3;
    }
}