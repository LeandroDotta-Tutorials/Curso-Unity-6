public class Account
{
    private float balance;
    private float creditLimit;
    private float creditInvoice;

    public Account(float initialBalance, float initialCreditLimit)
    {
        balance = initialBalance;
        creditLimit = initialCreditLimit;
    }

    public float Withdraw(float amount)
    {
        if (amount > balance)
        {
            return -1;
        }
        else
        {
            balance = balance - amount;
            return balance;
        }
    }

    public float Deposit(float amount)
    {
        balance = balance + amount;
        return balance;
    }

    public bool Pay(string paymentMethod, float value)
    {
        if (paymentMethod == "debit" && value < balance)
        {
            balance = balance - value;
            return true;
        }
        else if (paymentMethod == "credit" && (creditLimit - creditInvoice) > value)
        {
            creditInvoice = creditInvoice + value;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        Console.WriteLine($"""
        
        ====================== Conta =====================
        Saldo: R${balance:0.00}
        Limit de Crédito: R${creditLimit:0.00}
        Fatura do Cartão de Crédito: R${creditInvoice:0.00}
        --------------------------------------------------
        """);
    }
}