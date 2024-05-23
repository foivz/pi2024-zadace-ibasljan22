using DBLayer;
using MyDoc.Models;
using MyDoc.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDoc
{
    public partial class FrmPacijent : Form
    {
        public FrmPacijent()
        {
            InitializeComponent();
        }

        public void PrikazPodataka()
        {

        }

        private void FrmPacijent_Load(object sender, EventArgs e)
        {
            PrikaziZahtjeve();
        }
        private void PrikaziZahtjeve()
        {
            List<Zahtjev> zahtjevi = RepozitorijPacijenata.DohvatiZahtjeve();
            dgvZahtjev.DataSource = zahtjevi;
        }
    }
}
