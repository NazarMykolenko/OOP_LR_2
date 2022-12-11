namespace Lr_2
{
    public class GameStats
    {
        public string OpponentName { get; set; }
        public string Result { get; set; }
        public int Rating { get; set; }
        
        public string GameName { get; set; }
        
        public GameStats(string opponentName, string result, int rating, string gameName)
        {
            OpponentName = opponentName;
            Result = result;
            Rating = rating;
            GameName = gameName;
        }
    }
}