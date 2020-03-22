using System;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll";
            Assembly assembly = Assembly.LoadFile(path);

            Type type = assembly.GetType("System.Web.HttpUtility");
            
            //????????? 2nd paramether - new Type object
            MethodInfo encode = type.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo decode = type.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            string stringToBeEncoded = "fsdhdfgdjhsfgdjhsfgk 77 && <>";
            Console.WriteLine(stringToBeEncoded);

            string encodedString = (string)encode.Invoke(null, new object[] { stringToBeEncoded });
            Console.WriteLine(encodedString);

            string decodedString = (string)decode.Invoke(null, new object[] { encodedString });
            Console.WriteLine(decodedString);

            Console.ReadLine();

            
        }
    }
}
