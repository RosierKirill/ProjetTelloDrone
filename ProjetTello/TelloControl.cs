using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TelloLibrary;

namespace ProjetTello
{
    public class TelloControl
    {

        public Tello tello;

        public TelloControl()
        {
        }

        public void connexion(string ip)
        {
            tello = new Tello(ip);
            Console.WriteLine(tello.ToString());
        }
        public void decollageAterissage(int i)
        {
            switch (i)
            {
                case 0:
                    tello.TakeOff();
                    break;
                case 1:
                    this.tello.Land();
                    break;
            }
        }
        public void rotationDroite(int a)
        {
            tello.TurnClockwise(a);
        }
        public void rotationGauche(int a)
        {
            tello.TurnCounterClockwise(a);
        }
            
        public void avancer(int a)
        {
            tello.MoveForward(a);
        }
        public void monter(int a)
        {
            tello.MoveUp(a);
        }
        public void descendre(int a)
        {
            tello.MoveDown(a);
        }
        public void gauche(int a)
        {
            tello.MoveLeft(a);
        }
        public void droite(int a) 
        {
            tello.MoveRight(a);
        }
        public void arriere(int a)
        {
            tello.MoveBackward(a);
        }
        public void modeAuto(int h, int a)
        {
                tello.MoveUp(h);
                avancer(a);
            
        }
        public String battery()
        {
            return tello.Battery() + "%";
        }
    }
}
