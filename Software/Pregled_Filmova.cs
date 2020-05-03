using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Pregled_Filmova : Form
    {
        public Pregled_Filmova()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmovi.LoadList();

            UcitajTablicu();
        }

        private void UcitajTablicu()
        {
            pregledFilmova.DataSource = null;
            pregledFilmova.DataSource = Filmovi.lista;
            pregledFilmova.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime filter = dateTimePicker1.Value.Date;
            List<Filmovi> filtirano = new List<Filmovi>();
            foreach (Filmovi c in Filmovi.lista)
            {
                if (c.Datum.ToString() == filter.ToString())
                {
                    filtirano.Add(c);
                }
            }
            pregledFilmova.DataSource = null;
            pregledFilmova.DataSource = filtirano;
        }

        private void tablicaData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filmovi odabrano = (Filmovi)pregledFilmova.CurrentRow.DataBoundItem;
            //label1.Text = "" + odabrano.Ime + " " + odabrano.Datum;
            Informacije_o_filmu forma = new Informacije_o_filmu(odabrano);
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filmovi.LoadList();

            UcitajTablicu();
        }
    }
}
