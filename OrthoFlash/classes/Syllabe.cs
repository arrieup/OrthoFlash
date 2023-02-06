using System;
using System.Collections.Generic;
using System.Text;

namespace OrthoFlash.classes
{
    public struct Lettre
    {
        public char caractère;
        public byte couleur;
        public Lettre(char car, byte cou) { this.caractère = car; this.couleur = cou; }

        public override string ToString()
        {
            return (" " + caractère + " : " + couleur + " ");
        }
    }
    public class Syllabe
    {
        public int id { get; private set; }
        public Lettre[] Composition { get; private set; }

        public Syllabe(char[] lettres, byte[] couleurs)
        {
            Composition = new Lettre[lettres.Length];
            int i = 0;
            foreach(char c in lettres)
            {
                Composition[i] = new Lettre(c, couleurs[i]);
                i++;
            }
        }

        public override string ToString()
        {
            String ret = "";
            foreach(Lettre x in Composition)
            {
                ret += x.ToString();
            }
            return ret;
        }





    }
}
