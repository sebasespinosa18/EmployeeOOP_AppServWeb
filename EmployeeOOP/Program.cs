﻿using EmployeeOOP.Classes;

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

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 1234,
        FirstName = firstName,
        LastName = lastName,
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = 500000,
        CommissionPercentaje = 0.1F
    };

    HourlyEmployee hourlyEmployee = new HourlyEmployee() 
    {
        Id = 1234,
        FirstName = firstName,
        LastName = lastName,
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = 3,
        HoursValue = 8500
    };

    BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
    {
        Id = 1234,
        FirstName = firstName,
        LastName = lastName,
        Birthdate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Base = 25555
    };
    Console.WriteLine(salaryEmployee);
    Console.WriteLine(commissionEmployee);
    Console.WriteLine(hourlyEmployee);
    Console.WriteLine(baseCommissionEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}







