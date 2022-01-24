using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRPG.src.entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(int HP, string Name, int level, string heroType)
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

               return this.Name +  " Lançou Magia Negra rara \r\n Ataque Crítico de "+ Ataque + " + " + Bonus + " Bonus";
            
            
            
            }else if( Ataque > 7){
                Bonus = 3;
                Cura = 0;
               
               return this.Name + " Lançou Magia Negra requintada \r\n Ataque de " + Ataque +" + " + Bonus + " Bonus";

            }  
            else{

               return this.Name + " Lançou Magia Negra comun \r\n Ataque Normal de "+ Ataque;
 
            }
        }    

    }
}