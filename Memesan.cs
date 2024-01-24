using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAS
{
    public partial class Memesan : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Memesan(string user, string pass)
        {
            InitializeComponent();
            Username = user;
            Password = pass;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Log Out ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();

                form1.Show();
                this.Hide();
            }
        }

        private void btnmnm_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks(Username, Password);

            drinks.Show();
            this.Hide();
        }

        private void btnmkn_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods(Username, Password);

            foods.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cbPilih.Text;

            switch (selectedText)
            {
                case "Ayam Bakar":
                    ptrGambar.Image = Properties.Resources.ayambakar;
                    break;
                case "Nasi Goreng":
                    ptrGambar.Image = Properties.Resources.nasigoreng;
                    break;
                case "Bakso":
                    ptrGambar.Image = Properties.Resources.bakso;
                    break;
                case "Mie Ayam":
                    ptrGambar.Image = Properties.Resources.mieayam;
                    break;
                case "Ikan Bakar":
                    ptrGambar.Image = Properties.Resources.ikan_bakar;
                    break;
                case "Soto Ayam":
                    ptrGambar.Image = Properties.Resources.soto;
                    break;
                case "Es Teh":
                    ptrGambar.Image = Properties.Resources.esteh;
                    break;
                case "Es Jeruk":
                    ptrGambar.Image = Properties.Resources.esjerok;
                    break;
                case "Es Susu":
                    ptrGambar.Image = Properties.Resources.essusu;
                    break;
                case "Es Cincau":
                    ptrGambar.Image = Properties.Resources.escincau;
                    break;
                case "Kopi":
                    ptrGambar.Image = Properties.Resources.kopi;
                    break;
                case "Es Degan":
                    ptrGambar.Image = Properties.Resources.esdegan;
                    break;
                default:
                    break;
            }
        }

        private void txbTambah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string tambahBarang = txbTambah.Text;

            if (!string.IsNullOrWhiteSpace(tambahBarang))
            {
                if (!cbPilih.Items.Contains(tambahBarang))
                {
                    cbPilih.Items.Add(tambahBarang);
                }
                else
                {
                    MessageBox.Show("Barang sudah ada dalam daftar!");
                }
            }
            else
            {
                MessageBox.Show("Tidak boleh kosong!");
            }
        }

        private void ptrGambar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbHarga.SelectedItem != null)
            {
                int hargavalue = int.Parse(cmbHarga.SelectedItem.ToString());

                int jumlah = (int)numericBrp.Value;

                int diskon = int.Parse(cmbDiskon.SelectedItem.ToString());

                int result = (hargavalue * jumlah) - diskon;

                txtTotal.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Pilih harga dan jumlah terlebih dahulu!");
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            int jumlah = (int)numericBrp.Value;
            string harga = cmbHarga.SelectedItem?.ToString();
            string total = txtTotal.Text;
            string diskon = cmbDiskon.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(harga) && !string.IsNullOrEmpty(diskon) && !string.IsNullOrEmpty(cbPilih.Text) && jumlah != 0)
            {
                lbdata.Items.Clear();

                lbdata.Items.Add("Kamu telah memesan : " + cbPilih.Text);
                lbdata.Items.Add("Sebanyak : " + jumlah + "x");
                lbdata.Items.Add("Diskon : " + diskon);
                lbdata.Items.Add("Dengan harga : Rp. " + harga);
                lbdata.Items.Add("Total harga : Rp. " + total);
            }
            else
            {
                MessageBox.Show("Pilih item, jumlah, tambah, harga terlebih dahulu!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Reset ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                cbPilih.Text = "";
                numericBrp.Value = 0;
                txtTotal.Clear();
                ptrGambar.Image = null;
                lbdata.Items.Clear();
                txbTambah.Clear();
                cmbHarga.SelectedIndex = 0;
                cmbDiskon.SelectedIndex = 0;
            }
        }

        private void cmbHarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            About about = new About(Username, Password);

            about.Show();
            this.Hide();
        }

        private void lbdata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
