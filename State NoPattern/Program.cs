using State;
using System;

namespace State_NoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card
            {
                ID = Guid.NewGuid(),
                Pin = "1111"
            };

            var context = new CashMashineContext(
                availableCash: 2000);

            context.EjectCard();

            context.InsertCard(card);

            context.InsertPin("8888");

            context.InsertCard(card);

            context.InsertPin("1111");

            context.WithdrawCash(2000);

            context.EjectCard();

        }
    }
}
