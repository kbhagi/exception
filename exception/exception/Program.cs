using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        const string FileName = @"C:\hello.txt";
        static void Main(string[] args)
        {
            string fileContents;
            string filename = @"c:\hello.txt";

            //    fileContents = File.ReadAllText(filename);
            try
            {
                fileContents = File.ReadAllText(filename);
            }
            catch (FileNotFoundException)
            {

            }
            catch (DirectoryNotFoundException)
            {


            }
            catch (UnauthorizedAccessException)
            {

            }
            catch (Exception)
            {


            }

            try
            {
                DoSomething(filename);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
            
        }
        static void DoSomething(string filename)
        {
            try
            {
                DemonstrateNameOf(filename);
            }
            catch (FileNotFoundException exception)
            when (exception.FileName == filename)
            {


            }
        }
        static void DemonstrateNameOf(string fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));
            if (fileName == null)
                throw new ArgumentNullException("filename");
            try
            {
                string fileContents = File.ReadAllText(fileName);
                Console.WriteLine(fileContents);

            }
            catch (Exception exception)
            {
                Debug.WriteLine($"{nameof(DemonstrateNameOf)}{exception.Message}");
                throw;


            }
        }

        
    }
}
