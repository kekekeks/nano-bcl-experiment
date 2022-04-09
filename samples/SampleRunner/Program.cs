using System;
using System.Reflection;
using SampleLib;
namespace SampleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum:" + TestClass.Sum("1", "2"));
        }
    }
}