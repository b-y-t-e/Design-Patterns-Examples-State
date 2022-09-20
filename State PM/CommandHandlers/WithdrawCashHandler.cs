using State_PM.Commands;
using State_PM.Data;
using System;
using System.Threading.Tasks;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;

namespace State_PM.CommandHandlers
{
    public class WithdrawCashHandler : IProcessManagerEventHandler<CashMachineData, WithdrawCash>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, WithdrawCash @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, WithdrawCash @event)
        {
            if (@event.Amount > context.Data.AvailableCash)
                throw new Exception("That amount of cash is not available");

            context.Data.AvailableCash -= @event.Amount;
            Console.WriteLine($"You have withdraw {@event.Amount} from the machine");
        }
    }
}
