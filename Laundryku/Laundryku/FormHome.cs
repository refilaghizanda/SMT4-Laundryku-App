using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundryku
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btn klik untuk masuk ke form transaksi
            new FormTransaksi().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btn klik untuk masuk ke form laporan
            new FormLaporan().Show();
            this.Hide();
        }
    }
}
