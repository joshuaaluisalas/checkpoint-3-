using System;
using System.Collections.Generic;
using System.Text;

namespace Alquisalas_CheckPointExam3
{
    class Player
    {
        private string playerName;
        private int points;
        private int rebounds;
        private int assists;

        public int com;
        public string GetName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int GetPoints
        {
            get { return points; }
            set { points = value; }
        }
        public int GetRebounds
        {
            get { return rebounds; }
            set { rebounds = value; }
        }
        public int GetAssists
        {
            get { return assists; }
            set { assists = value; }
        }
        public Player()
        {
            playerName = " ";
            points = -1;
            rebounds = -1;
            assists = -1;
        }
        public Player(string playerNames, int playerPoints, int playerRebounds, int playerAssists)
        {
            this.playerName = playerNames;
            this.points = playerPoints;
            this.rebounds = playerRebounds;
            this.assists = playerAssists;
        }
        public int HasMorePoints(int comPoints)
        {
            if (points == comPoints)
            {
                com = 3;
            }
            else if (points < comPoints)
            {
                com = 2;
            }
            else if (points > comPoints)
            {
                com = 1;
            }
            return com;
        }
        public int HasMoreRebounds(int comRebounds)
        {
            if (rebounds > comRebounds)
            {
                com = 1;
            }
            else if (rebounds < comRebounds)
            {
                com = 2;
            }
            else if (rebounds == comRebounds)
            {
                com = 3;
            }
            return com;
        }
        public int HasMoreAssists(int comAssists)
        {
            if (assists == comAssists)
            {
                com = 3;
            }
            else if (assists < comAssists)
            {
                com = 2;
            }
            else if (assists > comAssists)
            {
                com = 1;
            }
            return com;
        }
    }
}

