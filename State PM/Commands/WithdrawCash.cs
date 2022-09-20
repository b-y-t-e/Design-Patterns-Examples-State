using System;
using TheProcessManager.Events;

namespace State_PM.Commands
{
    public class WithdrawCash : IProcessManagerEvent
    {
        public Guid ID { get; set; }
        public decimal Amount { get; set; }
    }
}
