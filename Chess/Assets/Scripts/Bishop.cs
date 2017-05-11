public class Bishop : Chessman 
{
    public override bool[,] PossibleMove()
    {
        bool[,] move = new bool[8, 8];
        
        Chessman c;
        int i, j;

        // Diagonal Left Up
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i--;
            j++;
            
            if (i < 0 || j > 7) break; // Outside of the board

            c = BoardManager.Instance.Chessman [i, j];

            if (c == null)
            {
                move [i, j] = true;
            }
            else
            {
                if (isWhite != c.isWhite)
                {
                    move [i, j] = true;
                }

                break;
            }
        }

        // Diagonal Right Up
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i++;
            j++;
            
            if (i > 7 || j > 7) break; // Outside of the board

            c = BoardManager.Instance.Chessman [i, j];

            if (c == null)
            {
                move [i, j] = true;
            }
            else
            {
                if (isWhite != c.isWhite)
                {
                    move [i, j] = true;
                }

                break;
            }
        }

        // Diagonal Left Down
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i--;
            j--;
            
            if (i < 0 || j < 0) break; // Outside of the board

            c = BoardManager.Instance.Chessman [i, j];

            if (c == null)
            {
                move [i, j] = true;
            }
            else
            {
                if (isWhite != c.isWhite)
                {
                    move [i, j] = true;
                }

                break;
            }
        }

        // Diagonal Right Down
        i = CurrentX;
        j = CurrentY;
        while (true)
        {
            i++;
            j--;
            
            if (i > 7 || j < 0) break; // Outside of the board

            c = BoardManager.Instance.Chessman [i, j];

            if (c == null)
            {
                move [i, j] = true;
            }
            else
            {
                if (isWhite != c.isWhite)
                {
                    move [i, j] = true;
                }

                break;
            }
        }
    
        return move;
    }
}
