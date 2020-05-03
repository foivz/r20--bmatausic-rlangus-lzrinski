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
    public partial class Informacije_o_filmu : Form
    {
        private Filmovi Info;
        public Informacije_o_filmu(Filmovi info)
        {
            Info = info;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ID.Text = ""+Info.ID;
            Naziv.Text = Info.Naziv;
            Vrijeme.Text = ""+Info.Datum;
            Dvorana.Text = Info.Dvorana;
        }
    }
}
