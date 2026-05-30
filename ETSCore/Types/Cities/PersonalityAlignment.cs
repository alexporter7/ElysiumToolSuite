namespace ETSCore.Types.Cities;

public class PersonalityAlignment {

    public Moral  AlignmentMoral  { get; set; }
    public Method AlignmentMethod { get; set; }
    
    public enum Moral {

        Good,
        Evil,
        Neutral

    }

    public enum Method {

        Lawful,
        Neutral,
        Good

    }

}