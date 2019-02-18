using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\rawliito\Desktop\Exampl.txt");
                Console.WriteLine(content);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Make sure the file is named correctly");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Make sure the directory is spelled correctly");
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Closing app now... ");
            }
            Console.ReadLine();

        }
    }
}
