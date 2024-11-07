namespace P5_4_714230051
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
            this.Nama = new System.Windows.Forms.Label();
            this.Jenis_Kelamin = new System.Windows.Forms.Label();
            this.Tanggal_Lahir = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Pilihan_Kelas = new System.Windows.Forms.GroupBox();
            this.Panahan = new System.Windows.Forms.CheckBox();
            this.Voli = new System.Windows.Forms.CheckBox();
            this.Bulu_Tangkis = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Renang = new System.Windows.Forms.CheckBox();
            this.Sepak_Bola = new System.Windows.Forms.CheckBox();
            this.Pilihan_Jadwal = new System.Windows.Forms.GroupBox();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.Sabtu_Minggu = new System.Windows.Forms.RadioButton();
            this.Selasa_Kamis = new System.Windows.Forms.RadioButton();
            this.Senin_Rabu = new System.Windows.Forms.RadioButton();
            this.Form_Pendaftaran = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.Pilihan_Kelas.SuspendLayout();
            this.Pilihan_Jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(233, 110);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(51, 20);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.label1_Click);
            // 
            // Jenis_Kelamin
            // 
            this.Jenis_Kelamin.AutoSize = true;
            this.Jenis_Kelamin.Location = new System.Drawing.Point(233, 169);
            this.Jenis_Kelamin.Name = "Jenis_Kelamin";
            this.Jenis_Kelamin.Size = new System.Drawing.Size(106, 20);
            this.Jenis_Kelamin.TabIndex = 1;
            this.Jenis_Kelamin.Text = "Jenis Kelamin";
            this.Jenis_Kelamin.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tanggal_Lahir
            // 
            this.Tanggal_Lahir.AutoSize = true;
            this.Tanggal_Lahir.Location = new System.Drawing.Point(233, 226);
            this.Tanggal_Lahir.Name = "Tanggal_Lahir";
            this.Tanggal_Lahir.Size = new System.Drawing.Size(105, 20);
            this.Tanggal_Lahir.TabIndex = 2;
            this.Tanggal_Lahir.Text = "Tanggal Lahir";
            this.Tanggal_Lahir.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Pilihan_Kelas
            // 
            this.Pilihan_Kelas.Controls.Add(this.Panahan);
            this.Pilihan_Kelas.Controls.Add(this.Voli);
            this.Pilihan_Kelas.Controls.Add(this.Bulu_Tangkis);
            this.Pilihan_Kelas.Controls.Add(this.Basket);
            this.Pilihan_Kelas.Controls.Add(this.Yoga);
            this.Pilihan_Kelas.Controls.Add(this.Tenis);
            this.Pilihan_Kelas.Controls.Add(this.Renang);
            this.Pilihan_Kelas.Controls.Add(this.Sepak_Bola);
            this.Pilihan_Kelas.Location = new System.Drawing.Point(29, 290);
            this.Pilihan_Kelas.Name = "Pilihan_Kelas";
            this.Pilihan_Kelas.Size = new System.Drawing.Size(386, 281);
            this.Pilihan_Kelas.TabIndex = 6;
            this.Pilihan_Kelas.TabStop = false;
            this.Pilihan_Kelas.Text = "Pilihan Kelas";
            // 
            // Panahan
            // 
            this.Panahan.AutoSize = true;
            this.Panahan.Location = new System.Drawing.Point(224, 221);
            this.Panahan.Name = "Panahan";
            this.Panahan.Size = new System.Drawing.Size(92, 24);
            this.Panahan.TabIndex = 7;
            this.Panahan.Text = "Panahan";
            this.Panahan.UseVisualStyleBackColor = true;
            this.Panahan.CheckedChanged += new System.EventHandler(this.Panahan_CheckedChanged);
            // 
            // Voli
            // 
            this.Voli.AutoSize = true;
            this.Voli.Location = new System.Drawing.Point(224, 168);
            this.Voli.Name = "Voli";
            this.Voli.Size = new System.Drawing.Size(54, 24);
            this.Voli.TabIndex = 6;
            this.Voli.Text = "Voli";
            this.Voli.UseVisualStyleBackColor = true;
            this.Voli.CheckedChanged += new System.EventHandler(this.Voli_CheckedChanged);
            // 
            // Bulu_Tangkis
            // 
            this.Bulu_Tangkis.AutoSize = true;
            this.Bulu_Tangkis.Location = new System.Drawing.Point(224, 115);
            this.Bulu_Tangkis.Name = "Bulu_Tangkis";
            this.Bulu_Tangkis.Size = new System.Drawing.Size(119, 24);
            this.Bulu_Tangkis.TabIndex = 5;
            this.Bulu_Tangkis.Text = "Bulu Tangkis";
            this.Bulu_Tangkis.UseVisualStyleBackColor = true;
            this.Bulu_Tangkis.CheckedChanged += new System.EventHandler(this.Bulu_Tangkis_CheckedChanged);
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(225, 62);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(78, 24);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.CheckedChanged += new System.EventHandler(this.Basket_CheckedChanged);
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(50, 221);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(66, 24);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            this.Yoga.CheckedChanged += new System.EventHandler(this.Yoga_CheckedChanged);
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(50, 168);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(66, 24);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            this.Tenis.CheckedChanged += new System.EventHandler(this.Tenis_CheckedChanged);
            // 
            // Renang
            // 
            this.Renang.AutoSize = true;
            this.Renang.Location = new System.Drawing.Point(50, 114);
            this.Renang.Name = "Renang";
            this.Renang.Size = new System.Drawing.Size(85, 24);
            this.Renang.TabIndex = 1;
            this.Renang.Text = "Renang";
            this.Renang.UseVisualStyleBackColor = true;
            this.Renang.CheckedChanged += new System.EventHandler(this.Renang_CheckedChanged);
            // 
            // Sepak_Bola
            // 
            this.Sepak_Bola.AutoSize = true;
            this.Sepak_Bola.Location = new System.Drawing.Point(50, 62);
            this.Sepak_Bola.Name = "Sepak_Bola";
            this.Sepak_Bola.Size = new System.Drawing.Size(110, 24);
            this.Sepak_Bola.TabIndex = 0;
            this.Sepak_Bola.Text = "Sepak Bola";
            this.Sepak_Bola.UseVisualStyleBackColor = true;
            this.Sepak_Bola.CheckedChanged += new System.EventHandler(this.Sepak_Bola_CheckedChanged);
            // 
            // Pilihan_Jadwal
            // 
            this.Pilihan_Jadwal.Controls.Add(this.Minggu);
            this.Pilihan_Jadwal.Controls.Add(this.Sabtu_Minggu);
            this.Pilihan_Jadwal.Controls.Add(this.Selasa_Kamis);
            this.Pilihan_Jadwal.Controls.Add(this.Senin_Rabu);
            this.Pilihan_Jadwal.Location = new System.Drawing.Point(470, 290);
            this.Pilihan_Jadwal.Name = "Pilihan_Jadwal";
            this.Pilihan_Jadwal.Size = new System.Drawing.Size(359, 281);
            this.Pilihan_Jadwal.TabIndex = 7;
            this.Pilihan_Jadwal.TabStop = false;
            this.Pilihan_Jadwal.Text = "Pilihan Jadwal";
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(16, 210);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(215, 24);
            this.Minggu.TabIndex = 3;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu, 13.00 - 20.00 WIB";
            this.Minggu.UseVisualStyleBackColor = true;
            this.Minggu.CheckedChanged += new System.EventHandler(this.Minggu_CheckedChanged);
            // 
            // Sabtu_Minggu
            // 
            this.Sabtu_Minggu.AutoSize = true;
            this.Sabtu_Minggu.Location = new System.Drawing.Point(16, 156);
            this.Sabtu_Minggu.Name = "Sabtu_Minggu";
            this.Sabtu_Minggu.Size = new System.Drawing.Size(287, 24);
            this.Sabtu_Minggu.TabIndex = 2;
            this.Sabtu_Minggu.TabStop = true;
            this.Sabtu_Minggu.Text = "Sabtu s/d Minggu, 09.00 - 11.00 WIB";
            this.Sabtu_Minggu.UseVisualStyleBackColor = true;
            this.Sabtu_Minggu.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Selasa_Kamis
            // 
            this.Selasa_Kamis.AutoSize = true;
            this.Selasa_Kamis.Location = new System.Drawing.Point(16, 102);
            this.Selasa_Kamis.Name = "Selasa_Kamis";
            this.Selasa_Kamis.Size = new System.Drawing.Size(284, 24);
            this.Selasa_Kamis.TabIndex = 1;
            this.Selasa_Kamis.TabStop = true;
            this.Selasa_Kamis.Text = "Selasa s/d Kamis, 14.00 - 16.00 WIB";
            this.Selasa_Kamis.UseVisualStyleBackColor = true;
            this.Selasa_Kamis.CheckedChanged += new System.EventHandler(this.Selasa_Kamis_CheckedChanged);
            // 
            // Senin_Rabu
            // 
            this.Senin_Rabu.AutoSize = true;
            this.Senin_Rabu.Location = new System.Drawing.Point(16, 50);
            this.Senin_Rabu.Name = "Senin_Rabu";
            this.Senin_Rabu.Size = new System.Drawing.Size(272, 24);
            this.Senin_Rabu.TabIndex = 0;
            this.Senin_Rabu.TabStop = true;
            this.Senin_Rabu.Text = "Senin s/d Rabu, 14.00 - 16.00 WIB";
            this.Senin_Rabu.UseVisualStyleBackColor = true;
            this.Senin_Rabu.CheckedChanged += new System.EventHandler(this.Senin_Rabu_CheckedChanged);
            // 
            // Form_Pendaftaran
            // 
            this.Form_Pendaftaran.AutoSize = true;
            this.Form_Pendaftaran.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Pendaftaran.Location = new System.Drawing.Point(295, 32);
            this.Form_Pendaftaran.Name = "Form_Pendaftaran";
            this.Form_Pendaftaran.Size = new System.Drawing.Size(195, 24);
            this.Form_Pendaftaran.TabIndex = 8;
            this.Form_Pendaftaran.Text = "FORM PENDAFTARAN";
            this.Form_Pendaftaran.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(238, 598);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(124, 38);
            this.btnTampilkan.TabIndex = 9;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(513, 598);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(124, 38);
            this.btnSelesai.TabIndex = 10;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(860, 663);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.Form_Pendaftaran);
            this.Controls.Add(this.Pilihan_Jadwal);
            this.Controls.Add(this.Pilihan_Kelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tanggal_Lahir);
            this.Controls.Add(this.Jenis_Kelamin);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.Pilihan_Kelas.ResumeLayout(false);
            this.Pilihan_Kelas.PerformLayout();
            this.Pilihan_Jadwal.ResumeLayout(false);
            this.Pilihan_Jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Jenis_Kelamin;
        private System.Windows.Forms.Label Tanggal_Lahir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox Pilihan_Kelas;
        private System.Windows.Forms.GroupBox Pilihan_Jadwal;
        private System.Windows.Forms.RadioButton Sabtu_Minggu;
        private System.Windows.Forms.RadioButton Selasa_Kamis;
        private System.Windows.Forms.RadioButton Senin_Rabu;
        private System.Windows.Forms.CheckBox Panahan;
        private System.Windows.Forms.CheckBox Voli;
        private System.Windows.Forms.CheckBox Bulu_Tangkis;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Renang;
        private System.Windows.Forms.CheckBox Sepak_Bola;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.Label Form_Pendaftaran;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}

