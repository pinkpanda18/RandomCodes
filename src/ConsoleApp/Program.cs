// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using System.Globalization;

Console.WriteLine("Hello, World!");

//Date
int weekNo = DateService.GetWeekNo(new CultureInfo("nn-NO"));
Console.WriteLine($"Week no : {weekNo}");