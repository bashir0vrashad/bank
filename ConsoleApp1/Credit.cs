namespace ConsoleApp1
{
    internal class Credit
    {
        private Guid id;
        private float amount;
        private float percent;
        private byte months;
        
        public Guid Id { get; set; }
       
        public float Amount
        {
            get => amount;
            set
            {
                if (value >= 0) amount = value;
                else throw new ApplicationException("Amount Error...");
            }
        }
        public float Percent
        {
            get => percent;
            set
            {
                if (value >= 0  && value <= 100) percent = value;
                else throw new ApplicationException("Percent Error...");
            }
        }
        public byte Months
        {
            get => months;
            set
            {
                if (value >= 0 && value <= 120) months = value;
                else throw new ApplicationException("Months Error...");
            }
        }

        public float calculatePercent()
        {
            return Amount / Percent;
        }
        public bool payment(float mebleg)
        {
            if (this.calculatePercent() >= mebleg) return true;
            else return false;
        }

        public Credit()
        {
            Id = Guid.NewGuid();
            Amount = 0;
            Percent = 0;
            Months = 0;
        }


        public Credit( float amount , byte months,float percent)
        {
            Id = Guid.NewGuid();        
            Amount= amount;
            Percent = percent;
            Months = months;
        }
    }
}
