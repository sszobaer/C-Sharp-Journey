using System.IO;
using System.Runtime.InteropServices;
namespace Files
{
    class Program
    {
        static void Main(string[]args)
        {
            string fpath1 = @"D:\Zobaer's Info.txt";
            string fpath2 = @"D:\Nayeem's Info.txt";

            //Create a file
            using (File.Create(fpath1)) { };
            using (File.Create(fpath2)) { };

            string Condition1 = (File.Exists(fpath1)) ? "File Created Successfully" : "Access denied";
            Console.Write(Condition1);

            string Condition2 = (File.Exists(fpath2)) ? "\nFile Created Successfully" : "\nAccess denied";
            Console.Write(Condition2);

            //Directory / Folder
            string dpath = @"D:\Zobaer's All Information";
            Directory.CreateDirectory(dpath);

            string condition3 = (Directory.Exists(dpath)) ? "\nFolder created successfully" : "\nAccess denied";
            Console.Write(condition3);

            string[] infoZobaer = new string[]
            {
                "Name: S. S. Zobaer Ahmed",
                "Id : 22-49415-3",
                "CGPA: 3.78"
            };
            string[] infoNayeem = new string[]
            {
                "Name: Najmul Hassan Nayeem",
                "Id: 22-5749-2",
                "CGPA: 3.90"
            };
            //Write
            File.WriteAllLines(fpath1, infoZobaer);
            File.WriteAllLines (fpath2, infoNayeem);

            //Append Write
            File.AppendAllText(fpath1, "Department: BSc CSE");
            File.AppendAllText(fpath2, "Department: BSc CSE");

            //Read
            string[] fileContent = File.ReadAllLines(fpath1);
            foreach (string Contents in fileContent)
            {
                Console.WriteLine("\n"+Contents);
            }

        }
    }
}
