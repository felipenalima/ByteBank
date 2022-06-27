using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using ByteBank;

// Test for Client class
Client client = new Client();
client.name = "Felipe Lima";
client.cpf = "1234567-40";
client.occupation = "Embedded Developer";

System.Console.WriteLine("Name: " + client.name);
System.Console.WriteLine("CPF: " + client.cpf);
System.Console.WriteLine("Occupation: " + client.occupation);


// Test for CurrentAccount class

// CurrentAccount account = new CurrentAccount();
// CurrentAccount accountTwo = new CurrentAccount();

// account.name = "Felipe Lima";
// account.account = "1234x-X";
// account.agencyName = "Central Agency";
// account.agencyNumber = 23;
// account.balance = 3254.5;

// accountTwo.name = "Pamela Luz";
// accountTwo.account = "32547-X";
// accountTwo.agencyName = "Central Agency";
// accountTwo.agencyNumber = 2;
// accountTwo.balance = 5000.5;

// Console.WriteLine("Name: " + account.name);
// Console.WriteLine("Account: " + account.account);
// Console.WriteLine("Agency Name: " + account.agencyName);
// Console.WriteLine("Agency Number: " + account.agencyNumber);
// Console.WriteLine("Balance: " + account.balance);

// Console.WriteLine("Balance before the transfer: " + account.balance);
// account.Withdraw(2000);
// Console.WriteLine("Balance after the transfer: " + account.balance);

// account.Deposit(30);
// Console.WriteLine("Balance after the deposit: " + account.balance);

// account.Transfer(300, accountTwo);
// System.Console.WriteLine(accountTwo.name + " receveid transfer of " + account.name);
// System.Console.WriteLine("New Balance: " + account.balance);
// Console.ReadLine();

