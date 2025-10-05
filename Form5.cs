using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectCasaDeSchimbValutar
{
    public partial class Form5 : Form
    {
        String connString;
        List<Tranzactii> listaTranzactii;
        public Form5()
        {
            InitializeComponent();
            incarcaDate();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = tranzactii.accdb";
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void incarcaDate()
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaTranzactii = (List<Tranzactii>)bf.Deserialize(fs);
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            /*foreach (Tranzactii t in listaTranzactii)
            {
                ListViewItem itm = new ListViewItem(t.DataTranzactiei.ToString());
                itm.SubItems.Add(t.ValoareInitiala.ToString());
                itm.SubItems.Add(t.ValutaInitiala.ToString());
                itm.SubItems.Add(t.ValoareFinala.ToString());
                itm.SubItems.Add(t.ValutaFinala.ToString());
                listView1.Items.Add(itm);
            }
            */
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM tranzactii";
                comanda.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["DataTranzactiei"].ToString());
                    itm.SubItems.Add(reader["ValoareInitiala"].ToString());
                    itm.SubItems.Add(reader["ValutaInitiala"].ToString());
                    itm.SubItems.Add(reader["ValoareFinala"].ToString());
                    itm.SubItems.Add(reader["ValutaFinala"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /*
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    string data = itm.SubItems[0].Text;
                    for (int i = 0; i < listaTranzactii.Count; i++)
                        if (data.Equals(listaTranzactii[i].DataTranzactiei.ToString()))
                            listaTranzactii.RemoveAt(i);
                    itm.Remove();
                }
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaTranzactii);
            fs.Close();
            //button1_Click(sender, e);
            */

            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM tranzactii WHERE ID=" + id;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                button1_Click(sender, e);
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            


        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            


        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            /* ListViewItem itm = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
             string data = itm.SubItems[0].Text;
             for (int i = 0; i < listaTranzactii.Count; i++)
                 if (data.Equals(listaTranzactii[i].DataTranzactiei.ToString()))
                     listaTranzactii.RemoveAt(i);
             itm.Remove();
             FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, listaTranzactii);
             fs.Close();
             */
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM tranzactii WHERE ID=" + id;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                button1_Click(sender, e);
            }


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            DateTime data = calendar1.SelectedDate;
            String dataString = data.ToString("dd-MMM-yy");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM tranzactii WHERE DateValue(DataTranzactiei) = '" + dataString+"'";
                comanda.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["DataTranzactiei"].ToString());
                    itm.SubItems.Add(reader["ValoareInitiala"].ToString());
                    itm.SubItems.Add(reader["ValutaInitiala"].ToString());
                    itm.SubItems.Add(reader["ValoareFinala"].ToString());
                    itm.SubItems.Add(reader["ValutaFinala"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }
    }
}
