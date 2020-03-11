namespace heistTwo
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardSore { get; set; }

        public bool IsSecure
        {
            get
            {
                if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardSore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

    }
}