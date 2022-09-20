using State_PM.CommandHandlers;
using State_PM.Commands;
using State_PM.Data;
using State_PM.States;
using TheProcessManager.Builders;
using TheProcessManager.ModelsProcessManager.Interfaces;

namespace State_PM
{
    public class CashMashinePmBuilder : IProcessManagerModelBuilder<CashMachineData>
    {
        IProcessManagerBuilder<CashMachineData> builder;

        public CashMashinePmBuilder(IProcessManagerBuilder<CashMachineData> builder)
        {
            this.builder = builder;
        }

        public IProcessManagerModel Build()
        {
            builder.
                Name("Bankomat").

                Start<CreateCashMashine>().
                    HandleBy<CreateCashMashineHandler>().
                    TransitionTo<NoCard>().

                During<NoCard>().
                    When<InsertCard>().
                        HandleBy<InsertCardHandler>().
                        TransitionTo<CardInserted>().
                    When<AddCash>().
                        HandleBy<AddCashHandler>().

                During<CardInserted>().
                    When<InsertPin>().
                        HandleBy<InsertPinHandler>().
                        TransitionTo<PinInserted>().
                    When<EjectCard>().
                        HandleBy<EjectCardHandler>().
                        TransitionTo<NoCard>().

                During<PinInserted>().
                    When<WithdrawCash>().
                        HandleBy<WithdrawCashHandler>().
                        TransitionTo<NoCard>().
                    When<EjectCard>().
                        HandleBy<EjectCardHandler>().
                        TransitionTo<NoCard>();

            return builder.Build();
        }
    }
}
