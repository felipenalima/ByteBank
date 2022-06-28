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

CurrentAccount account = new CurrentAccount();
// CurrentAccount accountTwo = new CurrentAccount();

account.Client = client;
account.SetBalance(3254.5);
// account.account = "1234x-X";
// account.agencyName = "Central Agency";
// account.agencyNumber = 23;

// accountTwo.name = "Pamela Luz";
// accountTwo.account = "32547-X";
// accountTwo.agencyName = "Central Agency";
// accountTwo.agencyNumber = 2;
// accountTwo.balance = 5000.5;

Console.WriteLine("Name: " + account.Client.Name);
Console.WriteLine("Balance: " + account.GetBalance());
// Console.WriteLine("Account: " + account.account);
// Console.WriteLine("Agency Name: " + account.agencyName);
// Console.WriteLine("Agency Number: " + account.agencyNumber);

// Console.WriteLine("Balance before the transfer: " + account.balance);
// account.Withdraw(2000);
// Console.WriteLine("Balance after the transfer: " + account.balance);

// account.Deposit(30);
// Console.WriteLine("Balance after the deposit: " + account.balance);

// account.Transfer(300, accountTwo);
// System.Console.WriteLine(accountTwo.name + " receveid transfer of " + account.name);
// System.Console.WriteLine("New Balance: " + account.balance);
// Console.ReadLine();

