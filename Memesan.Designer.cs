namespace PAS
{
    partial class Memesan
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnmkn = new Button();
            btnmnm = new Button();
            btnmms = new Button();
            btnabout = new Button();
            btnLogOut = new Button();
            label2 = new Label();
            cbPilih = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbTambah = new TextBox();
            label6 = new Label();
            label7 = new Label();
            numericBrp = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            ptrGambar = new PictureBox();
            btnTambah = new Button();
            label10 = new Label();
            label11 = new Label();
            cmbHarga = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtTotal = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbdata = new ListBox();
            btnBayar = new Button();
            btnBeli = new Button();
            btnClear = new Button();
            cmbDiskon = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBrp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrGambar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 558);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 54);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("STZhongsong", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 23);
            label1.TabIndex = 3;
            label1.Text = "Silahkan Memesan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Kriug;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnmkn
            // 
            btnmkn.BackColor = Color.White;
            btnmkn.FlatAppearance.BorderSize = 0;
            btnmkn.FlatStyle = FlatStyle.Flat;
            btnmkn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmkn.Location = new Point(3, 245);
            btnmkn.Name = "btnmkn";
            btnmkn.Size = new Size(244, 38);
            btnmkn.TabIndex = 3;
            btnmkn.Text = "Makanan";
            btnmkn.UseVisualStyleBackColor = false;
            btnmkn.Click += btnmkn_Click;
            // 
            // btnmnm
            // 
            btnmnm.BackColor = Color.White;
            btnmnm.FlatAppearance.BorderSize = 0;
            btnmnm.FlatStyle = FlatStyle.Flat;
            btnmnm.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmnm.Location = new Point(3, 301);
            btnmnm.Name = "btnmnm";
            btnmnm.Size = new Size(244, 38);
            btnmnm.TabIndex = 4;
            btnmnm.Text = "Minuman";
            btnmnm.UseVisualStyleBackColor = false;
            btnmnm.Click += btnmnm_Click;
            // 
            // btnmms
            // 
            btnmms.BackColor = Color.White;
            btnmms.FlatAppearance.BorderSize = 0;
            btnmms.FlatStyle = FlatStyle.Flat;
            btnmms.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmms.Location = new Point(3, 355);
            btnmms.Name = "btnmms";
            btnmms.Size = new Size(244, 38);
            btnmms.TabIndex = 5;
            btnmms.Text = "Memesan";
            btnmms.UseVisualStyleBackColor = false;
            // 
            // btnabout
            // 
            btnabout.BackColor = Color.White;
            btnabout.FlatAppearance.BorderSize = 0;
            btnabout.FlatStyle = FlatStyle.Flat;
            btnabout.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnabout.Location = new Point(3, 408);
            btnabout.Name = "btnabout";
            btnabout.Size = new Size(244, 38);
            btnabout.TabIndex = 6;
            btnabout.Text = "About";
            btnabout.UseVisualStyleBackColor = false;
            btnabout.Click += btnabout_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Black;
            btnLogOut.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(23, 484);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(206, 62);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(285, 87);
            label2.Name = "label2";
            label2.Size = new Size(170, 24);
            label2.TabIndex = 8;
            label2.Text = "Tambah Barang";
            // 
            // cbPilih
            // 
            cbPilih.FormattingEnabled = true;
            cbPilih.Location = new Point(497, 148);
            cbPilih.Name = "cbPilih";
            cbPilih.Size = new Size(166, 28);
            cbPilih.TabIndex = 9;
            cbPilih.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(461, 87);
            label3.Name = "label3";
            label3.Size = new Size(17, 24);
            label3.TabIndex = 10;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(285, 147);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 11;
            label4.Text = "Pilih Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(461, 147);
            label5.Name = "label5";
            label5.Size = new Size(17, 24);
            label5.TabIndex = 12;
            label5.Text = ":";
            // 
            // txbTambah
            // 
            txbTambah.Location = new Point(497, 88);
            txbTambah.Name = "txbTambah";
            txbTambah.Size = new Size(166, 27);
            txbTambah.TabIndex = 13;
            txbTambah.TextChanged += txbTambah_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(285, 211);
            label6.Name = "label6";
            label6.Size = new Size(132, 24);
            label6.TabIndex = 14;
            label6.Text = "Beli Berapa ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(461, 211);
            label7.Name = "label7";
            label7.Size = new Size(17, 24);
            label7.TabIndex = 15;
            label7.Text = ":";
            // 
            // numericBrp
            // 
            numericBrp.Location = new Point(497, 213);
            numericBrp.Name = "numericBrp";
            numericBrp.Size = new Size(49, 27);
            numericBrp.TabIndex = 17;
            numericBrp.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(285, 282);
            label8.Name = "label8";
            label8.Size = new Size(169, 24);
            label8.TabIndex = 18;
            label8.Text = "Gambar Barang";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(461, 282);
            label9.Name = "label9";
            label9.Size = new Size(17, 24);
            label9.TabIndex = 19;
            label9.Text = ":";
            // 
            // ptrGambar
            // 
            ptrGambar.BackColor = Color.White;
            ptrGambar.Location = new Point(497, 282);
            ptrGambar.Name = "ptrGambar";
            ptrGambar.Size = new Size(193, 164);
            ptrGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrGambar.TabIndex = 20;
            ptrGambar.TabStop = false;
            ptrGambar.Click += ptrGambar_Click;
            // 
            // btnTambah
            // 
            btnTambah.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.Location = new Point(688, 88);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 21;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(686, 147);
            label10.Name = "label10";
            label10.Size = new Size(150, 24);
            label10.TabIndex = 22;
            label10.Text = "Harga Barang";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(862, 147);
            label11.Name = "label11";
            label11.Size = new Size(17, 24);
            label11.TabIndex = 23;
            label11.Text = ":";
            // 
            // cmbHarga
            // 
            cmbHarga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHarga.FormattingEnabled = true;
            cmbHarga.Items.AddRange(new object[] { "", "3000", "4000", "5000", "6000", "10000", "12000", "15000", "17000", "25000" });
            cmbHarga.Location = new Point(898, 148);
            cmbHarga.Name = "cmbHarga";
            cmbHarga.Size = new Size(151, 28);
            cmbHarga.TabIndex = 24;
            cmbHarga.SelectedIndexChanged += cmbHarga_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(862, 233);
            label12.Name = "label12";
            label12.Size = new Size(17, 24);
            label12.TabIndex = 26;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(688, 234);
            label13.Name = "label13";
            label13.Size = new Size(127, 24);
            label13.TabIndex = 25;
            label13.Text = "Total Harga";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(898, 234);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(151, 27);
            txtTotal.TabIndex = 27;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbdata);
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(712, 282);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(337, 264);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // lbdata
            // 
            lbdata.ForeColor = Color.Black;
            lbdata.FormattingEnabled = true;
            lbdata.ItemHeight = 20;
            lbdata.Location = new Point(3, 3);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(333, 264);
            lbdata.TabIndex = 0;
            lbdata.SelectedIndexChanged += lbdata_SelectedIndexChanged;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.Black;
            btnBayar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(285, 468);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(94, 61);
            btnBayar.TabIndex = 29;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += button2_Click;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.Black;
            btnBeli.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(415, 468);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(94, 61);
            btnBeli.TabIndex = 30;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(540, 468);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 61);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbDiskon
            // 
            cmbDiskon.FormattingEnabled = true;
            cmbDiskon.Items.AddRange(new object[] { "", "2000", "3000", "5000", "6000" });
            cmbDiskon.Location = new Point(897, 191);
            cmbDiskon.Name = "cmbDiskon";
            cmbDiskon.Size = new Size(151, 28);
            cmbDiskon.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(688, 191);
            label14.Name = "label14";
            label14.Size = new Size(157, 24);
            label14.TabIndex = 33;
            label14.Text = "Diskon Barang";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(862, 190);
            label15.Name = "label15";
            label15.Size = new Size(17, 24);
            label15.TabIndex = 34;
            label15.Text = ":";
            // 
            // Memesan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1083, 558);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(cmbDiskon);
            Controls.Add(btnClear);
            Controls.Add(btnBeli);
            Controls.Add(btnBayar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtTotal);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(cmbHarga);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnTambah);
            Controls.Add(ptrGambar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(numericBrp);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txbTambah);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbPilih);
            Controls.Add(label2);
            Controls.Add(btnLogOut);
            Controls.Add(btnabout);
            Controls.Add(btnmms);
            Controls.Add(btnmnm);
            Controls.Add(btnmkn);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Memesan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memesan";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBrp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrGambar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnmkn;
        private Button btnmnm;
        private Button btnmms;
        private Button btnabout;
        private Button btnLogOut;
        private Label label2;
        private ComboBox cbPilih;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbTambah;
        private Label label6;
        private Label label7;
        private NumericUpDown numericBrp;
        private Label label8;
        private Label label9;
        private PictureBox ptrGambar;
        private Button btnTambah;
        private Label label10;
        private Label label11;
        private ComboBox cmbHarga;
        private Label label12;
        private Label label13;
        private TextBox txtTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox lbdata;
        private Button btnBayar;
        private Button btnBeli;
        private Button btnClear;
        private ComboBox cmbDiskon;
        private Label label14;
        private Label label15;
    }
}