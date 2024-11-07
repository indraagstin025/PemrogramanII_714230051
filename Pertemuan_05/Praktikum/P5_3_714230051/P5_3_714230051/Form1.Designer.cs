namespace P5_3_714230051
{
    partial class ServiceHP
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
            this.MerkHP = new System.Windows.Forms.Label();
            this.SistemOperasi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerekHP = new System.Windows.Forms.TextBox();
            this.rb_Android = new System.Windows.Forms.RadioButton();
            this.rb_iOS = new System.Windows.Forms.RadioButton();
            this.cb_Ya = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MerkHP
            // 
            this.MerkHP.AutoSize = true;
            this.MerkHP.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MerkHP.Location = new System.Drawing.Point(48, 34);
            this.MerkHP.Name = "MerkHP";
            this.MerkHP.Size = new System.Drawing.Size(67, 22);
            this.MerkHP.TabIndex = 0;
            this.MerkHP.Text = "MerkHP";
            // 
            // SistemOperasi
            // 
            this.SistemOperasi.AutoSize = true;
            this.SistemOperasi.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SistemOperasi.Location = new System.Drawing.Point(48, 120);
            this.SistemOperasi.Name = "SistemOperasi";
            this.SistemOperasi.Size = new System.Drawing.Size(29, 22);
            this.SistemOperasi.TabIndex = 1;
            this.SistemOperasi.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki ?";
            // 
            // txtMerekHP
            // 
            this.txtMerekHP.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerekHP.Location = new System.Drawing.Point(213, 34);
            this.txtMerekHP.Name = "txtMerekHP";
            this.txtMerekHP.Size = new System.Drawing.Size(290, 31);
            this.txtMerekHP.TabIndex = 3;
            this.txtMerekHP.TextChanged += new System.EventHandler(this.txtMerekHP_TextChanged);
            // 
            // rb_Android
            // 
            this.rb_Android.AutoSize = true;
            this.rb_Android.Location = new System.Drawing.Point(213, 120);
            this.rb_Android.Name = "rb_Android";
            this.rb_Android.Size = new System.Drawing.Size(89, 24);
            this.rb_Android.TabIndex = 4;
            this.rb_Android.TabStop = true;
            this.rb_Android.Text = "Android";
            this.rb_Android.UseVisualStyleBackColor = true;
            this.rb_Android.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_iOS
            // 
            this.rb_iOS.AutoSize = true;
            this.rb_iOS.Location = new System.Drawing.Point(370, 120);
            this.rb_iOS.Name = "rb_iOS";
            this.rb_iOS.Size = new System.Drawing.Size(60, 24);
            this.rb_iOS.TabIndex = 5;
            this.rb_iOS.TabStop = true;
            this.rb_iOS.Text = "iOS";
            this.rb_iOS.UseVisualStyleBackColor = true;
            // 
            // cb_Ya
            // 
            this.cb_Ya.AutoSize = true;
            this.cb_Ya.Location = new System.Drawing.Point(213, 215);
            this.cb_Ya.Name = "cb_Ya";
            this.cb_Ya.Size = new System.Drawing.Size(55, 24);
            this.cb_Ya.TabIndex = 6;
            this.cb_Ya.Text = "Ya";
            this.cb_Ya.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(195, 283);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(106, 32);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(428, 283);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(106, 32);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // ServiceHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(668, 409);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cb_Ya);
            this.Controls.Add(this.rb_iOS);
            this.Controls.Add(this.rb_Android);
            this.Controls.Add(this.txtMerekHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SistemOperasi);
            this.Controls.Add(this.MerkHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ServiceHP";
            this.Text = "Service HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MerkHP;
        private System.Windows.Forms.Label SistemOperasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerekHP;
        private System.Windows.Forms.RadioButton rb_Android;
        private System.Windows.Forms.RadioButton rb_iOS;
        private System.Windows.Forms.CheckBox cb_Ya;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

