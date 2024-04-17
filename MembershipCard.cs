using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class MembershipCard : CardInterface
    {
        private readonly int discount;

        public MembershipCard()
        {
            this.discount = 10;
        }
        public string CardType()
        {
            return "Membership Card";
        }

        int CardInterface.Discount()
        {
            return this.discount;
        }
    }
}
