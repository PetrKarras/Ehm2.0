using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mortal_Kombat
{
    public partial class PlayerForm : Form
    {
        private int maxAttack;
        private int minAttack;
        private int deff;
        private string playerName;
        public int MaxAttack { get { return maxAttack; } }
        public int MinAttack { get { return minAttack; } }
        public int Deff { get { return deff; } }
        public string PlayerName { get { return playerName; } }

        public PlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxAttack = (int)NumUDMaxAttack.Value;
            minAttack = (int)NumUDMinAttack.Value;
            deff = (int)NumUDDeff.Value;
            playerName = TxtBoxName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
