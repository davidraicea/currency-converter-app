using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCasaDeSchimbValutar
{
    public partial class Form3 : Form
    {
        CursuriValutare cursuri;
        public Form3()
        {
            InitializeComponent();
            cursuri = new CursuriValutare();
            cursuri.incarcaCursuriXML();
            TreeNode parinte = new TreeNode("Cursuri Valutare");
            treeView1.Nodes.Add(parinte);
            foreach (KeyValuePair<string, double> pereche in cursuri.RateSchimb)
            {
                TreeNode copil1 = new TreeNode("1 "+pereche.Key.ToString());
                TreeNode copil2 = new TreeNode(pereche.Value.ToString()+" RON");
                parinte.Nodes.Add(copil1);
                copil1.Nodes.Add(copil2);
                //textBox1.Text += "1 " + pereche.Key.ToString() + " = " + pereche.Value.ToString() + " RON" + Environment.NewLine;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void veziSubFormaGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.MdiParent = this.MdiParent;
            form.Show();
           
        }
    }
}
