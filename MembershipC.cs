namespace MemeberShipProg
{
    abstract class MemberShip
    {
        private string? membershipID;
        private string? emailAddress;
        private string? membershipType;
        private double AmmounThisMonth = 0;
        private double annualCost = 0;

        public double PBammountThisMonth
        {
          get{return AmmounThisMonth;}
          set{AmmounThisMonth = value;}
        }
         public double PBannualCost
        {
          get{return annualCost;}
          set{annualCost = value;}
        }
        
        public string? PBmembershipID
        {
          get{return membershipID;}
          set{membershipID = value;}
        }

        public string? PBemailAddress
        {
          get{return emailAddress;}
          set{emailAddress = value;}
        }

        public string? PBmembershipType
        {
          get{return membershipType;}
          set{membershipType = value;}
        }

        public MemberShip()
        {
            membershipID = "";
            emailAddress = "";
            membershipType = "";
        }
        public MemberShip(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth, double newAnnual)
        {
            membershipID = NewMemID;
            emailAddress = NewEmail;
            membershipType = newMemTy;
            AmmounThisMonth = newAmmountMonth;
            annualCost = newAnnual;
        }


    }//end of class Membership 
    
}//end of namespace 