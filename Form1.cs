using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCasaDeSchimbValutar
{
    public partial class Form1 : Form
    {

        private List<Tranzactii> listaTranzactii = new List<Tranzactii>();
        String connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = tranzactii.accdb";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbValoare.Text == "")
                errorProvider1.SetError(tbValoare, "Introduceti valoarea!");
            else
                if (comboBox1.Text == "")
                errorProvider1.SetError(comboBox1, "Selectati valuta initiala!");
            else
                if (comboBox2.Text == "")
                errorProvider1.SetError(comboBox2, "Selectati valuta finala!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    double valoare = Convert.ToDouble(tbValoare.Text);
                    string vi = comboBox1.Text;
                    string vf = comboBox2.Text;
                    
                    Valute valutaInitiala = new Valute();
                    Valute valutaFinala = new Valute();
                    valutaInitiala.CodValuta = vi;
                    valutaFinala.CodValuta = vf;

                    Tranzactii tranzactie = new Tranzactii(DateTime.Now, valoare, 0, valutaInitiala, valutaFinala);
                    tranzactie.efectuareTranzactie();
                    MessageBox.Show(tranzactie.ToString());
                    listaTranzactii.Add(tranzactie);
                    ////
                    OleDbConnection conexiune = new OleDbConnection(connString);
                    OleDbCommand comanda = new OleDbCommand();
                    try
                    {
                        conexiune.Open();
                        comanda.Connection = conexiune;

                        comanda.CommandText = "SELECT MAX(ID) FROM tranzactii";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());

                        comanda.CommandText = "INSERT INTO tranzactii VALUES(?,?,?,?,?,?)";
                        comanda.Parameters.Add("DataTranzactiei", OleDbType.Date).Value = tranzactie.DataTranzactiei;
                        comanda.Parameters.Add("ValoareInitiala", OleDbType.Double).Value = tranzactie.ValoareInitiala;
                        comanda.Parameters.Add("ValutaInitiala", OleDbType.Char, 30).Value = tranzactie.ValutaInitiala.CodValuta;
                        comanda.Parameters.Add("ValoareFinala", OleDbType.Double).Value = tranzactie.ValoareFinala;
                        comanda.Parameters.Add("ValutaFinala", OleDbType.Char, 30).Value = tranzactie.ValutaFinala.CodValuta;
                        comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;

                        comanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }

                    salvareFisierTextToolStripMenuItem_Click(this, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbValoare.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
            }
        }

        private void tbValoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            sw.WriteLine(tbValoare.Text);
            sw.WriteLine(comboBox1.Text);
            sw.WriteLine(comboBox2.Text);
            sw.Close();
        }

        private void restaurareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            tbValoare.Text = sr.ReadLine();
            comboBox1.Text = sr.ReadLine();
            comboBox2.Text = sr.ReadLine();
            sr.Close();
        }

        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(listaTranzactii);
            form.MdiParent = this.MdiParent;
            
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
