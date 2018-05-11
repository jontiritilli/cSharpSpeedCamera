using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCameraLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify the speed limit");
            var demerits = 0;
            var limit = Convert.ToInt32(Console.ReadLine());
            while (demerits < 12)
            {
                Console.WriteLine(string.Format("The speed limit is set to {0}. Enter your vehicle speed so we know if you're speeding...", limit));
                Console.Write("Speed: ");
                var vehicleSpeed = Convert.ToInt32(Console.ReadLine());

                if (vehicleSpeed > limit)
                {
                    var excess = vehicleSpeed - limit;
                    demerits += excess / 5;
                    Console.WriteLine(string.Format("You're going too fast, the speed limit is {0}, and you are going {1}. That's {2} over the limit and I've assessed {3} demerits on your record!", limit, vehicleSpeed, excess, demerits));
                }
                else
                {
                    var shortage = limit - vehicleSpeed;
                    Console.WriteLine(string.Format("You're driving safely under the speed limit of {0}, and you are going {1}. That's {2} under the limit", limit, vehicleSpeed, shortage));
                }
            }
            if (demerits > 12)
            {
                Console.WriteLine(string.Format("License has been suspended. You had {0} demerits on your record!", demerits));
                Console.ReadLine();
            }
        }
    }
}
