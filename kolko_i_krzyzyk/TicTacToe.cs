using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk
{
    public class TicTacToe
    {
        private Square[][] board =
        {
            new Square[3],
            new Square[3],
            new Square[3]

        };

        internal void PlayGame()
        {
            Player player = Player.Crosses;
            bool flaga = true;
            while (flaga)
            {
                DisplayBoard();
                flaga = PlayMove(player);
                if (!flaga)
                {
                    return;
                }
                player = 3 - player;
            }
        }
    }
}
