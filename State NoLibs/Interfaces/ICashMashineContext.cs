using State.Interfaces;

namespace State
{
    public interface ICashMashineContext : IContext
    {
        decimal AvailableCash { get; set; }
        Card CurrentCard { get; set; }
    }
}