using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;

class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Index: {Index}, Country: {Country}, City: {City}, Street: {Street}, House: {House}, Apartment: {Apartment}");
    }
}

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUsd(double amount)
    {
        return amount / usd;
    }

    public double ConvertToEur(double amount)
    {
        return amount / eur;
    }

    public double ConvertToPln(double amount)
    {
        return amount / pln;
    }

    public double ConvertFromUsd(double amount)
    {
        return amount * usd;
    }

    public double ConvertFromEur(double amount)
    {
        return amount * eur;
    }

    public double ConvertFromPln(double amount)
    {
        return amount * pln;
    }
}

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        double baseSalary = 1000; // Базовий оклад
        if (position == "manager")
        {
            baseSalary += 500; // Додатковий оклад для менеджера
        }
        else if (position == "developer")
        {
            baseSalary += 1000; // Додатковий оклад для розробника
        }
        // Розрахунок окладу з урахуванням стажу
        double totalSalary = baseSalary + experience * 100;
        // Податок 18%
        double tax = totalSalary * 0.18;
        double netSalary = totalSalary - tax;
        return netSalary;
    }

    public void DisplayEmployeeInfo(string position, int experience)
    {
        double salary = CalculateSalary(position, experience);
        Console.WriteLine("Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary} UAH");
    }
}

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("User Information:");
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу Address
        Address myAddress = new Address("12345", "Ukraine", "Kyiv", "Main Street", "10A", "25");
        Console.WriteLine("Address:");
        myAddress.DisplayAddress();

        // Приклад використання класу Converter
        Converter myConverter = new Converter(27.5, 32.0, 6.5);
        double amountInUah = 1000;
        double amountInUsd = myConverter.ConvertToUsd(amountInUah);
        Console.WriteLine($"{amountInUah} UAH is approximately {amountInUsd} USD");

        // Приклад використання класу Employee
        Employee employee1 = new Employee("Doe", "John");
        string position = "developer";
        int experience = 5;
        employee1.DisplayEmployeeInfo(position, experience);

        // Приклад використання класу User
        User user1 = new User("user123", "John", "Doe", 30);
        user1.DisplayUserInfo();
    }
}