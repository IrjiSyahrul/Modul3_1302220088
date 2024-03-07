using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_MOD3_1302220088_FYI
{
    public partial class Form1 : Form
    {
        int angka;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void nol_Click(object sender, EventArgs e)
        {
          this.Output.Text = this.Output.Text + this.nol.Text;
        }
        private void satu_Click(object sender, EventArgs e)
        {
          this.Output.Text = this.Output.Text + this.satu.Text;
        }

        private void dua_Click(object sender, EventArgs e)
        {
          this.Output.Text = this.Output.Text + this.dua.Text;
        }

        private void tiga_Click(object sender, EventArgs e)
        {
          this.Output.Text = this.Output.Text + this.tiga.Text;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.empat.Text;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.lima.Text;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.enam.Text;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.tujuh.Text;
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.delapan.Text;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            this.Output.Text = this.Output.Text + this.sembilan.Text;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            angka = int .Parse(this.Output.Text);
            this.Output.Text = this.Output.Text + this.tambah.Text;
            this.Output.Text = null;    
        }

        private void samaDengan_Click(object sender, EventArgs e)
        {
           int hasil;
          hasil = angka + int.Parse(this.Output.Text);
          Output.Text = hasil.ToString();

        }
    }
}
