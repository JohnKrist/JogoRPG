using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRPG.src.entities
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string heroType, int HP, int Ataque, int Bonus, int Cura)
        {
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.Ataque = Ataque;
            this.Bonus = Bonus;
            this.Cura = Cura;

            
        }
       
        public Hero(){ 
            

        
        }

        

         public string Name;
         public int level;
         public string heroType;

        public int HP;

         public int Ataque;

         public int Bonus;
        
        public int Cura;

        


        public override string ToString()
        {
            return this.HP + " " + this.Name + " " + this.level + " " + this.heroType;

           

        }



        public virtual string Attack(int Ataque){
        
           return this.Name + " Atacou com sua espada";

        }
    }
}