using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            // https://msdn.microsoft.com/en-us/library/ms143368(v=vs.110).aspx
            // List of all possible exceptions 
            // related to File.Readalltext()

            var path = Console.ReadLine();

            string fileContent;

            try
            {
                fileContent = File.ReadAllText(path);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            if (fileContent == null)
            {
                return;
            }

            Console.WriteLine(fileContent);
        }
    }
}
