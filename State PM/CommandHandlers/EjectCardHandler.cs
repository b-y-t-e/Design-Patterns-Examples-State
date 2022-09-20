using State_PM.Commands;
using State_PM.Data;
using System;
using System.Threading.Tasks;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;

namespace State_PM.CommandHandlers
{
    public class EjectCardHandler : IProcessManagerEventHandler<CashMachineData, EjectCard>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, EjectCard @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, EjectCard @event)
        {
            Console.WriteLine("Card ejected");
            context.Data.CurrentCard = null;
        }
    }
}
