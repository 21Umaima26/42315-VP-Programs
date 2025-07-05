using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tOOLBOXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open tool box");
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open pdf");
        }

        private void pROJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open project");
        }

        private void cOPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and copy project");
        }

        private void pASTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and paste project");
        }

        private void cUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and cut project");
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open menu");
        }

        private void tOOLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open tools");
        }

        private void dESINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click and open desing");
        }
    }
}
