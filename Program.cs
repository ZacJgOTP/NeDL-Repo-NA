using System;
using System.Collections.Generic;

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

            List<MemberShip> MemList = new List<MemberShip>();
            MemList.Add(new RegularMember("481", "TEST.Email@email.com", "Regular", 7775));
            MemList.Add(new ExecutiveMember("454", "TEST.Email@email.com", "Executive", 45576, 1));
            MemList.Add(new NonProfMember("458", "TEST.Email@email.com", "NonProf", 45576, "Military"));
            MemList.Add(new NonProfMember("448", "TEST.Email@email.com", "NonProf", 45576, "Education"));
            MemList.Add(new CorperateMember("324", "TEST.Email@email.com", "Corp", 7247));

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

            //----------------------START OF TRANSACTION MENU----------------------------\\
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
                            Console.WriteLine("Invalid selection! Please enter a valid character. Please press any key to coninue");
                            Console.ReadKey();
                        }

                    } while (!transactionChoice);
                    //----------------------END OF TRANSACTION MENU----------------------------\\

                    //----------------------START OF L MENU----------------------------\\
                    if (transactionChoiceSt == "L" || transactionChoiceSt == "l")
                    {
                        foreach (MemberShip m in MemList)
                        {
                            Console.WriteLine(m);
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    //----------------------END OF L MENU----------------------------\\

                    //----------------------START OF P MENU----------------------------\\
                    if (transactionChoiceSt == "P" || transactionChoiceSt == "p")
                    {
                        string? idCheck;
                        bool found = false;
                        Console.WriteLine("Please enter the member ID to find the account");
                        idCheck = Console.ReadLine();

                        for (int index = 0; index < MemList.Count; index++)
                        {
                            if ((MemList[index].PBmembershipID == idCheck))
                            {
                                Console.WriteLine("Please enter the total of the transaction");
                                double transactionAmmount = Convert.ToDouble(Console.ReadLine());

                                double AmmountMonth = MemList[index].PBammountThisMonth;
                                MemList[index].PBammountThisMonth = MemberShip.purchase(transactionAmmount, AmmountMonth);

                                found = true;
                            }

                        }  // end foreach  

                        if (found)
                            Console.WriteLine("Purchase successfull!");
                        else
                            Console.WriteLine("Purchase failed, please try again.");

                    }
                    //----------------------END OF P MENU----------------------------\\

                    //----------------------START OF T MENU----------------------------\\
                    if (menuTypeChoiceSt == "T" || menuTypeChoiceSt == "t")
                    {
                        string? idCheck;
                        bool found = false;
                        Console.WriteLine("Please enter the member ID to find the account");
                        idCheck = Console.ReadLine();

                        for (int index = 0; index < MemList.Count; index++)
                        {
                            if ((MemList[index].PBmembershipID == idCheck))
                            {
                                Console.WriteLine("Please enter the total of the transaction");
                                double transactionAmmount = Convert.ToDouble(Console.ReadLine());

                                double AmmountMonth = MemList[index].PBammountThisMonth;
                                MemList[index].PBammountThisMonth = MemberShip.returns(transactionAmmount, AmmountMonth);


                                found = true;
                            }
                        }  
                        
                        if (found)
                            Console.WriteLine("Return successfull!");
                        else
                        {
                            Console.WriteLine("Return Failed Please try again");
                            Console.WriteLine("Please enter member Id");
                            idCheck = Console.ReadLine();
                        }

                    }

                    //----------------------END OF T MENU----------------------------\\


                    //----------------------START OF A MENU----------------------------\\
                    if (menuTypeChoiceSt == "A" || menuTypeChoiceSt == "a")
                    {
                        string? idCheck;
                        Console.WriteLine("Please enter the member ID to find the account");
                        idCheck = Console.ReadLine();

                        for (int index = 0; index < MemList.Count; index++)
                        {
                            if ((MemList[index].PBmembershipID == idCheck))
                            {
                                double cashBackApp = MemList[index].cashbackreg();
                                Console.WriteLine("Cash-back reward request for membership" + MemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                            }

                            else if ((MemList[index].PBmembershipID == idCheck))
                            {
                                if (MemList[index].PBtier == 1)
                                {
                                    double cashBackApp = MemList[index].cashbackregteir1();
                                    Console.WriteLine("Cash-back reward request for membership" + MemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                                }
                                else if (MemList[index].PBtier == 2)
                                {
                                    double cashBackApp = MemList[index].cashbackregteir2();
                                    Console.WriteLine("Cash-back reward request for membership" + MemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                                }



                                else if (MemList[index].PBspecialOrg == "Military")
                                {
                                    double cashBackApp = NonprofMemList[index].cashbackNonSp();
                                    Console.WriteLine("Cash-back reward request for membership" + NonprofMemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                                }
                                else if (NonprofMemList[index].PBspecialOrg == "Education")
                                {
                                    double cashBackApp = NonprofMemList[index].cashbackNonSp();
                                    Console.WriteLine("Cash-back reward request for membership" + NonprofMemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                                }
                                else if (NonprofMemList[index].PBspecialOrg == "None")
                                {
                                    double cashBackApp = NonprofMemList[index].cashbackNon();
                                    Console.WriteLine("Cash-back reward request for membership" + NonprofMemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");
                                }



                                double cashBackApp = CorpMemList[index].cashbackreg();
                                Console.WriteLine("Cash-back reward request for membership" + CorpMemList[index].PBmembershipID + " in the amount of " + cashBackApp + " has been made.");


                            }
                        }
                    }    
                } while (!(transactionChoiceSt == "Q") && !(transactionChoiceSt == "q")) ;
                       //----------------------END OF A MENU----------------------------\\

            //----------------------------------- END OF TRANSACTION MENU IF STATMENT --------------------------------------------\\

            if (menuTypeChoiceSt == "A" || menuTypeChoiceSt == "a")
                {
                    do
                    {
                        do
                        {
                            //----------------------START OF CHOICE MENU----------------------------\\
                            Console.WriteLine(" C: Create a new membership");
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
                        //----------------------START OF CHOICE MENU----------------------------\\


                        //----------------------START OF C MENU----------------------------\\
                        if (menuChoiceString == "C" || menuChoiceString == "c")
                        {
                            Console.WriteLine("Please enter a new member ID");
                            string? newID = (Console.ReadLine());
                            Console.WriteLine("Please enter new Email");
                            string? NewEmail = Console.ReadLine();
                            Console.WriteLine("Please enter the Account type, account type options are Regular, NonProf, Executive, and Corperate");
                            string? newAccountTy = Console.ReadLine();
                            Console.WriteLine("Please enter the ammount spent this month");
                            double newAmmountMonth = Convert.ToDouble(Console.ReadLine());

                            if (newAccountTy == "Regular")
                            {
                                MemList.Add(new RegularMember(newID, NewEmail, newAccountTy, newAmmountMonth));
                                Console.WriteLine("New Regular member added!");
                            }
                            else if (newAccountTy == "Executive")
                            {
                                double tier = 0;
                                Console.WriteLine("Please enter the teir of the account");
                                tier = Convert.ToDouble(Console.ReadLine());

                                MemList.Add(new ExecutiveMember(newID, NewEmail, newAccountTy, newAmmountMonth, tier));
                                Console.WriteLine("New Executive member added!");
                            }
                            else if (newAccountTy == "NonProf")
                            {
                                string? newOrg;
                                Console.WriteLine("Please enter in if the Org is military or education, if neither type none");
                                newOrg = Console.ReadLine();
                                MemList.Add(new NonProfMember(newID, NewEmail, newAccountTy, newAmmountMonth, newOrg));
                                Console.WriteLine("New NonProf member added!");
                            }
                            else if (newAccountTy == "Corperate")
                            {
                                MemList.Add(new CorperateMember(newID, NewEmail, newAccountTy, newAmmountMonth));
                                Console.WriteLine("New corperate member added!");
                            }
                        }
                        //----------------------END OF C MENU----------------------------\\


                        //----------------------START OF R MENU----------------------------\\
                        if (menuChoiceString == "R" || menuChoiceString == "r")
                        {
                            foreach (MemberShip m in MemList)
                            {
                                Console.WriteLine(m);
                            }
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        //----------------------END OF R MENU----------------------------\\


                        //----------------------START OF U MENU----------------------------\\
                        if (menuChoiceString == "U" || menuChoiceString == "u")
                        {

                            string? idCheck;
                            bool found = false;
                            Console.WriteLine("Please enter the member ID to find the account");
                            idCheck = Console.ReadLine();

                            for (int index = 0; index < MemList.Count; index++)
                            {
                                if ((MemList[index].PBmembershipID == idCheck))
                                {
                                    Console.WriteLine("ID found please enter a char for what you would like to change. Options are as follows");
                                    Console.WriteLine("E: alter the email, AS: Ammount spent this month");
                                    string? alterVal = Console.ReadLine();
                                    if (alterVal == "E" || alterVal == "e")
                                    {
                                        Console.WriteLine("Please enter new email");
                                        MemList[index].PBemailAddress = Console.ReadLine();
                                        found = true;
                                    }

                                    if (alterVal == "AS" || alterVal == "as")
                                    {
                                        Console.WriteLine("Please enter new ammount spent this month");
                                        MemList[index].PBammountThisMonth = Convert.ToDouble(Console.ReadLine());
                                        found = true;
                                    }

                                }


                                // end foreach  
                                if (found)
                                    Console.WriteLine("Record has been updated");
                                else
                                    Console.WriteLine("ID not found no record updated");

                            }

                        }
                        //----------------------END OF U MENU----------------------------\\


                        //----------------------START OF D MENU----------------------------\\
                        if (menuChoiceString == "D" || menuChoiceString == "d")
                        {
                            string? idCheck;
                            bool found = false;
                            bool passwordB = false;
                            string? passwordSt;

                            Console.WriteLine("Welcome to the deletion menu if you would like to delete a member please enter the pasword now: ");
                            passwordSt = Console.ReadLine();
                            if (passwordSt == "8453")
                            {
                                passwordB = true;
                            }

                            else
                            {
                                Console.WriteLine("Invalid password. Exiting now");
                            }

                            if (passwordB)
                            {
                                Console.WriteLine("Please enter the member ID to find the account");
                                idCheck = Console.ReadLine();

                                for (int index = 0; index < MemList.Count; index++)
                                {
                                    if ((MemList[index].PBmembershipID == idCheck))
                                    {
                                        MemList.RemoveAt(index);
                                        found = true;
                                    }
                                }
                                if (found)
                                    Console.WriteLine("Member deleted");
                            }
                            else
                                break;
                        }
                        //----------------------END OF D MENU----------------------------\\ 


                        else
                        {
                            Console.Write("Returning to main menu");
                        }


                    } while (!(menuChoiceString == "Q") && !(menuChoiceString == "q"));



                }//----------------------------------- END OF ADMINISTRATION MENU --------------------------------------------\\



                //----------------------------------- END OF ADMINISTRATION MENU IF STATMENT --------------------------------------------\\


            }// end of main

        } // end of program
    }//end of Namespace 