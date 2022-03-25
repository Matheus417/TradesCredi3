using System;
using TesteCredit.Eenumerators;

namespace TesteCredit.Interfaces
{
    interface ITrade
    {
        double Value { get; } //indicates the transaction amount in dollars
        Enuns.Sector ClientSector { get; } //indicates the client´s sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; } //indicates when the next payment from the client to the bank is expected                                          
    }
}
