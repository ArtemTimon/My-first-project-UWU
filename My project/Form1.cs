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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string code = StudentNumber.Text;
            Welcome transferForm = new Welcome(name, code);
            transferForm.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            StudentNumber.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
