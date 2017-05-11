public class Knight : Chessman 
{
    public override bool[,] PossibleMove()
    {   
        bool[,] move = new bool[8, 8];
        
        // 1 step Up 2 step left 
        KnightMove (CurrentX - 2, CurrentY + 1, ref move);
        
        // 1 step Up 2 step right 
        KnightMove (CurrentX + 2, CurrentY + 1, ref move);
        
        // 2 step Up 1 step left 
        KnightMove (CurrentX - 1, CurrentY + 2, ref move);
        
        // 2 step Up 1 step right 
        KnightMove (CurrentX + 1, CurrentY + 2, ref move);
        
        // 1 step Down 2 step left 
        KnightMove (CurrentX - 2, CurrentY - 1, ref move);
        
        // 1 step Down 2 step right 
        KnightMove (CurrentX + 2, CurrentY - 1, ref move);
        
        // 2 step Down 1 step left 
        KnightMove (CurrentX - 1, CurrentY - 2, ref move);
        
        // 2 step Down 1 step right 
        KnightMove (CurrentX + 1, CurrentY - 2, ref move);
        
        return move;
    }

    public void KnightMove (int x, int y, ref bool[,] move)
    {
        Chessman c;

        if (x >= 0 && x < 8 && y >= 0 && y < 8) /* Inside the board */
        {
            c = BoardManager.Instance.Chessman[x, y];

            if (c == null) // empty space
            {
                move [x, y] = true;
            }
            else if (isWhite != c.isWhite) // there is an enemy
            {
                move [x, y] = true;
            }
        }
    }
}
