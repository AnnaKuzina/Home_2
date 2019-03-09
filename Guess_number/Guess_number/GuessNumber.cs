using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_number
{
    public class GuessNumber
    {
        public int RandomNumber()
        {
            Random x = new Random();
            int randon_number = x.Next(10);
            return randon_number;
        }

        public void EnterNumber()
        {
            int randon_number = RandomNumber();
            Console.WriteLine("Please enter number betweeen 0 and 9: ");
            while (true)
            {
                int enter_number = Convert.ToInt32(Console.ReadLine());
                if (randon_number == enter_number)
                {
                    Console.WriteLine("You win, game over");
                    break;
                }
                else if (randon_number > enter_number)
                {
                    Console.WriteLine("Random number greater than entered");
                }
                else
                {
                    Console.WriteLine("Random number less than entered");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            GuessNumber gn = new GuessNumber();
            gn.EnterNumber();
        }
    }
}
