namespace ConsoleApp1
{
    internal class Client:IAll
    {
        private string name;
        private string surname;
        private int age;
        private float salary;
        private string work_address;
        private string live_address;
        //private Client kredit;

       
        public Guid Id { get; set; }
        public Credit Kredit { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15) { name = value; }
                else throw new ApplicationException("CLIENT Name Error...");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20) { surname = value; }
                else throw new ApplicationException("CLIENT Surname Error...");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18) { age = value; }
                else throw new ApplicationException("CLIENT Age Error...");
            }
        }
        public float Salary
        {
            get { return salary; }
            set
            {
                if (value >= 250) { salary = value; }
                else throw new ApplicationException("CLIENT Salary Error...");
            }
        }

        public string Live_Address
        {
            get { return live_address; }
            set
            {
                if ( value.Length >= 10) { live_address = value; }
                else throw new ApplicationException("CLIENT Live Address Error...");
            }
        }
        public string Work_Address
        {
            get { return work_address; }
            set
            {
                if (value.Length >= 10) { work_address = value; }
                else throw new ApplicationException("CLIENT Work Address Error...");
            }
        }

        public Client()
        {
            Id = Guid.NewGuid();
            Name = "Null";
            Surname = "Null ";
            Age = 18;
            Salary = 250;
            Kredit = new Credit();
            
        }
        public Client(string name, string surname, int age, float salary, string live_address , string work_address, Credit c1) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Live_Address = live_address;
            Work_Address = work_address;
            Kredit= c1;
          
        }

    }
}
