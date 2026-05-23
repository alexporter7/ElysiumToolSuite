namespace ETSCore.Types;

public class District {

    private string Name;
    private City   DistrictCity; //TODO: this name is stupid

    public District(string name, City city) {
        Name         = name;
        DistrictCity = city;
    }

    public string GetName() {
        return Name;
    }

    public City GetCity() {
        return DistrictCity;
    }

}