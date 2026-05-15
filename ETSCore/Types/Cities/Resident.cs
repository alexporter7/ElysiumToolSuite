namespace ETSCore.Types;

public class Resident {

    private string  FirstName;
    private string  MiddleName;
    private string  LastName;
    private int     Age;
    private int     Salary;
    
    private Address ResidentAddress;
    private Job     ResidentJob;
    private Wallet  ResidentWallet;

    public string GetFirstName {
        get => FirstName;
        set => FirstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string GetMiddleName {
        get => MiddleName;
        set => MiddleName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string GetLastName {
        get => LastName;
        set => LastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int GetAge {
        get => Age;
        set => Age = value;
    }

    public Job GetResidentJob {
        get => ResidentJob;
        set => ResidentJob = value;
    }

    public int GetSalary {
        get => Salary;
        set => Salary = value;
    }

    public Wallet GetWallet() {
        return ResidentWallet;
    }

    public Address GetAddress() {
        return ResidentAddress;
    }

}