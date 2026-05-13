namespace ETSCore.Types;

public class City {

    private string         Name;
    private DateTime       FoundingDate;
    private int            Population;
    private int            Area;
    private List<Resident> Residents;

    public City(string name, DateTime foundingDate, int population, int area, List<Resident> residents) {
        Name         = name;
        FoundingDate = foundingDate;
        Population   = population;
        Area         = area;
        Residents    = residents;
    }

    public string GetCityName() {
        return Name;
    }

    public DateTime GetFoundingDate {
        get => FoundingDate;
        set => FoundingDate = value;
    }

    public int GetPopulation {
        get => Population;
        set => Population = value;
    }

    public int GetArea {
        get => Area;
        set => Area = value;
    }

    public List<Resident> GetResidents {
        get => Residents;
        set => Residents = value ?? throw new ArgumentNullException(nameof(value));
    }

}