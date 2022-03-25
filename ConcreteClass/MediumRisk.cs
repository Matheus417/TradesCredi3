using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCredit.Eenumerators;
using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class MediumRisk : ICategory
    {
        private const double AMOUNTLIMIT = 1000000;
        private Enuns.Sector SECTOR = Enuns.Sector.Public ;

        public string ProcessInputData(IDataProcessing InputData)
        {
            if ((InputData.Trade.Value > AMOUNTLIMIT) && (InputData.Trade.ClientSector == SECTOR))
            {
                return "MEDIUMRISK";
            }
            return "";
        }
    }
}
