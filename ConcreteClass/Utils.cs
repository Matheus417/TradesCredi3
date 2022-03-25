using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCredit.Eenumerators;

namespace TesteCredit.ClassesConretas
{
    static class Utils
    {
        public static Enuns.Sector ImputSector(string ws_sector)
        {
            var values = Enum.GetValues(typeof(Enuns.Sector)).Cast<Enuns.Sector>();
            foreach (Enuns.Sector value in values)
            {
                if (value.ToString().ToLower() == ws_sector.ToLower())
                    return value;
            }
            return Enuns.Sector.Indefined;
        }

        public static string elementsSeparated = " ";
    }
}
