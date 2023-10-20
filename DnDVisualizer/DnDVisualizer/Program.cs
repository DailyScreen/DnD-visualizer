using System;
using System.Windows.Forms;

namespace DnDVisualizer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PasserelleXML laPasserelle = new PasserelleXML();
            FichierPersonnage perso1 = laPasserelle.getInfoPerso("NomPersonnage.xml");
            Console.WriteLine(perso1.ToString());
            //Console.WriteLine(perso1.Allies[1]);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
