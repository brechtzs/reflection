using System;
using System.Reflection;

namespace AssemblyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";
            
            //????????
            BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;
            Assembly assembly = Assembly.LoadFile(path);

            Console.WriteLine($"Assembly Full Name: {assembly.FullName}");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"Type Name: {type.Name}");
                MemberInfo[] members = type.GetMembers(bindingFlags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine($"Member Type of {type.Name}: {member.GetType()} and Member Name: {member.Name}");
                }
            }
            Console.ReadLine();
        }
    }
}
