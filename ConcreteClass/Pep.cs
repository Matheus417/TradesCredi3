using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class Pep : ICategory
    {
        public string ProcessInputData(IDataProcessing InputData)
        {
            if (InputData.Trade is ItradeExposed)
            {
                ItradeExposed wItradeExposed = (ItradeExposed)InputData.Trade;
                if (wItradeExposed.IsPoliticallyExposed)
                {
                    return "ISPOLITICALEXPOSED";
                }
            }
            return "";
        }
    }
}
