using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToe
    {
        char[] _array = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public char[] Array
        {
            get { return _array; }
            set { _array = value; }
        }

        int _player = 1;

        public int Player
        {
            get { return _player; }
            set { _player = value; }
        }

        int _choice;

        public int Choice
        {
            get { return _choice; }
            set { _choice = value; }
        }

        int _flag = 0;

        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        public int CheckWin()
        {
            if (Array[0] == Array[1] && Array[1] == Array[2])
            {
                return 1;
            }
            else if (Array[3] == Array[4] && Array[4] == Array[5])
            {
                return 1;
            }
            else if (Array[6] == Array[7] && Array[7] == Array[8])
            {
                return 1;
            }
            else if (Array[0] == Array[3] && Array[3] == Array[6])
            {
                return 1;
            }
            else if (Array[1] == Array[4] && Array[4] == Array[7])
            {
                return 1;
            }
            else if (Array[2] == Array[5] && Array[5] == Array[8])
            {
                return 1;
            }
            else if (Array[0] == Array[4] && Array[4] == Array[8])
            {
                return 1;
            }
            else if (Array[2] == Array[4] && Array[4] == Array[6])
            {
                return 1;
            }
            else if (Array[0] != '1' && Array[1] != '2' && Array[2] != '3' && Array[3] != '4' && Array[4] != '5' && Array[5] != '6' && Array[6] != '7' && Array[7] != '8' && Array[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public string Board()
        {
            return string.Format("     |     |      \n  {0}  |  {1}  |  {2}\n_____|_____|_____ \n     |     |      \n  {3}  |  {4}  |  {5}\n_____|_____|_____\n     |     |      \n  {6}  |  {7}  |  {8}\n     |     |      ", Array[0], Array[1], Array[2], Array[3], Array[4], Array[5], Array[6], Array[7], Array[8]);
        }

        public string ChanceOfThePlayer()
        {
            if (Player % 2 == 0)
            {
                return "Player 2 Chance";
            }
            else
            {
                return "Player 1 Chance";
            }
        }

        public void MarkInBoard()
        {
            if (Array[Choice] != 'X' && Array[Choice] != 'O')
            {
                if (Player % 2 == 0)
                {
                    Array[Choice] = 'O';
                    Player++;
                }
                else
                {
                    Array[Choice] = 'X';
                    Player++;
                }
            }
            else
            {
                throw new Exception("Sorry the row " + Choice + " is already marked with " + Array[Choice]);
            }
            Flag = CheckWin();
        }

        public string WinOrDraw()
        {
            if (Flag == 1)
            {
                return "Player " + ((Player % 2) + 1) + " has won";
            }
            else if(Flag==-1)
            {
                return "Match Draw";
            }
            else
            {
                return "";
            }
        }
    }
}
