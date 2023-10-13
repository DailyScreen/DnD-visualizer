using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DnDVisualizer;
using System.Collections.Generic;

namespace UnitTestProjectDND
{
    [TestClass]
    public class UnitTestFichierPersonnage
    {
        private FichierPersonnage perso1; 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            perso1 = new FichierPersonnage("","",0,"",0,0,0,0,0,0,"","","",new List<int>(5) {0,0,0,0,100},"","","","","","","","",0,0,0,"",0,new List<String>(1), new List<String>(1), new List<String>(1), new List<String>(1), new List<String>(1));
            
        }
        [TestMethod]
        public void testsychroArgent()
        {
            List<int> f = new List<int>(5) { 0, 0, 0, 1, 0 };
            perso1.sycroArgent();
            bool test = perso1.Piece.Equals(f);
            Assert.IsTrue(test);
        }
    }
}