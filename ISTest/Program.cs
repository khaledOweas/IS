using ISDAL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InnovationDAL DAL = new InnovationDAL();
            var allInvo = DAL.GetAll(); 
            Console.ReadKey();



            //Console.WriteLine("Press Any Key To Continue ");
            //Console.ReadKey();
            //Console.WriteLine("Write Your Name :  ");
            //var name = Console.ReadLine();

            //Console.WriteLine( "Your Name Is :  >> > > > > " + name);
            //Console.ReadKey();

        }
    }
}
