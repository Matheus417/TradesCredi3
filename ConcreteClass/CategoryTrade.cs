using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    class CategoryTrade
    {
        public string ProcessCategoryTrade(IDataProcessing InputData, List<ICategory> ListCategories)
        {
            string ws_return = "";
            foreach (ICategory Category in ListCategories)
            {
                ws_return = Category.ProcessInputData(InputData);
                if (ws_return != "")
                    break;
            }
            return ws_return;
        }
    }
}
