public class Pawn : Chessman 
{
    public override bool[,] PossibleMove()
    {
        bool[,] move = new bool[8, 8];
        Chessman c, c2;
        int[] e = BoardManager.Instance.EnPassantMove;

        if (isWhite) /* White team */
        {
            // Diagonal Left
            if (CurrentX != 0 && CurrentY != 7) /* Left side and Top side from White view */
            {
                if (e[0] == CurrentX - 1 && e[1] == CurrentY + 1)
                    move [CurrentX - 1, CurrentY + 1] = true;

                c = BoardManager.Instance.Chessman[CurrentX - 1, CurrentY + 1];

                if (c != null && !c.isWhite)
                    move [CurrentX - 1, CurrentY + 1] = true;
            }

            // Diagonal Right
            if (CurrentX != 7 && CurrentY != 7) /* Right side and Top side from White view */
            {
                if (e[0] == CurrentX + 1 && e[1] == CurrentY + 1)
                    move [CurrentX + 1, CurrentY + 1] = true;

                c = BoardManager.Instance.Chessman[CurrentX + 1, CurrentY + 1];

                if (c != null && !c.isWhite)
                    move [CurrentX + 1, CurrentY + 1] = true;
            }

            // Middle
            if (CurrentY != 7) /* Top side from White view */
            {
                c = BoardManager.Instance.Chessman[CurrentX, CurrentY + 1];

                if (c == null)
                    move [CurrentX, CurrentY + 1] = true;
            }

            // Middle 2 step
            if (CurrentY == 1)
            {
                c = BoardManager.Instance.Chessman[CurrentX, CurrentY + 1];
                c2 = BoardManager.Instance.Chessman[CurrentX, CurrentY + 2];
    
                if (c == null && c2 == null)
                    move [CurrentX, CurrentY + 2] = true;
            }
        }
        else /* Black team */
        {
            // Diagonal Left
            if (CurrentX != 0 && CurrentY != 0) /* Left side and Bottom side from White view */
            {
                if (e[0] == CurrentX - 1 && e[1] == CurrentY - 1)
                    move [CurrentX - 1, CurrentY - 1] = true;

                c = BoardManager.Instance.Chessman[CurrentX - 1, CurrentY - 1];

                if (c != null && c.isWhite)
                    move [CurrentX - 1, CurrentY - 1] = true;
            }

            // Diagonal Right
            if (CurrentX != 7 && CurrentY != 0) /* Right side and Bottom side from White view */
            {
                if (e[0] == CurrentX + 1 && e[1] == CurrentY - 1)
                    move [CurrentX + 1, CurrentY - 1] = true;

                c = BoardManager.Instance.Chessman[CurrentX + 1, CurrentY - 1];

                if (c != null && c.isWhite)
                    move [CurrentX + 1, CurrentY - 1] = true;
            }

            // Middle
            if (CurrentY != 0) /* Bottom side from White view */
            {
                c = BoardManager.Instance.Chessman[CurrentX, CurrentY - 1];

                if (c == null)
                    move [CurrentX, CurrentY - 1] = true;
            }

            // Middle 2 step
            if (CurrentY == 6)
            {
                c = BoardManager.Instance.Chessman[CurrentX, CurrentY - 1];
                c2 = BoardManager.Instance.Chessman[CurrentX, CurrentY - 2];
    
                if (c == null && c2 == null)
                    move [CurrentX, CurrentY - 2] = true;
            }
        }
        
        return move;
    }
}
