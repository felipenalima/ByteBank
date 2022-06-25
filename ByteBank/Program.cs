using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using ByteBank;

CurrentAccount account = new CurrentAccount();

account.name = "Felipe Lima";
account.account = "1234x-X";
account.agencyName = "Central Agency";
account.agencyNumber = 23;
account.balance = 3254.5;

Console.WriteLine("Name: " + account.name);
Console.WriteLine("Account: " + account.account);
Console.WriteLine("Agency Name: " + account.agencyName);
Console.WriteLine("Agency Number: " + account.agencyNumber);
Console.WriteLine("Balance: " + account.balance);
Console.ReadLine();