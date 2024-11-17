Account account = new Account(10000f, 5000f);

// Print
account.Print();

// Withdraw
float balance = account.Withdraw(1500f);

if (balance != -1)
{
    Console.WriteLine("Saque realizado com sucesso!");
    Console.WriteLine($"Saldo Restante: R${balance:0.00}");
}
else
{
    Console.WriteLine("Não foi possível realizar o saque!");
}

// Deposit
balance = account.Deposit(100);
Console.WriteLine("Depósito realizado com sucesso!");
Console.WriteLine($"Saldo Restante: R${balance:0.00}");

// Payment
Console.WriteLine("Realizando pagamento no Débito...");

if (account.Pay("debit", 350f))
{
    Console.WriteLine("Pagamento no débito realizado com sucesso!");
}
else
{
    Console.WriteLine("Você não tem saldo suficiente para realizado o pagamento...");
}

account.Print();

Console.WriteLine("Realizando pagamento no Crédito...");

if (account.Pay("credit", 6000f))
{
    Console.WriteLine("Pagamento no crédito realizado com sucesso!");
}
else
{
    Console.WriteLine("Você não tem limite suficiente para realizar o pagamento...");
}

account.Print();