using System;


namespace DnDVisualizer.classes
{
    class FichierPersonnage
    {
        #region attribut
        private String _race;
        private String _classe;
        private int _niveau;
        private String _histoire;

        private int _force;
        private int _dexterite;
        private int _constitution;
        private int _intelligence;
        private int _sagesse;
        private int _charme;

        private String _competence;
        private String _outilsProf;
        private String _langue;
        private int[] _piece;

        private String _armure;
        private String _bouclier;
        private String _arme;
        private String _arme2;
        private String _outils;

        private String _items;
        private String _nom;
        private String _sexe;
        private int _age;
        private int _taille; // en cm
        private int _poids;
        private String _alignement;
        private int _experience;
        private String[] _traits;
        private String[] _ideaux;
        private String[] _lien;
        private String[] _defauts;
        private String[] _allies;
        #endregion

        #region constructeur
        public FichierPersonnage(
        string race, string classe, int niveau, string histoire,
        int force, int dexterite, int constitution, int intelligence, int sagesse, int charme,
        string competence, string outilsProf, string langue, int[] piece,
        string armure, string bouclier, string arme, string arme2, string outils,
        string items, string nom, string sexe, int age, int taille, int poids,
        string alignement, int experience, string[] traits, string[] ideaux, string[] lien,
        string[] defauts, string[] allies)
        {
            _race = race;
            _classe = classe;
            _niveau = niveau;
            _histoire = histoire;

            _force = force;
            _dexterite = dexterite;
            _constitution = constitution;
            _intelligence = intelligence;
            _sagesse = sagesse;
            _charme = charme;

            _competence = competence;
            _outilsProf = outilsProf;
            _langue = langue;
            _piece = piece;

            _armure = armure;
            _bouclier = bouclier;
            _arme = arme;
            _arme2 = arme2;
            _outils = outils;

            _items = items;
            _nom = nom;
            _sexe = sexe;
            _age = age;
            _taille = taille;
            _poids = poids;
            _alignement = alignement;
            _experience = experience;
            _traits = traits;
            _ideaux = ideaux;
            _lien = lien;
            _defauts = defauts;
            _allies = allies;
        }
        #endregion

        #region propriete
        #endregion
    }
}
