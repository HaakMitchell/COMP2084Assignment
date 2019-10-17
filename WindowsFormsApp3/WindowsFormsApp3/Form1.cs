using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        int city = 1;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int citySelection)
        {
            InitializeComponent();
            city = citySelection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //to show a picture

            if (city == 1)
            {
                pictureBox1.Visible = true;
            }
            else if (city == 2)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox3.Visible = true;
            }

        }
    }
}
