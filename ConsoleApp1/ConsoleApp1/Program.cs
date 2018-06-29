using System;
using System.IO;
using TestUnit;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int variant;
            Console.WriteLine("Choose variant:\n 1) Empty Launch;\n 2) Release Launch");
            try
            {
                variant = int.Parse(Console.ReadLine());
                if (variant == 1)
                {
                    Loader.Load();
                    Console.ReadLine();
                }
                else if (variant == 2)
                {
                    string Url = @"https://www.postjobfree.com/job/dpf2mj/telecommute-developer-ok-java-manila-ncr";
                    string FileName = "index.html";
                    string Directory = @"C:\Users\Comp\source\repos\ConsoleApp1\ConsoleApp1\";
                    Console.Clear();
                    Loader.Load(Url, FileName, Directory);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Choose the existing variant!");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
