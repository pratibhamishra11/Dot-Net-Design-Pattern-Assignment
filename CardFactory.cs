using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class CardFactory
    {
        public static CardInterface getCard(int CardType)
        {
            CardInterface card = null;

            switch (CardType)
            {
                case 1:
                    card = new MembershipCard();
                    break;
                case 2:
                    card = new EmployeeCard();
                    break;
                case 3:
                    card = new NoCard();
                    break;
            }

            return card;
        }
    }
}
