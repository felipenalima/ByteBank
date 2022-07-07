using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using ByteBank;

// Test for Client class

try{

    Client client = new Client();
    client.Name = "Felipe Lima";
    client.Cpf = "1234567-40";
    client.Occupation = "Embedded Developer";

    System.Console.WriteLine("Name: " + client.Name);
    System.Console.WriteLine("CPF: " + client.Cpf);
    System.Console.WriteLine("Occupation: " + client.Occupation);


    // Test for CurrentAccount class

    CurrentAccount account = new CurrentAccount(23,1234);
    CurrentAccount accountTwo = new CurrentAccount(1,1);

    account.Client = client;   
    account.SetBalance(3254.5);
    //account.Withdraw(20);

    accountTwo.SetBalance(5000);
    accountTwo.Transfer(6000, account);

    Console.WriteLine("Name: " + account.Client.Name);
    Console.WriteLine("Balance: " + account.GetBalance());
    Console.WriteLine("Agency Number: " + account.AgencyNumber + " Account: " + account.Account);
    Console.WriteLine("Operation Fee: " + CurrentAccount.OperationFee);
    Console.WriteLine("Total Accounts Created: " + CurrentAccount.TotalAccountsCreated);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch(InsufficientBalanceException ex)
{
    Console.WriteLine(ex.Message);
}
catch(FinancialOperationException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

    Console.WriteLine("InnerException Example");

    Console.WriteLine(ex.InnerException.Message);
    Console.WriteLine(ex.InnerException.StackTrace);
}

