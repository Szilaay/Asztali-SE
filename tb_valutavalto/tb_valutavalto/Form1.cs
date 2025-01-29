using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tb_valutavalto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void devizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeviza frmDeviza = new frmDeviza();
            frmDeviza.ShowDialog();
        }

        private void árfolyamokRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArfolyam frmArfolyam = new frmArfolyam();
            frmArfolyam.ShowDialog();
        }
    }
}
