namespace MemeberShipProg
{
    class RegularMember : MemberShip
    {
        public double Cashback = .05;


        public RegularMember() : base()
        {

        }
        public RegularMember(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth) : base(NewMemID, NewEmail, newMemTy, newAmmountMonth)
        {

        }
        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + Cashback + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + annualRate;
        }

        public double cashbackreg()
        {
            double PBcashBackAmmount = Cashback * annualRate;
            return PBcashBackAmmount;
        }

    }// end of class regmem
}// end of namespcae