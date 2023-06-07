using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundryku
{
    public partial class FormTransaksi : Form
    {
        // koneksi ke dblaundryku menggunakan mysql
        string cnnString = "Server=127.0.0.1;UID=root;PWD=;Database=dblaundryku";
        MySqlConnection myConnection;
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btn klik untuk kembali ke form home
            new FormHome().Show();
            this.Hide();
        }

        private bool mySqlConnect()
        {
            myConnection = new MySqlConnection(cnnString);
            try
            {
                myConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                // untuk menampilkan pesan ketika data transaksi berhasil disimpan
                MessageBox.Show("Data berhasil disimpan!" + ex);
                return false;
            }

        }
        private void mySqlDisConnect()
        {
            myConnection.Close();
        }

        private void bttnKoneksiMYSQL_Click_1(object sender, EventArgs e)
        {
            if (mySqlConnect())
                MessageBox.Show("Data disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // inisialiasasi variabel data transaksi untuk konek dengan database
            string nama = inputnama.Text;
            string inputpkt = paket.Text;
            uint inputnold = uint.Parse(nold.Text);
            uint notelp = uint.Parse(telp.Text);
            uint inputbrt = uint.Parse(berat.Text);
            uint inputotal = uint.Parse(total.Text);
            if (mySqlConnect())
            {
                String query = string.Format("INSERT INTO transaksi(tanggal, nolaundry, namapelanggan, notelp, paket, berat, total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    (object)DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"),
                    (object)inputnold,
                    (object)nama,
                    (object)notelp,
                    (object)inputpkt,
                    (object)inputbrt,
                    (object)inputotal);
                var cmd = new MySqlCommand(query, myConnection);
                cmd.ExecuteNonQuery();
                mySqlDisConnect();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // btn klik untuk masuk ke form laporan
            new FormLaporan().Show();
            this.Hide();
        }
    }
}
