namespace MemeberShipProg
{
    class ExecutiveMember : MemberShip
    {
        
        public double Cashback1 = .25;
        public double cashBack2 = .5;

        
        public ExecutiveMember() : base()
        {

        }
        public ExecutiveMember(string NewMemID, string NewEmail, string newMemTy, double newAmmountMonth, double newTier) : base(NewMemID, NewEmail, newMemTy, newAmmountMonth)
        {
            PBtier = newTier;
        }

        public string Tostring()
        {
            return base.ToString() + "| MemberID : " + PBmembershipID + "| Member Email Contact : " + PBemailAddress + "| Member type :" + PBmembershipType + "| Tier of executive account " + PBtier + "| Ammount this month" + PBammountThisMonth + "| Ammount this month : " + PBammountThisMonth + "| Annual Fee: " + annualRate;
        }
        public double cashbackregteir1()
        {
            double PBcashBackAmmount = Cashback1 * annualRate;
            return PBcashBackAmmount;
        }
        public double cashbackregteir2()
        {
            double PBcashBackAmmount = cashBack2 * annualRate;
            return PBcashBackAmmount;
        }
    }// end of class regmem
}// end of namespcae 