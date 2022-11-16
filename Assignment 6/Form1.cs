using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int player = 0;
        int AI = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            AI = random.Next(1, 4);
            player = 2;

            if (AI == 1)
            {
                MessageBox.Show("Win");
            }
            else if (AI == 2)
            {
                MessageBox.Show("Draw");
            }
            else
            {
                MessageBox.Show("Loss");
            }

        }
        private void Rock_Click(object sender, EventArgs e)
        {
            AI = random.Next(1, 4);
            player = 1;

            if (AI == 1)
            {
                MessageBox.Show("Draw");
            }
            else if (AI == 2)
            {
                MessageBox.Show("Loss");
            }
            else
            {
                MessageBox.Show("Win");
            }

        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            AI = random.Next(1, 4);
            player = 3;

            if (AI == 1)
            {
                MessageBox.Show("Loss");
            }
            else if (AI == 2)
            {
                MessageBox.Show("Win");
            }
            else
            {
                MessageBox.Show("Draw");
            }
        }
    }
}
