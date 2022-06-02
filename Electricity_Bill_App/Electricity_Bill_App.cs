using System;

namespace Electricity_Bill_App
{
    class Electricity_Bill_App
    {
        static void Main(string[] args)
        {
            /*In this program I am generating electricity bill with some Condition
             * Condition 1- If the unit is 0- 100 then the cost of 1 unit is 3rs per/unit
             * Condition 2 -If the unit is 101 - 300 then the cost of 1 unit is 5rs per/unit
             * Condition 3 -If the unit is 301 - 500 then the cost of 1 unit is 7rs per/unit
             * Condition 4 -If the unit is 501 and more  then the cost of 1 unit is 10rs per/unit
             * Condition 5 -If the unit is 150 then 100*3 = 300 and for 50 its 50*5 = 250 so overall bill is 550
             */

            int unit, amt;

            Console.WriteLine("Enter The Unit to generate a Electricity bill");
            unit = Convert.ToInt32(Console.ReadLine());

            if (unit >= 1 && unit <= 100)
            {
                amt = unit * 3; // Rate for first 100 unit is 3 per unit
                Console.WriteLine($"You Used {unit} Unit your bill is {amt}");
            }

            else if (unit >= 101 && unit <= 300)
            {
                amt = ((unit - 100) * 5) + 300;// Rate for first 100 unit is 3 per unit and after 100 unit is 5 per unit till 300 unit
                Console.WriteLine($"You Used {unit} Unit so your bill is {amt}");
            }

            else if (unit >= 301 && unit <= 500)
            {
                amt = ((unit - 300) * 7) + 1300;// Rate for first 100 unit is 3 per unit and after 100 unit is 5 per unit till 300 unit and after 300 unit its 7 per unit 
                Console.WriteLine($"You Used {unit} Unit so your bill is {amt}");
            }

            else if (unit >= 501)
            {
                amt = ((unit - 500) * 10) + 2700;// Rate for first 100 unit is 3 per unit and after 100 unit is 5 per unit till 300 unit and after 300 unit its 7 per unit and after 500 units its 10
                Console.WriteLine($"You Used {unit} Unit so your bill is {amt}");
            }

            Console.ReadLine();
        }
   
    }
}
