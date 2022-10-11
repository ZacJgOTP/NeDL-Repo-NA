/* namespace MemeberShipProg
{
    class ExecutiveMember : MemberShip
    {
        private double tier = 0;

        public double PBTier
        {
            get { return tier; }
            set { tier = value; }
        }
        public RegularMember(string NewMemID, string NewMemEmail, string newMemTy, double newAmmountMonth, double newCashback, double newAnnual) : base(NewMemID, NewMemEmail, newMemTy, newAmmountMonth, newAnnual, newAmmountMonth)
        {
            tier = newCashback;
        }

        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + PBCashBack + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + PBannualCost;
        }

    }// end of class regmem
}// end of namespcae */