using System;
using TheProcessManager.Events;

namespace State_PM.Commands
{
    public class InsertPin : IProcessManagerEvent
    {
        public Guid ID { get; set; }
        public String Pin { get; set; }
    }
}
