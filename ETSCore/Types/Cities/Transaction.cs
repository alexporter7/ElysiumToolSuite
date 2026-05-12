using System.Text;
using ETSCore.Enums;
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