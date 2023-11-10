using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Welcome : Form
    {
        public Welcome(string name,string code)
        {
            InitializeComponent();
            StudentNumber.Text = $"[{code}]";
            WelcomeName.Text = $"Welcome {name} to MS111";
            this.Text = $"Welcome {name}";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == "IMG/Picture1.jpg")
            {
                pictureBox1.ImageLocation = "IMG/Picture2.jpg";
            }
            else { pictureBox1.ImageLocation = "IMG/Picture1.jpg"; }
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            ColourPanel.BackColor = Color.Green;
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            ColourPanel.BackColor = Color.Red;
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            ColourPanel.BackColor = Color.Blue;
        }

        private void Chocolate_CheckedChanged(object sender, EventArgs e)
        {
            ColourPanel.BackColor = Color.Chocolate;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no exit bro", "exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ColourPanel.BackColor = Color.Empty;
        }
    }
}
