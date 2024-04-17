using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class EmployeeCard : CardInterface
    {
        private readonly int discount;

        public EmployeeCard()
        {
            this.discount = 20;
        }
        public string CardType()
        {
            return "Employee Card";
        }

        int CardInterface.Discount()
        {
            return this.discount;
        }
    }
}
