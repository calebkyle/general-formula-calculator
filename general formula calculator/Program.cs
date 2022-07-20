using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general_formula_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("General formula calculator version 0.0.1");


            int a, b, c;
            Double root1, root2, d;

            Console.WriteLine("\nTo calculate the roots of the equation using General formula please imput the required parameters");
           
            Console.WriteLine("\n Input value of a ");
            
            a = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("\n Input value of b ");
            b= Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("\n Input value of c ");
            c = Convert.ToInt32(Console.In.ReadLine());


            //formula is x=(-b(+/-)root of (b*b-4*a*c)/(2a)), too complex
            //replace (b*b-4*a*c) with another variable d to make it x=(-b(+/-)root of (d)/(2a))


            d = b * b - 4 * a * c;

            if (d > 0)
            {
                // the roots are in this case not equal 

                root1 = (-b + Math.Sqrt(d)) / 2 * a;
                root2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.Write("\nThe root1 = {0}\n", root1);

                Console.Write("\nThe root2 = {0}\n", root2);
            }

            else if (d == 0)
            {
                //the roots will be equal

                root1 = -b + 0;
                root2 = root1;

                Console.Write("\nThe root1 ={0}\n ", root1);
                Console.Write("\nThe root2 ={0}\n ", root2);
            }


            else
                
                Console.WriteLine("oops No solution! Please check that yopur parameters are correct.");

            Console.WriteLine("Do you want to try again[Y or N].");
            string answer = Console.ReadLine().ToUpper();




            while (answer == "Y" )// answer == "N")
            {

                

                Console.WriteLine("\nTo calculate the roots of the equation using General formula please imput the required parameters");

                Console.WriteLine("\n Input value of a ");
                a = Convert.ToInt32(Console.In.ReadLine());

                Console.WriteLine("\n Input value of b ");
                b = Convert.ToInt32(Console.In.ReadLine());

                Console.WriteLine("\n Input value of c ");
                c = Convert.ToInt32(Console.In.ReadLine());


                //formula is x=(-b(+/-)root of (b*b-4*a*c)/(2a)), too complex
                //replace (b*b-4*a*c) with another variable d to make it x=(-b(+/-)root of (d)/(2a))


                d = b * b - 4 * a * c;

                if (d > 0)
                {
                    // the roots are in this case not equal 

                    root1 = (-b + Math.Sqrt(d)) / 2 * a;
                    root2 = (-b - Math.Sqrt(d)) / 2 * a;

                    Console.Write("\nThe root1 = {0}\n", root1);

                    Console.Write("\nThe root2 = {0}\n", root2);
                }

                else if (d == 0)
                {
                    //the roots will be equal

                    root1 = -b + 0;
                    root2 = root1;

                    Console.Write("\nThe root1 ={0}\n ", root1);
                    Console.Write("\nThe root2 ={0}\n ", root2);
                }


                else

                    Console.WriteLine("oops No solution! Please check that yopur parameters are correct.");

                Console.WriteLine("Do you want to try again[Y or N].");
                 Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }






                while (answer == "N")
                {


                    if (answer == "N")
                    {
                        return;
                    }
                    else if (answer == "N")
                    {
                        continue;
                    }
                }
            }
           


            Console.ReadKey();
        }
    }
}
