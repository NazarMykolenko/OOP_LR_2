using System;
namespace Lr_2
{
    class NoRatingGame : Game
    {
        public NoRatingGame(string gameName) : base(gameName)
        {
        }

        public override void PlayTheGame(GameAccount player1, GameAccount player2, int rating)
        {

            rating = 0;

            Random rand = new Random();
            int res = rand.Next(1, 3);

            // first player wins
            if (res == 1)
            {
                Console.WriteLine($"{player1.UserName} won the training game!");
                player1.WinGame(player2.UserName, rating, "NoRatingGame");
                player2.LoseGame(player1.UserName, rating, "NoRatingGame");
            }
            // second player wins
            else
            {
                Console.WriteLine($"{player2.UserName} won the training game!");
                player2.WinGame(player1.UserName, rating, "NoRatingGame");
                player1.LoseGame(player2.UserName, rating, "NoRatingGame");
            }
        }
    }
}