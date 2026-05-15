using ETSCore.Enums;

namespace ETSCore.Types;

public class BlockPos {

    private readonly Dimension         PosDimension;
    private readonly CardinalDirection PosDirection;
    
    private readonly int       X;
    private readonly int       Y;
    private readonly int       Z;

    public BlockPos(Dimension posDimension, CardinalDirection posDirection, int x, int y, int z) {
        PosDimension = posDimension;
        PosDirection = posDirection;
        X            = x;
        Y            = y;
        Z            = z;
    }

    public Dimension GetDimension => PosDimension;

    public CardinalDirection GetDirection => PosDirection;

    public int GetX => X;

    public int GetY => Y;

    public int GetZ => Z;

}