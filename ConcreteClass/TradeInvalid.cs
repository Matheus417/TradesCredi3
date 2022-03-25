using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCredit.ClassesConretas
{
    class TradeInvalid : AbstractTrade
    {
        public TradeInvalid(string parameters) :
              base(parameters)
        {
        }
        public override bool TestParameters(string parameters)
        {
            return false;
        }
    }
}
