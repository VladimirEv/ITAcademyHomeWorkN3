using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Alionka : SweetsParametrs
    {
        public Alionka() : base(5, "Alionka", 1, 2.3, 2.5)
        {
            SweetPosition = 5;
            SweetName = "Alionka";
            SweetWeight = 1;
            SweetSugar = 2.3;
            SweetCostInKg = 2.5;
        }
    }
}
