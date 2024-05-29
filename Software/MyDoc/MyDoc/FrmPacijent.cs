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
        private void FrmPacijent_Load_1(object sender, EventArgs e)
        {
            PrikaziZahtjeve();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKreiranjeZahtjeva frmKreiranjeZahtjeva = new FrmKreiranjeZahtjeva();
            Hide();
            frmKreiranjeZahtjeva.ShowDialog();
            Close();
        }

        private void UrediOpis_Click(object sender, EventArgs e)
        {
            FrmKreiranjeZahtjeva frmKreiranjeZahtjeva = new FrmKreiranjeZahtjeva();
            int id = (int)dgvZahtjev.SelectedCells[0].OwningRow.Cells["Id"].Value;
            frmKreiranjeZahtjeva.Editing(id);
            Hide();
            frmKreiranjeZahtjeva.ShowDialog();
            Close();
        }
    }
}
