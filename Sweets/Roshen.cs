using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Roshen : SweetsParametrs
    {
        public Roshen() : base(6, "Roshen", 1, 2.8, 3.5)
        {
            SweetPosition = 6;
            SweetName = "Roshen";
            SweetWeight = 1;
            SweetSugar = 2.8;
            SweetCostInKg = 3.5;
        }
    }
}
