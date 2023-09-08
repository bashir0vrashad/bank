using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Operation
    {
        private Guid id;
        private string process_name;
        private DateTime datetime;

        public Guid Id { get; set; }
        public DateTime Date_Time { get; set; }
        public string Process_Name
        {
            get { return process_name; }
            set
            {
                if (value.Length >= 55) { process_name = value; }
                else throw new ApplicationException("Process Name Error...");
            }
        }
        public Operation()
        {
            Id = Guid.NewGuid();
            Date_Time = DateTime.Now;
            Process_Name = "NULL ";
        }
        public Operation(string process) : this()
        {
            Process_Name =process;
        }
    }
}
