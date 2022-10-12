namespace MemeberShipProg
{
    class ExecutiveMember : MemberShip, ICashback, IAnnual
    {
        private double tier = 0;
        public double Cashback = .05;
        public double annualRate1 = 900;
        public double PBTier
        {
            get { return tier; }
            set { tier = value; }
        }
        public ExecutiveMember(string NewMemID, string NewMemEmail, string newMemTy, double newAmmountMonth, double newCashback, double newTier) : base(NewMemID, NewMemEmail, newMemTy, newAmmountMonth)
        {
            tier = newTier;
        }
        public double anRate()
        {
            return annualRate1;
        }
        public double newCashback()
        {
            return Cashback;
        }

        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType +  "| Tier of Exec account: "+tier+ "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + newCashback() + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + annualRate1;
        }

    }// end of class regmem
}// end of namespcae 