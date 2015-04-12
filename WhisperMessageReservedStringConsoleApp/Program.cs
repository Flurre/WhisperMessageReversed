using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessageReversedStringCLib;

namespace WhisperMessageReservedStringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWhisperMessageReversedString _whisperString = new ReversedString();

                Console.WriteLine("Please enter a message: ");
                string message = Console.ReadLine();
                var result = _whisperString.WhisperReversedString(message);
                Console.WriteLine("Entered message: {0} \nManipulated message: {1}", message, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            

            


        }
    }
}
