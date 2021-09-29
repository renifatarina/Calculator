using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            if (cmbOperasi.Text == "Penambahan")
            {
                txtHasil.Text = (Penambahan(a, b).ToString());
            } else if (cmbOperasi.Text == "Pengurangan")
            {
                txtHasil.Text = (Pengurangan(a, b).ToString());
            } else if (cmbOperasi.Text == "Perkalian")
            {
                txtHasil.Text = (Perkalian(a, b).ToString());
            } else if (cmbOperasi.Text == "Pembagian")
            {
                txtHasil.Text = (Pembagian(a, b).ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
