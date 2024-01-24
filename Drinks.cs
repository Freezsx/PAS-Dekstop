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
    public partial class Drinks : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Drinks(string user, string pass)
        {
            InitializeComponent();
            Username = user;
            Password = pass;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Log Out ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();

                form1.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods(Username, Password);

            foods.Show();
            this.Hide();
        }

        private void btnmmn_Click(object sender, EventArgs e)
        {
            Memesan memesan = new Memesan(Username, Password);

            memesan.Show();
            this.Hide();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            About about = new About(Username, Password);

            about.Show();
            this.Hide();
        }
    }
}
