namespace ConsoleApp1
{
    internal class Bank
    {
        private string name;
        private decimal budget;
        private decimal profit;
        
        public Ceo Bank_Ceo { get; set; }
        public List<Worker> workers { get; set; }
        public List <Manager> managers { get; set; }
        public List<Client> clients { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 25) { name = value; }
                else throw new ApplicationException("BANK Name Error...");
            }
        }

        public decimal Budget
        {
            get { return budget; }
            set
            {
                if (value >= 0) { budget = value; }
                else throw new ApplicationException("BUDGET Error...");
            }
        }
        public decimal Profit { get; set; }


        public void showAllCredit()
        {
            for (int i = 0; i < this.clients.Count; i++)
            {
                Console.WriteLine($"{this.clients[i].Name}  {this.clients[i].Surname}  --  {this.clients[i].Kredit.Amount}");
            }
        }


        public Bank()
        {
            name = "Null";
            Budget = 1000000;
            Profit = 0;
            Bank_Ceo = null;
            workers = new List<Worker>();
            managers = new List<Manager>();
            clients = new List<Client>();
        }

        public Bank(string name , decimal budget,decimal profit,Ceo ceo , List<Worker> workers , List<Manager> managers , List<Client> clients)
        {
            Name= name;
            Budget= budget;
            Profit = profit;
            this.Bank_Ceo= ceo;
            this.workers = workers;
            this.clients = clients;
            this.managers= managers;          
        }

    }
}
