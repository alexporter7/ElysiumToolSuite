namespace ETSCore.Types;

public class District {

    private string Name;
    private City   DistrictCity;

    public string GetName() {
        return Name;
    }

    public City GetCity() {
        return DistrictCity;
    }

}