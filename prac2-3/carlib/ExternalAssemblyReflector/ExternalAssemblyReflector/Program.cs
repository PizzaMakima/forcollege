﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO; 
namespace ExternalAssemblyReflector
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("\n***** Типы в сборке *****");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types) Console.WriteLine("Type: {0}", t);
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Просмотр внешней сборки *****");
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("\nВведите сборку для оценки");
                Console.Write("или Q для выхода: ");
                asmName = Console.ReadLine();
                if (asmName.ToUpper() == "Q")
                {
                    break;
                }
                try
                {
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can’t find assembly.");
                }
            } while (true);
        }
    }
}

