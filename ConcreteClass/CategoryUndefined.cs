using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class CategoryUndefined : ICategory
    {
        string ICategory.ProcessInputData(IDataProcessing pDataProcessing)
        {
            return "UNDEFINED";
        }
    }
}
