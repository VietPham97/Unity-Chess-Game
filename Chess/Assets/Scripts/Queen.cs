public class Queen : Chessman 
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

        // Right
        i = CurrentX;
        while (true)
        {
            i++;
            if (i > 7) break; // outside the board

            c = BoardManager.Instance.Chessman [i, CurrentY];
            
            if (c == null)
            {
                move [i, CurrentY] = true;
            }
            else
            {
                if (c.isWhite != isWhite) // there is an enemy
                    move [i, CurrentY] = true;

                break;
            }
        }

        // Left
        i = CurrentX;
        while (true)
        {
            i--;
            if (i < 0) break; // outside the board

            c = BoardManager.Instance.Chessman [i, CurrentY];
            
            if (c == null)
            {
                move [i, CurrentY] = true;
            }
            else
            {
                if (c.isWhite != isWhite) // there is an enemy
                    move [i, CurrentY] = true;

                break;
            }
        }

        // Up
        i = CurrentY;
        while (true)
        {
            i++;
            if (i > 7) break; // outside the board

            c = BoardManager.Instance.Chessman [CurrentX, i];
            
            if (c == null)
            {
                move [CurrentX, i] = true;
            }
            else
            {
                if (c.isWhite != isWhite) // there is an enemy
                    move [CurrentX, i] = true;

                break;
            }
        }

        // Down
        i = CurrentY;
        while (true)
        {
            i--;
            if (i < 0) break; // outside the board

            c = BoardManager.Instance.Chessman [CurrentX, i];
            
            if (c == null)
            {
                move [CurrentX, i] = true;
            }
            else
            {
                if (c.isWhite != isWhite) // there is an enemy
                    move [CurrentX, i] = true;

                break;
            }
        }

        return move; 
    }
}
