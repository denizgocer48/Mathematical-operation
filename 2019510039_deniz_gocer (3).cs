using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019510039_deniz_gocer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please select one from * or /");
            string symbol = Convert.ToString(Console.ReadLine());

            do
            {
                if (symbol == "/" || symbol == "*")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please select * or /");
                    symbol = Convert.ToString(Console.ReadLine());
                }
            } while (symbol != "/" && symbol != "*");


            Console.WriteLine("Please enter x between 0 and 25");
            string x = Convert.ToString(Console.ReadLine());
            do
            {
                if (x == "0" || x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9" ||
                    x == "10" || x == "11" || x == "12" || x == "13" || x == "14" || x == "15" || x == "16" || x == "17" || x == "18" ||
                    x == "19" || x == "20" || x == "21" || x == "22" || x == "23" || x == "24" || x == "25")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter x between 0 and 25");
                    x = Convert.ToString(Console.ReadLine());
                }
            } while (x != "0" || x != "1" || x != "2" || x != "3" || x != "4" || x != "5" || x != "6" || x != "7" || x != "8" || x != "9" ||
                    x != "10" || x != "11" || x != "12" || x != "13" || x != "14" || x != "15" || x != "16" || x != "17" || x != "18" ||
                    x != "19" || x != "20" || x != "21" || x != "22" || x != "23" || x != "24" || x != "25");
            

            int xi = Convert.ToInt32(x);
            double final_result = 0;
            int denominator_starting_number = 2;

            for (int i = 0; i < 30; i++)
            {
                double result_of_denominator = 0;
                

                for (int j = 0; j <= i + 1; j++)
                {
                    int denominator_power = 2 + i;
                    int denominator_number = denominator_starting_number + j * 2;
                    double taking_power_of_denominator = 1;
                    for (int m = 1; m <= denominator_power; m++)
                    {
                        taking_power_of_denominator = taking_power_of_denominator * denominator_number;
                       
                    }
                    result_of_denominator += taking_power_of_denominator;
                }
                denominator_starting_number = denominator_starting_number + 2;

                int number_of_factorial = 4 + i * 2;
                double factorial = 1;
                for (int k = number_of_factorial; k > 0; k--)
                {
                    factorial = factorial * k;
                }

                int power_of_x = 2 + i * 3;

                int coefficient_of_x = 3 + i * 4;

                double taking_power_of_x = 1;
                for (int m = 1; m <= power_of_x; m++)
                {
                    taking_power_of_x *= xi;
                }

                double result_of_x = taking_power_of_x * coefficient_of_x;

                int number = 2 + i * 5;

                double result_of_numerator;
                
                if (symbol == "/")
                {
                    if (factorial < result_of_x)
                    {
                        result_of_numerator = factorial / number;
                    }
                    else
                    {
                        result_of_numerator = result_of_x / number;
                    }
                }
                else
                {
                    if (factorial < result_of_x)
                    {
                        result_of_numerator = factorial * number;
                    }
                    else
                    {
                        result_of_numerator = result_of_x * number;
                    }

                }
                double result_of_digit = result_of_numerator / result_of_denominator;
                if (i % 2 == 1 )
                {
                    final_result = final_result - result_of_digit;
                }
                else
                {
                    final_result = final_result + result_of_digit;
                }
            }

            Console.WriteLine(final_result);
            Console.ReadLine();

        }
    }
}
