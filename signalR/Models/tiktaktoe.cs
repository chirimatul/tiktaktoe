using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace signalR.Models
{
    public class Tiktaktoe
    {

        public Player GetWinner(int?[,] input)
        {
            Player winner = Player.None;

            // check rows
            for (int row = 0; row < 3; row++)
            {
                if (input[row, 0] != null && input[row, 0] == input[row, 1] && input[row, 1] == input[row, 2])
                {
                    return (Player)input[row, 0];
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (input[0, col] != null && input[0, col] == input[1, col] && input[1, col] == input[2, col])
                {
                    return (Player)input[0, col];
                }
            }

            if (input[0, 0] != null && input[0, 0] == input[1, 1] && input[1, 1] == input[2, 2])
            {
                return (Player)input[0, 0];
            }
            else if (input[0, 2] != null && input[0, 2] == input[1, 1] && input[1, 1] == input[2, 0])
            {
                return (Player)input[0, 2];
            }

            return winner;
        }
    }

    public enum Player
    {
        None,
        Player1,
        Player2
    }
}