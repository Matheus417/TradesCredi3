using System;
using TesteCredit.Eenumerators;

namespace TesteCredit.ClassesConretas
{
    public abstract class AbstractTrade
    {
        private const int VALUE = 0;
        private const int CLIENTSECTOR = 1;
        private const int NEXTPAYMENTDATE = 2;
        protected double value;
        protected Enuns.Sector clientSector;
        protected DateTime nextPaymentDate;
        protected bool tradeValid;
        protected string[] trades;

        public AbstractTrade(string parameters)
        {
            trades = parameters.Split(Utils.elementsSeparated);
            if (TestParameters(parameters))
            {
                value = double.Parse(trades[VALUE]);

                clientSector = Utils.ImputSector(trades[CLIENTSECTOR]);
                nextPaymentDate = DateTime.Parse(trades[NEXTPAYMENTDATE]);
            }
        }

        public abstract bool TestParameters(string parameters);

        public bool TradeValid
        {
            get
            {
                return tradeValid;
            }
        }
    }
}
