// See https://aka.ms/new-console-template for more information
using RestShar_Sample.Interfaces;
using RestShar_Sample.Interfaces.Services;
using RestShar_Sample.Models;

Console.WriteLine("Hello, World!");
IRestSharpManagement restManageMent = new RestSharpManagement();
restManageMent.GetMethod<Person, string>("this is test","https://localhost:44323/api/patient/GetAllPatientAsync");