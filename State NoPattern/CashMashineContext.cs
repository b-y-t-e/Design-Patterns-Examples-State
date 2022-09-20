using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace State
{
    public class CashMashineContext
    {
        string currentState;
        //////////////////////////////
        decimal availableCash;
        Card currentCard;
        //////////////////////////////

        public CashMashineContext(decimal availableCash)
        {
            this.availableCash = availableCash;
            this.currentState = "no card";
        }

        //////////////////////////////

        public void InsertCard(Card card)
        {
            switch (currentState)
            {
                case ("no card"):
                    Console.WriteLine("Card inserted");
                    currentCard = card;
                    currentState = "card inserted";
                    break;

                case ("card inserted"):
                    Console.WriteLine("You have already inserted a card");
                    break;

                case ("pin inserted"):
                    Console.WriteLine("You have already inserted a card");
                    break;
            }
        }

        public void AddCash(decimal amount)
        {
            switch (currentState)
            {
                case ("no card"):
                    availableCash += amount;
                    Console.WriteLine("Cash added to cash machine");
                    break;

                case ("card inserted"):
                    Console.WriteLine("Eject card first");
                    break;

                case ("pin inserted"):
                    Console.WriteLine("Eject card first");
                    break;
            }
        }

        public void EjectCard()
        {
            switch (currentState)
            {
                case ("no card"):
                    Console.WriteLine("No card inserted yet");
                    break;

                case ("card inserted"):
                    Console.WriteLine("Card ejected");
                    currentCard = null;
                    currentState = "no card";
                    break;

                case ("pin inserted"):
                    Console.WriteLine("Card ejected");
                    currentCard = null;
                    currentState = "no card";
                    break;
            }
        }

        public void InsertPin(string pin)
        {
            switch (currentState)
            {
                case ("no card"):
                    Console.WriteLine("No card inserted yet");
                    break;

                case ("card inserted"):
                    if (pin == currentCard.Pin)
                    {
                        Console.WriteLine("Correct PIN inserted");
                        currentState = "pin inserted";
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN inserted");
                        Console.WriteLine("Card ejected");
                        currentCard = null;
                        currentState = "no card";
                    }
                    break;

                case ("pin inserted"):
                    Console.WriteLine("You have already inserted correct PIN");
                    break;
            }
        }

        public void WithdrawCash(decimal amount)
        {
            switch (currentState)
            {
                case ("no card"):
                    Console.WriteLine("No card inserted yet");
                    break;

                case ("card inserted"):
                    Console.WriteLine("Insert PIN first");
                    break;

                case ("pin inserted"):
                    if (amount > availableCash)
                    {
                        Console.WriteLine("That amount of cash is not available");
                    }
                    else
                    {
                        Console.WriteLine($"You have withdraw {amount} from the machine");
                        availableCash -= amount;
                    }
                    Console.WriteLine("Card ejeceted");
                    currentCard = null;
                    currentState = "no card";
                    break;
            }
        }


    }
}
