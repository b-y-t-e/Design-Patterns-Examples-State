using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Interfaces;

namespace State.States
{
    public class NoCard : IState
    {
        private readonly ICashMashineContext _context;

        public NoCard(ICashMashineContext context)
        {
            this._context = context;
        }

        public void AddCash(decimal amount)
        {
            _context.AvailableCash += amount;
            Console.WriteLine("Cash added to cash machine");
        }

        public void InsertCard(Card card)
        {
            _context.CurrentCard = card;
            _context.ChangeState(new CardInserted(_context));
            Console.WriteLine("Card inserted");
        }

        public void EjectCard()
        {
            Console.WriteLine("No card inserted yet");
        }

        public void InsertPin(string pin)
        {
            Console.WriteLine("No card inserted yet");
        }

        public void WithdrawCash(decimal amount)
        {
            Console.WriteLine("No card inserted yet");
        }
    }
}
