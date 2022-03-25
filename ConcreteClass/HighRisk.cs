using TesteCredit.Eenumerators;
using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class HighRisk : ICategory
    {
        private const double AMOUNTLIMIT = 1000000;
        private const Enuns.Sector SECTOR = Enuns.Sector.Private;

        public string ProcessInputData(IDataProcessing InputData)
        {
            if ((InputData.Trade.Value > AMOUNTLIMIT) && (InputData.Trade.ClientSector == SECTOR))
            {
                return "HIGHRISK";
            }
            return "";
        }
    }
}
