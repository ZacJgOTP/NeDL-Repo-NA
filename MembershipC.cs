namespace MemeberShipProg
{
    abstract class MemberShip
    {
        private string? membershipID;
        private string? emailAddress;
        private string? membershipType;
        private double AmmounThisMonth = 0;


        public double PBammountThisMonth
        {
            get { return AmmounThisMonth; }
            set { AmmounThisMonth = value; }
        }

        public string? PBmembershipID
        {
            get { return membershipID; }
            set { membershipID = value; }
        }

        public string? PBemailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string? PBmembershipType
        {
            get { return membershipType; }
            set { membershipType = value; }
        }

        public MemberShip()
        {
            membershipID = "";
            emailAddress = "";
            membershipType = "";
        }
        public MemberShip(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth)
        {
            membershipID = NewMemID;
            emailAddress = NewEmail;
            membershipType = newMemTy;
            AmmounThisMonth = newAmmountMonth;

        }
        public void MemberShipPruchase(double NewAmmountMonth, double userAmmount)
        {

            AmmounThisMonth = purchase(userAmmount, NewAmmountMonth);
            Console.WriteLine("transaction successful new account balance = " + AmmounThisMonth);

        }
        public void MemberShipReturn(double NewAmmountMonth, double userAmmount)
        {

            AmmounThisMonth = returns(userAmmount, NewAmmountMonth);
            Console.WriteLine("transaction successful new account balance = " + AmmounThisMonth);

        }
        public static double purchase(double PurcPrice, double AmmounThisMonth)
        {
            double Total = PurcPrice + AmmounThisMonth;
            return Total;
        }
        public static double returns(double PurcPrice, double AmmounThisMonth)
        {
            double TotalReturn = AmmounThisMonth - PurcPrice;
            return TotalReturn;
        }




    }//end of class Membership 

}//end of namespace 