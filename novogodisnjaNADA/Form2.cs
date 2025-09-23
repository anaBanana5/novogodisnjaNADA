using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novogodisnjaNADA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string vrsta = textBox2.Text;
            string pasmina = textBox3.Text;
            string spol = radioButton1.Checked ? "M" : radioButton2.Checked ? "Ž" : "";
            int dob = (int)numericUpDown1.Value;
            DateTime datumDolaska = dateTimePicker1.Value;
            bool cijepljen = checkBox1.Checked;
            bool kastriran = checkBox2.Checked;
            string napomena = textBox4.Text;

            string poruka = $"Ime: {ime}\nVrsta: {vrsta}\nPasmina: {pasmina}\nSpol: {spol}\nDob: {dob}\nDatum dolaska: {datumDolaska.ToShortDateString()}\nCijepljen: {(cijepljen ? "Da" : "Ne")}\nKastriran: {(kastriran ? "Da" : "Ne")}\nNapomena: {napomena}";
            MessageBox.Show(poruka, "Uneseni su podaci :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Odabran je muški spol.");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                MessageBox.Show("Odabran je ženski spol.");
        }
    }
}
