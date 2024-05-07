using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetTello
{
    public partial class Choix_Mod_Pilotage : Form
    {
        Connecteur connecteur = null;
        public Choix_Mod_Pilotage(Connecteur c)
        {
            connecteur = c;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modeManuel_Click(object sender, EventArgs e)
        {
            connecteur.Close();
            this.Close();
        }
    }
}
