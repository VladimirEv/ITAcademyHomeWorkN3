using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Snickers : SweetsParametrs
    {
        public Snickers() : base(2, "Snickers", 1, 2, 3)
        {
            SweetPosition = 2;
            SweetName = "Snickers";
            SweetWeight = 1;
            SweetSugar = 2;
            SweetCostInKg = 3;
        }
    }
}
