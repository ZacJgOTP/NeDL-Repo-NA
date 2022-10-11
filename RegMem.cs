namespace MemeberShipProg
{
    class RegularMember : MemberShip, AnualCost, PurchaseAmmount
    {
        private double Cashback = 0;

        public double PBCashBack
        {
            get{return Cashback;}
            set{ Cashback = value;}
        }

        public RegularMember(string NewMemID, string NewMemEmail, string newMemTy,double newAmmountMonth ,double newCashback, double newAnnual) : base ( NewMemID, NewMemEmail, newMemTy, newAmmountMonth, newAnnual)
        {
            Cashback = newCashback;
        }


    }// end of class regmem
}// end of namespcae