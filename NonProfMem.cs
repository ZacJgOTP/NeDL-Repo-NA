namespace MemeberShipProg
{
    class NonProfMember : MemberShip
    {
        public double Cashback = .05;

        private string? specialOrg;
        public string? PBspecialOrg
        {
            get { return specialOrg; }
            set { specialOrg = value; }
        }

        public NonProfMember() : base()
        {

        }
        public NonProfMember(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth, string newOrg) : base(NewMemID, NewEmail, newMemTy, newAmmountMonth)
        {
            specialOrg = newOrg;
        }
        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Special Org: " + PBspecialOrg + "| Ammount this month" + PBammountThisMonth + "| Cash back percentage : " + Cashback + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + annualRate;
        }

        public double cashbackNonSp()
        {
            double PBcashBackAmmount = ((Cashback * PBammountThisMonth)*2);
            return PBcashBackAmmount;
        }
        public double cashbackNon()
        {
            double PBcashBackAmmount = Cashback * PBammountThisMonth;
            return PBcashBackAmmount;
        }

    }// end of class regmem
}// end of namespcae