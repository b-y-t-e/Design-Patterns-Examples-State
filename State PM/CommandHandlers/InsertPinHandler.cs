using State_PM.Commands;
using System.Net.NetworkInformation;
using System;
using System.Threading.Tasks;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;
using Microsoft.Extensions.Logging;
using State_PM.Data;

namespace State_PM.CommandHandlers
{
    public class InsertPinHandler : IProcessManagerEventHandler<CashMachineData, InsertPin>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, InsertPin @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, InsertPin @event)
        {
            if (@event.Pin != context.Data.CurrentCard.Pin)
                throw new Exception("Incorrect PIN inserted");
         
            Console.WriteLine("Correct PIN inserted");
        }
    }
}
