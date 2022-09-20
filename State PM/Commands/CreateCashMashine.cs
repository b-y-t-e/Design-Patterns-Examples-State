using System;
using TheProcessManager.Events;

namespace State_PM.Commands
{
    public class CreateCashMashine : IProcessManagerEvent
    {
        public Guid ID { get; set; }
        public decimal AvailableCash { get; set; }
    }
}
