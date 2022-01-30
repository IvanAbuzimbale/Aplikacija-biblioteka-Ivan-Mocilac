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
using System.Xml.Linq;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class PregledKorisnika : Form
    {

        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Korisnici.xml");
        public PregledKorisnika()
        {
            InitializeComponent();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            var xml = XElement.Load(putanja);
            txtKorisnici.Text = xml.Value;
        }
    }
}
