using ByteBankAdmin.CommercialPartner;
using ByteBankAdmin.Employees;
using ByteBankAdmin.InternalSystem;
using ByteBankAdmin.Utils;

Console.WriteLine("Welcome to the ByteBank Admin");

BonificatonCalculate();
//UserAuthenticate();

void BonificatonCalculate()
{
    Director director = new Director("123456-XX");
    director.Name = "Fulano Silva";

    Designer designer = new Designer("8689748646-XX");
    designer.Name = "Ciclano Lima";

    AccountManager accountManager = new AccountManager("123778746-XX");
    accountManager.Name = "Beltrano Souza";

    Developer developer = new Developer("1236456-XX");
    developer.Name = "João Maria";

    Assistant assistant = new Assistant("1236456456-XX");
    assistant.Name = "Maria João";

    TotalBonification totalBonification = new TotalBonification();
    totalBonification.Register(director);
    totalBonification.Register(designer);
    totalBonification.Register(accountManager);
    totalBonification.Register(developer);
    totalBonification.Register(assistant);

    Console.WriteLine("Bonification is: " +  director.GetBonification() + " to " + director.Name);
    Console.WriteLine("Salary with Bonification is: " + (director.Salary + director.GetBonification()));
    Console.WriteLine("Bonification is: " +  designer.GetBonification() + " to " + designer.Name);
    Console.WriteLine("Salary with Bonification is: " + (designer.Salary + designer.GetBonification()));
    Console.WriteLine("Bonification is: " +  accountManager.GetBonification() + " to " + accountManager.Name);
    Console.WriteLine("Salary with Bonification is: " + (accountManager.Salary + accountManager.GetBonification()));
    Console.WriteLine("Bonification is: " +  developer.GetBonification() + " to " + developer.Name);
    Console.WriteLine("Salary with Bonification is: " + (developer.Salary + developer.GetBonification()));
    Console.WriteLine("Bonification is: " +  assistant.GetBonification() + " to " + assistant.Name);
    Console.WriteLine("Salary with Bonification is: " + (assistant.Salary + assistant.GetBonification()));
    Console.WriteLine("Total of Bonifications is: " + totalBonification.GetBonification());

}

void UserAuthenticate()
{
    InternalSystem internalSystem = new InternalSystem();

    Director director = new Director("33646");
    director.Password = "123";
    director.Name = "Fulano Silva";

    AccountManager accountManager = new AccountManager("33646-X");
    accountManager.Password = "321";
    accountManager.Name = "Beltrano Souza";

    CommercialPartner commercialPartner = new CommercialPartner();
    commercialPartner.Password = "321";
    

    internalSystem.Login(director, "123");
    internalSystem.Login(accountManager, "3211");
    internalSystem.Login(commercialPartner, "321");

}

Console.ReadLine();

