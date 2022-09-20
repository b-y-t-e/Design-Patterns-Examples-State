// See https://aka.ms/new-console-template for more information
using State_PM;
using Stateless;

Console.WriteLine("Hello, World!");

var call = new StateMachine<CashMashineStates, CashMashineCommands>
    (CashMashineStates.NoCard);

call.Configure(CashMashineStates.NoCard)
    .Permit(CashMashineCommands.InsertCard, CashMashineStates.CardInserted)
    .Permit(CashMashineCommands.AddCash, CashMashineStates.NoCard);

call.Configure(CashMashineStates.NoCard)
    .Permit(CashMashineCommands.PlacedOnHook, CashMashineStates.OffHook)
    .Permit(CashMashineCommands.CallConnected, CashMashineStates.Connected);

call.Configure(CashMashineStates.Connected)
    .Permit(CashMashineCommands.LeftMessage, CashMashineStates.Connected)
    .Permit(CashMashineCommands.PlacedOnHook, CashMashineStates.OffHook)
    .Permit(CashMashineCommands.TakenOffHold, CashMashineStates.OnHook);

call.Fire(CashMashineCommands.CallDialed); 