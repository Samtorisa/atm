using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp
{
    public class Person
    {
        private int id;
        private string name { get;set; }
        private string surName;
        private double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SurName { 
        get { return surName; }
        set { surName = value; }
        }
        
        public double Balance {
            get { return balance; }
            set { balance = value; }
        }

        public Person()
        {
            this.id = 0;
            this.name = "";
            this.surName = "";
            this.balance = 0;

        }

        public Person(int id,string name,string surName ,double balance)  { 
            this.id = id;   
            this.name = name;
            this.surName = surName;
            this.balance = balance;

        }
        public void addMoney(double amount)
        {
            if (amount < 0) {
                throw new ArgumentException("The amount cant less than zero");
                    }
            this.balance += amount;
        }

        public void withDrawMoney(double amount) 
        {
            if(amount<0 || this.balance < amount)
            {
                throw new ArgumentException("The amount  cant  less than the balance or amount cant less than zero");
            }
            this.balance -= amount;
        }
        public  void AddNewPerson(List<Person> persons, Person person)
        {
            int newId = persons.Any() ? persons.Max(p => p.Id) + 1 : 1; 
            person.Id = newId;
            persons.Add(person);
        }


    }
}
