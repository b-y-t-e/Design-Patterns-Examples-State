using State.Interfaces;

namespace State
{

    public interface IContext
    {
        void ChangeState(IState newState);
    }
}