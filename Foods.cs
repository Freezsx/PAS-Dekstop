using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS
{
    public partial class Foods : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Foods(string user, string pass)
        {
            InitializeComponent();
            Username = user;
            Password = pass;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Foods_Load(object sender, EventArgs e)
        {

        }

        private void btnmms_Click(object sender, EventArgs e)
        {
            Memesan memesan = new Memesan(Username, Password);

            memesan.Show();
            this.Hide();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            About about = new About(Username, Password);

            about.Show();
            this.Hide();
        }
    }
}
