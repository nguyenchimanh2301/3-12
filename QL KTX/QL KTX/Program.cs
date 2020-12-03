using System;
using System.Text;
using QL_KTX.Presentation;

namespace QL_KTX
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FormMENU menu = new FormMENU();
            menu.start();
            Console.ReadKey();
        }
    }
}
