using ByteBankAdmin.Employees;

Console.WriteLine("Welcome to the ByteBank Admin");

Employee employee = new Employee();
employee.Name = "Felipe Lima";
employee.Cpf = "123456-XX";
employee.Salary = 54545.5;


Console.WriteLine("Bonification is: " +  employee.GetBonification());
Console.WriteLine("Salary with Bonification is: " + (employee.Salary + employee.GetBonification()));
Console.ReadLine();