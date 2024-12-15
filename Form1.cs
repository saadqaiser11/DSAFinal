using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuidance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Validate if the txtName field is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                // Show a message box if the field is empty
                MessageBox.Show("Please enter your name to proceed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Hide the current form and show the Main form
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
