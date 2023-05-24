using System;
using System.IO;

namespace FolderDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\Ravi Ranjan");
            FileInfo[] f = d.GetFiles("*", SearchOption.TopDirectoryOnly);
            //FileInfo[] f = d.GetFiles("*", SearchOption.AllDirectories);
            Console.WriteLine(f.Length.ToString());
            Console.ReadLine();
        }
    }
}
