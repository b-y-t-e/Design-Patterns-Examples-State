using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class PinInserted : IState
    {
        private readonly ICashMashineContext _context;

        public PinInserted(ICashMashineContext context)
        {
            _context = context;
        }

        public void AddCash(decimal amount)
        {
            Console.WriteLine("Eject card first");
        }

        public void InsertCard(Card card)
        {
            Console.WriteLine("You have already inserted a card");
        }

        public void EjectCard()
        {
            _context.CurrentCard = null;
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }

        public void InsertPin(string pin)
        {
            Console.WriteLine("You have already inserted correct PIN");
        }

        public void WithdrawCash(decimal amount)
        {
            if (amount > _context.AvailableCash)
            {
                Console.WriteLine("That amount of cash is not available");
            }
            else
            {
                Console.WriteLine($"You have withdraw {amount} from the machine");
            }

            _context.AvailableCash -= amount;
            _context.CurrentCard = null;

            Console.WriteLine("Card ejeceted");
            _context.ChangeState(new NoCard(_context));
        }
    }
}
