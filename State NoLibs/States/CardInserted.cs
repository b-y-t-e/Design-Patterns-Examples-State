using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class CardInserted : IState
    {
        private readonly ICashMashineContext _context;

        public CardInserted(ICashMashineContext context)
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
            _context.ChangeState(new NoCard(_context));
            Console.WriteLine("Card ejected");
        }

        public void InsertPin(string pin)
        {
            if (pin == _context.CurrentCard.Pin)
            {
                Console.WriteLine("Correct PIN inserted");
                _context.ChangeState(new PinInserted(_context));
            }
            else
            {
                Console.WriteLine("Incorrect PIN inserted");
                Console.WriteLine("Card ejected");
                _context.CurrentCard = null;
                _context.ChangeState(new NoCard(_context));
            }
        }

        public void WithdrawCash(decimal amount)
        {
            Console.WriteLine("Insert PIN first");
        }
    }
}
