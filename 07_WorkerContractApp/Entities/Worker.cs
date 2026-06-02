using WorkerContractApp.Entities.Enums;

namespace WorkerContractApp.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        
        public Worker(string name, double baseSalary, WorkerLevel workerLevel, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = workerLevel;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year  && contract.Date.Month == month)
                {
                    income = income + contract.TotalValue();
                }
            }
            return income;
        }
    }
}
