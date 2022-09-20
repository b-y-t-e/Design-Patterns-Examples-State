namespace State.Interfaces
{
    public interface IState
    {
        void InsertCard(Card card);
        void EjectCard();
        void InsertPin(string pin);
        void WithdrawCash(decimal amount);
        void AddCash(decimal amount);
    }
}