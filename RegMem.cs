namespace MemeberShipProg
{
    class RegularMember : MemberShip, ICashback
    {
        public double Cashback = .05;


        public double newCashback()
        {
            return annualRate;
        }
        public RegularMember() : base()
        {

        }
        public RegularMember(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth) : base(NewMemID, NewEmail, newMemTy, newAmmountMonth)
        {

        }
        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + newCashback() + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + annualRate;
        }

    }// end of class regmem
}// end of namespcae