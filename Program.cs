using System;
using ProjetoRPG.src.Entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Knight("Arus", 12, "Knight");
            Hero jennica = new Wizard("Jennica", 11, "White Mage");
            Hero ninjarino = new Ninja("Ninjarino", 12, "Ninja");
            Hero blackMage = new Wizard("Black Mage", 11, "Black Mage");

            Console.WriteLine(arus.ToString());
            Console.WriteLine(jennica.ToString());
            Console.WriteLine(ninjarino.ToString());
            Console.WriteLine(blackMage.ToString());

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine(ninjarino.Attack(10));
            Console.WriteLine(blackMage.Attack());
            Console.WriteLine(blackMage.Attack(20));
        }
    }
}
