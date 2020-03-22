using System;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type type = Type.GetType("System.Reflection.AssemblyDescriptionAttribute");
            object[] attributes = currentAssembly.GetCustomAttributes(type, false);

            if (attributes.Length > 0)
            {
                AssemblyDescriptionAttribute attribute = (AssemblyDescriptionAttribute)attributes[0];
                Console.WriteLine(attribute.Description);
                Console.ReadLine();
            }
        }
    }
}
