using System;
using ExemploRPG.src.entities;

namespace Exemplo4
{
    class program
    {
        static void Main(string[] Args)
        {
            
            Knigth arus = new Knigth(469, "Arus", 21, "knigth");
            WhiteWizard jennica = new WhiteWizard(325,"Jennica", 25, "WhiteMagic");
            BlackWizard topapa = new BlackWizard(106, "Topapa", 31, "BlackMagic");
            Ninja wedge = new Ninja(292, "wedge", 47, "NinjaFlash" );
             
             System.Console.WriteLine("--------------------------------------------------");
             System.Console.WriteLine(jennica);
             System.Console.WriteLine("--------------------------------------------------");
           
            System.Console.WriteLine(jennica.Attack(2));
            System.Console.WriteLine(jennica.Attack(10));
            System.Console.WriteLine(jennica.Attack(25));
             
             System.Console.WriteLine("--------------------------------------------------");
             System.Console.WriteLine(topapa);
             System.Console.WriteLine("--------------------------------------------------"); 

            System.Console.WriteLine(topapa.Attack(16));
            System.Console.WriteLine(topapa.Attack(8));
            System.Console.WriteLine(topapa.Attack(3));
             
             System.Console.WriteLine("--------------------------------------------------");
             System.Console.WriteLine(wedge);
             System.Console.WriteLine("--------------------------------------------------");

            System.Console.WriteLine(wedge.Attack(9));
            System.Console.WriteLine(wedge.Attack(23));
            System.Console.WriteLine(wedge.Attack(4));
             
             System.Console.WriteLine("--------------------------------------------------");
             System.Console.WriteLine(arus);
             System.Console.WriteLine("--------------------------------------------------");

            System.Console.WriteLine(arus.Attack(19));
            System.Console.WriteLine(arus.Attack(10));
            System.Console.WriteLine(arus.Attack(1));
            

        }
    }
    
}

