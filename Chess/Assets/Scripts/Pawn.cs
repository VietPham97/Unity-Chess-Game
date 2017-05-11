public class Pawn : Chessman 
{
    public override bool[,] PossibleMove()
    {
        bool[,] move = new bool[8, 8];

        move[3,3] = true;

        return move;
    }
}
