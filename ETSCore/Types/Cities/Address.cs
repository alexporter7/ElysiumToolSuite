using ETSCore.Enums;

namespace ETSCore.Types;

public class Address {

    //TODO: Add actual street objects?

    public BlockPos MainPosition = new BlockPos(Dimension.Overworld, CardinalDirection.East, 1, 2, 3);

    public int    Number;
    public string Street;
    public string City;


    public string GetAddress() {
        return $"{Number} {Street}, {City}";
    }

}