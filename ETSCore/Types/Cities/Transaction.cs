using System.Text;
using ETSCore.Enums;
using ETSCore.Types.Cities.Residents;
using Microsoft.Extensions.Logging;

namespace ETSCore.Types;

public class Transaction {
    
    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private static ILogger Logger = LogFactory.CreateLogger<Transaction>();

    private Guid             TransactionId;
    private string           Memo;
    private int              StartingBalance;
    private int              AmountTransacted;
    private int              NewBalance;
    private Resident         Creator;
    private Resident         Customer;
    private TransactionState TransactionState;

    public Transaction(string memo, int startingBalance, int amountTransacted, int newBalance, Resident creator, Resident customer) {
        Logger.LogInformation("Initializing new transaction");
        TransactionId    = Guid.NewGuid();
        Memo             = memo;
        StartingBalance  = startingBalance;
        AmountTransacted = amountTransacted;
        NewBalance       = newBalance;
        Creator          = creator;
        Customer         = customer;
        TransactionState = TransactionState.Initialized;
    }

    public bool AttemptTransaction() {
        Logger.LogInformation($"Attempting Transaction between [{Creator.FirstName}] and [{Customer.FirstName}");
        if (!Customer.ResidentWallet.HasFunds(AmountTransacted)) {
            Logger.LogInformation($"Resident [{Customer.FirstName}] only has [{Customer.ResidentWallet.Money} but the" +
                                  $" the transaction amount is [{AmountTransacted}]");
            return false;
        }
        Logger.LogInformation($"Resident [{Customer.FirstName}] has enough funds [{Customer.ResidentWallet.Money}" +
                              $"for the transaction of [{AmountTransacted}]");
        Customer.ResidentWallet.SpendMoney(AmountTransacted);
        Creator.ResidentWallet.AddMoney(AmountTransacted);

        return true;
    }

    public override string ToString() {
        return new StringBuilder()
               .Append("Transaction ID: " + TransactionId)
               .Append("Memo: " + Memo)
               .Append("Starting Balance: " + StartingBalance)
               .Append("Amount Transacted: " + AmountTransacted)
               .Append("New Balance: " + NewBalance)
               .Append("Transaction Creator: " + Creator)
               .Append("Transaction Customer: " + Customer)
               .ToString();
    }

}