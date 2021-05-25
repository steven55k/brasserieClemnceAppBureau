using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Recette
    {
        private int num;
        private string nom;
        private DateTime creeLe;

        public Recette(string name, DateTime creeLe)
        {

            this.nom = name;
            this.creeLe = creeLe;
        }
        public Recette() { }

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

        public DateTime getCreeLe()
        {
            return this.creeLe;
        }

        public void setCreeLe(DateTime creeLe)
        {
            this.creeLe = creeLe;
        }
    }
}
