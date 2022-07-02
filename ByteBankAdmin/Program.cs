using ByteBankAdmin.Employees;
using ByteBankAdmin.Utils;

Console.WriteLine("Welcome to the ByteBank Admin");

Employee employee = new Employee();
employee.Name = "Felipe Lima";
employee.Cpf = "123456-XX";
employee.Salary = 1000;

Director director = new Director();
director.Name = "Fulano Silva";
director.Cpf = "123456-XX";
director.Salary = 2000;

BonificationManager bonificationManager = new BonificationManager();
bonificationManager.Register(employee);
bonificationManager.Register(director);

Console.WriteLine("Bonification is: " +  employee.GetBonification() + " to " + employee.Name);
Console.WriteLine("Salary with Bonification is: " + (employee.Salary + employee.GetBonification()));
Console.WriteLine("Bonification is: " +  director.GetBonification() + " to " + director.Name);
Console.WriteLine("Salary with Bonification is: " + (director.Salary + director.GetBonification()));

Console.WriteLine("Total of Bonifications is: " + bonificationManager.GetBonification());

Console.ReadLine();
