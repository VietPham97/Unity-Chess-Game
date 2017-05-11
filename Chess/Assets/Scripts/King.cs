public class King : Chessman 
{
    public override bool[,] PossibleMove()
    {   
        bool[,] move = new bool[8, 8];

        Chessman c;
        int i, j;

        // Up, Diagonal Left, Diagonal Right
        i = CurrentX - 1;
        j = CurrentY + 1;

        if (CurrentY != 7) /* Top side of the board from White view */
        {
            for (int k = 0; k < 3; k++)
            {
                if (i >= 0 || i <= 7) /* Inside the board */
                {
                    c = BoardManager.Instance.Chessman [i, j];

                    if (c == null) /* empty space */
                    {
                        move [i, j] = true;
                    }
                    else if (isWhite != c.isWhite) /* there is an enemy */
                    {
                        move [i, j] = true;
                    }
                }
                
                i++;
            }
        }

        // Left
        if (CurrentX != 0)
        {
            c = BoardManager.Instance.Chessman [CurrentX - 1, CurrentY];

            if (c == null) /* empty space */
            {
                move [CurrentX - 1, CurrentY] = true;
            }
            else if (isWhite != c.isWhite) /* there is an enemy */
            {
                move [CurrentX - 1, CurrentY] = true;
            }
        }
        
        // Right
        if (CurrentX != 7)
        {
            c = BoardManager.Instance.Chessman [CurrentX + 1, CurrentY];

            if (c == null) /* empty space */
            {
                move [CurrentX + 1, CurrentY] = true;
            }
            else if (isWhite != c.isWhite) /* there is an enemy */
            {
                move [CurrentX + 1, CurrentY] = true;
            }
        }
        
        // Down, Diagonal Left, Diagonal Right
        i = CurrentX - 1;
        j = CurrentY - 1;

        if (CurrentY != 0) /* Bottom side of the board from White view */
        {
            for (int k = 0; k < 3; k++)
            {
                if (i >= 0 || i <= 7) /* Inside the board */
                {
                    c = BoardManager.Instance.Chessman [i, j];

                    if (c == null) /* empty space */
                    {
                        move [i, j] = true;
                    }
                    else if (isWhite != c.isWhite) /* there is an enemy */
                    {
                        move [i, j] = true;
                    }
                }

                i++;
            }
        }

        return move;
    }
}
