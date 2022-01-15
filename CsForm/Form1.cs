using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Java_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            string appelation = "";
            string langs = "";
            string prenom = textBoxPrenom.Text;
            string nom = textBoxNom.Text;
            string ville = Villes.SelectedItem.ToString();
            if (Homme.Checked)
            {
                appelation = "Mr";
            }
            else if (Femme.Checked)
            {
                appelation = "Mme";
            }
            if (CS.Checked)
                langs = langs + " " + CS.Text;
            if (Java.Checked)
                langs = langs + " " + Java.Text;
            if (cpp.Checked)
                langs = langs + " " + cpp.Text;

            string msg = appelation + " " + prenom + " " + nom + " " + ville + " " + langs;
            MessageBox.Show(msg);

        }
    }
}
