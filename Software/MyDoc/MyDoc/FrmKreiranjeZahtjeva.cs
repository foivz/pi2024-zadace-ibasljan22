using DBLayer;
using MyDoc.Repositories;
using MyDoc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDoc
{
    public partial class FrmKreiranjeZahtjeva : Form
    {
        public FrmKreiranjeZahtjeva()
        {
            InitializeComponent();
        }

        bool edit = false;
        int editID;
        public void Editing(int id)
        {
            edit = true;
            editID = id;

            Zahtjev zahtjev = RepozitorijPacijenata.DohvatiZahtjev(id);

            txtTermin.Text = zahtjev.VrijemeTermina;
            txtObrazlozenje.Text = zahtjev.Obrazloženje;
            cboOdabir.Text = zahtjev.MogučnostVideopoziva;
            nmbrid.Value = zahtjev.IDPacijent;


        }

        private void FrmKreiranjeZahtjeva_Load(object sender, EventArgs e)
        {
            cboOdabir.Items.Add("Da");
            cboOdabir.Items.Add("Ne");

        }



        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmPacijent frmEmployer = new FrmPacijent();
            Hide();
            frmEmployer.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboOdabir.Text == "")
            {
                MessageBox.Show("Niste stavili odgvor na mogučnost videopoziva!", "Problem",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Zahtjev zahtjev = new Zahtjev
                {
                    Obrazloženje = txtObrazlozenje.Text,
                    MogučnostVideopoziva = cboOdabir.Text,
                    VrijemeTermina=txtTermin.Text,
                    IDPacijent = (int)nmbrid.Value
                };

                if (!edit)
                {
                    RepozitorijPacijenata.SpremiZahtjev(zahtjev);
                }
                else
                {
                    RepozitorijPacijenata.UrediZahtjev(zahtjev, editID);
                }

                edit = false;

                FrmPacijent frmPacijent = new FrmPacijent();
                Hide();
                frmPacijent.ShowDialog();
                Close();
            }
        }
    }
}
