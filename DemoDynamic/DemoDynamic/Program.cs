using System;
using System.Reflection.Emit;
using System.Reflection;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "DynamicAssembly";
            assemblyName.Version = new Version("1.0");

            AppDomain appDomain = AppDomain.CurrentDomain;

            AssemblyBuilder assemblyBuilder = appDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.ReflectionOnly);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicAssembly");

            TypeBuilder typeBuilder = moduleBuilder.DefineType("Student");

            Type student = typeBuilder.CreateType();
            Console.WriteLine(student.FullName);

            MemberInfo[] memberInfos = student.GetMembers();
            foreach (MemberInfo memberInfo in memberInfos)
            {
                Console.WriteLine($"{memberInfo.MemberType} - {memberInfo.Name}");
            }

            Console.Read();
        }
    }
}
