using System;


namespace Lr_2
{
    abstract class Game
    {
        public int Rating { get; set; }
        public string GameName { get; set; }
        public Game(string gameName)
        {
            GameName = gameName;
        }
        
        public abstract void PlayTheGame(GameAccount player1, GameAccount player2, int rating);
    }
}