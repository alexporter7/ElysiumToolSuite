using ETSCore.Enums;

namespace ETSCore.Types;

public class Address {

    public int    Number  { get; set; }
    public string Street  { get; set; }
    public string CityKey { get; set; }

    public BlockPos MainPosition    { get; set; }
    public City     AddressCity     { get; set; }
    public District AddressDistrict { get; set; }


    public Address(BlockPos mainPosition, City addressCity, District addressDistrict, int number, string street) {
        MainPosition    = mainPosition;
        AddressCity     = addressCity;
        AddressDistrict = addressDistrict;
        Number          = number;
        Street          = street;
    }

    public string GetAddressString() {
        return $"{Number} {Street}, {AddressDistrict.GetName()} District, {AddressCity.GetCityName()}";
    }

}