namespace Laporan_Keuangan
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
            this.cmbDana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpWaktu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwlaporan = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDana
            // 
            this.cmbDana.FormattingEnabled = true;
            this.cmbDana.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran",
            "Nabung"});
            this.cmbDana.Location = new System.Drawing.Point(108, 12);
            this.cmbDana.Name = "cmbDana";
            this.cmbDana.Size = new System.Drawing.Size(163, 24);
            this.cmbDana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sumber Dana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waktu";
            // 
            // dtpWaktu
            // 
            this.dtpWaktu.Location = new System.Drawing.Point(108, 54);
            this.dtpWaktu.Name = "dtpWaktu";
            this.dtpWaktu.Size = new System.Drawing.Size(163, 22);
            this.dtpWaktu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah Rp";
            // 
            // txtUang
            // 
            this.txtUang.Location = new System.Drawing.Point(108, 98);
            this.txtUang.Name = "txtUang";
            this.txtUang.Size = new System.Drawing.Size(163, 22);
            this.txtUang.TabIndex = 6;
            this.txtUang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(108, 148);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(163, 22);
            this.txtKeterangan.TabIndex = 8;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(15, 198);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 23);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(139, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwlaporan);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btntampilkan);
            this.groupBox1.Location = new System.Drawing.Point(289, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 426);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Laporan";
            // 
            // lvwlaporan
            // 
            this.lvwlaporan.HideSelection = false;
            this.lvwlaporan.Location = new System.Drawing.Point(6, 55);
            this.lvwlaporan.Name = "lvwlaporan";
            this.lvwlaporan.Size = new System.Drawing.Size(756, 365);
            this.lvwlaporan.TabIndex = 14;
            this.lvwlaporan.UseCompatibleStateImageBehavior = false;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(157, 21);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btntampilkan
            // 
            this.btntampilkan.Location = new System.Drawing.Point(6, 21);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(129, 23);
            this.btntampilkan.TabIndex = 12;
            this.btntampilkan.Text = "Tampilkan Data";
            this.btntampilkan.UseVisualStyleBackColor = true;
            this.btntampilkan.Click += new System.EventHandler(this.btntampilkan_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpWaktu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDana);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan keuangan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpWaktu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwlaporan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btntampilkan;
    }
}

