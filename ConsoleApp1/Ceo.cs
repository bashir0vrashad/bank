namespace ConsoleApp1
{
    internal class Ceo : IAll, IEasy
    {
        private string name;
        private string surname;
        private int age;
        private float salary;
        private string position;

        public Guid Id { get; set; }
        public string Name {
            get { return name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15) { name = value; }
                else throw new ApplicationException("CEO Name Error...");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20) { surname = value; }
                else throw new ApplicationException("CEO Surname Error...");
            }
        }
        public int Age {
            get { return age; }
            set
            {
                if(value >= 18) { age = value; }
                else throw new ApplicationException("CEO Age Error...");
            }
        }
        public float Salary {
            get { return salary; }
            set
            {
                if (value >= 250) { salary = value; }
                else throw new ApplicationException("CEO Salary Error...");
            }
        }
        public string Position {
            get { return position; }
            set
            {
                if (value.Length >= 3) { position = value; }
                else throw new ApplicationException("CEO Position Error...");
            }
        }

        public void Organize()
        {
            Console.WriteLine("Organize from CEO");
        }

        public void Control()
        {
            Console.WriteLine("Control from CEO");
        }

        public void makeMeeting(bool secim)
        {
            if (secim) Console.WriteLine("MakeMeeting from CEO");
            else Console.WriteLine("Isn't MakeMeeting from CEO");
        }

        public void DecreasePercentage(float percent)
        {
            Console.WriteLine($"DecreasePercentage: {percent}");
        }

        public Ceo()
        {
            Id= Guid.NewGuid();
            Name = "Null";
            Surname = "Null ";
            Age = 18;
            Salary = 250;
            Position = "Null";
        }
        public Ceo(string name , string surname , int age ,float salary,string posistion ): this()
        {
            Name= name;
            Surname= surname;
            Age= age;
            Salary = salary;
            Position = posistion;
        }

    }
}
