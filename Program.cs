using System;

namespace MemeberShipProg
{
    class Program
    {
    static void Main(string [] args)
    {   
        bool bMenuChoice = false;
        string? menuChoiceString;
        do
        {
            do
            {
        
                Console.WriteLine("C: Create a new membership");
                Console.WriteLine("R: Read the list of members and displays them");
                Console.WriteLine("U: Update the information on a member");
                Console.WriteLine("D: Delete a member from the list");
                Console.WriteLine("Q: Quit the application");

                menuChoiceString=Console.ReadLine();

                bMenuChoice = (menuChoiceString == "C" || menuChoiceString == "c"||
                menuChoiceString == "R" || menuChoiceString == "r"||
                menuChoiceString == "U" || menuChoiceString == "u"||
                menuChoiceString == "D" || menuChoiceString == "d"||
                menuChoiceString == "Q" || menuChoiceString == "q");
                
                if(!bMenuChoice)
                {
                    Console.WriteLine("Invalid selection please enter valid character");
                }

            }while(!bMenuChoice);

            if(menuChoiceString == "C" || menuChoiceString =="c")
            {
                // C logic
            }
             if(menuChoiceString == "R" || menuChoiceString =="r")
            {
                // R logic
            }
             if(menuChoiceString == "U" || menuChoiceString =="u")
            {
                // U logic
            }
             if(menuChoiceString == "D" || menuChoiceString =="d")
            {
                // D logic
            }
            else
            {
                Console.Write("Thank you for using the membership program");
            }
            

        }while(!(menuChoiceString == "Q") && (menuChoiceString == "q")); // end of main do loop 

    }// end of main 

    }// end of program

}//end of Namespace 