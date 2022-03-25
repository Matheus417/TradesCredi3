using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class Expired : ICategory
    {
        private const int QTDAYSEXPIRED = 30;

        public string ProcessInputData(IDataProcessing InputData)
        {
            if ((InputData.ReferenceDate - InputData.Trade.NextPaymentDate).Days > QTDAYSEXPIRED)
            {
                return "EXPIRED";
            }
            return "";
        }
    }
}
