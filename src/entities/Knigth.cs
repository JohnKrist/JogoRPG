using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRPG.src.entities
{
    public class Knigth : Hero
    {
        public Knigth(int HP, string Name, int level, string heroType)
        {
        
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
        
        }



        public override string Attack(int Ataque){
            if(Ataque > 15){
                Bonus = 4;
                Cura = 0;

               return this.Name +  " Dilacerou com a espada \r\n Ataque Crítico de "+ Ataque + " + " + Bonus + " Bonus";
            
            
            
            }else if( Ataque > 7){
                Bonus = 3;
                Cura = 0;
               
               return this.Name + " Perfurou com a espada \r\n Ataque de " + Ataque +" + " + Bonus + " Bonus";

            }  
            else{

               return this.Name + " Cortou com a espada \r\n Ataque Normal de "+ Ataque;
            }        
         }  
    }
}