namespace Laundryku
{
    partial class FormTransaksi
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
            inputnold = new Label();
            inputtgl = new Label();
            telepon = new Label();
            label5 = new Label();
            tanggal = new TextBox();
            telp = new TextBox();
            inputnama = new TextBox();
            nold = new TextBox();
            label6 = new Label();
            inputotal = new Label();
            inputbrt = new Label();
            paket = new TextBox();
            berat = new TextBox();
            total = new TextBox();
            button2 = new Button();
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
            panelUnguAtas.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 82, 112);
            button1.BackgroundImage = Properties.Resources.RumahHijau_removebg_preview;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(847, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 77);
            button1.TabIndex = 22;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(868, 80);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 20;
            label1.Text = "Home";
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Transaksi_removebg_preview1;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(387, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 52);
            panel7.TabIndex = 19;
            // 
            // inputnold
            // 
            inputnold.AutoSize = true;
            inputnold.Location = new Point(103, 247);
            inputnold.Name = "inputnold";
            inputnold.Size = new Size(72, 15);
            inputnold.TabIndex = 2;
            inputnold.Text = "No. Laundry";
            // 
            // inputtgl
            // 
            inputtgl.AutoSize = true;
            inputtgl.Location = new Point(103, 180);
            inputtgl.Name = "inputtgl";
            inputtgl.Size = new Size(48, 15);
            inputtgl.TabIndex = 3;
            inputtgl.Text = "Tanggal";
            // 
            // telepon
            // 
            telepon.AutoSize = true;
            telepon.Location = new Point(103, 375);
            telepon.Name = "telepon";
            telepon.Size = new Size(70, 15);
            telepon.TabIndex = 4;
            telepon.Text = "No. Telepon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 308);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Nama";
            // 
            // tanggal
            // 
            tanggal.Location = new Point(232, 177);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(178, 23);
            tanggal.TabIndex = 6;
            // 
            // telp
            // 
            telp.Location = new Point(232, 372);
            telp.Name = "telp";
            telp.Size = new Size(178, 23);
            telp.TabIndex = 7;
            // 
            // inputnama
            // 
            inputnama.Location = new Point(232, 305);
            inputnama.Name = "inputnama";
            inputnama.Size = new Size(178, 23);
            inputnama.TabIndex = 8;
            // 
            // nold
            // 
            nold.Location = new Point(232, 239);
            nold.Name = "nold";
            nold.Size = new Size(178, 23);
            nold.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 177);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 10;
            label6.Text = "Jenis Paket";
            // 
            // inputotal
            // 
            inputotal.AutoSize = true;
            inputotal.Location = new Point(553, 308);
            inputotal.Name = "inputotal";
            inputotal.Size = new Size(67, 15);
            inputotal.TabIndex = 11;
            inputotal.Text = "Total Harga";
            // 
            // inputbrt
            // 
            inputbrt.AutoSize = true;
            inputbrt.Location = new Point(553, 242);
            inputbrt.Name = "inputbrt";
            inputbrt.Size = new Size(58, 15);
            inputbrt.TabIndex = 12;
            inputbrt.Text = "Berat (kg)";
            // 
            // paket
            // 
            paket.Location = new Point(656, 174);
            paket.Name = "paket";
            paket.Size = new Size(178, 23);
            paket.TabIndex = 13;
            // 
            // berat
            // 
            berat.Location = new Point(656, 239);
            berat.Name = "berat";
            berat.Size = new Size(178, 23);
            berat.TabIndex = 14;
            // 
            // total
            // 
            total.Location = new Point(656, 305);
            total.Name = "total";
            total.Size = new Size(178, 23);
            total.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 82, 112);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(725, 356);
            button2.Name = "button2";
            button2.Size = new Size(109, 39);
            button2.TabIndex = 16;
            button2.Text = "SIMPAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(76, 82, 112);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(725, 412);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 17;
            button3.Text = "NEXT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 252);
            ClientSize = new Size(950, 502);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(total);
            Controls.Add(berat);
            Controls.Add(paket);
            Controls.Add(inputbrt);
            Controls.Add(inputotal);
            Controls.Add(label6);
            Controls.Add(nold);
            Controls.Add(inputnama);
            Controls.Add(telp);
            Controls.Add(tanggal);
            Controls.Add(label5);
            Controls.Add(telepon);
            Controls.Add(inputtgl);
            Controls.Add(inputnold);
            Controls.Add(panelUnguAtas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            panelUnguAtas.ResumeLayout(false);
            panelUnguAtas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUnguAtas;
        private Label label1;
        private Panel panel7;
        private Button button1;
        private Label inputnold;
        private Label inputtgl;
        private Label telepon;
        private Label label5;
        private TextBox tanggal;
        private TextBox telp;
        private TextBox inputnama;
        private TextBox nold;
        private Label label6;
        private Label inputotal;
        private Label inputbrt;
        private TextBox paket;
        private TextBox berat;
        private TextBox total;
        private Button button2;
        private Button button3;
    }
}