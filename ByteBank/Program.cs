using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using ByteBank;

// Test for Client class

Client client = new Client();
client.Name = "Felipe Lima";
client.Cpf = "1234567-40";
client.Occupation = "Embedded Developer";

System.Console.WriteLine("Name: " + client.Name);
System.Console.WriteLine("CPF: " + client.Cpf);
System.Console.WriteLine("Occupation: " + client.Occupation);


// Test for CurrentAccount class

CurrentAccount account = new CurrentAccount(23,"1234-X");
CurrentAccount accountTwo = new CurrentAccount(2,"32547-X");

account.Client = client;
account.SetBalance(3254.5);

Console.WriteLine("Name: " + account.Client.Name);
Console.WriteLine("Balance: " + account.GetBalance());
Console.WriteLine("Agency Number: " + account.AgencyNumber + " Account: " + account.Account);
Console.WriteLine("Total Accounts Created: " + CurrentAccount.TotalAccountsCreated);


