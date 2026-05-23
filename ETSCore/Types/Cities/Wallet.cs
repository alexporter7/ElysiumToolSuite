namespace ETSCore.Types.Cities;


//TODO: Add some way to track multiple accounts or something
public class Wallet {

    public int Money { get; set; }

    public bool HasFunds(int amount) {
        return Money > amount;
    }

    public void AddMoney(int amount) {
        Money += amount;
    }

    public void SpendMoney(int amount) {
        Money -= amount;
    }

    //Transaction
    //Current Balance + Amount Transacted + New Balance + Date + Time + Reason

}