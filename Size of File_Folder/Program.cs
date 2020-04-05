using System;
using System.IO;

namespace Size_of_File_Folder
{

    class Program
    {
        
        static void Main(string[] args)
        {
          string[] a=  Directory.GetFiles(@"C:\POB\Size of File_Folder\Size of File_Folder","TextFile1.txt");
            string FileName = a[0];
            FileInfo fi = new FileInfo(FileName);
            long sizeb = fi.Length;
            
            Console.WriteLine("Dimensiunea in bytes:{0}", sizeb);
            Console.WriteLine("Dimensiunea pe disk:{0}", a);

        }
    }
}
