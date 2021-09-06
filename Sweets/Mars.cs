using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskItAcademy.Sweets
{
    public class Mars : SweetsParametrs
    {
        public Mars() : base(1, "Mars", 1, 2, 2)
        {
            SweetPosition = 1;
            SweetName = "Mars";
            SweetWeight = 1;
            SweetSugar = 2;
            SweetCostInKg = 2;
        }
    }
}
