using System;
namespace Lr_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var messi = new GameAccount("Messi");
            var ronaldo = new PremiumAccount("Ronaldo");
            ClassicGame fifa = new ClassicGame("FIFA2023");
            NoRatingGame pes = new NoRatingGame("PES2023");
            
            fifa.PlayTheGame(messi,ronaldo,3);
            pes.PlayTheGame(messi,ronaldo,0);
            fifa.PlayTheGame(messi,ronaldo,3);
            pes.PlayTheGame(messi,ronaldo,0);
            
            Console.WriteLine("");
            Console.WriteLine(messi.GetStatus());
            Console.WriteLine("");
            Console.WriteLine(ronaldo.GetStatus());
        }
    }
}