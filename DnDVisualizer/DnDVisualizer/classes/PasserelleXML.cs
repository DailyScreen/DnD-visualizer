using System;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace DnDVisualizer
{
    public class PasserelleXML : Passerelle
    {
        //leDocument.ReadToFollowing("number");
        //leDocument.Read();
        //String number = leDocument.Value;

        public override FichierPersonnage getInfoPerso(String url)
        {

            StreamReader unFluxEnLecture = getFluxEnLecture(url);
            XmlReader leDocument = getDocumentXML(unFluxEnLecture);


            List<int> piece = new List<int>(5) { 0,0,0,0,0};

            leDocument.ReadToFollowing("race");
            leDocument.Read();
            String race = leDocument.Value;
            leDocument.ReadToFollowing("class");
            leDocument.Read();
            String classe = leDocument.Value;
            leDocument.ReadToFollowing("level");
            leDocument.Read();
            int niveau = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("background");
            leDocument.Read();
            String histoire = leDocument.Value;
            leDocument.ReadToFollowing("str");
            leDocument.Read();
            int force = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("dex");
            leDocument.Read();
            int dexterite = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("con");
            leDocument.Read();
            int constitution = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("int");
            leDocument.Read();
            int intelligence = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("wis");
            leDocument.Read();
            int sagesse = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("cha");
            leDocument.Read();
            int charme = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("skillsProf");
            leDocument.Read();
            String competence = leDocument.Value;
            leDocument.ReadToFollowing("toolsProf");
            leDocument.Read();
            String outilsProf = leDocument.Value;
            leDocument.ReadToFollowing("languages");
            leDocument.Read();
            String langue = leDocument.Value;
            leDocument.ReadToFollowing("gp");
            leDocument.Read();
            piece[1] = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("pp");
            leDocument.Read();
            piece[0] = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("ep");
            leDocument.Read();
            piece[2] = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("sp");
            leDocument.Read();
            piece[3] = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("cp");
            leDocument.Read();
            piece[4] = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("armor");
            leDocument.Read();
            String armure = leDocument.Value;
            leDocument.ReadToFollowing("shield");
            leDocument.Read();
            String bouclier = leDocument.Value;
            leDocument.ReadToFollowing("weapon");
            leDocument.Read();
            String arme = "";String arme2 = "";
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                arme = truc[0].ToString();
                arme2 = truc[1].ToString();

            }
            leDocument.ReadToFollowing("tools");
            leDocument.Read();
            String outils = leDocument.Value;
            leDocument.ReadToFollowing("item");
            leDocument.Read();
            String items = leDocument.Value;
            leDocument.ReadToFollowing("name");
            leDocument.Read();
            String nom = leDocument.Value;
            leDocument.ReadToFollowing("sexe");
            leDocument.Read();
            String sexe = leDocument.Value;
            leDocument.ReadToFollowing("age");
            leDocument.Read();
            int age = Convert.ToInt32(leDocument.Value);
            leDocument.ReadToFollowing("height");
            leDocument.Read();
            String taille = leDocument.Value;
            leDocument.ReadToFollowing("weight");
            leDocument.Read();
            String poids = (leDocument.Value);
            leDocument.ReadToFollowing("alignment");
            leDocument.Read();
            String alignement = leDocument.Value;
            leDocument.ReadToFollowing("xp");
            leDocument.Read();
            int experience = Convert.ToInt32(leDocument.Value);
            List<String> traits = new List<string>(0);
            leDocument.ReadToFollowing("traits");
            leDocument.Read();
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                foreach (String element in truc) { traits.Add(element); }

            }
            List<String> ideaux = new List<string>(0);
            leDocument.ReadToFollowing("ideals");
            leDocument.Read();
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                foreach (String element in truc) { ideaux.Add(element); }

            }

            List<String> lien = new List<string>(0);
            leDocument.ReadToFollowing("bonds");
            leDocument.Read();
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                foreach (String element in truc) { lien.Add(element); }

            }
            List<String> defauts = new List<string>(0);
            leDocument.ReadToFollowing("flaws");
            leDocument.Read();
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                foreach (String element in truc) { defauts.Add(element); }

            }
            leDocument.ReadToFollowing("allies");
            leDocument.Read();
            List<String> allies = new List<string>(0);
            if (leDocument.Value.Contains(","))
            {
                String[] truc = leDocument.Value.Split(',');
                foreach (String element in truc) { allies.Add(element); }

            }
            

            FichierPersonnage unPerso = new FichierPersonnage(race, classe, niveau, histoire, force,
                dexterite, constitution, intelligence, sagesse, charme, competence, outilsProf, langue,
                piece, armure, bouclier, arme, arme2, outils, items, nom, sexe, age, taille, poids,
                alignement, experience, traits, ideaux, lien, defauts, allies);
            return unPerso;
        }
	}
}
