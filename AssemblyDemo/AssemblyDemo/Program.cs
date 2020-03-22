using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";
            Assembly assembly = Assembly.LoadFile(dir);
            ShowAssembly(assembly);

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(currentAssembly);

            Console.ReadLine();
        }

        public static void ShowAssembly(Assembly assembly)
        {
            //FullName , GlobalAssembly Cache , Location , and ImageRuntimeVersion properties to the console.
            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.GlobalAssemblyCache);
            Console.WriteLine(assembly.Location);
            Console.WriteLine(assembly.ImageRuntimeVersion);

            Module[] modules = assembly.GetModules();

            foreach(Module module in modules)
            {
                Console.WriteLine(module.Name);
            }
        }
    }
}
