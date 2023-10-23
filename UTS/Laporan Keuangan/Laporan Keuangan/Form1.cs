using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan_Keuangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();

        }

        private List<LaporanKeuangan> listLaporanKeuangan = new List<LaporanKeuangan>();

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // saya ingin mensanitasi inputan hanya angka saja
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged()
        {
            lvwlaporan.View = View.Details;
            lvwlaporan.FullRowSelect = true;
            lvwlaporan.GridLines = true;

            lvwlaporan.Columns.Add("No. ", 40, HorizontalAlignment.Center);
            lvwlaporan.Columns.Add("Waktu ", 150, HorizontalAlignment.Center);
            lvwlaporan.Columns.Add("Sumber Dana", 100, HorizontalAlignment.Center);
            lvwlaporan.Columns.Add("Jumlah", 70, HorizontalAlignment.Center);
            lvwlaporan.Columns.Add("Keterangan", 70, HorizontalAlignment.Center);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            LaporanKeuangan laporan = new LaporanKeuangan();

            string input = txtUang.Text;
            if (!string.IsNullOrEmpty(input))
            {
                decimal amount = decimal.Parse(input);
                string formattedAmount = string.Format("{0:N0}", amount);
                txtUang.Text = formattedAmount;
            }

            laporan.NominalUang = decimal.Parse(txtUang.Text);
            laporan.SumberDana = cmbDana.Text;
            laporan.Jumlah = txtUang.Text;


            laporan.Waktu = dtpWaktu.Value;
            laporan.Keterangan = txtKeterangan.Text;

            listLaporanKeuangan.Add(laporan);

            var msg = "Data Berhasil Disimpan.";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            lvwlaporan.Items.Clear();
            ResetForm();
        }

        private void ResetForm()
        {
            cmbDana.Text = "";
            dtpWaktu.Value = DateTime.Now;
            txtKeterangan.Text = "";
            txtUang.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

       

        private void tampilkanData()
        {

            lvwlaporan.Items.Clear();

            int index = 0;
            foreach (var laporan in listLaporanKeuangan)
            {
                var lvwItem = lvwlaporan.Items.Count + 1;
                ListViewItem item = new ListViewItem(lvwItem.ToString());
                item.SubItems.Add(laporan.Waktu.ToString());
                item.SubItems.Add(laporan.SumberDana);
                item.SubItems.Add(laporan.Jumlah);
                item.SubItems.Add(laporan.Keterangan);

                lvwlaporan.Items.Add(item);
                index++;
            }
            foreach (var item in listLaporanKeuangan)
            {
                Console.WriteLine("Sumber Dana: " + item.SumberDana);
                Console.WriteLine("Jumlah: " + item.Jumlah);
                Console.WriteLine("Waktu: " + item.Waktu);
                Console.WriteLine("Keterangan: " + item.Keterangan);
            }
        }

        private void btntampilkan_Click_1(object sender, EventArgs e)
        {
            tampilkanData();    
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (lvwlaporan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    var selectedItem = lvwlaporan.SelectedItems[0];
                    var index = lvwlaporan.SelectedIndices[0];
                    listLaporanKeuangan.RemoveAt(index);
                    lvwlaporan.Items.Remove(selectedItem);
                    tampilkanData();

                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
