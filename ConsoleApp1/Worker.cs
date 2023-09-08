namespace ConsoleApp1
{
    internal class Worker : IAll
    {
        private string name;
        private string surname;
        private int age;
        private float salary;
        private string position;
        private TimeOnly startTime;
        private TimeOnly endTime;
       
        public Guid Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15) { name = value; }
                else throw new ApplicationException("WORKER Name Error...");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20) { surname = value; }
                else throw new ApplicationException("WORKER Surname Error...");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18) { age = value; }
                else throw new ApplicationException("WORKER Age Error...");
            }
        }
        public float Salary
        {
            get { return salary; }
            set
            {
                if (value >= 250) { salary = value; }
                else throw new ApplicationException("WORKER Salary Error...");
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                if (value.Length >= 3) { position = value; }
                else throw new ApplicationException("CEO Position Error...");
            }
        }

        public Worker()
        {
            Id = Guid.NewGuid();
            Name = "Null";
            Surname = "Null ";
            Position = "Null ";
            Age = 18;
            Salary = 250;
            StartTime = new TimeOnly(9, 0, 0);
            EndTime = new TimeOnly(18, 0, 0);
        }
        public Worker(string name, string surname, int age, float salary,string position) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Position= position;
                
        }
    }
}
