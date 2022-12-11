using System;
namespace Lr_2
{
    class ClassicGame : Game
    {
        public ClassicGame(string gameName) : base(gameName) { }

        public override void PlayTheGame(GameAccount player1, GameAccount player2, int rating)
        {
            // check for correct rating
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be greater then zero");
            }

            // game simulation
            Random rand = new Random();
            int res = rand.Next(1, 3);

            // first player wins
            if (res == 1)
            {
                Console.WriteLine($"{player1.UserName} won the rating game!");
                player1.WinGame(player2.UserName,rating ,"Classic" );
                player2.LoseGame(player1.UserName, rating, "Classic");
            }
            // second player wins
            else
            {
                Console.WriteLine($"{player2.UserName} won the rating game!");
                player2.WinGame(player1.UserName, rating, "Classic");
                player1.LoseGame(player2.UserName, rating, "Classic");
            }
        }
    }
}