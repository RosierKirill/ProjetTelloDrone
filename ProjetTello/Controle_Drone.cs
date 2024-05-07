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
    public partial class Controle_Drone : Form
    {
        Boolean flags = false;
        public Controle_Drone()
        {
            InitializeComponent();
            Connecteur connecteur = new Connecteur(tello);
            connecteur.ShowDialog();
        }
        private TelloControl tello = new TelloControl();
            

        private void retourChoix_Click(object sender, EventArgs e)
        {
        }
        private void end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decollerAtterrir_Click(object sender, EventArgs e)
        {
            if (flags)
            {
                lbletat.Text = "Aterissage";
                decollerAtterrir.BackColor = Color.Red;
                tello.decollageAterissage(1);
                flags = false;
            }
            else
            {
                lbletat.Text = "Décollage";
                decollerAtterrir.BackColor = Color.Blue;
                tello.decollageAterissage(0);
                flags = true;
            }
        }

        private void TurnClockwise_Click(object sender, EventArgs e)
        {
            tello.rotationGauche(Decimal.ToInt32(rotationLeft.Value));
        }

        private void Controle_Drone_Load(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
        batteryLevel.Text = tello.battery();
        }

        private void reculer_Click(object sender, EventArgs e)
        {
            tello.arriere(Decimal.ToInt32(distanceNumber.Value));
        }

        private void avancer_Click(object sender, EventArgs e)
        {
            tello.avancer(Decimal.ToInt32(distanceNumber.Value));
        }

        private void monter_Click(object sender, EventArgs e)
        {
            tello.monter(Decimal.ToInt32(hauteurDist.Value));
        }

        private void droite_Click(object sender, EventArgs e)
        {
            tello.droite(Decimal.ToInt32(distanceNumber.Value));
        }

        private void gauche_Click(object sender, EventArgs e)
        {
            tello.gauche(Decimal.ToInt32(distanceNumber.Value));
        }

        private void TurnPasClockwise_Click(object sender, EventArgs e)
        {
            tello.rotationDroite(Decimal.ToInt32(rotationRight.Value));
        }

        private void descendre_Click(object sender, EventArgs e)
        {
            tello.descendre(Decimal.ToInt32(DescendreDist.Value));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rotateRight_TextChanged(object sender, EventArgs e)
        {

        }

        private void distance_TextChanged(object sender, EventArgs e)
        {

        }

        private void auto_Click(object sender, EventArgs e)
        {
            tello.modeAuto(Decimal.ToInt32(hauteurDist.Value), Decimal.ToInt32(distanceNumber.Value));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rotationLeft_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DescendreDist_ValueChanged(object sender, EventArgs e)
        {

        }

        private void batteryLevel_Click(object sender, EventArgs e)
        {
        
        }
    }
}
