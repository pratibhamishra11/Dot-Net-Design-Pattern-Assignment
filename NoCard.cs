using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class NoCard : CardInterface
    {
        private readonly int discount;

        public NoCard()
        {
            this.discount = 0;
        }
        public string CardType()
        {
            return "No Card";
        }

        int CardInterface.Discount()
        {
            return this.discount;
        }
    }
}
