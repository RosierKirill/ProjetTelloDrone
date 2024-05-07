using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelloLibrary;

namespace ProjetTello
{
    public partial class Connecteur : Form
    {
        TelloControl tello = null;
        public Connecteur(TelloControl te)
        {
            tello = te;
            InitializeComponent();
        }


        private void Connecteur_Load(object sender, EventArgs e)
        {

        }


        private void submit_Click(object sender, EventArgs e)
        {

            tello.connexion(ipBox.Text);
            Console.WriteLine(ipBox.Text);
            Choix_Mod_Pilotage fenetre = new Choix_Mod_Pilotage(this);
            fenetre.ShowDialog();


        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
