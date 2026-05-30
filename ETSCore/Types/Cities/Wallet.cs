namespace ETSCore.Types.Cities;

public class Wallet {

    public int Money { get; set; }

    public bool HasEnoughMoney(int amount) {
        return Money > amount;
    }

}