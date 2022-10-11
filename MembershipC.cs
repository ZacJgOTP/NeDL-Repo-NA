namespace MemeberShipProg
{
    class MemberShip
    {
        private string? membershipID;
        private string? emailAddress;
        private string? membershipType;
        
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
        public MemberShip(string NewMemID, string NewEmail, string newMemTy)
        {
            membershipID = NewMemID;
            emailAddress = NewEmail;
            membershipType = newMemTy;
        }


    }//end of class Membership 
    
}//end of namespace 