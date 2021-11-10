using System;
using System.Collections.Generic;
using System.Text;

namespace Alquisalas_CheckPointExam3
{
    class Team
    {
        private int totals;

        public Team()
        {
            totals = 0;
        }

        public int ComputeTotals(int player1, int player2, int player3, int player4, int player5)
        {
            totals = player1 + player2 + player3 + player4 + player5;
            return totals;
        }
    }
}

