using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Ingredient
    {
        private int num;
        private string nom;
        private bool bio = false; 

        public Ingredient ( string name, bool b)
        {
            
            this.nom = name;
            this.bio = b;
        }
        public Ingredient() { }

        public int getNum()
        {
            return this.num;
        }
       
        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string no)
        {
            this.nom = no;
        }
        public bool getBio()
        {
            return this.bio;
        }
        public void setBio (bool b)
        {
            this.bio = b;
        }

        
    }
}
