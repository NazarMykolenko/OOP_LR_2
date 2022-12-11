using System;
using System.Collections.Generic;
namespace Lr_2
{
    public class GameAccount
    {
        private string username;
        public int currentrating;
        public int gamecount;

        public List<GameStats> data = new List<GameStats>();

        public string UserName
        {
            get { return username; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Your nickname must be longer");
                }

                username = value;
            }
        }
        public GameAccount(string username)
        {
            UserName = username;
            currentrating = 1;
            gamecount = 0;
        }
        public virtual void WinGame(string opponentName, int rating, string gameName)
        {
            var res = new GameStats(opponentName, "Win", rating, gameName);
            data.Add(res);
            currentrating += rating;
            gamecount++;
        }

        public  void LoseGame(string opponentname, int rating, string gameName)
        {
            var res = new GameStats(opponentname, "Lose", rating, gameName);
            data.Add(res);
            if (currentrating - rating <= 1)
            {
                currentrating = 1;
            }
            else 
            { 
                currentrating -= rating; 
            }

            gamecount++;
        }

        public string GetStatus()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine($"Username: {UserName}");
            report.AppendLine("Opponent\t\tGame type\tResult\tRating");
            foreach (var item in data)
            {
                if(item.GameName == "Classic")
                    report.AppendLine($"{item.OpponentName}\t\t{item.GameName}\t\t\t{item.Result}\t{item.Rating}");
                else
                    report.AppendLine($"{item.OpponentName}\t\t{item.GameName}\t\t{item.Result}\t{item.Rating}");
            }
            report.AppendLine("\nCurrent rating\tGames count");
            report.AppendLine($"{currentrating}\t\t{gamecount}");

            return report.ToString();
        }
    }
}