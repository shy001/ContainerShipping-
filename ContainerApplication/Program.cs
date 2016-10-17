using ContainerSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileInput = System.IO.File.ReadAllText(@"C:\ContainerFile\ContainerInput.txt");
            string result = new ArrangeContainers().ReadContainerFile(fileInput);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
