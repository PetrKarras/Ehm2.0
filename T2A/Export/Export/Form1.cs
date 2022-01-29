using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Export
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = TxtBOxNazev.Text;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    TxtBoxObsah.Text = sr.ReadLine();
                }
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string typsouboru = "";
            if (Radcsv.Checked) { typsouboru = ".csv"; }
            if (Radtxt.Checked) { typsouboru = ".txt"; }
            if (Radxml.Checked) { typsouboru = ".xml"; }
            using (StreamWriter sw = new StreamWriter($"{TxtBOxNazev.Text}.{typsouboru}"))
            {
                sw.WriteLine(TxtBoxObsah.Text);
                sw.Close();
            }

        }
    }
}
