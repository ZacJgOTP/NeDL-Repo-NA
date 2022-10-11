namespace MemeberShipProg
{
    class RegularMember : MemberShip, AnualCost, PurchaseAmmount
    {
        public double Cashback = .25;

        public RegularMember(string NewMemID, string NewEmail, string newMemTy) : base (NewMemID,NewEmail,newMemTy)
        {
            
        }
        
    }// end of class regmem
}// end of namespcae