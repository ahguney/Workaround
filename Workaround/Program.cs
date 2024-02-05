using Business.Concrete;
using Entities.Concrete;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Id = 1;
        person.FirstName = "AHMET FAHRİ";
        person.LastName = "GÜNEY";
        person.DateofBirthYear = 1;
        person.NationalIdentity = 1234567890;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);

    }
    private static void Variables()
    {
        string message = "Hello";
        double price = 100000;
        int number = 100;
        bool isAuthenticate = false;

        string firstName = "Ahmet Fahri";
        string lastName = "Güney";
        long nationalIdentity = 1234567890;

        Console.WriteLine(price * 1.18);

        Console.WriteLine(price * 1.18);
    }
}