using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//create a class with a function in it. when called console freezes until user presses a key
namespace week_4_sample_1
{
    public class BasicTools
    {
        public static void Pause()
        {
            Console.WriteLine("\nPress Any Key to Continue\n");
            Console.ReadKey();
        }
    }
}
