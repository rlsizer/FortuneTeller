using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Week 1 Project
            //Ryan Sizer

            //Fortune Teller program

            //Greet user
            //Ask user for their first name
            Console.WriteLine("Greetings, earthling. Welcome to the Fortune Teller.\r\n\r\nPlease type in your first name and press enter: ");
            //Store user response in variable
            string firstName = Console.ReadLine();

            //create conditional to check if user typed 'quit'
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("\r\n\r\nNobody likes a quitter...");
                return;
            }

            //Ask user for their last name
            Console.WriteLine("\r\n\r\nOkay, " + firstName + ". Please type in your last name and press enter: ");
            //Store user response in variable
            string lastName = Console.ReadLine();

            //create conditional to check if user typed 'quit'
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("\r\n\r\nNobody likes a quitter...");
                return;
            }


            //Ask user for their age
            Console.WriteLine("\r\n\r\nMoving right along.. Please type in your age and press enter: ");
            //store user response in variable
            string userAge = Console.ReadLine().ToLower();

            //create conditional to check if user typed 'quit'
            if (userAge == "quit")
            {
                Console.WriteLine("\r\n\r\nNobody likes a quitter...");
                return;
            }

            //convert string datatype to int datatype
            int age = Convert.ToInt32(userAge);
         
            //Ask user for their birth month
            Console.WriteLine("\r\n\r\nPlease type in the number of your birth month and press enter: ");
            //Store user response in variable
            string birthMonth = Console.ReadLine().ToLower();

            //create conditional to check if user typed 'quit'
            if (birthMonth == "quit")
            {
                Console.WriteLine("\r\n\r\nNobody likes a quitter...");
                return;
            }

            //convert string to int
            int month = Convert.ToInt32(birthMonth);


            //Ask user for their favorite ROYGBIV color; if they need assistance, tell them to enter 'Help'
            Console.WriteLine("\r\n\r\nAlrighty, " + firstName + ". Please type in your favorite ROYGBIV color and press enter: \r\n(If you don't know what ROYGBIV is, please type \"Help\" and press enter)");
            //Store user response in variable
            string favColor = Console.ReadLine();

            //use switch case to determine which color user selected
            switch (favColor.ToLower())
            {
                case "red":
                    Console.WriteLine("\r\nNever wear red around a bull.");
                    break;

                case "orange":
                    Console.WriteLine("\r\nOrange like the helmets of the Cleveland Browns?");
                    break;

                case "yellow":
                    Console.WriteLine("\r\nFollow me down the yellow brick road!");
                    break;

                case "green":
                    Console.WriteLine("\r\nI am green with envy right now.");
                    break;

                case "blue":
                    Console.WriteLine("\r\nAll tangled up in blue..");
                    break;

                case "indigo":
                    Console.WriteLine("\r\nI saw the Indigo Girls at Red Rocks in '93.");
                    break;

                case "violet":
                    Console.WriteLine("\r\nViolet is really just purple in disguise.");
                    break;

                //Inserted a case for instances when the user types in 'quit'
                case "quit":
                    Console.WriteLine("\r\nNobody likes a quitter..."); 
                    return;

                default:
                    Console.WriteLine("\r\n\r\nPlease select from the following ROYGBIV colors: \r\n\r\nRed\r\nOrange\r\nYellow\r\nGreen\r\nBlue\r\nIndigo\r\nViolet\r\n\r\nPlease type in your favorite color and press enter: ");
                    //Store user response in variable
                    string favColor2 = Console.ReadLine();

                    //repeating the switch one more time in the event the user typed 'help'
                    switch (favColor2.ToLower())
                    {
                        case "red":
                            Console.WriteLine("\r\nNever wear red around a bull.");
                            break;

                        case "orange":
                            Console.WriteLine("\r\nOrange like the helmets of the Cleveland Browns?");
                            break;

                        case "yellow":
                            Console.WriteLine("\r\nFollow me down the yellow brick road!");
                            break;

                        case "green":
                            Console.WriteLine("\r\nI am green with envy right now.");
                            break;

                        case "blue":
                            Console.WriteLine("\r\nAll tangled up in blue..");
                            break;

                        case "indigo":
                            Console.WriteLine("\r\nI saw the Indigo Girls at Red Rocks in '93.");
                            break;

                        case "violet":
                            Console.WriteLine("\r\nViolet is really just purple in disguise.");
                            break;

                        //Inserted a case for instances when the user types in 'quit'
                        case "quit":
                            Console.WriteLine("\r\nNobody likes a quitter...");
                            return;

                        default:
                            Console.WriteLine("\r\n\r\nPlease select from the following ROYGBIV colors: \r\n\r\nRed\r\nOrange\r\nYellow\r\nGreen\r\nBlue\r\nIndigo\r\nViolet");
                            break;
                    }
                    break;
            }

            //Ask user for the number of siblings they have
            Console.WriteLine("\r\n\r\nPlease type in the number of siblings you have and press enter: ");
            //Store user response in variable
            string siblings = Console.ReadLine().ToLower();

            //create conditional to check if user typed 'quit'
            if (siblings == "quit")
            {
                Console.WriteLine("\r\n\r\nNobody likes a quitter...");
                return;
            }

            //convert string to int
            int numSibs = Convert.ToInt32(siblings);

            //Keep user informed
            Console.WriteLine("\r\nThank you, " + firstName + ". Now let's see your fortune..");

            //Tell user their fortune
            Console.WriteLine("\r\n\r\n" + firstName + " " + lastName + "...");

            //Create conditional to determine what happens if age is odd number or even number
            if (age % 2 == 0)
            {
                string retire1 = "You will retire in 20 years ";
                Console.Write(retire1);
            }

            else
            {
                string retire2 = "You will retire in 3 years ";
                Console.Write(retire2);
            }

            //Create conditionals to determine how much money user will have in the bank based upon their birth month
            if (month >= 1 && month <= 4)
            {
                string birth1 = "with $240 million in the bank, ";
                Console.Write(birth1);
            }

            else if (month >= 5 && month <= 8)
            {
                string birth2 = "with $2 million in the bank, ";
                Console.Write(birth2);
            }

            else if (month >= 9 && month <= 12)
            {
                string birth3 = "with $2,387.64 in the bank, ";
                Console.Write(birth3);
            }

            else
            {
                string birth0 = "with $0.00 in the bank, ";
                Console.WriteLine(birth0);
            }


            //Create conditionals to determine what vacation home user will get based upon their number of siblings
            if (numSibs == 0)
            {
                string zeroSibs = "a vacation home in North Dakota, ";
                Console.Write(zeroSibs);
            }

            else if (numSibs == 1)
            {
                string oneSib = "a vacation home in the newly renovated Flats District of Cleveland, Ohio, ";
                Console.Write(oneSib);
            }

            else if (numSibs == 2)
            {
                string twoSibs = "a vacation home on Mars, ";
                Console.Write(twoSibs);
            }

            else if (numSibs == 3)
            {
                string threeSibs = "a vacation home on the glorious Gold Coast of Australia, ";
                Console.Write(threeSibs);
            }

            else if (numSibs > 3)
            {
                string manySibs = "a vacation home in Narnia, ";
                Console.Write(manySibs);
            }

            else
            {
                string invalidSibs = "a vacation home in the seventh circle of Hell, ";
                Console.Write(invalidSibs);
            }


            //Create conditionals to determine what mode of transportation the user will have based upon their color choice
            if (favColor == "red")
            {
                string redColor = "\r\nand a yacht named Poseidon.";
                Console.WriteLine(redColor);
            }

            else if (favColor == "orange")
            {
                string orangeColor = "\r\nand a decommissioned spacecraft from NASA.";
                Console.WriteLine(orangeColor);
            }

            else if (favColor == "yellow")
            {
                string yellowColor = "\r\nand a 1986 Mazda RX-7.";
                Console.WriteLine(yellowColor);
            }

            else if (favColor == "green")
            {
                string greenColor = "\r\nand a Toyota Prius.";
                Console.WriteLine(greenColor);
            }

            else if (favColor == "blue")
            {
                string blueColor = "\r\nand a nuclear submarine.";
                Console.WriteLine(blueColor);
            }

            else if (favColor == "indigo")
            {
                string indigoColor = "\r\nand a Rolls-Royce Wraith.";
                Console.WriteLine(indigoColor);
            }

            else
            {
                string violetColor = "\r\nand a magic carpet.";
                Console.WriteLine(violetColor);
            }

        }
    }
}
