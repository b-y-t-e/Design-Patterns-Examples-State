using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using State.Interfaces;
using State.States;

namespace State
{
    public class CashMashineContext : ICashMashineContext
    {
        public decimal AvailableCash { get; set; }

        public Card CurrentCard { get; set; }

        //////////////////////////////

        IState _currentState;
        public CashMashineContext(int availableCash)
        {
            AvailableCash = availableCash;
            _currentState = new NoCard(this);
        }

        //////////////////////////////

        public void ChangeState(IState newState)
        {
            _currentState = newState;
        }

        public void AddCash(decimal amount)
        {
            _currentState.AddCash(amount);
        }


        public void InsertCard(Card card)
        {
            _currentState.InsertCard(card);
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void InsertPin(string pin)
        {
            _currentState.InsertPin(pin);
        }

        public void WithdrawCash(decimal amount)
        {
            _currentState.WithdrawCash(amount);
        }
    }
}
