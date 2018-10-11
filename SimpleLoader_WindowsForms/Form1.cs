using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoader_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            pictureBox1.Visible = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
