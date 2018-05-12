using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private int salary;
        private IEmployee manager;
        public Employee()
        {
            salary = 1000;
        }
        public string getFirstName()
        {
            return firstName;
        }

        public string getFullName()
        {
            return firstName + ' ' + lastName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getManagerName()
        {
            if(manager == null)
            {
                return this.getFullName();
            }
            return manager.getFirstName();
        }

        public IEmployee getTopManager()
        {
            if(manager == null)
            {
                return this;
            }
            return manager.getTopManager();
        }

        public void increaseSalary(int value)
        {
            salary += value;
        }

        public int getSalary()
        {
            return salary;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName; ;
        }

        public void setManager(IEmployee manager)
        {
            this.manager = manager;
        }

    }
}
