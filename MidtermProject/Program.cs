using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SandwichOrder> LstSandwichOrders = new List<SandwichOrder>();
            List<Sandwiches> LstSandwiches = new List<Sandwiches>();
            LstSandwiches.Add(new Sandwiches(1, "OOHH Sooo Meaty", 5.99, "Roast Beef", "extatoppings", 1500));
            LstSandwiches.Add(new Sandwiches(2, "The Jenny", 6.88, "avocado with Roasted Peppers", "extratoppings", 1000));
            LstSandwiches.Add(new Sandwiches(3, "the quany", 20.99, "wagyu beef", "extratoppings", 6000));
            LstSandwiches.Add(new Sandwiches(4, "The Saigon Special", 12.99, "Roasted Pork", "extratoppings", 6000));
            LstSandwiches.Add(new Sandwiches(5, "The Big Country", 14.88, "Pork Chop", "extraToppings", 4500));
            LstSandwiches.Add(new Sandwiches(6, "The Yum Yum", 16.67, "Fried Chicken", "extra Toppings", 3500));
            LstSandwiches.Add(new Sandwiches(7, "Steak on Steak and Cheeze", 13.65, "Rib EYE STEAK", "extra toppings", 3750));
            LstSandwiches.Add(new Sandwiches(8, "Not Yo Mommas BlT", 20.44, "BACON", "extratoppings", 2355));
            LstSandwiches.Add(new Sandwiches(9, "Da Count", 32.34, "Monte Cristo", "extratoppings", 4500));
            LstSandwiches.Add(new Sandwiches(10, "Da Wuhuan Special", 4.59, "Pangolins", "extratoppings", 2000));

            double subtotal = 0;
            string userName;
            int numberSelection;
            int passwordCorrect = 1234;
           


            WriteLine("*******WELCOME TO WE GOT THE MEATZ SANDWICH SHOP****\n");
            WriteLine("Are you an employee or a customer \n1. Employee \n2. Customer");
            int empOrcustomer = Convert.ToInt32(ReadLine());


            if (empOrcustomer == 1)
            {

                WriteLine("Please enter your user name:");
                userName = ReadLine();
             

                for (int i = 0; i < 3; i++)
                {
                    WriteLine("Please enter your password");
                    int password = Convert.ToInt32(ReadLine());

                    if(password== passwordCorrect)
                    {
                        break;
                    }

                    if(password != passwordCorrect)
                    {
                       
                        if(i==2)
                        {
                            Environment.Exit(0);
                        }
                          

                    }



                
                    

                }

                    foreach (Sandwiches co in LstSandwiches)
                WriteLine($"{co.number}\t{co.namo}\t{co.costo}\t{co.meatType}\t{co.toppins}\t{co.cals}");
                WriteLine("How many sandwiches would you like to modify?");
                        numberSelection = Convert.ToInt32(ReadLine());


                        for (int x = 0; x < numberSelection; x++)
                        {
                            WriteLine("Please enter the number of the sandwich you would like to modify");
                            numberSelection = Convert.ToInt32(ReadLine());
                            Sandwiches selected = LstSandwiches[numberSelection - 1];
                            WriteLine($"{selected.number}\t{selected.namo}\t{selected.costo}\t{selected.meatType}\t{selected.cals}");
                            WriteLine("What  is the new sandwich number?");
                            int NumSand = Convert.ToInt32(ReadLine());
                            WriteLine("what would you like the Name to be changed to?");
                            string newName = ReadLine();
                            WriteLine("What is the price of the sandwich?");
                            double price1 = Convert.ToInt32(ReadLine());
                            WriteLine("What type of meat does the sanwich have?");
                            string newMeat = ReadLine();
                            WriteLine("How many calories does this sandwich have?");
                            int Kalos = Convert.ToInt32(ReadLine());
                            WriteLine("Any additional toppings?");
                            string Toppys2 = ReadLine();

                            LstSandwichOrders.Add(new SandwichOrder(NumSand, newName, price1, newMeat, Toppys2, Kalos));
                        }

                        foreach (SandwichOrder eerr in LstSandwichOrders)
                            WriteLine($"{eerr.numero}\t{eerr.nombre}\t{eerr.cuanto}\t{eerr.carne}\t{eerr.toppingz}\t{eerr.calorias} ");
                  


                
            }


            else if (empOrcustomer == 2) //customer
            {
                WriteLine(LstSandwiches.Count);

                foreach (Sandwiches co in LstSandwiches)
                    WriteLine($"{co.number}\t{co.namo}\t{co.costo}\t{co.meatType}\t{co.toppins}\t{co.cals}");

                WriteLine("How many sandwiches would you like to order?");
                int sandwichcont = Convert.ToInt32(ReadLine());

                for (int y = 0; y < sandwichcont; ++y)
                {
                    WriteLine("which sandwich number would you like?");
                    numberSelection = Convert.ToInt32(ReadLine());
                    Sandwiches selected = LstSandwiches[numberSelection - 1];
                    WriteLine($"{selected.number}\t{selected.namo}\t{selected.costo}\t{selected.meatType}\t{selected.cals}");
                    subtotal = subtotal + selected.costo;

                    LstSandwichOrders.Add(new SandwichOrder(selected.number, selected.namo, selected.costo, selected.meatType, selected.toppins, selected.cals));

                }

             WriteLine("Here is your order:");

             foreach (SandwichOrder cdf in LstSandwichOrders)
                WriteLine($"{cdf.numero}\t{cdf.nombre}\t{cdf.cuanto}\t{cdf.carne}\t{cdf.toppingz}\t{cdf.calorias}");

             WriteLine($"your subtotal is {subtotal}");
             double taxes = subtotal * .055;
             WriteLine($"your tax is {taxes}");
             double Grandtotal = taxes + subtotal;
             WriteLine($"your grandtotal is {Grandtotal}");

            }







            ReadKey();
        }
    }
}

    

