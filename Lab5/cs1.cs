using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class cs1
    {
        class worker
        {
            private string _PIB { get; set; }
            private string _HPB { get; set; }
            private string _Number { get; set; }
            private string _Email { get; set; }
            private string _Position { get; set; }
            private string _Responsibilities { get; set; }
            private decimal _Salary { get; set; }
            public worker(string _PIB, string _HPB, string _Number, string _Email, string _Position, string _Responsibilities, decimal _Salary)
            {
                this._PIB = _PIB;
                this._HPB = _HPB;
                this._Number = _Number;
                this._Email = _Email;
                this._Position = _Position;
                this._Responsibilities = _Responsibilities;
                this._Salary = _Salary;
            }

            public void SetPib(string _PIB)
            {
                this._PIB = _PIB;
            }
            public string GetPib()
            {
                return this._PIB;
            }
            public void SetHPB(string _HPB)
            {
                this._HPB = _HPB;
            }
            public string GetHPB()
            {
                return this._HPB;
            }
            public void SetNumber(string _Number)
            {
                this._Number = _Number;
            }
            public string GetNumber()
            {
                return this._Number;
            }
            public void SetEmail(string _Email)
            {
                this._Email = _Email;
            }
            public string getEmail()
            {
                return this._Email;
            }
            public void SetPosition(string _Position)
            {
                this._Position = _Position;
            }
            public string GetPosition()
            {
                return this._Position;
            }
            public void SetResponsibilities(string _Responsibilities)
            {
                this._Responsibilities = _Responsibilities;
            }
            public string GetResponsibilities()
            {
                return this._Responsibilities;
            }
            public void SetSalary(decimal _Salary)
            {
                this._Salary = _Salary;
            }
            public decimal GetSalary()
            {
                return this._Salary;
            }
            public void IncreaseSalary(decimal amount)
            {
                this._Salary += amount;
            }
            public void DecreaseSalary(decimal amount)
            {
                this._Salary -= amount;
            }
            public bool Equals(worker other)
            {
                return this._Salary == other._Salary;
            }
            public bool NotEquals(worker other)
            {
                return this._Salary != other._Salary;
            }
            public bool GreaterThan(worker other)
            {
                return this._Salary > other._Salary;
            }
            public bool LessThan(worker other)
            {
                return this._Salary < other._Salary;
            }
            public static worker operator +(worker w, decimal amount)
            {
                w.IncreaseSalary(amount);
                return w;
            }

            public static worker operator -(worker w, decimal amount)
            {
                w.DecreaseSalary(amount);
                return w;
            }

            public static bool operator ==(worker w1, worker w2)
            {
                return w1.Equals(w2);
            }

            public static bool operator !=(worker w1, worker w2)
            {
                return w1.NotEquals(w2);
            }

            public static bool operator >(worker w1, worker w2)
            {
                return w1.GreaterThan(w2);
            }

            public static bool operator <(worker w1, worker w2)
            {
                return w1.LessThan(w2);
            }

            
        }
        public static void task_1()
        {
            worker john = new worker("John Smith", "1987.05.15", "555-1234", "john.smith@email.com", "Manager", "Managing a team", 5000);
            worker jane = new worker("Jane Doe", "1990.1.13", "555-5678", "jane.doe@email.com", "Assistant Manager", "Assisting the manager", 4000);

            Console.WriteLine($"John's  salary: {john.GetSalary()}");
            Console.WriteLine($"Jane's  salary: {jane.GetSalary()}");
            Console.WriteLine(" ");

            john.IncreaseSalary(1000);
            jane.IncreaseSalary(500);

            Console.WriteLine($"John's new salary: {john.GetSalary()}");
            Console.WriteLine($"Jane's new salary: {jane.GetSalary()}");
            Console.WriteLine(" ");

            john.DecreaseSalary(500);
            jane.DecreaseSalary(1000);

            Console.WriteLine($"John's new salary: {john.GetSalary()}");
            Console.WriteLine($"Jane's new salary: {jane.GetSalary()}");
            Console.WriteLine(" ");

            if (john == jane)
            {
                Console.WriteLine("John and Jane have the same salary");

            }
            else
            {
                Console.WriteLine("John and Jane do not have the same salary");
            }
            Console.WriteLine(" ");

            if (john > jane)
            {
                Console.WriteLine("John has a higher salary than Jane");
            }
            else
            {
                Console.WriteLine("John does not have a higher salary than Jane");
            }
            Console.WriteLine(" ");

            if (john < jane)
            {
                Console.WriteLine("John has a lower salary than Jane");
            }
            else
            {
                Console.WriteLine("John does not have a lower salary than Jane");
            }
            Console.WriteLine(" ");

            if (john.Equals(jane))
            {
                Console.WriteLine("John and Jane have the same salary");
            }
            else
            {
                Console.WriteLine("John and Jane do not have the same salary");
            }
            Console.WriteLine(" ");

            if (john.NotEquals(jane))
            {
                Console.WriteLine("John and Jane do not have the same salary");
            }
            else
            {
                Console.WriteLine("John and Jane have the same salary");
            }
            Console.WriteLine(" ");

        }
    }
}
