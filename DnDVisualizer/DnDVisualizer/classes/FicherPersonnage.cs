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
        private int[] _piece; // pp,gp,ep,sp,bp

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
            string race, 
            string classe, 
            int niveau, 
            string histoire,
            int force,
            int dexterite, 
            int constitution, 
            int intelligence, 
            int sagesse, 
            int charme,
            string competence, 
            string outilsProf, 
            string langue, 
            int[] piece,
            string armure, 
            string bouclier, 
            string arme, 
            string arme2, 
            string outils,
            string items, 
            string nom, 
            string sexe, 
            int age, 
            int taille, 
            int poids,
            string alignement, 
            int experience, 
            string[] traits, 
            string[] ideaux, 
            string[] lien,
            string[] defauts, 
            string[] allies
            )
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
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public string Classe
        {
            get { return _classe; }
            set { _classe = value; }
        }

        public int Niveau
        {
            get { return _niveau; }
            set { _niveau = value; }
        }

        public string Histoire
        {
            get { return _histoire; }
            set { _histoire = value; }
        }

        public int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        public int Dexterite
        {
            get { return _dexterite; }
            set { _dexterite = value; }
        }

        public int Constitution
        {
            get { return _constitution; }
            set { _constitution = value; }
        }

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }

        public int Charme
        {
            get { return _charme; }
            set { _charme = value; }
        }

        public string Competence
        {
            get { return _competence; }
            set { _competence = value; }
        }

        public string OutilsProf
        {
            get { return _outilsProf; }
            set { _outilsProf = value; }
        }

        public string Langue
        {
            get { return _langue; }
            set { _langue = value; }
        }

        public int[] Piece
        {
            get { return _piece; }
            set { _piece = value; }
        }

        public string Armure
        {
            get { return _armure; }
            set { _armure = value; }
        }

        public string Bouclier
        {
            get { return _bouclier; }
            set { _bouclier = value; }
        }

        public string Arme
        {
            get { return _arme; }
            set { _arme = value; }
        }

        public string Arme2
        {
            get { return _arme2; }
            set { _arme2 = value; }
        }

        public string Outils
        {
            get { return _outils; }
            set { _outils = value; }
        }

        public string Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public int Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }

        public string Alignement
        {
            get { return _alignement; }
            set { _alignement = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public string[] Traits
        {
            get { return _traits; }
            set { _traits = value; }
        }

        public string[] Ideaux
        {
            get { return _ideaux; }
            set { _ideaux = value; }
        }

        public string[] Lien
        {
            get { return _lien; }
            set { _lien = value; }
        }

        public string[] Defauts
        {
            get { return _defauts; }
            set { _defauts = value; }
        }

        public string[] Allies
        {
            get { return _allies; }
            set { _allies = value; }
        }
        #endregion

        #region methode

        public static void sycroArgent()
        {

        }
        #endregion
    }
}
