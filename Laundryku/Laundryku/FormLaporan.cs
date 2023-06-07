using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Laundryku
{
    public partial class FormLaporan : Form
    {
        // koneksi ke db laundryku menggunakan db mysql
        string cnnString = "Server=127.0.0.1;UID=root;PWD=;Database=dblaundryku";
        MySqlConnection myConnection;
        public FormLaporan()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // btn klik untuk kembali ke form home
            new FormHome().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Laporan.Items.Clear();
            if (mySqlConnect())
            {
                // memanggil data transaksi untuk ditampilkan ke form laporan
                string query = "SELECT * FROM transaksi";
                var cmd = new MySqlCommand(query, myConnection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime Tanggal = reader.GetDateTime(0);
                    uint nold = reader.GetUInt32(1);
                    string inputnama = reader.GetString(2);
                    uint notelp = reader.GetUInt32(3);
                    string paket = reader.GetString(4);
                    uint berat = reader.GetUInt32(5);
                    uint total = reader.GetUInt32(6);
                    Laporan.Items.Add(Tanggal + "   \t|    " + nold + "   \t|   " + inputnama + "   \t|   " + notelp + "   \t|   " + paket + "   \t|   " + berat + "   \t|   " + total);
                }
                mySqlDisConnect();
            }
        }
    }
}