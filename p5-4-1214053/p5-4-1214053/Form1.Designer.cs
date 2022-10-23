namespace p5_4_1214053
{
    partial class Form1
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.PilihJKK = new System.Windows.Forms.ComboBox();
            this.TglLahirr = new System.Windows.Forms.DateTimePicker();
            this.jadwal = new System.Windows.Forms.GroupBox();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.FormPendaftaran = new System.Windows.Forms.Label();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.jadwal.SuspendLayout();
            this.kelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(320, 98);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(168, 20);
            this.txtNama.TabIndex = 5;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // PilihJKK
            // 
            this.PilihJKK.FormattingEnabled = true;
            this.PilihJKK.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.PilihJKK.Location = new System.Drawing.Point(320, 147);
            this.PilihJKK.Margin = new System.Windows.Forms.Padding(2);
            this.PilihJKK.Name = "PilihJKK";
            this.PilihJKK.Size = new System.Drawing.Size(131, 21);
            this.PilihJKK.TabIndex = 6;
            this.PilihJKK.Text = "-- Pilih Jenis Kelamin --";
            this.PilihJKK.SelectedIndexChanged += new System.EventHandler(this.PilihJKK_SelectedIndexChanged);
            // 
            // TglLahirr
            // 
            this.TglLahirr.Location = new System.Drawing.Point(320, 196);
            this.TglLahirr.Margin = new System.Windows.Forms.Padding(2);
            this.TglLahirr.Name = "TglLahirr";
            this.TglLahirr.Size = new System.Drawing.Size(190, 20);
            this.TglLahirr.TabIndex = 7;
            this.TglLahirr.Tag = "";
            // 
            // jadwal
            // 
            this.jadwal.BackColor = System.Drawing.Color.Transparent;
            this.jadwal.Controls.Add(this.rbJadwal2);
            this.jadwal.Controls.Add(this.rbJadwal1);
            this.jadwal.Controls.Add(this.rbJadwal3);
            this.jadwal.Controls.Add(this.rbJadwal4);
            this.jadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal.Location = new System.Drawing.Point(528, 233);
            this.jadwal.Margin = new System.Windows.Forms.Padding(2);
            this.jadwal.Name = "jadwal";
            this.jadwal.Padding = new System.Windows.Forms.Padding(2);
            this.jadwal.Size = new System.Drawing.Size(207, 159);
            this.jadwal.TabIndex = 9;
            this.jadwal.TabStop = false;
            this.jadwal.Text = "Pilihan Jadwal";
            this.jadwal.Enter += new System.EventHandler(this.jadwal_Enter);
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.BackColor = System.Drawing.Color.Transparent;
            this.rbJadwal2.Location = new System.Drawing.Point(11, 61);
            this.rbJadwal2.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(189, 17);
            this.rbJadwal2.TabIndex = 10;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Senin && Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = false;
            this.rbJadwal2.CheckedChanged += new System.EventHandler(this.rbJadwal2_CheckedChanged);
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.BackColor = System.Drawing.Color.Transparent;
            this.rbJadwal1.Location = new System.Drawing.Point(11, 32);
            this.rbJadwal1.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(186, 17);
            this.rbJadwal1.TabIndex = 9;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin && Rabu, 14.00 - 16.00\r\n";
            this.rbJadwal1.UseVisualStyleBackColor = false;
            this.rbJadwal1.CheckedChanged += new System.EventHandler(this.rbJadwal1_CheckedChanged);
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.BackColor = System.Drawing.Color.Transparent;
            this.rbJadwal3.Location = new System.Drawing.Point(11, 90);
            this.rbJadwal3.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(185, 17);
            this.rbJadwal3.TabIndex = 11;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = false;
            this.rbJadwal3.CheckedChanged += new System.EventHandler(this.rbJadwal3_CheckedChanged);
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.BackColor = System.Drawing.Color.Transparent;
            this.rbJadwal4.Location = new System.Drawing.Point(11, 119);
            this.rbJadwal4.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(150, 17);
            this.rbJadwal4.TabIndex = 12;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = false;
            this.rbJadwal4.CheckedChanged += new System.EventHandler(this.rbJadwal4_CheckedChanged);
            // 
            // kelas
            // 
            this.kelas.BackColor = System.Drawing.Color.Transparent;
            this.kelas.Controls.Add(this.cbPiano);
            this.kelas.Controls.Add(this.cbDrum);
            this.kelas.Controls.Add(this.cbKonduktor);
            this.kelas.Controls.Add(this.cbBiola);
            this.kelas.Controls.Add(this.cbKomposer);
            this.kelas.Controls.Add(this.cbVokal);
            this.kelas.Controls.Add(this.cbGitar);
            this.kelas.Controls.Add(this.cbSaxophone);
            this.kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas.ForeColor = System.Drawing.Color.Black;
            this.kelas.Location = new System.Drawing.Point(178, 233);
            this.kelas.Margin = new System.Windows.Forms.Padding(2);
            this.kelas.Name = "kelas";
            this.kelas.Padding = new System.Windows.Forms.Padding(2);
            this.kelas.Size = new System.Drawing.Size(201, 159);
            this.kelas.TabIndex = 10;
            this.kelas.TabStop = false;
            this.kelas.Tag = "";
            this.kelas.Text = "Pilihan Kelas";
            this.kelas.Enter += new System.EventHandler(this.kelas_Enter);
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.BackColor = System.Drawing.Color.Transparent;
            this.cbPiano.Location = new System.Drawing.Point(106, 33);
            this.cbPiano.Margin = new System.Windows.Forms.Padding(2);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(58, 17);
            this.cbPiano.TabIndex = 21;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = false;
            this.cbPiano.CheckedChanged += new System.EventHandler(this.cbPiano_CheckedChanged);
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.BackColor = System.Drawing.Color.Transparent;
            this.cbDrum.Location = new System.Drawing.Point(106, 62);
            this.cbDrum.Margin = new System.Windows.Forms.Padding(2);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(55, 17);
            this.cbDrum.TabIndex = 22;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = false;
            this.cbDrum.CheckedChanged += new System.EventHandler(this.cbDrum_CheckedChanged);
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.BackColor = System.Drawing.Color.Transparent;
            this.cbKonduktor.Location = new System.Drawing.Point(13, 120);
            this.cbKonduktor.Margin = new System.Windows.Forms.Padding(2);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(84, 17);
            this.cbKonduktor.TabIndex = 18;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = false;
            this.cbKonduktor.CheckedChanged += new System.EventHandler(this.cbKonduktor_CheckedChanged);
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.BackColor = System.Drawing.Color.Transparent;
            this.cbBiola.Location = new System.Drawing.Point(13, 33);
            this.cbBiola.Margin = new System.Windows.Forms.Padding(2);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(54, 17);
            this.cbBiola.TabIndex = 15;
            this.cbBiola.Tag = "Biola";
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = false;
            this.cbBiola.CheckedChanged += new System.EventHandler(this.cbBiola_CheckedChanged);
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.BackColor = System.Drawing.Color.Transparent;
            this.cbKomposer.Location = new System.Drawing.Point(106, 120);
            this.cbKomposer.Margin = new System.Windows.Forms.Padding(2);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(81, 17);
            this.cbKomposer.TabIndex = 20;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = false;
            this.cbKomposer.CheckedChanged += new System.EventHandler(this.cbKomposer_CheckedChanged);
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.BackColor = System.Drawing.Color.Transparent;
            this.cbVokal.Location = new System.Drawing.Point(106, 91);
            this.cbVokal.Margin = new System.Windows.Forms.Padding(2);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(58, 17);
            this.cbVokal.TabIndex = 19;
            this.cbVokal.Tag = "Vokal";
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = false;
            this.cbVokal.CheckedChanged += new System.EventHandler(this.cbVokal_CheckedChanged);
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.BackColor = System.Drawing.Color.Transparent;
            this.cbGitar.Location = new System.Drawing.Point(13, 62);
            this.cbGitar.Margin = new System.Windows.Forms.Padding(2);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(53, 17);
            this.cbGitar.TabIndex = 16;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = false;
            this.cbGitar.CheckedChanged += new System.EventHandler(this.cbGitar_CheckedChanged);
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.BackColor = System.Drawing.Color.Transparent;
            this.cbSaxophone.Location = new System.Drawing.Point(13, 91);
            this.cbSaxophone.Margin = new System.Windows.Forms.Padding(2);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(89, 17);
            this.cbSaxophone.TabIndex = 17;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = false;
            this.cbSaxophone.CheckedChanged += new System.EventHandler(this.cbSaxophone_CheckedChanged);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.BackColor = System.Drawing.Color.Transparent;
            this.Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(188, 98);
            this.Nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(45, 15);
            this.Nama.TabIndex = 11;
            this.Nama.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.BackColor = System.Drawing.Color.Transparent;
            this.JenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisKelamin.Location = new System.Drawing.Point(182, 153);
            this.JenisKelamin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(98, 15);
            this.JenisKelamin.TabIndex = 12;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.BackColor = System.Drawing.Color.Transparent;
            this.TanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalLahir.Location = new System.Drawing.Point(188, 200);
            this.TanggalLahir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(96, 15);
            this.TanggalLahir.TabIndex = 13;
            this.TanggalLahir.Text = "Tanggal Lahir";
            // 
            // FormPendaftaran
            // 
            this.FormPendaftaran.AutoSize = true;
            this.FormPendaftaran.BackColor = System.Drawing.Color.Transparent;
            this.FormPendaftaran.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormPendaftaran.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormPendaftaran.Location = new System.Drawing.Point(248, 46);
            this.FormPendaftaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormPendaftaran.Name = "FormPendaftaran";
            this.FormPendaftaran.Size = new System.Drawing.Size(262, 30);
            this.FormPendaftaran.TabIndex = 24;
            this.FormPendaftaran.Text = "FORM PENDAFTARAN";
            this.FormPendaftaran.Click += new System.EventHandler(this.FormPendaftaran_Click);
            // 
            // Tampilkan
            // 
            this.Tampilkan.BackColor = System.Drawing.Color.DarkOrchid;
            this.Tampilkan.Location = new System.Drawing.Point(284, 386);
            this.Tampilkan.Margin = new System.Windows.Forms.Padding(2);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(83, 24);
            this.Tampilkan.TabIndex = 25;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = false;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Selesai
            // 
            this.Selesai.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Selesai.Location = new System.Drawing.Point(472, 386);
            this.Selesai.Margin = new System.Windows.Forms.Padding(2);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(81, 24);
            this.Selesai.TabIndex = 26;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = false;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.FormPendaftaran);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.jadwal);
            this.Controls.Add(this.TglLahirr);
            this.Controls.Add(this.PilihJKK);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jadwal.ResumeLayout(false);
            this.jadwal.PerformLayout();
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox PilihJKK;
        private System.Windows.Forms.DateTimePicker TglLahirr;
        private System.Windows.Forms.GroupBox jadwal;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.Label FormPendaftaran;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
    }
}

