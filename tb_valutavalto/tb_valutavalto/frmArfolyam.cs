using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tb_valutavalto
{
    public partial class frmArfolyam : Form
    {
        string file = "arfolyamok.txt";
        void devBetoltes()
        {
            //List<Devizak> devlista = new List<Devizak>();

            if(File.Exists(file))
            {
                List<string> arfolyamlista = new List<string>();

                FileStream fs = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string devkod = sor.Substring(0, 3);
                    arfolyamlista.Add(devkod);
                }

                sr.Close();
                fs.Close();


            }
            else
            {
                if (File.Exists("devizanemek.txt"))
                {
                    FileStream fs = new FileStream("devizanemek.txt", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        Devizak dev = new Devizak(sr.ReadLine());
                        //devlista.Add(dev);
                        cbDev.Items.Add(dev.nevKiiras());
                    }
                    sr.Close();
                    fs.Close();
                }
            }
        }
        public frmArfolyam()
        {
            InitializeComponent();
        }

        private void frmArfolyam_Load(object sender, EventArgs e)
        {
            devBetoltes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    int arfolyam = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Az árfolyam csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                try
                {
                    double arfolyam = Convert.ToDouble(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Az árfolyam csak törtszám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
        }

        private void btnElvet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan elveti a módosításokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (cbDev.SelectedItem == null)
            {
                MessageBox.Show("Válasszon ki egy devizát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDev.Focus();
            }
            else if (textBox1.TextLength == 0)
            {
                MessageBox.Show("A deviza egység nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Az árfolyam egység nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                string devkod = cbDev.SelectedItem.ToString();
                devkod = devkod.Substring(0, 3);

                if (File.Exists(file))
                {
                    FileStream fs = new FileStream(file, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write($"\n{devkod};{textBox1.Text};{textBox2.Text}");

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(file, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write($"{devkod};{textBox1.Text};{textBox2.Text}");

                    sw.Close();
                    fs.Close();
                }

                DialogResult dr = MessageBox.Show("Sikeres mentés! Újabb árfolyam hozzáadása?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cbDev.SelectedItem = null;
                    textBox1.Clear();
                    textBox2.Clear();
                    cbDev.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
