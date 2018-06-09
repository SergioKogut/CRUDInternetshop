using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void GetMethod();

namespace CRUDInternetshop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            DataBaseCRUD databasereader = new DataBaseCRUD();
            try
            {
                databasereader.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();


        }
    }
}
