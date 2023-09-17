using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year;
    string firstName, lastName;
    decimal salary;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    //HardCoding = Quemar código
    Console.WriteLine("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellidos completo: ");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 1234,
        FirstName = firstName,
        LastName = lastName,
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    
    };
    
    Console.WriteLine(salaryEmployee);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}







