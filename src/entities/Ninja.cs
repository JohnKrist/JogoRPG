using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRPG.src.entities
{
    public class Ninja : Hero 
    {
        public Ninja(int HP, string Name, int level, string heroType)
        {
        
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
        }


        
        public override string Attack(int Ataque){
            if(Ataque > 20){ 
               Cura = 2;
               Bonus = 3;
               return this.Name + " Lançou Facas  \r\n Ataque Crítico " + Ataque + " + "+ Cura +" de Cura, + " + Bonus + " de Bonus";
            
            
            } else if (Ataque > 6){
               Cura = 1;
               Bonus = 2;
               return this.Name + " Atacou rapidamente \r\n com Ataque de "+ Ataque + " + " + Cura +" de Cura, + " + Bonus + " de Bonus";
               

            } 
            else{ 
               return this.Name + " Usou ataque comun \r\n Ataque normal de " + Ataque;


       
            }    
             
        } 
    }
}