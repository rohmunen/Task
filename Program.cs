// See https://aka.ms/new-console-template for more information
using System.Reflection;
using AreaCalculator;

Assembly myAssembly = Assembly.GetExecutingAssembly();
foreach (Type type in myAssembly.GetTypes())
{
    Console.WriteLine(type.FullName);
}
