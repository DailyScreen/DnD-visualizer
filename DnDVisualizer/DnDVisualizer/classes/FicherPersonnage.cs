using System;
using System.Collections.Generic;

namespace DnDVisualizer
{
    public class FichierPersonnage
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
        private List<int> _piece; // pp,gp,ep,sp,bp

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
        private List<String> _traits;
        private List<String> _ideaux;
        private List<String> _lien;
        private List<String> _defauts;
        private List<String> _allies;
        #endregion

        #region constructeur
        public FichierPersonnage(
            String race, 
            String classe, 
            int niveau, 
            String histoire,
            int force,
            int dexterite, 
            int constitution, 
            int intelligence, 
            int sagesse, 
            int charme,
            String competence, 
            String outilsProf, 
            String langue, 
            List<int> piece,
            String armure, 
            String bouclier, 
            String arme, 
            String arme2, 
            String outils,
            String items, 
            String nom, 
            String sexe, 
            int age, 
            int taille, 
            int poids,
            String alignement, 
            int experience,
            List<String> traits,
            List<String> ideaux,
            List<String> lien,
            List<String> defauts,
            List<String> allies
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
        public String Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public String Classe
        {
            get { return _classe; }
            set { _classe = value; }
        }

        public int Niveau
        {
            get { return _niveau; }
            set { _niveau = value; }
        }

        public String Histoire
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

        public String Competence
        {
            get { return _competence; }
            set { _competence = value; }
        }

        public String OutilsProf
        {
            get { return _outilsProf; }
            set { _outilsProf = value; }
        }

        public String Langue
        {
            get { return _langue; }
            set { _langue = value; }
        }

        public List<int> Piece
        {
            get { return _piece; }
            set { _piece = value; }
        }

        public String Armure
        {
            get { return _armure; }
            set { _armure = value; }
        }

        public String Bouclier
        {
            get { return _bouclier; }
            set { _bouclier = value; }
        }

        public String Arme
        {
            get { return _arme; }
            set { _arme = value; }
        }

        public String Arme2
        {
            get { return _arme2; }
            set { _arme2 = value; }
        }

        public String Outils
        {
            get { return _outils; }
            set { _outils = value; }
        }

        public String Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public String Sexe
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

        public String Alignement
        {
            get { return _alignement; }
            set { _alignement = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public List<String> Traits
        {
            get { return _traits; }
            set { _traits = value; }
        }

        public List<String> Ideaux
        {
            get { return _ideaux; }
            set { _ideaux = value; }
        }

        public List<String> Lien
        {
            get { return _lien; }
            set { _lien = value; }
        }

        public List<String> Defauts
        {
            get { return _defauts; }
            set { _defauts = value; }
        }

        public List<String> Allies
        {
            get { return _allies; }
            set { _allies = value; }
        }
        #endregion

        #region methode

        public void sycroArgent()
        {
            if (this._piece[4] >= 100)
            {
                int a;
                a=this._piece[4] - 100;
                a = this._piece[3] + 1;
            }
            if (this._piece[1] >= 100)
            {
                int a;
                a = this._piece[1] - 100;
                a = this._piece[0] + 1;
            }
            if (this._piece[3] >= 100)
            {
                int a;
                a = this._piece[3] - 100;
                a = this._piece[1] + 1;
            }

        }
        #endregion
    }
}
