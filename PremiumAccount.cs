namespace Lr_2
{
    public class PremiumAccount : GameAccount
    {
        public PremiumAccount(string name) : base(name)
        {
        }
        public override void WinGame(string opponentName, int rating, string gameName)
        {
            
            var winGame = new GameStats(opponentName,"Win", rating*2, gameName);
            data.Add(winGame);
            gamecount++;
            currentrating += rating * 2;
        }

        
    }
}