﻿using System;

namespace MemeberShipProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------CONTAINER FOR MENU CHOICE VARIABLES-----------------------\\
            bool bMenuChoice = false;
            string? menuChoiceString;

            bool menuTypeChoice = false;
            string? menuTypeChoiceSt;

            bool transactionChoice = false;
            string? transactionChoiceSt;


            //-----------------CONTAINER FOR MENU CHOICE VARIABLES-----------------------\\


            //-----------------CONTAINER FOR LIST VARIABLES------------------------------\\
            List<RegularMember> regMemList = new List<RegularMember>();

            //regMemList.Add(new RegularMember("485454", "TEST.Email@email.com", "Regular", 7775, .2, .25)); //Annual Fee is .25 and cashback is .2
           // regMemList.Add(new RegularMember("485445", "TEST.Email@email.com", "Regular", 7456, .2, .25));


            //-----------------CONTAINER FOR LIST VARIABLES------------------------------\\



            //-----------------START MAIN MENU----------------------\\
            do
            {
                Console.WriteLine("Please make a selection for the menu tha you would like to use");
                Console.WriteLine("A: Administrative menu to make chases and look at members");
                Console.WriteLine("T: Transactional menu");



                menuTypeChoiceSt = Console.ReadLine();

                menuTypeChoice = (menuTypeChoiceSt == "A" || menuTypeChoiceSt == "a" ||
                menuTypeChoiceSt == "T" || menuTypeChoiceSt == "t");


                if (!menuTypeChoice)
                {
                    Console.WriteLine("Invalid selection, please enter a valid character");

                }
                else
                {
                    Console.WriteLine("Moving to Selected menu");

                }


            } while (!menuTypeChoice);
            //----------------------------------- END OF MAIN MENU--------------------------------------------\\

            if (menuTypeChoiceSt == "T" || menuTypeChoiceSt == "t")
            {

                do
                {

                    do
                    {
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Welcome to the transactional menu! Please select one of the options");
                        Console.WriteLine("L: List all the memberships");
                        Console.WriteLine("P: Preform a purchase ");
                        Console.WriteLine("T: Return a transaction for refund");
                        Console.WriteLine("A: Apply cash back rewards");
                        Console.WriteLine("Q: quit this menu and return to main menu");

                        transactionChoiceSt = Console.ReadLine();

                        transactionChoice = (transactionChoiceSt == "L" || transactionChoiceSt == "l" ||
                        transactionChoiceSt == "P" || transactionChoiceSt == "p" ||
                        transactionChoiceSt == "T" || transactionChoiceSt == "t" ||
                        transactionChoiceSt == "A" || transactionChoiceSt == "a" ||
                        transactionChoiceSt == "Q" || transactionChoiceSt == "q");

                        if (!transactionChoice)
                        {
                            Console.WriteLine("Invalid selection! Please enter a valid character");
                        }

                    } while (!transactionChoice);

                    if (menuTypeChoiceSt == "L" || menuTypeChoiceSt == "l")
                    {
                        foreach (RegularMember aMember in regMemList)
                        {
                            Console.WriteLine(aMember);
                        }
                    }
                    if (menuTypeChoiceSt == "P" || menuTypeChoiceSt == "p")
                    {
                        // pruchase transaction
                    }
                    if (menuTypeChoiceSt == "T" || menuTypeChoiceSt == "t")
                    {
                        // return transaction
                    }
                    if (menuTypeChoiceSt == "A" || menuTypeChoiceSt == "a")
                    {
                        // apply cashback rewards
                    }
                    else
                    {
                        Console.WriteLine("Exiting program");
                    }

                } while (!(transactionChoiceSt == "Q") && !(transactionChoiceSt == "q"));

                //----------------------------------- END OF TRANSACTION MENU --------------------------------------------\\

            }

            //----------------------------------- END OF TRANSACTION MENU IF STATMENT --------------------------------------------\\

            if (menuTypeChoiceSt == "A" || menuTypeChoiceSt == "a")
            {
                do
                {
                    do
                    {

                        Console.WriteLine("C: Create a new membership");
                        Console.WriteLine("R: Read the list of members and displays them");
                        Console.WriteLine("U: Update the information on a member");
                        Console.WriteLine("D: Delete a member from the list");
                        Console.WriteLine("Q: Quit this menu and return to main menu");

                        menuChoiceString = Console.ReadLine();

                        bMenuChoice = (menuChoiceString == "C" || menuChoiceString == "c" ||
                        menuChoiceString == "R" || menuChoiceString == "r" ||
                        menuChoiceString == "U" || menuChoiceString == "u" ||
                        menuChoiceString == "D" || menuChoiceString == "d" ||
                        menuChoiceString == "Q" || menuChoiceString == "q");

                        if (!bMenuChoice)
                        {
                            Console.WriteLine("Invalid selection please enter valid character");
                        }

                    } while (!bMenuChoice);

                    if (menuChoiceString == "C" || menuChoiceString == "c")
                    {
                        // C logic
                    }
                    if (menuChoiceString == "R" || menuChoiceString == "r")
                    {
                        foreach (RegularMember aMember in regMemList)
                        {
                            Console.WriteLine(aMember);
                        }
                        Console.ReadKey();
                    }
                    if (menuChoiceString == "U" || menuChoiceString == "u")
                    {
                        // U logic
                    }
                    if (menuChoiceString == "D" || menuChoiceString == "d")
                    {
                        // D logic
                    }
                    else
                    {
                        Console.Write("Returning to main menu");
                    }


                } while (!(menuChoiceString == "Q") && !(menuChoiceString == "q"));

                //----------------------------------- END OF ADMINISTRATION MENU --------------------------------------------\\


            }
            //----------------------------------- END OF ADMINISTRATION MENU IF STATMENT --------------------------------------------\\


        }// end of main 

    }// end of program

}//end of Namespace 