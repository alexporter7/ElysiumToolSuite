using ETSCore.Types.Cities;

namespace ETSCore.Types.Data;

public class City {

    public string Name       { get; set; }
    public int    Population { get; set; }

    public Guid           Id        { get; set; }
    public List<Resident> Residents { get; set; }

}