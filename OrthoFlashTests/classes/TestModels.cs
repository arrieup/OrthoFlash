using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrthoFlash.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrthoFlash.classes.Tests
{
    [TestClass()]
    public class PatientTest
    {
        [TestMethod()]
        public void EmptyTest()
        {
            Patient pierre = new Patient();
            Assert.IsTrue(pierre != null);
        }
        [TestMethod()]
        public void NomcompletTest()
        {
            Patient pierre = new Patient("Pierre", "Arrieumerlou");
            Assert.AreEqual(pierre.nom_complet, "Pierre Arrieumerlou");
        }
        [TestMethod()]
        public void FullTest()
        {
            Patient pierre = new Patient("Pierre", "Arrieumerlou", new DateTime(1960,12,13), Classe.TER);

            Assert.AreEqual(pierre.nom_complet, "Pierre Arrieumerlou");
            Assert.AreEqual(pierre.date_naissance.ToString().Split(' ')[0], "13/12/1960");
            Assert.AreEqual(pierre.classe, Classe.TER);
        }
    }

    [TestClass()]
    public class LettreTest
    {
        [TestMethod()]
        public void LettreInit()
        {
            Lettre a = new Lettre('a', 0x01);
            Assert.IsNotNull(a);
        }
        [TestMethod()]
        public void LettreToString()
        {
            Lettre b = new Lettre('b', 0x02);
            Assert.AreEqual(b.ToString(), " b : 2 ");
        }
    }

    [TestClass()]
    public class SyllabeTest
    {
        [TestMethod()]
        public void SyllabeInit()
        {
            char[] mot = new char[] { 'a', 'b' };
            byte[] code = new byte[] { 0x01, 0x03 };
            Syllabe ab = new Syllabe(mot,code);
            Assert.IsNotNull(ab);
        }
        [TestMethod()]
        public void NLettrSyllabeToString()
        {
            char[] mot = new char[] { 'a', 'c' };
            byte[] code = new byte[] { 0x01, 0x03 };
            Syllabe ac = new Syllabe(mot, code);
            Assert.AreEqual(ac.ToString()," a : 1  c : 3 ");
        }
    }

}