namespace ExemploRPG.src.entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(int HP, string Name, int level, string heroType)
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
               return this.Name + " Lançou Magia Branca no Alvo \r\n Ataque Crítico " + Ataque + " + "+ Cura +" de Cura, + " + Bonus + " de Bonus";
            
            }else if (Ataque > 6){
              Cura = 1;
              Bonus = 2;
               return this.Name + " Lançou Magia Branca Efetiva \r\n com Ataque de "+ Ataque + " + " + Cura +" de Cura, + " + Bonus + " de Bonus";
            }else{ 
               return this.Name + " Lançou Magia Branca Comun \r\n Ataque normal de " + Ataque;
         } 
      }
   }
}