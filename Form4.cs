using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCasaDeSchimbValutar
{

    public partial class Form4 : Form
    {
        Graphics g;
        CursuriValutare cursuriValutare;
        int nrElem;
        double vMax;
        bool incarcat = false;
        Font font = new Font(FontFamily.GenericSansSerif, 9);
        public Form4()
        {
            InitializeComponent();


            g = panel1.CreateGraphics();
            cursuriValutare = new CursuriValutare();
            cursuriValutare.incarcaCursuriXML();
            nrElem = cursuriValutare.RateSchimb.Count();
            vMax = 6;


        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (incarcat == false)
            {
                MessageBox.Show("Datele au fost incarcate!");

                Pen pen = new Pen(Color.AliceBlue, 3);
                Rectangle rec = new Rectangle(
                        panel1.ClientRectangle.X + 10,
                        panel1.ClientRectangle.Y + 20,
                        panel1.ClientRectangle.Width - 20,
                        panel1.ClientRectangle.Height - 30
                        );
                g.DrawRectangle(pen, rec);
                double latime = rec.Width / nrElem / 2;
                double distanta = (rec.Width - nrElem - latime) / (nrElem + 1);
                Brush br = new SolidBrush(Color.MidnightBlue);
                Rectangle[] recs = new Rectangle[nrElem];
                int i = 0;

                foreach (KeyValuePair<string, double> pereche in cursuriValutare.RateSchimb)
                {
                    recs[i] = new Rectangle(
                        (int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - (pereche.Value / vMax) * rec.Height),
                        (int)latime,
                        (int)((pereche.Value / vMax) * rec.Height)
                        );
                    g.DrawRectangle(pen, recs[i]);
                    g.FillRectangle(br, recs[i]);
                    g.DrawString(pereche.Key.ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y - font.Height)));
                    i++;
                }
                incarcat = true;
            }
            else MessageBox.Show("Ai incarcat deja datele!");


        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (incarcat == true)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_print);
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = pd;
                dlg.ShowDialog();
            }
            else MessageBox.Show("Datele trebuie incarcate mai intai!");
        }

        private void pd_print(object sender,PrintPageEventArgs e )
        {
            g = e.Graphics;
            Pen pen = new Pen(Color.AliceBlue, 3);
            Rectangle rec = new Rectangle(
                    e.PageBounds.X + 10,
                    e.PageBounds.Y + 2 * 10,
                    e.PageBounds.Width - 2 * 10,
                    e.PageBounds.Height - 3 * 10
                    );
            g.DrawRectangle(pen, rec);
            double latime = rec.Width / nrElem / 2;
            double distanta = (rec.Width - nrElem - latime) / (nrElem + 1);
            Brush br = new SolidBrush(Color.MidnightBlue);
            Rectangle[] recs = new Rectangle[nrElem];
            int i = 0;
            foreach (KeyValuePair<string, double> pereche in cursuriValutare.RateSchimb)
            {
                recs[i] = new Rectangle(
                    (int)(rec.Location.X + (i + 1) * distanta + i * latime),
                    (int)(rec.Location.Y + rec.Height - (pereche.Value / vMax) * rec.Height),
                    (int)latime,
                    (int)((pereche.Value / vMax) * rec.Height)
                    );
                g.DrawRectangle(pen, recs[i]);
                g.FillRectangle(br, recs[i]);
                g.DrawString(pereche.Key.ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y - font.Height)));
                i++;

            }
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
    }

