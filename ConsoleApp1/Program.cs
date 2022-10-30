using RestShar_Sample.Interfaces.Services;
using RestShar_Sample.Interfaces;
using RestShar_Sample.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var restManageMent = new RestSharpManagement("https://localhost:44367");
            restManageMent.PostAsync<Person>(new Person
           {
               DateOfBirth = "1400/02/01",
               Family = "Davoody",
               Name = "Soheil"
           });
        }
    }
}
