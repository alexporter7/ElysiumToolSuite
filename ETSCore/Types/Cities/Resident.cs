namespace ETSCore.Types.Cities;

public class Resident {

    public string FirstName  { get; set; }
    public string MiddleName { get; set; }
    public string LastName   { get; set; }
    
    //TODO: Wrap into some health class or something
    public int    Age        { get; set; }
    public int    Height     { get; set; }
    public int    Weight     { get; set; }

    public Job                  ResidentJob       { get; set; }
    public Wallet               ResidentWallet    { get; set; }
    public Skillset             ResidentSkillset  { get; set; }
    public PersonalityAlignment ResidentAlignment { get; set; }

}