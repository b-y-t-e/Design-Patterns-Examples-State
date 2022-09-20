using State_PM.Commands;
using State_PM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TheProcessManager.Builders;
using TheProcessManager.Events;
using TheProcessManager.ExecutionContext;
using TheProcessManager.Models.Interfaces;
using TheProcessManager.ModelsProcessManager.Interfaces;

namespace State_PM.CommandHandlers
{

    public class InsertCardHandler : IProcessManagerEventHandler<CashMachineData, InsertCard>
    {
        public async Task Compensate(IExecutionContext<CashMachineData> context, InsertCard @event)
        {

        }

        public async Task Execute(IExecutionContext<CashMachineData> context, InsertCard @event)
        {
            Console.WriteLine("Card inserted");
            context.Data.CurrentCard = @event.Card;
        }
    }
}
