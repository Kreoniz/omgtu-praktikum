using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("core.dll");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"Class: {type.Name}");
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($"\tMethod: {method.Name}");
                    Console.WriteLine($"\t\tReturn type: {method.ReturnType.Name}");
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine($"\t\t\tParameter: {parameter.Name} ({parameter.ParameterType.Name})");
                    }
                }
            }
        }
    }
}