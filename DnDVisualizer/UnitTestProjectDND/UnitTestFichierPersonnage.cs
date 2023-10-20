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
            perso1 = new FichierPersonnage("","",0,"",0,0,0,0,0,0,"","","",new List<int>(5) {0,100,0,0,300},"","","","","","","","",0,"0","0","",0,new List<String>(1), new List<String>(1), new List<String>(1), new List<String>(1), new List<String>(1));
            
        }
        [TestMethod]
        public void testsychroArgent()
        {
            List<int> f = new List<int>(5) { 1, 0, 0, 3, 0 };
            perso1.sycroArgent();
            string test1 = perso1.Piece.ToString();
            string test2 = f.ToString();
            Assert.AreEqual(test1,test2);
        }
    }
}