using State_PM.Commands;
using State_PM.Data;
using System.Threading.Tasks;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;

namespace State_PM.CommandHandlers
{
    public class CreateCashMashineHandler : IProcessManagerEventHandler<CashMachineData, CreateCashMashine>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, CreateCashMashine @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, CreateCashMashine @event)
        {
            context.Data.AvailableCash = @event.AvailableCash;
        }
    }
}
