using System;
using System.Linq;
using System.Reflection;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0]; //"C:\\Users\\Пользователь\\RiderProjects\\lab5\\lab5Ex\\bin\\Debug\\net5.0\\lab5Ex.dll";                                               //Assembly.GetExecutingAssembly().Location;
            
            Assembly.LoadFrom(path).GetTypes()
                .Where(type => type.IsPublic)
                .OrderBy(type => type.FullName)
                .ToList()
                .ForEach(type => Console.WriteLine(type.FullName));
        }
    }
}



