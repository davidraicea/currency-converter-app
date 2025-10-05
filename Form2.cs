using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCasaDeSchimbValutar
{
    public partial class Form2 : Form
    {
        List<Tranzactii> lista;
        public Form2(List<Tranzactii> listaTranzactii)
        {
            InitializeComponent();
            lista = listaTranzactii;
            foreach (Tranzactii t in listaTranzactii)
            {
                textBox1.Text += t.ToString() + Environment.NewLine;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista);
            fs.Close();

        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            FileStream fs = new FileStream("fisier.dat",FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            lista = (List<Tranzactii>)bf.Deserialize(fs);
            foreach (Tranzactii t in lista)
            {
                //MessageBox.Show(t.ToString());
                textBox1.Text += t.ToString() + Environment.NewLine;
            }
           // lista = listaNoua.ToList();
            fs.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

 

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Alt == true)
            {
                serializareToolStripMenuItem_Click(sender, e);
            }
            if(e.KeyCode == Keys.D && e.Alt == true)
            {
                deserializareToolStripMenuItem_Click(sender,e);
            }
        }

        private void veziInListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void stergeDateDinZiuaSelectataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            DateTime data = calendar1.SelectedDate;
            String dataString = data.ToString("dd-MMM-yy");
            int nr = 0;
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (dataString.Equals(lista[i].DataTranzactiei.ToString("dd-MMM-yy")))
                {
                    lista.RemoveAt(i);
                    nr = 1;
                }
            }
            bf.Serialize(fs, lista);
            fs.Close();
            if (nr == 0)
                MessageBox.Show("Nu exista tranzactii efectuate in ziua selectata (salvate in fisier)!");
            else
            {
                textBox1.Clear();
                deserializareToolStripMenuItem_Click(sender, e);
            }
            

        }
    }
}
