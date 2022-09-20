using System;
using TheProcessManager.Models.Interfaces;

namespace State_PM.Data
{
    public class CashMachineData : IProcessManagerData
    {
        public Guid ID { get; set; }
        public decimal AvailableCash { get; set; }
        public Card CurrentCard { get; set; }
    }
}
