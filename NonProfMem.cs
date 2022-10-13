namespace MemeberShipProg
{
    class NonProfMember : MemberShip,IAnnual,ICashback
    {
        public double Cashback = .1;
        

       /*  public double PBCashBack
        {
            get { return Cashback; }
            set { Cashback = value; }
        }
        public RegularMember(string NewMemID, string NewMemEmail, string newMemTy, double newAmmountMonth, double newCashback) : base(NewMemID, NewMemEmail, newMemTy, newAmmountMonth)
        {
            Cashback = newCashback;
        } */
        public double anRate()
        {
            return annualRate;
        }
        public double newCashback()
        {
            return annualRate;
        }

        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + newCashback() + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + anRate();
        }

    }// end of class regmem
}// end of namespcae