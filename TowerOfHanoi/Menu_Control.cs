using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Menu_Control : Form
    {
        public Menu_Control()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Height = 64;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 475)
            {
                panel1.Height = 64;
            }
            else
            {
                panel1.Height = 475;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game_Design_Setup f = new Game_Design_Setup();
            f.ShowDialog();
        }
    }
}
