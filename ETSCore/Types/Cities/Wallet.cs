namespace ETSCore.Types;

public class Wallet {

    private int Money;

    public int GetMoney() {
        return Money;
    }

    public void SetMoney(int amount) {
        Money = amount;
    }

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