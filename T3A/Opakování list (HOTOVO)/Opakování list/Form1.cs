using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakování_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> hraci = new List<string>();

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "")
            {
                MessageBox.Show("Prázdný textbox", "Error 001");
                return;
            }
            hraci.Add(TxtBox.Text);
            string seznamHracu ="";
            foreach (string item in hraci)
            {
                seznamHracu += item + Environment.NewLine;
            }
            LblHracOut.Text = seznamHracu;
        }

        private void ButtRmv_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "")
            {
                MessageBox.Show("Prázdný textbox", "Error 001");
                return;
            }           
            hraci.Remove(TxtBox.Text);

            string seznamHracu = "";
            foreach (string item in hraci)
            {
                seznamHracu += item + Environment.NewLine;
            }
            LblHracOut.Text = seznamHracu;

        }

        private void ButtTeam_Click(object sender, EventArgs e)
        {
            int rozdeleniTymu = hraci.Count / (int)NumUD.Value;
            int tmp = 0;
            string vystup = "";
            foreach(string item in hraci)
            {
                if(tmp == rozdeleniTymu)
                {
                    vystup += "------";
                    tmp = 0;
                }
                vystup += item+ Environment.NewLine;
            }
            LblTymOut.Text = vystup; 
        }
    }
}
