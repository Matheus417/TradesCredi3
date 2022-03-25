using System;
using TesteCredit.Eenumerators;
using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class Trade : AbstractTrade, ITrade
    {
        public Trade(string parameters) :
           base(parameters)
        {
        }
        public double Value
        {
            get
            {
                return base.value;
            }
        }

        public Enuns.Sector ClientSector
        {
            get
            {
                return base.clientSector;
            }
        }

        public DateTime NextPaymentDate
        {
            get
            {
                return base.nextPaymentDate;
            }
        }

        public override bool TestParameters(string parameters)
        {
            tradeValid = Validations.validTrade(parameters);
            return tradeValid;
        }
    }
}
