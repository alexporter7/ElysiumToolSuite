using System.Text.Json.Serialization;

namespace ETSCore.Types.Cities.Residents;

public class Resident {

    public string FirstName  { get; set; }
    public string MiddleName { get; set; }
    public string LastName   { get; set; }
    public int    Age        { get; set; }
    
    public Address ResidentAddress { get; set; }
    public Job     ResidentJob     { get; set; }
    public Wallet  ResidentWallet  { get; set; }

    public Resident(string firstName, string middleName, string lastName, int age, Address residentAddress, Job residentJob, Wallet residentWallet) {
        FirstName       = firstName;
        MiddleName      = middleName;
        LastName        = lastName;
        Age             = age;
        ResidentAddress = residentAddress;
        ResidentJob     = residentJob;
        ResidentWallet  = residentWallet;
    }

}