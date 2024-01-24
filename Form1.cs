namespace PAS
{
    public partial class Form1 : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" || txtPassword.Text != "" || txtConfirmPassword.Text != "")
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Close();
                    Application.Exit();
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ClearTextBox(object sender, EventArgs e) 
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtUsername) || IsTextBoxEmpty(txtPassword) || IsTextBoxEmpty(txtConfirmPassword))
            {
                MessageBox.Show("Harap isi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    About aboutForm = new About(txtUsername.Text, txtPassword.Text);
                    aboutForm.Show();
                    this.Hide();

                    MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Konfirmasi password harus sama dengan password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearTextBox(sender, e);
                }
            }
        }

        private bool IsTextBoxEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
}