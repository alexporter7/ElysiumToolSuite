using ETSCore.Enums;

namespace ETSCore.Types;

public class Address {

    public  BlockPos MainPosition;
    private City     AddressCity;
    private District AddressDistrict;

    private int      Number;
    private string   Street;


    public string GetAddress() {
        return $"{Number} {Street}, {AddressDistrict.GetName()} District, {AddressCity.GetCityName()}";
    }

}