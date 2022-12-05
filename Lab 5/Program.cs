using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Displaymenu();
        }

        private static void Displaymenu()
        {
            {
                Console.WriteLine("MENU");
                Console.WriteLine("----");
                Console.WriteLine(" ");
                Console.WriteLine("A - Convert Pounds To Kilograms");
                Console.WriteLine("B - Convert Miles To Kilometers");
                Console.WriteLine(" ");
                Console.WriteLine("-> Press X To Exit The Application");
                Console.WriteLine(" ");

                

                while (true)
                {
                    char input;
                    Console.Write("Enter The Letter That Corresponds To Your Choice: ");
                    input = Char.Parse(Console.ReadLine());

                    if (input == 'A')
                    {
                        OptionA();
                    }

                    else

                    if (input == 'B')
                    {
                        OptionB();
                    }

                    else

                    if (input == 'X')
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                
                   
                    



                }

            }
        }

        static void OptionA()
        {
            Console.WriteLine("Pounds      Kilograms");
            Console.WriteLine("---------------------");

            for (int pounds = 200; pounds >= 50; pounds -= 5)
            {
                double kg = PoundsToKilograms(pounds);
                Console.WriteLine($"{pounds,6:F2}      {kg:F2}");


            }
            Console.WriteLine(" ");
        }
        static double PoundsToKilograms(double pounds)
        {
            double kg = pounds * 0.45;
            return kg; 
        }

        static void OptionB()
        {
            Console.WriteLine("Miles     Kilometers");
            Console.WriteLine("--------------------");

            for(int miles=10; miles<=100; miles +=100)
            {
                double km;
                MilesToKilometers(miles, out km);
                Console.WriteLine($"{miles:F2}     {km}");
            }
        }


        static void MilesToKilometers(double miles, out double km)
        {
            km = miles * 1.61;
            
        }

    }



    
   






}
