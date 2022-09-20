using State_PM.Commands;
using State_PM.Data;
using System.Threading.Tasks;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;

namespace State_PM.CommandHandlers
{
    public class AddCashHandler : IProcessManagerEventHandler<CashMachineData, AddCash>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, AddCash @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, AddCash @event)
        {
            context.Data.AvailableCash += @event.Amount;
        }
    }
}
