using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Worker
    {
        string workerFirstName;
        string workerLastName;
        double workerSalary;

        public Worker (string workerFirstName, string workerLastName, double workerSalary)
        {
            this.workerFirstName = workerFirstName;
            this.workerLastName = workerLastName;
            this.workerSalary = workerSalary;
        }
        public void SetWorkerFirstName(string workerFirstName) 
        {
            this.workerFirstName = workerFirstName;
        }
        public void SetWorkerLastName(string workerLastName)
        {
            this.workerLastName = workerLastName;
        }
        public void SetWorkerSalary(double workerSalary)
        {
            this.workerSalary = workerSalary;
        }
        public string GetWorkerFullName()
        {
            return $"{workerFirstName} {workerLastName}";
        }
        public string GetWorkerFirstName()
        {
            return workerFirstName;
        }
        public string GetWorkerLastName() 
        {
            return workerLastName;
        }
        public double GetWorkerSallary()
        {
            return workerSalary;
        }
            
    }
}
